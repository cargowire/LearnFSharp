// Script file run in the F# Interactive window by hitting 'Alt-Enter' over selected code
open System // .NET framework namespaces can be 'opened' for use within a F#
open System.Drawing

// Discriminated unions offer a fixed set of 'constructors'
type Shape =
    | Rectangle of Point * Point
    | Ellipse of Point * Point
    | Composed of Shape * Shape

// Simple area helper functions, types can be specified as name:type
let rectangleArea(pFrom:Point, pTo:Point) =
    let width = Math.Abs pFrom.X - pTo.X
    let height = Math.Abs pFrom.Y - pTo.Y
    (float width) * (float height)

let ellipseArea(pFrom:Point, pTo:Point) =
    let xRadius = Math.Abs pFrom.X - pTo.X
    let yRadius = Math.Abs pFrom.Y - pTo.Y
    Math.PI * (float xRadius) * (float yRadius)

let isNestedRectangle(from1:Point, to1:Point, from2:Point, to2:Point) = 
    from1.X >= from2.X && to1.X <=  to2.X && 
        from1.Y >= from2.Y && to1.Y <=  to2.Y

let intersectionArea(shape1:Shape, shape2:Shape) = 
    (float 0) // Not implemented

// Pattern matching allows program flow based on matched types leading to specific code
let rec shapeArea shape =
    match shape with
    | Rectangle(pFrom, pto) -> rectangleArea(pFrom, pto)
    | Ellipse(pFrom, pto) -> ellipseArea(pFrom, pto) // 'when' allows for additional filtering in the pattern
    | Composed(Rectangle(from1, to1), Rectangle(from2, to2))
        when isNestedRectangle(from2, to2, from1, to1) -> rectangleArea(from1, to1)
    | Composed(shape1, shape2) -> 
        let area1 = shapeArea(shape1)
        let area2 = shapeArea(shape2)
        area1 + area2 - (intersectionArea(shape1, shape2))