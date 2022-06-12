module Tests

open Minesweeper
open Xunit
open Minesweeper.Cell

[<Fact>]
let IsCovered() =
    let sut = Covered Bomb
    let ret = sut |> char
    Assert.Equal('.', ret )

[<Fact>]
let IsBomb() =
    let sut = Bomb
    let ret = sut |> char
    Assert.Equal('*', ret )
