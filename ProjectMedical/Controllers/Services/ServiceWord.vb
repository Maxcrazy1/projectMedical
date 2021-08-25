Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.Configuration

Class ServiceWord

    'Exportacion de datos de la historia a document en Word
    Private Sub exportDocument(plantilla As Word.Application)
        If MsgBox("DOCUMENTO GUARDADO EXITOSAMENTE, ¿DESEA ABRIRLO?", MsgBoxStyle.YesNo,
                  "ARCHIVO GUARDADO") = MsgBoxResult.Yes Then
            FrmPrincipal.WindowState = FormWindowState.Minimized
            plantilla.Visible = True
        Else
            plantilla.Quit()
        End If
    End Sub

    Public Sub PrepareDocBeforeExport(bookmarskAndData As Dictionary(Of String, String))
        Try
            FrmPrincipal.Cursor = Cursors.WaitCursor
            Dim plantilla As New Word.Application
            Dim media As New CtrlMedia
            Dim pathFolder As String = ConfigurationManager.AppSettings("pathFolderMain") &
                           trimAnyText(FrmPrincipal.lblName.Text, "string", "|") & "\Documentos multimedia"

            media.createFolder(pathFolder)
            Dim documento = openDocument(plantilla)
            SetBKMarks(bookmarskAndData, documento)
            documento.Save()
            exportDocument(plantilla)

        Catch ex As Exception
            MsgBox("ERROR DE GUARDADO, CIERRE WORD E INTENTE DE NUEVO " + ex.ToString,
                   MsgBoxStyle.Exclamation, "CERRAR WORD")
        Finally
            FrmPrincipal.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub SetBKMarks(bookmarskAndData As Dictionary(Of String, String), doc As Word.Document)
        For Each bkMarkAndData As KeyValuePair(Of String, String) In bookmarskAndData
            doc.Bookmarks.Item(bkMarkAndData.Key).Range.Text = bkMarkAndData.Value
        Next
    End Sub

    Function openDocument(plantilla As Word.Application)
        Dim documento As New Word.Document
        Dim name = FrmPrincipal.lblName.Text.Split("|")

        Dim pathToNewFile = ConfigurationManager.AppSettings("pathFolderMain") + name(1).Trim() &
            "\historia " & Format(Date.Now, "yyyy-MM-dd H_mm_ss") & ".docx"

        copyDocument(pathToNewFile)
        Return plantilla.Documents.Open(pathToNewFile)
    End Function

    Private Sub copyDocument(pathToNewFile As String)
        Dim pathOfTemplate = ConfigurationManager.AppSettings("pathFolderMain") + "\Template Document\Template.docx"
        FileCopy(pathOfTemplate, pathToNewFile)
    End Sub

End Class

