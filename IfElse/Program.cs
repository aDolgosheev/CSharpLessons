internal class Program
{
    private static void Main(string[] args)
    {
        // int x = 0;
        // if (x > 0)
        // {
        //     Console.WriteLine("Переменная x > 0");
        // }
        // else if (x == 0)
        // {
        //     Console.WriteLine("Переменная x = 0");
        // }
        // else
        // {
        //     Console.WriteLine("Переменная x < 0");
        // }

        Console.WriteLine("Хотите ли Вы запустить проверку антивируса?");

        if (Console.ReadLine() == "да")
        {
            Console.WriteLine("Выполняется проверка компьютера на вирусы.....Вирусы не обнаружены.");
        }
        else
        {
            Console.WriteLine("Есть опасность заражения компьютера вирусами. Пожалуйста, выполните проверку.");
        }
    }
}