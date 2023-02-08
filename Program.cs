using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdenamientoBurbujeo
{
    class Program
    {
        static void Main (string[] args)
        {
            int i = 0;
            int k = 0;
            int CAN = 0;
            int AUX = 0;
            string linea;
            Console.WriteLine("Cuantos elementos MAX=12. ");
            linea = Console.ReadLine();
            CAN = int.Parse(linea);
            int[] VEC = new int [CAN + 1];

            for(i = 1; i <= CAN; i++)
            {
                Console.WriteLine("Posicion {0} ==> ", i);
                linea = Console.ReadLine();
                VEC[i] = int.Parse(linea);
            }

            for (i = 1; i <= CAN; i++)
            {
               for(k = i + 1; k <= CAN; k++)
               {
                if((VEC[i] < VEC[k] ))
                {
                    AUX = VEC[k];
                    VEC [k] = VEC [i];
                    VEC [i] = AUX;
                }
               }
            }
          
            Console.WriteLine();
            Console.WriteLine("Arreglo ordenado descendete ");
             for(i = 1; i <= CAN; i++)
            {
                Console.WriteLine(VEC[i]);
            }
            Console.WriteLine("Pulse una tecla.");
            Console.ReadLine();
        }
    }
}