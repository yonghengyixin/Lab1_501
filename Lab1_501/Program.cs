using System;

namespace Lab1_501
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Client ct = new Client(manager);
            ct.work();
            Console.WriteLine("done");
        }
    }
}
