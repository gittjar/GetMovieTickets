using System;
using Spectre.Console;

namespace LaskuriOhjelma.CanvasSamples
{
	public class QR2
	{
        public void QrKoodiToka()
		{

            Console.WriteLine("Mukavaa elokuvailtaa!");
            Printer.PrintUnderscored("Esitä tämä QR-koodi kassalla maksua varten.");
            Console.WriteLine("");

            // Create a QR koodi
            var canvas = new Canvas(16, 16);
            // Draw some shapes
            for (var i = 0; i < canvas.Width; i++)
            {
                // Sisus viivoja
                // näinpäin tulisi vaakaviiva reunasta reunaan
                // canvas.SetPixel(i,5,Color.White);

                // pystysuora valkoinen viiva 6. vasemmalta
                    canvas.SetPixel(6, i, Color.White);
                //canvas.SetPixel(i,11,Color.Orchid);

                // Reuna
                canvas.SetPixel(i, 0, Color.White);
                canvas.SetPixel(0, i, Color.White);
                canvas.SetPixel(i, canvas.Height - 1, Color.White);
                canvas.SetPixel(canvas.Width - 1, i, Color.White);
            }

            // 1. pystyrivi vasemmalta
            canvas.SetPixel(1, 1, Color.Grey50);
            canvas.SetPixel(1, 2, Color.Grey50);
            canvas.SetPixel(1, 3, Color.Grey50);
            canvas.SetPixel(1, 4, Color.Grey50);
            canvas.SetPixel(1, 5, Color.Red);
            canvas.SetPixel(1, 6, Color.GreenYellow);
            canvas.SetPixel(1, 7, Color.GreenYellow);
            canvas.SetPixel(1, 8, Color.GreenYellow);
            canvas.SetPixel(1, 9, Color.GreenYellow);
            canvas.SetPixel(1, 10, Color.Grey50);
            canvas.SetPixel(1, 11, Color.GreenYellow);
            canvas.SetPixel(1, 12, Color.GreenYellow);
            canvas.SetPixel(1, 13, Color.GreenYellow);
            canvas.SetPixel(1, 14, Color.Purple3);

            // 2. pystyrivi vasemmalta
            canvas.SetPixel(2, 1, Color.Grey42);
            canvas.SetPixel(2, 2, Color.Grey42);
            canvas.SetPixel(2, 3, Color.Grey42);
            canvas.SetPixel(2, 4, Color.Grey42);
            canvas.SetPixel(2, 5, Color.Magenta2_1);
            canvas.SetPixel(2, 6, Color.GreenYellow);
            canvas.SetPixel(2, 7, Color.GreenYellow);
            canvas.SetPixel(2, 8, Color.GreenYellow);
            canvas.SetPixel(2, 9, Color.GreenYellow);
            canvas.SetPixel(2, 10, Color.Grey50);
            canvas.SetPixel(2, 11, Color.GreenYellow);
            canvas.SetPixel(2, 12, Color.GreenYellow);
            canvas.SetPixel(2, 13, Color.GreenYellow);
            canvas.SetPixel(2, 14, Color.Purple3);

            // 3. pystyrivi vasemmalta
            canvas.SetPixel(3, 1, Color.Grey35);
            canvas.SetPixel(3, 2, Color.Grey35);
            canvas.SetPixel(3, 3, Color.Grey35);
            canvas.SetPixel(3, 4, Color.Grey35);
            canvas.SetPixel(3, 5, Color.Red);
            canvas.SetPixel(3, 6, Color.GreenYellow);
            canvas.SetPixel(3, 7, Color.GreenYellow);
            canvas.SetPixel(3, 8, Color.GreenYellow);
            canvas.SetPixel(3, 9, Color.GreenYellow);
            canvas.SetPixel(3, 10, Color.Grey50);
            canvas.SetPixel(3, 11, Color.GreenYellow);
            canvas.SetPixel(3, 12, Color.GreenYellow);
            canvas.SetPixel(3, 13, Color.GreenYellow);
            canvas.SetPixel(3, 14, Color.Purple3);

            // 4. pystyrivi vasemmalta
            canvas.SetPixel(4, 1, Color.Grey27);
            canvas.SetPixel(4, 2, Color.Grey27);
            canvas.SetPixel(4, 3, Color.Grey27);
            canvas.SetPixel(4, 4, Color.Grey27);
            canvas.SetPixel(4, 5, Color.Magenta2_1);
            canvas.SetPixel(4, 6, Color.GreenYellow);
            canvas.SetPixel(4, 7, Color.GreenYellow);
            canvas.SetPixel(4, 8, Color.GreenYellow);
            canvas.SetPixel(4, 9, Color.GreenYellow);
            canvas.SetPixel(4, 10, Color.Grey50);
            canvas.SetPixel(4, 11, Color.GreenYellow);
            canvas.SetPixel(4, 12, Color.GreenYellow);
            canvas.SetPixel(4, 13, Color.GreenYellow);
            canvas.SetPixel(4, 14, Color.Purple3);

            // 5. pystyrivi vasemmalta
            canvas.SetPixel(5, 1, Color.Grey19);
            canvas.SetPixel(5, 2, Color.Grey19);
            canvas.SetPixel(5, 3, Color.Grey19);
            canvas.SetPixel(5, 4, Color.Grey19);
            canvas.SetPixel(5, 5, Color.Red);
            canvas.SetPixel(5, 6, Color.GreenYellow);
            canvas.SetPixel(5, 7, Color.GreenYellow);
            canvas.SetPixel(5, 8, Color.GreenYellow);
            canvas.SetPixel(5, 9, Color.GreenYellow);
            canvas.SetPixel(5, 10, Color.Grey50);
            canvas.SetPixel(5, 11, Color.GreenYellow);
            canvas.SetPixel(5, 12, Color.GreenYellow);
            canvas.SetPixel(5, 13, Color.GreenYellow);
            canvas.SetPixel(5, 14, Color.Purple3);

            //
            //      6. pystyrivi on valkoinen viiva
            //      määrittely ylempänä!
            //

            // 7. pystyrivi vasemmalta
            canvas.SetPixel(7, 1, Color.Grey15);
            canvas.SetPixel(7, 2, Color.Grey15);
            canvas.SetPixel(7, 3, Color.Grey15);
            canvas.SetPixel(7, 4, Color.Grey15);
            canvas.SetPixel(7, 5, Color.Grey15);
            canvas.SetPixel(7, 6, Color.Grey15);
            canvas.SetPixel(7, 7, Color.Grey15);
            canvas.SetPixel(7, 8, Color.Grey15);
            canvas.SetPixel(7, 9, Color.Grey15);
            canvas.SetPixel(7, 10, Color.Grey15);
            canvas.SetPixel(7, 11, Color.Grey15);
            canvas.SetPixel(7, 12, Color.Grey15);
            canvas.SetPixel(7, 13, Color.Grey15);
            canvas.SetPixel(7, 14, Color.Grey15);

            // 8. pystyrivi vasemmalta
            canvas.SetPixel(8, 1, Color.Grey19);
            canvas.SetPixel(8, 2, Color.Grey19);
            canvas.SetPixel(8, 3, Color.Grey19);
            canvas.SetPixel(8, 4, Color.Grey19);
            canvas.SetPixel(8, 5, Color.Grey19);
            canvas.SetPixel(8, 6, Color.Grey19);
            canvas.SetPixel(8, 7, Color.Grey19);
            canvas.SetPixel(8, 8, Color.Grey19);
            canvas.SetPixel(8, 9, Color.Grey19);
            canvas.SetPixel(8, 10, Color.Grey19);
            canvas.SetPixel(8, 11, Color.Grey19);
            canvas.SetPixel(8, 12, Color.Grey19);
            canvas.SetPixel(8, 13, Color.Grey19);
            canvas.SetPixel(8, 14, Color.Grey19);

            // 9. pystyrivi vasemmalta
            canvas.SetPixel(9, 1, Color.Grey23);
            canvas.SetPixel(9, 2, Color.Grey23);
            canvas.SetPixel(9, 3, Color.Grey23);
            canvas.SetPixel(9, 4, Color.Grey23);
            canvas.SetPixel(9, 5, Color.Grey23);
            canvas.SetPixel(9, 6, Color.Grey23);
            canvas.SetPixel(9, 7, Color.Grey23);
            canvas.SetPixel(9, 8, Color.Grey23);
            canvas.SetPixel(9, 9, Color.Grey23);
            canvas.SetPixel(9, 10, Color.Grey23);
            canvas.SetPixel(9, 11, Color.Grey23);
            canvas.SetPixel(9, 12, Color.Grey23);
            canvas.SetPixel(9, 13, Color.Grey23);
            canvas.SetPixel(9, 14, Color.Grey23);

            // 10. pystyrivi vasemmalta
            canvas.SetPixel(10, 1, Color.Green3_1);
            canvas.SetPixel(10, 2, Color.Green3_1);
            canvas.SetPixel(10, 3, Color.Green3_1);
            canvas.SetPixel(10, 4, Color.Green3_1);
            canvas.SetPixel(10, 5, Color.Green3_1);
            canvas.SetPixel(10, 6, Color.Green3_1);
            canvas.SetPixel(10, 7, Color.Green3_1);
            canvas.SetPixel(10, 8, Color.Green3_1);
            canvas.SetPixel(10, 9, Color.Green3_1);
            canvas.SetPixel(10, 10, Color.Green3_1);
            canvas.SetPixel(10, 11, Color.Green3_1);
            canvas.SetPixel(10, 12, Color.Green3_1);
            canvas.SetPixel(10, 13, Color.Green3_1);
            canvas.SetPixel(10, 14, Color.Green3_1);

            // 11. pystyrivi vasemmalta
            canvas.SetPixel(11, 1, Color.Cyan2);
            canvas.SetPixel(11, 2, Color.Cyan2);
            canvas.SetPixel(11, 3, Color.Cyan2);
            canvas.SetPixel(11, 4, Color.Cyan2);
            canvas.SetPixel(11, 5, Color.Cyan2);
            canvas.SetPixel(11, 6, Color.Cyan2);
            canvas.SetPixel(11, 7, Color.Cyan2);
            canvas.SetPixel(11, 8, Color.Cyan2);
            canvas.SetPixel(11, 9, Color.Cyan2);
            canvas.SetPixel(11, 10, Color.Cyan2);
            canvas.SetPixel(11, 11, Color.Cyan2);
            canvas.SetPixel(11, 12, Color.Cyan2);
            canvas.SetPixel(11, 13, Color.Cyan2);
            canvas.SetPixel(11, 14, Color.Cyan2);

            // 12. pystyrivi vasemmalta
            canvas.SetPixel(12, 1, Color.Cyan1);
            canvas.SetPixel(12, 2, Color.Cyan1);
            canvas.SetPixel(12, 3, Color.Cyan1);
            canvas.SetPixel(12, 4, Color.Cyan1);
            canvas.SetPixel(12, 5, Color.Cyan1);
            canvas.SetPixel(12, 6, Color.Cyan1);
            canvas.SetPixel(12, 7, Color.Cyan1);
            canvas.SetPixel(12, 8, Color.Cyan1);
            canvas.SetPixel(12, 9, Color.Cyan1);
            canvas.SetPixel(12, 10, Color.Cyan1);
            canvas.SetPixel(12, 11, Color.Cyan1);
            canvas.SetPixel(12, 12, Color.Cyan1);
            canvas.SetPixel(12, 13, Color.Cyan1);
            canvas.SetPixel(12, 14, Color.Cyan1);

            // 13. pystyrivi vasemmalta
            canvas.SetPixel(13, 1, Color.Cyan1);
            canvas.SetPixel(13, 2, Color.Purple3);
            canvas.SetPixel(13, 3, Color.Cyan1);
            canvas.SetPixel(13, 4, Color.Purple3);
            canvas.SetPixel(13, 5, Color.Purple3);
            canvas.SetPixel(13, 6, Color.Cyan1);
            canvas.SetPixel(13, 7, Color.Cyan1);
            canvas.SetPixel(13, 8, Color.Purple3);
            canvas.SetPixel(13, 9, Color.Purple3);
            canvas.SetPixel(13, 10, Color.Cyan1);
            canvas.SetPixel(13, 11, Color.Cyan1);
            canvas.SetPixel(13, 12, Color.Purple3);
            canvas.SetPixel(13, 13, Color.Cyan1);
            canvas.SetPixel(13, 14, Color.Cyan1);

            // 14. pystyrivi vasemmalta
            canvas.SetPixel(14, 1, Color.Cyan1);
            canvas.SetPixel(14, 2, Color.Purple3);
            canvas.SetPixel(14, 3, Color.Cyan1);
            canvas.SetPixel(14, 4, Color.Purple3);
            canvas.SetPixel(14, 5, Color.Purple3);
            canvas.SetPixel(14, 6, Color.Cyan1);
            canvas.SetPixel(14, 7, Color.Cyan1);
            canvas.SetPixel(14, 8, Color.Purple3);
            canvas.SetPixel(14, 9, Color.Purple3);
            canvas.SetPixel(14, 10, Color.Cyan1);
            canvas.SetPixel(14, 11, Color.Cyan1);
            canvas.SetPixel(14, 12, Color.Purple3);
            canvas.SetPixel(14, 13, Color.Cyan1);
            canvas.SetPixel(14, 14, Color.Cyan1);

            // Render the canvas
            AnsiConsole.Write(canvas);
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();

		}
    }
}
