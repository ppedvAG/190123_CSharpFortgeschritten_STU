using System;
using System.Linq;

namespace SOLID_Taschenrechner
{
    class GrundrechenartenRechner : IRechner
    {
        public int Berechne(Formel formel)
        {
            if (formel.Operator == '+')
                return formel.Operand1 + formel.Operand2;
            else if (formel.Operator == '-')
                return formel.Operand1 + formel.Operand2;
            
            throw new NotSupportedException("Operator ist unbekannt");
        }
    }

    #region Params - Erklärung
    //class Demo
    //{
    //    public void Main()
    //    {
    //        Add(1, 2, 3);
    //        Add(1, 2, 3,4);
    //        Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
    //        Add( 1, 2, 3, 4, 5, 6, 7, 8,9,10,11,12,12213123 );
    //    }
    //    public void Add(params int[] zahlen) => zahlen.Sum();
    //} 
    #endregion
}
