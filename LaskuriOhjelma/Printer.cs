using System;
namespace LaskuriOhjelma
{
	public class Printer
	{
        // class methods
        public static void PrintUnderscored(string input)
        {
            Console.WriteLine(input);
            PrintLine(input.Length);
        }

        public static void PrintLine(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}

/*
             HOW TO USE:

            public class Program 
            {
              public static void Main(string[] args)
              {

                // method use example 1.

                Printer.PrintUnderscored("Hello World!");

                // method use example 2.

                Item chair = new Item("Kartell Louis Ghost");
                Printer.PrintLine(chair.GetName().Length);
                Printer.PrintUnderscored(chair.ToString());
              }
            }


            Hello World!
            ------------
            -------------------
            Kartell Louis Ghost
            -------------------

 */