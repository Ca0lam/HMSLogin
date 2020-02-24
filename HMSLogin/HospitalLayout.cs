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
    public partial class HospitalLayout : Form
    {
        public HospitalLayout()
        {
            InitializeComponent();
        }

        private void Btn_New_Department_Click(object sender, EventArgs e)
        {
            ViewDepartment viewDepartment = new ViewDepartment();
            viewDepartment.Show();
        }

        private void Btn_New_Ward_Click(object sender, EventArgs e)
        {
            ViewWard viewWard = new ViewWard();
            viewWard.Show();
        }

        private void Btn_New_Room_Click(object sender, EventArgs e)
        {
            ViewRoom viewRoom = new ViewRoom();
            viewRoom.Show();
        }

        private void Btn_New_Bed_Click(object sender, EventArgs e)
        {
            ViewBed viewBed = new ViewBed();
            viewBed.Show();
        }
    }
}
