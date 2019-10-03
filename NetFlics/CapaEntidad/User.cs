using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaEntidad
{
    public class User
    {
        public string username { get; set; }
		public string firstName { get; set; } 
		public string lastName { get; set; } 
		public string email { get; set; } 
		public string gender { get; set; }
		public string position { get; set; }
		public string role { get; set; }
		public string branchOffice { get; set; }
    }
}
