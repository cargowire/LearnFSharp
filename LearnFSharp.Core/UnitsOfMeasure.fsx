// Script file run in the F# Interactive window by hitting 'Alt-Enter' over selected code
[<Measure>] // Define your own measures
type km

[<Measure>]
type mile

[<Measure>]
type h

let maxSpeed = 50.0<km/h> // using measures based on measures
let actualSpeed = 40.0<mile/h>

(*
// F# will not allow mixing and matching of units of measure
if (actualSpeed > maxSpeed) then
    printf "Speeding!";
*)