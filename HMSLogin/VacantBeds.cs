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
    public partial class VacantBeds : Form
    {
        HospitalMSDataContext hMS;

        public VacantBeds()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();

            updateDept();
            updatePrivateBeds();
            updateSemiPrivateBeds();
            updatePublicBeds();
        }

        private void updateDept()
        {
            Cbx_Department.SelectedIndex = -1;
            Cbx_Department.Items.AddRange(hMS.tblDeptDetails.Select(x => (object)x.DeptName).ToArray());
            if (Cbx_Department.Items.Count != 0)
                Cbx_Department.SelectedIndex = 0;
        }

        private void updatePrivateBeds()
        {
            Cbx_Private.Items.Clear();
            Cbx_Private.SelectedIndex = -1;
            var bedIds = hMS.tblDeptDetails.SingleOrDefault(x => x.DeptName == Cbx_Department.Text).tblWardDetails.SelectMany(y => y.tblRoomDetails.Where(a=>a.RoomType == "Private").SelectMany(z => z.tblBedDetails.Select(b => (object)b.BedId)));
            var occupiedBeds = hMS.tblVisitDetails.Where(x => !bedIds.ToList().Contains(x.BedId) && x.tblBedDetail.tblRoomDetail.RoomType == "Private").Select(y=>(object)y.BedId);
            Cbx_Private.Items.AddRange(occupiedBeds.ToArray());
            if (Cbx_Private.Items.Count != 0)
                Cbx_Private.SelectedIndex = 0;
        }

        private void updateSemiPrivateBeds()
        {
            Cbx_Semiprivate.Items.Clear();
            Cbx_Semiprivate.SelectedIndex = -1;
            var bedIds = hMS.tblDeptDetails.SingleOrDefault(x => x.DeptName == Cbx_Department.Text).tblWardDetails.SelectMany(y => y.tblRoomDetails.Where(a => a.RoomType == "SemiPrivate").SelectMany(z => z.tblBedDetails.Select(b => (object)b.BedId)));
            var occupiedBeds = hMS.tblVisitDetails.Where(x => bedIds.ToList().Contains(x.BedId) && x.tblBedDetail.tblRoomDetail.RoomType == "SemiPrivate").Select(y => (object)y.BedId);
            var vacantBeds = bedIds.Where(x => occupiedBeds.Contains(x));
            Cbx_Semiprivate.Items.AddRange(occupiedBeds.ToArray());
            Lbl_TotalPublic.Text = "Total: " + Cbx_Public.Items.Count;
            if (Cbx_Semiprivate.Items.Count != 0)
                Cbx_Semiprivate.SelectedIndex = 0;
        }

        private void updatePublicBeds()
        {
            Cbx_Public.Items.Clear();
            Cbx_Public.SelectedIndex = -1;
            var bedIds = hMS.tblDeptDetails.SingleOrDefault(x => x.DeptName == Cbx_Department.Text).tblWardDetails.SelectMany(y => y.tblRoomDetails.Where(a => a.RoomType == "Public").SelectMany(z => z.tblBedDetails.Select(b => (object)b.BedId)));
            var occupiedBeds = hMS.tblVisitDetails.Where(x => bedIds.ToList().Contains(x.BedId) && x.tblBedDetail.tblRoomDetail.RoomType == "Public").Select(y => (object)y.BedId);
            var vacantBeds = bedIds.Where(x => occupiedBeds.Contains(x));
            Cbx_Public.Items.AddRange(vacantBeds.ToArray());
            Lbl_TotalPublic.Text = "Total: " + Cbx_Public.Items.Count;
            if (Cbx_Public.Items.Count != 0)
                Cbx_Public.SelectedIndex = 0;
        }

        private void Cbx_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePrivateBeds();
            updatePublicBeds();
            updateSemiPrivateBeds();
        }
    }
}
