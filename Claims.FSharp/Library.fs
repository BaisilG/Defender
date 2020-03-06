namespace Defender

open System
open System.Collections
open Xunit.Sdk

[<AutoOpen>]
module Claims =
    /// <summary>
    /// Is this empty?
    /// </summary>
    let inline isEmpty(act:#IEnumerable) =
        let enum = act.GetEnumerator()
        if enum.MoveNext() then
            raise(EmptyException(act))
        act

    /// <summary>
    /// Is this equal?
    /// </summary>
    let inline isEqual(exp)(act) =
        if exp <> act then
            raise(EqualException(exp, act))
        act

    /// <summary>
    /// Is this false?
    /// </summary>
    let inline isFalse(act:bool) =
        if act then
            raise(FalseException("", Nullable(act)))
        act

    /// <summary>
    /// Is this not equal?
    /// </summary>
    let inline isNotEqual(exp)(act) =
        if String.Equals(act, exp) then
            raise(NotEqualException(exp, act))
        act

    /// <summary>
    /// Is this not null?
    /// </summary>
    let inline isNotNull(act) =
        if act = null then
            raise(NullException(act))
        act

    /// <summary>
    /// Is this null?
    /// </summary>
    let inline isNull(act) =
        if act <> null then
            raise(NotNullException())
        act

    /// <summary>
    /// Is this true?
    /// </summary>
    let inline isTrue(act:bool) =
        if not(act) then
            raise(TrueException("", Nullable(act)))
        act