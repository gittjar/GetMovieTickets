using System;
using System.Data;
using System.Globalization;
using LaskuriOhjelma.CanvasSamples;
using LaskuriOhjelma.Movies;
using Spectre.Console;
using Rule = Spectre.Console.Rule;

namespace LaskuriOhjelma
{
	public class LeffaLippu
	{
   
        public void VaraaLeffalippu()
		{
            // suomiajan esitystä ja euroja varten
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fi-FI");

            AnsiConsole.Write(
            new FigletText(" ! Welcome to High-Five Cinema ! ")
            .Centered()
            .Color(Color.Pink1));

            TimeZoneInfo localZone = TimeZoneInfo.Local;
            DateTime now = DateTime.Now;

            var rule1 = new Rule("[purple_2]Päivämäärä ja aika[/]");
            //rule1.Alignment = Justify.Left;
            AnsiConsole.Write(rule1);

            // Table päivämäärät


            Console.WriteLine("Olet aikavyöhykkeellä: {0}", localZone.DisplayName);
            Console.WriteLine(now.ToString("ddd MMMM %d, yyyy"));
            Console.WriteLine(now.ToString("HH:mm"));


            // Ask for the user kanta-asiakas / elokuva?
            AnsiConsole.Status();
            var question = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[lightskyblue1]Valitse toiminto seuraavaksi:[/]")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more questions!)[/]")
                    .AddChoices(new[] {
                             "Kanta-asiakkaaksi liittyminen", "Elokuvat",
                    }));

                if (question == "Kanta-asiakkaaksi liittyminen")
                {
                    KantaAsiakas KAsiakas = new KantaAsiakas();
                    KAsiakas.KantaAsiakasLomake();
                }
                else if (question == "Elokuvat")
                {
                    
                }

            // --> jatkuu jos Elokuvat niin tästä alaspäin

            Console.WriteLine("Etsitään katsottavissa olevat elokuvat, press enter!");
            Console.ReadKey();

            AnsiConsole.Status()
                .Start("Ladataan elokuvia...", ctx =>
                {
                    // Simulate some work
                    AnsiConsole.MarkupLine("Etsitään näytökset..");

                    // Update the status and spinner
                    // ctx.Status("Thinking some more");
                    ctx.Spinner(Spinner.Known.Ascii);
                    ctx.SpinnerStyle(Style.Parse("green"));
                    // Simulate some work
                    Thread.Sleep(3500);
                });

            // Ask for the user
            var movie = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[lightskyblue1]Valitkaa elokuva[/]")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more movies)[/]")
                    .AddChoices(new[] {
                             "Home Alone 1", "Goodfellas",
                             "Full Metal Jacket",
                    }));

            var rule2 = new Rule("[purple_2]Elokuvalipun varaus[/]");
            //rule2.Alignment = Justify.Left;
            AnsiConsole.Write(rule2);


            if (movie == "Home Alone 1")
            {
                Console.WriteLine("Työn alla..1");
            }
            if (movie == "Goodfellas")
            {
                Console.WriteLine("Työn alla..2");
            }
            else if (movie == "Full Metal Jacket")
            {
                // metodin kutsu
                FullMetalJacket FMJMovie = new FullMetalJacket();
                FMJMovie.FMJ();
            }
            

        }


    }
}

