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
//the last line IS the return value
let addFive x =
    //nested let
    let five = 5
    
    //every new line is an expression and expressions are values so u can d that
    //you can use ; to separate expression ( we won't use it as well )
    3;2
    3
    
    //return value
    x + five
  
///////////////////////////////////////////////////////
//the next 3 functions are the same in different ways
let add x y = y + x //int -> int -> int
//so what does 'int -> int -> int' means?
//because of currying explained in line 46 ( each function return another function e.g. int -> (int -> int) means it takes and int and return a function that takes an int and return int)


//lambda expression
//'fun' keyword is for lambda expression, anonymous function
//in F# there is no discrimination between lambda and function
let add' = fun x y -> x + y

//Currying | Baking-in : function that returns another function that returns another function
//in F# all functions are currying
let add'' x = fun y -> x + y

////////////////////////////////////////////////////
//Partial application
