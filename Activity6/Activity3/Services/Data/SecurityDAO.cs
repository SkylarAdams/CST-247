using Activity3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Activity3.Services.Data
{
    public class SecurityDAO
    {
        string connectionString =
        "Data Source=(localdb)\\MSSQLLocalDB; initial catalog = Test; Integrated Security = True";
            
            //USER ID=Skylar.j.adams@gmail.com; Password=Titleist36";

            public bool FindByUser(UserModel user)
            {
            bool result = false;
            

            try
            {
                string query = "SELECT * FROM dbo.users WHERE USERNAME = @Username AND PASSWORD = @PASSWORD";

                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = user.Username;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = user.Password;

                    //open db connection
                    cn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                        result = true;
                    else
                        result = false;

                    //close db connection
                    cn.Close();

                }
            }
            catch (SqlException e)
            {
                throw e;
            }

            return result;

        }
       
    }
}