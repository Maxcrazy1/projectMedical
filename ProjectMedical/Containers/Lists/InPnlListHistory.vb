Imports System.Globalization
Imports System.Configuration

Class InPnlListHistory
    Private media As New CtrlMedia


    Public Sub FillList(typeHistoryString As String)
        Try
            Dim histories, typeHistory, lst, columnImage As Object

            If typeHistoryString = "HemanHistory" Then
                typeHistory = New HemanHistory
                histories = typeHistory.getHemanHistories.Rows
                lst = FrmPrincipal.PnlHistoryRegister1.lstHeman
                columnImage = FrmPrincipal.PnlHistoryRegister1.hemanHistoryId
            Else
                typeHistory = New History
                histories = typeHistory.getHistories(FrmPrincipal.cedula).Rows
                lst = FrmPrincipal.PnlHistoryRegister1.lstHistory
                columnImage = FrmPrincipal.PnlHistoryRegister1.historyId
            End If

            Dim listHistories = AddItemsInList(histories, typeHistoryString)
            SetIconHistory(columnImage)
            lst.SetObjects(listHistories)
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Function AddItemsInList(histories, val) As List(Of Object)
        Dim listHistories As New List(Of Object)
        For Each dataHistory As DataRow In histories
            If val = "HemanHistory" Then
                listHistories.Add(SetDataHemanHistory(dataHistory))
            Else
                listHistories.Add(SetDataHistory(dataHistory))
            End If
        Next
        Return listHistories
    End Function


    Private Function SetDataHistory(dataHistory As DataRow)
        Dim history As New History With {.historyId = dataHistory("dateFormat") & " - " & dataHistory("id")}
        Return history
    End Function



    Private Function SetDataHemanHistory(dataHistory As DataRow)
        Dim history As New HemanHistory With {.hemanHistoryId = "Historia # " & dataHistory("history_id")}
        Return history
    End Function

    Private Sub SetIconHistory(columnImage As BrightIdeasSoftware.OLVColumn)
        columnImage.ImageGetter =
            Function() As String
                Return "donante.png"
            End Function
    End Sub

    Private Sub AddMediaFolderItem(listHistories As List(Of History))
        If media.existsFolder() Then
            Dim folder As New History With {.historyId = "Archivos Multimedia"}
            listHistories.Add(folder)
        End If
    End Sub


    Public Sub SetDataAndFormHistory(val As String)
        Dim frm = FrmPrincipal.PnlHistoryRegister1
        FrmPrincipal.PnlHistoria1.BringToFront()


        If Not (val = "Archivos Multimedia") Then
            SetHistory(trimAnyText(val, "integer", "-"))
        End If

        media.loadMedia()
        frm.BtnDeleteRegister.Enabled = False
        frm.BtnExportar.Enabled = False
    End Sub

    Public Sub lockBtnDeleteAndExport(lst As Object)
        Dim frm = FrmPrincipal.PnlHistoryRegister1
        frm.BtnDeleteRegister.Enabled = False
        frm.BtnExportar.Enabled = False
        For Each i In lst.SelectedItems()
            If lst.SelectedItems.Count > 0 And i.Text <> "Archivos Multimedia" Then
                frm.BtnDeleteRegister.Enabled = True
                frm.BtnExportar.Enabled = True
            Else
                frm.BtnDeleteRegister.Enabled = False
                frm.BtnExportar.Enabled = False
            End If
        Next
    End Sub
End Class
