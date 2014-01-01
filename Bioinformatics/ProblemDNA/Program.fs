
// NOTE: If warnings appear, you may need to retarget this project to .NET 4.0. Show the Solution
// Pad, right-click on the project node, choose 'Options --> Build --> General' and change the target
// framework to .NET 4.0 or .NET 4.5.

module ProblemDNA.Main

open System

[<EntryPoint>]
let main args = 
    let result =
        args.[0]
        |> Seq.countBy(fun c -> c)
        |> Map.ofSeq

    printfn "%i %i %i %i" result.['A'] result.['C'] result.['G'] result.['T']

    0