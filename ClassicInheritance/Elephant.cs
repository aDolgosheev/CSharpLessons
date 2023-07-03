using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Производный класс Слон
//Запечатанный класс
public sealed class Elephant : Animal
{
    public override void Feed()
    {
        base.Feed();
        System.Console.WriteLine("Слона кормим бананами.");
    }
}
