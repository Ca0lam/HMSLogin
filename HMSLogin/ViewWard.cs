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

    public partial class ViewWard : Form
    {
        HospitalMSDataContext hMS;
        public ViewWard()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            updateBoxes();

        }

        public ViewWard(string wardName)
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            Cbx_Ward.Items.Add(wardName);
            Cbx_Ward.SelectedIndex = 0;
            updateDept();
            updateRoom();
            updateBed();
            Cbx_Ward.Enabled = false;
        }

        private void updateBoxes()
        {
            updateWard();
            updateDept();
            updateRoom();
            updateBed();
        }


        private void updateWard()
        {
            Cbx_Ward.SelectedIndex = -1;
            Cbx_Ward.Items.AddRange(hMS.tblWardDetails.Select(x => (object)x.WardName).ToArray());
            if (Cbx_Ward.Items.Count != 0)
                Cbx_Ward.SelectedIndex = 0;
        }
        private void updateDept()
        {
            Cbx_Department.Items.Clear();
            Cbx_Department.SelectedIndex = -1;
            Cbx_Department.Items.Add((object)hMS.tblWardDetails.SingleOrDefault(x => x.WardName == Cbx_Ward.Text).tblDeptDetail.DeptName);
            if (Cbx_Department.Items.Count != 0)
                Cbx_Department.SelectedIndex = 0;
        }

        private void updateRoom()
        {
            Cbx_Room.Items.Clear();
            Cbx_Room.SelectedIndex = -1;
            Cbx_Room.Items.AddRange(hMS.tblWardDetails.SingleOrDefault(x => x.WardName == Cbx_Ward.Text).tblRoomDetails.Select(y => (object)y.RoomId).ToArray());
            if (Cbx_Room.Items.Count != 0)
                Cbx_Room.SelectedIndex = 0;
        }

        private void updateBed()
        {
            Cbx_Bed.Items.Clear();
            Cbx_Bed.SelectedIndex = -1;
            Cbx_Bed.Items.AddRange(hMS.tblWardDetails.SingleOrDefault(x => x.WardName == Cbx_Ward.Text).tblRoomDetails.SelectMany(y => y.tblBedDetails.Select(z=>(object)z.BedId)).ToArray());
            if (Cbx_Bed.Items.Count != 0)
                Cbx_Bed.SelectedIndex = 0;
        }
    }
}
