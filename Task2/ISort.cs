namespace Task2
{
    public interface ISort
    {
        /// <summary>
        /// Interface for realization bubble sort
        /// </summary>
        /// <param name="firstInts">First int number</param>
        /// <param name="secondInts">Second int number</param>
        /// <returns>The boolean value of compare first and second numbers</returns>
        bool SortSum(int firstInts, int secondInts);
        bool SortMax(int firstInts, int secondInts);
        bool SortMin(int firstInts, int secondInts);
    }

   
}