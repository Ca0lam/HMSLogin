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
    public partial class AdminMenu : Form
    {
        Form1 hmsloginfrm;
        public AdminMenu(Form1 hmsloginfrm)
        {
            InitializeComponent();
            this.hmsloginfrm = hmsloginfrm;
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {

        }

        private void btnPatientDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctorDetails_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            DoctorSearchForm doctorSearch = new DoctorSearchForm();
            doctorSearch.Show();
        }

        private void btnGenerateBills_Click(object sender, EventArgs e)
        {

        }

        private void btnHospitalLayout_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Dispose();
            hmsloginfrm.Show();
        }
    }
}
