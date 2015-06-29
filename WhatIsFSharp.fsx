(*
What is F#?

> F# is a mature, open source, cross-platform, functional-first programming language. 
> It empowers users and organizations to tackle complex computing problems with simple, maintainable and robust code.

-- F# Foundation http://fsharp.org/

Basically it's a ML, closely related to OCaml, for the .NET runtime designed by Microsoft (Research).

*)

let someValue = 42L

let someFunction (p1: string) = p1.ToUpper()

let rec fac n = 
    match n with
    | 0 -> 1
    | _ -> n * fac (n - 1)

