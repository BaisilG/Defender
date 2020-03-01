using System;
using System.Collections;
using System.Collections.Generic;
using Xunit.Sdk;

namespace Defender {
	public sealed class Claim {
		internal Claim() { }

		public StringClaim That(String @string) => new StringClaim(@string);

		public SequenceClaim That(IEnumerable sequence) => new SequenceClaim(sequence);

		public SequenceClaim<T> That<T>(IEnumerable<T> sequence) => new SequenceClaim<T>(sequence);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public IActionClaim That(Action action) => new ActionClaim(action);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public IActionClaim That<P1>(Action<P1> action, P1 param1) => new ActionClaim<P1>(action, param1);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public IActionClaim That<P1, P2>(Action<P1, P2> action, P1 param1, P2 param2) => new ActionClaim<P1, P2>(action, param1, param2);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public IActionClaim That<P1, P2, P3>(Action<P1, P2, P3> action, P1 param1, P2 param2, P3 param3) => new ActionClaim<P1, P2, P3>(action, param1, param2, param3);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public IActionClaim That<P1, P2, P3, P4>(Action<P1, P2, P3, P4> action, P1 param1, P2 param2, P3 param3, P4 param4) => new ActionClaim<P1, P2, P3, P4>(action, param1, param2, param3, param4);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public IActionClaim That<P1, P2, P3, P4, P5>(Action<P1, P2, P3, P4, P5> action, P1 param1, P2 param2, P3 param3, P4 param4, P5 param5) => new ActionClaim<P1, P2, P3, P4, P5>(action, param1, param2, param3, param4, param5);

		/// <summary>
		/// Claims to be made about an <see cref="Func{TResult}"/>.
		/// </summary>
		public IFuncClaim That<R>(Func<R> func) => new FuncClaim<R>(func);

		/// <summary>
		/// Claims to be made about an <see cref="Func{TResult}"/>.
		/// </summary>
		public IFuncClaim That<P1, R>(Func<P1, R> func, P1 param1) => new FuncClaim<P1, R>(func, param1);

		/// <summary>
		/// Claims to be made about an <see cref="Func{TResult}"/>.
		/// </summary>
		public IFuncClaim That<P1, P2, R>(Func<P1, P2, R> func, P1 param1, P2 param2) => new FuncClaim<P1, P2, R>(func, param1, param2);

		/// <summary>
		/// Claims to be made about an <see cref="Func{TResult}"/>.
		/// </summary>
		public IFuncClaim That<P1, P2, P3, R>(Func<P1, P2, P3, R> func, P1 param1, P2 param2, P3 param3) => new FuncClaim<P1, P2, P3, R>(func, param1, param2, param3);

		/// <summary>
		/// Claims to be made about an <see cref="Func{TResult}"/>.
		/// </summary>
		public IFuncClaim That<P1, P2, P3, P4, R>(Func<P1, P2, P3, P4, R> func, P1 param1, P2 param2, P3 param3, P4 param4) => new FuncClaim<P1, P2, P3, P4, R>(func, param1, param2, param3, param4);

		/// <summary>
		/// Claims to be made about an <see cref="Func{TResult}"/>.
		/// </summary>
		public IFuncClaim That<P1, P2, P3, P4, P5, R>(Func<P1, P2, P3, P4, P5, R> func, P1 param1, P2 param2, P3 param3, P4 param4, P5 param5) => new FuncClaim<P1, P2, P3, P4, P5, R>(func, param1, param2, param3, param4, param5);
	}

	/// <summary>
	/// Claims to be made about a value.
	/// </summary>
	public class Claim<T> {
		internal Claim(T value) => Value = value;

		/// <summary>
		/// The value having claims made against it.
		/// </summary>
		public T Value { get; private set; }

		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d value equal the <paramref name="expected"/>?
		/// </summary>
		/// <typeparam name="Te">The type of <paramref name="expected"/>.</typeparam>
		/// <param name="expected">The expected value.</param>
		/// <returns>The calling <see cref="Claim{T}"/>.</returns>
		/// <remarks>
		/// This uses the <see cref="IEquatable{T}.Equals(T)"/> of <typeparamref name="Te"/>, for supporting mixed types.
		/// </remarks>
		public Claim<T> Equals<Te>(Te expected) where Te : IEquatable<T> {
			if (!expected.Equals(Value)) {
				throw new EqualException(expected, Value);
			}
			return this;
		}

		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d value equal the <paramref name="expected"/>?
		/// </summary>
		/// <param name="expected">The expected value.</param>
		/// <returns>The calling <see cref="Claim{T}"/>.</returns>
		new public Claim<T> Equals(Object? expected) {
			if (!Equals(Value, expected)) {
				throw new EqualException(expected, Value);
			}
			return this;
		}
	}
}
