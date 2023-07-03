#nullable disable

internal class Program
{
    private static void Main(string[] args)
    {
        Office office = new Office();
        office.Number = 20;
        office.Comp.SerialNumber = 111;
        office.Comp.TurnOn();
    }
}