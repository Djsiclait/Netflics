using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class ConsultarNegocios
    {
        public static UserSession FetchUserSessionData(string username)
        {
            return CapaDatos.ConsultarDatos.FetchUserSessionData(username);
        }
        public static List<User> SearchUserRegistry(string category, string keyword)
        {
            return CapaDatos.ConsultarDatos.SearchUserRegistry(category, keyword);
        }
        public static string ValidateNewUsername(string username)
        {
            return CapaDatos.ConsultarDatos.ValidateNewUsername(username);
        }
    }
}
