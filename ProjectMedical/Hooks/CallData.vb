Module CallData
    'Obtiene el max reciente ID de la BD
    Public Function getBDHistoryId(id As String, nameTable As String) As Integer
        Dim ctrl As New ctrlCrud

        Dim idHistory = ctrl.getResultsBD("SELECT MAX(" & id & ") FROM " & nameTable & "", False, nameTable)

        Dim newIdHistory = If(IsDBNull(idHistory.Tables(nameTable).Rows(0)("MAX(" & id & ")".ToString)),
                      1, CInt(idHistory.Tables(nameTable).Rows(0)("MAX(" & id & ")".ToString)))

        Return CInt(newIdHistory)
    End Function
End Module
