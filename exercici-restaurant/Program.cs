using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b5 = 5, b10 = 10, b20 = 20, b50 = 50, b100 = 100, b200 = 200, b500 = 500;
            double total = 0;
            string[] menu = { "pizza", "hamburguesa", "entrecot", "spaguetti", "dorada", "sepia" };
            int[] precio = { 8, 10, 15, 8, 18, 20 };

            Dictionary<string, int> plato = new Dictionary<string, int>();
            for (int i = 0; i < menu.Length; i++)
            {
                plato.Add(menu[i], precio[i]);
            }

            Dictionary<string, int> dict = new Dictionary<string, int>(plato);
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine("Plato : {0}, Precio: {1} euros",
                   kvp.Key, kvp.Value);
            }

            Console.WriteLine("Que desea para comer?");


            ArrayList pedidoAL = new ArrayList();
            bool v = false;
            do
            {
                string introducirPedido = Console.ReadLine().ToLower();

                if (menu.Contains(introducirPedido))
                {
                    pedidoAL.Add(introducirPedido);

                    if (dict.ContainsKey(introducirPedido))
                    {
                        foreach (KeyValuePair<string, int> kvp in dict)
                        {
                            total = total + kvp.Value;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("{0} producto inexistente", introducirPedido);
                }

                Console.WriteLine("Desea algo mas? \n[Seleccione 1 si su respuesta es SI] [Seleccione 0 si su respuesta es NO]");
                int algoMas = Convert.ToInt32(Console.ReadLine());

                if (algoMas == 1)
                {
                    Console.WriteLine("Va a pedir algo mas?");
                }
                else
                {
                    Console.WriteLine("Cuenta");
                    foreach (string x in pedidoAL)
                    {
                        Console.WriteLine(x);

                    }
                    Console.WriteLine("El total de su comida es {0}", total);
                    v = true;
                }

            } while (!v);
        }

    }
}