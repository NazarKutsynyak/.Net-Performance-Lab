using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace BubbleSort
{
    public class MykytaPavlov
    {
        private int[] arr;

        [Params(10000, 100000)]
        //[Params(5000, 10000)]
        public int count;

        [GlobalSetup]
        public void Setup()
        {
            Random random = new Random();
            arr = new int[count];
            for (int i = 0; i < count; ++i)
                arr[i] = random.Next(1, count * 5) % count;
        }

        /// <summary>
        /// BubbleSort
        /// https://github.com/mykyta-pavlov/bubble/blob/master/Program.cs
        /// </summary>
        /// <param name="arr"></param>
        [Benchmark]
        public void SortArray()
        {
            bool swapped;
            
            do
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped == true);
        }

        [Benchmark]
        public void SortArrayTryOptimise1()
        {
            bool swapped;
            int i;

            do
            {
                swapped = false;
                for (i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped == true);
        }

        [Benchmark]
        public void SortArrayTryOptimise2()
        {
            bool swapped;
            int i;
            int swapedCount = 0;
            int elementCount = arr.Length - 1;

            do
            {
                swapped = false;
                for (i = 0; i < elementCount - swapedCount; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
                swapedCount++;

            } while (swapped == true);
        }

        [Benchmark]
        public void SortArrayTryOptimise3()
        {
            bool swapped;
            int i, swapedCount = 0, temp, elementCount = arr.Length - 1;

            do
            {
                swapped = false;
                for (i = 0; i < elementCount - swapedCount; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
                swapedCount++;

            } while (swapped == true);
        }

        [Benchmark]
        public void SortArrayTryOptimise4()
        {
            bool swapped;
            int i = 0, swapedCount = 0, temp, elementCount = arr.Length - 1;

            do
            {
                swapped = false;
                while (i < elementCount - swapedCount)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                    i++;
                }
                swapedCount++;

            } while (swapped == true);
        }

        [Benchmark]
        public void SortArrayTryOptimise5()
        {
            bool swapped;
            int i = 0, swapedCount = 0, temp, elementCount = arr.Length - 1;

        OuterLoop:
            swapped = false;
            i = 0;
        InnerLoopStart:
            if (i >= elementCount - swapedCount)
                goto InnerLoopEnd;

            if (arr[i] > arr[i + 1])
            {
                temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                swapped = true;
            }
            i++;
            goto InnerLoopStart;
        InnerLoopEnd:
            swapedCount++;
            if (swapped == true)
                goto OuterLoop;
        }

        // based on SortArrayTryOptimise2 and SortArrayTryOptimise4
        [Benchmark]
        public void SortArrayTryOptimise6()
        {
            bool swapped;
            int i = 0, swapedCount = 0, elementCount = arr.Length - 1;

            do
            {
                swapped = false;
                while (i < elementCount - swapedCount)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                    i++;
                }
                swapedCount++;

            } while (swapped == true);
        }

        [Benchmark]
        public void Array_Sort()
        {
            Array.Sort(arr);
        }

        public void PrintArray()
        {
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
