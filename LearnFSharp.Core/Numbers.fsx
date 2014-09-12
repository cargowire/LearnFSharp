// Script file run in the F# Interactive window by hitting 'Alt-Enter' over selected code
open System // .NET framework namespaces can be 'opened' for use within a F#

// Lambda calculus style definition: (λa.λb.a+b)
let add a b = // define the function 'add' with the parameters 'a' and 'b' that returns a string (implied by last line)
    let res = a + b // define the symbol 'res' as equal to the addition of 'a' and 'b'
    String.Format("{0} + {1} = {2}", a, b, res) // use the .net framework to format the string and return it