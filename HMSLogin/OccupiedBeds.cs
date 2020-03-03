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
    public partial class OccupiedBeds : Form
    {
        HospitalMSDataContext hMS;
        public OccupiedBeds()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            updateDept();
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
            var bedIds = hMS.tblDeptDetails.SingleOrDefault(x => x.DeptName == Cbx_Department.Text).tblWardDetails.SelectMany(y => y.tblRoomDetails.Where(a => a.RoomType == "Private").SelectMany(z => z.tblBedDetails.Select(b => (object)b.BedId)));
            var occupiedBeds = hMS.tblVisitDetails.Where(x => !bedIds.ToList().Contains(x.BedId) && x.tblBedDetail.tblRoomDetail.RoomType == "Private").Select(y => (object)y.BedId).Distinct();
            Cbx_Private.Items.AddRange(occupiedBeds.ToArray());
            if (Cbx_Private.Items.Count != 0)
                Cbx_Private.SelectedIndex = 0;
        }

        private void updateSemiPrivateBeds()
        {
            Cbx_Semiprivate.Items.Clear();
            Cbx_Semiprivate.SelectedIndex = -1;
            var bedIds = hMS.tblDeptDetails.SingleOrDefault(x => x.DeptName == Cbx_Department.Text).tblWardDetails.SelectMany(y => y.tblRoomDetails.Where(a => a.RoomType == "SemiPrivate").SelectMany(z => z.tblBedDetails.Select(b => (object)b.BedId)));
            var occupiedBeds = hMS.tblVisitDetails.Where(x => bedIds.ToList().Contains(x.BedId) && x.tblBedDetail.tblRoomDetail.RoomType == "SemiPrivate").Select(y => (object)y.BedId).Distinct();
            //var vacantBeds = bedIds.Where(x => occupiedBeds.Contains(x));
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
            var occupiedBeds = hMS.tblVisitDetails.Where(x => bedIds.ToList().Contains(x.BedId) && x.tblBedDetail.tblRoomDetail.RoomType == "Public").Select(y => (object)y.BedId).Distinct();
            Cbx_Public.Items.AddRange(occupiedBeds.ToArray());
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

        private void Cbx_Public_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbx_PublicPatient.Items.Clear();
            Cbx_PublicPatient.Items.AddRange(hMS.tblVisitDetails.Where(x => x.BedId == int.Parse(Cbx_Public.Text)).Select(y=>(object)(y.tblPatientDetail.PatientForename + " " + y.tblPatientDetail.PatientSurename)).ToArray());
            if (Cbx_PublicPatient.Items.Count != 0)
                Cbx_PublicPatient.SelectedIndex = 0;
        }

        private void Cbx_Semiprivate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbx_PublicPatient.Items.Clear();
            Cbx_PublicPatient.Items.AddRange(hMS.tblVisitDetails.Where(x => x.BedId == int.Parse(Cbx_Semiprivate.Text)).Select(y => (object)(y.tblPatientDetail.PatientForename + " " + y.tblPatientDetail.PatientSurename)).ToArray());
            if (Cbx_PublicPatient.Items.Count != 0)
                Cbx_PublicPatient.SelectedIndex = 0;
        }

        private void Cbx_Private_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbx_PublicPatient.Items.Clear();
            Cbx_PublicPatient.Items.AddRange(hMS.tblVisitDetails.Where(x => x.BedId == int.Parse(Cbx_Private.Text)).Select(y => (object)(y.tblPatientDetail.PatientForename + " " + y.tblPatientDetail.PatientSurename)).ToArray());
            if (Cbx_PublicPatient.Items.Count != 0)
                Cbx_PublicPatient.SelectedIndex = 0;
        }
    }
}
