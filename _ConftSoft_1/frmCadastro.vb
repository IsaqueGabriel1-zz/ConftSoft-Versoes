Public Class frmCadastro
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Sub Limpar_dados()
        txt_confiSenha.Text = ""
        txt_email.Text = ""
        txt_nivelAcesso.Text = ""
        txt_nomeUser.Text = ""
        txt_senha.Text = ""
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If txt_nomeUser.Text = "" Or txt_email.Text = "" Or txt_senha.Text = "" Or txt_confiSenha.Text = "" Or txt_nivelAcesso.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                If txt_senha.Text = txt_confiSenha.Text Then
                    sql = "select * from tb_cadastro where email = '" & txt_email.Text & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = True Then
                        sql = "insert into tb_cadastro (Email, nomeUser, senha, nivelAcesso) 
                               values ('" & txt_email.Text & "', '" & txt_nomeUser.Text & "', '" & txt_senha.Text & "', " &
                               "'" & txt_nivelAcesso.Text & "')"
                        rs = db.Execute(sql)
                        MsgBox("Cadastro realizado com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        resp = MsgBox("Deseja realizar um novo cadastro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Novo Cadastro")
                        If vbYesNo = True Then
                            Limpar_dados()
                        Else
                            Me.Close()
                        End If
                    Else
                        MsgBox("Estas informações ja foram cadastradas no sistema!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Limpar_dados()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro de ")
        End Try
    End Sub

End Class