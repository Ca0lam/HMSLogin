using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSLogin
{
    class DoctorDAO
    {
        //
        // A connection object that will be used by all objects in this class
        //
        private readonly SqlConnection connection1;
        //
        // This is a constructor used for initialising any class member variables i.e. the connection reference above
        //
        public DoctorDAO()
        {
            this.connection1 = new SqlConnection
            {
                 ConnectionString = "Data Source = SD-15;" +
                 "Initial Catalog=HospitalMS;" +
                 "Integrated Security = True;"
            };
        }
        public bool insertDoctor(Doctor doc, out int newID)
        {
            bool success = false;
            newID = 0;              // default for new ID
            //doc.DocPhoto = new byte[] { };
            
            // 1. declare the SQL statement (for the command)
            //    each parameter must be declared and added to the commands parameters collection
            string sqlInsert = "INSERT INTO tblDoctorDetails " +
                "(DocForename, DocSurname, DocPhoto, DocGender, DocAddress, DocPhoneNumber, DocQualification, DeptId) " +
                "VALUES (@Forename,  @Surname, @Photo, @Gender, @Address, @Phone, @Qualification, @DeptId); " +
                "SELECT SCOPE_IDENTITY();";
            Console.WriteLine("sqlInsert is " + sqlInsert);
            try
            {
                // 3. set up a command object
                SqlCommand command1 = new SqlCommand(sqlInsert, connection1);
                // 4. set up all parameters
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Forename",
                    Value = doc.DocForename,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Surname",
                    Value = doc.DocSurname,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50          
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Photo",
                    Value = doc.DocPhoto,
                    SqlDbType = SqlDbType.Image
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Gender",
                    Value = doc.DocGender,
                    SqlDbType = SqlDbType.Bit
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Address",
                    Value = doc.DocAddress,
                    SqlDbType = SqlDbType.VarChar,
                    Size = -1                       // -1 is for the Max allowed
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Phone",
                    Value = doc.DocPhoneNumber,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50                    
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Qualification",
                    Value = doc.DocQualification,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@DeptId",
                    Value = doc.DeptId,
                    SqlDbType = SqlDbType.Int
                });
                // 5. open the connection
                connection1.Open();
                Console.WriteLine("**********before ExectueScalar");
                // 6. execute NonQuery
                // int numOfRows = command1.ExecuteNonQuery();
                //newID = int.Parse(command1.ExecuteScalar().ToString());           // ExecuteScalar returns an object of the first column of the updated/inserted row
                newID = int.Parse(command1.ExecuteScalar().ToString());           // ExecuteScalar returns an object of the first column of the updated/inserted row
                Console.WriteLine("********* numOfRows is " + newID.ToString());
                // 7. check the insert worked
                //    will be 1 if successful, 0 if failed
                if (newID > 0)     // if ID was returned from the ExecuteNonQuery method, it worked
                    success = true;
                else
                    success = false;
                // 8. close the connection
            }
            catch (SqlException ex1)
            {
                Console.WriteLine("  ***************    A database error occurred: \n" + ex1);
                success = false;
            }
            catch (Exception ex2)
            {
                Console.WriteLine("  **************    A non-database exception occurred: \n" + ex2);
                success = false;
            }
            finally
            {
                if (connection1.State != ConnectionState.Closed)
                    connection1.Close();
            }

            return success;
        }
        public bool updateDoctor(Doctor doc)
        {
            bool success = false;
            try
            {
                String updateSQL = "UPDATE tblDoctorDetails " +
                    "SET DocForename = @Forename, " +
                    "DocSurname = @Surname, " +
                    "DocPhoto = @Photo, " +
                    "DocGender = @Gender, " +
                    "DocAddress = @Address, " +
                    "DocPhoneNumber = @Phone, " +
                    "DocQualification = @Qualification, " +
                    "DeptId = @DeptId " +
                    "WHERE DocId = @ID;";
                // 3. set up a command object
                SqlCommand command1 = new SqlCommand(updateSQL, connection1);
                // 4. set up all parameters
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Forename",
                    Value = doc.DocForename,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Surname",
                    Value = doc.DocSurname,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Photo",
                    Value = doc.DocPhoto,
                    SqlDbType = SqlDbType.Image
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Gender",
                    Value = doc.DocGender,
                    SqlDbType = SqlDbType.Bit
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Address",
                    Value = doc.DocAddress,
                    SqlDbType = SqlDbType.VarChar,
                    Size = -1                       // -1 is for the Max allowed
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Phone",
                    Value = doc.DocPhoneNumber,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Qualification",
                    Value = doc.DocQualification,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@DeptId",
                    Value = doc.DeptId,
                    SqlDbType = SqlDbType.Int
                });
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@ID",
                    Value = doc.DocId,
                    SqlDbType = SqlDbType.Int
                });
                // open the connection 
                connection1.Open();
                Console.WriteLine("****** doctor object is " + doc.ToString());
                Console.WriteLine("****** updateSQL is "+updateSQL);
                int numOfRows = command1.ExecuteNonQuery();
                Console.WriteLine("*********** numOfRows is "+numOfRows.ToString());
                if (numOfRows == 1)
                    success = true;
            }
            catch (SqlException ex1)
            {
                Console.WriteLine("*********** SQL exception ************\n" + ex1);
            }
            catch (Exception ex2)
            {
                Console.WriteLine("*********** non-SQL exception ************\n" + ex2);
            }
            finally
            {
                if (connection1.State != ConnectionState.Closed)
                    connection1.Close();
            }
            return success;
        }
        public DataSet searchDoctor(String searchID, String searchSurname, String searchDept, out bool success)
        {
            success = false;
            bool whereIncluded = false;
            String sqlText = "SELECT * FROM tblDoctorDetails";
            if (searchID != string.Empty)
            {
                sqlText += $" WHERE DocID = '{searchID}'";
                whereIncluded = true;
            } 
            if (searchSurname != string.Empty)
            {
                if (whereIncluded)
                    sqlText += " AND ";
                else
                    sqlText += " WHERE ";
                sqlText += $"DocSurname = '{searchSurname}'";
                whereIncluded = true;
            } 
            if (searchDept != string.Empty)
            {
                if (whereIncluded)
                    sqlText += " AND ";
                else
                    sqlText += " WHERE ";
                sqlText += $"DeptID = '{searchDept}'";
            }
            sqlText += ";";
            Console.WriteLine("sqlText is "+sqlText);
            //  declare a DataSet before the try block, so that it can be returned after the try block
            //  if you declare a variable inside the try block it cannot be seen outside the try block
            DataSet dataSet1 = new DataSet();
            try
            {
                SqlCommand command1 = new SqlCommand(sqlText, connection1);
                //
                // the data adapter object can execute commands against the database
                // and populate a DataSet object with results
                // The datagrid on the search form can be connected directly to a DataSet
                // 
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(command1);
                //
                //  To execute the SQL command, use the dataAdapter's fill method.
                //  The fill method of the dataAdapter will put the results from the SELECT command into the dataset
                //  and you can optionally specify the table name where the results will go.
                //  The Fill method automatically opens and closes the connection (do not need to specify connection1.Open() or connection1.Close()
                //
                dataAdapter1.Fill(dataSet1, "DoctorTable");
                Console.WriteLine("dataSet1 index 0 is "+dataSet1.Tables[0].Rows[0].ItemArray[0].ToString());
                Console.WriteLine("dataSet1 index 1 is " + dataSet1.Tables[0].Rows[0].ItemArray[1].ToString());
                Console.WriteLine("dataSet1 index 2 is " + dataSet1.Tables[0].Rows[0].ItemArray[2].ToString());
                Console.WriteLine("dataSet1 index 3 is " + dataSet1.Tables[0].Rows[0].ItemArray[3].ToString());
                Console.WriteLine("dataSet1 index 4 is " + dataSet1.Tables[0].Rows[0].ItemArray[4].ToString());
                Console.WriteLine("dataSet1 index 5 is " + dataSet1.Tables[0].Rows[0].ItemArray[5].ToString());
                Console.WriteLine("dataSet1 index 6 is " + dataSet1.Tables[0].Rows[0].ItemArray[6].ToString());
                Console.WriteLine("dataSet1 index 7 is " + dataSet1.Tables[0].Rows[0].ItemArray[7].ToString());
                Console.WriteLine("dataSet1 index 8 is " + dataSet1.Tables[0].Rows[0].ItemArray[8].ToString());
                success = true;
            }
            catch (SqlException ex1)
            {
                Console.WriteLine("*************** SQL exception \n" + ex1);
            }
            catch (Exception ex2)
            {
                Console.WriteLine("*************** non-SQL exception  \n" + ex2);
            }
            return dataSet1;
        }

    }

    /*
    public List<Doctor> getDoctorsFromDatabase(out bool success)
        {

            List<Doctor> listOfDoctors = new List<Doctor>();
            //System.Data.Linq.Table<tblDoctorDetail> listOfDoctors = null;
            try
            {
                /*DataClasses1DataContext hMSDataContext = new DataClasses1DataContext();
                listOfDoctors = hMSDataContext.GetTable<tblDoctorDetail>();

                listOfDoctors.Where(x => x.DocId != 1000);

                string connectionString = "Data Source=SD-15; " +
                    "Initial Catalog=HospitalMS; " +
                    "Integrated Security=true; ";
                // A using statement will automatically close a resource for you,
                // when the using block finishes.
                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    connection1.Open();
                    success = false;
                    string selectSQL = "SELECT * FROM Doctor;";              // This is the select statement we want to send to the database
                    SqlCommand selectCommand = new SqlCommand(selectSQL, connection1);
                    //  Declare a DataReader and execute the command
                    SqlDataReader dataReader1 = selectCommand.ExecuteReader();
                    Console.WriteLine("********************");
                    //  Loop through rows using DataReader
                    while (dataReader1.Read())
                    {
                        //  Turn each row into a Learner object
                        Doctor doctor = new Doctor();
                        //
                        // The dataReader has an [indexer method] for accessing each column on the current row
                        // The dataReader returns an object type which must be (cast) into the correct type each time.
                        doctor.DocId = (int)dataReader1["DoctorID"];
                        doctor.DocForename = (string)dataReader1["DocForename"];
                        doctor.DocSurname = (string)dataReader1["DocSurname"];
                        doctor.DocSurname = (string)dataReader1["DocSurname"];
                        doctor.DocPhoto = (byte[])dataReader1["Photo"];
                        doctor.DocAddress = (string)dataReader1["DocAddress"];
                        doctor.DocPhoneNumber = (string)dataReader1["DocPhoneNum"];
                        doctor.DocQualification = (string)dataReader1["DocQualification"];
                        doctor.DeptId = (int)dataReader1["DeptId"];
                        //
                        //  Add each object to the List
                        //
                        Console.WriteLine("Doctor added to list: \r\n" + doctor.ToString());
                        listOfDoctors.Add(doctor);
                    }
                    success = true;
                }
            }
            catch (SqlException ex1)
            {

                System.Diagnostics.Debug.WriteLine("A database error occurred: " + ex1.Message);
                success = false;
            }
            catch (InvalidOperationException ex2)
            {
                Console.WriteLine("A database error occurred: " + ex2.Message);
                success = false;
            }
            catch (Exception ex3)
            {
                Console.WriteLine("An error occurred: " + ex3.Message);
                success = false;
            }
            return listOfDoctors;
        }
    }*/
}
