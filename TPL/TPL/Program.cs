using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parallel
            //Parallel.For(0, 100,new ParallelOptions { MaxDegreeOfParallelism = 2 }, i =>
            //  {
            //      Console.WriteLine(i);
            //  });

            //Console.WriteLine("-----------------------------");

            //int[] zahlen = { 12, 5, 6, 7, 8, 9, 0, 5, 3, 2 };
            //// zahlen.Where(x => x%2 == 0).AsParallel()
            //Parallel.ForEach(zahlen, item =>
            // {
            //     Console.WriteLine(zahlen);
            // }); 
            #endregion

            #region Parallel-Performancetest
            //int[] durchgänge = { 500, 1_000, 10_000, 50_000, 100_000, 500_000, 1_000_000, 5_000_000, 10_000_000 };
            //Stopwatch watch = new Stopwatch();
            //for (int i = 0; i < durchgänge.Length; i++)
            //{
            //    Console.WriteLine($"Schleifen: {durchgänge[i]}");
            //    watch.Restart();
            //    SynchronTest(durchgänge[i]);
            //    watch.Stop();

            //    Console.WriteLine($"Synchron: {watch.ElapsedMilliseconds}ms");
            //    watch.Restart();
            //    ParallelTest(durchgänge[i]);
            //    watch.Stop();

            //    Console.WriteLine($"Parallel: {watch.ElapsedMilliseconds}ms");
            //    Console.WriteLine("-------------------------------------------------");
            //}
            #endregion

            #region Tasks starten und drauf warten
            //Task t1 = new Task(MachEtwasAufEinemKern);
            //t1.Start();

            //Task t2 = Task.Factory.StartNew(MachWas2); // .NET 4.0  - Startet sofort
            //Task t3 = Task.Run(new Action(MachWas3)); //  .NET 4.5  - Startet sofort

            //Task.Run(() =>
            //{

            //});

            // Warten auf einen Task:
            // t1.Wait();

            //Task.WaitAll(t1, t2, t3);
            //Task.WaitAny(t1, t2, t3); 
            #endregion

            #region Task mit Ergebnis
            //Task<string> meineAufgabe = Task.Run(() =>
            //{
            //    Thread.Sleep(5000);
            //    return DateTime.Now.ToLongTimeString();
            //});
            //Thread.Sleep(8000);

            //Console.WriteLine($"Aktuelle Uhrzeit ist: {meineAufgabe.Result}"); // Wartet automatisch auf das Ergebnis 
            #endregion

            #region Task beenden mit Token
            //CancellationTokenSource cts = new CancellationTokenSource();
            //CancellationToken token = cts.Token;

            //Task t1 = Task.Factory.StartNew(() =>
            //{
            //    while (true)
            //    {
            //        Console.Write('X');
            //        if (token.IsCancellationRequested)
            //            break;
            //    }
            //});

            //Thread.Sleep(3000);
            //cts.Cancel(); 
            #endregion

            #region Task mit Exception
            //Task t1 = Task.Run(() =>
            //{
            //    Thread.Sleep(2000);
            //    throw new DivideByZeroException();
            //});
            //Task t2 = Task.Run(() =>
            //{
            //    Thread.Sleep(5000);
            //    throw new FormatException();
            //});
            //Task t3 = Task.Run(() =>
            //{
            //    Thread.Sleep(8000);
            //    throw new StackOverflowException();
            //});

            //try
            //{
            //    Task.WaitAll(t1,t2,t3);
            //}
            //catch (AggregateException ex) // Alle Exceptions werden ausnahmslos in einer AggregateException zusammengefasst
            //{
            //    Console.WriteLine(ex.Message);
            //    ex.InnerExceptions.ToList()
            //                      .ForEach(item => Console.WriteLine(item.Message));

            //    //foreach (var item in ex.InnerExceptions)
            //    //{
            //    //    Console.WriteLine(item.Message);
            //    //}
            //} 
            #endregion

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        private static void MachWas3()
        {
            Thread.Sleep(8000);
            Console.WriteLine("lalalala 3");
        }

        private static void MachWas2()
        {
            Thread.Sleep(3000);
            Console.WriteLine("lalalala 2");
        }

        private static void MachEtwasAufEinemKern()
        {
            Thread.Sleep(5000);
            Console.WriteLine("lalalala");
        }

        public static void SynchronTest(int durchgänge)
        {
            double[] werte = new double[durchgänge];
            for (int i = 0; i < durchgänge; i++)
            {
                werte[i] = Math.Pow(i, 0.3333333) * Math.Sqrt(Math.Sin(i));
            }
        }

        public static void ParallelTest(int durchgänge)
        {
            double[] werte = new double[durchgänge];
            Parallel.For(0, durchgänge, new ParallelOptions { MaxDegreeOfParallelism = 2 }, i =>
             {
                 werte[i] = Math.Pow(i, 0.3333333) * Math.Sqrt(Math.Sin(i));
             });
        }
    }
}
