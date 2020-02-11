// Learn more about F# at http://fsharp.org

open System
open Library

[<EntryPoint>]
let main argv =
    printfn "Json converter!"
    argv 
    |> Array.map getJsonNetJson
    |> Array.iter (printfn "%s")
    0 // return an integer exit code
