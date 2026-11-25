open System
open System.Drawing
open System.Windows.Forms

[<EntryPoint; STAThread>]
let main _ =

    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault(false)

    let form = new Form(
        Text = "Library Management System",
        Width = 1100,
        Height = 700,
        StartPosition = FormStartPosition.CenterScreen
    )

    Application.Run(form)

    0