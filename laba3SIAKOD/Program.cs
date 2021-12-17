using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3SIAKOD
{
    class Program
    {
        
        static int Fibonachi(int n)
        {
            if (n<3)
            {
                return 1;
            }
            return Fibonachi(n-2)+ Fibonachi(n-1);
        }

        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("От какого числа начать поиск чисел фибоначи?");
            int ot = int.Parse(Console.ReadLine());
            Console.WriteLine("До какого числа продолжать поиск чисел фибоначи?");
            int N = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            for (int i = ot; i <= N; i++)
            {
                Console.WriteLine(Fibonachi(i) + $" index[{i+1-ot}]");
                list.Add(Fibonachi(i));
            }
            
            Console.Write("\nПод каким индексом вы хотите узнать число? \nIndex= ");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число под индексом {v} равно: " +list[v-1]);
            int k = 0;
            for (int i = 0; i < list.Count; i++)
            {
                k += 1;
            }
            Console.WriteLine("\nКоличество чисел фибоначи в указанном диапозоне равно: " + k);
        }
    }
}
