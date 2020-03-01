using System;
using System.Collections;
using System.Collections.Generic;

namespace Defender {
	/// <summary>
	/// Base test class, which injects the <see cref="Defender"/> testing framework into the test class.
	/// </summary>
	public abstract class Trial {
		protected Trial() { }

		public static Claim Claim { get; } = new Claim();
	}
}
