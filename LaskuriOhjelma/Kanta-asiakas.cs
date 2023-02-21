using System;
using Spectre.Console;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace LaskuriOhjelma
{
	public class KantaAsiakas
	{

        public void KantaAsiakasLomake()
        {

        // databasen säädöt
        using var db = new KantaContext();

        Printer.PrintUnderscored($"Tietokantasi osoite / your database path: {db.DbPath}.");
        
        AnsiConsole.Markup("[black on green3]Anna nimi tai nimimerkki >[/] ");
        string? inputName = Console.ReadLine();
        AnsiConsole.Markup("[black on green3]Anna lempielokuvasi >[/] ");
        string? inputFavmovie = Console.ReadLine();

            // Adds some info
            db.Asiakas.Add(new Asiakas
            {
                Name = inputName,
                Favmovie = inputFavmovie
            });

            db.SaveChanges();
            Console.WriteLine("");
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

            AnsiConsole.Markup("[white on blueviolet]Poista käyttäjä? Anna ID nro, joka poistetaan tai - kirjoita 999 - jatkaaksesi.[/]");   
            Console.WriteLine("");
  

            int del;
            while (true)
            {
                while(!int.TryParse(Console.ReadLine(), out del)) Console.WriteLine("Vain numerot kelpaavat!");
                {
                    if (del < 0)
                    {
                    AnsiConsole.Markup("[red]Annoit negatiivisen luvun![/]");
                    }
                    else if (del == 0)
                    {
                    AnsiConsole.Markup("[red]Annoit nollan![/]");    
                    }
  
                    else if (del == 999)
                    {
                    AnsiConsole.Markup("[lime]Valitsit jatka ohjelmaa.[/]");
                    break;
                    }
                    else if (del > 0)
                    { 
                        // FIX THIS MORE! Works now but Exeption loops wrong.
                        try
                        {
                        var deleteasiakas = new Asiakas() { ID = del };
                        db.Asiakas.Attach(deleteasiakas);
                        db.Asiakas.Remove(deleteasiakas);
                        db.SaveChanges();
                        Console.WriteLine($"Poistettu onnistuneesti asiakas ID: {del}");
                        break;    
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine($"{del} is an invalid value for AsiakasDatabase!");
                           // throw;
                        }
                        finally
                        {
                            Console.WriteLine("kokeile toista ID numeroa.");
                            // question tänne lisäksi?
                        }

                    }
                }



            }












        }}}
