﻿using System;
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
    }
}
