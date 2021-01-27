Class History
    Public Property historyId As String
    Public Property folderPatient As String

    Public Sub setHistoryId(id As Integer)
        FrmPrincipal.historyId = id
    End Sub

    Public Function getHistoryId()
        Return FrmPrincipal.historyId
    End Function

    'Guarda un registro en la historia
    Public Sub saveHistory(fields As String)
        Dim ctrl As New ctrlCrud
        ctrl.sendPetition("REGISTER", "patient_history", fields, "LOS DATOS DE LA HISTORIA HAN SIDO ALMACENADOS CORRECTAMENTE")
        setHistoryId(getBDHistoryId("id", "patient_history"))
    End Sub

    'Actualiza los datos de la historia
    Public Sub updateHistory(fields)
        Dim ctrl As New ctrlCrud

        ctrl.sendPetition("UPDATE", "patient_history", fields, "SE HA AÑADIDO LA INFORMACIÓN EN EL REGISTRO DE LA HISTORIA CORRECTAMENTE",
                       "id='" & getHistoryId() & "'")
    End Sub

    'Obtiene los datos de la historia desde la bd
    Public Function getHistory(idRegister As String)
        Dim ctrl As New ctrlCrud

        Dim historyData As New DataSet
        Dim data As Object = {}

        historyData = ctrl.getResultsBD("select * from patient_history where id=" & idRegister, False, "patient_history")

        If historyData.Tables("patient_history").Rows.Count > 0 Then
            data = historyData.Tables("patient_history").Rows(0)
        End If

        Return data
    End Function

    'Obtiene todos los registros de la BD de un paciente
    Public Function getHistories(patient_id As String) As DataTable
        Dim ctrl As New ctrlCrud
        Dim patient As New Patient

        Return ctrl.getResultsBD("SELECT *, DATE_FORMAT(date_medical,'%d/%m/%Y') AS dateFormat FROM patient_history where patient_id=" &
                          patient.getId(patient_id), True)
    End Function

    'Borra registros de la historia
    Public Sub deleteHistory(registers() As Integer, Optional swDeleteRegister As Boolean = True)
        Dim ctrl As New ctrlCrud

        Dim Msg = ""
        For Each i As String In registers
            Dim condition As String

            If swDeleteRegister Then
                condition = "Id ='" & i & "'"
                ctrl.sendPetition("DELETE", "patient_history", "", "", condition)
                Msg = If(registers.Length() = 1, "EL REGISTRO DE LA HISTORIA HA SIDO ELIMINADO", "LOS REGISTROS DE LA HISTORIA HAN SIDO ELIMINADOS")
            Else
                condition = "patient_id ='" & i & "'"
                ctrl.sendPetition("DELETE", "patient_history", "", "", condition)
            End If
        Next

        If swDeleteRegister Then
            MsgBox(Msg, MsgBoxStyle.Information, "REGISTROS ELIMINADOS")
        End If

    End Sub
End Class
