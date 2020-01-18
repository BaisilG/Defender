using BenchmarkDotNet.Running;

namespace Benchmarks {
	public static class Program {
		public static void Main() {
			_ = BenchmarkRunner.Run<Argument_Class_NotNull_Benchmarks>();
			_ = BenchmarkRunner.Run<Argument_Struct_NotNull_Benchmarks>();
		}
	}
}
