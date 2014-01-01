
// NOTE: If warnings appear, you may need to retarget this project to .NET 4.0. Show the Solution
// Pad, right-click on the project node, choose 'Options --> Build --> General' and change the target
// framework to .NET 4.0 or .NET 4.5.

module ProblemREVC.Main

open System

let compliment c =
    match c with
        | 'A' -> 'T'
        | 'C' -> 'G'
        | 'G' -> 'C'
        | 'T' -> 'A'
        | _ -> 'X'

[<EntryPoint>]
let main args = 

    let chars = args.[0].ToCharArray()
    
    let result =
        chars
        |> Array.rev
        |> Array.map compliment
        |> (fun s -> new String(s))
    
    printfn "%s" result

    0

