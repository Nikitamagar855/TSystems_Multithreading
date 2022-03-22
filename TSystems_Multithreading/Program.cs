using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TSystems_Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread1 demo = new Thread1();
            Thread t1 = new Thread(new ThreadStart(demo.Test));
            Thread t2 = new Thread(new ThreadStart(demo.Test2));
            Thread t3 = new Thread(new ThreadStart(demo.Test3));
            t1.Name = "First Thread";
            t2.Name = "Second Thread";
            t3.Name = "Third Thread";
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Normal;
            t3.Priority = ThreadPriority.Highest;
            

            t1.Start();
            t2.Start();
            
            t3.Start();
           
            Console.ReadLine();
        }
    }
}
