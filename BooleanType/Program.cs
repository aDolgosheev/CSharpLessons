internal class Program
{
    private static void Main(string[] args)
    {
        // bool operationIsFinished = false;
        // System.Console.WriteLine("Операция завершена: {0}", operationIsFinished);

        // bool result;
        // result = 5 < 6;
        // System.Console.WriteLine("5 < 6? {0}", result);
        // result = 18 - 2 == 16;
        // System.Console.WriteLine(result);
        // result = "snow" == "snow";
        // System.Console.WriteLine("\"snow\" == \"snow\"? {0}", result);

        Console.WriteLine("Введите любое число:");
        string number = Console.ReadLine();
        int number1 = int.Parse(number);
        bool test = number1 > 0;
        Console.WriteLine("Выбранное Вами число больше нуля?: {0}", test);
    }
}