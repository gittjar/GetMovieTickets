using LaskuriOhjelma;
using Spectre.Console;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;
//using System.Data.Entity;

using LaskuriOhjelma.CanvasSamples;

namespace LaskuriOhjelma
{
class Program
{
    public static void Main(string[] args)

    {
        AnsiConsole.Write(
        new FigletText("O v.1.0")
        .Centered()
        .Color(Color.LightCyan1));

        AnsiConsole.Markup("[underline deepskyblue1]The World[/] Is Yours. Press Enter to continue..");
        Console.ReadKey();
        Console.WriteLine("");

        while (true)
        {

            // Ask for the user's favorite program!!
            var Selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[green]Select program[/]:")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more)[/]")
                    .AddChoices(new[] {
                                        "01 - High-five Cinema",
                                        "02 - Lopeta",
                    }));

            if (Selection == "01 - High-five Cinema")
            {
                LeffaLippu LeffalipunVaraus = new LeffaLippu();
                LeffalipunVaraus.VaraaLeffalippu();
                Console.WriteLine("Press any key to continue!");
                Console.ReadKey();
            }
            else if (Selection == "02 - Lopeta")
            {
                Console.WriteLine("You go exit. Goodbye. See you later!");
                Console.WriteLine("Press enter to quit.");
                break;
            }

        }
        Console.ReadKey();
    }

}}