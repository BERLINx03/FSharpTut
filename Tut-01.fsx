//First of all .fsx files doesn't compile unless u explicitly loaded into project
// = is bind operator and equality operator here because the default is that all variables are immutable unless you 'let mutable' it
// <- reassign operator, which works only with the mutable types ( we won't use it )

//type inference 
let myOne = 1

//you can explicit add the type
let myTwo: int = 2
printfn $"my one is equal to %d{myOne} and my two is equal to %d{myTwo}"

///////////////////////////////////////
//reassigning
let mutable isEnable = true

isEnable <- false
////////////////////////////////////////
//functions

//function use the same keyword as variables, because FUNCTIONS IN F# ARE VALUES
let add x y = y + x

//the last line IS the return value
let addFive x =
    //nested let
    let five = 5
    
    //every new line is an expression and expressions are values so u can d that
    3
    
    //return value
    x + five