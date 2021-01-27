Public Class PnlHistoryRegister
    Private History As New History
    Private CtrlListHistory As New InPnlListHistory
    Private media As New CtrlMedia

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        newHemanHistory()
        SetPnlHistory()
    End Sub

    Private Sub SetPnlHistory()
        If (TabHistory.SelectedIndex = 0) Then
            resetfieldsHistory()
            media.loadMedia()
            FrmPrincipal.PnlHistoria1.BringToFront()
        Else
            FrmPrincipal.PnlHeman_11.BringToFront()
        End If
    End Sub

    'Centra los textos
    Private Sub PnlHistoryRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetTitleAndCenter(lblRegister.Text, lblRegister)
    End Sub

 
    Private Sub BtnDeleteRegister_Click(sender As Object, e As EventArgs) Handles BtnDeleteRegister.Click
        Dim Msg = If(lstHistory.SelectedItems.Count() > 1 Or lstHeman.SelectedItems.Count > 1,
                     "¿DESEA ELIMINAR TODOS LOS REGISTROS DEL PACIENTE SELECCIONADOS?", "¿DESEA ELIMINAR EL REGISTRO DEL PACIENTE?")

        If MessageBox.Show(Msg, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If (lstHistory.SelectedItems.Count() > 1) Then
                InPnlHistory.deleteListHistory(lstHistory)
            Else
                InPnlHeman.deleteListHistory(lstHeman)
            End If
        End If
    End Sub


    Private Sub lstHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHistory.SelectedIndexChanged
        CtrlListHistory.lockBtnDeleteAndExport(Me.lstHistory)
    End Sub


    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim serviceExport As New ServiceExport
        Dim Msg = If(lstHistory.SelectedItems.Count() > 1,
                     "¿DESEA EXPORTAR A WORD LOS REGISTROS DEL PACIENTE SELECCIONADOS?", "¿DESEA EXPORTAR A WORD EL REGISTRO DEL PACIENTE?")

        If MessageBox.Show(Msg, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            serviceExport.SelectedToExport()
        End If
    End Sub

    Private Sub TabHistory_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabHistory.Selecting
        If (e.TabPage.Name = "TabHema") Then
            CtrlListHistory.FillList("HemanHistory")
            BtnExportar.Visible = False
            BtnDeleteRegister.Enabled = False
        Else
            BtnExportar.Enabled = False
            BtnExportar.Visible = True
            CtrlListHistory.FillList("StandardHistory")
        End If
    End Sub

    Private Sub lstHeman_DoubleClick(sender As Object, e As EventArgs) Handles lstHeman.DoubleClick
        Dim ctrlHeman As New HemanHistory
        ctrlHeman.getHemanHistory(sender.SelectedItems(0).Text)
        FrmPrincipal.PnlHeman_11.BringToFront()
    End Sub

    Private Sub lstHistory_MouseClick(sender As Object, e As MouseEventArgs) Handles lstHistory.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            MenuLeft.Show(Control.MousePosition)
        End If
    End Sub

    Private Sub lstHistory_DoubleClick(sender As Object, e As EventArgs) Handles lstHistory.DoubleClick
        CtrlListHistory.SetDataAndFormHistory(sender.SelectedItems(0).Text)
    End Sub

    Private Sub lstHeman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHeman.SelectedIndexChanged
        CtrlListHistory.lockBtnDeleteAndExport(Me.lstHeman)
    End Sub
End Class
