Imports Bunifu.Framework.UI

Module InPnlHeman
    Private fieldsHistory = New Dictionary(Of String, String)
    Private lastField As String = "complic"
    Private hemanHistoryId As Integer = 0

    Public Sub SetHemanHistoryId(newId As Integer)
        hemanHistoryId = newId
    End Sub

    Public Sub GetValuesHistory(frm As Control)
        For Each ctl As Control In frm.Controls
            GetValueFromTextBox(ctl)
            GetValueFromDatePicker(ctl)
            IsPnlGradient(ctl)
        Next
    End Sub

    Public Sub handleClickHistory()
        GetDataInRichTxt()
        If Not historyIsEmpty() Then
            UpdateOrSaveHistory()
        Else
            MsgBox("NO HAY NINGUNA INFORMACIÓN QUE ALMACENAR", MsgBoxStyle.Exclamation, "DATOS INCOMPLETOS")
        End If
    End Sub

    Private Sub UpdateOrSaveHistory()
        Dim ctrlHist As New HemanHistory
        If (hemanHistoryId = 0) Then
            ctrlHist.saveHemanHistory(fieldsHistory)
        Else
            ctrlHist.updateHemanHistory(fieldsHistory, hemanHistoryId)
        End If
    End Sub

    Public Sub newHemanHistory()
        fieldsHistory.clear()
        SetHemanHistoryId(0)
        resetfieldsInPnl(FrmPrincipal.PnlHeman_11.Controls)
        resetfieldsInPnl(FrmPrincipal.PnlHeman_21.Controls)
        resetfieldsInPnl(FrmPrincipal.PnlHeman_Final1.Controls)
        FrmPrincipal.PnlHeman_11.BringToFront()
        FirstInputFocus(FrmPrincipal.PnlHeman_11)
    End Sub

    Private Sub resetfieldsInPnl(ctlMain As Object)
        For Each ctlMaster As Object In ctlMain
            If isRichOrTxtbox(ctlMaster) Then
                ctlMaster.Text = String.Empty
            End If
            For Each controlInPanel As Control In ctlMaster.Controls
                conditionsToReset(controlInPanel, ctlMaster)
            Next
        Next
    End Sub

    Private Sub conditionsToReset(controlInPanel, controlMaster)
        If controlMaster.[GetType]() = GetType(BunifuGradientPanel) Then
            If (controlInPanel.[GetType]() = GetType(BunifuCheckbox)) Then
                Dim check = CType(controlInPanel, BunifuCheckbox)
                check.Checked = False
            ElseIf (controlInPanel.[GetType]() = GetType(RichTextBox)) Then
                controlInPanel.Text = String.Empty
            End If
        End If
    End Sub
    Public Sub setValuesFieldsHistory(dataHistory As Dictionary(Of String, String))
        For Each ctlsMain As Object In {FrmPrincipal.PnlHeman_11.Controls(),
                                       FrmPrincipal.PnlHeman_21.Controls, FrmPrincipal.PnlHeman_Final1.Controls}

            fieldsHistory = dataHistory
            For Each pnl As Control In ctlsMain
                SetValueInTxtAndRichTxt(pnl, fieldsHistory)
                SetValueInDatepicker(pnl, fieldsHistory)
                SetValueInCheckOnPanel(pnl, fieldsHistory)
            Next
        Next
    End Sub

    Private Sub SetValueInTxtAndRichTxt(ctl As Control, values As Dictionary(Of String, String))
        If isRichOrTxtbox(ctl) Or ctl.[GetType]() = GetType(BunifuDatepicker) Then
            If values.ContainsKey(ctl.Name) Then
                ctl.Text = values(ctl.Name)
            End If
        End If
    End Sub

    Private Sub SetValueInDatepicker(ctl As Control, values As Dictionary(Of String, String))
        If ctl.[GetType]() = GetType(BunifuDatepicker) Then
            Dim datePick = CType(ctl, BunifuDatepicker)
            If values.ContainsKey(ctl.Name) Then
                datePick.Value = values(ctl.Name)
            End If
        End If
    End Sub

    Private Sub SetValueInCheckOnPanel(ctl As Control, values As Dictionary(Of String, String))
        If ctl.[GetType]() = GetType(BunifuGradientPanel) Then
            For Each obj As Control In ctl.Controls
                conditionsToSetDataOnPanel(ctl, values)
            Next
        End If
    End Sub

    Private Sub conditionsToSetDataOnPanel(ctl, Data)
        If ctl.[GetType]() = GetType(BunifuCheckbox) Then
            If Data.ContainsKey(ctl.Name) Then
                Dim check = CType(ctl, BunifuCheckbox)
                check.Checked = Data(ctl.Name)
            End If
        ElseIf ctl.[GetType]() = GetType(RichTextBox) Then
            If Data.ContainsKey(ctl.Name) Then
                ctl.Text = Data(ctl.Name)
            End If
        End If
    End Sub

    Private Sub GetDataInRichTxt()
        fieldsHistory(lastField) = FrmPrincipal.PnlHeman_Final1.txtFieldHistory.Text
        removeKeyDictHistory()
    End Sub

    Private Sub removeKeyDictHistory()
        If FrmPrincipal.PnlHeman_Final1.txtFieldHistory.Text = "" Then
            fieldsHistory.Remove(lastField)
        End If
    End Sub

    Private Function historyIsEmpty()
        Return If(fieldsHistory.count = 0, True, False)
    End Function

    Private Sub SetFieldGuide(newValue As String)
        lastField = newValue
    End Sub
    Public Sub loadFirstDataInRichtxt()
        If fieldsHistory.ContainsKey(lastField) Then
            FrmPrincipal.PnlHeman_Final1.txtFieldHistory.Text = fieldsHistory(lastField)
        End If
    End Sub

    Public Sub SetTitleAndSetValueHistory(title As String, fieldGuideName As String)
        fieldsHistory(lastField) = FrmPrincipal.PnlHeman_Final1.txtFieldHistory.Text
        FrmPrincipal.PnlHeman_Final1.txtFieldHistory.Clear()
        SetFieldGuide(fieldGuideName)
        scrollForm(FrmPrincipal.PnlHeman_Final1, 700)
        If fieldsHistory.ContainsKey(fieldGuideName) Then
            FrmPrincipal.PnlHeman_Final1.txtFieldHistory.Text = fieldsHistory(fieldGuideName)
        End If

        SetTitleAndCenter(title, FrmPrincipal.PnlHeman_Final1.lblFieldHistory)
    End Sub

    Private Sub GetValueFromTextBox(ctl As Control)
        If isRichOrTxtbox(ctl) Then
            fieldsHistory(ctl.Name) = ctl.Text
        End If
    End Sub

    Private Function isRichOrTxtbox(control As Control) As Boolean
        Return If(control.[GetType]() = GetType(BunifuMaterialTextbox) Or control.[GetType]() = GetType(RichTextBox), True, False)
    End Function

    Private Sub GetValueFromDatePicker(ctl As Control)
        If ctl.[GetType]() = GetType(BunifuDatepicker) Then
            Dim datePick = CType(ctl, BunifuDatepicker)
            fieldsHistory(datePick.Name) = datePick.Value
        End If
    End Sub

    Private Sub IsPnlGradient(ctl As Control)
        If ctl.[GetType]() = GetType(BunifuGradientPanel) Then
            For Each obj As Control In ctl.Controls
                GetValueRich(obj)
                IsCheckbox(obj)
            Next
        End If
    End Sub

    Private Sub IsCheckbox(obj As Control)
        If obj.[GetType]() = GetType(BunifuCheckbox) Then
            Dim check = CType(obj, BunifuCheckbox)
            GetValueChecked(check)
        End If
    End Sub

    Private Sub GetValueRich(richTxt)
        If richTxt.[GetType]() = GetType(RichTextBox) Then
            fieldsHistory(richTxt.Name) = richTxt.text
        End If
    End Sub

    Private Sub GetValueChecked(check As BunifuCheckbox)
        fieldsHistory(check.Name) = check.Checked
    End Sub

    Public Sub deleteListHistory(lstParam As Object)
        Dim ctrlHeman As New HemanHistory
        Dim CtrlListHistory As New InPnlListHistory

        Dim idHistorys() As Integer = {}

        If (lstParam.SelectedItems.Count > 1) Then
            For itemSelected As Integer = 0 To lstParam.SelectedItems.Count - 1
                idHistorys.Add(trimAnyText(lstParam.SelectedItems(itemSelected).Text, "integer", "#"))
            Next
        Else
            idHistorys.Add(trimAnyText(lstParam.SelectedItems(0).Text, "integer", "#"))
        End If
        ctrlHeman.deleteHemanHistory(idHistorys)
        CtrlListHistory.FillList("HemanHistory")

        FrmPrincipal.PnlHistoryRegister1.BtnDeleteRegister.Enabled = False
        FrmPrincipal.PnlHistoryRegister1.BtnExportar.Enabled = False
    End Sub
End Module
