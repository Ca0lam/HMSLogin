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
        HospitalMSDataContext hMS = new HospitalMSDataContext();
        public ViewDepartment()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();

            //var join = hMS.tblWardDetails.Join(hMS.tblDeptDetails, w => w.WardId, d => d.DeptId, (w,d)=> new { tblWardDetail = w, tblDeptDetail = d });
            //var joinedTable = from w in hMS.tblWardDetails join d in hMS.tblDeptDetails on w.DeptId equals d.DeptId select new { tblWardDetail = w, tblDeptDetail = d };
            Cbx_Department.Items.AddRange(hMS.tblDeptDetails.Select(x => (object)x.DeptName).ToArray());
            Cbx_Department.SelectedIndex = 0;
            Cbx_Ward.Items.AddRange(hMS.tblDeptDetails.Single(x=> x.DeptName == Cbx_Department.Text).tblWardDetails.Select(x=>(object)x.WardName).ToArray());
            Cbx_Ward.SelectedIndex = 0;
            Cbx_Room.Items.AddRange(hMS.tblDeptDetails.Single(x => x.DeptName == Cbx_Department.Text).tblWardDetails.SelectMany(y => y.tblRoomDetails.Select(z => (object)z.RoomId)).ToArray());
            Cbx_Room.SelectedIndex = 0;
            Cbx_Bed.Items.AddRange(hMS.tblDeptDetails.Single(x => x.DeptName == Cbx_Department.Text).tblWardDetails.SelectMany(y => y.tblRoomDetails.SelectMany(z => z.tblBedDetails.Select(b => (object)b.BedId))).ToArray());
            Cbx_Bed.SelectedIndex = 0;
        }
    }
}
