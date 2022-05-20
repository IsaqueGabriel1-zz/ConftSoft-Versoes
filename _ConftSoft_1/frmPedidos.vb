Public Class frmPedidos

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If txtCel.Text = "" Or
               txtCliente.Text = "" Or
               txtDataPedido.Text = "" Or
               txtObs.Text = "" Or
               txtPedido.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "insert into tb_cliente (celularCliente, nomeCliente) values('" & txtCel.Text & "', '" & txtCliente.Text & "')"
                sql = "insert into tb_pedido (tipoPedido, dataPedido, obsPedido), values ('" & txtTipoPedido.Text & "', '" & txtDataPedido.Text & "', '" & txtObs.Text & "')"
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class