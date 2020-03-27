using System;

namespace Defender {
	/// <summary>
	/// Formats arguments for display.
	/// </summary>
	/// <remarks>
	/// This is designed similar in concept to what xUnit did, but doesn't work remotely close to the same way.
	/// </remarks>
	public static class ArgumentFormatter {
		private const Int32 maxDepth = 3;
		private const Int32 maxEnumerableLength = 5;
		private const Int32 maxObjectParameterCount = 5;
		private const Int32 maxStringLength = 50;

		/// <summary>
		/// Format the value for display.
		/// </summary>
		/// <param name="value">The value to be formatted.</param>
		/// <returns>The formatted value.</returns>
		public static String Format(String value) {
			if (value.Length > maxStringLength) {
				Char[] result = new Char[50];
				Array.Copy(value.ToCharArray(), 0, result, 0, 46);
				result[47] = '.';
				result[48] = '.';
				result[49] = '.';
				return new String(result);
			} else {
				return value;
			}
		}

		/// <summary>
		/// Format the value for display.
		/// </summary>
		/// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
		/// <param name="value">The value to be formatted.</param>
		/// <returns>The formatted value.</returns>
		public static String Format<T>(T value) => Format(value.ToString());
	}
}
