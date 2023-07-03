namespace TestProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello world!";
            if (message == "Hello world!")
            {
                Console.WriteLine(message);
            } 
            else
            {
                Console.WriteLine("Неверное слово!");
            }
        }
    }
}