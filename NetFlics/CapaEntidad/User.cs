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
        public string identification { get; set; }
        public string identificationType { get; set; }
		public string firstName { get; set; } 
		public string lastName { get; set; } 
		public string email { get; set; } 
		public string gender { get; set; }
        public DateTime birthDate { get; set; }
        public string nationality { get; set; }
		public string position { get; set; }
        public float salary { get; set; }
        public string paymentSchedule { get; set; }
		public string role { get; set; }
		public string branchOffice { get; set; }
    }
}
