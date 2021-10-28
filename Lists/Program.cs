using System;
using System.Collections.Generic;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishes = new List<string>();
            myWishes.Add("new crocs sport mode ++");
            myWishes.Add("new umbrella, must be bulletproof");
            myWishes.Add("Porche 911 year 1995");

            //Console.WriteLine($"There are {myWishes.Count} items on your wishlist");

            // Console.WriteLine(myWishes[0]);
            // Console.WriteLine(myWishes[myWishes.Count - 1]);

            foreach (string wish in myWishes)
            {
                Console.WriteLine($"item on your wish lis is: {wish}");
            }

            Console.WriteLine("Enter a wish");
            string userWish = Console.ReadLine();

            myWishes.Add(userWish);

            foreach (string wish in myWishes)
            {
                Console.WriteLine($"Item in your wish list is: {wish}");
            }
        }
    }
}
