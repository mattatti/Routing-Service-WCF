namespace RoutingService.Tests.Mocks
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    class ConnectionStringServiceMock : ConnectionStringService
    {
        public ConnectionStringServiceMock()
        {
            _ConnectionStrings = new Dictionary<string, SqlConnectionStringBuilder>();
            _ConnectionStrings.Add("DefaultConnectionString",new SqlConnectionStringBuilder("Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername; Password=myPassword;"));
        }

        private const string Username = "TestUser";
        private const string Password = "TestPassword";
        public override SqlConnectionStringBuilder GetConnectionString(string username, string password, string name)
        {
            if (!username.Equals(Username) || !password.Equals(Password))
                return null;

            if (_ConnectionStrings.ContainsKey(name))
            {
                return _ConnectionStrings[name];
            }
            else {
                return null;
            }
        }
    }
}
