namespace Example


type ClassName(name: string) =

    member __.Greeting() = printfn "Hello %s" name

    static member FsHello = "Hello from F#"

module Math = 
    
    let cube x = x * x * x

module FsTypes = 

    type DU = | Aaa | B of string | C of string * int | ``D e``

    // mutable fields have unusual behavior: the PS table shows two (Union, Union@)
    type MyRecord = {
        Name : string
        Union : DU
    }

    let createMyRec (n, u) = 
        {
            Name = n
            Union = match u with
                    | "Tag" -> Aaa
                    | "String" -> B u
                    | _ -> ``D e``
        }

    let createMyRecList (al:System.Collections.ArrayList) =
        al 
        |> Seq.cast
        |> Seq.map (fun s -> createMyRec (s, s))
        |> List.ofSeq
           

    let r = {
        Name = "Record example"
        Union = C ("tuple item 1", 3)
    }
