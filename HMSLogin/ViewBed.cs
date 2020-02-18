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
            Cbx_RoomId.Items.AddRange(hMS.tblBedDetails.Select(x => (object)x.RoomId).ToArray());
        }
    }
}
