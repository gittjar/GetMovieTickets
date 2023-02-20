using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using Microsoft.EntityFrameworkCore;



namespace LaskuriOhjelma
{
	public class KantaAsiakas
	{
        // class methods
        public void KantaAsiakasLomake()
        {

            // database säädöt

        using var db = new KantaContext();

        Printer.PrintUnderscored($"Your database path: {db.DbPath}.");
        
        Console.WriteLine("Anna nimi tai nimimerkki:");
        string? inputName = Console.ReadLine();
        Console.WriteLine("Anna lempielokuvasi:");
        string? inputFavmovie = Console.ReadLine();

            // Adds some info
            db.Asiakas.Add(new Asiakas
            {
                Name = inputName,
                Favmovie = inputFavmovie
            });

            db.SaveChanges();
            Console.WriteLine("");

            Printer.PrintUnderscored("Järjestelmässä on nyt seuraavat kanta-asiakkaat:");

            using (var context = new KantaContext())
            {
                var kantaasiakas = context.Asiakas;
                foreach (var x in kantaasiakas)
                {
                    var data = new StringBuilder();

                    data.AppendLine($"ID nro: {x.ID}");
                    data.AppendLine($"Nimi tai nimimerkki: {x.Name}");
                    data.AppendLine($"Lempielokuva: {x.Favmovie}");
                    Console.WriteLine(data.ToString());

                }

            }



        }}}
