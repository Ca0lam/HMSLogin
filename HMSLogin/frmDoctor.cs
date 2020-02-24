using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSLogin
{
    public partial class frmDoctor : Form
    {
        DoctorDAO dao = new DoctorDAO();
        bool isNewDoctor = false;
        Doctor formDoctor;                 // doctor object for this form
        byte[] photo = null;
        bool pictureChanged = false;
        public frmDoctor(Doctor doc)
        {
            InitializeComponent();
            cboGender.Items.Add("male");
            cboGender.Items.Add("female");
            if (doc == null)
            {
                isNewDoctor = true;
                btnCancel.Text = "Cancel Add";
                btnUpdate.Text = "Add New Doctor";
            }
            else
            {
                lblID.Text = doc.DocId.ToString();
                txtSurname.Text = doc.DocSurname;
                txtFirstname.Text = doc.DocForename;
                if (doc.DocGender)
                    cboGender.SelectedIndex = 0;
                else
                    cboGender.SelectedIndex = 1;
                txtDeptID.Text = doc.DeptId.ToString();
                txtAddress.Text = doc.DocAddress;
                txtQualifications.Text = doc.DocQualification;
                txtPhone.Text = doc.DocPhoneNumber;
                if (doc.DocPhoto != null)
                    pictureBox1.Image = Image.FromStream(new MemoryStream(doc.DocPhoto));

            }
            formDoctor = doc;                           // assign the input doctor object to this form
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Make sure no text boxes are empty
            if (txtSurname.Text == String.Empty || txtFirstname.Text == String.Empty || txtDeptID.Text == String.Empty || cboGender.Text == string.Empty ||
                txtAddress.Text == string.Empty || txtPhone.Text == String.Empty || txtQualifications.Text == String.Empty)
                MessageBox.Show("Must enter values for Surame, first name, Deparment ID, Address, phone and Qualifications.", "Fill out all text boxes");
            else
            {
                //ImageConverter _imageConverter = new ImageConverter();
                //byte[] photoByte = (byte[])_imageConverter.ConvertTo(pictureBox1.Image, typeof(byte[]));
                bool gender = false;
                Console.WriteLine("lblID.text is "+lblID.Text);
                if (cboGender.SelectedIndex == 0)
                    gender = true;
                // The TryParse method takes two parameters.  The first a String to convert into the specified type
                // The second an out parameter to store the converted value into
                // If successful, it will return true and the number will be stored in the out parameter
                // If unsuccessful, it will return false and store 0 in the out parameter
                if (int.TryParse(txtDeptID.Text, out int deptID))
                {
                    if (int.TryParse(lblID.Text, out int docID))
                        if (isNewDoctor)
                        {
                            formDoctor = new Doctor
                            {
                                DocId = docID,
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
                            // pass the Learner object to the LearnerDAO class to insert into the database
                            //
                            bool success = dao.insertDoctor(formDoctor, out int newID);      // newID will hold the new ID of the newly inserted doctor
                            if (success)
                            {
                                lblID.Text = newID.ToString();
                                MessageBox.Show("ID assigned to the new doctor is " + newID.ToString(), "New Doctor added successfully");
                                isNewDoctor = false;            // no longer adding a new doctor
                                btnUpdate.Text = "Update details";
                                btnCancel.Text = "Return to Search";
                                //lblDocID.Text = newID.ToString();                            // before adding the doctor object to the list, update the ID with that
                                // automatically assigned by the SQL database.
                                /*                      listOfLearners.Add(learner1);
                                                      MessageBox.Show("New learner:" + newLine + newLine + learner1.ToString() + newLine + newLine + "successfully added to the list", "Learner added");
                                                      // listOfLearners.ForEach(Console.WriteLine);
                                                      //
                                                      // update the TextBox with the record number
                                                      txtRecordNumber.Text = $"{currentRecord + 1} of {listOfLearners.Count}";
                                                      //
                                                      currentRecord++;*/
                            }
                            else              // learner wss not added
                            {
                                MessageBox.Show("Insert failed", "Insert failed");
                            }
                            /*btnLast.PerformClick();
                            txtAddress.Modified = false;
                            txtName.Modified = false;
                            txtAge.Modified = false;*/
                        }
                        else
                        {
                            Console.WriteLine("start updating doctor.............................");
                            string docGender;
                            if (formDoctor.DocGender)
                                docGender = "male";
                            else
                                docGender = "female";
                            //  first check if any of the information in the textboxes/comboboxes have changed....
                            if (txtSurname.Text != formDoctor.DocSurname || txtFirstname.Text != formDoctor.DocForename || cboGender.Text !=  docGender ||
                                txtAddress.Text != formDoctor.DocAddress || txtPhone.Text != formDoctor.DocPhoneNumber || txtQualifications.Text != formDoctor.DocQualification || 
                                txtDeptID.Text != formDoctor.DeptId.ToString() || pictureChanged)
                                {
                                // The TryParse method takes two parameters.  The first a String to convert into the specified type
                                // The second an out parameter to store the converted value into
                                // If successful, it will return true and the number will be stored in the out parameter
                                // If unsuccessful, it will return false and store 0 in the out parameter
                                if (int.TryParse(txtDeptID.Text, out int deptId))
                                {
                                    Doctor currentDoctor = new Doctor();
                                    currentDoctor.DocId = int.Parse(lblID.Text);
                                    currentDoctor.DocForename = txtFirstname.Text;
                                    currentDoctor.DocSurname = txtSurname.Text;
                                    currentDoctor.DocPhoto = photo;
                                    currentDoctor.DocAddress = txtAddress.Text;
                                    currentDoctor.DocPhoneNumber = txtPhone.Text;
                                    currentDoctor.DocQualification = txtQualifications.Text;
                                    currentDoctor.DeptId = deptId;
                                    if (cboGender.Text == "male")
                                        currentDoctor.DocGender = true;
                                    else
                                        currentDoctor.DocGender = false;
                                    if (dao.updateDoctor(currentDoctor))
                                    {
                                        MessageBox.Show("Details for doctor: " + lblID.Text + "\nsuccessfully updated", "Doctor details updated");
                                        btnCancel.Text = "Return to Search";
                                    }
                                    else
                                        MessageBox.Show("Error on updating the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("Department ID not in numeric format", "Invalid Department ID");
                                    txtDeptID.Focus();
                                    txtDeptID.SelectAll();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Could not update, no change was made.");
                            }
                        }
                    else
                    {
                        MessageBox.Show("Doctor ID not in numeric format", "Invalid Doctor ID");
                        lblDocID.Focus();
                    }
                }
                        else
                {
                    MessageBox.Show("Department ID not in numeric format", "Invalid Department ID");
                    txtDeptID.Focus();
                    txtDeptID.SelectAll();
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DoctorSearchForm searchForm = new DoctorSearchForm();
            searchForm.Show();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream inputStream = openFileDialog1.OpenFile();
                    using (var memoryStream = new MemoryStream())
                    {
                        inputStream.CopyTo(memoryStream);
                        photo = memoryStream.ToArray();
                        pictureBox1.Image = Image.FromStream(memoryStream);
                        pictureChanged = true;
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
