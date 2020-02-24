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
    public partial class ViewBed : Form
    {
        HospitalMSDataContext hMS;
        public ViewBed()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            int result = hMS.tblRoomDetails.OrderByDescending(x => x.RoomId).Select(x => x.RoomId).FirstOrDefault() + 1;
            Cbx_BedId.Text = result.ToString();
            Cbx_RoomId.Items.AddRange(hMS.tblRoomDetails.Select(x => (object)x.RoomId).ToArray());
            Cbx_RoomId.SelectedIndex = 0;
            
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            tblBedDetail bed = new tblBedDetail();
            bed.BedId= int.Parse(Cbx_BedId.SelectedItem.ToString());
            bed.RoomId = int.Parse(Cbx_RoomId.SelectedItem.ToString());
            hMS.tblBedDetails.InsertOnSubmit(bed);
            hMS.SubmitChanges();
            this.Dispose();
        }
    }
}
