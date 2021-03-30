using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Resistors_v2
{
    public class ValueOfResistors
    {
        public int numberOfResistors { get; set; }
        public float r1 { get; set; }
        public float r2 { get; set; }
        public float r3 { get; set; }
        public float r4 { get; set; }
        public float r5 { get; set; }

        public void valuesOfResistors()
        {
            Console.WriteLine("Podaj ilość łączonych rezystorów: ");
            numberOfResistors = int.Parse(Console.ReadLine());

            if (numberOfResistors == 2)
            {
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors + " rezystora: ");
                r2 = float.Parse(Console.ReadLine());
            }
            if (numberOfResistors == 3)
            {
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors-- + " rezystora: ");
                r2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wartosc " + numberOfResistors + " rezystora: ");
                r3 = float.Parse(Console.ReadLine());
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
            }
        }
    }
}
