using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class PpedvStack
    {
        // ctor + TAB + TAB
        public PpedvStack()
        {
            data = new object[4];
            stackPointer = 0;
        }

        private object[] data;
        private int stackPointer;

        // Autoproperty: prop + TAB + TAB
        // Property + Field: propfull + tab + tab

        public void Push(object item)
        {
            if(stackPointer == data.Length)
            {
                object[] newData = new object[data.Length * 2];
                Array.Copy(data, newData, data.Length);
                data = newData;
            }
            data[stackPointer++] = item;
            // stackPointer++;
        }

        public object Pop()
        {
            if (stackPointer == 0)
                throw new InvalidOperationException("Stack ist leer");

            // stackPointer--;
            return data[--stackPointer];
        }
    }

}
