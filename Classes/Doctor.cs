using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#nullable disable

namespace Classes
{
    public class Doctor
    {
        #region Fields
        //Поля класса

        //Номер кабинета
        private int cabinetNumber;

        #endregion

        #region Properties

        //В этом свойстве мы проверяем, чтобы номер кабинета был действительным
        public int CabinetNumber
        {
            get
            {
                return cabinetNumber;
            }
            set
            {
                //В больнице всего 100 кабинетов
                if (value > 100)
                    value = 100;
                if (value < 0)
                    value = 0;
                cabinetNumber = value;
            }
        }

        //Автоматические свойства
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Profession { get; set; }
        public int PatientNumber { get; set; }
        public static string Address { get; private set; } //Для всех врачей место работы одинаковое
        private static int DoctorCount { get; set; } //Сколько врачей работает в больнице

        #endregion

        #region Constructor

        //Статический конструктор
        static Doctor()
        {
            Address = "Какой-то адрес больницы.";
        }

        //Конструктор по умолчанию
        public Doctor()
        {
            DoctorCount++;
        }

        //Конструктор с тремя параметрами
        public Doctor(string surname, string nameInc, string middleName)
        {
            Surname = surname;
            Name = nameInc; //нет нужды использовать this
            MiddleName = middleName;
            if (surname.ToLower() == "иванов")
                CabinetNumber = 15;
        }

        //Конструктор с одним параметром - кол-во вылеченных больных
        //Остальные поля мы также инициализируем внутри конструктора своими значениями
        public Doctor(int patientNumber)
        {
            PatientNumber = patientNumber;
            Surname = "Тестовый";
            Name = "Тест";
            MiddleName = "Анонимный";
            Profession = "Не определена";
            CabinetNumber = -1;
        }
        #endregion

        #region Methods
        //Метод выводит информацию о враче на консоль
        public void PrintBio()
        {
            Console.WriteLine("Врач, {0} {1} {2} имеет специальность \"{3}\" и работает в кабинете номер {4}. Он уже вылечил {5} пациентов.", Surname, Name, MiddleName, Profession, CabinetNumber, PatientNumber);
        }

        //Метод "пойти на работу"
        public void GoToWork()
        {
            Console.WriteLine("Врач {0} пошел на работу...", Surname);
            PatientNumber++;
        }

        //Статический метод может обращаться только к статическим членам класса
        public static void HowManyDoctors()
        {
            Console.WriteLine("Всего врачей в больнице: {0}.", DoctorCount);
        }

        #endregion
    }
}