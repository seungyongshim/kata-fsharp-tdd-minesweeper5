module CellSpec

open Xunit
open Minesweeper
open Minesweeper.Cell

[<Fact>]
let IsCovered() =
    let sut = Covered Bomb
    let ret = sut |> char
    Assert.Equal('.', ret)

[<Fact>]
let IsBomb() =
    let sut = Bomb
    let ret = sut |> char
    Assert.Equal('*', ret )

[<Fact>]
let IsNumber() =
    let sut = Number 0
    let ret = sut |> char
    Assert.Equal('0', ret)

[<Fact>]
let IsFlag() =
    let sut = Covered (Number 0)
    let ret = sut |> rclick |> char
    Assert.Equal('A', ret)

[<Fact>]
let IsQuestion() =
    let sut = Covered (Number 0)
    let ret = sut |> rclick |> rclick |> char
    Assert.Equal('?', ret)

[<Fact>]
let IsBoom() =
    let sut = Covered Bomb
    let ret = sut |> click |> char
    Assert.Equal('X', ret)

