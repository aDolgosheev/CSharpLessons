using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#nullable disable


//Базовый класс Животное
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }

    public Animal()
    {

    }

    public Animal(string name, int age, int weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public virtual void Feed() 
    {
        System.Console.WriteLine("Вы покормили животное.");
    }
}
