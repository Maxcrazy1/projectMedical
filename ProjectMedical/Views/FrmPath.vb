Imports System.Configuration

Public Class FrmPath


    Private Sub BtnSetPath_Click(sender As Object, e As EventArgs) Handles BtnSetPath.Click
        Dim users As New InPnlSettings
        users.SetNewDataAppConfig(txtPath.Text)
        LoadSettings()
    End Sub

    Private Sub FormPath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private Sub LoadSettings()
        txtPath.Text = ConfigurationManager.ConnectionStrings("MySqlConnectionString").ConnectionString
    End Sub
End Class