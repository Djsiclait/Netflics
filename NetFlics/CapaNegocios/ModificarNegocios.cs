using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    public class ModificarNegocios
    {
        public static string UserLogIn(string username, string password, string branchOffice)
        {
            return CapaDatos.ModificarDatos.UserLogIn(username, password, branchOffice);
        }
        public static string UserLogOut(string username, string branchOffice)
        {
            return CapaDatos.ModificarDatos.UserLogOut(username, branchOffice);
        }
        public static string ChangeUserPassword(string username, string newPassword)
        {
            return CapaDatos.ModificarDatos.ChangeUserPassword(username, newPassword);
        }
        public static string ModifyUserInformation(User user, string userInSession)
        {
            return CapaDatos.ModificarDatos.ModifyUserInformation(user, userInSession);
        }
    }
}
