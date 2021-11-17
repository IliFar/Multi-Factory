using System;
using System.Collections.Generic;

namespace multifabriken_ilifar
{

    class Candy : Product
    {
        public Candy()
        {
            Console.Clear();

            Console.Write("Please write the candy flavor : ");
            flavor = Console.ReadLine();

            Console.Write("Write the quantity in GRAMS : ");
            quantity = Convert.ToInt32(Console.ReadLine());
        }
        public override string orderComplete()
        {
            Console.Clear();
            return ($"ORDER IS COMPLETE \n\nYou ordered {quantity}Grams of {flavor.ToUpper()} Candy.\n\nTHANK YOU FOR YOUR ORDER \n\nPress ENTER To Go Back To Menu");
        }
        public override string ordered()
        {
            return ($"Your Candy Order : \nYou ordered {quantity}Grams of {flavor.ToUpper()} Candy");
        }

    }





}