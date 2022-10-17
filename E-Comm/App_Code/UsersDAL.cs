using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace E_Comm.App_Code
{
    // DAL - data access layer class
    public class UsersDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public UsersDAL()
        {
            con = new SqlConnection(DbConnectionStr.GetDbConnectionStr());
        }
        public int SaveNewUser(Users user)
        {
            int result;
            try
            {
                string str = "insert into Users values(@firstname,@lastname,@username,@email,@password)";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@firstname", user.FirstName);
                cmd.Parameters.AddWithValue("@lastname", user.LastName);
                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@password", user.Password);
                // code goes here to add all parameters one by one
                con.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
            return result;

        }

        public Users Login(Users user)
        {
            Users users = new Users();
            string str = "select * from Users where Email=@email";
            cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@email", user.Email);
            con.Open();
            dr = cmd.ExecuteReader();
            
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    users.Id = Convert.ToInt32(dr["Id"]);
                    users.FirstName = dr["FirstName"].ToString();
                    users.UserName = dr["UserName"].ToString();
                    users.Email = dr["Email"].ToString();
                    users.Password = dr["Password"].ToString();
                }
            }
            return users;
        }
    }
}