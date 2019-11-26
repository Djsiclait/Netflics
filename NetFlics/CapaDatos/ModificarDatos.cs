using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

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

        public static string ModifyUserInformation(User user, string userInSession)
        {
            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_MOD_USU", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = user.username;
            cmd.Parameters.Add("@documento", SqlDbType.VarChar, 100).Value = user.identification;
            cmd.Parameters.Add("@desc_tipo_domumento", SqlDbType.VarChar, 50).Value = user.identificationType;
            cmd.Parameters.Add("@nombre ", SqlDbType.VarChar, 100).Value = user.firstName;
            cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 100).Value = user.lastName;
            cmd.Parameters.Add("@correo", SqlDbType.VarChar, 200).Value = user.email;
            cmd.Parameters.Add("@desc_sexo", SqlDbType.VarChar, 30).Value = user.gender;
            cmd.Parameters.Add("@fehca_nacimiento", SqlDbType.DateTime).Value = user.birthDate;
            cmd.Parameters.Add("@desc_nacionalidad", SqlDbType.VarChar, 50).Value = user.nationality;
            cmd.Parameters.Add("@desc_cargo", SqlDbType.VarChar, 30).Value = user.position;
            cmd.Parameters.Add("@salario", SqlDbType.Decimal).Value = user.salary;
            cmd.Parameters.Add("@desc_forma_pago", SqlDbType.VarChar, 30).Value = user.paymentSchedule;
            cmd.Parameters.Add("@desc_rol ", SqlDbType.VarChar, 30).Value = user.role;
            cmd.Parameters.Add("@nombre_sucursal", SqlDbType.VarChar, 100).Value = user.branchOffice;
            cmd.Parameters.Add("@usuario_actualizador", SqlDbType.VarChar, 50).Value = userInSession;

            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 200);
            message.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(message);

            Int32 re;
            re = Convert.ToInt32(cmd.ExecuteNonQuery());

            return cmd.Parameters["@message"].Value.ToString();
        }
    }
}