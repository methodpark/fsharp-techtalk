
// Direct use of your beloved .NET libraries
open System
Console.WriteLine "Hello World"

#r "/home/b6n/dev/FsharpTechTalk/packages/Newtonsoft.Json.6.0.8/lib/net40/Newtonsoft.Json.dll"

type Thingy = {
    Name : string;
    Skill : int32
}

open Newtonsoft.Json

let t = {Name = "Dat thing"; Skill = 99}

JsonConvert.SerializeObject t


// nicer printing with compiler support!
printfn "Hello World %A" [1; 2; 3]

// printfn "Hello World %d" "1 2 3"
