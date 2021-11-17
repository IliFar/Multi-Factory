using System;
using System.Collections.Generic;

namespace multifabriken_ilifar
{

    class Car : Product
    {

        public Car()
        {
            Console.Clear();

            Console.Write("Please Write the letters of the plate letters (3 Letters): ");
            plateLetters = Console.ReadLine();

            Console.Write("Write the letters of the plate numbers : ");
            plateNumbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The car's plate number is : {plateLetters.ToUpper()}{plateNumbers}");

            Console.Write("Write the color you want : ");
            color = Console.ReadLine();

            Console.Write("Write a car brand : ");
            brand = Console.ReadLine();

        }

        public override string orderComplete()
        {
            Console.Clear();
            return ($"ORDER IS COMPLETE \n\nYou ordered a {color.ToUpper()} {brand.ToUpper()} possessing the following plate number : {plateLetters.ToUpper()}{plateNumbers} \n\nTHANK YOU FOR YOUR ORDER \nPress ENTER Go Back To Menu");

        }
        public override string ordered()
        {
            return ($"Your Cars' Order : \nYou ordered a {color} {brand} possessing the following plate number : {plateLetters.ToUpper()}{plateNumbers}");
        }
    }





}