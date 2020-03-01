using System;
using Xunit.Sdk;

namespace Defender {
	/// <summary>
	/// Claims to be made about a <see cref="Func{TResult}"/>.
	/// </summary>
	public interface IFuncClaim {
		/// <summary>
		/// Does the <see cref="Func{TResult}"/> throw the <typeparamref name="E"/> when executed?
		/// </summary>
		/// <typeparam name="E">The expected exception type.</typeparam>
		/// <returns>The calling <see cref="IActionClaim"/>.</returns>
		public IFuncClaim Throws<E>() where E : Exception;
	}

	internal sealed class FuncClaim<R> : IFuncClaim {
		internal FuncClaim(Func<R> func) => Func = func;

		public Func<R> Func { get; }

		public FuncClaim<R> Equals(Func<R> expected) {
			if (!Equals(Func, expected)) {
				throw new EqualException(expected, Func);
			}
			return this;
		}

		public IFuncClaim Throws<E>() where E : Exception {
			try {
				_ = Func();
			} catch (E) {
				return this;
			}
			throw new ThrowsException(typeof(E));
		}
	}

	internal sealed class FuncClaim<P1, R> : IFuncClaim {
		internal FuncClaim(Func<P1, R> func, P1 param1) {
			Func = func;
			Param1 = param1;
		}

		public Func<P1, R> Func { get; }

		public P1 Param1 { get; }

		public FuncClaim<P1, R> Equals(Func<P1, R> expected) {
			if (!Equals(Func, expected)) {
				throw new EqualException(expected, Func);
			}
			return this;
		}

		public IFuncClaim Throws<E>() where E : Exception {
			try {
				_ = Func(Param1);
			} catch (E) {
				return this;
			}
			throw new ThrowsException(typeof(E));
		}
	}

	internal sealed class FuncClaim<P1, P2, R> : IFuncClaim {
		internal FuncClaim(Func<P1, P2, R> func, P1 param1, P2 param2) {
			Func = func;
			Param1 = param1;
			Param2 = param2;
		}

		public Func<P1, P2, R> Func { get; }

		public P1 Param1 { get; }

		public P2 Param2 { get; }

		public FuncClaim<P1, P2, R> Equals(Func<P1, P2, R> expected) {
			if (!Equals(Func, expected)) {
				throw new EqualException(expected, Func);
			}
			return this;
		}

		public IFuncClaim Throws<E>() where E : Exception {
			try {
				_ = Func(Param1, Param2);
			} catch (E) {
				return this;
			}
			throw new ThrowsException(typeof(E));
		}
	}

	internal sealed class FuncClaim<P1, P2, P3, R> : IFuncClaim {
		internal FuncClaim(Func<P1, P2, P3, R> func, P1 param1, P2 param2, P3 param3) {
			Func = func;
			Param1 = param1;
			Param2 = param2;
			Param3 = param3;
		}

		public Func<P1, P2, P3, R> Func { get; }

		public P1 Param1 { get; }

		public P2 Param2 { get; }

		public P3 Param3 { get; }

		public FuncClaim<P1, P2, P3, R> Equals(Func<P1, P2, P3, R> expected) {
			if (!Equals(Func, expected)) {
				throw new EqualException(expected, Func);
			}
			return this;
		}

		public IFuncClaim Throws<E>() where E : Exception {
			try {
				_ = Func(Param1, Param2, Param3);
			} catch (E) {
				return this;
			}
			throw new ThrowsException(typeof(E));
		}
	}

	internal sealed class FuncClaim<P1, P2, P3, P4, R> : IFuncClaim {
		internal FuncClaim(Func<P1, P2, P3, P4, R> func, P1 param1, P2 param2, P3 param3, P4 param4) {
			Func = func;
			Param1 = param1;
			Param2 = param2;
			Param3 = param3;
			Param4 = param4;
		}

		public Func<P1, P2, P3, P4, R> Func { get; }

		public P1 Param1 { get; }

		public P2 Param2 { get; }

		public P3 Param3 { get; }

		public P4 Param4 { get; }

		public FuncClaim<P1, P2, P3, P4, R> Equals(Action<P1, P2, P3, P4> expected) {
			if (!Equals(Func, expected)) {
				throw new EqualException(expected, Func);
			}
			return this;
		}

		public IFuncClaim Throws<E>() where E : Exception {
			try {
				_ = Func(Param1, Param2, Param3, Param4);
			} catch (E) {
				return this;
			}
			throw new ThrowsException(typeof(E));
		}
	}

	internal sealed class FuncClaim<P1, P2, P3, P4, P5, R> : IFuncClaim {
		internal FuncClaim(Func<P1, P2, P3, P4, P5, R> func, P1 param1, P2 param2, P3 param3, P4 param4, P5 param5) {
			Func = func;
			Param1 = param1;
			Param2 = param2;
			Param3 = param3;
			Param4 = param4;
			Param5 = param5;
		}

		public Func<P1, P2, P3, P4, P5, R> Func { get; }

		public P1 Param1 { get; }

		public P2 Param2 { get; }

		public P3 Param3 { get; }

		public P4 Param4 { get; }

		public P5 Param5 { get; }

		public FuncClaim<P1, P2, P3, P4, P5, R> Equals(Func<P1, P2, P3, P4, P5, R> expected) {
			if (!Equals(Func, expected)) {
				throw new EqualException(expected, Func);
			}
			return this;
		}

		public IFuncClaim Throws<E>() where E : Exception {
			try {
				_ = Func(Param1, Param2, Param3, Param4, Param5);
			} catch (E) {
				return this;
			}
			throw new ThrowsException(typeof(E));
		}
	}
}