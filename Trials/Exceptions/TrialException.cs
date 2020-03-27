using System;
using System.Runtime.Serialization;

namespace Defender {
    /// <summary>
    /// The base exception for all of <see cref="Defender"/> trials.
    /// </summary>
    [Serializable]
    public abstract class TrialException : Exception {
       /// <inheritdoc/>
        protected TrialException(String message) : base(message) { }

        /// <inheritdoc/>
        protected TrialException(String message, Exception inner) : base(message, inner) { }

        /// <inheritdoc/>
        protected TrialException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
