using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class ModificarDatos
    {
        private static string dataSource = "Data Source=DESKTOP-PNLJFN5;Initial Catalog=DBNETFLICS;User id=prueba;password=prueba";
        private static SqlConnection connection = new SqlConnection(dataSource);

        private static void ConnectToDatabase()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();

            connection.Open();
        }

        private static void DisconnectFromDatabase()
        {
            connection.Close();
        }

        public static string UserLogIn(string username, string password, string branchOffice)
        {
            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_USU_LOG_IN", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            // Declaring paramaters
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = username;
            cmd.Parameters.Add("@contrasena", SqlDbType.VarChar, 50).Value = password;
            cmd.Parameters.Add("@sucursal", SqlDbType.VarChar, 4).Value = branchOffice;

            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 200);
            message.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(message);

            Int32 re;
            re = Convert.ToInt32(cmd.ExecuteNonQuery());

            return cmd.Parameters["@message"].Value.ToString();
        }

        public static string UserLogOut(string username, string branchOffice)
        {
            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_USU_LOG_OUT", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = username;
            cmd.Parameters.Add("@sucursal", SqlDbType.VarChar, 4).Value = branchOffice;

            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 200);
            message.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(message);

            Int32 re;
            re = Convert.ToInt32(cmd.ExecuteNonQuery());

            return cmd.Parameters["@message"].Value.ToString();
        }

        public static string ChangeUserPassword(string username, string newPassword)
        {
            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_CHANGE_PASS_USU", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = username;
            cmd.Parameters.Add("@nueva_contrasena", SqlDbType.VarChar, 50).Value = newPassword;

            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 200);
            message.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(message);

            Int32 re;
            re = Convert.ToInt32(cmd.ExecuteNonQuery());

            return cmd.Parameters["@message"].Value.ToString();

        }
    }
}