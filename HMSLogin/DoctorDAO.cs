using System;
using System.Data;
using System.Data.SqlClient;

namespace HMSLogin
{
    class DoctorDAO
    {
        /*
        * A connection object that will be used by all objects in this class
        */
        private readonly SqlConnection connection1;
        /*
        * This is a constructor used for initialising the connection reference above
        */
        public DoctorDAO()
        {
            this.connection1 = new SqlConnection
            {
                ConnectionString = "Data Source = SD-15;" +
                 "Initial Catalog=HospitalMS;" +
                 "Integrated Security = True;"
            };
        }
        /*
         * insertDoctor method for adding a new Doctor to the database
         */
        public bool insertDoctor(Doctor doc, out int newID)
        {
            bool success = false;               // return parameter to indicate success/failur
            bool photoSupplied = true;          // need to detect if a photo exists or not
            string sqlInsert;                   // string for SQL insert command
            newID = 0;                          // default for new ID
            if (doc.DocPhoto == null)           // if no photo supplied 
                photoSupplied = false;          // indicate this
            // 1. declare the SQL statement (for the command)
            //    each parameter must be declared and added to the commands parameters collection
            if (photoSupplied)
                sqlInsert = "INSERT INTO tblDoctorDetails " +
                    "(DocForename, DocSurname, DocPhoto, DocGender, DocAddress, DocPhoneNumber, DocQualification, DeptId) " +
                    "VALUES (@Forename,  @Surname, @Photo, @Gender, @Address, @Phone, @Qualification, @DeptId); " +
                    "SELECT SCOPE_IDENTITY();";
            else            // have a different INSERT statement that does not include parameter for photo if no photo is supplied
                sqlInsert = "INSERT INTO tblDoctorDetails " +
                    "(DocForename, DocSurname, DocGender, DocAddress, DocPhoneNumber, DocQualification, DeptId) " +
                    "VALUES (@Forename,  @Surname, @Gender, @Address, @Phone, @Qualification, @DeptId); " +
                     "SELECT SCOPE_IDENTITY();";
            Console.WriteLine("sqlInsert is " + sqlInsert);     // write SQL insert to console
            try
            {
                // 2. set up a command object
                SqlCommand command1 = new SqlCommand(sqlInsert, connection1);
                // 3. set up all parameters
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
                if (photoSupplied)                      // only include @Photo parameter if a photo was supplied
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
                // 4. open the connection
                connection1.Open();
                // 5. ExecuteScalar
                // ExecuteScalar returns an object of the first column of the updated/inserted row
                newID = int.Parse(command1.ExecuteScalar().ToString());
                // 6. check the insert worked
                //    will be 1 if successful, 0 if failed
                if (newID > 0)                          // if ID was returned from the ExecuteNonQuery method, it worked
                    success = true;
                else
                    success = false;
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
                // 7. close the connection
                if (connection1.State != ConnectionState.Closed)
                    connection1.Close();
            }
            return success;
        }
        /*
         * updateDoctor method for updating details for a doctor 
         * that already exists in the database
         */
        public bool updateDoctor(Doctor doc)
        {
            bool success = false;
            string updateSQL;                           // string for SQL update command
            bool photoSupplied = true;                  // indicator for whether a photo was supplied or not
            if (doc.DocPhoto == null)                   // if no photo supplied,
                photoSupplied = false;                  //      indicate this
            try
            {
                // 1. declare the SQL statement (for the command)
                //    each parameter must be declared and added to the commands parameters collection
                if (photoSupplied)                      // do not include @Photo parameter if no photo was supplied
                    updateSQL = "UPDATE tblDoctorDetails " +
                        "SET DocForename = @Forename, " +
                        "DocSurname = @Surname, " +
                        "DocPhoto = @Photo, " +
                        "DocGender = @Gender, " +
                        "DocAddress = @Address, " +
                        "DocPhoneNumber = @Phone, " +
                        "DocQualification = @Qualification, " +
                        "DeptId = @DeptId " +
                        "WHERE DocId = @ID;";
                else
                    updateSQL = "UPDATE tblDoctorDetails " +
                        "SET DocForename = @Forename, " +
                        "DocSurname = @Surname, " +
                        "DocGender = @Gender, " +
                        "DocAddress = @Address, " +
                        "DocPhoneNumber = @Phone, " +
                        "DocQualification = @Qualification, " +
                        "DeptId = @DeptId " +
                        "WHERE DocId = @ID;";
                // 2. set up a command object
                SqlCommand command1 = new SqlCommand(updateSQL, connection1);
                // 3. set up all parameters
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
                if (photoSupplied)                  // do not include the photo parameter, if no photo was supplied
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
                // 4. open the connection 
                connection1.Open();
                Console.WriteLine("****** updateSQL is " + updateSQL);        // write the SQL to the console
                // 5. executeNonQuery, which returns the number of rows updated
                int numOfRows = command1.ExecuteNonQuery();
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
                //  6.  close the connection
                if (connection1.State != ConnectionState.Closed)
                    connection1.Close();
            }
            return success;
        }
        /*
         * Search the doctor table in the database for a doctor or doctors depending
         * upon the search criteria of the three textboxes on the search form.
         */
        public bool searchDepartment(int deptID)
        {
            bool success = false;
            SqlDataReader rdr = null;

            try
            {
                // Open connection to the database
                connection1.Open();
                // Set up a command with the given query and associate
                // this with the current connection.
                string CommandText = "SELECT DeptId" +
                                     "  FROM tblDeptDetails" +
                                     " WHERE (DeptId = @Find)";
                SqlCommand cmd = new SqlCommand(CommandText);
                cmd.Connection = connection1;

                // Add LastName to the above defined paramter @Find
                cmd.Parameters.Add(
                    new SqlParameter(
                    "@Find",                // The name of the parameter to map
                    System.Data.SqlDbType.Int,      // SqlDbType values
                    8,                      // The width of the parameter
                    "DeptId"));             // The name of the source column

                // Fill the parameter with the value retrieved
                // from the text field
                cmd.Parameters["@Find"].Value = deptID;

                // Execute the query
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    success = true;
                }
            }
            catch (SqlException ex1)
            {
                Console.WriteLine("*************** SQL exception \n" + ex1);
            }
            catch (Exception ex2)
            {
                Console.WriteLine("*************** non-SQL exception  \n" + ex2);
            }  finally
            {
                // Close data reader object and database connection
                if (rdr != null)
                    rdr.Close();

                if (connection1.State == ConnectionState.Open)
                    connection1.Close();
            }
            return success;
        }
        /*
        * Search the doctor table in the database for a doctor or doctors depending
        * upon the search criteria of the three textboxes on the search form.
        */
        public DataSet searchDoctor(String searchID, String searchSurname, String searchDept, out bool success)
        {
            success = false;
            bool whereIncluded = false;             // indicate if a WHERE clause has already been added to the SQL statement or not
            String sqlText = "SELECT * FROM tblDoctorDetails";          // select SQL
            if (searchID != string.Empty)           // if search to be on doctor ID....
            {
                sqlText += $" WHERE DocID = '{searchID}'";      // add WHERE clause on the doctor ID supplied
                whereIncluded = true;              // indicate WHERE clause added to search SQL
            }
            if (searchSurname != string.Empty)     // if search to be on doctor surname
            {
                if (whereIncluded)                  // if WHERE clause already added, include an 'AND' for extra where clause
                    sqlText += " AND ";
                else
                    sqlText += " WHERE ";
                sqlText += $"DocSurname LIKE '%{searchSurname}%'";
                whereIncluded = true;               // indicate WHERE clause added to search SQL
            }
            if (searchDept != string.Empty)         // if search to be on department
            {
                if (whereIncluded)                  // if WHERE clause already added, include an 'AND' for extra where clause
                    sqlText += " AND ";
                else
                    sqlText += " WHERE ";
                sqlText += $"DeptID = '{searchDept}'";
            }
            sqlText += ";";                         // end delimiter for search SQL
            Console.WriteLine("sqlText is " + sqlText);           // write SQL statement to the console
            //  declare a DataSet before the try block, so that it can be returned after the try block
            //  if you declare a variable inside the try block it cannot be seen outside the try block
            DataSet dataSet1 = new DataSet();
            try
            {
                SqlCommand command1 = new SqlCommand(sqlText, connection1);
                /*
                *  The data adapter object can execute commands against the database
                *  and populates the DataSet object with results
                *  The datagrid on the search form can be connected directly to a DataSet
                */
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(command1);
                /*
                *  To execute the SQL command, use the dataAdapter's fill method.
                *  The fill method of the dataAdapter will put the results from the SELECT command into the dataset
                *  and you can optionally specify the table name where the results will go.
                *  The Fill method automatically opens and closes the connection (do not need to specify connection1.Open() or connection1.Close()
                */
                dataAdapter1.Fill(dataSet1, "DoctorTable");
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
            return dataSet1;            // return the dataset
        }
        /*
        * deleteDoctor method for deleting a doctor from the database 
        */
        public bool deleteDoctor(int docID)
        {
            bool success = false;
            string deleteSQL;                           // string for SQL delete command
            try
            {
                // 1. declare the SQL statement (for the command)
                //    The @ID parameter must be declared and added to the commands parameters collection
                deleteSQL = "DELETE FROM tblDoctorDetails " +
                    "WHERE DocId = @ID;";
                // 2. set up a command object
                SqlCommand command1 = new SqlCommand(deleteSQL, connection1);
                // 3. set up the @ID parameter
                command1.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@ID",
                    Value = docID,
                    SqlDbType = SqlDbType.Int
                });
                // 4. open the connection 
                connection1.Open();
                Console.WriteLine("****** deleteSQL is " + deleteSQL);        // write the SQL to the console
                                                                              // 5. executeNonQuery, which returns the number of rows updated
                int numOfRows = command1.ExecuteNonQuery();
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
                //  6.  close the connection
                if (connection1.State != ConnectionState.Closed)
                    connection1.Close();
            }
            return success;
        }
    }
}

 