using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace multifabriken_ilifar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Product List.
            List<Product> productsCollection = new List<Product>();

            while (true)
            {
                // Introuction
                Console.WriteLine("INTRODUCTION\n");
                Console.WriteLine("Here you can choose the products we are offering and make your order.");
                Console.WriteLine("To choose a product to order, type in the number of the corresponding product in the menu and press ENTER \n");

                // Array for the products options
                string[] productsOption = { "[1] Cars", "[2] Candy", "[3] Strings", "[4] Tofu", "[5] See What You ordered", "[6] Exit" };

                // Looping through array to display menu options
                for (int i = 0; i < productsOption.Length; i++)
                {
                    Console.WriteLine(productsOption[i]);
                }

                // Exception HandelingTry the code below
                try
                {
                    // Capture user input for products options
                    Console.Write("Write here : ");
                    int choosenMenu = Convert.ToInt32(Console.ReadLine());

                    // Switch menu products options
                    switch (choosenMenu)
                    {
                        // For Car
                        case 1:
                            Car carOrdered = new Car();
                            productsCollection.Add(carOrdered);
                            Console.WriteLine(carOrdered.orderComplete());
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        // For Candy
                        case 2:
                            Candy candyOrdered = new Candy();
                            productsCollection.Add(candyOrdered);
                            Console.WriteLine(candyOrdered.orderComplete());
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        // For Strings
                        case 3:
                            Strings stringsOrdered = new Strings();
                            productsCollection.Add(stringsOrdered);
                            Console.WriteLine(stringsOrdered.orderComplete());
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        // For Tofu
                        case 4:
                            Tofu tofuOrdered = new Tofu();
                            productsCollection.Add(tofuOrdered);
                            Console.WriteLine(tofuOrdered.orderComplete());
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        // To display ordered products
                        case 5:
                            Console.Clear();
                            var count = productsCollection.Count();
                            // Check if count is less than or bigger than 0
                            if (count > 0)
                            {
                                foreach (Product product in productsCollection)
                                {   
                                    // Loop through product list and call the ordered method on each product ordered.
                                    Console.WriteLine(product.ordered());
                                    Console.WriteLine();
                                }
                                Console.ReadLine();
                                Console.Clear();
                            }
                            if (count == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Your order list is empty.\n\nPress ENTER To Go Back : ");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            break;
                        default:
                            return;
                    }
                }
                // Catch this error if the there is a problem in the above code
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Please write the appropriate letter or number\n\nBack to menu in 4 seconds.");
                    Thread.Sleep(4000);
                    Console.Clear();
                }
            }
        }
    }
}
