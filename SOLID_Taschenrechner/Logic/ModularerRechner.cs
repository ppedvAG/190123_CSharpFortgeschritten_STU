using SOLID_Taschenrechner.Domain;
using System;
using System.Linq;

namespace SOLID_Taschenrechner.Logic
{
    public class ModularerRechner : IRechner
    {
        public ModularerRechner(params IRechenoperation[] rechenoperationen)
        {
            this.rechenoperationen = rechenoperationen;
        }
        private readonly IRechenoperation[] rechenoperationen;

        public int Berechne(Formel formel)
        {
            if (!rechenoperationen.Any(x => x.Operator == formel.Operator))
                throw new NotSupportedException("Diese Rechenoperation wird nicht unterstütz");

            return rechenoperationen.First(x => x.Operator == formel.Operator)
                                    .Berechne(formel.Operand1, formel.Operand2);
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
