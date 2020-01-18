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
	public class Argument_Struct_NotNull_Benchmarks {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void noGuard(Int32? argument) => _ = argument.Value;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void manualGuard(Int32? argument) {
			if (argument is null) {
				throw new ArgumentNullException(nameof(argument));
			}
			_ = argument.Value;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void ardalis(Int32? argument) {
			ArdalisGuard.GuardClauseExtensions.Null(ArdalisGuard.Guard.Against, argument, nameof(argument));
			_ = argument.Value;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void defender(Int32? argument) {
			NotNull(argument, nameof(argument));
			_ = argument.Value;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void dawnGuard(Int32? argument) {
			_ = Dawn.Guard.Argument(argument, nameof(argument)).NotNull();
			_ = argument.Value;
		}

		[Params(42, null)]
		public Int32? Argument { get; set; }

		[Benchmark]
		public void NoGuard() {
			try {
				noGuard(Argument);
			} catch (Exception) {
				// Keep BenchmarkDotNet from discarding the results
			}
		}

		[Benchmark(Baseline = true)]
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
	}
}
