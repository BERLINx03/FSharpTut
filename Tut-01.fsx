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
//parameters are whitespace separated and not comma as other languages
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
//Partial application : you are totally gives the functions all the parameters it needs
let add3 x =
    let three = 5
    x + three


let add3' x = add x 3
////////////////////////////////////////////////////

//u can specify one parameter type with ()
let sub (x: int) y = x - y

//if you put the time at the end it's the 'return type'

let sub' (x: int) y : int = x - y
////////////////////////////////////////////////////
//prefix and infix

//this is called infix
let add2 x = 2 + x
//this is called prefix
let add2' x = (+) 2 //2 + x
////////////////////////////////////////////////////////
//pipe operation
//imagine we accomplish to this equation...
let operation num = (2. * (num + 6.)) ** 2.
//consuming the pipe operator for readability as those mathematical operation have order to be done
let add6  = (+) 6.  //first step _following the parentheses order_

let times2  = (*) 2.

let pow2 num  = num ** 2.  //we can't use prefix here because it will be like : 2 ** num which violates the logic we are trying to achieve

//now combine those operations using the pipe op

let operation' num =
    num
    |> add6
    |> times2
    |> pow2
    
(*
    as u can see they're executing sequentially e.g. if you are familiar with other OO lang it's
    equivalent to : num.add(6).times(2).pow(2)
*)