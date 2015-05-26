
// Direct use of your beloved .NET libraries
open System
Console.WriteLine "Hello World"

open System.IO

(new DirectoryInfo(Environment.CurrentDirectory)).GetFiles()
|> Seq.filter (fun l -> l.Length < 100L)
|> Seq.map (fun f -> f.Name)

// nicer printing with compiler support!
printfn "Hello World %A" [1; 2; 3]

// printfn "Hello World %d" "1 2 3"
