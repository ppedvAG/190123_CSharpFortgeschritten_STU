namespace SOLID_Taschenrechner
{
    class Subtraktion : IRechenoperation
    {
        public char Operator => '-';
        public int Berechne(int operator1, int operator2) => operator1 - operator2;
    }
}
