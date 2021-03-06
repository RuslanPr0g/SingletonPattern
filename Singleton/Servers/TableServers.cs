﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Servers
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();

        private readonly List<string> servers = new List<string>();
        private int nextServer = 1;

        private TableServers()
        {
            servers.Add("Russia");
            servers.Add("USA");
            servers.Add("Israel");
            servers.Add("Mexico");
        }

        public static TableServers GetTableServers()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string output = servers[nextServer++];

            if(nextServer >= servers.Count)
            {
                nextServer = 0;
            }

            return output;
        }
    }
}
