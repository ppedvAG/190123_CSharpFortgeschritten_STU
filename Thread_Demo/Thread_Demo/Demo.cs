using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Demo
{
    class Demo
    {
        private object syncObject = new object();
        private int wert = default; // also 0
        public void MachWas()
        {
            while (true)
            {
                // Monitor.Enter(syncObject); // Nur 1 Thread darf da rein
                lock (syncObject)
                {
                    wert++;
                    if (wert > 100)
                        break;
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {wert}");
                }
                // Monitor.Exit(syncObject);

                // Monitor:     Nur 1 darf den Codeblock ausführen
                // Mutex:       Nur 1 (von 2..N instanzen) darf hinein (Prozessübergreifender Monitor-Block)
                // Semaphore:   Mehrere Applikationen auf einem Codeblock

                // Threadsichere Operationen
                // Interlocked ... z.B. Increment, .Decrement(ref wert);
            }
        }
    }
}
