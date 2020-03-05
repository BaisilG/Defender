namespace Tests

open System
open Defender
open Xunit

module ClaimTests =

    [<Fact>]
    let ``claim empty`` () = [| |] |> isEmpty |> ignore

    [<Theory>]
    [<InlineData(0, 0)>]
    [<InlineData(5, 5)>]
    [<InlineData(-5, -5)>]
    [<InlineData(5.0, 5.0)>]
    [<InlineData(5.0, 5)>]
    [<InlineData(5, 5.0)>]
    [<InlineData('a', 'a')>]
    [<InlineData("", "")>]
    [<InlineData("hello", "hello")>]
    let ``claim equals`` (exp) (act) = act |> isEqual exp |> ignore

    [<Theory>]
    [<InlineData(false)>]
    let ``claim false`` (act) = act |> isFalse |> ignore

    [<Theory>]
    [<InlineData("", "a")>]
    [<InlineData("a", "")>]
    let ``claim not equal`` (exp) (act) = act |> isNotEqual exp |> ignore

    [<Theory>]
    [<InlineData("")>]
    let ``claim not null`` (act) = act |> isNotNull |> ignore

    [<Theory>]
    [<InlineData(null)>]
    let ``claim null`` (act) = act |> isNull |> ignore

    [<Theory>]
    [<InlineData(true)>]
    let ``claim true`` (act) = act |> isTrue |> ignore