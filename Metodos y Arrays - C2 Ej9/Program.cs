using System;

namespace Metodos_y_Arrays___C2_Ej9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarray = new int[10];

            for (int i = 0; i < miarray.Length; i++)
            {
                
                Console.WriteLine("Escribe el valor a introducir en la posición {0}",i);
                miarray[i] = Convert.ToInt32(Console.ReadLine()) ;
            }
            for (int i = 0; i < miarray.Length; i++)
            {
                Console.WriteLine(miarray[i]);
            }
        }
    }
}
