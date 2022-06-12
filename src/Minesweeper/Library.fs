namespace Minesweeper

type Cell =
    | Covered of Cell
    | Bomb
    member this.ToChar =
        match this with
        | Covered _ -> '.'
        | Bomb -> '*'
