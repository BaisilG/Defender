using System;
using Xunit.Sdk;

namespace Defender {
	public static partial class ClaimExtensions {
		/// <summary>
		/// Does the <see cref="Claim{T}"/>'d object reference the <paramref name="expected"/>?
		/// </summary>
		/// <typeparam name="T">The <see langword="class"/> type.</typeparam>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <param name="expected">The expected object.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<T> ReferenceEquals<T>(this Claim<T> claim, T expected) where T : class {
			if (!ReferenceEquals(claim.Value, expected)) {
				throw new EqualException(expected, claim.Value);
			}
			return claim;
		}
	}
}
