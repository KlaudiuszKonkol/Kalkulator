while (true)
{
    string Menu = "MENU";
    string dodawanie = "Dodawanie - 1";
    string odejmowanie = "Odejmowanie - 2";
    string mnozenie = "Mnożenie - 3";
    string dzielenie = "Dzielenie - 4";
    string wyjscie = "Wyjście - 5";
    string skladnik = "Podaj pierwszy składnik";
    string skladnik2 = "Podaj drugi składnik";
    string wybor1 = "Wybrano Dodawanie " + skladnik;
    string wybor2 = "Wybrano Odejmowanie " + skladnik;
    string wybor3 = "Wybrano Mnożenie " + skladnik;
    string wybor4 = "Wybrano Dzielenie " + skladnik;
    string wynik = "Twój wynik to: ";
    Console.WriteLine(Menu);
    Console.WriteLine(dodawanie);
    Console.WriteLine(odejmowanie);
    Console.WriteLine(mnozenie);
    Console.WriteLine(dzielenie);
    Console.WriteLine(wyjscie);
    string input = Console.ReadLine();
    if (input == "1")
    {
        Console.WriteLine(wybor1);
        int liczba1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(skladnik2);
        int liczba2 = Convert.ToInt32(Console.ReadLine());
        int suma = liczba1 + liczba2;
        Console.WriteLine(wynik + suma);
    }
    else if (input == "2")
    {
        Console.WriteLine(wybor2);
        int liczba1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(skladnik2);
        int liczba2 = Convert.ToInt32(Console.ReadLine());
        int różnica = liczba1 - liczba2;
        Console.WriteLine(wynik + różnica);
    }
    else if (input == "3")
    {
        Console.WriteLine(wybor3);
        int liczba1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(skladnik2);
        int liczba2 = Convert.ToInt32(Console.ReadLine());
        int iloczyn = liczba1 * liczba2;
        Console.WriteLine(wynik + iloczyn);
    }
    else if (input == "4")
    {
        Console.WriteLine(wybor4);
        int liczba1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(skladnik2);
        int liczba2 = Convert.ToInt32(Console.ReadLine());
        int iloraz = liczba1 / liczba2;
        Console.WriteLine(wynik + iloraz);
    }
    else if (input == "5")
    {
        break;
    }
    Console.WriteLine("Aby wrócić, naciśnij dowolny klawisz");
    Console.ReadLine();
    Console.Clear();
}