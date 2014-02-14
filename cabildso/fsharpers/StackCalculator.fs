module StackCalculator

type Stack = StackContents of float list

let push x (StackContents contents) =   
    StackContents (x::contents)
    
let pop (StackContents contents) = 
    match contents with 
    | top::rest -> 
        (top, StackContents rest)
    | [] ->
        failwith "popping empty stack!"

let EMPTY = StackContents []
let ONE = push 1.0
let TWO = push 2.0
let THREE = push 3.0
let FOUR = push 4.0
let FIVE = push 5.0

let binary mathFn stack = 
    let x,stack' = pop stack    
    let y,stack'' = pop stack'  
    let z = mathFn y x
    push z stack''    

let ADD = binary (+)
let MUL = binary (*)
let DIV = binary (/)
let SUB = binary (-)