using System;
using System.Collections.Generic;
using System.Text;

namespace Defender {
	public static class ClaimExtensions {
		/// <summary>
		/// Claims to be made about a value.
		/// </summary>
		/// <remarks>
		/// This has to be an extension method because this is the default "catch all", and it has to be checked last. The only way to do that is to have most <see cref="That{T}(Claim, T)"/> variants as instance methods, with this one as an extension method.
		/// </remarks>
		public static Claim<T> That<T>(this Claim _, T value) => new Claim<T>(value);
	}
}
