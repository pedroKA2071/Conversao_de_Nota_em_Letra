using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace att5_dia2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            float nota, letra;



            Console.WriteLine("qual foi sua nota de 0 - 10: ");
            nota = float.Parse(Console.ReadLine());









            if (nota == 0)
            {
                Console.WriteLine("F");
            }
            else if (nota >= 1 && nota <= 4)
            {
                Console.WriteLine("D");
            }
            else if (nota >= 5 && nota <= 7)
            {
                Console.WriteLine("C");
            }
            else if (nota >= 8 && nota <= 9)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("A");
            }







            Console.ReadKey();
        }
    }
}