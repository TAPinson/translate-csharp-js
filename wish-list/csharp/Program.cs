using System;
using System.Collections.Generic;

namespace wishlist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> iWishFor = new List<string>();
            iWishFor.Add("An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'");
            iWishFor.Add("The ability to think of interesting wishes on short notice");
            iWishFor.Add("A washtub of Skittles");
            iWishFor.Add("World peace, but not the kind of world peace where all the humans are removed from existence");
            iWishFor.Add("A TV that is NOT internet-capable");
            iWishFor.Add("The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?");

            foreach (string wish in iWishFor)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
