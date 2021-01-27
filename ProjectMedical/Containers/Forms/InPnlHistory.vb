
Module InPnlHistory
    Private fieldsHistory = New Dictionary(Of String, String)
    Private guideAllFields() = {"enfermedad", "personales", "familiares", "hábitos", "piel", "cuero", "mucosas", "uñas", "DX", "plan", "controles"}
    Private blnMsgVerification As Boolean = False
    Private ctrHistory As New History
    Private ctrPatient As New Patient
    Private ctrlPnlListHistory As New InPnlListHistory
    Private evtsHistory As New ActionsFormHistory


    'Bln que activa mensaje emergente de guardar cambios (ES MEJORABLE)
    Public Sub setBlnMsgVerification(switch As Boolean)
        blnMsgVerification = switch
    End Sub

    Public Function getBlnMsgVerification()
        Return blnMsgVerification
    End Function

    Private Sub SetScrollForm(UpScrollForm As Boolean)
        If UpScrollForm Then
            scrollForm(FrmPrincipal.PnlHistoria1, 400)
        Else
            scrollForm(FrmPrincipal.PnlHistoria1, 0)
        End If
    End Sub

    
    Public Sub SetTitleHistoryInPnl(title As String, lblFilter As String)
        Dim titleHistory = FrmPrincipal.PnlHistoria1.lblFieldHistory
        prepareHistoryField(titleHistory, lblFilter)
        SetTitleAndCenter(title, titleHistory)

    End Sub


    Private Sub prepareHistoryField(titleHistory As Label, lblFilter As String)
        setValuesFieldHistory(FrmPrincipal.PnlHistoria1.txtFieldHistory.Text, titleHistory.Text)
        printValueHistory(lblFilter)
        evtsHistory.setCursorText(FrmPrincipal.PnlHistoria1.txtFieldHistory)
        SetScrollForm(True)
    End Sub


    Public Sub printValueHistory(txtFilter As String)
        FrmPrincipal.PnlHistoria1.txtFieldHistory.Text = fieldsHistory(txtFilter)
    End Sub


    Private Function setfieldsHistory() As String
        Dim dateConsultation = FrmPrincipal.PnlHistoria1.fieldDateConsultation.Value.ToString("yyyy/MM/dd")
        Dim dateNow = DateTime.Now.ToString("yyyy/MM/dd")
        Dim idPatient = ctrPatient.getId(FrmPrincipal.cedula)

        Dim arrHistory As String = "null," & idPatient & " ,'" & fieldsHistory("enfermedad") & "', '" & fieldsHistory("personales") & "', '" &
            fieldsHistory("familiares") & "','" & fieldsHistory("hábitos") & "','" & fieldsHistory("piel") & "','" & fieldsHistory("cuero") &
            "','" & fieldsHistory("mucosas") & "','" & fieldsHistory("uñas") & "','" & fieldsHistory("DX") & "','" & fieldsHistory("plan") & "','" &
            fieldsHistory("controles") & "','" & dateConsultation & "','" & dateNow & "'"
        Return arrHistory
    End Function

    Public Sub savefieldsHistory()
        setValuesFieldHistory(FrmPrincipal.PnlHistoria1.txtFieldHistory.Text, FrmPrincipal.PnlHistoria1.lblFieldHistory.Text)
        Dim arrHistory = setfieldsHistory()
        ctrHistory.saveHistory(arrHistory)
    End Sub


    Public Sub updatefieldsHistory()
        setValuesFieldHistory(FrmPrincipal.PnlHistoria1.txtFieldHistory.Text, FrmPrincipal.PnlHistoria1.lblFieldHistory.Text)

        Dim arrHistory As String = "enf_actual='" & fieldsHistory("enfermedad") & "', ant_per='" & fieldsHistory("personales") & "', ant_fam='" &
            fieldsHistory("familiares") & "', hab_psi='" & fieldsHistory("hábitos") & "', piel='" & fieldsHistory("piel") & "', cue_cab='" & fieldsHistory("cuero") &
            "', muc='" & fieldsHistory("mucosas") & "', unas='" & fieldsHistory("uñas") & "', dx='" & fieldsHistory("DX") & "', plan='" & fieldsHistory("plan") &
            "', cont='" & fieldsHistory("controles") & "', date_medical='" & FrmPrincipal.PnlHistoria1.fieldDateConsultation.Value.ToString("yyyy/MM/dd") & "'"

        ctrHistory.updateHistory(arrHistory)
    End Sub

    Public Sub evtClickSaveOrUpdate()
        setBlnMsgVerification(False)

        If (ctrHistory.getHistoryId() = 0) Then
            savefieldsHistory()
        Else
            updatefieldsHistory()
        End If
    End Sub

    Public Sub resetfieldsHistory()

        SetTitleHistoryInPnl("Información de la enfermedad actual", "enfermedad")
        SetScrollForm(False)
        FrmPrincipal.PnlHistoria1.fieldDateConsultation.Value = DateTime.Now.ToString("dd/MM/yyyy")
        FrmPrincipal.PnlHistoria1.txtFieldHistory.Text = ""
        ctrHistory.setHistoryId(0)
        setBlnMsgVerification(False)

        fieldsHistory.clear()

    End Sub


    Public Sub deleteListHistory(lstParam As Object)
        Dim idHistorys() As Integer = {}

        If (lstParam.SelectedItems.Count > 1) Then
            For itemSelected As Integer = 0 To lstParam.SelectedItems.Count - 1
                idHistorys.Add(trimAnyText(lstParam.SelectedItems(itemSelected).Text, "integer", "-"))
            Next
        Else
            idHistorys.Add(trimAnyText(lstParam.SelectedItems(0).Text, "integer", "-"))
        End If
        ctrHistory.deleteHistory(idHistorys)
        ctrlPnlListHistory.FillList("StandardHistory")

        FrmPrincipal.PnlHistoryRegister1.BtnDeleteRegister.Enabled = False
        FrmPrincipal.PnlHistoryRegister1.BtnExportar.Enabled = False
    End Sub

    'Función encargada de fijar los datos en los indices del array que
    ' les corresponde e imprimir algunos datos en la vista
    Public Sub SetHistory(ByVal id As Integer)
        ctrHistory.setHistoryId(id)
        Dim frm = FrmPrincipal.PnlHistoria1
        Dim Data = ctrHistory.getHistory(id)

        Dim fieldsNameHistoryDB() = {"enf_actual", "ant_per", "ant_fam", "hab_psi",
                            "piel", "cue_cab", "muc", "unas", "dx", "plan", "cont"}

        frm.txtFieldHistory.Text = Data("enf_actual".ToString)
        frm.fieldDateConsultation.Value = Data("date_medical".ToString)

        For itemFieldHistory As Integer = 0 To guideAllFields.Length - 1
            setValuesFieldHistory(Data(fieldsNameHistoryDB(itemFieldHistory).ToString), guideAllFields(itemFieldHistory).ToString)
        Next
    End Sub


    'Llena la colección con los valores que va recogiendo del richtxtbox
    'If el contador de la collecion es menor que 11 llena el item que esta recorriendo con cierta información
    Private Sub setValuesFieldHistory(txtFieldHistory As String, paramFieldGuide As String)
        For Each guideField As String In guideAllFields
            If fieldsHistory.count() < 11 Then
                fieldsHistory.Add(guideField, "")
            End If

            If paramFieldGuide.Contains(guideField) Then
                fieldsHistory(guideField) = txtFieldHistory
            End If
        Next
    End Sub
End Module
