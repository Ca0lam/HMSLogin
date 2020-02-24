using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSLogin
{
    public partial class DoctorSearchForm : Form
    {
        DoctorDAO dao = new DoctorDAO();
        DataSet dataSet1;
        SqlConnection connection1;
        int docId;
        private int deptId;
        private string connectionString = "Data Source=SD-15; " +
            "Initial Catalog=HospitalMS; " +
            "Integrated Security=true; ";
        public DoctorSearchForm()
        {
            InitializeComponent();
        }
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Dispose();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //  Call the method in the DAO class, which returns a dataset
            //  The dataset can contain a collection of Data tables (i.e. results from the database)
            // the searchLearner needs 3 values (from the comboBoxes and text box)
            dataSet1 = dao.searchDoctor(txtDocIdSearch.Text, txtDocSurnameSearch.Text, txtDocDeptSearch.Text, out bool success);
            //
            //  Two important properties of the DataGridView
            //  1. The DataSource connects up to the dataset
            //     which was returned to the searchLearner() method.
            //  2. The DataMember is the table name supplied
            //
            Console.WriteLine("dataSet1 index 0 is " + dataSet1.Tables[0].Rows[0].ItemArray[0].ToString());
            Console.WriteLine("dataSet1 index 1 is " + dataSet1.Tables[0].Rows[0].ItemArray[1].ToString());
            Console.WriteLine("dataSet1 index 2 is " + dataSet1.Tables[0].Rows[0].ItemArray[2].ToString());
            Console.WriteLine("dataSet1 index 3 is " + dataSet1.Tables[0].Rows[0].ItemArray[3].ToString());
            Console.WriteLine("dataSet1 index 4 is " + dataSet1.Tables[0].Rows[0].ItemArray[4].ToString());
            Console.WriteLine("dataSet1 index 5 is " + dataSet1.Tables[0].Rows[0].ItemArray[5].ToString());
            Console.WriteLine("dataSet1 index 6 is " + dataSet1.Tables[0].Rows[0].ItemArray[6].ToString());
            Console.WriteLine("dataSet1 index 7 is " + dataSet1.Tables[0].Rows[0].ItemArray[7].ToString());
            Console.WriteLine("dataSet1 index 8 is " + dataSet1.Tables[0].Rows[0].ItemArray[8].ToString());
            if (success)        // if table retrieved okay
            {
                dataGridView1.DataSource = dataSet1;
                dataGridView1.DataMember = "DoctorTable";
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;      // select the entire row when clicking on a cell
                btnEdit.Enabled = true;
            }

        }

        private void DoctorSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doctorsDataSet.Doctor' table. You can move, or remove it, as needed.
            //this.doctorTableAdapter.Fill(this.doctorDataSet.Doctor);
        }

        private void TxtDocIdSearch_Leave(object sender, EventArgs e)
        {

        }

        private void TxtDocSurnameSearch_Leave(object sender, EventArgs e)
        {

        }

        private void TxtDocDeptSearch_Leave(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmDoctor newDoctor = new frmDoctor(null);
            newDoctor.Show();
        }

        private void doctorBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int doctorID;
            int currentRow;
            try
            {

                currentRow = this.dataGridView1.CurrentRow.Index;
                Console.WriteLine("current row is "+currentRow);
                doctorID = (int)this.dataGridView1.CurrentRow.Cells[0].Value;       // get the doctorID of the current selected row
            } catch (Exception e1)
            {
                MessageBox.Show("Unable to edit.\n\nYou must first select a single row from the grid of doctors.", "No doctor selected");
                return;
            }
            //  get the row of the dataset that is selected
            DataRow dRow = dataSet1.Tables[0].Rows[currentRow];
            Doctor editDoc = new Doctor();
            editDoc.DocId = doctorID;
            editDoc.DocSurname = dRow.ItemArray.GetValue(1).ToString();
            editDoc.DocForename = dRow.ItemArray.GetValue(2).ToString();
            Object objPhoto = dRow.ItemArray.GetValue(3);
            Console.WriteLine("******* objPhoto is "+objPhoto.ToString());
            if (objPhoto.Equals(System.DBNull.Value))           // cannot cast null to a byte array
                editDoc.DocPhoto = null;
            else
                editDoc.DocPhoto = (byte[])objPhoto;
            editDoc.DocGender = (bool)dRow.ItemArray.GetValue(4);
            editDoc.DocAddress = dRow.ItemArray.GetValue(5).ToString();
            editDoc.DocPhoneNumber = dRow.ItemArray.GetValue(6).ToString();
            editDoc.DocQualification = dRow.ItemArray.GetValue(7).ToString();
            editDoc.DeptId = (int)dRow.ItemArray.GetValue(8);
            this.Dispose();
            frmDoctor editDoctor = new frmDoctor(editDoc);
            editDoctor.Show();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                Console.WriteLine("value at index 4 is "+e.Value);
                bool gender;
                gender = (bool)(e.Value);
                if (gender)
                    e.Value = "M";
                else
                    e.Value = "F";
                e.FormattingApplied = true;
            } else if (e.ColumnIndex == 6 && e.Value != null)
            {
                Console.WriteLine("phone number is " + e.Value.ToString());
            }
            else if (e.ColumnIndex == 7 && e.Value != null)
            {
                Console.WriteLine("department ID is " + e.Value);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
