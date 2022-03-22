using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TSystems_Multithreading
{
   public class Thread1
    {
        public void Test()
        {
            lock (this)
            { 
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }



            }
        }
        public void Test2()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }
        public void Test3()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }
    }
}
