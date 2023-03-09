string Menu = "MENU Kalkulatora";
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

void wyborJeden()
{
    Console.WriteLine(wybor1);
    int liczba1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(skladnik2);
    int liczba2 = Convert.ToInt32(Console.ReadLine());
    int suma = liczba1 + liczba2;
    Console.WriteLine(wynik + suma);
}

void wyborDwa()
{
    Console.WriteLine(wybor2);
    int liczba1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(skladnik2);
    int liczba2 = Convert.ToInt32(Console.ReadLine());
    int różnica = liczba1 - liczba2;
    Console.WriteLine(wynik + różnica);
}

void wyborTrzy()
{
    Console.WriteLine(wybor3);
    int liczba1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(skladnik2);
    int liczba2 = Convert.ToInt32(Console.ReadLine());
    int iloczyn = liczba1 * liczba2;
    Console.WriteLine(wynik + iloczyn);
}

void wyborCztery()
{
    Console.WriteLine(wybor4);
    int liczba1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(skladnik2);
    int liczba2 = Convert.ToInt32(Console.ReadLine());
    int iloraz = liczba1 / liczba2;
    Console.WriteLine(wynik + iloraz);
}

void menu()
{
    Console.WriteLine(Menu);
    Console.WriteLine(dodawanie);
    Console.WriteLine(odejmowanie);
    Console.WriteLine(mnozenie);
    Console.WriteLine(dzielenie);
    Console.WriteLine(wyjscie);
}

while (true)
{
    menu();
    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            wyborJeden();
            break;
        case "2":
            wyborDwa();
            break;
        case "3":
            wyborTrzy();
            break;  
        case "4":
            wyborCztery();
            break;
        case "5":
            goto exit_loop;
    }
    Console.WriteLine("Aby wrócić, naciśnij dowolny klawisz");
    Console.ReadLine();
    Console.Clear();
}
exit_loop:;
