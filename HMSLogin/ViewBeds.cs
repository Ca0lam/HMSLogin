using HMSLogin.Database;
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
    public partial class ViewBeds : Form
    {
        HospitalMSDataContext hMS;
        public ViewBeds()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            updateBoxes();
        }

        public ViewBeds(int bedId)
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            Cbx_Bed.Items.Add((object)bedId);
            Cbx_Bed.SelectedIndex = 0;
            updateRoom();
            updateWard();
            updateDept();
            Cbx_Bed.Enabled = false;
        }

        private void updateBoxes()
        {
            updateBed();
            updateWard();
            updateRoom();
            updateDept();
        }
        private void updateBed()
        {
            Cbx_Bed.Items.Clear();
            Cbx_Bed.SelectedIndex = -1;
            Cbx_Bed.Items.AddRange(hMS.tblBedDetails.Select(x=>(object)x.BedId).ToArray());
            if (Cbx_Bed.Items.Count != 0)
                Cbx_Bed.SelectedIndex = 0;
        }



        private void updateRoom()
        {
            Cbx_Room.Items.Clear();
            Cbx_Room.SelectedIndex = -1;
            Cbx_Room.Items.Add((object)hMS.tblBedDetails.SingleOrDefault(x => x.BedId.ToString() == Cbx_Bed.Text).tblRoomDetail.RoomId);
            if (Cbx_Room.Items.Count != 0)
                Cbx_Room.SelectedIndex = 0;
        }
        private void updateWard()
        {
            Cbx_Ward.SelectedIndex = -1;
            Cbx_Ward.Items.Add((object)hMS.tblBedDetails.SingleOrDefault(x => x.BedId.ToString() == Cbx_Bed.Text).tblRoomDetail.tblWardDetail.WardName);
            if (Cbx_Ward.Items.Count != 0)
                Cbx_Ward.SelectedIndex = 0;
        }
        private void updateDept()
        {
            Cbx_Department.Items.Clear();
            Cbx_Department.SelectedIndex = -1;
            Cbx_Department.Items.Add((object)hMS.tblBedDetails.SingleOrDefault(x => x.BedId.ToString() == Cbx_Bed.Text).tblRoomDetail.tblWardDetail.tblDeptDetail.DeptName);
            if (Cbx_Department.Items.Count != 0)
                Cbx_Department.SelectedIndex = 0;
        }

        private void Btn_View_Ward_Click(object sender, EventArgs e)
        {
            ViewWard ward = new ViewWard(Cbx_Ward.Text);
            ward.Show();
        }


        private void Btn_ViewRoom_Click(object sender, EventArgs e)
        {
            ViewRoom room = new ViewRoom(int.Parse(Cbx_Room.Text));
            room.Show();
        }

        private void Btn_ViewDepartment_Click(object sender, EventArgs e)
        {
            ViewDepartment dept = new ViewDepartment(Cbx_Department.Text);
            dept.Show();
        }
    }
}
