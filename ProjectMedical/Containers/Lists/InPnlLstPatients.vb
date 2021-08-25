Class InPnlLstPatients
    Private patient As New Patient

    'Función que recorre los items chequeados y los que conseguí los elimina de la bd
    Public Sub deleteListPatients()
        Dim ctrlPat As New InPnlRegister
        Dim documentsId() As String = {}

        If (FrmPrincipal.PnlListado1.lstPatients.CheckedItems.Count > 0) Then
            For itemCheck As Integer = 0 To FrmPrincipal.PnlListado1.
                lstPatients.CheckedItems.Count - 1 Step 1
                documentsId.Add(FrmPrincipal.PnlListado1.lstPatients.
                                CheckedItems.Item(itemCheck).SubItems(0).Text())
            Next
        Else
            documentsId.Add(FrmPrincipal.PnlListado1.lstPatients.SelectedItems(0).SubItems(0).Text)
        End If

        ctrlPat.deletePatient(documentsId)
    End Sub

    'Fija los items en la lista de los pacientes
    Public Sub FillPatientList()
        Dim patient As New Patient
        Dim itemsPatient = patient.getPatients().Rows
        Dim pnlLst = FrmPrincipal.PnlListado1

        SetIconGenre()

        Dim lstPatient As New List(Of Patient)
        For Each dataPatient As DataRow In itemsPatient
            Dim newPatient = SetDataPatient(dataPatient)
            lstPatient.Add(newPatient)
        Next

        pnlLst.lstPatients.SetObjects(lstPatient)
    End Sub


    Private Sub SeticonGenre()
        FrmPrincipal.PnlListado1.documentId.ImageGetter =
            Function(rowObject As Object) As String
                Dim rowPatient As Patient = DirectCast(rowObject, Patient)
                Return If(rowPatient.genre = "Masculino", "male.png", "female.png")
            End Function
    End Sub

    Private Function SetDataPatient(dataPatient As DataRow)
        Dim patient As New Patient With {.documentId = dataPatient("document_id").ToString,
                                       .namePatient = dataPatient("name").ToString,
                                       .lastName = dataPatient("last_name").ToString,
                                       .profession = dataPatient("profesion").ToString,
                                       .genre =
                                       If(dataPatient("genre").ToString = "0", "Masculino", "Femenino")}
        Return patient
    End Function
End Class
