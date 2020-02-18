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
            DataSet dataSet1 = dao.searchDoctor(txtDocIdSearch.Text, txtDocSurnameSearch.Text, txtDocDeptSearch.Text, out bool success);
            //
            //  Two important properties of the DataGridView
            //  1. The DataSource connects up to the dataset
            //     which was returned to the searchLearner() method.
            //  2. The DataMember is the table name supplied
            //
            if (success)        // if table retrieved okay
            {
                dataGridView1.DataSource = dataSet1;
                dataGridView1.DataMember = "DoctorTable";
            }


        /*    using (connection1 = new SqlConnection(connectionString))
        {
            SqlCommand command1 = null;
            connection1.Open();
            if (connection1.State != ConnectionState.Open)
                MessageBox.Show("Unable to connect to database", "Cannot sign in", MessageBoxButtons.OK);
            else
            {
                string surname = txtDocSurnameSearch.Text;
                // @Username creates a placeholder for the parameter @title,
                // which must be declared and set up using an SqlParamater object underneath
                // and added to the SqlCommand's parameter's collection.
                string commandString;         // contains the SQL text to query the SQL Server database
                if (txtDocIdSearch.Text != string.Empty)
                {
                    commandString = "SELECT DocId FROM Doctor WHERE DocId=@DocId";
                    command1 = new SqlCommand(commandString, connection1);
                    // Create and set up SqlParameter
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@DocId",
                        Value = docId, 
                        SqlDbType = System.Data.SqlDbType.Int
                    };
                    // Add that parameter into the collection of
                    // Parameters on the Command object
                    command1.Parameters.Add(parameter);
                }
                else if (txtDocSurnameSearch.Text != string.Empty)
                {
                    commandString = "SELECT * FROM Doctor WHERE DocSurname=@DocSurname";
                    command1 = new SqlCommand(commandString, connection1);
                    // Create and set up SqlParameter
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@DocSurname",
                        Value = surname, 
                        SqlDbType = System.Data.SqlDbType.NVarChar,
                        Size = surname.Length
                    };
                    // Add that parameter into the collection of
                    // Parameters on the Command object
                    command1.Parameters.Add(parameter);
                }
                else if (txtDocDeptSearch.Text != string.Empty)
                {
                    commandString = "SELECT DocId, DocDeptId FROM Doctor WHERE DocDeptId=@DeptId";
                    command1 = new SqlCommand(commandString, connection1);
                    // Create and set up SqlParameter
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@DeptId",
                        Value = deptId, 
                        SqlDbType = System.Data.SqlDbType.Int
                    };
                    // Add that parameter into the collection of
                    // Parameters on the Command object
                    command1.Parameters.Add(parameter);
                }
                else
                {
                    commandString = "SELECT * FROM Doctor";
                    command1 = new SqlCommand(commandString, connection1);
                        Console.WriteLine("\ncommandString is "+commandString+"\nconnectionString is "+connectionString);
                }
                Console.WriteLine("***************\nThe command string is:  \n"+commandString+"\n*******************");
                Console.WriteLine("\n DocID is " + docId + ",      Doc surname is " + surname + ",              Dept Id is " + deptId);
                DoctorsDataSet doctorDataSet = new DoctorsDataSet();
                using (SqlDataAdapter da = new SqlDataAdapter(command1))
                {
                    doctorDataSet.Clear();
                    da.Fill(doctorDataSet, "Doctor");
                    DoctorsDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter = new DoctorsDataSetTableAdapters.DoctorTableAdapter();
                    doctorTableAdapter.Fill(doctorDataSet.Doctor);
                    //this.doctorTableAdapter.Fill(doctorDataSet.Doctor);
                    dataGridView1.DataSource = doctorDataSet.Doctor.DefaultView;
                    Console.WriteLine("\n  **************     dataGridView.DataSource is " +dataGridView1.DataSource.ToString());
                        dataGridView1.Refresh();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                    //Console.WriteLine("dataSet is "+ dataSet.Tables["Login"].Rows[0]+", dataSet.ToString() is "+dataSet.ToString());
                    /*try
                    {
                        string passwordMatch = dataSet.Tables["Login"].Rows[0]["Password"].ToString();
                        if (Int32.TryParse(dataSet.Tables["Doctor"].Rows[0]["UserID"].ToString(), out int foundUserID))
                        {
                            if (!password.Equals(passwordMatch))
                            {
                                MessageBox.Show("Invalid password entered.\r\nPlease try again.", "Wrong password entered", MessageBoxButtons.OK);
                                LblPassword.ForeColor = Color.Red;
                                TxtPassword.Focus();
                                TxtPassword.SelectAll();
                            }
                            else
                            {
                                string role = dataSet.Tables["Login"].Rows[0]["Role"].ToString();
                                LogInID = foundUserID;
                                commandString = "SELECT FirstName, LastName FROM Customer " +
                                    "WHERE UserID=@UserID";
                                SqlCommand command2 = new SqlCommand(commandString, connection1);
                                // Create and set up SqlParameter
                                parameter = new SqlParameter
                                {
                                    ParameterName = "@UserID",
                                    Value = LogInID, // comes from the bug
                                                     // object passed fromt the form into this
                                                     // insertBook() method.
                                    SqlDbType = System.Data.SqlDbType.Int
                                };
                                // Add that parameter into the collection of
                                // Parameters on the Command object
                                command2.Parameters.Add(parameter);
                                dataSet = new DataSet();
                                using (SqlDataAdapter da2 = new SqlDataAdapter(command2))
                                {
                                    da2.Fill(dataSet, "Customer");
                                    //Console.WriteLine("dataSet is "+ dataSet.Tables["Login"].Rows[0]+", dataSet.ToString() is "+dataSet.ToString());
                                    try
                                    {
                                        CustomerName = dataSet.Tables["Customer"].Rows[0]["FirstName"].ToString() + " " +
                                            dataSet.Tables["Customer"].Rows[0]["LastName"].ToString();
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error on retrieving user details from Cutomer:  " + ex.Message);
                                        MessageBox.Show("User Details not found", "Error on logging in.", MessageBoxButtons.OK);
                                        TxtUsername.Text = string.Empty;
                                        TxtUsername.Focus();
                                        TxtUsername.SelectAll();
                                    }
                                }
                                if (role.ToUpper().Equals("PROGRAMMER"))
                                {
                                    FrmProgrammer openProgrammer = new FrmProgrammer();
                                    this.Hide();
                                    openProgrammer.Show();
                                }
                                else
                                {
                                    FrmBugReport openMainForm = new FrmBugReport();
                                    this.Hide();
                                    openMainForm.Show();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("User Details not found", "Error on logging in.", MessageBoxButtons.OK);
                            TxtUsername.Text = string.Empty;
                            TxtUsername.Focus();
                            TxtUsername.SelectAll();
                        }
                    }
                    catch (IndexOutOfRangeException ex1)
                    {
                        MessageBox.Show("Username Not found", "Invalid username", MessageBoxButtons.OK);
                        LblUsername.ForeColor = Color.Red;
                        TxtUsername.Focus();
                        TxtUsername.SelectAll();
                    }
                }*/
        }

        private void DoctorSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doctorsDataSet.Doctor' table. You can move, or remove it, as needed.
            //this.doctorTableAdapter.Fill(this.doctorDataSet.Doctor);
        }

        private void TxtDocIdSearch_Leave(object sender, EventArgs e)
        {
            /*if (txtDocIdSearch.Text != string.Empty)
            {
                if (!int.TryParse(txtDocIdSearch.Text, out docId))
                {
                    MessageBox.Show("Doctor ID must be a whole number (only contains number 0 to 9)");
                }
                else
                {
                    txtDocSurnameSearch.Enabled = false;
                    txtDocDeptSearch.Enabled = false;
                }
            } else if (txtDocSurnameSearch.Text == string.Empty && txtDocDeptSearch.Text == string.Empty)
            {           // re-enable other text boxes if they are empty
                txtDocSurnameSearch.Enabled = true;
                txtDocDeptSearch.Enabled = true;
            }*/
        }

        private void TxtDocSurnameSearch_Leave(object sender, EventArgs e)
        {
            /*if (txtDocSurnameSearch.Text != string.Empty)
            {
                txtDocIdSearch.Enabled = false;
                txtDocDeptSearch.Enabled = false;
            } else if (txtDocIdSearch.Text == string.Empty && txtDocDeptSearch.Text == string.Empty)
            {           // re-enable other text boxes if they are empty
                txtDocIdSearch.Enabled = true;
                txtDocDeptSearch.Enabled = true;
            }*/
        }

        private void TxtDocDeptSearch_Leave(object sender, EventArgs e)
        {
            /*if (txtDocDeptSearch.Text != string.Empty)
            {
                if (!int.TryParse(txtDocDeptSearch.Text, out docId))
                {
                    MessageBox.Show("Department ID must be a whole number (only contains number 0 to 9)");
                }
                else
                {
                    txtDocIdSearch.Enabled = false;
                    txtDocSurnameSearch.Enabled = false;
                }
            }
            else if (txtDocIdSearch.Text == string.Empty && txtDocSurnameSearch.Text == string.Empty)
            {           // re-enable other text boxes if they are empty
                txtDocIdSearch.Enabled = true;
                txtDocSurnameSearch.Enabled = true;
            }*/
        }
    }
}
