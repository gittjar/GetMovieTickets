using System;
using LaskuriOhjelma.CanvasSamples;
using Spectre.Console;
using System.Globalization;

namespace LaskuriOhjelma.Movies
{
    // Tämä on Home Alone esitys 17:00
	public class HomeAlone_esitys_1700
	{
       // class methods
        public static void HomeAlone_showtime_1700()
        {
            string movie = "Home Alone";
            // suomiajan esitystä ja euroja varten
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fi-FI");
            DateTime dt = DateTime.Now;
            // merkitty dt1 = AddDays +1 jne..

            DateTime dt1_HA = dt.AddDays(1); // Home Alone näyttöaika +1d nykyhetkeen ja klo 17:00
            DateTime dt4_HA = dt.AddDays(4); // Home Alone näyttöaika +4d nykyhetkeen ja klo 19:00

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
             new Panel("[green]P-4[/]").BorderColor(Color.Green3), 
             new Panel("[green]P-5[/]").BorderColor(Color.Green3),  
             new Panel("[green]P-6[/]").BorderColor(Color.Green3),
             new Panel("[green]P-7[/]").BorderColor(Color.Green3),
             new Panel("[green]P-8[/]").BorderColor(Color.Green3),
             new Panel("[green]P-9[/]").BorderColor(Color.Green3),
             new Panel("[green]P-10[/]").BorderColor(Color.Green3),
             new Panel("[green]P-11[/]").BorderColor(Color.Green3)
           );
            // RIVI 2
            table.AddRow(new Panel("[blue]R-2[/]"),
                new Panel("[green]P-1[/]").BorderColor(Color.Green3),
                new Panel("[green]P-2[/]").BorderColor(Color.Green3),
                new Panel("[green]P-3[/]").BorderColor(Color.Green3),
                new Panel("[green]P-4[/]").BorderColor(Color.Green3),
                new Panel("[green]P-5[/]").BorderColor(Color.Green3),
                new Panel("[green]P-6[/]").BorderColor(Color.Green3),
                new Panel("[green]P-7[/]").BorderColor(Color.Green3),
                new Panel("[green]P-8[/]").BorderColor(Color.Green3),
                new Panel("[green]P-9[/]").BorderColor(Color.Green3),
                new Panel("[green]P-10[/]").BorderColor(Color.Green3),
                new Panel("[green]P-11[/]").BorderColor(Color.Green3)
                );
            // RIVI 3
            table.AddRow(new Panel("[blue]R-3[/]"),
                new Panel("[green]P-1[/]").BorderColor(Color.Green3),
                new Panel("[green]P-2[/]").BorderColor(Color.Green3),
                new Panel("[green]P-3[/]").BorderColor(Color.Green3),
                new Panel("[green]P-4[/]").BorderColor(Color.Green3),
                new Panel("[green]P-5[/]").BorderColor(Color.Green3),
                new Panel("[green]P-6[/]").BorderColor(Color.Green3),
                new Panel("[green]P-7[/]").BorderColor(Color.Green3),
                new Panel("[grey37]P-8[/]").BorderColor(Color.Grey46), // Disabled
                new Panel("[grey37]P-9[/]").BorderColor(Color.Grey46), // Disabled
                new Panel("[green]P-10[/]").BorderColor(Color.Green3),
                new Panel("[green]P-11[/]").BorderColor(Color.Green3)
                );
            // RIVI 4
            table.AddRow(new Panel("[blue]R-4[/]"),
                new Panel("[green]P-1[/]").BorderColor(Color.Green3),
                new Panel("[green]P-2[/]").BorderColor(Color.Green3),
                new Panel("[green]P-3[/]").BorderColor(Color.Green3),
                new Panel("[green]P-4[/]").BorderColor(Color.Green3),
                new Panel("[green]P-5[/]").BorderColor(Color.Green3),
                new Panel("[green]P-6[/]").BorderColor(Color.Green3),
                new Panel("[green]P-7[/]").BorderColor(Color.Green3),
                new Panel("[green]P-8[/]").BorderColor(Color.Green3), 
                new Panel("[green]P-9[/]").BorderColor(Color.Green3), 
                new Panel("[green]P-10[/]").BorderColor(Color.Green3),
                new Panel("[green]P-11[/]").BorderColor(Color.Green3)
                );

            // Render the table to the console
            table.Border(TableBorder.Heavy);
            table.Centered();
            AnsiConsole.Write(table);

            Console.WriteLine("");
            Console.WriteLine("Salin istumapaikkojen määrä yhteensä 44 kappaletta");
            Console.WriteLine("Vapaita paikkoja yhteensä: 42");
            Console.WriteLine("");
            // Create a list of seats
            AnsiConsole.Write(new BarChart()
                .Width(75) // chartin leveys > jotta alempi teksti näkyy samalla rivillä!
                .Label($"[green bold underline]Esitysaika: {dt1_HA:d MMM yyyy} [/]"+"[green bold underline] klo 17:00 [/]")
                .CenterLabel()
                .AddItem("Vapaana", 42, Color.Green1)
                .AddItem("Varattu", 0, Color.Red1)
                .AddItem("Muut", 2, Color.Grey19));

