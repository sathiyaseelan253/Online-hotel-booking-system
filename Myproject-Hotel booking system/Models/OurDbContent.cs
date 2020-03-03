using System;
using System.Data.Entity;
using User.Entity;

namespace Myproject_Hotel_booking_system.Models
{
    public class OurDbContent : DbContext
    {
       
         public DbSet<SignUp_Account> userDetails { get; set; }
        
        public static bool Autheticate_User(Login_Account account)
        {
            return true;
        }
        public void AddUser(SignUp_Account user)
        {
            SignUp_Account newUser = new SignUp_Account();
            try
            {
                using (OurDbContent content = new OurDbContent())
                {
                    content.userDetails.Add(user);
                    content.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
      
 }



//public DbSet<UserDetails> userAccounts { get; set; }
//public static bool Autheticate_UserUser(Login_Account account)
//{
//private static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;


//using (SqlConnection con = new SqlConnection(connectionString))
//{
//    SqlCommand com = new SqlCommand("sp_CheckUser", con);
//    com.CommandType = CommandType.StoredProcedure;
//    SqlParameter p1 = new SqlParameter("@userName", userName);
//    SqlParameter p2 = new SqlParameter("@password", pass);
//    com.Parameters.Add(p1);
//    com.Parameters.Add(p2);
//    con.Open();
//    SqlDataReader rd = com.ExecuteReader();
//    if (rd.HasRows)
//    {
//        rd.Read();
//        return true;
//    }
//    else
//    {
//        return false;

//    }
//}

//public void AddUser(SignUp_Account user)
//{


//    using (SqlConnection con = new SqlConnection(connectionString))
//    {
//        SqlCommand cmd = new SqlCommand("spAddUser", con);
//        cmd.CommandType = CommandType.StoredProcedure;

//        SqlParameter paramUserName = new SqlParameter();
//        paramUserName.ParameterName = "@userName";
//        paramUserName.Value = user.userName;
//        cmd.Parameters.Add(paramUserName);

//        SqlParameter paramFirstName = new SqlParameter();
//        paramFirstName.ParameterName = "@firstName";
//        paramFirstName.Value = user.firstName;
//        cmd.Parameters.Add(paramFirstName);

//        SqlParameter paramLastName = new SqlParameter();
//        paramLastName.ParameterName = "@lastName";
//        paramLastName.Value = user.lastName;
//        cmd.Parameters.Add(paramLastName);

//        SqlParameter paramEmail = new SqlParameter();
//        paramEmail.ParameterName = "@Email";
//        paramEmail.Value = user.Email;
//        cmd.Parameters.Add(paramEmail);

//        SqlParameter paramPassword = new SqlParameter();
//        paramPassword.ParameterName = "@Password";
//        paramPassword.Value = user.Password;
//        cmd.Parameters.Add(paramPassword);

//        con.Open();
//        cmd.ExecuteNonQuery();
//    }
//}
//    }
//}