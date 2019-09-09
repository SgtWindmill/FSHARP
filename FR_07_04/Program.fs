open System
                                    
let rec FR_07_04 currTest maxTest =
    if currTest < maxTest then
        let values = Console.ReadLine().Split(' ') |> Array.map float |> Array.toList
        let obnizka = values.Item(0) + ((100.00 - values.Item(0)) * (values.Item(1)/100.00))
        Console.WriteLine(obnizka.ToString(".00"))
        FR_07_04 (currTest+1) maxTest
                                    
[<EntryPoint>]
let main argv =
    let D = Console.ReadLine()
    let numCases = Int32.Parse(T)
    FR_07_04 0 numCases
    0 // return an integer exit code