            Console.WriteLine("");

            // Multiselection!
            // Valitkaa paikkanne!
            var seats = AnsiConsole.Prompt(
                new MultiSelectionPrompt<string>()
                    .Title("Valitse [green]paikkasi[/]!")
                    .Required() // Required! ja jos Not required = .NotRequired() 
                    .PageSize(25)
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
                        "R-1 > Paikka #4",
                        "R-1 > Paikka #5",
                        "R-1 > Paikka #6",
                        "R-1 > Paikka #7",
                        "R-1 > Paikka #8",
                        "R-1 > Paikka #9",
                        "R-1 > Paikka #10",
                        "R-1 > Paikka #11",
                     })
                    // rivi 2 vapaat paikat
                    .AddChoiceGroup("Rivi-2", new[] {
                        "R-2 > Paikka #1",
                        "R-2 > Paikka #2",
                        "R-2 > Paikka #3",
                        "R-2 > Paikka #4",
                        "R-2 > Paikka #5",
                        "R-2 > Paikka #6",
                        "R-2 > Paikka #7",
                        "R-2 > Paikka #8",
                        "R-2 > Paikka #9",
                        "R-2 > Paikka #10",
                        "R-2 > Paikka #11",
                     })
                    // rivi 3 vapaat paikat
                    .AddChoiceGroup("Rivi-3", new[] {
                        "R-3 > Paikka #1",
                        "R-3 > Paikka #2",
                        "R-3 > Paikka #3",
                        "R-3 > Paikka #4",
                        "R-3 > Paikka #5",
                        "R-3 > Paikka #6",
                        "R-3 > Paikka #7",
                        "R-3 > Paikka #10",
                        "R-3 > Paikka #11",
                     })
                    // rivi 4 vapaat paikat
                    .AddChoiceGroup("Rivi-4", new[] {
                        "R-4 > Paikka #1",
                        "R-4 > Paikka #2",
                        "R-4 > Paikka #3",
                        "R-4 > Paikka #4",
                        "R-4 > Paikka #5",
                        "R-4 > Paikka #6",
                        "R-4 > Paikka #7",
                        "R-4 > Paikka #8",
                        "R-4 > Paikka #9",
                        "R-4 > Paikka #10",
                        "R-4 > Paikka #11",
                    }
                    ));

                AnsiConsole.Status()
                .Start("Ladataan tiedot ... odota hetki", ctx =>
                {
                    // Simulate some work
                    //AnsiConsole.MarkupLine("Paikkojen valinta");

                    // Update the status and spinner
                    ctx.Status("Päivitän paikkoja ja kokoan tiedot..");
                    ctx.Spinner(Spinner.Known.Ascii);
                    ctx.SpinnerStyle(Style.Parse("aqua"));
                    // Simulate some work
                    Thread.Sleep(2300);
                });

                Console.WriteLine("");

                // Varauksen yhteenveto!
                int kpl = 0;

                // Create receipt
                Console.WriteLine("Yhteenveto varauksesta");
                Printer.PrintUnderscored("** High-five Cinema **");
                Console.WriteLine("Elokuva: " + movie);
                Console.WriteLine($"Aika: {dt1_HA:d MMM yyyy}" + " klo 17:00");
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
                AnsiConsole.Markup("[lime]Lipun kappalehinta 15,00€[/]");
                Console.WriteLine("");

                Console.WriteLine(("").PadRight(32, '-'));
                Console.WriteLine($"Veroton hinta:\t{(kpl * 15) - ((kpl * 15) * 0.24),16:c}");
                Console.WriteLine($"Vero Alv:\t{(kpl * 15) * 0.24,16:c} (24%)");
                Console.WriteLine("");
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
                        QR3 QrKoodi3 = new QR3();
                        QrKoodi3.QrKoodiKolmas();
                        }
                        else if (Selection == "02 - Lopeta")
                        {
                        //
                        //  TABLE
                        //

                        var footertable = new Table();

                        footertable.AddColumn("Elokuva: " + movie + "\n" + $"Aika: {dt1_HA:d MMM yyyy}" + " (klo 17:00)");
                        footertable.AddColumn("Tilaus peruttu");

                        footertable.AddRow("Varaustapahtuma: " + "[red3]Ei vahvistettu[/]", "");
                        footertable.AddRow(
                        "Paina enter lopettaksesi." + "\n" + "Tilaustapahtuma on peruttu ja tiliäsi ei veloitettu!", "[lime]See you next time![/]"
                        );
                        // Render the table to the console
                        footertable.Border(TableBorder.Horizontal);
                        AnsiConsole.Write(footertable);
                        Console.ReadKey();
                        }
             
                }

        }
    }
}