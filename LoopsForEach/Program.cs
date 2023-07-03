#nullable disable

internal class Program
{
    private static void Main(string[] args)
    {
        string[] letters = { "a", "b", "c", "d", "e" };
        Array.Reverse(letters);
        foreach (string i in letters)
        {
            Console.WriteLine(i);
        }
    }
}