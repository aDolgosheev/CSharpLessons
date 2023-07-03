using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#nullable disable


namespace Classes
{
    public static class Service
    {
        //Приватное статическое поле
        private static string emailAdmin;

        //Константное поле
        public const string emailSupport = "support@support.com";

        //Статический конструктор
        static Service()
        {
            emailAdmin = "admin@admin.com";
        }

        //Статический метод
        public static void SendEmail(string emailTo)
        {
            Console.WriteLine("Отправляем email с адреса {0} на адрес {1}", emailAdmin, emailTo);
        }
    }
}