Public Class Form1
    Private Sub btnLogar_Click(sender As Object, e As EventArgs) Handles btnLogar.Click
        Try
            If txtNome.Text = "" And txtSenha.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "select * from tb_cadastro where nomeUser = '" & txtNome.Text & "' AND senha = '" & txtSenha.Text & "'"
                rs = db.Execute(UCase(sql))
                If rs.EOF = False Then
                    frmGerencia.Show()
                Else
                    txtNome.Text = ""
                    txtSenha.Text = ""
                    lblErroSenha.Visible = True
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_bd()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        NovaSenha.Show()
    End Sub

    Private Sub txtNome_MouseClick(sender As Object, e As MouseEventArgs) Handles txtNome.MouseClick
        lblErroSenha.Visible = False
    End Sub
End Class