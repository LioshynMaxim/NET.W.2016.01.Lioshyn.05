using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class EuclideanAlgorithm
    {

        public static int GreatestCommonSivisor(int a, int b)
        {
            return b != 0?GreatestCommonSivisor(b, a % b):a;
        }

        public static int GreatestCommonSivisor(params int[] numbInts)
        {
            int boof = GreatestCommonSivisor(numbInts[0], numbInts[1]);
            for (int i = 2; i <= numbInts.Length - 1; i ++)
            {
                boof = GreatestCommonSivisor(boof, numbInts[i]);
            }
            return  boof;
        }
    }
}
