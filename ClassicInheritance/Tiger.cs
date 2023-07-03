using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#nullable disable

//Производный класс Тигр
public class Tiger : Animal
{
    public int TailLength { get; set; }

    public Tiger()
    {

    }

    public Tiger(string name, int age, int weight, int tailLength) : base (name, age, weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
        TailLength = tailLength;
    }

    public override void Feed()
    {
        base.Feed();
        System.Console.WriteLine("Тигра кормим мясом.");
    }

}
