using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HMSLogin
{
    /*
     * This form is for viewing/adding/updating a single doctor
     */
    public partial class frmDoctor : Form
    {
        DoctorDAO dao = new DoctorDAO();            // create DAO for adding or updating a doctor
        bool isNewDoctor = false;                   // indicate if viewing an existing doctor, or creating a new doctor
        Doctor formDoctor;                          // doctor object for this form
        byte[] photo = null;                        // create a byte array to store the photo
        bool pictureChanged = false;                // indicator for whether the photo was updated or not
        DoctorSearchForm saveSearchForm = null;     // search form which we used to get here
        /*
         * form constructor which populates the gender combo box and buttons with text.
         * It also populates the text boxes and picturebox if an existing doctor is being viewed
         */
        public frmDoctor(Doctor doc, DoctorSearchForm dsForm)
        {
            InitializeComponent();
            saveSearchForm = dsForm;
            cboGender.Items.Add("male");
            cboGender.Items.Add("female");
            if (doc == null)                        // if adding a new doctor
            {
                isNewDoctor = true;                 // indicate creating a new doctor (not updating an existing doctor)
                btnCancel.Text = "Cancel Add";
                btnUpdate.Text = "Add New Doctor";
                btnDelete.Visible = false;          // remove the "Delete doctor" button
            }
            else                                    // if viewing a doctor that alreay exists in the database,
            {                                       // then populate the form fields with the doctor details.
                lblID.Text = doc.DocId.ToString();
                txtSurname.Text = doc.DocSurname;
                txtFirstname.Text = doc.DocForename;
                if (doc.DocGender)                  // if DocGender is 'true' select the first index in combobox
                    cboGender.SelectedIndex = 0;
                else                                // else, select the second index
                    cboGender.SelectedIndex = 1;
                txtDeptID.Text = doc.DeptId.ToString();
                txtAddress.Text = doc.DocAddress;
                txtQualifications.Text = doc.DocQualification;
                txtPhone.Text = doc.DocPhoneNumber;
                if (doc.DocPhoto != null)           // only populate picturebox if a photo is present
                    pictureBox1.Image = Image.FromStream(new MemoryStream(doc.DocPhoto));

            }
            formDoctor = doc;                       // assign the input doctor object to this form
        }
        /*
         *  The update (or Add new doctor) button is at the bottom of the form
         */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Make sure no text boxes are empty. display an error message if any textbox is empty
            if (txtSurname.Text == String.Empty || txtFirstname.Text == String.Empty || txtDeptID.Text == String.Empty || cboGender.Text == string.Empty ||
                txtAddress.Text == string.Empty || txtPhone.Text == String.Empty || txtQualifications.Text == String.Empty)
                MessageBox.Show("Must enter values for Surame, first name, gender, Deparment ID, Address, phone and Qualifications.", "Fill out all text boxes");
            else
            {
                bool gender = false;                                // populate gender variable
                if (cboGender.SelectedIndex == 0)                   // if first gender selected
                    gender = true;                                  // change the gender variable
                // The TryParse method takes two parameters.  The first a String to convert into the specified type
                // The second an out parameter to store the converted value into
                // If successful, it will return true and the number will be stored in the out parameter
                // If unsuccessful, it will return false and store 0 in the out parameter
                if (int.TryParse(txtDeptID.Text, out int deptID))    // convert the text in the department ID textbox to an integer variable
                {
                    /*
                     *  if adding a new doctor, create a doctor object from the supplied information (in textboxes, combobox and picturbox)
                     *  and pass to the insertDoctor method of the DAO, which adds a new doctor to the database.
                     */
                    if (isNewDoctor)                            // if adding a new doctor
                    {
                        bool success = dao.searchDepartment(deptID);
                        if (!success)
                        {
                            MessageBox.Show($"Error: Entered department ID ({deptID}) not in Department table\n\ncannot add new doctor", "Error on Department ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDeptID.Focus();
                            txtDeptID.SelectAll();
                        }
                        else
                        {
                            formDoctor = new Doctor
                            {
                                DocForename = txtFirstname.Text,
                                DocSurname = txtSurname.Text,
                                DocPhoto = photo,
                                DocGender = gender,
                                DocAddress = txtAddress.Text,
                                DocPhoneNumber = txtPhone.Text,
                                DocQualification = txtQualifications.Text,
                                DeptId = deptID
                            };
                            //
                            // pass the Doctor object to the DoctorDAO class to insert into the database
                            //
                            success = dao.insertDoctor(formDoctor, out int newID);      // newID will hold the new ID of the newly inserted doctor
                            if (success)
                            {
                                lblID.Text = newID.ToString();              // populate the doctor ID label with the new ID
                                MessageBox.Show("ID assigned to the new doctor is " + newID.ToString(), "New Doctor added successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                isNewDoctor = false;                        // no longer adding a new doctor
                                btnUpdate.Text = "Update details";          // update text on update button 
                                btnCancel.Text = "Return to Search Form";   // update text on cancel button
                                btnDelete.Visible = true;                   // show the "Delete doctor" button
                            }
                            else                    // doctor was not added successfully
                            {
                                MessageBox.Show("Insert of new Doctor failed", "Insert failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                    }
                    /*
                     * if updating an existing doctor create a Doctor object from the textbox fields and use the doctor DAO
                     * to update the database for the doctor ID.
                     */
                    else if (int.TryParse(lblID.Text, out int docID))    // convert the ID in the doctor ID label to an integer variable
                    {
                        string docGender;                   // variable to compare with combobox text field
                        if (formDoctor.DocGender)
                            docGender = "male";
                        else
                            docGender = "female";
                        //  first check if any of the information in the textboxes/comboboxes have changed....
                        if (txtSurname.Text != formDoctor.DocSurname || txtFirstname.Text != formDoctor.DocForename || cboGender.Text != docGender ||
                            txtAddress.Text != formDoctor.DocAddress || txtPhone.Text != formDoctor.DocPhoneNumber || txtQualifications.Text != formDoctor.DocQualification ||
                            txtDeptID.Text != formDoctor.DeptId.ToString() || pictureChanged)
                        {
                            // The TryParse method takes two parameters.  The first a String to convert into the specified type
                            // The second an out parameter to store the converted value into
                            // If successful, it will return true and the number will be stored in the out parameter
                            // If unsuccessful, it will return false and store 0 in the out parameter

                            Doctor currentDoctor = new Doctor();                    // create doctor object which will ...
                            currentDoctor.DocId = int.Parse(lblID.Text);            //    ... overwrite the doctor with same ID in the database
                            currentDoctor.DocForename = txtFirstname.Text;
                            currentDoctor.DocSurname = txtSurname.Text;
                            currentDoctor.DocPhoto = photo;
                            currentDoctor.DocAddress = txtAddress.Text;
                            currentDoctor.DocPhoneNumber = txtPhone.Text;
                            currentDoctor.DocQualification = txtQualifications.Text;
                            currentDoctor.DeptId = deptID;
                            if (cboGender.Text == "male")                           // convert gender from 'male' or 'female' ...
                                currentDoctor.DocGender = true;                     //      ... to 'true' or 'false'
                            else
                                currentDoctor.DocGender = false;
                            if (dao.updateDoctor(currentDoctor))                    // use updateDoctor method in the DAO to update the doctor
                            {                                                       //     in the database
                                MessageBox.Show("Details for doctor: " + lblID.Text + "\nsuccessfully updated", "Doctor details updated",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                btnCancel.Text = "Return to Search";
                                formDoctor = currentDoctor;                         // update the details of the doctor shown by this form
                            }
                            else                            // return error message if an error in updating the database
                                MessageBox.Show("Error on updating the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else                    // if no change was made, then return an error message
                        {
                            MessageBox.Show("Could not update, no change was made to the doctor details.", "Must update fields",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else                            // problem with doctor ID, return an error message
                    {
                        MessageBox.Show("Doctor ID not in numeric format", "Invalid Doctor ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        lblDocID.Focus();
                    }
                }
                else                                // the department ID textbox was not an integer, return an error message
                {
                    MessageBox.Show("Department ID not in numeric format", "Invalid Department ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtDeptID.Focus();
                    txtDeptID.SelectAll();
                }
            }
        }
        /*
         *  If the cancel button is clicked, then dispose this form and display a new Search form
         */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();                 // dispose of this Doctor form
            if (saveSearchForm == null)
                saveSearchForm = new DoctorSearchForm();
            saveSearchForm.Show();              // display the search form
        }
        /*
         *  If the delete button is clicked, then delete the currently displayed doctor
         */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete doctor ID ","Delete Doctor?",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (int.TryParse(lblID.Text, out int docID))    // convert the ID in the doctor ID label to an integer variable
                {
                    bool success = dao.deleteDoctor(docID);     // newID will hold the new ID of the newly inserted doctor
                    if (success)
                    {
                        MessageBox.Show($"Doctor ID {docID} deleted from the database", "Doctor successfully deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        btnCancel_Click(sender, e);             // return to the Search form
                    }
                    else                    // doctor was not deleted successfully
                    {
                        MessageBox.Show($"Error: Delete of Doctor ID {docID} failed", "Delete failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                } else
                {
                    MessageBox.Show("Doctor ID not in numeric format", "Invalid Doctor ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    lblDocID.Focus();
                }
            } else
            {
                MessageBox.Show("Delete of doctor cancelled", "Doctor not deleted",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        /*
         *  if double-click the picturebox, then allow uploading of an image for the Doctor
         */
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();                 // create file open dialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)    // if the Dialog has finished...
            {
                try
                {
                    Stream inputStream = openFileDialog1.OpenFile();        // open the supplied file and store in Stream variable
                    using (var memoryStream = new MemoryStream())
                    {
                        inputStream.CopyTo(memoryStream);                   // copy the Stream to a MemoryStream variable
                        photo = memoryStream.ToArray();                     // convert the memoryStream to a byte array and store in photo variable
                        pictureBox1.Image = Image.FromStream(memoryStream);     // convert the memoryStream to an image and store in pictureBox
                        pictureChanged = true;                              // indicate that the picture was updated.
                    }
                }
                catch (Exception ex1)                                       // if any error opening the file, display error message
                {
                    MessageBox.Show($"Error opening the file.\n\n\nError message: {ex1.Message}", "Error opening file",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Console.WriteLine($"\n\nError opening the file.\n\n Error message: \n{ex1.Message}\n\nDetails: \n{ex1.StackTrace}\n\n\n");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void lblID_Click(object sender, EventArgs e)
        {
        }


    }
}
