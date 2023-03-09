using Kalkulatornia;

Services services = new Services();

while (true)
{
    services.menu();
    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            services.wyborJeden();
            break;
        case "2":
            services.wyborDwa();
            break;
        case "3":
            services.wyborTrzy();
            break;  
        case "4":
            services.wyborCztery();
            break;
        case "5":
            goto exit_loop;
    }
    Console.WriteLine("Aby wrócić, naciśnij dowolny klawisz");
    Console.ReadLine();
    Console.Clear();
}
exit_loop:;
