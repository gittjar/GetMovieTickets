using System;
using Spectre.Console;

namespace LaskuriOhjelma.CanvasSamples
{
	public class QR3
	{

        public void QrKoodiKolmas()
        {
            Console.WriteLine("Mukavaa elokuvailtaa!");
            Printer.PrintUnderscored("Esitä tämä QR-koodi kassalla maksua varten.");
            Console.WriteLine("");

            // Create a QR koodi
            var canvas = new Canvas(5, 10);
            // Draw some shapes

            // 0. pystyrivi vasemmalta
            canvas.SetPixel(0, 0, Color.Aqua);
            canvas.SetPixel(0, 1, Color.Grey50);
            canvas.SetPixel(0, 2, Color.Grey50);
            canvas.SetPixel(0, 3, Color.Grey50);
            canvas.SetPixel(0, 4, Color.Grey50);
            canvas.SetPixel(0, 5, Color.Grey50);
            canvas.SetPixel(0, 6, Color.Grey50);
            canvas.SetPixel(0, 7, Color.Grey50);
            canvas.SetPixel(0, 8, Color.Grey50);
            canvas.SetPixel(0, 9, Color.Aqua);

            // 1. pystyrivi vasemmalta
            canvas.SetPixel(1, 0, Color.Grey50);
            canvas.SetPixel(1, 1, Color.Maroon);
            canvas.SetPixel(1, 2, Color.Maroon);
            canvas.SetPixel(1, 3, Color.Black);
            canvas.SetPixel(1, 4, Color.Purple);
            canvas.SetPixel(1, 5, Color.Fuchsia);
            canvas.SetPixel(1, 6, Color.Black);
            canvas.SetPixel(1, 7, Color.Maroon);
            canvas.SetPixel(1, 8, Color.Maroon);
            canvas.SetPixel(1, 9, Color.Grey50);

            // 2. pystyrivi vasemmalta
            canvas.SetPixel(2, 0, Color.Grey50);
            canvas.SetPixel(2, 1, Color.Maroon);
            canvas.SetPixel(2, 2, Color.Maroon);
            canvas.SetPixel(2, 3, Color.Maroon);
            canvas.SetPixel(2, 4, Color.Black);
            canvas.SetPixel(2, 5, Color.Fuchsia);
            canvas.SetPixel(2, 6, Color.Maroon);
            canvas.SetPixel(2, 7, Color.Black);
            canvas.SetPixel(2, 8, Color.Maroon);
            canvas.SetPixel(2, 9, Color.Grey50);

            // 3. pystyrivi vasemmalta
            canvas.SetPixel(3, 0, Color.Grey50);
            canvas.SetPixel(3, 1, Color.Maroon);
            canvas.SetPixel(3, 2, Color.Maroon);
            canvas.SetPixel(3, 3, Color.Black);
            canvas.SetPixel(3, 4, Color.Purple);
            canvas.SetPixel(3, 5, Color.Black);
            canvas.SetPixel(3, 6, Color.Maroon);
            canvas.SetPixel(3, 7, Color.Maroon);
            canvas.SetPixel(3, 8, Color.Maroon);
            canvas.SetPixel(3, 9, Color.Grey50);

            // 4. pystyrivi vasemmalta
            canvas.SetPixel(4, 0, Color.Aqua);
            canvas.SetPixel(4, 1, Color.Grey50);
            canvas.SetPixel(4, 2, Color.Grey50);
            canvas.SetPixel(4, 3, Color.Grey50);
            canvas.SetPixel(4, 4, Color.Grey50);
            canvas.SetPixel(4, 5, Color.Grey50);
            canvas.SetPixel(4, 6, Color.Grey50);
            canvas.SetPixel(4, 7, Color.Grey50);
            canvas.SetPixel(4, 8, Color.Grey50);
            canvas.SetPixel(4, 9, Color.Aqua);

            // Render the canvas
            AnsiConsole.Write(canvas);
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();


        }


    }

}    