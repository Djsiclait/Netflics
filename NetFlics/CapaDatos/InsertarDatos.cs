using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class InsertarDatos
    {
        private static string dataSource = "Data Source=USER-PC;Initial Catalog=DBNETFLICS;User id=prueba;password=prueba";
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

        public static string RegisterNewUser(User newUser, string registerUser)
        {
            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_INS_NEW_USU", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = newUser.username;
            cmd.Parameters.Add("@documento", SqlDbType.VarChar, 100).Value = newUser.identification;
            cmd.Parameters.Add("@desc_tipo_documento", SqlDbType.VarChar, 50).Value = newUser.identificationType;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = newUser.firstName;
            cmd.Parameters.Add("@apellido", SqlDbType.VarChar, 100).Value = newUser.lastName;
            cmd.Parameters.Add("@correo", SqlDbType.VarChar, 200).Value = newUser.email;
            cmd.Parameters.Add("@desc_sexo", SqlDbType.VarChar, 30).Value = newUser.gender;
            cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.DateTime).Value = newUser.birthDate;
            cmd.Parameters.Add("@desc_nacionalidad", SqlDbType.VarChar, 50).Value = newUser.nationality;
            cmd.Parameters.Add("@desc_cargo", SqlDbType.VarChar, 30).Value = newUser.position;
            cmd.Parameters.Add("salario", SqlDbType.Decimal).Value = newUser.salary;
            cmd.Parameters.Add("@desc_forma_pago", SqlDbType.VarChar, 30).Value = newUser.paymentSchedule;
            cmd.Parameters.Add("@desc_rol", SqlDbType.VarChar, 30).Value = newUser.role;
            cmd.Parameters.Add("@nombre_sucursal", SqlDbType.VarChar, 100).Value = newUser.branchOffice;
            cmd.Parameters.Add("@usuario_registrador", SqlDbType.VarChar, 50).Value = registerUser;

            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 200);
            message.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(message);

            Int32 re;
            re = Convert.ToInt32(cmd.ExecuteNonQuery());

            return cmd.Parameters["@message"].Value.ToString();
        }

        public static string RegisterNewPhoneNumber(Telephone telephone)
        {
            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_INS_TEL_USU", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = telephone.owner;
            cmd.Parameters.Add("@numero_telefono", SqlDbType.VarChar, 30).Value = telephone.phoneNumber;
            cmd.Parameters.Add("@desc_tipo_telefono", SqlDbType.VarChar, 30).Value = telephone.phoneType;

            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 200);
            message.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(message);

            Int32 re;
            re = Convert.ToInt32(cmd.ExecuteNonQuery());

            return cmd.Parameters["@message"].Value.ToString();
        }

        public static string RegisterNewAddress(Address address)
        {
            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_INS_DIR_USU", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = address.owner;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 300).Value = address.address;
            cmd.Parameters.Add("@desc_tipo_direccion", SqlDbType.VarChar, 30).Value = address.addressType;
            cmd.Parameters.Add("@sector", SqlDbType.VarChar, 50).Value = address.sector;
            cmd.Parameters.Add("@ciudad", SqlDbType.VarChar, 50).Value = address.city;

            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 200);
            message.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(message);

            Int32 re;
            re = Convert.ToInt32(cmd.ExecuteNonQuery());

            return cmd.Parameters["@message"].Value.ToString();
        }
    }
}
