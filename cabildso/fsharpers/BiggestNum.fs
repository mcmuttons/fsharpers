module BiggestNum

open System

let getMax list = list |> max

let getMax2 list =
    let rec getMax2' max list =
        match list with
        | head::tail -> tail |> getMax2' (if max >= head then max else head)
        | []         -> max
    list |> List.tail |> getMax2' (list |> List.head)

let getMax3 list = list |> List.fold (fun max item -> if item > max then item else max) (list |> List.head)