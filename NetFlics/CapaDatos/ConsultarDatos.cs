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
    public class ConsultarDatos
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

        public static UserSession FetchUserSessionData(string username)
        {
            UserSession user = new UserSession();

            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_FETCH_USU", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = username;

            SqlDataReader dataReader;

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                user = new UserSession();

                user.username = dataReader["fld_cod_usu"].ToString();
                user.firstName = dataReader["fld_nom_usu"].ToString();
                user.lastName = dataReader["fld_ape_usu"].ToString();
                user.role = dataReader["fld_desc_rol"].ToString();
            }

            DisconnectFromDatabase();

            return user;
        }

        public static User FetchUserData(string username)
        {
            User user = new User();

            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_FETCH_USU", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = username;

            SqlDataReader dataReader;

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                user = new User();

                user.username = dataReader["fld_cod_usu"].ToString();
                user.identification = dataReader["fld_doc_usu"].ToString();
                user.identificationType = dataReader["fld_desc_tip"].ToString();
                user.firstName = dataReader["fld_nom_usu"].ToString();
                user.lastName = dataReader["fld_ape_usu"].ToString();
                user.email = dataReader["fld_cor_usu"].ToString();
                user.gender = dataReader["fld_desc_sex"].ToString();
                user.birthDate = Convert.ToDateTime(dataReader["fld_fec_nac"].ToString());
                user.nationality = dataReader["fld_desc_nac"].ToString();
                user.position = dataReader["fld_desc_car"].ToString();
                user.salary = FormatSalary(dataReader["fld_sal_usu"].ToString());
                user.paymentSchedule = dataReader["fld_desc_tip"].ToString();
                user.role = dataReader["fld_desc_rol"].ToString();
                user.branchOffice = dataReader["fld_nom_suc"].ToString();
            }

            return user;
        }

        public static List<Telephone> FetchUserTelephoneData(String username)
        {
            List<Telephone> telephones = new List<Telephone>();

            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_FETCH_TEL_USU", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = username;

            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Telephone telephone = new Telephone();

                telephone.owner = dataReader["fld_cod_cli"].ToString();
                telephone.phoneNumber = dataReader["fld_tel_cli"].ToString();
                telephone.phoneType = dataReader["fld_desc_tip"].ToString();
                telephone.phoneState = dataReader["fld_desc_est"].ToString();

                telephones.Add(telephone);
            }

            return telephones;
        }

        public static Address FetchUserAddressData(string username)
        {
            Address address = new Address();

            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_FETCH_DIR_USU", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = username;

            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                address.owner = dataReader["fld_cod_cli"].ToString();
                address.addressType = dataReader["fld_desc_tip"].ToString();
                address.address = dataReader["fld_dir_cli"].ToString();
                address.sector = dataReader["fld_sec_dir"].ToString();
                address.city = dataReader["fld_ciu_dir"].ToString();
            }

            return address;
        }

        public static List<User> SearchUserRegistry(string category, string keyword)
        {
            List<User> registry = new List<User>();

            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_SEARCH_USU", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@categoria", SqlDbType.VarChar, 30).Value = category;
            cmd.Parameters.Add("@buscado", SqlDbType.VarChar, 200).Value = keyword;

            SqlDataReader dataReader;

            dataReader = cmd.ExecuteReader();

            User user = new User();
            while (dataReader.Read())
            {
                user = new User();

                user.username = dataReader["fld_cod_usu"].ToString();
                user.firstName = dataReader["fld_nom_usu"].ToString();
                user.lastName = dataReader["fld_ape_usu"].ToString();
                user.email = dataReader["fld_cor_usu"].ToString();
                user.gender = dataReader["fld_desc_sex"].ToString();
                user.position = dataReader["fld_desc_car"].ToString();
                user.role = dataReader["fld_desc_rol"].ToString();
                user.branchOffice = dataReader["fld_nom_suc"].ToString();

                registry.Add(user);
            }

            DisconnectFromDatabase();

            return registry;
        }

        public static string ValidateNewUsername(string username)
        {
            ConnectToDatabase();

            SqlCommand cmd = new SqlCommand("USP_VAL_USU", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = username;

            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 200);
            message.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(message);

            Int32 re;

            re = Convert.ToInt32(cmd.ExecuteNonQuery());

            return cmd.Parameters["@message"].Value.ToString();
        }

        // Auxiliary Functions
        private static float FormatSalary(string salary)
        {
            float sal;

            float.TryParse(salary, out sal);

            return sal;
        }
    }
}
