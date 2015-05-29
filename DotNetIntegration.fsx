// Easy use of the core .Net lib
open System

Console.WriteLine "Hello World" // <-- See?? No stupid ; and no ()

// Easy use of your beloved .NET libraries
#r "packages/Newtonsoft.Json.6.0.8/lib/net40/Newtonsoft.Json.dll"

open Newtonsoft.Json

type Thingy = 
    { Name : string
      Skill : int32 }

let t = 
    { Name = "Dat thing"
      Skill = 99 }

let s = JsonConvert.SerializeObject t

// nicer printing with compiler support!
printfn "Hello World %A" [ 1; 2; 3 ]
//printfn "Hello World %d" "1 2 3"
