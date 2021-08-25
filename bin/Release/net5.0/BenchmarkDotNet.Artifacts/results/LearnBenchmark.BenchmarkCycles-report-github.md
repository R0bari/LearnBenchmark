``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.18363.1556 (1909/November2019Update/19H2)
AMD Ryzen 7 2700E, 1 CPU, 16 logical and 8 physical cores
.NET SDK=5.0.103
  [Host]     : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT
  DefaultJob : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT


```
|           Method |      Mean |     Error |    StdDev | Allocated |
|----------------- |----------:|----------:|----------:|----------:|
|       SumWithFor |  72.34 μs |  1.438 μs |  3.304 μs |         - |
|   SumWithForeach | 148.13 μs |  2.023 μs |  1.793 μs |         - |
|   SumWithLINQSum | 509.46 μs |  9.371 μs | 15.913 μs |      40 B |
| SumWithAggregate | 571.99 μs | 11.104 μs | 11.403 μs |      40 B |
