// Easy use of the core .Net lib
open System

Console.WriteLine "Hello World" // <-- See?? No stupid ; and no ()

// Interfaces, classes, everything is there. 
type SomeInterface = 
    abstract Foo : unit -> unit

type SomeClass() = 
    
    interface SomeInterface with
        member x.Foo() = printfn "Foo"
    
    interface System.IDisposable with
        member x.Dispose() = printfn "CU!"
do
    use c = new SomeClass()
    (c :> SomeInterface).Foo()


// -----------------------------------------------------------------------
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



open System.Net

let fetch (u : string) = 
    use client = new WebClient()
    client.DownloadString(u)

fetch "http://google.com"

let fetchAsync u = async { return fetch u }
let a = fetchAsync "http://google.com"
let urls = [ "http://google.com"; "http://yahoo.com"; "http://bing.com" ]

let rs = 
    urls
    |> List.map fetchAsync
    |> Async.Parallel
    |> Async.RunSynchronously
    |> Array.toList
    |> List.map (fun s -> s.Length)

let m = (Seq.max rs)

List.zip urls (rs |> List.map (fun u -> (float (u) / (float (m) / 100.))))