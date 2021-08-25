Option Strict On
Imports BrightIdeasSoftware

Public Class PnlListado
    Private ctrlPnl As New InPnlLstPatients
    Private frmPatient As New InPnlRegister

    Private Sub SeleccionarVariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarVariosToolStripMenuItem.Click
        lstPatients.CheckBoxes = If(lstPatients.CheckBoxes = False, True, False)
    End Sub 'Activa el checkboxes

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim Patient As New Patient
        Dim Msg = If(lstPatients.CheckedItems.Count() > 1, "¿DESEA ELIMINAR TODOS LOS REGISTROS DE LOS PACIENTES SELECCIONADOS?", "¿DESEA ELIMINAR TODOS LOS REGISTROS DEL PACIENTE?")
        If MessageBox.Show(Msg, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ctrlPnl.deleteListPatients()
        End If
    End Sub 'Elimina estudiante o estudiantes seleccionados

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        lstPatients.ModelFilter = TextMatchFilter.Contains(lstPatients, txtSearch.Text)
    End Sub


    Private Sub olvSongs_MouseClick(sender As Object, e As MouseEventArgs) Handles lstPatients.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Control.MousePosition)
        End If
    End Sub


    Private Sub olvSongs_DoubleClick(sender As Object, e As EventArgs) Handles lstPatients.DoubleClick
        frmPatient.FillDataFieldsPatients(lstPatients.SelectedItems(0).SubItems(0).Text)
        FrmPrincipal.cedula = lstPatients.SelectedItems(0).SubItems(0).Text
        FrmPrincipal.PnlRegistro1.BringToFront()
    End Sub

End Class
