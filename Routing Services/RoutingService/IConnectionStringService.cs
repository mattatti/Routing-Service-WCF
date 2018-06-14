
namespace RoutingService
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.ServiceModel;

    [ServiceContract]
    public interface IConnectionStringService
    {
     //   Dictionary<String, SqlConnectionStringBuilder> _ConnectionStrings { get; set; }

        [OperationContract]
        SqlConnectionStringBuilder GetConnectionString(String username, String password, String name);
    }
}
