using System;

namespace Favourite_Number_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {   int favouritenumberA;
            int favouritenumberB;
            int newfavnum;
            
            Console.WriteLine("What's your favourite number?");
            favouritenumberA = int.Parse(Console.ReadLine());
            Console.WriteLine("What's your second favourite number?");
            favouritenumberB = int.Parse(Console.ReadLine());
            newfavnum = favouritenumberA * favouritenumberB;
            Console.WriteLine("Your new favourite number " + newfavnum);
        }
    }
}
