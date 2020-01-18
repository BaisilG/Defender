using System;
using BenchmarkDotNet.Running;

namespace Benchmarks {
	public static class Program {
		public static void Main() {
			_ = BenchmarkRunner.Run<ArgumentIsNotNullBenchmarks>();
		}
	}
}
