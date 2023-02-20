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
            DateTime dt3_GF = dt.AddDays(2); // Goodfellas näyttöaika +2d nykyhetkeen ja klo 19:00
            DateTime dt5_GF = dt.AddDays(3); // Goodfellas näyttöaika +3d nykyhetkeen ja klo 20:00


            AnsiConsole.WriteLine($"Mahtavaa! {movie} on valikoimissa ja se on oikein hyvä valinta!");
            //Console.WriteLine("Seuraava näytös on: " + dt3.ToString("d") + " klo 18:30");

            // Create a table
            var table_Goodfellas = new Table();
            table_Goodfellas.Title("Goodfellas");

            // Add some columns
            table_Goodfellas.AddColumn(" Valmistusmaat: USA ja UK");
            table_Goodfellas.AddColumn(new TableColumn(" Valmistumisvuosi: 1987"));

            // Add some rows

            table_Goodfellas.AddRow(new Markup("[cornsilk1] Ohjaaja[/]"), new Markup("[cornsilk1] Stanley Kubrick[/]"));
            table_Goodfellas.AddRow(new Markup("[cornsilk1] Tuotantoyhtiö[/]"), new Markup("[cornsilk1] Warner Bros.[/]"));
            table_Goodfellas.AddRow(new Markup("[cornsilk1] Kesto[/]"), new Markup("[cornsilk1] 116 min[/]"));
            table_Goodfellas.AddRow(new Markup("[cornsilk1] Genre[/]"), new Markup("[cornsilk1] Sota[/]"));
            table_Goodfellas.AddRow(new Markup("[cornsilk1] Ikäraja[/]"), new Markup("[darkorange3_1] 16[/]"));
            table_Goodfellas.AddRow(new Markup("[cornsilk1] Alkuperäinen kieli[/]"), new Markup("[cornsilk1] Englanti[/]"));
            table_Goodfellas.AddRow(new Markup("[cornsilk1] Tekstitys[/]"), new Markup("[cornsilk1] Suomi[/]"));
            table_Goodfellas.AddRow(new Markup("[cornsilk1] Pääosat[/]"), new Markup("[cornsilk1] Matthew Modine,\n " +
                "Adam Baldwin,\n Vincent D'Onofrio,\n Lee Ermey,\n " +
                "Dorian Harewood,\n Arliss Howard,\n Kevyn Major Howard,\n Ed O'Ross[/]"));



        }


    }
    
}
