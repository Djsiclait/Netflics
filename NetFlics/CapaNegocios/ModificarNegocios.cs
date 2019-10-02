using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
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

    }
}
