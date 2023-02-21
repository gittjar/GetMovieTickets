using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using LaskuriOhjelma.CanvasSamples;
using Microsoft.VisualBasic;
using Spectre.Console;

namespace LaskuriOhjelma.Movies
{
    public class FullMetalJacket
    {
        // tänne kaikki FullMetalJacketiin liittyvä!
        public void FMJ()
        {
            string movie = "Full Metal Jacket";

            // suomiajan esitystä ja euroja varten
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fi-FI");

            DateTime dt = DateTime.Now;
            DateTime dt3_FMJ = dt.AddDays(1); // Full Metal Jacket näyttöaika +1d nykyhetkeen ja klo 18:30
            DateTime dt5_FMJ = dt.AddDays(5); // Full Metal Jacket näyttöaika +5d nykyhetkeen ja klo 21:00


            AnsiConsole.WriteLine($"Mahtavaa! {movie} on valikoimissa ja se on oikein hyvä valinta!");
            //Console.WriteLine("Seuraava näytös on: " + dt3.ToString("d") + " klo 18:30");

            // Create a table

            var table_FMJ = new Table();
            table_FMJ.Title("Full Metal Jacket");
            // Add some columns
            table_FMJ.AddColumn(" Valmistusmaat: USA ja UK");
            table_FMJ.AddColumn(new TableColumn(" Valmistumisvuosi: 1987"));

            // Add some rows

            table_FMJ.AddRow(new Markup("[cornsilk1] Ohjaaja[/]"), new Markup("[cornsilk1] Stanley Kubrick[/]"));
            table_FMJ.AddRow(new Markup("[cornsilk1] Tuotantoyhtiö[/]"), new Markup("[cornsilk1] Warner Bros.[/]"));
            table_FMJ.AddRow(new Markup("[cornsilk1] Kesto[/]"), new Markup("[cornsilk1] 116 min[/]"));
            table_FMJ.AddRow(new Markup("[cornsilk1] Genre[/]"), new Markup("[cornsilk1] Sota[/]"));
            table_FMJ.AddRow(new Markup("[cornsilk1] Ikäraja[/]"), new Markup("[darkorange3_1] 16[/]"));
            table_FMJ.AddRow(new Markup("[cornsilk1] Alkuperäinen kieli[/]"), new Markup("[cornsilk1] Englanti[/]"));
            table_FMJ.AddRow(new Markup("[cornsilk1] Tekstitys[/]"), new Markup("[cornsilk1] Suomi[/]"));
            table_FMJ.AddRow(new Markup("[cornsilk1] Pääosat[/]"), new Markup("[cornsilk1] Matthew Modine,\n " +
                "Adam Baldwin,\n Vincent D'Onofrio,\n Lee Ermey,\n " +
                "Dorian Harewood,\n Arliss Howard,\n Kevyn Major Howard,\n Ed O'Ross[/]"));



            table_FMJ.Border(TableBorder.HeavyEdge);
            table_FMJ.BorderColor(Color.Grey35);
            // Render the table to the console
            table_FMJ.Centered();
            AnsiConsole.Write(table_FMJ);



            // String = FMJ_naytos_1 = ""Seuraava näytös on {dt3_FMJ: ddd MMM % d, yyyy""
            // Tässä seuraavat näytökset!
            Console.WriteLine("Seuraavat näytökset:");
            Console.WriteLine($"{dt3_FMJ:ddd MMM %d, yyyy}" + " klo 18:30");
            Console.WriteLine($"{dt5_FMJ:ddd MMM %d, yyyy}" + " klo 21:00");

            // Ask Promt mikä näytös!
            // selectionFMJ ->
            var selectionFMJ = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[cyan]Valitse näytösaika[/], Ole hyvä..")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more)[/]")
                    // set up valinnat alla
                    .AddChoices(new[] {

                        $"{dt3_FMJ:ddd MMM %d, yyyy}" + " klo 18:30",
                        $"{dt5_FMJ:ddd MMM %d, yyyy}" + " klo 21:00",

                    }));
            //
            // KLO 21:00 ESITYS
            //

            if (selectionFMJ == $"{dt5_FMJ:ddd MMM %d, yyyy}" + " klo 21:00")
            {
                // static metodin kutsu!
                FMJ_esitys_2100.FMJ_showtime_2100();
            }


            //
            // KLO 18:30 ESITYS
            //

            if (selectionFMJ == $"{dt3_FMJ:ddd MMM %d, yyyy}" + " klo 18:30")
            {
                // static metodin kutsu
                FMJ_esitys_1830.FMJ_showtime_1830();

            }
        }

    }
}