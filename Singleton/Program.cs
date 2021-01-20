using Singleton.Servers;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TableServers servers = new TableServers();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Next is {servers.GetNextServer()}");
            }
        }
    }
}
