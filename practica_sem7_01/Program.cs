using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_sem7_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n: ");
            int N = int.Parse(Console.ReadLine());
            float result = 0f;
            float suma = 0f;
            for (int i = 1; i <= N; i++)
            {
                result = (16f - i) / (3f * i);
                Console.WriteLine("resultado : " + result);
                suma += result;
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
