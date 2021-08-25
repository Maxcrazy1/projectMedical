Public Class PnlRegistro
    Private ctrlPnl As New InPnlRegister

    Private Sub PnlRegistro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        limitMaxLenghtTxt(TxtCed, 10)
        limitMaxLenghtTxt(TxtNom, 80)
        limitMaxLenghtTxt(TxtApe, 80)
        limitMaxLenghtTxt(TxtCorreo, 50)
        limitMaxLenghtTxt(TxtNro, 30)
        dateFirstConsultation.Value = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub 'El Load

    Private Sub TxtCed_Enter(sender As Object, e As EventArgs) Handles TxtCed.Enter
        rePaintColor({Me.TxtCed})
    End Sub

    Private Sub TxtNom_Enter(sender As Object, e As EventArgs) Handles TxtNom.Enter
        rePaintColor({Me.TxtNom})
    End Sub

    Private Sub TxtApe_Enter(sender As Object, e As EventArgs) Handles TxtApe.Enter
        rePaintColor({Me.TxtApe})
    End Sub

    Private Sub TxtCed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCed.KeyPress
        IsOnlyNumber(sender, e)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ctrlPnl.validateFormRegister(Me) Then
            If (btnEliminar.Enabled = True) Then
                ctrlPnl.FillDataPatientToUpdate(FrmPrincipal.cedula)
            Else
                ctrlPnl.FillArrayToSavePatient()
            End If
        Else
            MsgBox("LOS CAMPOS RESALTADOS REQUIEREN INFORMACIÓN", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ctrlPnl.NewRegister()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿DESEA ELIMINAR TODOS LOS REGISTROS DEL PACIENTE?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ctrlPnl.deletePatient({FrmPrincipal.cedula})
        End If
    End Sub

    Private Sub TxtCorreo_Leave(sender As Object, e As EventArgs) Handles TxtCorreo.Leave
        If Not (ctrlPnl.IsValidEmail(TxtCorreo.Text)) Then
            MsgBox("FORMATO DE EMAIL INVALIDO", MsgBoxStyle.Exclamation)
            TxtCorreo.Focus()
        End If
    End Sub


    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAge.KeyPress
        IsOnlyNumber(Me, e)
    End Sub
End Class
