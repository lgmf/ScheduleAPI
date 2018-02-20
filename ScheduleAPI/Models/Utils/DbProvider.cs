using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleAPI.Models.Utils
{
    public class DbProvider
    {
        public static string connString { get; set; }

        public static SqlConnection GetConnection()
        {            
            return new SqlConnection(DbProvider.connString);
        }
    }
}
