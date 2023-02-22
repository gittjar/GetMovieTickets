using System;
using LaskuriOhjelma.CanvasSamples;
using Spectre.Console;

namespace LaskuriOhjelma.Movies
{
        // Tämä on Goodfellas esitys 20:00
	public class Goodfellas_esitys_2000
	{
       // class methods
        public static void Goodfellas_showtime_2000()
        {
            string movie = "Goodfellas";
            // suomiajan esitystä ja euroja varten
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
            List<int> listGreySeats = new List<int>();


            // Add some columns
            table.AddColumn(new TableColumn("Rivit").Centered());
            table.AddColumn(new TableColumn("S").Centered());
            table.AddColumn(new TableColumn("C").Centered());
            table.AddColumn(new TableColumn("R").Centered());
            table.AddColumn(new TableColumn("E").Centered());
            table.AddColumn(new TableColumn("E").Centered());
            table.AddColumn(new TableColumn("N").Centered());
            table.AddColumn(new TableColumn("*").Centered());
            table.AddColumn(new TableColumn("I").Centered());
            table.AddColumn(new TableColumn("S").Centered());
            table.AddColumn(new TableColumn("*").Centered());
            table.AddColumn(new TableColumn("H").Centered());
            table.AddColumn(new TableColumn("E").Centered());
            table.AddColumn(new TableColumn("R").Centered());
            table.AddColumn(new TableColumn("E").Centered());
            table.AddColumn(new TableColumn("!").Centered());
            // RIVI 1
            table.AddRow(new Panel("[blue]R-1[/]"),
             new Panel("[red]P-1[/]").BorderColor(Color.Red3),
             new Panel("[red]P-2[/]").BorderColor(Color.Red3),
             new Panel("[red]P-3[/]").BorderColor(Color.Red3),
             new Panel("[red]P-4[/]").BorderColor(Color.Red3),
             new Panel("[red]P-5[/]").BorderColor(Color.Red3),
             new Panel("[red]P-6[/]").BorderColor(Color.Red3),
             new Panel("[green]P-7[/]").BorderColor(Color.Green3),
             new Panel("[red]P-8[/]").BorderColor(Color.Red3),
             new Panel("[red]P-9[/]").BorderColor(Color.Red3),
             new Panel("[red]P-10[/]").BorderColor(Color.Red3),
             new Panel("[red]P-11[/]").BorderColor(Color.Red3),
             new Panel("[red]P-12[/]").BorderColor(Color.Red3),
             new Panel("[red]P-13[/]").BorderColor(Color.Red3),
             new Panel("[red]P-14[/]").BorderColor(Color.Red3),
             new Panel("[red]P-15[/]").BorderColor(Color.Red3)
           );

            // RIVI 2
            table.AddRow(new Panel("[blue]R-2[/]"),
                new Panel("[red]P-1[/]").BorderColor(Color.Red3),
                new Panel("[red]P-2[/]").BorderColor(Color.Red3),
                new Panel("[red]P-3[/]").BorderColor(Color.Red3),
                new Panel("[red]P-4[/]").BorderColor(Color.Red3),
                new Panel("[red]P-5[/]").BorderColor(Color.Red3),
                new Panel("[red]P-6[/]").BorderColor(Color.Red3),
                new Panel("[red]P-7[/]").BorderColor(Color.Red3),
                new Panel("[red]P-8[/]").BorderColor(Color.Red3),
                new Panel("[red]P-9[/]").BorderColor(Color.Red3),
                new Panel("[red]P-10[/]").BorderColor(Color.Red3),
                new Panel("[red]P-11[/]").BorderColor(Color.Red3),
                new Panel("[red]P-12[/]").BorderColor(Color.Red3),
                new Panel("[red]P-13[/]").BorderColor(Color.Red3),
                new Panel("[red]P-14[/]").BorderColor(Color.Red3),
                new Panel("[red]P-15[/]").BorderColor(Color.Red3)
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
                new Panel("[red]P-8[/]").BorderColor(Color.Red3),
                new Panel("[red]P-9[/]").BorderColor(Color.Red3),
                new Panel("[red]P-10[/]").BorderColor(Color.Red3),
                new Panel("[red]P-11[/]").BorderColor(Color.Red3),
                new Panel("[red]P-12[/]").BorderColor(Color.Red3),
                new Panel("[red]P-13[/]").BorderColor(Color.Red3),
                new Panel("[red]P-14[/]").BorderColor(Color.Red3),
                new Panel("[grey27]P-15[/]").BorderColor(Color.Grey27)
                );
            // RIVI 4
            table.AddRow(new Panel("[blue]R-4[/]"),
                new Panel("[green]P-1[/]").BorderColor(Color.Green3),
                new Panel("[green]P-2[/]").BorderColor(Color.Green3),
                new Panel("[green]P-3[/]").BorderColor(Color.Green3),
                new Panel("[red]P-4[/]").BorderColor(Color.Red3),
                new Panel("[red]P-5[/]").BorderColor(Color.Red3),
                new Panel("[red]P-6[/]").BorderColor(Color.Red3),
                new Panel("[red]P-7[/]").BorderColor(Color.Red3),
                new Panel("[red]P-8[/]").BorderColor(Color.Red3),
                new Panel("[red]P-9[/]").BorderColor(Color.Red3),
                new Panel("[red]P-10[/]").BorderColor(Color.Red3),
                new Panel("[red]P-11[/]").BorderColor(Color.Red3),
                new Panel("[red]P-12[/]").BorderColor(Color.Red3),
                new Panel("[red]P-13[/]").BorderColor(Color.Red3),
                new Panel("[red]P-14[/]").BorderColor(Color.Red3),
                new Panel("[red]P-15[/]").BorderColor(Color.Red3)
                );
            // RIVI 5
            table.AddRow(new Panel("[blue]R-5[/]"),
                new Panel("[red]P-1[/]").BorderColor(Color.Red3),
                new Panel("[red]P-2[/]").BorderColor(Color.Red3),
                new Panel("[red]P-3[/]").BorderColor(Color.Red3),
                new Panel("[red]P-4[/]").BorderColor(Color.Red3),
                new Panel("[green]P-5[/]").BorderColor(Color.Green3),
                new Panel("[green]P-6[/]").BorderColor(Color.Green3),
                new Panel("[red]P-7[/]").BorderColor(Color.Red3),
                new Panel("[red]P-8[/]").BorderColor(Color.Red3),
                new Panel("[red]P-9[/]").BorderColor(Color.Red3),
                new Panel("[red]P-10[/]").BorderColor(Color.Red3),
                new Panel("[red]P-11[/]").BorderColor(Color.Red3),
                new Panel("[red]P-12[/]").BorderColor(Color.Red3),
                new Panel("[red]P-13[/]").BorderColor(Color.Red3),
                new Panel("[grey27]P-14[/]").BorderColor(Color.Grey27),
                new Panel("[grey27]P-15[/]").BorderColor(Color.Grey27)
                );

            // Add some rows
            // table.AddRow("Baz", "[green]Qux[/]");
            // table.AddRow(new Markup("[blue]Corgi[/]"), new Panel("Waldo"));

            // green paikat listaan
            // rivi 1
            listGreenSeats.Add("R1-P7");
            // rivi 4 green paikat
            listGreenSeats.Add("R4-P1");
            listGreenSeats.Add("R4-P2");
            listGreenSeats.Add("R4-P3");
                // 5.
            listGreenSeats.Add("R5-P5");
            listGreenSeats.Add("R5-P6");

            // grey paikat listaan , joita on 3 kpl !
            listGreySeats.Add(1);
            listGreySeats.Add(2);
            listGreySeats.Add(3);

            // Render the table to the console
            table.Border(TableBorder.None);
            table.Centered();
            AnsiConsole.Write(table);

            Console.WriteLine("");

            Console.WriteLine("Salin istumapaikkojen määrä yhteensä 75 kappaletta");
            // green paikat listalta ulos!
            Console.WriteLine("Vapaita paikkoja yhteensä: " + listGreenSeats.Count);
            
            // Create a list of seats
            AnsiConsole.Write(new BarChart()
                .Width(75)
                .Label($"[green bold underline]Varaustilanne ja esitysaika: {dt3_GF:d MMM yyyy} [/]"+"[green bold underline] klo 20:00 [/]")
                .CenterLabel()
                .AddItem("Vapaana", listGreenSeats.Count, Color.Green1)
                .AddItem("Varattu", 66, Color.Red1)
                .AddItem("Muut", listGreySeats.Count, Color.Grey19));

            Console.WriteLine("");


            // Multiselection!
            // Valitkaa paikkanne!
            var seats = AnsiConsole.Prompt(
                new MultiSelectionPrompt<string>()
                    .Title("[greenyellow] Valitse paikkasi ![/]")
                    .Required() // Required! ja jos Not required = .NotRequired() 
                    .PageSize(20)
                    .MoreChoicesText("[grey](Liiku nuolinäppäimillä ylös ja alas)[/]")
                    .InstructionsText(
                        "[grey](Paina [blue]<space>[/] ja lukitse paikkasi ja paina " +
                        "[green]<enter>[/] vahvistaaksesi paikat. VALITSE VÄHINTÄÄN 1 Paikka, " +
                        "voit myöhemmin perua varauksen tarvittaessa!)[/]")
                    // Choises Group rivettäin!
                    // rivi 1 
                    .AddChoiceGroup("Rivi-1", new[] {
                        "Rivi 1 > P7",
                     })
                    // rivi 4 
                    .AddChoiceGroup("Rivi-4", new[] {
                        "Rivi 4 > P1", "Rivi 4 > P2", "Rivi 4 > P3",
                     })

                        // rivi 5 
                    .AddChoiceGroup("Rivi-5", new[] {
                        "Rivi 5 > P5", "Rivi 5 > P6",
                     })
                    /*
                    .AddChoices(new[] {
                        "Extratuote-1", "Extratuote-2",
                    })
                    */
                    );


            // tulostetaan valitut paikat ja kappalemäärä

            AnsiConsole.Status()
                .Start("Ladataan tiedot ... odota hetki", ctx =>
                {
                    // Simulate some work
                    //AnsiConsole.MarkupLine("Paikkojen valinta");

                    // Update the status and spinner
                    ctx.Status("Päivitän paikkoja ja kokoan tiedot..");
                    ctx.Spinner(Spinner.Known.Ascii);
                    ctx.SpinnerStyle(Style.Parse("lime"));
                    // Simulate some work
                    Thread.Sleep(3500);
                });

            Console.WriteLine("");

            // Varauksen yhteenveto!
            int kpl = 0;

            Console.WriteLine("Yhteenveto varauksesta");
            Printer.PrintUnderscored("** High-five Cinema **");
            Console.WriteLine("");
            Console.WriteLine("Elokuva: " + movie);
            Console.WriteLine($"Aika: {dt3_GF:d MMM yyyy}" + " klo 21:00");
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
                        QR2 QrKoodi2 = new QR2();
                        QrKoodi2.QrKoodiToka();
                        }
                        else if (Selection == "02 - Lopeta")
                        {
                        //
                        //  TABLE
                        //

                        var footertable = new Table();

                        footertable.AddColumn("Elokuva: " + movie + "\n" + $"Aika: {dt3_GF:d MMM yyyy}" + " (klo 20:00)");
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