using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulatornia
{
    public class Services
    {
        string Menu = "MENU Kalkulatora";
        string dodawanie = "Dodawanie - 1";
        string odejmowanie = "Odejmowanie - 2";
        string mnozenie = "Mnożenie - 3";
        string dzielenie = "Dzielenie - 4";
        string wyjscie = "Wyjście - 5";
        string skladnik2 = "Podaj drugi składnik";
        string wybor1 = "Wybrano Dodawanie " + "Podaj pierwszy składnik";
        string wybor2 = "Wybrano Odejmowanie " + "Podaj pierwszy składnik";
        string wybor3 = "Wybrano Mnożenie " + "Podaj pierwszy składnik";
        string wybor4 = "Wybrano Dzielenie " + "Podaj pierwszy składnik";
        string wynik = "Twój wynik to: ";

       public void wyborJeden()
        {
            Console.WriteLine(wybor1);
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(skladnik2);
            int liczba2 = Convert.ToInt32(Console.ReadLine());
            int suma = liczba1 + liczba2;
            Console.WriteLine(wynik + suma);
        }

        public void wyborDwa()
        {
            Console.WriteLine(wybor2);
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(skladnik2);
            int liczba2 = Convert.ToInt32(Console.ReadLine());
            int różnica = liczba1 - liczba2;
            Console.WriteLine(wynik + różnica);
        }

        public void wyborTrzy()
        {
            Console.WriteLine(wybor3);
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(skladnik2);
            int liczba2 = Convert.ToInt32(Console.ReadLine());
            int iloczyn = liczba1 * liczba2;
            Console.WriteLine(wynik + iloczyn);
        }

        public void wyborCztery()
        {
            Console.WriteLine(wybor4);
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(skladnik2);
            int liczba2 = Convert.ToInt32(Console.ReadLine());
            int iloraz = liczba1 / liczba2;
            Console.WriteLine(wynik + iloraz);
        }

        public void menu()
        {
            Console.WriteLine(Menu);
            Console.WriteLine(dodawanie);
            Console.WriteLine(odejmowanie);
            Console.WriteLine(mnozenie);
            Console.WriteLine(dzielenie);
            Console.WriteLine(wyjscie);
        }

    }
}
