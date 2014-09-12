open Learning  // 'Using' namespaces can be 'opened' for use within a F#

[<EntryPoint>]
let main argv = 
    let hw = new HelloWindow()
    hw.SayHello("This is a test")
    hw.Run()
    0 // return an integer exit code