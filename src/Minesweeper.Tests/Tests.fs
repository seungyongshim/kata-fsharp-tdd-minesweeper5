module Tests

open System
open Minesweeper
open Xunit
open Minesweeper.Cell

[<Fact>]
let ``My test2`` () =
    let sut = Covered Bomb
    Assert.Equal('1', sut |> char )

    
