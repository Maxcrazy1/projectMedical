Class InHome

    'Setea que btn debe estar presionado en el menú
    Public Sub setPressButton(btn As Bunifu.Framework.UI.BunifuFlatButton)
        FrmPrincipal.BtnRegistrar.BorderStyle = BorderStyle.None
        FrmPrincipal.BtnLista.BorderStyle = BorderStyle.None
        FrmPrincipal.BtnDatos.BorderStyle = BorderStyle.None
        FrmPrincipal.BtnHistory.BorderStyle = BorderStyle.None

        btn.BorderStyle = BorderStyle.Fixed3D
    End Sub

    'Setea que btn estara activo dependiendo la condicion
    Public Sub SetBtnActiveDataPatientOrRegister(Optional activeBtnDatos As Boolean = True)
        If activeBtnDatos Then
            FrmPrincipal.BtnDatos.BringToFront()
            setPressButton(FrmPrincipal.BtnDatos)
        Else
            FrmPrincipal.BtnRegistrar.BringToFront()
        End If
    End Sub

    Public Sub GetRoleUserToCondition(role As Integer, nameUsr As String)
        Dim ctrlUsr As New CtrlUsers
        ctrlUsr.setRoleUsr(role)
        SetNameUser(nameUsr)
        SetObjectDependsRole(ctrlUsr.getRoleUsr())
    End Sub

    Private Sub SetNameUser(nameUsr As String)
        FrmPrincipal.lblNameUsr.Text = nameUsr
        SetTitleAndCenter(nameUsr, FrmPrincipal.lblNameUsr)
    End Sub

    Private Sub SetObjectDependsRole(typeRoleStatus As String)
        Dim frmMain = FrmPrincipal
        If typeRoleStatus = "Administrador" Then
            frmMain.imgRole.BackgroundImage = My.Resources.Admin
            frmMain.lblRoleUser.Text = "Administrador"
            SetTitleAndCenter("Administrador", frmMain.lblRoleUser)
        Else
            frmMain.imgRole.BackgroundImage = My.Resources.sub_admin
            frmMain.btnSettings.Visible = False
            frmMain.lblRoleUser.Text = "Sub-Administrador"
            SetTitleAndCenter("Sub-Administrador", frmMain.lblRoleUser)
        End If
    End Sub
End Class
