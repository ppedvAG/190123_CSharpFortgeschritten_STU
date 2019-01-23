using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenerischerStack<T>
    {
        // ctor + TAB + TAB
        public GenerischerStack()
        {
            data = new T[4];
            stackPointer = 0;
        }

        private T[] data;
        private int stackPointer;

        // Autoproperty: prop + TAB + TAB
        // Property + Field: propfull + tab + tab

        public void Push(T item)
        {
            if (stackPointer == data.Length)
            {
                T[] newData = new T[data.Length * 2];
                Array.Copy(data, newData, data.Length);
                data = newData;
            }
            data[stackPointer++] = item;
            // stackPointer++;
        }

        public T Pop()
        {
            if (stackPointer == 0)
                throw new InvalidOperationException("Stack ist leer");

            // stackPointer--;
            return data[--stackPointer];
        }
    }
}
