using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Resistors_v2
{
    public class Series : ValueOfResistors
    {
        public void NumberOfResistors()
        {
            float rParraler1;

            if (numberOfResistors == 2)
            {
                rParraler1 = r1 + r2;
                Console.WriteLine("Rezystancja wypadkowa wynosi: " + rParraler1);
            }
            if (numberOfResistors == 3)
            {
                rParraler1 = r1 + r2 + r3;
                Console.WriteLine("Rezystancja wypadkowa wynosi: " + rParraler1);
            }
            if (numberOfResistors == 4)
            {
                rParraler1 = r1 + r2 + r3 + r4;
                Console.WriteLine("Rezystancja wypadkowa wynosi: " + rParraler1);
            }
            if (numberOfResistors == 5)
            {
                rParraler1 = r1 + r2 + r3 + r4 + r5;
                Console.WriteLine("Rezystancja wypadkowa wynosi: " + rParraler1);
            }
        }

    }
}
