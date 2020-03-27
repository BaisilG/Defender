using System;
using System.Runtime.Serialization;

namespace Defender {
    /// <summary>
    /// Indicates a compare claim failed.
    /// </summary>
    [Serializable]
    public abstract class CompareException : TrialException {
        /// <inheritdoc/>
        protected CompareException(String message) : base(message) { }

        /// <inheritdoc/>
        protected CompareException(String message, Exception inner) : base(message, inner) { }

        /// <inheritdoc/>
        protected CompareException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
