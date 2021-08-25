using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace LearnBenchmark
{
    [MemoryDiagnoser]
    public class BenchmarkCycles
    {
        private readonly List<int> numbers = Enumerable.Range(1, 60_000).ToList();
        
        [Benchmark]
        public int SumWithFor()
        {
            var sum = 0;
            for (var i = 0; i < numbers.Count; ++i)
            {
                sum += numbers[i];
            }

            return sum;
        }

        [Benchmark]
        public int SumWithForeach()
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        [Benchmark]
        public int SumWithLINQSum()
        {
            return numbers.Sum();
        }
        
        [Benchmark]
        public int SumWithAggregate()
        {
            return numbers.Aggregate(0, (acc, number) => acc += number);
        }
    }
}