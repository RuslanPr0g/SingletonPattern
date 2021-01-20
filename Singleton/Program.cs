using Singleton.Servers;
using System;

namespace Singleton
{
    class Program
    {
        static readonly TableServers hosts = TableServers.GetTableServers();
        static readonly TableServers premiumHosts = TableServers.GetTableServers();
        
        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            for (int i = 0; i < 10; i++)
            {
                GetNextHost();
                GetNextPremiumHost();
            }

            Console.ReadKey();
        }

        private static void GetNextHost()
        {
            Console.WriteLine($"Next is {hosts.GetNextServer()}");
        }

        private static void GetNextPremiumHost()
        {
            Console.WriteLine($"Next is {premiumHosts.GetNextServer()}");
        }
    }
}
