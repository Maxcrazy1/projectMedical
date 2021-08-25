Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Configuration


Public Class CtrlMedia


    Private Function getPathMain()
        Return ConfigurationManager.AppSettings("pathFolderMain") &
        trimAnyText(FrmPrincipal.lblName.Text, "string", "|")
    End Function


    Public Sub createFolder(pathToCopy As String)
        If Not My.Computer.FileSystem.DirectoryExists(pathToCopy) Then
            My.Computer.FileSystem.CreateDirectory(pathToCopy)
        End If
    End Sub

    Public Sub saveMedia(openFiles As OpenFileDialog)
        If openFiles.ShowDialog() = DialogResult.OK Then
            'Path to save the file
            Dim pathToCopy As String = getPathMain() & "\Documentos multimedia"
            createFolder(pathToCopy)

            For Each fileSelected In openFiles.FileNames
                Try
                    'Variable utilizada para almacenar la ruta final del documento copiado y el nombre
                    Dim newFile = pathToCopy + Mid(fileSelected, InStrRev(fileSelected, "\"))
                    File.Copy(fileSelected, newFile, True)
                Catch ex As Exception
                    MsgBox("HA OCURRIDO EL SIGUIENTE ERROR EN LA SUBIDA DE ARCHIVOS : " &
                           ex.ToString, MsgBoxStyle.Critical)
                End Try

                If (openFiles.FileNames.Length - 1 = Array.IndexOf(openFiles.FileNames, fileSelected)) Then
                    MsgBox("TODOS LOS ARCHIVOS HAN SIDO AGREGADOS CON ÉXITO", MsgBoxStyle.Information)
                    loadMedia()
                End If
            Next
        End If
    End Sub

    Public Sub openFolder()
        Process.Start("explorer.exe", getPathMain())
    End Sub

    'Condiciona si existe la carpeta y si tiene archivos dentro
    Public Function existsFolder() As Boolean
        Dim path As String = getPathMain() & "\Documentos multimedia\"
        Dim PathNow As New DirectoryInfo(path)
        Try
            Return If(My.Computer.FileSystem.DirectoryExists(path) And PathNow.GetFiles().Count > 0 = True, True, False)
        Catch ex As Exception
            Return MsgBox("HA OCURRIDO UN ERROR EN LA CONSULTA DE ARCHIVOS : " &
                           ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Function


    'Fija la ruta a buscar y condiciona si la ruta existe para mostrar dicha información
    Public Sub loadMedia()
        Dim lst = FrmPrincipal.PnlHistoria1.listFiles
        Dim imgList = FrmPrincipal.PnlHistoria1.imgList

        lst.Clear()
        imgList.Images.Clear()

        Dim path = getPathMain() & "\Documentos multimedia"

        If My.Computer.FileSystem.DirectoryExists(path) Then
            addFiles(lst, imgList, path)
        End If

    End Sub

    'Funcion encargada de añadir el item con el nombre y la imagen del mismo
    Private Sub addFiles(lst As ListView, imgList As ImageList, path As String)
        'Dim extWithOutImages() As String = {".pdf", ".doc", ".docx"} Se pueden añadir iconos personalizados
        Dim extsWithThumbnail() As String = {".jpeg", ".jpg", ".png"}

        Dim PathNow As New DirectoryInfo(path)
        Dim fileArray = PathNow.GetFiles()

        For Each fil In fileArray
            Dim newDirectoryItem As ListViewItem =
                lst.Items.Add(fil.Name)

            If (extsWithThumbnail.Contains(fil.Extension)) Then
                Dim stream As IO.StreamReader = New IO.StreamReader(path & "\" & fil.Name)
                imgList.Images.Add(Image.FromStream(stream.BaseStream))
                stream.Close()
            End If

            lst.Items(lst.Items.Count - 1).ImageIndex = imgList.Images.Count - 1
        Next
    End Sub

    'Elimina archivos
    Public Sub deleteFiles(fileToDelete As String)
        Dim pathToCopy As String = getPathMain() & "\Documentos multimedia\"

        Try
            FileSystem.DeleteFile(pathToCopy & fileToDelete,
                                 Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently,
        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        Catch ex As IOException
            MsgBox(ex.ToString)
        End Try

        loadMedia()
    End Sub

    'Elimina Carpetas
    Public Sub deleteFolder(pathToDelete As String)
        If My.Computer.FileSystem.DirectoryExists(pathToDelete) Then
            Try
                FileSystem.DeleteDirectory(pathToDelete, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception
                Console.WriteLine(ex.ToString)
            End Try
        End If
    End Sub
End Class
