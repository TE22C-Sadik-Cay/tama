


int correct = 7;
int number = 0;

while (number != correct)
{

    bool kundeKonvertera = false;
    while (kundeKonvertera == false)
    {
        Console.WriteLine("guess a number");
        string svar = Console.ReadLine();
        kundeKonvertera = int.TryParse(svar, out number);

        if (kundeKonvertera == false)
        {
            Console.WriteLine("try again");
        }
    }

    if (number == correct)
    {
        Console.WriteLine("congrats");
    }
    else if (number > correct)
    {
        Console.WriteLine("too high");
    }
    else if (number < correct)
    {
        Console.WriteLine("too low");
    }
}

Console.ReadLine();