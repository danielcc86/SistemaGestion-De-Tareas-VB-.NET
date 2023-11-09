using Api_CRUD_GestionTareas.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace Api_CRUD_GestionTareas.Data
{
    public class UserData
    {
        public bool CreateUser(UsersModel User)
        {
            User.Password = ConvertirSha256(User.Password);

            using (SqlConnection oConnection = new Connection().getConnection)
            {                
                SqlCommand cmd = new SqlCommand("Create_Users", oConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Name", User.name));
                cmd.Parameters.Add(new SqlParameter("@LastName", User.lastName));
                cmd.Parameters.Add(new SqlParameter("@UserName", User.UserName));
                cmd.Parameters.Add(new SqlParameter("@Password", User.Password));

                try 
                { 
                    oConnection.Open();
                    cmd.ExecuteNonQuery();
                    return true;                                
                } 
                catch (Exception ex) 
                { 
                    return false;
                }
            }
        }

        //metodo que me permite encriptar clave
        public static string ConvertirSha256(string texto)
        {
            StringBuilder sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result)
                    sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        public int ValidateUser(string UserName, string Password)
        {
            int result = 0;
            Password = ConvertirSha256(Password);

            using (SqlConnection oConnection = new Connection().getConnection)
            {
                SqlCommand cmd = new SqlCommand("Validate_User", oConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;                
                cmd.Parameters.Add(new SqlParameter("@UserName", UserName));
                cmd.Parameters.Add(new SqlParameter("@Password", Password));

                try
                {
                    oConnection.Open();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    while(rdr.Read())
                        {
                            result = rdr["ControlError"] as int? ?? 0;
                        }                    
                }
                catch (Exception ex)
                {
                    return 2;
                }
                finally { oConnection.Close(); }
            }
            return result;
        }
    }
}
