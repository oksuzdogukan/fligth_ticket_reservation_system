using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservation.Data
{
    public class Database
    {

        private static readonly string connectionString = "Server=DESKTOP-8VFFTE2\\SQLEXPRESS; Database=TicketSystemDB; Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
