module TestTheTester

open System
open Xunit
open FsCheck.Xunit
open Swensen.Unquote

[<Fact>]
let ``It works`` () =
    Assert.Equal(1, 1)

[<Fact>]
let ``Unquote works`` () =
    test <@ 1 = 1 @>

[<Property>]
let ``Reverse of reverse of a list is the original list ``(xs:list<int>) =
    List.rev(List.rev xs) = xs