
// NOTE: If warnings appear, you may need to retarget this project to .NET 4.0. Show the Solution
// Pad, right-click on the project node, choose 'Options --> Build --> General' and change the target
// framework to .NET 4.0 or .NET 4.5.

module ProblemRNA.Main

open System

[<EntryPoint>]
let main args = 
    let result = args.[0].Replace("T", "U")

    printfn "%s" result

    0
