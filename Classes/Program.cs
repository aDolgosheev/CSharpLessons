#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        //Объект класса врач == переменная класа врач == экземпляр класса врач
        private static void Main(string[] args)
        {
            // Console.WriteLine(Doctor.Address);

            // Doctor.HowManyDoctors();
            // Doctor doctor1 = new Doctor();
            // Doctor doctor2 = new Doctor();
            // Doctor.HowManyDoctors();

            // Service.SendEmail("insroach@gmail.com");

            // Console.WriteLine(Math.Round(10.87));

            // Console.WriteLine("Отправляйте ваши отзывы и пожелания по адресу {0}", Service.emailSupport);
            ATM aTM = new ATM("Иванов", "Иван", "Иванович", 1230, 25000);
            aTM.ExchangeDollarsToRubles(250);
            aTM.DollarsTakeFromATM(1000);
            aTM.DollarsPutInATM(5500);
            aTM.RublesPutInATM(130000);
            aTM.RublesTakeFromATM(125000);
            aTM.PrintInfoATM();
        }
    }
}