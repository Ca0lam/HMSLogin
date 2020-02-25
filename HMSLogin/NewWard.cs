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
    public partial class NewWard : Form
    {
        HospitalMSDataContext hMS;
        public NewWard()
        {
            InitializeComponent();
            hMS = new HospitalMSDataContext();
            int result = hMS.tblWardDetails.OrderByDescending(x => x.WardId).Select(x => x.WardId).FirstOrDefault() + 1;
            Cbx_WardID.Text = result.ToString();
            Cbx_DepartmentId.Items.AddRange(hMS.tblDeptDetails.Select(x => (object)x.DeptId).ToArray());
            Cbx_DepartmentId.SelectedIndex = 0;
        }

        public NewWard(string title)
        {
            InitializeComponent();
            //Btn_Save.Hide();
            this.Text = "View Department";
            hMS = new HospitalMSDataContext();
            Cbx_DepartmentId.Enabled = false;
            Cbx_WardID.Enabled = true;
            Cbx_DepartmentId.Items.AddRange(hMS.tblDeptDetails.Select(x => (object)x.DeptId).ToArray());
            Cbx_DepartmentId.SelectedIndex = 0;
            Cbx_WardID.Items.AddRange(hMS.tblWardDetails.Where(x=>x.DeptId == (int)Cbx_DepartmentId.SelectedItem).Select(x=> (object)x.WardId).ToArray());
            Cbx_WardID.SelectedIndex = 0;
            Txt_WardName.Text
                = hMS.tblWardDetails.Where(x => x.WardId == int.Parse(Cbx_WardID.SelectedItem.ToString())).Select(x => x.WardName).First();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            tblWardDetail ward = new tblWardDetail();
            ward.WardName = Txt_WardName.Text;
            ward.DeptId = int.Parse(Cbx_DepartmentId.SelectedItem.ToString());
            hMS.tblWardDetails.InsertOnSubmit(ward);
            hMS.SubmitChanges();
            this.Dispose();
        }
    }
}