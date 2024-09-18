using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DBConection
{
    public class SqldataAccess
    {
        private readonly string _conectionString;
        public SqldataAccess()
        {
            _conectionString = "Data Source=ITAMAR\\SQLEXPRESS;Initial Catalog=StudentAdministratorDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        }

        public SqlConnection GetConection ()
        {
            return new SqlConnection(_conectionString);
        }
    }
}
