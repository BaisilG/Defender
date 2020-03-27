using System;
using System.Collections.Generic;
using System.Text;

namespace Defender {
	public static class ClaimExtensions {
		/// <summary>
		/// Claims to be made about a value.
		/// </summary>
		public static Claim<T> That<T>(this Claim _, T value) => new Claim<T>(value);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public static IActionClaim That(this Claim _, Action action) => new ActionClaim(action);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public static IActionClaim That<P1>(this Claim _, Action<P1> action, P1 param1) => new ActionClaim<P1>(action, param1);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public static IActionClaim That<P1, P2>(this Claim _, Action<P1, P2> action, P1 param1, P2 param2) => new ActionClaim<P1, P2>(action, param1, param2);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public static IActionClaim That<P1, P2, P3>(this Claim _, Action<P1, P2, P3> action, P1 param1, P2 param2, P3 param3) => new ActionClaim<P1, P2, P3>(action, param1, param2, param3);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public static IActionClaim That<P1, P2, P3, P4>(this Claim _, Action<P1, P2, P3, P4> action, P1 param1, P2 param2, P3 param3, P4 param4) => new ActionClaim<P1, P2, P3, P4>(action, param1, param2, param3, param4);

		/// <summary>
		/// Claims to be made about an <see cref="Action"/>.
		/// </summary>
		public static IActionClaim That<P1, P2, P3, P4, P5>(this Claim _, Action<P1, P2, P3, P4, P5> action, P1 param1, P2 param2, P3 param3, P4 param4, P5 param5) => new ActionClaim<P1, P2, P3, P4, P5>(action, param1, param2, param3, param4, param5);

		/// <summary>
		/// Claims to be made about an <see cref="Func{TResult}"/>.
		/// </summary>
		public static IFuncClaim That<R>(this Claim _, Func<R> func) => new FuncClaim<R>(func);

		/// <summary>
		/// Claims to be made about an <see cref="Func{TResult}"/>.
		/// </summary>
		public static IFuncClaim That<P1, R>(this Claim _, Func<P1, R> func, P1 param1) => new FuncClaim<P1, R>(func, param1);

		/// <summary>
		/// Claims to be made about an <see cref="Func{TResult}"/>.
		/// </summary>
		public static IFuncClaim That<P1, P2, R>(this Claim _, Func<P1, P2, R> func, P1 param1, P2 param2) => new FuncClaim<P1, P2, R>(func, param1, param2);

		/// <summary>
		/// Claims to be made about an <see cref="Func{TResult}"/>.
		/// </summary>
		public static IFuncClaim That<P1, P2, P3, R>(this Claim _, Func<P1, P2, P3, R> func, P1 param1, P2 param2, P3 param3) => new FuncClaim<P1, P2, P3, R>(func, param1, param2, param3);

		/// <summary>
		/// Claims to be made about an <see cref="Func{TResult}"/>.
		/// </summary>
		public static IFuncClaim That<P1, P2, P3, P4, R>(this Claim _, Func<P1, P2, P3, P4, R> func, P1 param1, P2 param2, P3 param3, P4 param4) => new FuncClaim<P1, P2, P3, P4, R>(func, param1, param2, param3, param4);

		/// <summary>
		/// Claims to be made about an <see cref="Func{TResult}"/>.
		/// </summary>
		public static IFuncClaim That<P1, P2, P3, P4, P5, R>(this Claim _, Func<P1, P2, P3, P4, P5, R> func, P1 param1, P2 param2, P3 param3, P4 param4, P5 param5) => new FuncClaim<P1, P2, P3, P4, P5, R>(func, param1, param2, param3, param4, param5);

	}
}
