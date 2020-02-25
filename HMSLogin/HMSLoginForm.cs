using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSLogin
{
    public partial class Form1 : Form
    {

        HMSLoginDAO dao = new HMSLoginDAO();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            Process.Start("file:///C:/Users/dsd18/Documents/GitHub/HMSLogin/HMSHelpwebsite/Root/Helpdefault.html");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            String name = TxtName.Text;
            String password = TxtPassword.Text;

            HMSLoginDetails hmslogindetails = new HMSLoginDetails
            {
                Name = name,
                Password = password
            };

            Console.WriteLine("Login detail " + hmslogindetails);
            if (dao.InputLogin(hmslogindetails))
            {
                if (hmslogindetails.Role == "Patient")
                {
                    
                }
                if (hmslogindetails.Role == "Doctor")
                {
                    this.Hide();
                    //this.Dispose();
                    DoctorSearchForm doctorSearch = new DoctorSearchForm();
                    doctorSearch.Show();
                }
                if (hmslogindetails.Role == "Admin")
                {

                }
                if (hmslogindetails.Role == "Super-User")
                {

                }
                this.Hide();
            }
            if (TxtName.Text != hmslogindetails.Name || TxtPassword.Text != hmslogindetails.Password)
            {
                MessageBox.Show("Please enter the right username and/or password");
            }
            if (TxtName.Text == string.Empty || TxtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please enter a username/password");
            }
            if (TxtName.Text.Length < 6)
            {
                MessageBox.Show("Username needs to be more than 6 characters");
            }
            else if (TxtName.Text.Length > 14)
            {
                MessageBox.Show("Username/Password needs to be less than 14 characters");
            }
            TxtName.Text = string.Empty;
            TxtPassword.Text = string.Empty;
        }

        private void BtnShowMe_Click(object sender, EventArgs e)
        {

            TxtPassword.UseSystemPasswordChar = !TxtPassword.UseSystemPasswordChar;

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (TxtName.Text.Length < 6)
            {
                BtnLogin.Enabled = false;
            }
            else
            {
                BtnLogin.Enabled = true;
            }
            if (TxtPassword.Text.Length < 6)
            {
                BtnLogin.Enabled = false;
            }
            else
            {
                BtnLogin.Enabled = true;
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (TxtName.Text.Length < 6)
            {
                BtnLogin.Enabled = false;
            }
            else
            {
                BtnLogin.Enabled = true;
            }
            if (TxtPassword.Text.Length < 6)
            {
                BtnLogin.Enabled = false;
            }
            else
            {
                BtnLogin.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HMSLoginDAO hmsloginDAO = new HMSLoginDAO();

            Console.WriteLine(hmsloginDAO.Testlogin());
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerfrm = new RegisterForm(this);
            registerfrm.Show();
            this.Hide();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}