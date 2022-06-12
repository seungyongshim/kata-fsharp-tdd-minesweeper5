module Tests

open System
open Minesweeper
open Xunit
open Minesweeper.Cell

[<Fact>]
let IsBomb () =
    let sut = Covered Bomb
    let ret = sut |> uncover |> char
    Assert.Equal('*', ret )
