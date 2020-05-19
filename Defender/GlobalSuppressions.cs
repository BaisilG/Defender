// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Design", "MA0048:File name must match type name", Justification = "It's easier to manage large collections of static methods by splitting up the files by method. This is a major reason why partial classes exist.")]
