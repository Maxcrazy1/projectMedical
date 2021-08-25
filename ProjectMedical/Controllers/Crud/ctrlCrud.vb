Imports MySql.Data.MySqlClient

Class ctrlCrud
    'Función para extraer uno o varios registros de la base de datos, 
    'esta condicionado para que devuelva dataTable o dataset
    Public Function getResultsBD(ByVal query As String, ByVal dtTableOrDtSet As Boolean, Optional table As String = "")
        Dim resultsQuery = New Object

        Using conexionMySql As MySqlConnection = Connection.conexion()

            Try
                Dim actionSql As New MySqlDataAdapter(query, conexionMySql)
                If (dtTableOrDtSet) Then
                    resultsQuery = New DataTable
                    actionSql.Fill(resultsQuery)
                Else
                    resultsQuery = New DataSet
                    actionSql.Fill(resultsQuery, table)
                End If

            Catch ex As Exception
                MsgBox("Error: " & vbNewLine & ex.Message)
            Finally
                conexionMySql.Dispose()
            End Try

        End Using

        Return resultsQuery
    End Function

    'Función para CRUD completa condicionada por diversos parametros
    Public Sub sendPetition(ByVal typePetition As String, ByVal table As String, ByVal arrayData As String,
                                 ByVal msgSuccess As String, Optional condition As String = "")

        Using conexionMySql As MySqlConnection = Connection.conexion()
            conexionMySql.Open()
            Select Case typePetition
                Case "REGISTER"
                    typePetition = "INSERT INTO " & table & " VALUES (" & arrayData & ") "
                Case "UPDATE"
                    typePetition = "UPDATE " & table & " SET " & arrayData & " WHERE " & condition & ""
                Case "DELETE"
                    typePetition = "DELETE FROM " & table & " WHERE " & condition & ""
            End Select

            Try
                Dim cmd As New MySqlCommand(typePetition, conexionMySql)
                cmd.ExecuteNonQuery()

                If (msgSuccess <> "") Then
                    MsgBox(msgSuccess, MsgBoxStyle.Information, "REGISTRO ACTUALIZADO")
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)

            Finally
                conexionMySql.Close()
                conexionMySql.Dispose()
            End Try
        End Using
    End Sub

    Public Function existsThisRegister(ByVal query As String, ByVal table As String) As Boolean
        Dim id As Boolean = False
        Try
            Dim patientId As New DataSet
            patientId = getResultsBD(query, False, table)
            id = If(CInt(patientId.Tables(0).Rows(0).Item(0).ToString) <> -1, True, False)
        Catch ex As Exception
        End Try
        Return id
    End Function


    Public Sub loginDataUser()
        Dim user = FrmLogin.TxtUser.Text
        Dim hash As New OC.Core.Crypto.Hash
        Dim pass = hash.MD5(FrmLogin.TxtPass.Text).ToLower()

        Using conexionMySql As MySqlConnection = Connection.conexion()
            conexionMySql.Open()
            Try
                Dim ctrlFrmMain As New InHome
                Dim cmd = New MySqlCommand("SELECT * FROM users where user=@user and pass=@pass", conexionMySql)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@user", user)
                cmd.Parameters.AddWithValue("@pass", pass)

                Dim action = cmd.ExecuteReader
                If action.HasRows Then
                    action.Read()
                    ctrlFrmMain.GetRoleUserToCondition(action("role"), action("user"))
                    FrmLogin.BtnIngreso.Enabled = False
                    FrmLogin.Hide()
                    FrmPrincipal.Show()
                    FrmPrincipal.Focus()
                Else
                    MsgBox("DATOS DE ACCESO INCORRECTOS", MsgBoxStyle.Exclamation, "DATOS ERRADOS")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                conexionMySql.Close()
                conexionMySql.Dispose()
            End Try
        End Using

    End Sub
End Class
