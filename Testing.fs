module Test

open NUnit.Framework
open FsUnit

let inc n = n + 1

[<Test>]
let ``inc adds 1 to its parameter`` () =
    (inc 41) |> should equal 42


