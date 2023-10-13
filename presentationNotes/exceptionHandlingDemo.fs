// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

//------------------------------------------------

exception Error1 of string
// Using a tuple type as the argument type.
exception Error2 of string * int

let function1 x y =
   try
      if x = y then raise (Error1("x"))
      else raise (Error2("x", 10))
   with
      | Error1(str) -> printfn "Error1 %s" str
      | Error2(str, i) -> printfn "Error2 %s %d" str i

//function1 10 10
//function1 9 2

//------------------------------------------------

let divide1 x y =
   try
      Some (x / y)
   with
      | :? System.DivideByZeroException -> printfn "Division1 by zero!"; None

let result1 = divide1 100 12

//------------------------------------------------

let divide x y =
   let stream : System.IO.FileStream = System.IO.File.Create("test.txt")
   let writer : System.IO.StreamWriter = new System.IO.StreamWriter(stream)
   try
      writer.WriteLine("test1")
      Some( x / y )
   finally
      writer.Flush()
      printfn "Closing stream"
      stream.Close()

let result =
  try
     divide 100 0
  with
     | :? System.DivideByZeroException -> printfn "Exception handled."; None

printfn "END"
