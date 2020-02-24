using System;
using Xunit.Sdk;

namespace Defender {
	/// <summary>
	/// Claims to be made about a value.
	/// </summary>
	public sealed class Claim<T> {
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
