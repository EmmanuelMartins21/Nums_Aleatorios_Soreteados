using System;
using System.Collections.Generic;

namespace Nums_Aleatorios_Soreteados
{
    class Program
    {
        public static void Main(string[] args)
        {
            string repetir = "n";
            Random rn = new Random();
            string mudaSorteio = "n";

            List<int> vtrSorteio = new List<int>();

            do
            {
                vtrSorteio.Clear(); // Limpando a lista
                Console.WriteLine("\nQuantos numeros deseja sortear?");
                string[] line = Console.ReadLine().Split(" ");
                int numDesejados = Int32.Parse(line[0]);

                // Preechendo a Lista de numeros sorteados
                for (int i = 0; i < numDesejados; i++)
                {
                    vtrSorteio.Add(rn.Next(1, 25));
                }

                vtrSorteio.Sort(); // Ordenando a Lista
                Console.WriteLine("\nValores do sorteio: ");

                // Imprimindo a Lista obtida
                foreach (int lista in vtrSorteio)
                {
                    Console.WriteLine(lista);
                }

                Console.WriteLine("\nDeseja sortear novamente ? Digite: s - Sim / n - Não");
                repetir = Console.ReadLine();
                if (repetir == "s")
                {
                    Console.WriteLine("\nDeseja mudar a quantidade de valores sorteados? Digite: s - Sim / n - Não");
                    mudaSorteio = Console.ReadLine();
                }
                if (mudaSorteio == "s")
                {
                    numDesejados = Int32.Parse(line[0]);
                }

            } while (repetir == "s");
        }
    }
}
