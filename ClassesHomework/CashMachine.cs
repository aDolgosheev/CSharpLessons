#nullable disable

public static class CashMachine
{
    public static string Address { get; set; } //Адрес банкомата
    public static string SupportFIO { get; set; } //ФИО обслуживающего человека
    public static double Rubles { get; set; } //Всего доступно рублей
    public static double Dollars { get; set; } //Всего доступно долларов
    public static double DollarsCourse { get; set; } //Курс доллара


    //Конструктор класса
    static CashMachine()
    {
        Address = "Улица Пупкина. Дом Подзалупкина.";
        SupportFIO = "Петров Петр Петрович";
        Rubles = 50000;
        Dollars = 3000;
        DollarsCourse = 60.35;
    }

    //Метод снять деньги
    public static double WithdrawMoney(int accountNumber, double amount)
    {
        System.Console.WriteLine("...Снимаем деньги со счета {0}...", accountNumber);
        if(Rubles >= amount)
        {
            System.Console.WriteLine("Операция проведена успешно. Заберите ваши деньги и карту.\n");
            Rubles -= amount;
            return amount;
        }
        System.Console.WriteLine("Ошибка. В банкомате недостаточно средств.\n");
        return 0;
    }

    //Метод зачисления денег на счет
    public static void DepositMoney(int accountNumber, double amount)
    {
        System.Console.WriteLine("...Зачисляем деньги на счет {0}...", accountNumber);
        System.Console.WriteLine("Операция прошла успешно. Заберите свою карту\n");
        Rubles += amount;
    }

    //Метод обменять рубли на доллары
    public static double ChangeRubles(double amount)
    {
        double result = amount / DollarsCourse;
        System.Console.WriteLine("...Обмениваем рубли на доллары...");
        if(Dollars >= result)
        {
            System.Console.WriteLine("Операция проведена успешно. Заберите ваши деньги и карту.\n");
            Dollars -= result;
            return result;
        }
        System.Console.WriteLine("Ошибка. В банкомате недостаточно средств.\n");
        return 0;
    }

    //Метод обменять доллары на рубли
    public static double ChangeDollars(double amount)
    {
        double result = amount * DollarsCourse;
        System.Console.WriteLine("...Обмениваем доллары на рубли...");
        if(Rubles >= result)
        {
            System.Console.WriteLine("Операция проведена успешно. Заберите ваши деньги и карту.\n");
            Rubles -= result;
            return result;
        }
        System.Console.WriteLine("Ошибка. В банкомате недостаточно средств.\n");
        return 0;
    }
}
