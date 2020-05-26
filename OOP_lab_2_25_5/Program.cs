using System;

namespace OOP_lab_2_25_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] a = new int[n, m];

            var rnd = new Random();

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    a[i, j] = rnd.Next(-100, 100);
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("{0, -6} ", a[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < n; ++i)
            {
                bool isPositive = false;
                int d = 1;                

                for (int j = 0; j < m; ++j)
                {
                    if (a[i, j] > 0)
                    {
                        isPositive = true;

                        d *= a[i, j];
                    }
                }

                if (isPositive)
                {
                    Console.WriteLine(d);
                }
            }
        }
    }
}
