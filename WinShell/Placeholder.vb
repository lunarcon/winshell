Public Class Placeholder
    Private Sub Placeholder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New Size(My.Computer.Screen.Bounds.Size)
        StartMenu.Show()
    End Sub
End Class