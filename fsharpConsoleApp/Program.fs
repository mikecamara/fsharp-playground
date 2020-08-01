// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

//[<EntryPoint>]
//let main argv =
    //printfn "%A" argv
    //0 // return an integer exit code


// new code
module HelloSquare

let square x = x * x

[<EntryPoint>]
let main argv =
    printfn "%d squared is: %d!" 12 (square 12)
    0 // Return an integer exit code