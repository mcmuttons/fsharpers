module BiggestNumTest

open FsUnit
open NUnit.Framework
open BiggestNum

[<Test>]
let ``Gets biggest number``() =
    [2;4;9;14;9;3;2] |> getMax2 |> should equal 14

