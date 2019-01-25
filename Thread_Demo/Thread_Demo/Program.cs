using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Thread - Basics
            //Thread t1 = new Thread(Punkterl);
            //Thread t2 = new Thread(Stricherl);

            //t1.IsBackground = true;
            //t2.IsBackground = true;
            //t1.Start();
            //t2.Start();

            //Thread.Sleep(3000);
            //t1.Abort();
            //t1.Join(); // Warten, bis der Thread fertig ist 
            #endregion

            Demo d1 = new Demo();

            Thread t1 = new Thread(d1.MachWas);
            Thread t2 = new Thread(d1.MachWas);

            t1.Start();
            t2.Start();

            // Thread.Sleep(1000); // Suspended, andere Threads kommen drann
            // Thread.Sleep(0);    // Gibt die restliche übrige CPU-Zeit auf und ein anderer Thread kommt sofort drann
            // Thread.SpinWait();  // "Bullshit-Berechnung" um Zeit X zu "warten"

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        private static void Stricherl()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(100);
                Console.Write('-');
            }
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId); 
        }
        private static void Punkterl()
        {
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    Thread.Sleep(100);
                    Console.Write('.');
                }
            }
            catch (ThreadAbortException)
            {
                Console.WriteLine("Thread wird beendet ....");
                Thread.Sleep(4000);
                return;
            }
        }
    }
}
