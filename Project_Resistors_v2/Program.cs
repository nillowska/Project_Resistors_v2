using System;

namespace Project_Resistors_v2
{
    class Program
    {
        static void Main()
        {
            ValueOfResistors values = new ValueOfResistors();
            Choice choice = new Choice();
            values.valuesOfResistors();
            choice.takeAChoice();
        }
    }
}
