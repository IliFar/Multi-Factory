using System;
using System.Collections.Generic;

namespace multifabriken_ilifar
{
    abstract class Product
    {
        // For Cars
        protected string plateLetters;
        protected int plateNumbers;
        protected string brand;

        // For Strings
        protected float length;

        // For Candy
        protected string flavor;
        protected int quantity;

        // For Tofu
        protected float volume;
        protected string spices;

        // In Common 
        protected string color;


        public abstract string orderComplete();
        public abstract string ordered();
    }
}