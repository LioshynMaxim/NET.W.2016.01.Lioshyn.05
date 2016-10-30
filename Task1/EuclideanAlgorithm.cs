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

            return numbInts.Length;
        }
    }
}
