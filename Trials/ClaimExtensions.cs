using System;
using System.Collections.Generic;
using System.Text;

namespace Defender {
	public static class ClaimExtensions {
		/// <summary>
		/// Claims to be made about a value.
		/// </summary>
		public static Claim<T> That<T>(this Claim _, T value) => new Claim<T>(value);
	}
}
