using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSLogin.Database;

namespace HMSLogin
{
    public partial class ViewDepartment : Form
    {
        HospitalMSDataContext hMS;
        public ViewDepartment()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();

            //var join = hMS.tblWardDetails.Join(hMS.tblDeptDetails, w => w.WardId, d => d.DeptId, (w,d)=> new { tblWardDetail = w, tblDeptDetail = d });
            //var joinedTable = from w in hMS.tblWardDetails join d in hMS.tblDeptDetails on w.DeptId equals d.DeptId select new { tblWardDetail = w, tblDeptDetail = d };
            updateBoxes();
        }

        public ViewDepartment(string deptName)
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            Cbx_Department.Items.Add(deptName);
            Cbx_Department.SelectedIndex = 0;
            updateWard();
            updateRoom();
            updateBed();
        }

        private void updateBoxes()
        {
            updateDept();
            updateWard();
            updateRoom();
            updateBed();
        }

        private void updateDept()
        {
            Cbx_Department.SelectedIndex = -1;
            Cbx_Department.Items.AddRange(hMS.tblDeptDetails.Select(x => (object)x.DeptName).ToArray());
            if (Cbx_Department.Items.Count != 0)
                Cbx_Department.SelectedIndex = 0;
        }

        private void updateWard()
        {
            Cbx_Ward.Items.Clear();
            Cbx_Ward.SelectedIndex = -1;
            Cbx_Ward.Items.AddRange(hMS.tblDeptDetails.SingleOrDefault(x => x.DeptName == Cbx_Department.Text).tblWardDetails.Select(x => (object)x.WardName).ToArray());
            if (Cbx_Ward.Items.Count != 0)
                Cbx_Ward.SelectedIndex = 0;
        }

        private void updateRoom()
        {
            Cbx_Room.Items.Clear();
            Cbx_Room.SelectedIndex = -1;
            Cbx_Room.Items.AddRange(hMS.tblDeptDetails.SingleOrDefault(x => x.DeptName == Cbx_Department.Text).tblWardDetails.SelectMany(y => y.tblRoomDetails.Select(z => (object)z.RoomId)).ToArray());
            if (Cbx_Room.Items.Count != 0)
                Cbx_Room.SelectedIndex = 0;
        }

        private void updateBed()
        {
            Cbx_Bed.Items.Clear();
            Cbx_Bed.SelectedIndex = -1;
            var bedIds = hMS.tblDeptDetails.SingleOrDefault(x => x.DeptName == Cbx_Department.Text).tblWardDetails.SelectMany(y => y.tblRoomDetails.SelectMany(z => z.tblBedDetails.Select(b => (object)b.BedId)));
            Cbx_Bed.Items.AddRange(bedIds.ToArray());
            Lbl_NumBeds.Text = "Total Number of Beds In Dept: " + Cbx_Bed.Items.Count;
            var occupiedBeds = hMS.tblVisitDetails.Where(x => bedIds.ToList().Contains(x.BedId)).Count();
            Lbl_EmptyBeds.Text = "Total Empty Beds: " + (Cbx_Bed.Items.Count - occupiedBeds);
            if (Cbx_Bed.Items.Count!=0)
                Cbx_Bed.SelectedIndex = 0;
        }

        private void Cbx_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWard();
            updateRoom();
            updateBed();
        }

        private void Cbx_Ward_SelectedIndexChanged(object sender, EventArgs e)
        {
            //updateRoom();
            //updateBed();
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

        private void Btn_View_Bed_Click(object sender, EventArgs e)
        {
            ViewBeds beds = new ViewBeds(int.Parse(Cbx_Bed.Text));
            beds.Show();
        }
    }
}
