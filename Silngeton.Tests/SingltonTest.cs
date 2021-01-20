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
        [InlineData(10)]
        public void ShouldNotReturnTheSameInstance(int count)
        {
            bool was = false;

            for (int i = 0; i < count; i++)
            {
                if (hosts.GetNextServer() == premiumHosts.GetNextServer())
                {
                    was = true;
                }
            }

            Assert.False(was);
        }
    }
}
