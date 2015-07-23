
// Yah, you saw it all the way... ;-)

// So, why learn F#?

// Gives you a handy calculator directly in Visual Studio:
(42. * 3.) / 6.5

// even a typesafe calculator
[<Measure>] type degC
[<Measure>] type degF

let convertDegCToF c = 
    c * 1.8<degF/degC> + 32.0<degF>

convertDegCToF 32.<degC>

// Use it to explore the std .NET lib when in Visual Studio:

// play around with your own stuff:
#r "CsharpLib/bin/Debug/CsharpLib.dll"

open CsharpLib

let o = SomeCsharpClass (Name = "John Doe")
o

// Some other interesting usages can be found here:
// http://fsharpforfunandprofit.com/posts/low-risk-ways-to-use-fsharp-at-work/

// probe the std lib:
// what do these calls do?
open System.IO
new FileInfo("")
new FileInfo(@"\n")

// and many more cool things:
// http://fsharpforfunandprofit.com/
// Testing: https://fscheck.github.io/FsCheck/ 
// Enterprise: http://fsharp.org/guides/enterprise/
// Data Science: http://fsharp.org/guides/data-science/
// Machine Learning: http://fsharp.org/guides/machine-learning/
// Mobile apps and Games: http://fsharp.org/guides/apps-and-games/
// ...

(* What can feel odd:
- Syntax, in case you're not used to ML:
    Is it ( or {, is it = or :, is it ',' or ';', ...
- Module System has its oddities
- Manual build order of files
- No modules in folders, unlike C# or Java
*) 