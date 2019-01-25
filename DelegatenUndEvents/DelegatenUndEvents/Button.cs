using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEvents
{
    class Button
    {
        // Variante "lang"
        //private EventHandler clickEvent;
        //public event EventHandler ClickEvent
        //{
        //    add
        //    {
        //        clickEvent += value;
        //    }
        //    remove
        //    {
        //        clickEvent -= value;
        //    }
        //}

        // Variante "kurz"
        public event EventHandler ClickEvent;

        public void Click()
        {
            ClickEvent?.Invoke(this,EventArgs.Empty);
        }
    }
}
