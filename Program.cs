using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programme_22._11._2021_Csharp__
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, N;
            bool h;
            string U;
            Console.WriteLine("Введите длину катета");
            U = Console.ReadLine();
            h = int.TryParse(U, out N);
            if (h)
            {
                N = Convert.ToInt32(U);
            }
            for (i = 1; i <= N; ++i)
            {
                if (i == 1) 
                {
                    k = N * 2 - 2;
                    for (j=1;j<=k;j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                else if (i ==N)
                {
                    for (j = 1; j <= N; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    k = (N * 2) - ((i - 1) * 2) - 2;
                    for (j=1;j<=k;j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    k = ((i - 1) * 2 - 1);
                    for (j = 1; j <= k; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
            }
            Console.ReadLine();
        }
    }
}
