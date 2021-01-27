Public Class ServiceExport

    Private Function FillArrayDataHistoryToExport()
        Dim dataHistoryToExport = New Dictionary(Of String, String)
        Dim lst As ListView = FrmPrincipal.PnlHistoryRegister1.lstHistory
        Dim history As New History
        Dim nameFieldsDB() = {"enf_actual", "ant_per", "ant_fam", "cue_cab",
                           "dx", "hab_psi", "muc", "piel", "plan", "unas", "cont"}

        For itemSelected As Integer = 0 To FrmPrincipal.PnlHistoryRegister1.lstHistory.SelectedItems.Count - 1
            Dim dataHistory = history.getHistory(trimAnyText(FrmPrincipal.PnlHistoryRegister1.lstHistory.
                                                             SelectedItems(itemSelected).Text, "integer", "-"))

            For Each fieldHistoryDB As String In nameFieldsDB
                If dataHistoryToExport.ContainsKey(fieldHistoryDB) Then
                    dataHistoryToExport(fieldHistoryDB) += " " + dataHistory(fieldHistoryDB)
                Else
                    dataHistoryToExport.Add(fieldHistoryDB, dataHistory(fieldHistoryDB))
                End If
            Next
        Next

        Return dataHistoryToExport
    End Function

    'Llena la array con los datos del paciente que se exportara a word 
    Private Function FillArrayDataPatientToExport(dataPatient As Dictionary(Of String, String)) As Object
        Dim Patient As New Patient
        Dim dataDBPatient = Patient.getPatient(FrmPrincipal.cedula)

        dataPatient("age") = CStr(DateDiff(DateInterval.Year, Convert.ToDateTime(dataDBPatient(1)("date_birth").ToString), Date.Today))
        dataPatient("name") = dataDBPatient(1)("name".ToString) & " " & dataDBPatient(1)("last_name".ToString)
        dataPatient("address") = dataDBPatient(1)("address".ToString)
        dataPatient("genre") = If(dataDBPatient(1)("genre".ToString) = 0, "Masculino", "Femenino")
        dataPatient("marital_status") = WhatsMaritalStatus(dataDBPatient(1)("marital_status".ToString))
        dataPatient("profesion") = dataDBPatient(1)("profesion".ToString)
        dataPatient("start_date") = dataDBPatient(1)("start_date".ToString)

        Return dataPatient
    End Function

    'Ciclo para obtener los registros a exportar a word
    Public Sub SelectedToExport()
        Dim doc As New ServiceWord

        Dim dataHistoryToExport = FillArrayDataPatientToExport(FillArrayDataHistoryToExport())
        doc.PrepareDocBeforeExport(dataHistoryToExport)
    End Sub


    Private Function WhatsMaritalStatus(typeStatus As String)
        Select Case typeStatus
            Case "0"
                typeStatus = "Soltero"
            Case "1"
                typeStatus = "Viudo"
            Case "2"
                typeStatus = "Casado"
        End Select
        Return typeStatus
    End Function
End Class
