using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Resistors_v2
{
    public class Parraler : ValueOfResistors
    {
        public void NumberOfResistors_P()
        {
            float rParraler1;
            float rParraler2;
            float rParraler3;

            Console.WriteLine("Podaj ilość rezystorów do połączenia: ");
            numberOfResistors = int.Parse(Console.ReadLine());

            if (numberOfResistors == 2)
            {
                rParraler1 = r1 * r2;
                rParraler2 = r1 + r2;
                rParraler3 = rParraler1 / rParraler2;
                Console.WriteLine("Rezystancja wypadkowa wynosi: " + rParraler3);
            }
            if (numberOfResistors == 3)
            {
                rParraler1 = r1 * r2 * r3;
                rParraler2 = r1 + r2 + r3;
                rParraler3 = rParraler1 / rParraler2;
                Console.WriteLine("Rezystancja wypadkowa wynosi: " + rParraler3);
            }
            if (numberOfResistors == 4)
            {
                rParraler1 = r1 * r2 * r3 * r4;
                rParraler2 = r1 + r2 + r3 + r4;
                rParraler3 = rParraler1 / rParraler2;
                Console.WriteLine("Rezystancja wypadkowa wynosi: " + rParraler3);
            }
            if (numberOfResistors == 5)
            {
                rParraler1 = r1 * r2 * r3 * r4 * r5;
                rParraler2 = r1 + r2 + r3 + r4 + r5;
                rParraler3 = rParraler1 / rParraler2;
                Console.WriteLine("Rezystancja wypadkowa wynosi: " + rParraler3);
            }
        }
    }
}
