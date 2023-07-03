internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 12, 23, 246, 0, 457, 23, 5, 8, 79 };

        int i = 0;

        while (array[i] != 0)
        {
            Console.WriteLine(array[i]);
            i++;
        }
    }
}