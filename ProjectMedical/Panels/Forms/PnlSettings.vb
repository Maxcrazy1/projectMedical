Public Class PnlSettings
    Private users As New InPnlSettings


    Private Sub lstUsers_DoubleClick(sender As Object, e As EventArgs) Handles lstUsers.DoubleClick
        users.SetDataUser(lstUsers.SelectedItems(0).Text)
        users.setIdUsr(lstUsers.SelectedItems(0).Text)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        users.SetNewDataAppConfig(txtUrl.Text)

        If users.conditionsToSaveUser() Then
            If (users.getIdUsr <> 0) Then
                users.FillDataUserToUpdate()
            Else
                users.FillDataUserToSave()
            End If
        End If
    End Sub

    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged
        If lstUsers.SelectedItems.Count > 0 Then
            btnEliminar.Enabled = True
        Else
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim ctrlUser As New CtrlUsers
        Dim Msg = If(lstUsers.SelectedItems.Count() > 1,
                    "¿DESEA ELIMINAR TODOS LOS REGISTROS DEL PACIENTE SELECCIONADOS?", "¿DESEA ELIMINAR EL REGISTRO DEL PACIENTE?")

        If MessageBox.Show(Msg, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            users.deleteUsersSelected(Me.lstUsers)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        users.BeforeSendPetition()
    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
        txtPass.isPassword = True
    End Sub

    Private Sub txtConfirmed_Enter(sender As Object, e As EventArgs) Handles txtConfirmedPass.Enter
        txtConfirmedPass.isPassword = True
    End Sub
End Class
