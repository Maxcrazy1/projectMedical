Imports System.Configuration
Imports System.Xml

Public Class InPnlSettings
    Private user, pass, role As String
    Private idUsr As Integer = 0
    Private ctrlUser As New CtrlUsers

    Public Sub resetFieldsSettings()
        Dim Arr As String() = {
          "Bunifu.Framework.UI.BunifuMaterialTextbox"
          }
        resetFields(FrmPrincipal.PnlSettings1, Arr)
    End Sub

    Public Sub setIdUsr(putId)
        idUsr = putId
    End Sub

    Public Function getIdUsr()
        Return idUsr
    End Function

    'Las distintas condiciones que debe pasar el form para guardar un user
    Public Function conditionsToSaveUser()
        Dim nameControls() As String = {
            "txtUser",
            "txtPass",
            "txtConfirmedPass"
            }
        Dim blnToSaveUser = ValidateCtrlInForm(FrmPrincipal.PnlSettings1, nameControls)

        If blnToSaveUser Then
            Return blnToSaveUser = passEquals()
        Else
            MsgBox("LOS CAMPOS RESALTADOS REQUIEREN INFORMACIÓN", MsgBoxStyle.Critical)
            Return blnToSaveUser
        End If
    End Function

    'Condiciona si las 2 passwords son iguales y devuelve true
    Private Function passEquals()
        Dim blnEqualsPass As Boolean = False
        If FrmPrincipal.PnlSettings1.txtPass.Text = FrmPrincipal.PnlSettings1.txtConfirmedPass.Text Then
            blnEqualsPass = True
        Else
            blnEqualsPass = False
            MsgBox("LAS 2 CONSTRASEÑAS NO SON EXACTAMENTE IGUALES, REINTENTELO", MsgBoxStyle.Exclamation, "NO SON IGUALES")
        End If
        Return blnEqualsPass
    End Function

    'Después de las peticiones a la DB se limpia el form y se carga el appConfig
    Public Sub BeforeSendPetition()
        FrmPrincipal.PnlSettings1.btnEliminar.Enabled = False
        LoadListUsers()
        resetFieldsSettings()
        rePaintColor({FrmPrincipal.PnlSettings1.txtPass, FrmPrincipal.PnlSettings1.txtUser, FrmPrincipal.PnlSettings1.txtConfirmedPass})
        LoadAppConfigXml()
        setIdUsr(0)
    End Sub

    'Se encarga de añadir nuevo user
    Public Sub FillDataUserToSave()
        FillDataPrivateUser()
        Dim dateNow = DateTime.Now.ToString("yyyy/MM/dd")
        Dim hash As New OC.Core.Crypto.Hash
        Dim passwrd As String = hash.MD5(pass).ToLower

        Dim arrDataUser As String = "null, '" & user & "', '" & passwrd & "','" & role & "','" & dateNow & "'"
        ctrlUser.storeUser(arrDataUser)

        BeforeSendPetition()
    End Sub

    'Se encarga de actualizar el user
    Public Sub FillDataUserToUpdate()
        FillDataPrivateUser()
        Dim hash As New OC.Core.Crypto.Hash
        Dim passwrd As String = hash.MD5(pass).ToLower

        Dim dataUser As String = "user='" & user & "', pass='" & passwrd & "', role='" &
            role & "'"

        ctrlUser.updateUser(idUsr, dataUser)
        BeforeSendPetition()

    End Sub

    Private Sub FillDataPrivateUser()
        user = FrmPrincipal.PnlSettings1.txtUser.Text()
        pass = FrmPrincipal.PnlSettings1.txtConfirmedPass.Text()
        role = FrmPrincipal.PnlSettings1.cboxRole.selectedIndex()
    End Sub

    'Función que llena la lista de usuarios
    Public Sub LoadListUsers()
        Try
            Dim lstUsers As ListView = FrmPrincipal.PnlSettings1.lstUsers

            cleanListItems(lstUsers)

            For Each user As DataRow In ctrlUser.getUsers.Rows
                lstUsers.Items.Add( _
                user("id").ToString)
                lstUsers.Items(lstUsers.Items.Count - 1).SubItems.Add(user("user").ToString)
                lstUsers.Items(lstUsers.Items.Count - 1).SubItems.Add(If(user("role").ToString = 0, "Administrador", "SubAdmin"))
            Next

        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message)
        End Try

    End Sub

    'fija la información de la DB en el frm
    Public Sub SetDataUser(id As Integer)
        Dim dataUser = ctrlUser.getUser(id)
        Dim pnlSettings = FrmPrincipal.PnlSettings1

        Dim fieldsDbAndFrmUser = New Dictionary(Of Object, String())
        fieldsDbAndFrmUser.Add(pnlSettings.txtUser, {"user", "Text"})
        fieldsDbAndFrmUser.Add(pnlSettings.cboxRole, {"role", "selectedIndex"})

        For Each valueDBAndFrm As KeyValuePair(Of Object, String()) In fieldsDbAndFrmUser
            valueDBAndFrm.Key.DataBindings.Add(valueDBAndFrm.Value(1), dataUser(0), "users." & valueDBAndFrm.Value(0))
        Next

        cleanDataBindings(pnlSettings)
    End Sub

    'Eliminar items seleccionados en la BD
    Public Sub deleteUsersSelected(lst As ListView)
        Dim idUserSelected() As Integer = {}

        If (lst.SelectedItems.Count > 1) Then
            For itemSelected As Integer = 0 To lst.SelectedItems.Count - 1
                idUserSelected.Add(lst.SelectedItems(itemSelected).Text)
            Next
        Else
            idUserSelected.Add(lst.SelectedItems(0).Text)
        End If

        ctrlUser.deleteUser(idUserSelected)

        BeforeSendPetition()
    End Sub

    'carga la config de AppConfig
    Public Sub LoadAppConfigXml()
        FrmPrincipal.PnlSettings1.txtUrl.Text = ConfigurationManager.ConnectionStrings("MySqlConnectionString").ConnectionString
        FrmPrincipal.PnlSettings1.txtPath.Text = ConfigurationManager.AppSettings("pathFolderMain")
    End Sub

    'Establece la nueva configuración en app.config
    Public Sub SetNewDataAppConfig(urlConnection As String)
        If FrmPrincipal.PnlSettings1.txtPath.Text <> ConfigurationManager.AppSettings("pathFolderMain") Or
            urlConnection <> ConfigurationManager.ConnectionStrings("MySqlConnectionString").ConnectionString Then

            If MessageBox.Show("¿ESTÁ SEGURO DE MODIFICAR EL ARCHIVO DE CONFIGURACIÓN? PUEDE DEJAR SIN FUNCIONAMIENTO EL SISTEMA",
                            "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                Dim xmlCfgDoc As New XmlDocument
                xmlCfgDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)

                For Each lineDocument As XmlElement In xmlCfgDoc.DocumentElement
                    If (lineDocument.Name.Equals("appSettings") Or lineDocument.Name.Equals("connectionStrings")) Then
                        For Each valNodeLine As XmlNode In lineDocument.ChildNodes
                            If (valNodeLine.Attributes(0).Value = "pathFolderMain") Then
                                valNodeLine.Attributes(1).Value = FrmPrincipal.PnlSettings1.txtPath.Text()
                            ElseIf (valNodeLine.Attributes(0).Value = "MySqlConnectionString") Then
                                valNodeLine.Attributes(1).Value = urlConnection
                            End If
                        Next
                    End If
                Next

                xmlCfgDoc.Save(AppDomain.CurrentDomain.BaseDirectory +
                                             "..\\..\\App.config")
                xmlCfgDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)

                ConfigurationManager.RefreshSection("appSettings")
                ConfigurationManager.RefreshSection("connectionStrings")

                MsgBox("EL ARCHIVO DE CONFIGURACIÓN HA SIDO EDITADO CORRECTAMENTE", MsgBoxStyle.Information)
                resetFieldsSettings()
                LoadAppConfigXml()
            End If
        End If

    End Sub
End Class
