using System;
using System.Linq;

namespace Task2
{
    public static class BubbleSort
    {
        
        public static int[][] BubbleSortIncreaseSumElements(int[][] matrixInts)
        {
            var sizeRow = matrixInts.GetLength(0);
            var sum = new int[sizeRow];

            for (var i = 0; i < sizeRow; i++)
            {
                sum[i] = Sum(matrixInts[i]);
            }

            for (var i = 0; i < sizeRow - 1; i++)
            {
                for (var j = i; j < sizeRow; j++)
                {
                    if (sum[i] < sum[j])
                    {
                        ChangeArrayIndex(ref matrixInts, i, j);
                        ChangeInt(ref sum[i], ref sum[j]);
                    }
                }
            }

            return matrixInts;
        }

        public static int[][] BubbleSortDecreaseSumElements(int[][] matrixInts)
        {
            var sizeRow = matrixInts.GetLength(0);
            var sum = new int[sizeRow];

            for (var i = 0; i < sizeRow; i++)
            {
                sum[i] = Sum(matrixInts[i]);
            }

            for (var i = 0; i < sizeRow - 1; i++)
            {
                for (var j = i; j < sizeRow; j++)
                {
                    if (sum[i] > sum[j])
                    {
                        ChangeArrayIndex(ref matrixInts, i, j);
                        ChangeInt(ref sum[i], ref sum[j]);
                    }
                }
            }

            return matrixInts;
        }



        #region auxiliary function

        private static int Sum(int[] arrInts)
        {
            return arrInts.Sum();
        }

        private static int MaxVal(int[] arrInts)
        {
            var maxVal = arrInts[0];
            return arrInts.Concat(new[] {maxVal}).Max();
        }

        private static int MinVal(int[] arrInts)
        {
            var minVal = arrInts[0];
            return arrInts.Concat(new[] {minVal}).Min();
        }

        private static void ChangeInt(ref int a, ref int b)
        {
            var temp = b;
            b = a;
            a = temp;
        }

        private static void ChangeArrayIndex(ref int[][] matrixInts, int i, int j)
        {
            var boof = matrixInts[i];
            matrixInts[i] = matrixInts[j];
            matrixInts[j] = boof;
        }

        #endregion
    }
}