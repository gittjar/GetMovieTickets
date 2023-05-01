using System;
using Spectre.Console;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using Microsoft.EntityFrameworkCore;

// gittjar 22.2.2023

namespace LaskuriOhjelma
{
	public class KantaAsiakas
	{


        public void KantaAsiakasLomake()
        {



        // databasen säädöt
        using var db = new KantaContext();

        Printer.PrintUnderscored($"Tietokantasi osoite / your database path: {db.DbPath}.");
        
        AnsiConsole.Markup("[black on green3] Anna nimi tai nimimerkki ->  [/] ");
        string? inputName = Console.ReadLine();
        AnsiConsole.Markup("[black on green3] Anna lempielokuvasi ->  [/] ");
        string? inputFavmovie = Console.ReadLine();

            // lisää nimi ja elokuva Asiakas databaseen
            db.Asiakas.Add(new Asiakas
            {
                Name = inputName,
                Favmovie = inputFavmovie
            });

            db.SaveChanges();
            Console.WriteLine("");

            AnsiConsole.Status()
                .Start("... odota hetki", ctx =>
                {
                    ctx.Status("Tallennan dataa tietokantaan.");
                    ctx.Spinner(Spinner.Known.Aesthetic);
                    ctx.SpinnerStyle(Style.Parse("lime"));
                    Thread.Sleep(3000);
                });

            AnsiConsole.Markup("[lime]Lisätty onnistuneesti tietokantaan.[/]");
            Console.WriteLine("");
            Printer.PrintUnderscored($"Käyttäjä: {inputName}, jonka lempielokuva on {inputFavmovie}");
            Console.WriteLine("Paina Enter jatkaaksesi!");
            Console.ReadKey();
            // ASIAKASLISTA

            Printer.PrintUnderscored("Järjestelmässä on nyt seuraavat kanta-asiakkaat:");
            using (var context = new KantaContext())
            {
              var kantaasiakas = context.Asiakas;
                foreach (var x in kantaasiakas)
                {
                    var data = new StringBuilder();
                    // Jos halutaan rivettäin
                    /* 
                    data.AppendLine($"ID nro: {x.ID}");
                    data.AppendLine($"Nimi tai nimimerkki: {x.Name}");
                    data.AppendLine($"Lempielokuva: {x.Favmovie}");
                    */

                    // AppendFormat tulostetaan rivi per tietue      
                    data.AppendFormat($"ID nro: {x.ID} * Nimi tai nimimerkki: {x.Name} * Lempielokuva: {x.Favmovie}",Environment.NewLine);      
                    Console.WriteLine(data.ToString());
                }
            }
            Console.WriteLine("");

        // DELETE ID
                    
                    while (true)
                    {
                    // Ask for the user's favorite program!!
                        var Selection = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                            .Title("[fuchsia]Poista käyttäjä?[/]")
                            .PageSize(10)
                            .MoreChoicesText("[grey](Move up and down to reveal more)[/]")
                            .AddChoices(new[] {
                                                "01 - Kyllä",
                                                "02 - Ei (siirry elokuviin)",
                        }));
                        if (Selection == "01 - Kyllä")

                        {
                    
                            // using var db = new KantaContext();
                                Console.Write("Enter the user ID to delete, or press ENTER to continue: ");
                                int inputDelete;
                                bool isValid = int.TryParse(Console.ReadLine(), out inputDelete);
                                if (!isValid || inputDelete <= 0)
                                {
                                    Console.WriteLine("Invalid ID. Operation cancelled.");
                                    return;
                                }
                                var userToDelete = db.Asiakas?.SingleOrDefault(r => r.ID == inputDelete);
                                if (userToDelete == null)
                                {
                                    Console.WriteLine($"User with ID {inputDelete} not found. Operation cancelled.");
                                    return;
                                }
                                Console.WriteLine($"Are you sure you want to delete record with ID {inputDelete}? (Y/N)");
                                string? confirmation = Console.ReadLine()?.ToLower();
                                if (confirmation != "y")
                                {
                                    Console.WriteLine("Operation cancelled.");
                                    return;
                                }
                                db.Asiakas?.Remove(userToDelete);
                                db.SaveChanges();
                                Console.WriteLine($"User with ID {inputDelete} deleted successfully.");

                                AnsiConsole.Status()
                                .Start("Ladataan tiedot ... odota hetki", ctx =>
                                {
                                    ctx.Status("Ladataan..");
                                    ctx.Spinner(Spinner.Known.Aesthetic);
                                    ctx.SpinnerStyle(Style.Parse("aqua"));
                                    Thread.Sleep(3000);
                                });
                                                        
                            }
                            else if (Selection == "02 - Ei (siirry elokuviin)")
                            {
                                break;
                            }
                }
            }
    }}