using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            var book = new Books("The Way of Kings", "Brandon Sanderson");
            var movie = new Movies("Carol", "R");
            var song = new Music("Some Beach", "Blake Shelton");

            Console.WriteLine($"Book: {book}")
        }
    }
}