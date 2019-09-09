open System
                                    
let rec FR_03_15 currTest maxTest =
    if currTest < maxTest then
        let values = Console.ReadLine().Split(' ') |> Array.map double |> Array.toList
        let a = values.Item(0)
        let b = values.Item(1)
     
        if (a <= b) then
            let side = (a+b)/2.0
            let side2 =(b-a)/2.0

            let h = sqrt(side * side - side2 *side2)
            let result = ( a + b ) * h / 2.0

            Console.WriteLine(Math.Round(result,2))
        if (b < a) then
            let side = (b+a)/2.0
            let side2 =(a-b)/2.0
            let h = sqrt(side * side - side2 *side2)
            let result = ( a + b ) * h / 2.0

            Console.WriteLine(Math.Round(result,2))
        FR_03_15 (currTest+1) maxTest
                                    
[<EntryPoint>]
let main argv =
    let T = Console.ReadLine()
    let numCases = Int32.Parse(T)
    FR_03_15 0 numCases
    0 // return an integer exit code