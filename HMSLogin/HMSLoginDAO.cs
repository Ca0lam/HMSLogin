﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HMSLogin
{
    class HMSLoginDAO
    {

        public bool InputLogin(HMSLoginDetails hmslogindetails)
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

                    string selectCommand =
                        "SELECT Password FROM HMSLogin WHERE Name = @Name";

                    SqlCommand command = new SqlCommand();
                    command.CommandText = selectCommand;
                    command.Connection = connection;
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = hmslogindetails.Name,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 50
                    };
                    command.Parameters.Add(parameter);
                    string password = command.ExecuteScalar().ToString();
                    Console.WriteLine(password);
                    if (password == hmslogindetails.Password)
                    {
                        selectCommand =
                        "SELECT Role FROM HMSLogin WHERE Name = @Name";
                        command.CommandText = selectCommand;
                        string role = command.ExecuteScalar().ToString();
                        Console.WriteLine(role);
                        hmslogindetails.Role = role;
                    }
                    else
                    {
                        hmslogindetails.Password = string.Empty;
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("A database exception occured: " + ex);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("A database error occured: " + ex);
                return false;
            }
            return true;
        }
        public bool Testlogin()
        {
            string connectionString =
            "Data Source=;" +
            "Initial Catalog=;" +
            "Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    connection.Close();

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("A database error occured:" + ex);
                    return false;
                }

            }
            return true;
        }

    }
}
