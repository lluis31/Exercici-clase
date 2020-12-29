using System;
using System.Collections.Generic;

namespace exercici_restaurant
{
    class Program
    {
        public int Plats { get; set; }
        public int Preu { get; set; }
        
            static void Main(string[] args)
        {
            //fase1
            int bill5= 5, bill10= 10, bill20= 20, bill50= 50, bill100= 100, bill200 = 200, bill500 = 500;
            int preutotal;

            Console.WriteLine("Quants plats vol que tingui en menu");
            int numplats = Convert.ToInt32(Console.ReadLine());

            string[] menu = new string[numplats];
            int[] preus = new int[numplats];

            //fase 2
            for (int i = 0; i < numplats; i++)

            {

                Console.WriteLine("Introdueix el nom del plat {0}:", i + 1);

                menu[i] = Console.ReadLine();

                Console.WriteLine("Introdueix el preu del plat {0} ({1}):", i + 1, menu[i]);

                preus[i] = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("---EXERCICI RESTAURANT---");

                Console.WriteLine("");

            }

            Dictionary<string, int> openWith = new Dictionary<string, int>();

            for (int i = 0; i < numplats; i++)

            {

                openWith.Add(menu[i], preus[i]);

            }

            Console.Clear();

        }
    }
}
