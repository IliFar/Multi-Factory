using System;
using System.Collections.Generic;

namespace multifabriken_ilifar
{
    class Tofu : Product
    {
        public Tofu()
        {
            Console.Clear();

            Console.Write("Please write volume in liters : ");
            volume = float.Parse(Console.ReadLine());

            Console.Write("Write the spices you want in your Tofu : ");
            spices = Console.ReadLine();
        }
        public override string orderComplete()
        {
            Console.Clear();
            return ($"ORDER IS COMPLETE \n\nYou ordered {volume.ToString("N1")}L of Tofu spiced with {spices.ToUpper()}.\n\nTHANK YOU FOR YOUR ORDER \n\nPress ENTER To Go Back To Menu");
        }
        public override string ordered()
        {
            return ($"Your Tofu Order : \nYou ordered {volume.ToString("N1")}L of Tofu spiced with {spices.ToUpper()}.");
        }
    }
}
