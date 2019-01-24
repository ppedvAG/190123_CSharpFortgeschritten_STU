namespace SOLID_Taschenrechner.Domain
{
    public interface IRechenoperation
    {
        char Operator { get; }
        int Berechne(int operator1, int operator2);
    }
}
