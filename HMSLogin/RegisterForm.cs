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
    public partial class RegisterForm : Form
    {
        Form1 hmsloginfrm;
        RegisterDAO dao = new RegisterDAO();
        DateTime dob;
        public RegisterForm(Form1 hmsloginfrm)
        {
            InitializeComponent();
            MthDOB.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MthDOB_DateSelected);
            this.hmsloginfrm = hmsloginfrm;
        }

        private void MthDOB_DateSelected(object sender, DateRangeEventArgs e)
        {
            dob = e.Start;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (TxtFirstname.Text == string.Empty || TxtSurname.Text == string.Empty || CmbGender.Text == string.Empty ||
                TxtAddress.Text == string.Empty ||  TxtMobileNo.Text == string.Empty || TxtPersonsName.Text == string.Empty || 
                TxtPhoneNo.Text == string.Empty || TxtRelationship.Text == string.Empty)
            {
                MessageBox.Show("Some fields are empty", "Empty fields, you must fill them, I demand it!!!");
            }
            else
            {
                string firstname = TxtFirstname.Text;
                string surname = TxtSurname.Text;
                string gender = CmbGender.Text;
                string address = TxtAddress.Text;
                string mobileno = TxtMobileNo.Text;
                string personsname = TxtPersonsName.Text;
                string phoneno = TxtPhoneNo.Text;
                string relationship = TxtRelationship.Text;

                RegisterDetails registerdetails = new RegisterDetails
                {
                    FirstName = firstname,
                    SurName = surname,
                    Gender = gender,
                    Address = address,
                    DOB = dob,
                    MobileNo = mobileno,
                    PersonName = personsname,
                    PhoneNo = phoneno,
                    Relationship = relationship
                };
                dao.RegisterLogin(registerdetails);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            hmsloginfrm.Show();
        }
    }
}
