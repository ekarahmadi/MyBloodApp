using GoogleApi.Entities.Maps.StreetView.Request.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBloodAppLogin.DAL
{
    class Connection
    {
        public SqlConnection connect = new SqlConnection("Data Source = EKARAHMADI\\SQLEXPRESS; Database=kantongdarah;Integrated Security = True");
    }
}
