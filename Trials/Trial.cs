﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Defender {
	/// <summary>
	/// Base test class, which injects the <see cref="Defender"/> testing framework into the test class.
	/// </summary>
	public abstract class Trial {
		protected Trial() { }

		/// <summary>
		/// Claims to be made about a <see cref="String"/>.
		/// </summary>
		public static StringClaim Claim(String @string) => new StringClaim(@string);

		/// <summary>
		/// Claims to be made about a value.
		/// </summary>
		public static Claim<T> Claim<T>(T value) => new Claim<T>(value);

		/// <summary>
		/// Claims to be made about a sequence.
		/// </summary>
		/// <param name="sequence"></param>
		/// <returns></returns>
		public static Claim<IEnumerable> Claim(IEnumerable sequence) => new Claim<IEnumerable>(sequence);

		/// <summary>
		/// Claims to be made about a sequence.
		/// </summary>
		public static Claim<IEnumerable<T>> Claim<T>(IEnumerable<T> sequence) => new Claim<IEnumerable<T>>(sequence);

		/// <summary>
		/// Claims to be made about an array.
		/// </summary>
		public static Claim<IEnumerable<T>> Claim<T>(T[] array) => new Claim<IEnumerable<T>>(array);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public static IActionClaim Claim(Action action) => new ActionClaim(action);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public static IActionClaim Claim<P1>(Action<P1> action, P1 param1) => new ActionClaim<P1>(action, param1);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public static IActionClaim Claim<P1, P2>(Action<P1, P2> action, P1 param1, P2 param2) => new ActionClaim<P1, P2>(action, param1, param2);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public static IActionClaim Claim<P1, P2, P3>(Action<P1, P2, P3> action, P1 param1, P2 param2, P3 param3) => new ActionClaim<P1, P2, P3>(action, param1, param2, param3);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public static IActionClaim Claim<P1, P2, P3, P4>(Action<P1, P2, P3, P4> action, P1 param1, P2 param2, P3 param3, P4 param4) => new ActionClaim<P1, P2, P3, P4>(action, param1, param2, param3, param4);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public static IActionClaim Claim<P1, P2, P3, P4, P5>(Action<P1, P2, P3, P4, P5> action, P1 param1, P2 param2, P3 param3, P4 param4, P5 param5) => new ActionClaim<P1, P2, P3, P4, P5>(action, param1, param2, param3, param4, param5);

	}
}
