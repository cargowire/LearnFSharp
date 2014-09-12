// Script file run in the F# Interactive window by hitting 'Alt-Enter' over selected code
#light "off" // turning off 'light' mode enforces a more explicit syntax with regard to scope

let number = 42 in
(
    printfn "%d" number;
    let message = "Answer: " + number.ToString() in
    (
        printfn "%s" message
    )
)