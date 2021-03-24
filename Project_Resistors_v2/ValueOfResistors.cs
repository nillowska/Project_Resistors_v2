using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Resistors_v2
{
    public class ValueOfResistors
    {
        public float valuesOfResistors(float numberOfResistors, float r1, float r2, float r3, float r4, float r5)
        {
            Console.WriteLine("Podaj ilość łączonych rezystorów: ");
            numberOfResistors = float.Parse(Console.ReadLine());
            return numberOfResistors;

            if (numberOfResistors == 2)
            {
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors + " rezystora: ");
                r2 = float.Parse(Console.ReadLine());
                return r1;
                return r2;
            }
            if (numberOfResistors == 3)
            {
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors + " rezystora: ");
                r3 = float.Parse(Console.ReadLine());
                return r1;
                return r2;
                return r3;
            }
            if (numberOfResistors == 4)
            {
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r3 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors + " rezystora: ");
                r4 = float.Parse(Console.ReadLine());
                return r1;
                return r2;
                return r3;
                return r4;
            }
            if (numberOfResistors == 5)
            {
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r3 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r4 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors + " rezystora: ");
                r5 = float.Parse(Console.ReadLine());
                return r1;
                return r2;
                return r3;
                return r4;
                return r5;
            }
        }
    }
}
