using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class BubbleSort : ISort
    {
        #region Sum Elements

        /// <summary>
        /// Sort by sum amount of bubble elements. 
        /// </summary>
        /// <param name="matrixInts">Integer matrix elements</param>
        /// <param name="sort">Interface realization</param>
        /// <param name="flag">Sorting direction</param>
        public static void BubbleSortSumElements(ref int[][] matrixInts, ISort sort, bool flag)
        {

            if (ReferenceEquals(matrixInts, null) || ReferenceEquals(sort, null))
                throw new ArgumentNullException();

            var sizeRow = matrixInts.GetLength(0);
            int[] sumInts = SumArrayLine(matrixInts, sizeRow);

            for (var i = 0; i < sizeRow - 1; i++)
            {
                for (var j = i; j < matrixInts.Length; j++)
                {
                    if (flag)
                    {
                        if (sort.SortSum(sumInts[i], sumInts[j])) continue;
                    }
                    else
                    {
                        if (!(sort.SortSum(sumInts[i], sumInts[j]))) continue;
                    }

                    ChangeArrayIndex(ref matrixInts, i, j);
                    Swap(ref sumInts[i], ref sumInts[j]);
                }
            }
        }

        #endregion

        #region Max Element

        /// <summary>
        /// Sort by max amount of bubble elements. 
        /// </summary>
        /// <param name="matrixInts">Integer matrix elements</param>
        /// <param name="sort">Interface realization</param>
        /// <param name="flag">Sorting direction</param>

        public static void BubbleSortMaxElements(ref int[][] matrixInts, ISort sort, bool flag)
        {

            if (ReferenceEquals(matrixInts, null) || ReferenceEquals(sort, null))
                throw new ArgumentNullException();

            var sizeRow = matrixInts.GetLength(0);
            int[] maxInts = MaxVal(matrixInts, sizeRow);

            for (var i = 0; i < sizeRow; i++)
            {
                for (var j = i; j < matrixInts.Length; j++)
                {
                    if (flag)
                    {
                        if (sort.SortMax(maxInts[i], maxInts[j])) continue;
                    }
                    else
                    {
                        if (!(sort.SortMax(maxInts[i], maxInts[j]))) continue;
                    }

                    ChangeArrayIndex(ref matrixInts, i, j);
                    Swap(ref maxInts[i], ref maxInts[j]);
                }
            }
        }

        #endregion

        #region Min Element

        /// <summary>
        /// Sort by min amount of bubble elements. 
        /// </summary>
        /// <param name="matrixInts">Integer matrix elements</param>
        /// <param name="sort">Interface realization</param>
        /// <param name="flag">Sorting direction</param>

        public static void BubbleSortMinElements(ref int[][] matrixInts, ISort sort, bool flag)
        {

            if (ReferenceEquals(matrixInts, null) || ReferenceEquals(sort, null))
                throw new ArgumentNullException();

            var sizeRow = matrixInts.GetLength(0);
            int[] minInts = MinVal(matrixInts, sizeRow);

            for (var i = 0; i < sizeRow; i++)
            {
                for (var j = i; j < matrixInts.Length; j++)
                {
                    if (flag)
                    {
                        if (sort.SortMin(minInts[i], minInts[j])) continue;
                    }
                    else
                    {
                        if (!sort.SortMin(minInts[i], minInts[j])) continue;
                    }

                    ChangeArrayIndex(ref matrixInts, i, j);
                    Swap(ref minInts[i], ref minInts[j]);
                }
            }
        }

        #endregion

        #region auxiliary function

        /// <summary>
        /// Calculate sum of the sz-array.
        /// </summary>
        /// <param name="arrInts">Array of integer.</param>
        /// <param name="size">Size of array.</param>
        /// <returns>Array sum of the sz-array.</returns>

        private static int[] SumArrayLine(IReadOnlyList<int[]> arrInts, int size)
        {
            var sum = new int[size];
            for (var i = 0; i < size; i++)
            {
                sum[i] = arrInts[i].Sum();
            }
            return sum;
        }

        /// <summary>
        /// Search maximal element of the sz-array.
        /// </summary>
        /// <param name="arrInts">Array of integer.</param>
        /// <param name="size">Size of array.</param>
        /// <returns>Array max elements of the sz-array.</returns>

        private static int[] MaxVal(IReadOnlyList<int[]> arrInts, int size)
        {
            var maxVal = new int[size];
            int max = 0;
            for (int i = 0; i < size; i++)
            {
                max = arrInts[i][0];
                for (int j = 1; j < arrInts[i].Length; j++)
                {
                    if (max < arrInts[i][j])
                    {
                        max = arrInts[i][j];
                    }
                }
                maxVal[i] = max;
            }
            return maxVal;
        }

        /// <summary>
        /// Search minimal element of the sz-array.
        /// </summary>
        /// <param name="arrInts">Array of integer.</param>
        /// <param name="size">Size of array.</param>
        /// <returns>Array min elements of the sz-array.</returns>

        public static int[] MinVal(IReadOnlyList<int[]> arrInts, int size)
        {
            var minVal = new int[size];
            int min = 0;
            
            for (int i = 0; i < size; i++)
            {
                min = arrInts[i][0];
                for (int j = 1; j < arrInts[i].Length; j++)
                {
                    if (min > arrInts[i][j])
                    {
                        min = arrInts[i][j];
                    }
                }
                minVal[i] = min;
            }
            return minVal;
        }

        /// <summary>
        /// Change settings
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>

        private static void Swap(ref int a, ref int b)
        {
            var temp = b;
            b = a;
            a = temp;
        }

        /// <summary>
        /// Change index array
        /// </summary>
        /// <param name="matrixInts">Matrix</param>
        /// <param name="i">First index</param>
        /// <param name="j">Second index</param>

        private static void ChangeArrayIndex(ref int[][] matrixInts, int i, int j)
        {
            var boof = matrixInts[i];
            matrixInts[i] = matrixInts[j];
            matrixInts[j] = boof;
        }

        #endregion

        /// <summary>
        /// The implementation of the interface sum.
        /// </summary>
        /// <param name="firstInts">First int number</param>
        /// <param name="secondInts">Second int number</param>
        /// <returns>The boolean value of compare first and second numbers</returns>

        public bool SortSum(int firstInts, int secondInts)
        {
            return firstInts > secondInts;
        }

        /// <summary>
        /// The implementation of the interface max.
        /// </summary>
        /// <param name="firstInts">First int number</param>
        /// <param name="secondInts">Second int number</param>
        /// <returns>The boolean value of compare first and second numbers</returns>

        public bool SortMax(int firstInts, int secondInts)
        {
            return firstInts > secondInts;
        }

        /// <summary>
        /// The implementation of the interface min.
        /// </summary>
        /// <param name="firstInts">First int number</param>
        /// <param name="secondInts">Second int number</param>
        /// <returns>The boolean value of compare first and second numbers</returns>

        public bool SortMin(int firstInts, int secondInts)
        {
            return firstInts < secondInts;
        }
    }
}