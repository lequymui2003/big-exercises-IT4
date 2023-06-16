using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLDeTai
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=AnhHatDe;Initial Catalog=DeTaiThucTap;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
