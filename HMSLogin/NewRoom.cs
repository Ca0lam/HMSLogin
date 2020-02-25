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
    public partial class NewRoom : Form
    {
        HospitalMSDataContext hMS;
        public NewRoom()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            int result = hMS.tblRoomDetails.OrderByDescending(x => x.RoomId).Select(x => x.RoomId).FirstOrDefault() + 1;
            Cbx_RoomId.Text = result.ToString();
            Cbx_WardId.Items.AddRange(hMS.tblWardDetails.Select(x => (object)x.WardId).ToArray());
            Cbx_WardId.SelectedIndex = 0;
            object[] roomTypes = { "Public", "SemiPrivate", "Private" };
            Cbx_RoomType.Items.AddRange(roomTypes);
        }

        public NewRoom(string stuff)
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            Cbx_RoomId.Items.AddRange(hMS.tblRoomDetails.Select(x => (object)x.RoomId).ToArray());
            Cbx_RoomId.SelectedIndex = 0;
            Cbx_RoomId.Enabled = true;
            Cbx_WardId.Items.AddRange(hMS.tblRoomDetails.Where(x=> x.RoomId == int.Parse(Cbx_RoomId.Text)).Select(x => (object)x.WardId).ToArray());
            Cbx_WardId.SelectedIndex = 0;
            object[] roomTypes = { "Public", "SemiPrivate", "Private" };
            Cbx_RoomType.Items.AddRange(roomTypes);
            Cbx_RoomType.Text = hMS.tblRoomDetails.Where(x => x.RoomId == int.Parse(Cbx_RoomId.Text)).Select(x => x.RoomType).FirstOrDefault();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            tblRoomDetail room = new tblRoomDetail();
            room.WardId = int.Parse(Cbx_WardId.SelectedItem.ToString());
            room.RoomType = Cbx_RoomType.SelectedItem.ToString();
            hMS.tblRoomDetails.InsertOnSubmit(room);
            hMS.SubmitChanges();
            this.Dispose();
        }
    }
}
