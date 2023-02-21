using System;
using LaskuriOhjelma.CanvasSamples;
using Spectre.Console;
using System.Globalization;


namespace LaskuriOhjelma.Movies

{
        // Tämä on Goodfellas esitys 19:00
	public class Goodfellas_esitys_1900
	{
       // class methods
        public static void Goodfellas_showtime_1900()
        {
           
            string movie = "Goodfellas";
            // suomiajan esitystä ja euroja varten
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fi-FI");
            DateTime dt = DateTime.Now;
            // merkitty dt2 = AddDays +2 jne..
            DateTime dt2_GF = dt.AddDays(2); // Goodfellas näyttöaika +2d nykyhetkeen ja klo 19:00
            DateTime dt3_GF = dt.AddDays(3); // Goodfellas näyttöaika +3d nykyhetkeen ja klo 20:00

            Console.WriteLine("Valitse paikat seuraavaksi. Press enter!");
            Console.ReadKey();

            // TÄHÄN CREATE TABLE, HUOM NÄYTETÄÄ VIHREÄLLÄ VAPAAT JA VARATUT PUNAISELLA
            // VAPAITA PAIKKOJA VOI VARATA Multiselection Promptilla
            Console.WriteLine("");

            // Create a table
            var table = new Table();
            var listGreenSeats = new List<String>();

            // Add some columns
            table.AddColumn(new TableColumn("Rivit").Centered());
            table.AddColumn(new TableColumn("S").Centered());
            table.AddColumn(new TableColumn("").Centered());
            table.AddColumn(new TableColumn("C").Centered());
            table.AddColumn(new TableColumn("").Centered());
            table.AddColumn(new TableColumn("R").Centered());
            table.AddColumn(new TableColumn("").Centered());
            table.AddColumn(new TableColumn("E").Centered());
            table.AddColumn(new TableColumn("").Centered());
            table.AddColumn(new TableColumn("E").Centered());
            table.AddColumn(new TableColumn("").Centered());
            table.AddColumn(new TableColumn("N").Centered());
            // RIVI 1
            table.AddRow(new Panel("[blue]R-1[/]"),
             new Panel("[green]P-1[/]").BorderColor(Color.Green3),
             new Panel("[green]P-2[/]").BorderColor(Color.Green3),
             new Panel("[green]P-3[/]").BorderColor(Color.Green3),
             new Panel("[red]P-4[/]").BorderColor(Color.Red3),  // red
             new Panel("[red]P-5[/]").BorderColor(Color.Red3),  // red
             new Panel("[green]P-6[/]").BorderColor(Color.Green3),
             new Panel("[green]P-7[/]").BorderColor(Color.Green3),
             new Panel("[green]P-8[/]").BorderColor(Color.Green3),
             new Panel("[green]P-9[/]").BorderColor(Color.Green3),
             new Panel("[green]P-10[/]").BorderColor(Color.Green3),
             new Panel("[green]P-11[/]").BorderColor(Color.Green3)
           );
            // RIVI 2
            table.AddRow(new Panel("[blue]R-2[/]"),
                new Panel("[red]P-1[/]").BorderColor(Color.Red3),
                new Panel("[green]P-2[/]").BorderColor(Color.Green3),
                new Panel("[green]P-3[/]").BorderColor(Color.Green3),
                new Panel("[green]P-4[/]").BorderColor(Color.Green3),
                new Panel("[red]P-5[/]").BorderColor(Color.Red3),
                new Panel("[red]P-6[/]").BorderColor(Color.Red3),
                new Panel("[red]P-7[/]").BorderColor(Color.Red3),
                new Panel("[red]P-8[/]").BorderColor(Color.Red3),
                new Panel("[red]P-9[/]").BorderColor(Color.Red3),
                new Panel("[red]P-10[/]").BorderColor(Color.Red3),
                new Panel("[red]P-11[/]").BorderColor(Color.Red3)
                );
            // RIVI 3
            table.AddRow(new Panel("[blue]R-3[/]"),
                new Panel("[red]P-1[/]").BorderColor(Color.Red3),
                new Panel("[red]P-2[/]").BorderColor(Color.Red3),
                new Panel("[red]P-3[/]").BorderColor(Color.Red3),
                new Panel("[red]P-4[/]").BorderColor(Color.Red3),
                new Panel("[red]P-5[/]").BorderColor(Color.Red3),
                new Panel("[red]P-6[/]").BorderColor(Color.Red3),
                new Panel("[red]P-7[/]").BorderColor(Color.Red3),
                new Panel("[grey37]P-8[/]").BorderColor(Color.Grey46), // Disabled
                new Panel("[grey37]P-9[/]").BorderColor(Color.Grey46), // Harmaana
                new Panel("[red]P-10[/]").BorderColor(Color.Red3),
                new Panel("[red]P-11[/]").BorderColor(Color.Red3)
                );
            // RIVI 4
            table.AddRow(new Panel("[blue]R-4[/]"),
                new Panel("[red]P-1[/]").BorderColor(Color.Red3),
                new Panel("[red]P-2[/]").BorderColor(Color.Red3),
                new Panel("[red]P-3[/]").BorderColor(Color.Red3),
                new Panel("[red]P-4[/]").BorderColor(Color.Red3),
                new Panel("[red]P-5[/]").BorderColor(Color.Red3),
                new Panel("[red]P-6[/]").BorderColor(Color.Red3),
                new Panel("[red]P-7[/]").BorderColor(Color.Red3),
                new Panel("[red]P-8[/]").BorderColor(Color.Red3), 
                new Panel("[green]P-9[/]").BorderColor(Color.Green3), 
                new Panel("[green]P-10[/]").BorderColor(Color.Green3),
                new Panel("[red]P-11[/]").BorderColor(Color.Red3)
                );





            // Render the table to the console
            table.Border(TableBorder.Rounded);
            table.Centered();
            AnsiConsole.Write(table);

            Console.WriteLine("");
            Console.WriteLine("Salin istumapaikkojen määrä yhteensä 44 kappaletta");

            Console.WriteLine("Vapaita paikkoja yhteensä: 14");

            // Create a list of seats
            AnsiConsole.Write(new BarChart()
                .Width(75)
                .Label($"[green bold underline]Esitysaika: {dt2_GF:d MMM yyyy} [/]"+"[green bold underline] klo 19:00 [/]")
                .CenterLabel()
                .AddItem("Vapaana", 14, Color.Green1)
                .AddItem("Varattu", 28, Color.Red1)
                .AddItem("Muut", 2, Color.Grey19));

            Console.WriteLine("");

            // Multiselection!
            // Valitkaa paikkanne!
            var seats = AnsiConsole.Prompt(
                new MultiSelectionPrompt<string>()
                    .Title("Valitse [green]paikkasi[/]!")
                    .Required() // Required! ja jos Not required = .NotRequired() 
                    .PageSize(20)
                    .MoreChoicesText("[grey](Liiku nuolinäppäimillä ylös ja alas)[/]")
                    .InstructionsText(
                        "[grey](Paina [blue]<space>[/] ja lukitse paikkasi ja paina " +
                        "[green]<enter>[/] vahvistaaksesi paikat. VALITSE VÄHINTÄÄN 1 Paikka, " +
                        "voit myöhemmin perua varauksen tarvittaessa!)[/]")
                    // Choises Group rivettäin!
                    // rivi 1 vapaat paikat
                    .AddChoiceGroup("Rivi-1", new[] {
                        "R-1 > Paikka #1",
                        "R-1 > Paikka #2",
                        "R-1 > Paikka #3",
                        "R-1 > Paikka #6",
                        "R-1 > Paikka #7",
                        "R-1 > Paikka #8",
                        "R-1 > Paikka #9",
                        "R-1 > Paikka #10",
                        "R-1 > Paikka #11",
                     })
                    // rivi 2 vapaat paikat
                    .AddChoiceGroup("Rivi-2", new[] {
                        "R-2 > Paikka #2",
                        "R-2 > Paikka #3",
                        "R-2 > Paikka #4",
                     })
                    // rivi 4 vapaat paikat
                    .AddChoiceGroup("Rivi-4", new[] {
                        "R-4 > Paikka #9", 
                        "R-4 > Paikka #10",
                     })
                    /*
                    .AddChoices(new[] {
                        "Extratuote-1", "Extratuote-2",
                    })
                    */
                    );

                AnsiConsole.Status()
                .Start("Ladataan tiedot ... odota hetki", ctx =>
                {
                    // Simulate some work
                    //AnsiConsole.MarkupLine("Paikkojen valinta");

                    // Update the status and spinner
                    ctx.Status("Päivitän paikkoja ja kokoan tiedot..");
                    ctx.Spinner(Spinner.Known.Ascii);
                    ctx.SpinnerStyle(Style.Parse("violet"));
                    // Simulate some work
                    Thread.Sleep(2200);
                });

                 Console.WriteLine("");

            // Varauksen yhteenveto!
            int kpl = 0;

            Console.WriteLine("Yhteenveto varauksesta");
            Printer.PrintUnderscored("** High-five Cinema **");
            Console.WriteLine("");
            Console.WriteLine("Elokuva: " + movie);
            Console.WriteLine($"Aika: {dt2_GF:d MMM yyyy}" + " klo 19:00");
            Console.WriteLine(("").PadRight(32, '-'));

            foreach (string seat in seats)
            {
                AnsiConsole.WriteLine("Istumapaikka: " + seat);
                kpl++;
            }

            if (kpl == 0)
            {
                // Tätä ei välttämättä tarvitse, mutta multiselectionissa on nyt .Required(), jos multiselectionsis
                // valinta on .NotRequired()
                // astuu tämä sääntö voimaan!
                Printer.PrintUnderscored("Et valinnut yhtään lippua! Paina enter lopettaaksesi.");
                Console.ReadKey();
            }
            else
            {


                Console.WriteLine("*** *** ***");
                Printer.PrintUnderscored("Tuotteet: "); // metodilla alaviiva!
                Printer.PrintUnderscored("Elokuvaliput: " + kpl + " kpl"); // metodilla alaviiva!
                Console.WriteLine("Lipun kappalehinta 15,00€");
                Console.WriteLine(("").PadRight(32, '-'));
                Console.WriteLine($"Veroton hinta:\t{(kpl * 15) - ((kpl * 15) * 0.24),16:c}");
                Console.WriteLine($"Vero Alv:\t{(kpl * 15) * 0.24,16:c} (24%)");

                Console.WriteLine(("").PadRight(32, '-'));

                Console.WriteLine($"Yhteensä:\t{kpl * 15,16:c}");
                Console.WriteLine("");
                Console.WriteLine("Kiitos asioinnista ja tervetuloa uudelleen!");

                // Pyydetään vahvistus
                var Selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[cyan]Vahvistetaanko varaus?[/]")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more)[/]")
                    .AddChoices(new[] {
                             "01 - Kyllä", "02 - Lopeta",
                    }));

                if (Selection == "01 - Kyllä")
                {
                    // kutsutaan erillistä metodia, jossa Canvas qr-koodi
                    QR1 QrKoodi1 = new QR1();
                    QrKoodi1.QrKoodiEka();
                }
                else if (Selection == "02 - Lopeta")
                {
                    Console.WriteLine("Paina enter lopettaksesi. Ostotapahtuma on peruttu ja tiliäsi ei veloitettu!");
                    Console.ReadKey();
                }






            }

        }
    }
    
     }