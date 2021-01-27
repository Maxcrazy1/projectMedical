Imports System.IO

Public Class PnlHeman_Final
    Private ctrlMedia As New CtrlMedia
    Private actionsPnl As New ActionsFormHistory

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles complic.Click
        SetTitleAndSetValueHistory("Información de las complicaciones", sender.Name)
    End Sub


    Private Sub BtnAntPer_Click(sender As Object, e As EventArgs) Handles Ulcer.Click
        SetTitleAndSetValueHistory("Información de las ulceraciones", sender.Name)
    End Sub


    Private Sub infec_Click(sender As Object, e As EventArgs) Handles infec.Click
        SetTitleAndSetValueHistory("Información de las infecciones", sender.Name)
    End Sub


    Private Sub otros_Click(sender As Object, e As EventArgs) Handles otros.Click
        SetTitleAndSetValueHistory("Otras informaciones", sender.Name)
    End Sub

    Private Sub trata_Click(sender As Object, e As EventArgs) Handles trata.Click
        SetTitleAndSetValueHistory("Información del tratamiento", sender.Name)
    End Sub


    Private Sub Estero_Click(sender As Object, e As EventArgs) Handles Estero.Click
        SetTitleAndSetValueHistory("Información de Esteroides", sender.Name)
    End Sub


    Private Sub Topicos_Click(sender As Object, e As EventArgs) Handles Topicos.Click
        SetTitleAndSetValueHistory("Información de los tópicos", sender.Name)

    End Sub
    Private Sub Intra_Click(sender As Object, e As EventArgs) Handles Intra.Click
        SetTitleAndSetValueHistory("Información de intralesional", sender.Name)
    End Sub

    Private Sub Siste_Click(sender As Object, e As EventArgs) Handles Siste.Click
        SetTitleAndSetValueHistory("Información de sistemico", sender.Name)

    End Sub

    Private Sub Interf_Click(sender As Object, e As EventArgs) Handles Interf.Click
        SetTitleAndSetValueHistory("Información del interferon", sender.Name)
    End Sub

    Private Sub Vinc_Click(sender As Object, e As EventArgs) Handles Vinc.Click
        SetTitleAndSetValueHistory("Información de vincristina", sender.Name)

    End Sub

    Private Sub Embol_Click(sender As Object, e As EventArgs) Handles Embol.Click
        SetTitleAndSetValueHistory("Información de la Embolización", sender.Name)
    End Sub

    Private Sub Quirur_Click(sender As Object, e As EventArgs) Handles Quirur.Click
        SetTitleAndSetValueHistory("Información del quirurgico", sender.Name)
    End Sub

    Private Sub Observ_Click(sender As Object, e As EventArgs) Handles Observ.Click
        SetTitleAndSetValueHistory("Observaciones", sender.Name)
    End Sub

    Private Sub BtnSaveHistory_Click(sender As Object, e As EventArgs) Handles BtnSaveHistory.Click
        handleClickHistory()
    End Sub

    Private Sub btnTop_Click(sender As Object, e As EventArgs) Handles btnTop.Click
        scrollForm(Me, 0)
    End Sub

    Private Sub txtFieldHistory_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFieldHistory.KeyDown
        setBlnMsgVerification(True)
        actionsPnl.bindKey(e)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BtnDeleteAll.Click
        txtFieldHistory.Text = ""
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        actionsPnl.copyText(txtFieldHistory)
    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        actionsPnl.pasteText(txtFieldHistory)
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        actionsPnl.selectAllText(txtFieldHistory)
    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BtnUndo.Click
        txtFieldHistory.Undo()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles btnRedo.Click
        txtFieldHistory.Redo()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        BackStep()
    End Sub


    Private Sub listFiles_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Control.MousePosition)
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btnNewRegister.Click
        newHemanHistory()
    End Sub

    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Alt + Keys.Left Then
            BackStep()
        ElseIf keyData = Keys.Control + Keys.N Then
            newHemanHistory()
        ElseIf keyData = Keys.Control + Keys.Enter Then
            handleClickHistory()
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
        Return Nothing
    End Function

    Private Sub BackStep()
        FrmPrincipal.PnlHeman_21.BringToFront()
        FirstInputFocus(FrmPrincipal.PnlHeman_21)
    End Sub

   
End Class
