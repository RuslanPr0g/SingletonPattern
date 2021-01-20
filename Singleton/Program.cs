﻿using Singleton.Servers;
using System;

namespace Singleton
{
    class Program
    {
        static TableServers hosts = new TableServers();
        static TableServers premiumHosts = new TableServers();
        
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
