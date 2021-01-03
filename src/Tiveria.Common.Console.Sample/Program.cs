using System;
using Con = System.Console;
namespace Tiveria.Common.XConsole.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i = 0; i<25;i++)
            {
                var mod = i % 10;
                if (mod == 0)
                    System.Console.WriteLine("0123456789012345678901234567890123456789012345678901234567890");
                else
                    System.Console.WriteLine(i);
            }

            Output.WriteAt(10, 10, "Now at (10,10)");
            Output.WriteAt(10, 11, ConsoleColor.Red, "Now at (10,11) in red");
            Output.WriteAt(10, 12, ConsoleColor.Red, ConsoleColor.Green, "Now at (10,11) in red with green bg");
            Output.WriteAt(0, 20, "Done.");

            Con.WriteLine($"The current window size is {Con.LargestWindowHeight} rows and {Con.WindowWidth} columns.");
            Con.WriteLine($"The current buffer size is {Con.BufferHeight} rows and {Con.BufferWidth} columns.");

        }
    }
}
