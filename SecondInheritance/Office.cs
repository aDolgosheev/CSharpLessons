using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#nullable disable

//namespace SecondInheritance;

public class Office
{
    public class Computer
    {
        public int SerialNumber { get; set; }

        public void TurnOn()
        {
            
        }
    }

    public int Number { get; set; }
    public Computer Comp { get; set; }

    public Office()
    {
        Comp = new Computer();
    }
}
