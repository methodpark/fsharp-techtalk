
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