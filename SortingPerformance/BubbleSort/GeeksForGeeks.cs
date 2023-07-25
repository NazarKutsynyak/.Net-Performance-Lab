using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace BubbleSort
{
    public class GeeksForGeeks
    {
        private int[] arr;

        [Params(10000, 100000)]
        //[Params(5000, 10000)]
        public int count;

        //public GeeksForGeeks(int count)
        //{
        //    arr = new int[count];
        //}

        [GlobalSetup]
        public void Setup() 
        {
            Random random = new Random();
            arr = new int[count];
            for (int i = 0; i < count; ++i)
                arr[i] = random.Next(1, count * 5) % count;
        }

        /// <summary>
        /// GeeksForGeeks implementation
        /// https://www.geeksforgeeks.org/bubble-sort/
        /// </summary>
        /// <param name="array"></param>
        [Benchmark]
        public void BubbleSort(/*int[] array*/)
        {
            //Array.Clear(arr);
            //Array.Copy(array, arr, array.Length);
            int i, j, temp;
            bool swapped;
            for (i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;
                for (j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        // Swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
        }
    }
}
