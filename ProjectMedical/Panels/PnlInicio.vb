Option Strict On

Public Class PnlInicio

    Private Sub PnlInicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LblFecha.Text = Format(Now(), "long date")
        LblHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        LblFecha.Left = CInt((Me.Width - LblFecha.Width) / 2)

        'Start()
        LblHora.Left = CInt((Me.Width - LblHora.Width) / 2)
        RectangleShape2.Width = LblFecha.Width
        RectangleShape2.Left = CInt((Me.Width - LblFecha.Width) / 2)

    End Sub 'Asignación de fecha y hora ademas posiciones centradas de cada objeto

End Class
