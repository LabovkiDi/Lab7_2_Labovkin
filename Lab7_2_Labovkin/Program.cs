using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра a = {0} см");
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            Cube(a, out S, out V);
            Console.WriteLine("Площадь куба равна S ={0} кв.см",S);
            Console.WriteLine("Объем куба равен V = {0} куб.см",V);
            Console.ReadKey();
        }
        static void Cube(int a, out double S, out double V)
        {
            V = 6 * a * a;
            S = a * a * a;
        }
    }
}
