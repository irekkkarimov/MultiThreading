``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22000.1817/21H2/SunValley)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2


```
|                          Method |      Mean |     Error |    StdDev |      Gen0 |     Gen1 |     Gen2 | Allocated |
|-------------------------------- |----------:|----------:|----------:|----------:|---------:|---------:|----------:|
| ConcatStringsUsingStringBuilder |  4.664 ms | 0.0931 ms | 0.2102 ms | 1453.1250 | 992.1875 | 992.1875 |  14.86 MB |
|   ConcatStringsUsingGenericList | 11.357 ms | 0.1751 ms | 0.2338 ms | 1218.7500 | 562.5000 | 234.3750 |   9.16 MB |
