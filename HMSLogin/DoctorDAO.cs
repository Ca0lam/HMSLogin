using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSLogin
{
    class DoctorDAO
    {
        public bool InsertDoctor(Doctor doc)
        {
            try
            {
                string connectionString = "Data Source=SD-14; " +
                    "Initial Catalog=Doctors; " +
                    "Integrated Security=true; ";
                // A using statement will automatically close a resource for you,
                // when the using block finishes.
                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    connection1.Open();
                    // @Title creates a placeholder for the parameter @title,
                    // which must be declared and set up using an SqlParamater object underneath
                    // and added to the SqlCommand's parameter's collection.
                    string commandString = "INSERT INTO Doctor " +
                    "(DocId, DocForename, DocSurname, DocPhoto, DocGender, DocAddres, DocPhoneNum, DocQualification, DeptId) " +
                    "VALUES (@DocId, @Forename,  @Surname, @Photo, @Gender, @Address, @Phone, @Qualification, @DeptId); " +
                    "SELECT SCOPE_IDENTITY();";
                    SqlCommand command1 = new SqlCommand(commandString, connection1);
                    // Create and set up SqlParameter
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@DocId",
                        Value = doc.DocID, // comes from the doctor
                                           // object passed fromt the form into this
                                           // insertDoctor() method.
                        SqlDbType = System.Data.SqlDbType.Int
                    };
                    // Add that parameter into the collection of
                    // Parameters on the Command object
                    command1.Parameters.Add(parameter);
                    // set up the product parameter
                    command1.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@DocForename",
                        Value = doc.DocForename, // comes from the doctor
                                                 // object passed fromt the form into this
                                                 // insertDoctor() method.
                        SqlDbType = System.Data.SqlDbType.NVarChar,
                        Size = doc.DocForename.Length  // The size set up in SQL server
                    });

                    // Add that parameter into the collection of
                    // Parameters on the Command object
                    command1.Parameters.Add(parameter);
                    // set up the product parameter
                    command1.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@DocSurname",
                        Value = doc.DocSurname, // comes from the doctor
                                                // object passed fromt the form into this
                                                // insertDoctor() method.
                        SqlDbType = System.Data.SqlDbType.NVarChar,
                        Size = doc.DocSurname.Length  // The size set up in SQL server
                    });

                    // Add that parameter into the collection of
                    // Parameters on the Command object
                    command1.Parameters.Add(parameter);
                    // set up the product parameter
                    command1.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@DocPhoto",
                        Value = doc.Photo, // comes from the doctor
                                           // object passed fromt the form into this
                                           // insertDoctor() method.
                        SqlDbType = System.Data.SqlDbType.NVarChar,
                        Size = doc.Photo.Length  // The size set up in SQL server
                    });

                    // Add that parameter into the collection of
                    // Parameters on the Command object
                    command1.Parameters.Add(parameter);
                    // set up the product parameter
                    command1.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@DocGender",
                        Value = doc.Gender, // comes from the doctor
                                            // object passed fromt the form into this
                                            // insertDoctor() method.
                        SqlDbType = System.Data.SqlDbType.NVarChar,
                        Size = 1  // The size set up in SQL server
                    });

                    // Add that parameter into the collection of
                    // Parameters on the Command object
                    command1.Parameters.Add(parameter);
                    // set up the product parameter
                    command1.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@DocAddress",
                        Value = doc.DocAddress, // comes from the doctor
                                                // object passed fromt the form into this
                                                // insertDoctor() method.
                        SqlDbType = System.Data.SqlDbType.NVarChar,
                        Size = doc.DocAddress.Length  // The size set up in SQL server
                    });

                    // Add that parameter into the collection of
                    // Parameters on the Command object
                    command1.Parameters.Add(parameter);
                    // set up the product parameter
                    command1.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@DocPhoneNum",
                        Value = doc.DocPhoneNum, // comes from the doctor
                                                 // object passed fromt the form into this
                                                 // insertDoctor() method.
                        SqlDbType = System.Data.SqlDbType.NVarChar,
                        Size = doc.DocPhoneNum.Length  // The size set up in SQL server
                    });

                    // Add that parameter into the collection of
                    // Parameters on the Command object
                    command1.Parameters.Add(parameter);
                    // set up the product parameter
                    command1.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@DocQualification",
                        Value = doc.DocQualification, // comes from the doctor
                                                      // object passed fromt the form into this
                                                      // insertDoctor() method.
                        SqlDbType = System.Data.SqlDbType.NVarChar,
                        Size = doc.DocQualification.Length  // The size set up in SQL server
                    });

                    command1.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@DocDeptId",
                        Value = doc.DeptId, // comes from the doctor
                                            // object passed fromt the form into this
                                            // insertDoctor() method.
                        SqlDbType = System.Data.SqlDbType.NVarChar,
                        Size = 4  // The size set up in SQL server
                    }); ;

                    // Execute the command
                    // convert the Integer object to a String, and then to a 
                    int lastID = Int32.Parse(command1.ExecuteScalar().ToString());
                    Console.WriteLine("returned ID is " + lastID.ToString());
                    if (lastID != 0)
                    {
                        doc.DocID = lastID;
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (SqlException ex1)
            {

                System.Diagnostics.Debug.WriteLine("A database error occurred: " + ex1.Message);
                return false;
            }
            catch (InvalidOperationException ex2)
            {
                Console.WriteLine("A database error occurred: " + ex2.Message);
                return false;
            }
            catch (Exception ex3)
            {
                Console.WriteLine("An error occurred: " + ex3.Message);
                return false;
            }
        }
        public List<Doctor> getDoctorsFromDatabase(out bool success)
        {
            List<Doctor> listOfDoctors = new List<Doctor>();
            try
            {
                string connectionString = "Data Source=SD-14; " +
                    "Initial Catalog=DoctorTracing; " +
                    "Integrated Security=true; ";
                // A using statement will automatically close a resource for you,
                // when the using block finishes.
                using (SqlConnection connection1 = new SqlConnection(connectionString))
                {
                    connection1.Open();
                    success = false;
                    string selectSQL = "SELECT * FROM Doctors;";              // This is the select statement we want to send to the database
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
                        doctor.DocID = (int)dataReader1["DoctorID"];
                        doctor.DocForename = (string)dataReader1["DocForename"];
                        doctor.DocSurname = (string)dataReader1["DocSurname"];
                        doctor.DocSurname = (string)dataReader1["DocSurname"];
                        doctor.Photo = (byte[])dataReader1["Photo"];
                        doctor.DocAddress = (string)dataReader1["DocAddress"];
                        doctor.DocPhoneNum = (string)dataReader1["DocPhoneNum"];
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
    }
}
