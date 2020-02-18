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
    public partial class ViewDepartment : Form
    {
        HMSDataContext hMS;
        public ViewDepartment()
        {
            InitializeComponent();
            Cbx_DepartmentId.Enabled = false;
            hMS = new HMSDataContext();
            int result = hMS.tblDeptDetails.OrderByDescending(x => x.DeptId).Select(x=>x.DeptId).FirstOrDefault() + 1;
            Cbx_DepartmentId.Text = result.ToString();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            tblDeptDetail department = new tblDeptDetail();
            department.DeptName = Txt_DepartmentName.Text;
            hMS.tblDeptDetails.InsertOnSubmit(department);
            hMS.SubmitChanges();
            this.Dispose();
        }
    }
}
