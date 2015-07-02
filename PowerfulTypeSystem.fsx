type User = 
    { Email : string
      Age : int32 }


// Nothing keeps me from doing this:
let u = 
    { Email = "foo@bar"
      Age = -1 }






type MailAddress = 
    | MailAddress of string

let createMail (s : string) = 
    if System.Text.RegularExpressions.Regex.IsMatch(s, @"^\S+@\S+\.\S+$") then Some(MailAddress(s.ToLowerInvariant()))
    else None

type SafeUser = 
    { Email : MailAddress
      Age : int32 }

let createUser (email, age) = 
    let mail = createMail email
    match mail with
    | Some m -> 
        Some { Email = m
               Age = age }
    | None -> None

let mail = "bkn@methodpark.de"

createUser ("mail", 12)

let me = createUser (mail, 32)

me.Value.Email = (createMail mail).Value

// for further information see: 
// http://fsharpforfunandprofit.com/ddd/
// http://fsharpforfunandprofit.com/series/designing-with-types.html
// https://vimeo.com/album/3452190/video/131196782