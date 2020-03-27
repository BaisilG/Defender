using System;
using System.Runtime.Serialization;

namespace Defender {
    /// <summary>
    /// Indicates a lesser than claim failed.
    /// </summary>
    [Serializable]
    public sealed class LesserThanException : CompareException {
        /// <inheritdoc/>
        public LesserThanException(Object actual, Object lowerBound) : base($"{actual} is not lesser than {lowerBound}") { }

        /// <inheritdoc/>
        private LesserThanException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
