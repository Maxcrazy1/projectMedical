Imports System.IO

Public Class PnlHeman_2
    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Alt + Keys.Right Then
            nextStep()
        ElseIf keyData = Keys.Alt + Keys.Left Then
             beforeStep()
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
        Return False
    End Function

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        nextStep()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        beforeStep()
    End Sub

    Private Sub nextStep()
        GetValuesHistory(Me)
        loadFirstDataInRichtxt()
        FrmPrincipal.PnlHeman_Final1.BringToFront()
        FirstInputFocus(FrmPrincipal.PnlHeman_Final1)
    End Sub

    Private Sub beforeStep()
        FrmPrincipal.PnlHeman_11.BringToFront()
        FirstInputFocus(FrmPrincipal.PnlHeman_11)
    End Sub
    
End Class
