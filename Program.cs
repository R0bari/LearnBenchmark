using System;
using BenchmarkDotNet.Running;

namespace LearnBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkCycles>();
        }
    }
}