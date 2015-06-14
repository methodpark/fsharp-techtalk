// ------------------------------------------------------
// unit of measure
// ------------------------------------------------------
// https://msdn.microsoft.com/en-us/library/dd233243.aspx

[<Measure>]
type cm 

[<Measure>]
type m

let square (l: float<m>) = l * 2.

square 34.<m>

[<Measure>]
type euro

[<Measure>]
type cent

// ------------------------------------------------------
// type provider
// ------------------------------------------------------

#r "packages/FSharp.Data.2.2.2/lib/net40/FSharp.Data.dll"

open FSharp.Data
open System.Linq

type Person = JsonProvider<"resources/schema.json">

let s = "{ \"Name\": \"Paul\", \"Age\": 16 }"
let p = Person.Parse s

p.Age + 10


let wb = WorldBankData.GetDataContext()

let germany = wb.Countries.Germany

wb.Countries.Germany.Indicators.``Adjusted savings: carbon dioxide damage (% of GNI)``.Values
wb.Countries.China.Indicators.``Adjusted savings: carbon dioxide damage (% of GNI)``.Values                                

                                
germany.Indicators.``Cause of death, by communicable diseases and maternal, prenatal and nutrition conditions (% of total)``.Values
wb.Countries.Chad.Indicators.``Cause of death, by communicable diseases and maternal, prenatal and nutrition conditions (% of total)``.Values

// Kurzes Quiz der Hauptstädte
[wb.Countries.Albania; wb.Countries.Lithuania; wb.Countries.Haiti]
|> List.map (fun c -> c.CapitalCity)


// weitere Type Provider: SQL, XML, Configuration, Registry, ...
