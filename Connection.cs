using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JOB_FINDER
{
    internal class Connection
    {
        public SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder("Data Source=projectnibm.database.windows.net;Initial Catalog=jobfinderDB1;Persist Security Info=True;User ID=adm;Password=Dhanuri2003@");
    }
}
