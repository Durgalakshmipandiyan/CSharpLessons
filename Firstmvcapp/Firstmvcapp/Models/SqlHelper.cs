using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace Firstmvcapp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection() 
        {
            var connString = @"server=200411LTP2741\SQLEXPRESS; database = testdb;
            integrated security = true;Encrypt = false";
               SqlConnection sqlcn= new SqlConnection(connString);
            return sqlcn;
        }
    }
}
