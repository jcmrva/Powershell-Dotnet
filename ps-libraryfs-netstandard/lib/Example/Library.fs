namespace Example


type ClassName(name: string) =

    member __.Greeting() = printfn "Hello %s" name

    static member FsHello = "Hello from F#"

module Math = 
    
    let cube x = x * x * x