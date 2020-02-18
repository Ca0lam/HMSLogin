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
    public partial class ViewWard : Form
    {
        HospitalMSDataContext hMS;
        public ViewWard()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            int result = hMS.tblWardDetails.OrderByDescending(x => x.WardId).Select(x => x.WardId).FirstOrDefault() + 1;
            Cbx_WardID.Text = result.ToString();
            Cbx_DepartmentId.Items.AddRange(hMS.tblWardDetails.Select(x => (object)x.WardId).ToArray());
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            tblWardDetail ward= new tblWardDetail();
            ward.WardName = Txt_WardName.Text;
            ward.DeptId = int.Parse(Cbx_DepartmentId.SelectedItem.ToString());
            hMS.tblWardDetails.InsertOnSubmit(ward);
            hMS.SubmitChanges();
            this.Dispose();
        }
    }
}
