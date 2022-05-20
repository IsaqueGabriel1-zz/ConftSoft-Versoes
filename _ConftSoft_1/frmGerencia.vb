Public Class frmGerencia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCadastro.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        frmCadastro.Close()
    End Sub
End Class