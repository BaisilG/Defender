using System;
using System.Collections;
using System.Collections.Generic;
using Xunit.Sdk;

namespace Defender {
	public static partial class ClaimExtensions {
		public static Claim<String> Empty(this Claim<String> claim) {
			if (claim.Value.Length != 0) {
				throw new EmptyException(claim.Value);
			}
			return claim;
		}

		public static Claim<T[]> Empty<T>(this Claim<T[]> claim) {
			if (claim.Value.Length != 0) {
				throw new EmptyException(claim.Value);
			}
			return claim;
		}

		public static Claim<C> Empty<C>(this Claim<C> claim) where C : ICollection {
			if (claim.Value.Count != 0) {
				throw new EmptyException(claim.Value);
			}
			return claim;
		}

		public static Claim<C> Empty<C, T>(this Claim<C> claim) where C : ICollection<T> {
			if (claim.Value.Count != 0) {
				throw new EmptyException(claim.Value);
			}
			return claim;
		}
	}
}
