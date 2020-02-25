using System;
using System.Data;
using System.Windows.Forms;

namespace HMSLogin
{
    public partial class DoctorSearchForm : Form
    {
        DoctorDAO dao = new DoctorDAO();                // data access object for communicating with the database
        DataSet dataSet1;                               // dataset that the doctor table is read into 
        public DoctorSearchForm()                       // constructor for new Search form
        {
            InitializeComponent();
        }
        private void BtnLogOut_Click(object sender, EventArgs e)        // button to leave the search form and return to the Log in screen
        {
            this.Dispose();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)        // search the dataset returned from the database for doctors based on search text boxes
        {
            //  Call the searchDoctor method in the DAO class, which returns a dataset
            //  The dataset contains a single data table called DoctorTable
            // the searchDoctor method needs 3 values (from the comboBoxes and text box)
            dataSet1 = dao.searchDoctor(txtDocIdSearch.Text, txtDocSurnameSearch.Text, txtDocDeptSearch.Text, out bool success);
            //
            //  Two important properties of the DataGridView
            //  1. The DataSource connects up to the dataset
            //     which was returned to the searchDoctor() method.
            //  2. The DataMember is the table name supplied
            //
            if (success)        // if table retrieved okay
            {
                dataGridView1.DataSource = dataSet1;
                dataGridView1.DataMember = "DoctorTable";
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;      // select the entire row when clicking on a cell
                btnEdit.Enabled = true;                                                     // allow view or edit of a single doctor
            }
        }
        /*
         *   When the "Add Doctor" button is clicked, 
         *   then dispose of the search form and create and show the form for an individual doctor (with fields blank)
         */
        private void btnAddNew_Click(object sender, EventArgs e)        
        {
            this.Dispose();                                 // get rid of search form
            frmDoctor newDoctor = new frmDoctor(null);      // create an empty doctor form 
            newDoctor.Show();                               // display the new (empty) doctor form
        }
        /*
         *  When the View/Edit button is clicked,
         *  then dispose of the search form and display the form for an individual doctor of 
         *  the row selected in the datagrid
         */
        private void btnEdit_Click(object sender, EventArgs e)          
        {
            int doctorID;
            int currentRow;
            DataRow dRow;                                                           // row of a table in the dataset
            try
            {
                currentRow = this.dataGridView1.CurrentRow.Index;                   // detect the currently selected row
                doctorID = (int)this.dataGridView1.CurrentRow.Cells[0].Value;       // get the doctorID of the current selected row
                dRow = dataSet1.Tables[0].Rows[currentRow];                         //  get the row of the table (in dataset) that is selected
            } catch (Exception e1)                                                  // if any problem,
            {                                                                       // display an error message and exit method
                MessageBox.Show("Unable to edit.\n\nYou must first select a single row from the grid of doctors.", "No doctor selected");
                return;
            }
            Doctor editDoc = new Doctor();                                          // new Doctor object for the selected doctor
            editDoc.DocId = doctorID;                                               // populate the doctor ID
            editDoc.DocSurname = dRow.ItemArray.GetValue(2).ToString();             // populate the other fields of Doctor object from the 
            editDoc.DocForename = dRow.ItemArray.GetValue(1).ToString();            //    Row of the table in the dataset
            Object objPhoto = dRow.ItemArray.GetValue(3);
            if (objPhoto.Equals(System.DBNull.Value))           // cannot cast null to a byte array
                editDoc.DocPhoto = null;
            else
                editDoc.DocPhoto = (byte[])objPhoto;
            editDoc.DocGender = (bool)dRow.ItemArray.GetValue(4);
            editDoc.DocAddress = dRow.ItemArray.GetValue(5).ToString();
            editDoc.DocPhoneNumber = dRow.ItemArray.GetValue(6).ToString();
            editDoc.DocQualification = dRow.ItemArray.GetValue(7).ToString();
            editDoc.DeptId = (int)dRow.ItemArray.GetValue(8);
            this.Dispose();                                                         // dispose the search form
            frmDoctor editDoctor = new frmDoctor(editDoc);                          // create doctor form from the editDoctor object
            editDoctor.Show();                                                      // display the doctor object
        }
        /*
         * format the cells in the datagrid view
         */
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //  for the column displaying gender, show 'M' or 'F' rather than 'true' or 'false'
            //  but only if it contains a non-null value and there is data in the datagrid (Edit button is enabled)
            if (e.ColumnIndex == 4 && e.Value != null && btnEdit.Enabled)
            {
                try
                {
                    bool gender;
                    gender = (bool)(e.Value);
                    if (gender)
                        e.Value = "M";
                    else
                        e.Value = "F";
                    e.FormattingApplied = true;
                } catch (Exception ex1)
                {
                }
            }
        }
        /*
         * double clicking on a cell in the datagrid view will display the doctor form for the doctor at that row
         */
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);                   // call method for Edit button which performs the same functionality
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void DoctorSearchForm_Load(object sender, EventArgs e)
        {
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
        private void doctorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }
    }
}
