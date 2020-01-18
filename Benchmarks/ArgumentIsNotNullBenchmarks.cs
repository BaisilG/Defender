using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using ArdalisGuard = Ardalis.GuardClauses;
using static Defender.Arguments;
using Dawn;
using Lite = LiteGuard;
using Light.GuardClauses;

namespace Benchmarks {
	[SimpleJob(RuntimeMoniker.Net48)]
	[SimpleJob(RuntimeMoniker.NetCoreApp31)]
	[SimpleJob(RuntimeMoniker.CoreRt31)]
	[SimpleJob(RuntimeMoniker.Mono)]
	[MemoryDiagnoser]
	public class ArgumentIsNotNullBenchmarks {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void noGuard(String argument) => _ = argument.Length;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void manualGuard(String argument) {
			if (argument is null) {
				throw new ArgumentNullException(nameof(argument));
			}
			_ = argument.Length;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void ardalis(String argument) {
			ArdalisGuard.GuardClauseExtensions.Null(ArdalisGuard.Guard.Against, argument, nameof(argument));
			_ = argument.Length;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void defender(String argument) {
			NotNull(argument, nameof(argument));
			_ = argument.Length;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void dawnGuard(String argument) {
			_ = Dawn.Guard.Argument(argument, nameof(argument)).NotNull();
			_ = argument.Length;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void liteGuard(String argument) {
			Lite.Guard.AgainstNullArgument(nameof(argument), argument);
			_ = argument.Length;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void lightGuard(String argument) {
			_ = argument.MustNotBeNull(nameof(argument)).Length;
		}

		[Params("hello", null)]
		public String Argument { get; set; }

		[Benchmark(Baseline = true)]
		public void NoGuard() {
			try {
				noGuard(Argument);
			} catch (Exception) {
				// Keep BenchmarkDotNet from discarding the results
			}
		}

		[Benchmark]
		public void ManualGuard() {
			try {
				manualGuard(Argument);
			} catch (Exception) {
				// Keep BenchmarkDotNet from discarding the results
			}
		}

		[Benchmark]
		public void Ardalis() {
			try {
				ardalis(Argument);
			} catch (Exception) {
				// Keep BenchmarkDotNet from discarding the results
			}
		}

		[Benchmark]
		public void Defender() {
			try {
				defender(Argument);
			} catch (Exception) {
				// Keep BenchmarkDotNet from discarding the results
			}
		}

		[Benchmark]
		public void DawnGuard() {
			try {
				dawnGuard(Argument);
			} catch (Exception) {
				// Keep BenchmarkDotNet from discarding the results
			}
		}

		[Benchmark]
		public void LiteGuard() {
			try {
				liteGuard(Argument);
			} catch (Exception) {
				// Keep BenchmarkDotNet from discarding the results
			}
		}

		[Benchmark]
		public void LightGuard() {
			try {
				lightGuard(Argument);
			} catch (Exception) {
				// Keep BenchmarkDotNet from discarding the results
			}
		}
	}
}
