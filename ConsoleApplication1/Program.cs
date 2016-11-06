using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;
using static Task2.BubbleSort;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[][] arraOldInts = new[]
            {
                new []{6, -5, 3, 10},
                new []{1, 2, 1, 1},
                new []{0, 2, 30, 0},
                new []{0, 2, 29, -1}
            };

            BubbleSortMaxElements(ref arraOldInts, new BubbleSort(), true);

            for (int i = 0; i < arraOldInts.GetLength(0); i++)
            {
                foreach (int j in arraOldInts[i])
                {
                   Console.Write(j.ToString() + " ");
                }
               Console.WriteLine();
            }

            Console.ReadKey();
        }

       
    }
}
