using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#nullable disable

namespace Classes
{
    public class ATM
    {
        #region Fields
        public const string address = "Невский проспект, дом 73, строение 1";
        public const int exchangeRate = 63;
        public const int maxDollarsLimitInATM = 5000;
        public const int maxRublesLimitInATM = 100000;
        private double cashDollarsInATM;
        private double cashRublesInATM;
        #endregion

        #region Properties
        public string Surname { get; private set; } //Фамилия обслуживающего человека
        public string Name { get; private set; } //Имя обслуживающего человека
        public string MiddleName { get; private set; } //Отчество обслуживающего человека

        public double CashDollarsInATM
        {
            get
            {
                return cashDollarsInATM;
            }
            set
            {
                //В банкомате может быть не более 5000 долларов
                if (value > maxDollarsLimitInATM)
                {
                    Console.WriteLine("Указанная сумма превышает лимит на {0} долларов.", value - maxDollarsLimitInATM);
                    value = maxDollarsLimitInATM;
                }
                if (value < 0)
                {
                    Console.WriteLine("Неверно указана сумма");
                    value = 0;
                }
                cashDollarsInATM = value;
            }
        }

        public double CashRublesInATM
        {
            get
            {
                return cashRublesInATM;
            }
            set
            {
                //В банкомате может быть не более 100000 рублей
                if (value > maxRublesLimitInATM)
                {
                    Console.WriteLine("Указанная сумма превышает лимит на {0} рублей.", value - maxRublesLimitInATM);
                    value = maxRublesLimitInATM;
                }
                if (value < 0)
                {
                    Console.WriteLine("Неверно указана сумма");
                    value = 0;
                }
                cashRublesInATM = value;
            }
        }
        #endregion

        #region Constructors

        public ATM()
        {

        }

        public ATM(string surname, string name, string middleName, double cashDollars, double cashRubles)
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            CashDollarsInATM = cashDollars;
            CashRublesInATM = cashRubles;
        }

        #endregion

        #region Methods
        public void PrintInfoATM()
        {
            Console.WriteLine("Банкомат расположен по адресу {0}.Банкомат обслуживает {1} {2} {3}.В банкомате {4} долларов и {5} рублей.\nКурс обмена долларов к рублям - 1 к {6}.", address, Surname, Name, MiddleName, CashDollarsInATM, CashRublesInATM, exchangeRate);
        }

        public void RublesPutInATM(double rubles)
        {
            double currentCashRublesInATM = CashRublesInATM + rubles;
            if (currentCashRublesInATM > maxRublesLimitInATM)
            {
                Console.WriteLine("Вы внесли {0} рублей. Превышен максимальный лимит рублей в банкомате. На счет зачислено {1} рублей. Вам вернется {2} рублей", rubles, maxRublesLimitInATM - CashRublesInATM, currentCashRublesInATM - maxRublesLimitInATM);
                CashRublesInATM = maxRublesLimitInATM;
            }
        }

        public void RublesTakeFromATM(double rubles)
        {
            double currentCashRublesInATM = CashRublesInATM - rubles;
            if (currentCashRublesInATM < 0)
            {
                Console.WriteLine("Вы попытались снять {0} рублей. В банкомате не хватает {1} рублей. Вы получите {2} рублей", rubles, rubles - CashRublesInATM, CashRublesInATM);
                CashRublesInATM = 0;
            }
        }

        public void DollarsPutInATM(double dollars)
        {
            double currentCashDollarsInATM = CashDollarsInATM + dollars;
            if (currentCashDollarsInATM > maxDollarsLimitInATM)
            {
                Console.WriteLine("Вы внесли {0} долларов. Превышен максимальный лимит долларов в банкомате. На счет зачислено {1} долларов. Вам вернется {2} долларов", dollars, maxDollarsLimitInATM - CashDollarsInATM, currentCashDollarsInATM - maxDollarsLimitInATM);
                CashDollarsInATM = maxDollarsLimitInATM;
            }
        }

        public void DollarsTakeFromATM(double dollars)
        {
            double currentCashDollarsInATM = CashDollarsInATM - dollars;
            if (currentCashDollarsInATM < 0)
            {
                Console.WriteLine("Вы попытались снять {0} долларов. В банкомате не хватает {1} долларов. Вы получите {2} долларов", dollars, dollars - CashDollarsInATM, CashDollarsInATM);
                CashDollarsInATM = 0;
            }
        }

        private void RublesExchange(double dollars)
        {
            double rublesExchange = dollars * exchangeRate;
            if (rublesExchange > CashRublesInATM)
            {
                double lackOfRubles = rublesExchange - CashRublesInATM;
                double dollarsReturn = lackOfRubles / exchangeRate;
                Console.WriteLine("В банкомате не хватает {0} рублей. Вам вернется {1} долларов.", lackOfRubles, dollarsReturn);
                rublesExchange = CashRublesInATM;
            }
            Console.WriteLine("После обмена вы получите " + rublesExchange + " рублей.");
        }

        public void ExchangeDollarsToRubles(double dollars)
        {
            double dollarsSum = dollars + CashDollarsInATM;
            if (dollarsSum > maxDollarsLimitInATM)
            {
                double dollarsReturnFromATM = dollarsSum - maxDollarsLimitInATM;
                Console.WriteLine("Лимит долларов в банкомате превышен на {0} долларов.", dollarsReturnFromATM);
                dollars = dollars - dollarsReturnFromATM;
                RublesExchange(dollars);
            }
            else
            {
                RublesExchange(dollars);
            }
            CashDollarsInATM -= dollars;
        }

        private void DollarsExchange(double rubles)
        {
            double dollarsExchange = rubles / exchangeRate;
            if (dollarsExchange > CashDollarsInATM)
            {
                double lackOfDollars = dollarsExchange - CashDollarsInATM;
                double rublesReturn = lackOfDollars * exchangeRate;
                Console.WriteLine("В банкомате не хватает {0} долларов. Вам вернется {1} рублей.", lackOfDollars, rublesReturn);
                dollarsExchange = CashDollarsInATM;
            }
            Console.WriteLine("После обмена вы получите " + dollarsExchange + " долларов.");
        }

        public void RublesToDollars(double rubles)
        {
            double rublesSum = rubles + CashRublesInATM;
            if (rublesSum > maxRublesLimitInATM)
            {
                double rublesReturnFromATM = rublesSum - maxRublesLimitInATM;
                Console.WriteLine("Лимит рублей в банкомате превышен на {0} рублей.", rublesReturnFromATM);
                rubles = rubles - rublesReturnFromATM;
                DollarsExchange(rubles);
            }
            else
            {
                DollarsExchange(rubles);
            }
            CashRublesInATM -= rubles;
        }
        #endregion
    }
}