type Person = 
    { Name : string
      Age : int }

// No fuzz initialization
let m = 
    { Name = "John"
      Age = 67 }

(// Free (like in free beer) equality!!1!elf
 m = { Name = "John"
       Age = 67 })
(m = { Name = "Jane"
       Age = 67 })

open System
open System.IO

(new DirectoryInfo(Environment.CurrentDirectory)).GetFiles()
|> Seq.filter (fun l -> l.Length < 100L)
|> Seq.map (fun f -> f.Name)

// Composing functions is just a breeze
let upperCase (s : string) = s.ToUpperInvariant()
let noSpaces (s : string) = s.Replace(" ", String.Empty)
let f = upperCase >> noSpaces

f "Nathan Drake"

// pattern matching!!!
type FB = 
    | Fizz
    | Buzz
    | FizzBuzz
    | Number of int

let (|MultOf3|_|) n = 
    if n % 3 = 0 then Some MultOf3
    else None

let (|MultOf5|_|) n = 
    if n % 5 = 0 then Some MultOf5
    else None

let fb n = 
    match n with
    | MultOf3 & MultOf5 -> FizzBuzz
    | MultOf3 -> Fizz
    | MultOf5 -> Buzz
    | _ -> Number n

[ 1..100 ] |> List.map fb