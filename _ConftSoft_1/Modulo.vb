Module Modulo
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public diretorio, sql As String
    Public banco = Application.StartupPath & "\banco_dados\BancoCS.mdb"
    Public resp As String
    Sub conecta_bd()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & banco)
            ' MsgBox("Conexao com o banco de dados Ok", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            MsgBox(banco)
        End Try
    End Sub
End Module
