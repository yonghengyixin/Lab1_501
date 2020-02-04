using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_501
{
    public class Manager
    {
        private List<Helper> active = new List<Helper>();

        public void remove(Helper h)
        {
            active.Remove(h);
            Console.WriteLine("removed");
            //h.Finalize();
        }

        public Helper requestHelp()
        {
            Helper h = new Helper(this);
            active.Add(h);
            return h;
        }
    }
}
