using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class UserSession // global class to monitor user session 
    {
        public static string username { get; set; } // username 
        public static string firstName { get; set; } // name of euser in session
        public static string lastName { get; set; } // lastname of user in session
        public static string role { get; set; } // user pre defined role 
    }
}
