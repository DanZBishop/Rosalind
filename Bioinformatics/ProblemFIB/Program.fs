
// NOTE: If warnings appear, you may need to retarget this project to .NET 4.0. Show the Solution
// Pad, right-click on the project node, choose 'Options --> Build --> General' and change the target
// framework to .NET 4.0 or .NET 4.5.

module ProblemFIB.Main

open System

[<EntryPoint>]
let main args = 

    let time = int(args.[0])
    let initial = int64(args.[1])

    let generation =
        Seq.unfold (fun state -> Some(snd state + fst state * initial, (snd state, snd state + fst state * initial))) (int64(1),int64(1))

    generation
    |> Seq.take (time-2)
    |> Seq.last
    |> printfn "%i"

    0
