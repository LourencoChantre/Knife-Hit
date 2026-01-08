Public Class Form1
    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Me.Hide()
        Settings.Show()
        MessageBox.Show("banana")
    End Sub
End Class
