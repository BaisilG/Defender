using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit.Sdk;

namespace Defender {
	public sealed class Claim {
		internal Claim() { }

		public StringClaim That(String @string) => new StringClaim(@string);

		public Claim<Action> That(Action action) => new Claim<Action>(action);

		public Claim<IEnumerable> That(IEnumerable sequence) => new Claim<IEnumerable>(sequence);

		public Claim<IEnumerable<T>> That<T>(IEnumerable<T> sequence) => new Claim<IEnumerable<T>>(sequence);

		/// <inheritdoc/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override Boolean Equals(Object obj) => base.Equals(obj);

		/// <inheritdoc/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override Int32 GetHashCode() => base.GetHashCode();

		/// <inheritdoc/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override String ToString() => base.ToString();
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

		/// <inheritdoc/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override Int32 GetHashCode() => base.GetHashCode();

		/// <inheritdoc/>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override String ToString() => base.ToString();
	}
}
