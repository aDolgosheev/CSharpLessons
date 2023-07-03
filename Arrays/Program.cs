#nullable disable   

internal class Program
{
    private static void Main(string[] args)
    {
        // int a = 2, b = 4, c = 6, d = 8, e = 10;

        // int[] intArray = new int[5];
        // intArray[0] = 2;
        // intArray[1] = 4;
        // intArray[2] = 6;
        // intArray[3] = 8;
        // intArray[4] = 20;
        
        // // string[] stringArray = {"это", "массив", "строк"};
        // // Console.WriteLine("{0} {1} {2}", stringArray[0], stringArray[1], stringArray[2]);

        // int[] numbers = {2, -7, 14};
        // Console.WriteLine("Исходный массив: {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
        // Console.WriteLine("Количество элементов в массиве: {0}", numbers.Length);

        // Array.Reverse(numbers);
        // Console.WriteLine("Перевернутый массив: {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
        // Array.Sort(numbers);
        // Console.WriteLine("Отсортированный массив: {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
        // Array.Clear(numbers, 0, numbers.Length);
        // Console.WriteLine("Очищенный массив: {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);

        string[] stringArray = new string[3];
        Console.WriteLine("Введите первый элемент массива");
        stringArray[0] = Console.ReadLine();
        Console.WriteLine("Введите второй элемент массива");
        stringArray[1] = Console.ReadLine();
        Console.WriteLine("Введите третий элемент массива");
        stringArray[2] = Console.ReadLine();

        Array.Reverse(stringArray);
        System.Console.WriteLine("Заполненный массив в обратном порядке: {0}, {1}, {2}", stringArray[0], stringArray[1], stringArray[2]);

    }
}