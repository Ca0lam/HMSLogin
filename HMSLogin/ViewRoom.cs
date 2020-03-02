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
    public partial class ViewRoom : Form
    {
        HospitalMSDataContext hMS;
        public ViewRoom()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            updateBoxes();
        }

        private void updateBoxes()
        {
            updateRoom();
            updateDept();
            updateWard();
            updateBed();
        }

        private void updateRoom()
        {
            Cbx_Room.Items.Clear();
            Cbx_Room.SelectedIndex = -1;
            Cbx_Room.Items.AddRange(hMS.tblRoomDetails.Select(x => (object)x.RoomId).ToArray());
            //Cbx_Room.Items.AddRange(hMS.tblRoomDetails.SingleOrDefault(x => x.DeptName == Cbx_Department.Text).tblWardDetails.SelectMany(y => y.tblRoomDetails.Select(z => (object)z.RoomId)).ToArray());
            if (Cbx_Room.Items.Count != 0)
                Cbx_Room.SelectedIndex = 0;
        }
        private void updateDept()
        {
            Cbx_Department.SelectedIndex = -1;
            Cbx_Department.Items.Add((object)hMS.tblRoomDetails.SingleOrDefault(x => x.RoomId.ToString() == Cbx_Room.Text.ToString()).tblWardDetail.tblDeptDetail.DeptName);
            if (Cbx_Department.Items.Count != 0)
                Cbx_Department.SelectedIndex = 0;
        }

        private void updateWard()
        {
            Cbx_Ward.Items.Clear();
            Cbx_Ward.SelectedIndex = -1;
            Cbx_Ward.Items.Add((object)hMS.tblRoomDetails.SingleOrDefault(x => x.RoomId.ToString() == Cbx_Room.Text.ToString()).tblWardDetail.WardName);
            if (Cbx_Ward.Items.Count != 0)
                Cbx_Ward.SelectedIndex = 0;
        }


        private void updateBed()
        {
            Cbx_Bed.Items.Clear();
            Cbx_Bed.SelectedIndex = -1;
            Cbx_Bed.Items.AddRange(hMS.tblRoomDetails.SingleOrDefault(x => x.RoomId.ToString() == Cbx_Room.Text.ToString()).tblBedDetails.Select(y=>(object)y.BedId).ToArray());
            if (Cbx_Bed.Items.Count != 0)
                Cbx_Bed.SelectedIndex = 0;
        }
    }
}
