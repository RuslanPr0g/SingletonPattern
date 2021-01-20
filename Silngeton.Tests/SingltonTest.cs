using Singleton.Servers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Silngeton.Tests
{
    public class SingltonTest
    {
        static readonly TableServers hosts = TableServers.GetTableServers();
        static readonly TableServers premiumHosts = TableServers.GetTableServers();

        [Theory]
        [InlineData]
        public void ShouldNotReturnTheSameInstance()
        {

        }
    }
}
