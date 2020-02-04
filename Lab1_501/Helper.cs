using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_501
{
    public class Helper
    {
        private Manager mg = new Manager();
        private RemoveMethod done;

        public Helper(Manager myManager)
        {
            mg = myManager;
        }

        public void doWork()
        {
            Console.WriteLine("doWork");
        }

        public void finished()
        {
            //mg.remove(this);
            done.remove(mg);
            Console.WriteLine("finished");
        }
    }
}
