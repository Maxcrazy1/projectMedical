Imports System.IO

Public Class PnlHeman_1

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        nextStep()
    End Sub

    Private Sub nextStep()
        GetValuesHistory(Me)
        FrmPrincipal.PnlHeman_21.BringToFront()
        FirstInputFocus(FrmPrincipal.PnlHeman_21)
    End Sub

    Private Sub PnlHeman_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateFirstConsultation.Value = Date.Now
    End Sub

    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Alt + Keys.Right Then
            nextStep()
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
        Return False
    End Function
End Class
