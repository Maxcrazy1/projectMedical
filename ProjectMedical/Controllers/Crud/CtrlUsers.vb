Public Class CtrlUsers
    Private crudCtrl As New ctrlCrud
    Private History As New History
    Private role As Integer

    Public Sub setRoleUsr(role As Integer)
        MyClass.role = role
    End Sub

    Public Function getRoleUsr()
        Select Case MyClass.role
            Case 0
                Return "Administrador"
            Case 1
                Return "SubAdministrador"
        End Select

        Return MyClass.role
    End Function

    Public Sub storeUser(arrayData As String)
        rePaintColor({FrmPrincipal.PnlSettings1.txtUser, FrmPrincipal.PnlSettings1.txtConfirmedPass})
        crudCtrl.sendPetition("REGISTER", "users", arrayData, "EL USUARIO HA SIDO REGISTRADO CORRECTAMENTE")
    End Sub

    'Actualizar datos de paciente
    'FieldId = Cédula almacenada en la bd
    Public Sub updateUser(ByVal fieldId As String, arrayData As String)
        crudCtrl.sendPetition("UPDATE", "users", arrayData, "DATOS DEL USUARIO ACTUALIZADOS", "id=" & fieldId & "")
    End Sub



    'Extrae todos los usuarios de la DB
    Public Function getUsers() As DataTable
        Return crudCtrl.getResultsBD("SELECT * FROM users", True)
    End Function


    'Obtiene todos los detalles de un paciente
    Public Function getUser(id As Integer) As Object
        Dim arrayData() As Object = {}

        Dim usersData = crudCtrl.getResultsBD("SELECT * FROM users WHERE ID =" & id & "", False, "users")
        Dim data = usersData.Tables("users").Rows(0)
        Return {usersData, data}

    End Function



    ''Metodo Delete
    Public Sub deleteUser(ByVal ids() As Integer)
        For Each i As String In ids
            crudCtrl.sendPetition("DELETE", "users", "", "", "Id ='" & i & "'")
        Next

        Dim Msg = If(ids.Length() = 1, "EL USUARIO HA SIDO ELIMINADO", "LOS USUARIOS HAN SIDO ELIMINADOS")
        MsgBox(Msg, MsgBoxStyle.Information, "REGISTROS ELIMINADOS")
    End Sub



End Class
