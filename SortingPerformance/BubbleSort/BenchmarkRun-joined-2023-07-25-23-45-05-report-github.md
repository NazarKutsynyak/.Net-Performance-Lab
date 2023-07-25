```

BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.3208/22H2/2022Update)
Intel Core i5-3320M CPU 2.60GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET SDK 7.0.302
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX


```
|          Type |                Method |  count |        Mean |     Error |    StdDev |      Median |
|-------------- |---------------------- |------- |------------:|----------:|----------:|------------:|
| **GeeksForGeeks** |            **BubbleSort** |  **10000** |    **12.91 μs** |  **0.132 μs** |  **0.117 μs** |    **12.89 μs** |
|  MykytaPavlov |             SortArray |  10000 |    12.51 μs |  0.140 μs |  0.117 μs |    12.57 μs |
|  MykytaPavlov | SortArrayTryOptimise1 |  10000 |    12.52 μs |  0.125 μs |  0.117 μs |    12.57 μs |
|  MykytaPavlov | SortArrayTryOptimise2 |  10000 |    12.51 μs |  0.115 μs |  0.102 μs |    12.52 μs |
|  MykytaPavlov | SortArrayTryOptimise3 |  10000 |    12.50 μs |  0.120 μs |  0.112 μs |    12.48 μs |
|  MykytaPavlov | SortArrayTryOptimise4 |  10000 |    12.48 μs |  0.146 μs |  0.137 μs |    12.43 μs |
|  MykytaPavlov | SortArrayTryOptimise5 |  10000 |    15.59 μs |  0.200 μs |  0.177 μs |    15.59 μs |
|  MykytaPavlov | SortArrayTryOptimise6 |  10000 |    12.49 μs |  0.133 μs |  0.125 μs |    12.48 μs |
|  MykytaPavlov |            Array_Sort |  10000 |   114.41 μs |  1.088 μs |  0.965 μs |   114.68 μs |
| **GeeksForGeeks** |            **BubbleSort** | **100000** |   **158.85 μs** |  **8.916 μs** | **25.002 μs** |   **147.70 μs** |
|  MykytaPavlov |             SortArray | 100000 |   170.55 μs | 10.512 μs | 30.330 μs |   155.95 μs |
|  MykytaPavlov | SortArrayTryOptimise1 | 100000 |   163.38 μs |  8.988 μs | 25.496 μs |   153.00 μs |
|  MykytaPavlov | SortArrayTryOptimise2 | 100000 |   154.98 μs |  5.584 μs | 15.381 μs |   148.75 μs |
|  MykytaPavlov | SortArrayTryOptimise3 | 100000 |   169.68 μs | 11.302 μs | 32.609 μs |   151.45 μs |
|  MykytaPavlov | SortArrayTryOptimise4 | 100000 |   133.79 μs |  4.609 μs | 12.303 μs |   126.66 μs |
|  MykytaPavlov | SortArrayTryOptimise5 | 100000 |   190.00 μs |  7.004 μs | 19.868 μs |   181.40 μs |
|  MykytaPavlov | SortArrayTryOptimise6 | 100000 |   129.16 μs |  3.684 μs |  9.641 μs |   126.06 μs |
|  MykytaPavlov |            Array_Sort | 100000 | 1,375.80 μs | 13.502 μs | 12.630 μs | 1,379.03 μs |
