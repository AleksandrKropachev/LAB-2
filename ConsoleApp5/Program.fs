open System


let romanToInt roman =
    match roman with
    | "I"    -> 1
    | "II"   -> 2
    | "III"  -> 3
    | "IV"   -> 4
    | "V"    -> 5
    | "VI"   -> 6
    | "VII"  -> 7
    | "VIII" -> 8
    | "IX"   -> 9
    | _      -> 0

let chet number =
    number % 2 = 0

let addRoman sm roman =
    sm + romanToInt roman


[<EntryPoint>]
let main argv =

    // ===== ЗАДАНИЕ 1 =====
    printf "Введите числа через пробел: "
    let inputNumbers = Console.ReadLine()

    let numbers =
        inputNumbers.Split(' ')
        |> Array.toList
        |> List.map int

    let chetList =
        numbers
        |> List.map chet

    printfn "Исходный список: %A" numbers
    printfn "Список true/false: %A" chetList
    printfn ""


    // ===== ЗАДАНИЕ 2 =====
    printf "Введите римские числа (I–IX) через пробел: "
    let inputRomans = Console.ReadLine()

    let romanList =
        inputRomans.Split(' ')
        |> Array.toList

    let sum =
        romanList
        |> List.fold addRoman 0

    printfn "Список римских чисел: %A" romanList
    printfn "Сумма в десятичной системе: %d" sum

    0