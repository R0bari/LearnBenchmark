``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.18363.1556 (1909/November2019Update/19H2)
AMD Ryzen 7 2700E, 1 CPU, 16 logical and 8 physical cores
.NET SDK=5.0.103
  [Host]     : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT
  DefaultJob : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT


```
|             Method |       Mean |     Error |    StdDev |     Median |  Gen 0 | Allocated |
|------------------- |-----------:|----------:|----------:|-----------:|-------:|----------:|
| NativeEnumToString | 50.7915 ns | 0.4882 ns | 0.4328 ns | 50.7429 ns | 0.0057 |      24 B |
|   FastEnumToString |  0.0742 ns | 0.0388 ns | 0.0344 ns |  0.0522 ns |      - |         - |
