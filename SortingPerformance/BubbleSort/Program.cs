// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Running;
using BubbleSort;

var config = ManualConfig.Create(DefaultConfig.Instance)
         .WithOptions(ConfigOptions.JoinSummary)
         .WithOptions(ConfigOptions.DisableLogFile);

BenchmarkRunner.Run(new[]{
            BenchmarkConverter.TypeToBenchmarks( typeof(GeeksForGeeks), config),
            BenchmarkConverter.TypeToBenchmarks( typeof(MykytaPavlov), config)
            });

//Console.ReadLine();


//int count = 10;
//int itteration = 100000;
//int warmupItteration = 100;

//Random random = new Random();
//int[] values = new int[count];

//for (int i = 0; i < count; ++i)
//    values[i] = random.Next(1, count * 5) % count;

//Stopwatch stopwatch = new Stopwatch();

//GeeksForGeeks geeksForGeeks = new GeeksForGeeks(count);




//MykytaPavlov mykytaPavlov = new MykytaPavlov();
//mykytaPavlov.count = count;
//mykytaPavlov.Setup();
//mykytaPavlov.SortArrayTryOptimise2();
//mykytaPavlov.PrintArray();



//List<long> mykytaPavlovTimes = new List<long>(itteration);
//List<long> geeksForGeeksTimeList = new List<long>(itteration);
//List<long> optimise1SortTimes = new List<long>(itteration);


////for (int i = 0; i < 100; i++)
////    sort1.Sort(values);

////for (int i = 0; i < itteration; i++)
////{

//for(int i = 0; i < warmupItteration; i++)
//    GeeksForGeeks(true);

//for (int i = 0; i < itteration; i++)
//    GeeksForGeeks();


//for (int i = 0; i < warmupItteration; i++)
//    MykytaPavlovSort(mykytaPavlovTimes, true);

//for (int i = 0; i < itteration; i++)
//    MykytaPavlovSort(mykytaPavlovTimes);


//for (int i = 0; i < warmupItteration; i++)
//    MykytaPavlovSort(optimise1SortTimes, true);

//for (int i = 0; i < itteration; i++)
//    MykytaPavlovSort(optimise1SortTimes);

////for (int i = 0; i < warmupItteration; i++)
////MykytaPavlovOptimised1(true);

////for (int i = 0; i < itteration; i++)
////    MykytaPavlovOptimised1();
////}

//Console.WriteLine($"\nSort.BubbleSort() elapsed milliseconds average: {geeksForGeeksTimeList.Average()}");
//Console.WriteLine($"\nmykytaPavlovTimes.Sort() elapsed milliseconds average: {mykytaPavlovTimes.Average()}");
//Console.WriteLine($"\nmykytaPavlovTimes.OptimisedSort() elapsed milliseconds average: {optimise1SortTimes.Average()}");

Console.WriteLine("Press Enter to exit");
Console.Read();

//void RestartTimer()
//{
//    stopwatch.Reset();
//    stopwatch.Start();
//}

//void GeeksForGeeks(bool warmup = false)
//{
//    RestartTimer();
//    geeksForGeeks.BubbleSort(values);
//    stopwatch.Stop();
//    if (!warmup)
//        geeksForGeeksTimeList.Add(stopwatch.ElapsedMilliseconds);
//}

//void MykytaPavlovSort(List<long> times, bool warmUp = false)
//{
//    RestartTimer();
//    mykytaPavlov.SortArray(values);
//    stopwatch.Stop();
//    if (!warmUp)
//        times.Add(stopwatch.ElapsedMilliseconds);
//}

//void MykytaPavlovOptimised1(bool warmUp = false)
//{
//    RestartTimer();
//    mykytaPavlov.SortArrayTryOptimise1(values);
//    stopwatch.Stop();
//    optimise1SortTimes.Add(stopwatch.ElapsedMilliseconds);
//}