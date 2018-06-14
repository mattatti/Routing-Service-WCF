using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using RoutingService.Tests.Mocks;

namespace RoutingService.Tests
{
    [TestClass]
    public class ConnectionStringServiceTests
    {
        [TestMethod]
        public void GetConnectionStringTest()
        {
            ConnectionStringServiceMock service = new ConnectionStringServiceMock();
            SqlConnectionStringBuilder builder = service.GetConnectionString("TestUser", "TestPassword", "DefaultConnectionString");

            Assert.IsNotNull(builder);
        }
    }
}
