namespace Learning // The following code will be placed in the Learning namespace

open System.Drawing // .NET framework namespaces can be 'opened' for use within a F#
open System.Windows.Forms

// Define a type
type HelloWindow() = 
    // Private symbols
    let frm = new Form(Width = 400, Height = 140)
    let fnt = new Font("Times New Roman", 28.0f)
    let lbl = new Label(Dock = DockStyle.Fill, Font = fnt,
                    TextAlign = ContentAlignment.MiddleCenter)

    // 'do' executes code independently of a function or value definition e.g. module initialization, class initialization
    do frm.Controls.Add(lbl)

    // Public functions
    member x.SayHello(name) = 
        let msg = "Hello " + name + "!"
        lbl.Text <- msg

    member x.Run() =
        Application.Run(frm)

    member x.Show() =
        frm.Show()