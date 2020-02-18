using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSLogin
{
    public partial class frmDoctor : Form
    {
        DoctorDAO dao = new DoctorDAO();
        bool isNewDoctor = false;
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
                lblDocID.Text = doc.DocId.ToString();
                txtSurname.Text = doc.DocSurname;
                txtFirstname.Text = doc.DocForename;
                if (doc.DocGender)
                    cboGender.SelectedIndex = 0;
                else
                    cboGender.SelectedIndex = 1;
                txtDeptID.Text = doc.DeptId.ToString();
                txtAddress.Text = doc.DocAddress;
                txtQualifications.Text = doc.DocQualification;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Make sure no text boxes are empty
            if (txtSurname.Text == String.Empty || txtFirstname.Text == String.Empty || txtDeptID.Text == String.Empty ||
                txtAddress.Text == string.Empty || txtPhone.Text == String.Empty || txtQualifications.Text == String.Empty)
                MessageBox.Show("Must enter values for Surame, first name, Deparment ID, Address, phone and Qualifications.", "Fill out all text boxes");
            else
            {
                ImageConverter _imageConverter = new ImageConverter();
                byte[] photoByte = (byte[])_imageConverter.ConvertTo(pictureBox1.Image, typeof(byte[]));
                bool gender = false;
                Console.WriteLine("lblDocID.text is "+lblDocID.Text);
                if (cboGender.SelectedIndex == 0)
                    gender = true;
                // The TryParse method takes two parameters.  The first a String to convert into the specified type
                // The second an out parameter to store the converted value into
                // If successful, it will return true and the number will be stored in the out parameter
                // If unsuccessful, it will return false and store 0 in the out parameter
                if (int.TryParse(txtDeptID.Text, out int deptID))
                {
                    if (int.TryParse(lblDocID.Text, out int docID))
                        if (isNewDoctor)
                        {
                            Doctor newDoctor = new Doctor { DocId = docID, DocForename = txtFirstname.Text, DocSurname = txtSurname.Text, DocPhoto = photoByte,
                                DocGender = gender, DocAddress = txtAddress.Text, DocPhoneNumber = txtPhone.Text, DocQualification = txtQualifications.Text, DeptId = deptID };
                            //
                            // pass the Learner object to the LearnerDAO class to insert into the database
                            //
                            bool success = dao.insertDoctor(newDoctor);      // newID will hold the new ID of the newly inserted learner
                            if (success)
                            {
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
                        else { }
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
    }
}
