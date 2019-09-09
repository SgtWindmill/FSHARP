open System
                                    
let rec MWPZ06A currTest maxTest =
    if currTest < maxTest then
        let values = Console.ReadLine().Split(' ') |> Array.map double |> Array.toList
        let X = values.Item(0)
        let Y = values.Item(1)
        let Z = values.Item(2)
        let wynik = (X + Y - Z * Y) * -12.0 / (Z - 1.0)
        Console.WriteLine(int32(wynik + 0.5))
        MWPZ06A (currTest+1) maxTest
        
                                    
[<EntryPoint>]
let main argv =
    let T = Console.ReadLine()
    let numCases = Int32.Parse(T)
    MWPZ06A 0 numCases
    0 // return an integer exit code