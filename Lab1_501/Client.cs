using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_501
{
    public class Client
    {
        private Manager mgr;

        public Client(Manager mg)
        {
            mgr = mg;
        }

        public void work()
        {
            Helper h = mgr.requestHelp();
            h.doWork();
            h.finished();
        }
    }
}
