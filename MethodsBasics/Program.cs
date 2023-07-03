#nullable disable

internal class Program
{
    private static void Main(string[] args)
    {
        // int result = AddTwoNumbers(10, 4);
        // TypeMessage("Hello");


        // int intMax = GetMaxValue(new int[] { -1, 5, 22, 245, -234, 10, 0, 12 });
        // Console.WriteLine(intMax);

        // int[] massive = { 1, 5, 6, 5, 3, 65, 23 };
        // int intMax02 = GetMaxValue(massive);
        // Console.WriteLine(intMax02);

        Console.WriteLine(MessageLength("Вышел Ваня на крыльцо, почесать свое яйцо."));

        Console.WriteLine(AnalyzeNumber(5));
        Console.WriteLine(AnalyzeNumber(-2));
        Console.WriteLine(AnalyzeNumber(0));
    }

    //Метод для сложения двух чисел
    // static int AddTwoNumbers(int x, int y)
    // {
    //     int result = x + y;
    //     return result;
    //     // Console.WriteLine("{0} + {1} = {2}", x, y, result);
    // }

    // static void TypeMessage(string message)
    // {
    //     message += "!!!";
    //     Console.WriteLine(message);
    // }

    // static int GetMaxValue(int[] intArray)
    // {
    //     Array.Sort(intArray);
    //     return intArray[intArray.Length - 1];
    // }

    static int MessageLength(string text)
    {
        int symbolValue = text.Length;
        return symbolValue;
    }

    static string AnalyzeNumber(int number)
    {
        if (number > 0)
        {
            return "Число больше 0";
        }
        else if (number < 0)
        {
            return "Число меньше 0";
        }
        else
        {
            return "Число равно 0";
        }
    }
}