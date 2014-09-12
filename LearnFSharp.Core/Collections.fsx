// Script file run in the F# Interactive window by hitting 'Alt-Enter' over selected code
let numbers = [1..10] // Shorthands are provided to create lists from ranges
let isOdd(n) = n % 2 = 1 // define a function that takes a parameter 'n' and returns true if it is odd otherwise false
let square(n) = n * n // define a function that takes a parameter 'n' and returns 'n' multiplied by 'n'

// Higher-order functions - A function that takes a function as a parameter or returns it as a result
let oddNumbers = List.filter isOdd numbers
let squaredNumbers = List.map square numbers