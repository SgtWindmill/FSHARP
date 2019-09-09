open System
                                    
let rec ETI06F1 =
 
    let values = Console.ReadLine().Split(' ') |> Array.map double |> Array.toList
    let r = values.Item(0)
    let d = values.Item(1)
    let pi = 3.141592654
    let wynik = -1.0*(((d / 2.0) * (d / 2.0)) - (r * r))
    let obw = Math.Round(pi * wynik, 2)
    Console.WriteLine(obw.ToString().Replace(',','.'))
                                    
[<EntryPoint>]
let main argv =
    ETI06F1
    0 // return an integer exit code