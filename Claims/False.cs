using System;
using Xunit.Sdk;

namespace Defender {
	public static partial class ClaimExtensions {
		/// <summary>
		/// Is the <see cref="Claim{T}"/>'d value false?
		/// </summary>
		/// <param name="claim">The <see cref="Claim{T}"/>.</param>
		/// <returns>The calling <paramref name="claim"/>.</returns>
		public static Claim<Boolean> False(this Claim<Boolean> claim) {
			if (claim.Value) {
				throw new FalseException("", claim.Value);
			}
			return claim;
		}
	}
}
