using System;
using Xunit.Sdk;

namespace Defender {
	public interface IActionClaim {
		public IActionClaim Throws<E>() where E : Exception;
	}

	internal sealed class ActionClaim : IActionClaim {
		internal ActionClaim(Action action) => Action = action;

		public Action Action { get; }

		public ActionClaim Equals(Action expected) {
			if (!Equals(Action, expected)) {
				throw new EqualException(expected, Action);
			}
			return this;
		}

		public IActionClaim Throws<E>() where E : Exception {
			try {
				Action();
			} catch (E) {
				return this;
			}
			throw new ThrowsException(typeof(E));
		}
	}

	internal sealed class ActionClaim<P1> : IActionClaim {
		internal ActionClaim(Action<P1> action, P1 param1) {
			Action = action;
			Param1 = param1;
		}

		public Action<P1> Action { get; }

		public P1 Param1 { get; }

		public ActionClaim<P1> Equals(Action<P1> expected) {
			if (!Equals(Action, expected)) {
				throw new EqualException(expected, Action);
			}
			return this;
		}

		public IActionClaim Throws<E>() where E : Exception {
			try {
				Action(Param1);
			} catch (E) {
				return this;
			}
			throw new ThrowsException(typeof(E));
		}
	}

	internal sealed class ActionClaim<P1, P2> : IActionClaim {
		internal ActionClaim(Action<P1, P2> action, P1 param1, P2 param2) {
			Action = action;
			Param1 = param1;
			Param2 = param2;
		}

		public Action<P1, P2> Action { get; }

		public P1 Param1 { get; }

		public P2 Param2 { get; }

		public ActionClaim<P1, P2> Equals(Action<P1, P2> expected) {
			if (!Equals(Action, expected)) {
				throw new EqualException(expected, Action);
			}
			return this;
		}

		public IActionClaim Throws<E>() where E : Exception {
			try {
				Action(Param1, Param2);
			} catch (E) {
				return this;
			}
			throw new ThrowsException(typeof(E));
		}
	}

	internal sealed class ActionClaim<P1, P2, P3> : IActionClaim {
		internal ActionClaim(Action<P1, P2, P3> action, P1 param1, P2 param2, P3 param3) {
			Action = action;
			Param1 = param1;
			Param2 = param2;
			Param3 = param3;
		}

		public Action<P1, P2, P3> Action { get; }

		public P1 Param1 { get; }

		public P2 Param2 { get; }

		public P3 Param3 { get; }

		public ActionClaim<P1, P2, P3> Equals(Action<P1, P2, P3> expected) {
			if (!Equals(Action, expected)) {
				throw new EqualException(expected, Action);
			}
			return this;
		}

		public IActionClaim Throws<E>() where E : Exception {
			try {
				Action(Param1, Param2, Param3);
			} catch (E) {
				return this;
			}
			throw new ThrowsException(typeof(E));
		}
	}

	internal sealed class ActionClaim<P1, P2, P3, P4> : IActionClaim {
		internal ActionClaim(Action<P1, P2, P3, P4> action, P1 param1, P2 param2, P3 param3, P4 param4) {
			Action = action;
			Param1 = param1;
			Param2 = param2;
			Param3 = param3;
			Param4 = param4;
		}

		public Action<P1, P2, P3, P4> Action { get; }

		public P1 Param1 { get; }

		public P2 Param2 { get; }

		public P3 Param3 { get; }

		public P4 Param4 { get; }

		public ActionClaim<P1, P2, P3, P4> Equals(Action<P1, P2, P3, P4> expected) {
			if (!Equals(Action, expected)) {
				throw new EqualException(expected, Action);
			}
			return this;
		}

		public IActionClaim Throws<E>() where E : Exception {
			try {
				Action(Param1, Param2, Param3, Param4);
			} catch (E) {
				return this;
			}
			throw new ThrowsException(typeof(E));
		}
	}

	internal sealed class ActionClaim<P1, P2, P3, P4, P5> : IActionClaim {
		internal ActionClaim(Action<P1, P2, P3, P4, P5> action, P1 param1, P2 param2, P3 param3, P4 param4, P5 param5) {
			Action = action;
			Param1 = param1;
			Param2 = param2;
			Param3 = param3;
			Param4 = param4;
			Param5 = param5;
		}

		public Action<P1, P2, P3, P4, P5> Action { get; }

		public P1 Param1 { get; }

		public P2 Param2 { get; }

		public P3 Param3 { get; }

		public P4 Param4 { get; }

		public P5 Param5 { get; }

		public ActionClaim<P1, P2, P3, P4, P5> Equals(Action<P1, P2, P3, P4, P5> expected) {
			if (!Equals(Action, expected)) {
				throw new EqualException(expected, Action);
			}
			return this;
		}

		public IActionClaim Throws<E>() where E : Exception {
			try {
				Action(Param1, Param2, Param3, Param4, Param5);
			} catch (E) {
				return this;
			}
			throw new ThrowsException(typeof(E));
		}
	}
}