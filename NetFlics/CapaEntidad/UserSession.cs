using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaEntidad
{
    public class UserSession // global class to monitor user session 
    {
        public string username { get; set; } // username 
        public string firstName { get; set; } // name of euser in session
        public string lastName { get; set; } // lastname of user in session
        public string role { get; set; } // user pre defined role 

        public static UserSession userSession = new UserSession(); // global variable to store fetched data
    }
}
