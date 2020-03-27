using System;
using System.Runtime.Serialization;

namespace Defender {
    /// <summary>
    /// Indicates a greater than claim failed.
    /// </summary>
    [Serializable]
    public sealed class GreaterThanException : CompareException {
        /// <inheritdoc/>
        public GreaterThanException(Object actual, Object lowerBound) : base($"{actual} is not greater than {lowerBound}") { }

        /// <inheritdoc/>
        private GreaterThanException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
