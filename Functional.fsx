
type Person = {
    Name: string;
    Age: int
}

// No fuzz initialization
let m = {Name = "John"; Age = 67}

// Free (like in free beer) equality!!1!elf

(m = {Name = "John"; Age = 67})

(m = {Name = "Jane"; Age = 67})

open System
open System.IO

(new DirectoryInfo(Environment.CurrentDirectory)).GetFiles()
|> Seq.filter (fun l -> l.Length < 100L)
|> Seq.map (fun f -> f.Name)


// Composing functions is just a breeze

let upperCase (s: string) = s.ToUpperInvariant()

let noSpaces (s: string) = s.Replace(" ", String.Empty)

let f = upperCase >> noSpaces

f "Nathan Drake"

// pattern matching!!!
type FB = 
    | Fizz
    | Buzz
    | FizzBuzz
    | Number of int

HERE
let fb n =
    match n with
    | _ when n / 3 = 0 -> Fizz
    | _ -> Number n