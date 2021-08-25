``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.18363.1556 (1909/November2019Update/19H2)
AMD Ryzen 7 2700E, 1 CPU, 16 logical and 8 physical cores
.NET SDK=5.0.103
  [Host]     : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT
  DefaultJob : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT


```
|                        Method |     Mean |    Error |   StdDev |   Gen 0 | Allocated |
|------------------------------ |---------:|---------:|---------:|--------:|----------:|
|         FindConditionUsingFor | 41.03 μs | 0.374 μs | 0.312 μs | 12.6953 |     52 KB |
| FindConditionUsingListForeach | 45.12 μs | 0.886 μs | 1.212 μs | 12.8174 |     53 KB |
|     FindConditionUsingForeach | 49.38 μs | 0.392 μs | 0.347 μs | 12.8174 |     53 KB |
| FindConditionUsingListFindAll | 44.91 μs | 0.540 μs | 0.505 μs | 12.9395 |     53 KB |
|        FindConditionUsingLinq | 42.18 μs | 0.639 μs | 0.598 μs | 12.8174 |     53 KB |
