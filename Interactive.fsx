
// Yah, you saw it all the way... ;-)

// So, why learn F#?
// If only to use it to explore the std .NET lib when in Visual Studio:

// play around with your own stuff:
#r "CsharpLib/bin/Debug/CsharpLib.dll"

open CsharpLib

let o = SomeCsharpClass (Name = "John Doe")
o

// probe the std lib:
// what do these calls do?
open System.IO
new FileInfo("")
new FileInfo(@"\n")

// and many more cool things:
// http://fsharpforfunandprofit.com/
// Enterprise: http://fsharp.org/guides/enterprise/
// Data Science: http://fsharp.org/guides/data-science/
// Machine Learning: http://fsharp.org/guides/machine-learning/
// Mobile apps and Games: http://fsharp.org/guides/apps-and-games/
// ...