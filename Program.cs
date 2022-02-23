using System;

namespace NumberSumElArray
{
    /// <summary>
    /// Smallest number that can not be formed from sum of numbers from array
    /// Input array is already sorted
    /// </summary>
    internal class Program
    {
        static int[] ConvFromStrToIntArr(string[] strArr)
        {
            var intArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
                intArr[i] = Convert.ToInt32(strArr[i]);
            return intArr;
        }

        static int GetSmNum(int[] array)
        {
            var cand = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > cand)
                    return cand;
                cand += array[i];
            }
            return cand;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input array:");
            var inStr = Console.ReadLine().Split(' ');
            var inNum = ConvFromStrToIntArr(inStr);
            Console.WriteLine("Result {0}:", GetSmNum(inNum));
        }
    }
}
