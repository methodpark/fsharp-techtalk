type User = 
    { Email : string
      Age : int32 }

let u = 
    { Email = "foo@bar"
      Age = -1 }

type MailAddress = 
    | MailAddress of string

let createMail (s : string) = 
    if System.Text.RegularExpressions.Regex.IsMatch(s, @"^\S+@\S+\.\S+$") then Some(MailAddress s)
    else None

type SafeUser = 
    { Email : MailAddress
      Age : int32 }

let createUser (email, age) = 
    let mail = createMail email
    match mail with
    | Some m -> 
        Some { Email = m;
               Age = age }
    | None -> None

createUser("mail", 12)