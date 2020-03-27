// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Design", "CA1032:Implement standard exception constructors", Justification = "They don't have standard messages, they have preformatted messages.")]
[assembly: SuppressMessage("Design", "RCS1194:Implement exception constructors.", Justification = "They don't have standard messages, they have preformatted messages.")]
