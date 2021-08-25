using BenchmarkDotNet.Attributes;

namespace LearnBenchmark
{
    [MemoryDiagnoser]
    public class BenchmarkEnumToString
    {
        [Benchmark]
        public string NativeEnumToString()
        {
            return DaysOfWeek.Monday.ToString();
        }

        [Benchmark]
        public string FastEnumToString()
        {
            return nameof(DaysOfWeek.Monday);
        }
    }
    
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}