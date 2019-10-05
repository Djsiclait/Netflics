using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class InsertarNegocios
    {
        public static string RegisterNewUser(User newUser, string registerUser)
        {
            return CapaDatos.InsertarDatos.RegisterNewUser(newUser, registerUser);
        }

        public static string RegisterUserPhoneNumber(Telephone telephone)
        {
            return CapaDatos.InsertarDatos.RegisterNewPhoneNumber(telephone);
        }

        public static string RegisterNewAddress(Address address)
        {
            return CapaDatos.InsertarDatos.RegisterNewAddress(address);
        }
    }
}
