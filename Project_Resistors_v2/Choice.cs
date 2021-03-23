using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Resistors_v2
{
    public class Choice
    {
        public void takeAChoice()
        {

            int connection;
            Console.WriteLine("Witaj w kalkulatorze rezystancji wypadkowej.\nWybierz spobób połączenia rezystorów. " +
                "Naciśnij '1' aby wybrać połączenie szeregowe. Naciśnij '2' aby wybrać połączenie równoległe.");
            connection = int.Parse(Console.ReadLine());

            if (connection == 1)
            {
                Console.WriteLine("Wybrałeś połączenie szeregowe ");
                Series series_conn = new Series();
                series_conn.NumberOfResistors();
            }
            else if (connection == 2)
            {
                Console.WriteLine("Wybrałeś połączenie równoległe");
                Parraler series_connP = new Parraler();
                series_connP.NumberOfResistors_P();
             }
            else
            {
                Console.WriteLine("Wpisałes niepoprawną wartość");
            }
        }
    }
}
