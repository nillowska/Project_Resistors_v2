using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Resistors_v2
{
    public class Choice : ValueOfResistors
    {
        public void takeAChoice()
        {
            int connection;

            Console.WriteLine("Witaj w kalkulatorze rezystancji wypadkowej.\nWybierz spobób połączenia rezystorów. " +
                "Naciśnij '1' aby wybrać połączenie szeregowe. Naciśnij '2' aby wybrać połączenie równoległe.");
            connection = int.Parse(Console.ReadLine());

            if (connection == 1)
            {
                Series series_connection = new Series();
                Console.WriteLine("Wybrałeś połączenie szeregowe ");
                series_connection.ResultantSeries();
            }
            else if (connection == 2)
            {
                Parraler parraler_connection = new Parraler();
                Console.WriteLine("Wybrałeś połączenie równoległe");
                parraler_connection.ResultantParraler();
            }
            else
            {
                Console.WriteLine("Wpisałes niepoprawną wartość");
            }
        }
    }
}
