namespace Minesweeper

open System

type Cell =
    | Covered of Cell
    | Bomb
    | Number of int
    | Boom
    | Flag of Cell
    | Question of Cell

module Cell =
    let char v =
        match v with
        | Covered _ -> '.'
        | Bomb -> '*'
        | Boom -> 'X'
        | Flag _ -> 'A'
        | Number i -> Convert.ToChar(i + (int)'0')
        | Question _ -> '?'
    
    let uncover v =
        match v with
        | Covered x -> x
        | _ -> v

    let click v =
        let x = uncover v
        match x with
        | Bomb -> Boom
        | _ -> x

    let rclick v =
        match v with
        | Covered x -> Flag x
        | Flag x -> Question x
        | Question x -> Covered x
        | _ -> v
        

