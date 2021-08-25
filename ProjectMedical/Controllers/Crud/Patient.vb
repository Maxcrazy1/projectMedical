
Imports System.Configuration

Class Patient
    Public Property documentId As String
    Public Property namePatient As String
    Public Property lastName As String
    Public Property genre As String
    Public Property profession As String

    Private crudCtrl As New ctrlCrud

    Public Sub storePatient(ByVal arrayData As String, documentId As String) 'Metódo para almacenar un paciente
        crudCtrl.sendPetition("REGISTER", "patients", arrayData, "EL PACIENTE HA SIDO REGISTRADO CORRECTAMENTE")
    End Sub

    'Actualizar datos de paciente
    'FieldId = Cédula almacenada en la bd
    Public Sub updatePatient(ByVal fieldId As String, arrayData As String)
        crudCtrl.sendPetition("UPDATE", "patients", arrayData, "DATOS DEL PACIENTE ACTUALIZADOS", "id=" & getId(fieldId) & "")
    End Sub


    'Almacenar Contacto
    Public Sub storeContact(ByVal documentId As Integer, number As String)
        Dim arr As String = "null, '" & getId(documentId) & "', '" & number & "'"
        crudCtrl.sendPetition("REGISTER", "contact_user", arr, "")
    End Sub


    'Actualizar Contacto
    Public Sub updateContact(ByVal patientId As String, number As String)
        crudCtrl.sendPetition("UPDATE", "contact_user", "number='" & number & "'", "", "patient_id=" & getId(patientId) & "")
    End Sub


    'Extrae todos los pacientes de la DB
    Public Function getPatients() As DataTable
        Return crudCtrl.getResultsBD("SELECT * FROM patients", True, "")
    End Function


    'Obtiene todos los detalles de un paciente
    Public Function getPatient(document_id As String) As Object
        Dim arrayData() As Object = {}

        If getId(document_id) <> -1 Then
            Dim patientData = crudCtrl.getResultsBD("SELECT * FROM patients WHERE ID =" & getId(document_id) & "", False, "patients")
            Dim data = patientData.Tables("patients").Rows(0)
            arrayData = {patientData, data}
        End If

        Return arrayData
    End Function


    'Los datos de contacto de un user
    Public Sub getContact(ByVal id As Integer)
        Dim getQuery As String = "SELECT number FROM contact_user WHERE patient_id = " & id & ""
        FrmPrincipal.PnlRegistro1.TxtNro.DataBindings.Add("Text", crudCtrl.getResultsBD(getQuery, False, "contact_user"), "contact_user.number")
    End Sub


    'Obtiene el id a partir de la cedula
    Public Function getId(ByVal documentId As String) As Integer
        Dim id As Integer = -1
        Try
            Dim patientId As New DataSet
            patientId = crudCtrl.getResultsBD("SELECT id FROM patients where document_id = " & documentId & "", False, "patients")
            id = CInt(patientId.Tables(0).Rows(0).Item(0).ToString)
        Catch ex As Exception
        End Try
        Return id
    End Function

    'Metodo Delete
    Public Sub deletePatient(ByVal documentId() As String)
        Dim CtrlPnlListPatients As New InPnlLstPatients
        Dim ctrlRegister As New InPnlRegister
        Dim Media As New CtrlMedia
        Dim History As New History


        For Each i As String In documentId
            Media.deleteFolder(ConfigurationManager.AppSettings("pathFolderMain") &
                               getPatient(i)(1)("name".ToString) & " " &
                               getPatient(i)(1)("last_name".ToString))

            crudCtrl.sendPetition("DELETE", "patients", "", "", "Id ='" & getId(i) & "'")
            History.deleteHistory({getId(i)}, False)
        Next

        Dim Msg = If(documentId.Length() = 1, "EL PACIENTE HA SIDO ELIMINADO", "LOS PACIENTES HAN SIDO ELIMINADOS")
        MsgBox(Msg, MsgBoxStyle.Information, "REGISTROS ELIMINADOS")
    End Sub

End Class