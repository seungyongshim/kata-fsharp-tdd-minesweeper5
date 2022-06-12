module Tests

open System
open Minesweeper
open Xunit

[<Fact>]
let ``My test`` () =
    let sut = Covered Bomb
    Assert.Equal('0', sut.ToChar)
