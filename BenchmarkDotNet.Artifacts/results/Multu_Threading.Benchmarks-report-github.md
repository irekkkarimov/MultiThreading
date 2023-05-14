``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22000.1817/21H2/SunValley)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                                      Method |             Mean |           Error |          StdDev |   Gen0 | Allocated |
|-------------------------------------------- |-----------------:|----------------:|----------------:|-------:|----------:|
|        BenchmarkParallelFor_Size10_Threads1 |         679.5 ns |        12.32 ns |        10.92 ns | 0.1831 |    1.5 KB |
|      BenchmarkParallelFor10_Size10_Threads2 |       1,359.1 ns |        11.20 ns |        10.47 ns | 0.2022 |   1.65 KB |
|      BenchmarkParallelFor10_Size10_Threads4 |       2,199.2 ns |        42.23 ns |        39.50 ns | 0.2518 |   2.05 KB |
|      BenchmarkParallelFor10_Size10_Threads8 |       2,798.0 ns |        31.56 ns |        29.52 ns | 0.2975 |   2.44 KB |
|     BenchmarkParallelFor10_Size10_Threads16 |       2,865.4 ns |        49.56 ns |        46.36 ns | 0.2975 |   2.43 KB |
|    BenchmarkParallelFor100_Size100_Threads1 |     193,861.8 ns |     2,394.20 ns |     2,239.54 ns |      - |    1.5 KB |
|    BenchmarkParallelFor100_Size100_Threads2 |     122,413.1 ns |     1,096.02 ns |       915.23 ns |      - |   1.65 KB |
|    BenchmarkParallelFor100_Size100_Threads4 |     113,145.1 ns |       195.18 ns |       162.99 ns | 0.2441 |   2.13 KB |
|    BenchmarkParallelFor100_Size100_Threads8 |      93,256.0 ns |       619.40 ns |       579.39 ns | 0.3662 |   2.97 KB |
|   BenchmarkParallelFor100_Size100_Threads16 |      85,306.8 ns |       393.77 ns |       368.33 ns | 0.4883 |   4.56 KB |
|  BenchmarkParallelFor1000_Size1000_Threads1 | 171,848,224.4 ns | 2,416,588.66 ns | 2,260,478.53 ns |      - |   3.15 KB |
|  BenchmarkParallelFor1000_Size1000_Threads2 |  90,610,745.2 ns |   605,623.95 ns |   536,869.86 ns |      - |   2.52 KB |
|  BenchmarkParallelFor1000_Size1000_Threads4 |  49,659,829.7 ns |   454,573.25 ns |   425,208.10 ns |      - |   2.36 KB |
|  BenchmarkParallelFor1000_Size1000_Threads8 |  32,583,726.6 ns |   628,349.89 ns |   880,858.79 ns |      - |   3.03 KB |
| BenchmarkParallelFor1000_Size1000_Threads16 |  29,843,701.0 ns |   550,211.51 ns |   715,430.37 ns |      - |    4.7 KB |
