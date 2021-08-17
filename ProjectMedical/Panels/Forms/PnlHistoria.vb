Imports System.IO

Public Class PnlHistoria
    Private ctrlMedia As New CtrlMedia
    Private actionsPnl As New ActionsFormHistory

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles enfermedad.Click
        SetTitleHistoryInPnl("Información de la enfermedad actual", "enfermedad")
    End Sub

    Private Sub BtnMuc_Click(sender As Object, e As EventArgs) Handles mucosas.Click
        SetTitleHistoryInPnl("Información de las mucosas", "mucosas")
    End Sub

    Private Sub BtnAntPer_Click(sender As Object, e As EventArgs) Handles personales.Click
        SetTitleHistoryInPnl("Información de los antecedentes personales", "personales")
    End Sub

    Private Sub BtnAntFam_Click(sender As Object, e As EventArgs) Handles familiares.Click
        SetTitleHistoryInPnl("Información de los antecedentes familiares", "familiares")
    End Sub

    Private Sub BtnHabPsi_Click(sender As Object, e As EventArgs) Handles habitos.Click
        SetTitleHistoryInPnl("Información de los hábitos psicobiológicos", "hábitos")
    End Sub

    Private Sub BtnPiel_Click(sender As Object, e As EventArgs) Handles piel.Click
        SetTitleHistoryInPnl("Información de la piel", "piel")
    End Sub

    Private Sub BtnCueCab_Click(sender As Object, e As EventArgs) Handles cuero.Click
        SetTitleHistoryInPnl("Información del cuero cabelludo", "cuero")
    End Sub

    Private Sub BtnUnas_Click(sender As Object, e As EventArgs) Handles unas.Click
        SetTitleHistoryInPnl("Información de las uñas", "uñas")
    End Sub

    Private Sub BtnDx_Click(sender As Object, e As EventArgs) Handles DX.Click
        SetTitleHistoryInPnl("Información del DX", "DX")
    End Sub

    Private Sub BtnPlan_Click(sender As Object, e As EventArgs) Handles plan.Click
        SetTitleHistoryInPnl("Información del plan", "plan")
    End Sub

    Private Sub BtnCon_Click(sender As Object, e As EventArgs) Handles controles.Click
        SetTitleHistoryInPnl("Información de los controles", "controles")
    End Sub

    Private Sub BtnSaveHistory_Click(sender As Object, e As EventArgs) Handles BtnSaveHistory.Click
        evtClickSaveOrUpdate()
    End Sub

    Private Sub btnTop_Click(sender As Object, e As EventArgs) Handles btnTop.Click
        scrollForm(Me, 0)
    End Sub

    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Keys.Control + Keys.Enter Then
            evtClickSaveOrUpdate()
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
        Return False
    End Function

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

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        If (IsDropChangesInHistory()) Then
            resetfieldsHistory()
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btnAddFiles.Click
        ctrlMedia.saveMedia(openFiles)
    End Sub

    Private Sub listFiles_DoubleClick(sender As Object, e As EventArgs) Handles listFiles.DoubleClick
        ctrlMedia.deleteFiles(listFiles.SelectedItems(0).SubItems(0).Text)
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        ctrlMedia.openFolder()
    End Sub

    Private Sub listFiles_MouseClick(sender As Object, e As MouseEventArgs) Handles listFiles.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Control.MousePosition)
        End If
    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        ctrlMedia.deleteFiles(listFiles.SelectedItems(0).SubItems(0).Text)
    End Sub

    Private Sub PnlHistoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fieldDateConsultation.Value = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub
End Class
