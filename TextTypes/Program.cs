internal class Program
{
    private static void Main(string[] args)
    {
        // string surname = "Долгошеев";
        // string name = "Александр";
        // string middleName = "Олегович";

        // string fio = surname + " " + name + " " + middleName;
        // System.Console.WriteLine(fio);

        // System.Console.WriteLine("ФИО человека: " + fio);
        // System.Console.WriteLine("ФИО человека: {0}", fio);
        // System.Console.WriteLine("ФИО человека: {0} {1} {2}", surname, name, middleName);

        // System.Console.WriteLine(3 +4);
        // System.Console.WriteLine("3" + "4");

        // int x = 25;
        // string number = x.ToString();
        // number += " человек";
        // System.Console.WriteLine(number);

        // string someText = "123";
        // int someNumber = int.Parse(someText);
        // someNumber += 5;

        // System.Console.WriteLine(someNumber);

        // char symbol = '5';
        // char symbol2 = '?';
        // System.Console.WriteLine("Символ {0} является числом: {1}", symbol, char.IsDigit(symbol));
        // System.Console.WriteLine("Символ {0} является числом: {1}", symbol2, char.IsDigit(symbol2));
        // System.Console.WriteLine("Символ {0} является знаком пунктуации: {1}", symbol2, char.IsPunctuation(symbol2));

        string sun = "Солнце -";
        string thisIs = "это";
        string star = "звезда.";

        string sentence = sun + " " + thisIs + " " + star;

        System.Console.WriteLine(sentence);
    }
}