namespace ConsoleApp1 //namespace : groupings of code combined under one name
//Namespaces can't contain bindings
//e.g. let x = 3
//Namespace contains type and module.

//module : implemented as static class( piece of code that contains code elements )
//module contains values,functions and types.
//can be nested ...
module Arithmetic =
    module Addition =
        let add x y = x + y
        

//to use this we can call it as 'Arithmetic.Addition.add' or ...
module Other =
    open Arithmetic.Addition
    let program =
        add 5 5