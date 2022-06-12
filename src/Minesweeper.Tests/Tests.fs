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

[<Fact>]
let IsNumber() =
    let sut = Number 0
    let ret = sut |> char
    Assert.Equal('0', ret )

[<Fact>]
let IsFlag() =
    let sut = Flag (Number 0)
    let ret = sut |> char
    Assert.Equal('A', ret )

[<Fact>]
let IsQuestion() =
    let sut = Question (Number 0)
    let ret = sut |> char
    Assert.Equal('?', ret )

[<Fact>]
let IsQuestionWithRightClick() =
    let sut = Covered (Number 0)
    let ret = sut |> rclick |> rclick |> char
    Assert.Equal('?', ret )
