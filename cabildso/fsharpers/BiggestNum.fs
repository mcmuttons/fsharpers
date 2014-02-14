module BiggestNum

open System

let getMax list = list |> List.max

let getMax2 input =
    let rec getMax2' highest list =
        match input with
        | head::tail -> getMax2' (max highest head) tail
        | []         -> highest
    input 
    |> List.tail 
    |> getMax2' (List.head input)

let getMax3 list = 
    list 
    |> List.fold (fun highest item -> max highest item) (list |> List.head)

let getMax4 input =
    let rec getMax4' highest list =
        match input with
        | head::tail -> getMax4' (max highest head) tail
        | []         -> highest
    getMax4' (List.head input) (List.tail input)