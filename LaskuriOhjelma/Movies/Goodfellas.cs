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
    public class Goodfellas
    {
        public void GoodFellas()
        {
            string movie = "Goodfellas";

            // suomiajan esitystä ja euroja varten
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fi-FI");

            DateTime dt = DateTime.Now;
            // merkitty dt2 = AddDays +2 jne..
            DateTime dt2_GF = dt.AddDays(2); // Goodfellas näyttöaika +2d nykyhetkeen ja klo 19:00
            DateTime dt3_GF = dt.AddDays(3); // Goodfellas näyttöaika +3d nykyhetkeen ja klo 20:00


            AnsiConsole.WriteLine($"Mahtavaa! {movie} on valikoimissa ja se on oikein hyvä valinta!");
            //Console.WriteLine("Seuraava näytös on: " + dt3.ToString("d") + " klo 18:30");

            // Create a table
            var table_Goodfellas = new Table();
            table_Goodfellas.Title("Goodfellas");

            // Add some columns
            table_Goodfellas.AddColumn(" Valmistusmaa: USA");
            table_Goodfellas.AddColumn(new TableColumn(" Valmistumisvuosi: 1990"));

            // Add some rows

            table_Goodfellas.AddRow(new Markup("[greenyellow] Ohjaaja[/]"), new Markup("[greenyellow] Martin Scorsese[/]"));
            table_Goodfellas.AddRow(new Markup("[greenyellow] Tuotantoyhtiö[/]"), new Markup("[greenyellow] Warner Bros.[/]"));
            table_Goodfellas.AddRow(new Markup("[greenyellow] Kesto[/]"), new Markup("[greenyellow] 146 min[/]"));
            table_Goodfellas.AddRow(new Markup("[greenyellow] Genre[/]"), new Markup("[greenyellow] Rikos[/]"));
            table_Goodfellas.AddRow(new Markup("[greenyellow] Ikäraja[/]"), new Markup("[darkorange3_1] 16[/]"));
            table_Goodfellas.AddRow(new Markup("[greenyellow] Alkuperäinen kieli[/]"), new Markup("[greenyellow] Englanti[/]"));
            table_Goodfellas.AddRow(new Markup("[greenyellow] Tekstitys[/]"), new Markup("[greenyellow] Suomi[/]"));
            table_Goodfellas.AddRow(new Markup("[greenyellow] Pääosat[/]"), new Markup("[greenyellow] Robert De Niro,\n " +
                "Ray Liotta,\n Joe Pesci,\n Lorraine Bracco,\n " +
                "Paul Sorvino [/]"));
            table_Goodfellas.Border(TableBorder.HeavyEdge);
            table_Goodfellas.BorderColor(Color.Grey30);
            // Render the table to the console
            table_Goodfellas.Centered();
            AnsiConsole.Write(table_Goodfellas);

            // Tässä seuraavat näytökset!
            Console.WriteLine("Seuraavat näytökset:");
            Console.WriteLine($"{dt2_GF:ddd MMM %d, yyyy}" + " klo 19:00");
            Console.WriteLine($"{dt3_GF:ddd MMM %d, yyyy}" + " klo 20:00");

            // Ask Promt mikä näytös!
            // selectionGF ->
            var selectionGF = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[cyan]Valitse näytösaika[/], Ole hyvä..")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more)[/]")
                    // set up valinnat alla
                    .AddChoices(new[] {
                        $"{dt2_GF:ddd MMM %d, yyyy}" + " klo 19:00",
                        $"{dt3_GF:ddd MMM %d, yyyy}" + " klo 20:00",
                    }));


            // Goodfellas KLO 19:00 ESITYS

            if (selectionGF == $"{dt2_GF:ddd MMM %d, yyyy}" + " klo 19:00")
            {
                // static metodin kutsu!
                Goodfellas_esitys_1900.Goodfellas_showtime_1900();
            }

            // Goodfellas KLO 20:00 ESITYS

            if (selectionGF == $"{dt3_GF:ddd MMM %d, yyyy}" + " klo 20:00")
            {
                // static metodin kutsu
                Goodfellas_esitys_2000.Goodfellas_showtime_2000();

            }       

        }

    }
    
}
