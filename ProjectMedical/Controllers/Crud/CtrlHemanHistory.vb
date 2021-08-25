Public Class HemanHistory
    Public Property hemanHistoryId As String

    Public Sub saveHemanHistory(fieldsHistory As Dictionary(Of String, String))
        Dim ctrlCrud As New ctrlCrud
        Dim Patient As New Patient
        Dim historyId = (getBDHistoryId("history_id", "heman_history_patients") + 1)

        For Each valueFieldFormAndDb As KeyValuePair(Of String, String) In fieldsHistory
            Dim dataToSave As String = "null, '" & historyId & "', '" & valueFieldFormAndDb.Key & "','" & valueFieldFormAndDb.Value &
            "'"
            ctrlCrud.sendPetition("REGISTER", "heman_history", dataToSave, "")
        Next

        saveRelationHistory(historyId)
        MsgBox("REGISTRO HISTORICO ALMACENADO")
    End Sub


    Public Sub updateHemanHistory(fieldsHistory As Dictionary(Of String, String), historyId As Integer)
        Dim ctrlCrud As New ctrlCrud
        Dim Patient As New Patient

        For Each valueFieldFormAndDb As KeyValuePair(Of String, String) In fieldsHistory
            Dim dataToSave As String = "description='" & valueFieldFormAndDb.Value & "'"
            If Not (ctrlCrud.existsThisRegister("SELECT id from heman_history where name='" & valueFieldFormAndDb.Key &
                                        "' AND description='" & valueFieldFormAndDb.Value & "'", "heman_history")) Then

                dataToSave = "null, '" & historyId & "', '" & valueFieldFormAndDb.Key & "','" & valueFieldFormAndDb.Value &
                           "'"
                ctrlCrud.sendPetition("REGISTER", "heman_history", dataToSave, "")
            Else
                ctrlCrud.sendPetition("UPDATE", "heman_history", dataToSave, "", "history_id=" & historyId & " AND name='" & valueFieldFormAndDb.Key & "'")
            End If
        Next

        MsgBox("REGISTRO HISTORICO ACTUALIZADO")
    End Sub

    Private Sub SaveOnlyOneFieldHistory(ByVal historyId As Integer, ByVal dataHistory As String())
        Dim ctrlCrud As New ctrlCrud

        Dim dataToSave As String = "null, '" & historyId & "', '" & dataHistory(0) & "','" & dataHistory(1) &
          "', ' true '"
        ctrlCrud.sendPetition("REGISTER", "heman_history", dataToSave, "")
    End Sub


    Private Sub saveRelationHistory(historyId)
        Dim Patient As New Patient

        Dim ctrlCrud As New ctrlCrud

        Dim idPatient = Patient.getId(FrmPrincipal.cedula)

        Dim dataSave = "null,'" & idPatient & "', '" & historyId & "'"
        ctrlCrud.sendPetition("REGISTER", "heman_history_patients", dataSave, "")
    End Sub


    Public Sub getHemanHistory(hemanId As String)
        Dim ctrl As New ctrlCrud

        hemanId = trimAnyText(hemanId, "integer", "#")
        Dim historyData As New DataSet
        Dim fieldsHistory = New Dictionary(Of String, String)
        historyData = ctrl.getResultsBD("select * from heman_history where history_id=" & hemanId, False, "heman_history")

        If historyData.Tables("heman_history").Rows.Count > 0 Then
            For Each fieldHistory As Object In historyData.Tables("heman_history").Rows
                fieldsHistory(fieldHistory("name".ToString)) = fieldHistory("description".ToString)
            Next
        End If

        newHemanHistory()
        setValuesFieldsHistory(fieldsHistory)
        SetHemanHistoryId(hemanId)
    End Sub

    Public Function getHemanHistories() As Object

        Dim ctrl As New ctrlCrud
        Dim patient As New Patient

        Dim histories = ctrl.getResultsBD("SELECT history_id FROM heman_history_patients WHERE patient_id=" &
                          patient.getId(FrmPrincipal.cedula), True)
        Return histories
    End Function


    Public Sub deleteHemanHistory(registers() As Integer)
        Dim ctrl As New ctrlCrud

        Dim Msg = ""
        For Each i As String In registers
            ctrl.sendPetition("DELETE", "heman_history_patients", "", "", "history_id ='" & i & "'")
            ctrl.sendPetition("DELETE", "heman_history", "", "", "history_id ='" & i & "'")
            Msg = If(registers.Length() = 1, "EL REGISTRO DE LA HISTORIA HA SIDO ELIMINADO", "LOS REGISTROS DE LA HISTORIA HAN SIDO ELIMINADOS")            
        Next

        MsgBox(Msg, MsgBoxStyle.Information, "REGISTROS ELIMINADOS")
    End Sub

End Class
