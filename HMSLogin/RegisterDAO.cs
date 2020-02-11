using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HMSLogin
{
    class RegisterDAO
    {
        public bool RegisterLogin(RegisterDetails registerdetails)
        {
            string connectionString =
                "Data Source=SD-;" +
                "Initial Catalog=;" +
                "Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertCommand =
                        "INSERT INTO Patient (FirstName, SurName, Gender, Address, DOB, MobileNo, PersonName, PhoneNo, Relationship) " +
                        "VALUES(@FirstName, @SurName, @Gender, @Address, @DOB, @MobileNo, @PersonName, @PhoneNo, @Relationship)";

                    SqlCommand command = new SqlCommand();
                    command.CommandText = insertCommand;
                    command.Connection = connection;
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@FirstName",
                        Value = registerdetails.FirstName,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 50
                    };
                    command.Parameters.Add(parameter);

                    command.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@SurName",
                        Value = registerdetails.SurName,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 50
                    });

                    command.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Gender",
                        Value = registerdetails.Gender,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 50
                    });

                    command.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Address",
                        Value = registerdetails.Address,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 50
                    });

                    command.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@DOB",
                        Value = registerdetails.DOB,
                        SqlDbType = SqlDbType.DateTime,
                        Size = 50
                    });

                    command.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@MobileNo",
                        Value = registerdetails.MobileNo,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 50
                    });

                    command.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@PersonName",
                        Value = registerdetails.PersonName,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 50
                    });

                    command.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@PhoneNo",
                        Value = registerdetails.PhoneNo,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 50
                    });

                    command.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@Relationship",
                        Value = registerdetails.Relationship,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 50
                    });
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("A database occured: " + ex);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("A database occured: " + ex);
                return false;
            }
            return true;
        }
    }
}
