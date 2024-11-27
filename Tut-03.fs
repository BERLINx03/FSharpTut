namespace ConsoleApp1

open System
open System.Threading

module Program =
    [<EntryPoint>]
    let main args =
        Console.WriteLine "Hello world"
        let myName = "Abdallah"
        printfn $"my name is %s{myName}"
        
        let currentTime () =
            DateTime.Now
            
        currentTime()
        |> printfn "Time is %O"
        
        printfn $"Time is %O{currentTime()}"
        
        Thread.Sleep 2000
        
        printfn "Time is %O" (currentTime())
        0