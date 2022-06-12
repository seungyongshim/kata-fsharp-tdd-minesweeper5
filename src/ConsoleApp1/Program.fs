open FSharpPlus
open FSharpPlus.Data

let lst = [None; None; Some 2; Some 4; Some 10; None]

let c = monad {
    let a = seq [|1;2;3|]
    let b = seq [1;2;3]
    for c in a do
        yield c
    }

printf("%A") c
