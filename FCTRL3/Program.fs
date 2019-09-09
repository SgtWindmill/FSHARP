open System

let factorial n = [1..n] |> Seq.fold (fun acc n -> acc * n) 1
     
let decimal d = 
    let j = d%10
    ((d - j) / 10) % 10

let rec FCTRL3 currTest maxTest =
    if currTest < maxTest then
        let s = Console.ReadLine()
        let value = Int32.Parse(s)
        if value < 10 then
            Console.Write(decimal (factorial value))
            Console.Write(' ')
            Console.Write((factorial value)%10 )
            Console.WriteLine()
        else 
            Console.WriteLine("0 0")
        analyzeSittingPlace (currTest+1) maxTest
    
[<EntryPoint>]
let main argv =
    let T = Console.ReadLine()
    let n = Int32.Parse(T)
    FCTRL3 0 n
    0 // return an integer exit code