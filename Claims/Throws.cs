using System;
using Xunit.Sdk;

namespace Defender {
	public static partial class ClaimExtensions {
		/// <summary>
		/// Does the <paramref name="claim"/> throw the <typeparamref name="E"/> <see cref="Exception"/>?
		/// </summary>
		/// <typeparam name="E">The expected <see cref="Exception"/> type.</typeparam>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<Action> Throws<E>(this Claim<Action> claim) where E : Exception {
			try {
				claim.Value();
			} catch (E) {
				return claim;
			}
			throw new ThrowsException(typeof(E));
		}
	}
}
