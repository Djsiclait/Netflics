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
                user.role = dataReader["fld_rol_usu"].ToString();
            }

            DisconnectFromDatabase();

            return user;
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
    }
}
