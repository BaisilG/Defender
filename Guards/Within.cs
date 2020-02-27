using System;
using System.Runtime.CompilerServices;

namespace Defender {
	public static partial class Guard {
		/// <summary>
		/// Guards against the <paramref name="value"/> being outside of the range of <paramref name="lower"/>..<paramref name="upper"/>.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		/// <param name="upper">The upper bound.</param>
		/// <param name="inclusive">Whether the bounds are inclusive or exclusive.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Within(Byte value, String name, Byte lower, Byte upper, Boolean inclusive) {
			Int32 margin = upper - lower;
			if (inclusive) {
				if ((value - lower) > margin) {
					throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} inclusive.");
				}
			} else if ((value - lower) >= margin) {
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} exclusive.");
			}
		}

		/// <summary>
		/// Guards against the <paramref name="value"/> being outside of the range of <paramref name="lower"/>..<paramref name="upper"/>.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		/// <param name="upper">The upper bound.</param>
		/// <param name="inclusive">Whether the bounds are inclusive or exclusive.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Within(SByte value, String name, SByte lower, SByte upper, Boolean inclusive) {
			Int32 factor = (value - lower) * (upper - value);
			if (inclusive) {
				if (factor < 0) {
					throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} inclusive.");
				}
			} else if (factor <= 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} exclusive.");
			}
		}

		/// <summary>
		/// Guards against the <paramref name="value"/> being outside of the range of <paramref name="lower"/>..<paramref name="upper"/>.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		/// <param name="upper">The upper bound.</param>
		/// <param name="inclusive">Whether the bounds are inclusive or exclusive.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Within(Int16 value, String name, Int16 lower, Int16 upper, Boolean inclusive) {
			Int32 factor = (value - lower) * (upper - value);
			if (inclusive) {
				if (factor < 0) {
					throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} inclusive.");
				}
			} else if (factor <= 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} exclusive.");
			}
		}

		/// <summary>
		/// Guards against the <paramref name="value"/> being outside of the range of <paramref name="lower"/>..<paramref name="upper"/>.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		/// <param name="upper">The upper bound.</param>
		/// <param name="inclusive">Whether the bounds are inclusive or exclusive.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Within(UInt16 value, String name, UInt16 lower, UInt16 upper, Boolean inclusive) {
			Int32 margin = upper - lower;
			if (inclusive) {
				if ((value - lower) > margin) {
					throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} inclusive.");
				}
			} else if ((value - lower) >= margin) {
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} exclusive.");
			}
		}

		/// <summary>
		/// Guards against the <paramref name="value"/> being outside of the range of <paramref name="lower"/>..<paramref name="upper"/>.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		/// <param name="upper">The upper bound.</param>
		/// <param name="inclusive">Whether the bounds are inclusive or exclusive.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Within(Int32 value, String name, Int32 lower, Int32 upper, Boolean inclusive) {
			Int32 factor = (value - lower) * (upper - value);
			if (inclusive) {
				if (factor < 0) {
					throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} inclusive.");
				}
			} else if (factor <= 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} exclusive.");
			}
		}

		/// <summary>
		/// Guards against the <paramref name="value"/> being outside of the range of <paramref name="lower"/>..<paramref name="upper"/>.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		/// <param name="upper">The upper bound.</param>
		/// <param name="inclusive">Whether the bounds are inclusive or exclusive.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Within(UInt32 value, String name, UInt32 lower, UInt32 upper, Boolean inclusive) {
			UInt32 margin = upper - lower;
			if (inclusive) {
				if ((value - lower) > margin) {
					throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} inclusive.");
				}
			} else if ((value - lower) >= margin) {
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} exclusive.");
			}
		}

		/// <summary>
		/// Guards against the <paramref name="value"/> being outside of the range of <paramref name="lower"/>..<paramref name="upper"/>.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		/// <param name="upper">The upper bound.</param>
		/// <param name="inclusive">Whether the bounds are inclusive or exclusive.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Within(Int64 value, String name, Int64 lower, Int64 upper, Boolean inclusive) {
			Int64 factor = (value - lower) * (upper - value);
			if (inclusive) {
				if (factor < 0) {
					throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} inclusive.");
				}
			} else if (factor <= 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} exclusive.");
			}
		}

		/// <summary>
		/// Guards against the <paramref name="value"/> being outside of the range of <paramref name="lower"/>..<paramref name="upper"/>.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		/// <param name="upper">The upper bound.</param>
		/// <param name="inclusive">Whether the bounds are inclusive or exclusive.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Within(UInt64 value, String name, UInt64 lower, UInt64 upper, Boolean inclusive) {
			UInt64 margin = upper - lower;
			if (inclusive) {
				if ((value - lower) > margin) {
					throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} inclusive.");
				}
			} else if ((value - lower) >= margin) {
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} exclusive.");
			}
		}

		/// <summary>
		/// Guards against the <paramref name="value"/> being outside of the range of <paramref name="lower"/>..<paramref name="upper"/>.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		/// <param name="upper">The upper bound.</param>
		/// <param name="inclusive">Whether the bounds are inclusive or exclusive.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Within(Single value, String name, Single lower, Single upper, Boolean inclusive) {
			Single factor = (value - lower) * (upper - value);
			if (inclusive) {
				if (factor < 0) {
					throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} inclusive.");
				}
			} else if (factor <= 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} exclusive.");
			}
		}

		/// <summary>
		/// Guards against the <paramref name="value"/> being outside of the range of <paramref name="lower"/>..<paramref name="upper"/>.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		/// <param name="upper">The upper bound.</param>
		/// <param name="inclusive">Whether the bounds are inclusive or exclusive.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Within(Double value, String name, Double lower, Double upper, Boolean inclusive) {
			Double factor = (value - lower) * (upper - value);
			if (inclusive) {
				if (factor < 0) {
					throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} inclusive.");
				}
			} else if (factor <= 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} exclusive.");
			}
		}

		/// <summary>
		/// Guards against the <paramref name="value"/> being outside of the range of <paramref name="lower"/>..<paramref name="upper"/>.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		/// <param name="upper">The upper bound.</param>
		/// <param name="inclusive">Whether the bounds are inclusive or exclusive.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Within(Decimal value, String name, Decimal lower, Decimal upper, Boolean inclusive) {
			Decimal factor = (value - lower) * (upper - value);
			if (inclusive) {
				if (factor < 0) {
					throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} inclusive.");
				}
			} else if (factor <= 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} exclusive.");
			}
		}

		/// <summary>
		/// Guards against the <paramref name="value"/> being outside of the range of <paramref name="lower"/>..<paramref name="upper"/>.
		/// </summary>
		/// <typeparam name="T">The type of the argument.</typeparam>
		/// <param name="value">The value.</param>
		/// <param name="name">The name of the argument.</param>
		/// <param name="lower">The lower bound.</param>
		/// <param name="upper">The upper bound.</param>
		/// <param name="inclusive">Whether the bounds are inclusive or exclusive.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Within<T>(T value, String name, T lower, T upper, Boolean inclusive) where T : IComparable<T> {
			Int32 left = value.CompareTo(lower);
			Int32 right = value.CompareTo(upper);
			if (inclusive) {
				if (left > 0 && right > 0) {
					throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} inclusive.");
				}
			} else if (left >= 0 && right >= 0) {
				throw new ArgumentOutOfRangeException(name, $"Argument '{name}' must be within {lower}..{upper} exclusive.");
			}
		}
	}
}
