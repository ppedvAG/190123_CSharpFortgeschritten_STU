namespace SOLID_Taschenrechner
{
    interface IRechenoperation
    {
        char Operator { get; }
        int Berechne(int operator1, int operator2);
    }
}
