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

		public Claim<T> Equals<Te>(Te expected) where Te : IEquatable<T> {
			if (!expected.Equals(Value)) {
				throw new EqualException(expected, Value);
			}
			return this;
		}

		new public Claim<T> Equals(Object? expected) {
			if (!Equals(Value, expected)) {
				throw new EqualException(expected, Value);
			}
			return this;
		}
	}
}
