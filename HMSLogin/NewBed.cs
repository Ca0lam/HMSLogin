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
    public partial class NewBed : Form
    {
        HospitalMSDataContext hMS;
        public NewBed()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            int result = hMS.tblRoomDetails.OrderByDescending(x => x.RoomId).Select(x => x.RoomId).FirstOrDefault() + 1;
            Cbx_BedId.Items.Add((object)result.ToString());
            if (Cbx_BedId.Items.Count != 0)
                Cbx_BedId.SelectedIndex = 0;
            Cbx_RoomId.Items.AddRange(hMS.tblRoomDetails.Select(x => (object)x.RoomId).ToArray());
            if(Cbx_RoomId.Items.Count != 0)
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
