using LaskuriOhjelma;
using Spectre.Console;
/*CREATED JARNO .NET22*/
public static class Program
{
    public static void Main(string[] args)

    {
        AnsiConsole.Write(
        new FigletText("Ohjelma v.1.0")
        .Centered()
        .Color(Color.LightCyan1));

        AnsiConsole.Markup("[underline deepskyblue1]The World[/] Is Yours. Press Enter to continue..");
        Console.ReadKey();
        Console.WriteLine("");

        while (true)
        {

            // Ask for the user's favorite program!!
            var Selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[green]Select program[/]:")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more)[/]")
                    .AddChoices(new[] {
                                        "01 - Varaa elokuvalippu",
                                        "02 - Lopeta",
                    }));

            if (Selection == "01 - Varaa elokuvalippu")
            {
                LeffaLippu LeffalipunVaraus = new LeffaLippu();
                LeffalipunVaraus.VaraaLeffalippu();
                Console.WriteLine("Press any key to continue!");
                Console.ReadKey();
            }
            else if (Selection == "02 - Lopeta")
            {
                Console.WriteLine("You go exit. Goodbye. See you later!");
                Console.WriteLine("Press enter to quit.");
                break;
            }

        }
        Console.ReadKey();



    }
}