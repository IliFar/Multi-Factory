using System;
using System.Collections.Generic;

namespace multifabriken_ilifar
{

    class Strings : Product
    {
        public Strings()
        {
            Console.Clear();

            Console.Write("Please write the color you want : ");
            color = Console.ReadLine();

            Console.Write("Write the length in centimeters : ");
            length = Convert.ToInt32(Console.ReadLine());
        }
        public override string orderComplete()
        {
            Console.Clear();
            return ($"ORDER IS COMPLETE \n\nYou ordered a {color.ToUpper()} {length}Cm String \n\nTHANK YOU FOR YOUR ORDER \n\nENTER To Go Back To Menu");
        }
        public override string ordered()
        {
            return ($"Your Strings' Order : \nYou ordered a {color.ToUpper()} {length}Cm String");
        }
    }





}