using System;
using LaskuriOhjelma.CanvasSamples;
using Spectre.Console;

namespace LaskuriOhjelma.Movies
{
	public class FMJ_esitys_1830
	{
        public static void FMJ_showtime_1830()
        {
            string movie = "Full Metal Jacket";
            DateTime dt = DateTime.Now;
            DateTime dt3_FMJ = dt.AddDays(1); // Full Metal Jacket näyttöaika +1d nykyhetkeen ja klo 18:30
            DateTime dt5_FMJ = dt.AddDays(5); // Full Metal Jacket näyttöaika +5d nykyhetkeen ja klo 21:00

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
             new Panel("[green]P-11[/]").BorderColor(Color.Green3),
             new Panel("[green]P-12[/]").BorderColor(Color.Green3),
             new Panel("[green]P-13[/]").BorderColor(Color.Green3),
             new Panel("[green]P-14[/]").BorderColor(Color.Green3),
             new Panel("[green]P-15[/]").BorderColor(Color.Green3)
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
                new Panel("[green]P-9[/]").BorderColor(Color.Green3),
                new Panel("[red]P-10[/]").BorderColor(Color.Red3),
                new Panel("[red]P-11[/]").BorderColor(Color.Red3),
                new Panel("[green]P-12[/]").BorderColor(Color.Green3),
                new Panel("[green]P-13[/]").BorderColor(Color.Green3),
                new Panel("[green]P-14[/]").BorderColor(Color.Green3),
                new Panel("[green]P-15[/]").BorderColor(Color.Green3)
                );
            // RIVI 5
            table.AddRow(new Panel("[blue]R-5[/]"),
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
                new Panel("[grey27]P-14[/]").BorderColor(Color.Grey27),
                new Panel("[grey27]P-15[/]").BorderColor(Color.Grey27)
                );

            // Add some rows
            // table.AddRow("Baz", "[green]Qux[/]");
            // table.AddRow(new Markup("[blue]Corgi[/]"), new Panel("Waldo"));

            // green paikat listaan
            // rivi 1
            listGreenSeats.Add("R1-P1");
            listGreenSeats.Add("R1-P2");
            listGreenSeats.Add("R1-P3");
            listGreenSeats.Add("R1-P4");
            listGreenSeats.Add("R1-P5");
            listGreenSeats.Add("R1-P6");
            listGreenSeats.Add("R1-P7");
            listGreenSeats.Add("R1-P8");
            listGreenSeats.Add("R1-P9");
            listGreenSeats.Add("R1-P10");
            listGreenSeats.Add("R1-P11");
            listGreenSeats.Add("R1-P12");
            listGreenSeats.Add("R1-P13");
            listGreenSeats.Add("R1-P14");
            listGreenSeats.Add("R1-P15");
            // rivi 4 green paikat
            listGreenSeats.Add("R4-P1");
            listGreenSeats.Add("R4-P2");
            listGreenSeats.Add("R4-P3");
            listGreenSeats.Add("R4-P9");
            listGreenSeats.Add("R4-P12");
            listGreenSeats.Add("R4-P13");
            listGreenSeats.Add("R4-P14");
            listGreenSeats.Add("R4-P15");

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
                .Label("[green bold underline]Varaustilanne[/]")
                .CenterLabel()
                .AddItem("Vapaana", listGreenSeats.Count, Color.Green1)
                .AddItem("Varattu", 49, Color.Red1)
                .AddItem("Muut", 3, Color.Grey19));

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
                    // rivi 1 jne
                    .AddChoiceGroup("Rivi-1", new[] {
                        "R1-P1","R1-P2","R1-P3","R1-P4","R1-P5","R1-P6","R1-P7","R1-P8","R1-P9",
                        "R1-P10","R1-P11","R1-P12","R1-P13","R1-P14","R1-P15",
                     })
                    // rivi 4 jne
                    .AddChoiceGroup("Rivi-4", new[] {
                        "R4-P1", "R4-P2", "R4-P3","R4-P9", "R4-P12", "R4-P13","R4-P14", "R4-P15",
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
                    ctx.SpinnerStyle(Style.Parse("violet"));
                    // Simulate some work
                    Thread.Sleep(3500);
                });


            //  Laskuri 

            //  foreach (string seat in seats)
            //  {
            //      AnsiConsole.WriteLine(seat);
            //      kpl++;
            //  }
            //  Console.WriteLine("Olette hankkimassa: " + kpl + " kappaletta lippuja.");
            //  Console.WriteLine("Hinta yht. " + kpl * 15 + " euroa.");



            Console.WriteLine("");

            // Varauksen yhteenveto!
            int kpl = 0;

            Console.WriteLine("Yhteenveto varauksesta");
            Printer.PrintUnderscored("** High-five Cinema **");
            Console.WriteLine("");
            Console.WriteLine("Elokuva: " + movie);
            Console.WriteLine($"Aika: {dt3_FMJ:d MMM yyyy}" + " klo 18:30");
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


                Console.WriteLine("- * - * -");
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


