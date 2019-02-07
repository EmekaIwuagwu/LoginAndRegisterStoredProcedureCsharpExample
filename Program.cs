using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWithSP
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginTestWithStoredProcedures();
        }

        private static void LoginTestWithStoredProcedures()
        {
            string constring = @"Data Source=DESKTOP-V4GG52H\SQLEXPRESS;Initial Catalog=PeopleBase;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open(); // Open SQL Connection
                using (SqlCommand cmd = new SqlCommand("LoginUser", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", "Eiwuagwu");
                    cmd.Parameters.AddWithValue("@pwd", "22suarez");
                    try
                    {
                        int usercount = (Int32)cmd.ExecuteScalar();// for taking single value

                        if (usercount == 1)  // comparing users from table 
                        {
                            Console.WriteLine("I Am logged in using Stored Procedures!");
                            Console.ReadLine();
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.ToString());
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
