using System;

namespace Defender {
    /// <summary>
    /// Declares that a parameter has been validated as not <see langword="null"/>.
    /// </summary>
    /// <remarks>
    /// This is required for analyzers like Sonar which can't figure it out on their own.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
    public sealed class ValidatedNotNullAttribute : Attribute {
    }
}
