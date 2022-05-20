Public Class NovaSenha
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If txtNome.Text = "" And txtSenha.Text = "" And txtConfi.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                If txtSenha.Text = txtConfi.Text Then
                    sql = "update tb_cadastro set senha = '" & txtSenha.Text & "' where nomeUser = '" & txtNome.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("Senha atualizada com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Me.Close()
                Else
                    lblerro.Visible = True
                    txtSenha.Text = ""
                    txtConfi.Text = ""
                    txtNome.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox("Um erro foi detectado ao iniciar o programa", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATEÇÃO")
        End Try
    End Sub

    Private Sub txtNome_MouseClick(sender As Object, e As MouseEventArgs) Handles txtNome.MouseClick
        lblerro.Visible = False
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class