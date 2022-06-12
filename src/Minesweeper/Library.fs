namespace Minesweeper

type Cell =
    | Covered of Cell
    | Bomb

module Cell =
    let char v =
        match v with
        | Covered _ -> '.'
        | Bomb -> '*'
    
    let uncover v =
        match v with
        | Covered x -> x
        | _ -> v

