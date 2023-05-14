``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22000.1817/21H2/SunValley)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                     Method |          Mean |        Error |       StdDev | Allocated |
|--------------------------- |--------------:|-------------:|-------------:|----------:|
|    Threads_Size10_Threads1 |      86.61 μs |     1.249 μs |     1.169 μs |     304 B |
|    Threads_Size10_Threads2 |     159.04 μs |     3.098 μs |     4.029 μs |     544 B |
|    Threads_Size10_Threads4 |     277.61 μs |     2.360 μs |     2.092 μs |    1024 B |
|    Threads_Size10_Threads8 |     532.57 μs |     4.469 μs |     3.962 μs |    1985 B |
|   Threads_Size10_Threads16 |   1,030.11 μs |     4.333 μs |     4.053 μs |    3905 B |
|   Threads_Size100_Threads1 |     283.74 μs |     1.681 μs |     1.403 μs |     304 B |
|   Threads_Size100_Threads2 |     267.58 μs |     1.885 μs |     1.764 μs |     544 B |
|   Threads_Size100_Threads4 |     305.90 μs |     2.627 μs |     2.457 μs |    1024 B |
|   Threads_Size100_Threads8 |     561.56 μs |    10.276 μs |     8.581 μs |    1985 B |
|  Threads_Size100_Threads16 |   1,073.99 μs |    21.143 μs |    19.778 μs |    3905 B |
|  Threads_Size1000_Threads1 | 175,995.94 μs | 2,161.902 μs | 2,022.244 μs |    1984 B |
|  Threads_Size1000_Threads2 | 154,627.76 μs | 2,237.934 μs | 1,983.870 μs |    1458 B |
|  Threads_Size1000_Threads4 | 102,894.09 μs |   890.781 μs |   833.237 μs |    2029 B |
|  Threads_Size1000_Threads8 |  65,228.18 μs | 1,279.151 μs | 1,473.073 μs |    2064 B |
| Threads_Size1000_Threads16 |  48,837.61 μs |   971.335 μs | 1,228.428 μs |    3962 B |
