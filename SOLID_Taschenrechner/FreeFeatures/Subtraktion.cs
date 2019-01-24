using SOLID_Taschenrechner.Domain;

namespace SOLID_Taschenrechner.FreeFeatures
{
    public class Subtraktion : IRechenoperation
    {
        public char Operator => '-';
        public int Berechne(int operator1, int operator2) => operator1 - operator2;
    }
}
