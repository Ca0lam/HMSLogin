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
            NewDepartment viewDepartment = new NewDepartment();
            viewDepartment.Show();
        }

        private void Btn_New_Ward_Click(object sender, EventArgs e)
        {
            NewWard viewWard = new NewWard();
            viewWard.Show();
        }

        private void Btn_New_Room_Click(object sender, EventArgs e)
        {
            NewRoom viewRoom = new NewRoom();
            viewRoom.Show();
        }

        private void Btn_New_Bed_Click(object sender, EventArgs e)
        {
            NewBed viewBed = new NewBed();
            viewBed.Show();
        }

        private void Btn_View_Department_Click(object sender, EventArgs e)
        {
            ViewDepartment department = new ViewDepartment();
            department.Show();
        }

        private void Btn_View_Beds_Click(object sender, EventArgs e)
        {
            ViewWard ward = new ViewWard();
            ward.Show();
        }

        private void Btn_View_Room_Click(object sender, EventArgs e)
        {
            ViewRoom room = new ViewRoom();
            room.Show();
        }

        private void Btn_View_Bed_Click(object sender, EventArgs e)
        {
            ViewBeds bed = new ViewBeds();
            bed.Show();
        }

        private void Btn_Vacant_Click(object sender, EventArgs e)
        {
            VacantBeds vacant = new VacantBeds();
            vacant.Show();
        }

        private void Btn_Occupied_Click(object sender, EventArgs e)
        {
            OccupiedBeds occupied = new OccupiedBeds();
            occupied.Show();
        }
    }
}
