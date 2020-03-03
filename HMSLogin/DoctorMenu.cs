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
    public partial class DoctorMenu : Form
    {
        Form1 hmsloginfrm;
        public DoctorMenu(Form1 hmsloginfrm)
        {
            InitializeComponent();
            this.hmsloginfrm = hmsloginfrm;
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {

        }

        private void btnPatientDetails_Click(object sender, EventArgs e)
        {
            FrmPatientDetails patientDetails = new FrmPatientDetails();
            patientDetails.Show();
        }

        private void btnTestResults_Click(object sender, EventArgs e)
        {

        }

        private void btnWritePrescription_Click(object sender, EventArgs e)
        {

        }

        private void btnHospitalLayout_Click(object sender, EventArgs e)
        {
            HospitalLayout hospitalLayout = new HospitalLayout();
            hospitalLayout.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Dispose();
            hmsloginfrm.Show();
        }
    }
}
