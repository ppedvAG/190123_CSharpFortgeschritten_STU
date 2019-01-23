using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region eingebauter Stack
            //// LIFO -> last in, first out
            //Stack<int> meinStapel = new Stack<int>();

            //meinStapel.Push(12);
            //meinStapel.Push(7);
            //meinStapel.Push(3);

            //// .Peek() -> Auslesen, ohne es zu entfernen
            //Console.WriteLine(meinStapel.Pop());
            //Console.WriteLine(meinStapel.Pop());
            //Console.WriteLine(meinStapel.Pop()); 
            #endregion

            #region Variante Object
            //PpedvStack stack = new PpedvStack();

            //stack.Push(12);
            //stack.Push(3);
            //stack.Push(6);
            //stack.Push("hallo Welt");

            //stack.Push(new StringBuilder()); // <--- Exception

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //Console.WriteLine(stack.Pop());


            //try
            //{
            //    Console.WriteLine(stack.Pop()); // <---- Exception
            //}
            //catch (InvalidOperationException)
            //{
            //    Console.WriteLine("Der Stack ist bereits leer ;) ");
            //}

            //Console.WriteLine("----------------------------------------"); 
            #endregion

            #region Pre- und Postincrement

            //// Postincrement
            //int zahl1 = 10;
            //zahl1++; // 11

            //int zahl2 = zahl1++;
            //Console.WriteLine(zahl2);
            //Console.WriteLine(zahl1);

            //// Preincrement
            //zahl1 = 10;
            //++zahl1; // 11

            //zahl2 = ++zahl1;
            //Console.WriteLine(zahl2);
            //Console.WriteLine(zahl1);


            //for (int i = 0; i < 10; ++i)
            //{

            //}

            #endregion

            #region GenerischerStack - Eigenbau

            GenerischerStack<int> meinStack = new GenerischerStack<int>();

            meinStack.Push(12345);
            meinStack.Pop();

            // MeineMEthode<int,string,decimal>(12, "asd");

            //NurObjekte(new StringBuilder());
            //NurObjekte(12); 
            #endregion


            Dictionary<string, string> länder = new Dictionary<string, string>();

            länder.Add("Österreich", "Berlin");
            länder.Add("Deutschland", "Berlin");
            länder.Add("Ungarn", "Budapest");
            länder.Add("Tschechei", "Prag");
            länder.Add("Tschechei", "Bratislava");

            Console.WriteLine(länder["Österreich"]);


            MeineListe l = new MeineListe();

            l[1] = 5;
            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        //public static T3 MeineMEthode<T1,T2,T3>(T1 item, T2 option)
        //{

        //}

        //public static void NurObjekte<T>(T meinObjekt) where T : IEnumerable
        //{
        //    meinObjekt.
        //}

        //class MeineListe
        //{
        //    // indexer + TAB + TAB

        //    public TValue this[int index]
        //    {
        //        get { /* return the specified index here */ }
        //        set { /* set the specified index to value here */ }
        //    }
        //}
    }
}
