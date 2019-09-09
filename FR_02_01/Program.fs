open System
                                    
let rec FR_02_01 =
    let values = Console.ReadLine().Split(' ') |> Array.map double |> Array.toList
    let x1 = values.Item(0)
    let y1 = values.Item(1)
    let x2 = values.Item(2)
    let y2 = values.Item(3)
    let x3 = values.Item(4)
    let y3 = values.Item(5)

    let t0 = 2.0 * (x2 - x1)
    let t1 = 2.0 * (y2 - y1)
    let t2 = x1 * x1 + y1 * y1
    let t3 = x2 * x2 + y2 * y2 - t2
    let t4 = 2.0 * (x3 - x1)
    let t5 = 2.0 * (y3 - y1)
    let t6 = x3 * x3 + y3 * y3 - t2
    let x0 = (t6 * t1 - t5 * t3) / (t4 * t1 - t0 * t5)
    let y0 = (t6 * t0 - t4 * t3) / (t5 * t0 - t4 * t1)

    let r = sqrt((x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0))

    let wynik = Math.Round(r, 2)
    
    Console.WriteLine(String.Format("{0:0.00}", wynik))
                                    
[<EntryPoint>]
let main argv =
    FR_02_01
    0 // return an integer exit code