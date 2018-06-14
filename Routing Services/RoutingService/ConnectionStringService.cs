using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RoutingService
{
    public abstract class ConnectionStringService : IConnectionStringService
    {
        protected Dictionary<String, SqlConnectionStringBuilder> _ConnectionStrings;
        #region IconnectionStringService Members
        public abstract SqlConnectionStringBuilder GetConnectionString(string username, string password, string name);
        
        #endregion
    }
}
