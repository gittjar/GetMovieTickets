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
    public class Homealone
    {

        public void HomeAlone()
        {
            string movie = "Home Alone";
            // suomiajan esitystä ja euroja varten
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fi-FI");

            DateTime dt = DateTime.Now;
            // merkitty dt2 = AddDays +2 jne..
            DateTime dt1_HA = dt.AddDays(2); // Goodfellas näyttöaika +2d nykyhetkeen ja klo 17:00
            DateTime dt4_HA = dt.AddDays(3); // Goodfellas näyttöaika +3d nykyhetkeen ja klo 19:00

            AnsiConsole.WriteLine($"Mahtavaa! {movie} on valikoimissa ja se on oikein hyvä valinta!");
            //Console.WriteLine("Seuraava näytös on: " + dt3.ToString("d") + " klo 18:30");

            // Create a table
            var table_Homealone = new Table();
            table_Homealone.Title("Home Alone");

            // Add some columns, Live draws table
            AnsiConsole.Live(table_Homealone)
            .Start(ctx => 
            {
                table_Homealone.AddColumn(" Valmistusmaa: USA");
                        ctx.Refresh();
                        Thread.Sleep(1000);

                table_Homealone.AddColumn(new TableColumn(" Valmistumisvuosi: 1990"));
                        ctx.Refresh();
                        Thread.Sleep(1000);

                // Add some rows
                table_Homealone.AddRow(new Markup("[yellow2] Ohjaaja[/]"), new Markup("[yellow2] Chris Columbus[/]"));
                        ctx.Refresh();
                        Thread.Sleep(400);

                table_Homealone.AddRow(new Markup("[yellow2] Tuotantoyhtiö[/]"), new Markup("[yellow2] 20th Century Fox[/]"));
                        ctx.Refresh();
                        Thread.Sleep(400);

                table_Homealone.AddRow(new Markup("[yellow2] Kesto[/]"), new Markup("[yellow2] 103 min[/]"));
                        ctx.Refresh();
                        Thread.Sleep(400);

                table_Homealone.AddRow(new Markup("[yellow2] Genre[/]"), new Markup("[yellow2] Komedia[/]"));
                        ctx.Refresh();
                        Thread.Sleep(400);

                table_Homealone.AddRow(new Markup("[yellow2] Ikäraja[/]"), new Markup(" [grey11 on green3]S[/]"));
                        ctx.Refresh();
                        Thread.Sleep(400);

                table_Homealone.AddRow(new Markup("[yellow2] Alkuperäinen kieli[/]"), new Markup("[yellow2] Englanti[/]"));
                        ctx.Refresh();
                        Thread.Sleep(400);

                table_Homealone.AddRow(new Markup("[yellow2] Tekstitys[/]"), new Markup("[yellow2] Suomi[/]"));
                        ctx.Refresh();
                        Thread.Sleep(400);

                table_Homealone.AddRow(new Markup("[yellow2] Pääosat[/]"), new Markup("[yellow2] Macaulay Culkin,\n " +
                    "Daniel Stern,\n Joe Pesci,\n John Heard,\n " +
                    "Roberts Blossom,\n Catherine O'Hara [/]"));
                        ctx.Refresh();
                        Thread.Sleep(400);
                

                table_Homealone.Border(TableBorder.HeavyEdge);
                    ctx.Refresh();
                    Thread.Sleep(1000);

                table_Homealone.BorderColor(Color.Grey30);
                    ctx.Refresh();
                    Thread.Sleep(1000);

            
                // Render the table to the console
                table_Homealone.Centered();

               // AnsiConsole.Write(table_Homealone);
            });    

             // Tässä seuraavat näytökset!
            Console.WriteLine("Seuraavat näytökset:");
            Console.WriteLine($"{dt1_HA:ddd MMM %d, yyyy}" + " klo 17:00");
            Console.WriteLine($"{dt4_HA:ddd MMM %d, yyyy}" + " klo 19:00");

            // Ask Promt mikä näytös!
            // selection Home Alone ->
            var selectionHA = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[cyan]Valitse näytösaika[/], Ole hyvä..")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more)[/]")
                    // set up valinnat alla
                    .AddChoices(new[] {
                        $"{dt1_HA:ddd MMM %d, yyyy}" + " klo 17:00",
                        $"{dt4_HA:ddd MMM %d, yyyy}" + " klo 19:00",
                    }));

            // Home Alone KLO 17:00 ESITYS
            if (selectionHA == $"{dt1_HA:ddd MMM %d, yyyy}" + " klo 17:00")
            {
                // static metodin kutsu!
                HomeAlone_esitys_1700.HomeAlone_showtime_1700();
            }

            // Home Alone KLO 19:00 ESITYS
            if (selectionHA == $"{dt4_HA:ddd MMM %d, yyyy}" + " klo 19:00")
            {
                // static metodin kutsu
                HomeAlone_esitys_1900.HomeAlone_showtime_1900();
            }       

        } 
    }
}