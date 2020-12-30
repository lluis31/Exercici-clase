using System;

namespace exercici_M1
{
    class Program
    {
        static void Main(string[] args)
        {
            //milestone1-fase1
            string nom = "Lluis";
            string cognom = "Planas";
            string cognom2 = "Mastel";

            int dia = 31;
            int mes = 07;
            int any = 1997;

            Console.WriteLine(nom + cognom + cognom2);
            Console.WriteLine(dia + "/" + mes + "/" + any);

            //fase2
            const int bbb = 1948;
            int temps = 4;
            int cantitat = (any - bbb) / 4;

            Console.WriteLine("Fins el meu naixement hi ha {0} anys de traspas", cantitat);

            //fase3
            string si = "El meu any de naixement es un any de traspas";
            string no = "El meu any de naixement no es any de traspas";
            for (int i = 1; i <= cantitat; i++)
            {
                Console.WriteLine("Any de traspas: {0}", bbb + (4 * i));
            }
            bool any_traspas;
            if (any % temps ==0)
            {
                Console.WriteLine(si);
                any_traspas = true;
                
            }
            else
            {
                Console.WriteLine(no);
                any_traspas = false;
            }

            //fase4
            string nom_complet = nom + cognom + cognom2;
            string data = dia + "/" + mes + "/" + any;

            Console.WriteLine(nom_complet);
            Console.WriteLine(data);
            Console.WriteLine(no);

            //Milestone2
            double num = 0.5362;
            int x;
            float y;
            string e;

            x = Convert.ToInt32(num);
            y = (float)num;
            e = Convert.ToString(num);

            Console.WriteLine(x + y + e);

            //Milestone3
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int aux;
            for (int i = 0; i<10; i++)
            {
                aux = numeros[i];
                numeros[i] = numeros[9 - i];
                numeros[9 - i] = aux;
                if (i==4) { goto exit; }
            }
        exit:
            Console.WriteLine(string.Join("", numeros));
        }
    }
}
