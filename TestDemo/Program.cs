
namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            if (DateTime.Now.Hour < 12)
            {
                System.Console.WriteLine("Доброе утро!");
            }
            else
            {
                System.Console.WriteLine("Добрый день!");
            }
            System.Console.WriteLine("Введите, пожалуйста, Ваше имя и нажмите Enter:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Введите, пожалуйста, название блюда и нажмите Enter:");
            string order = Console.ReadLine();
            System.Console.WriteLine("Спасибо за Ваш заказ, {0}! Вы выбрали {1}.", name, order);
            int time = new Random().Next(5, 20);
            Console.WriteLine("Ваш заказ будет готов через {0} минут.", time);
        }
    }
}

