open System
                                    
let rec analyzeSittingPlace currTest maxTest =
    if currTest < maxTest then
     let values = Console.ReadLine()
    let bit = BitConverter.ToString(BitConverter.GetBytes(values))
    Console.WriteLine(BitConverter.ToString(BitConverter.GetBytes(values)))


    analyzeSittingPlace (currTest+1) maxTest
                                    
[<EntryPoint>]
let main argv =
    let T = Console.ReadLine()
    let numCases = Int32.Parse(T)
    analyzeSittingPlace 0 numCases
    0 // return an integer exit code
    float32.Pars