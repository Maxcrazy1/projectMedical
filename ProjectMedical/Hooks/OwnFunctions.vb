Imports System.Runtime.CompilerServices
Imports System.Globalization
Module OwnFunctions

    'Función para añadir items a una array
    <Extension()> _
    Public Sub Add(Of T)(ByRef arr As T(), item As T)
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = item
    End Sub

    Public Sub resetFields(control As Control, arr() As String)
        For Each contHijo As Object In control.Controls
            For i = 0 To arr.Length - 1
                If contHijo.GetType.ToString() = arr(i) Or arr(i).Contains(contHijo.GetType.ToString()) Then
                    contHijo.Text = ""
                End If
            Next
        Next
    End Sub

    'Valida los controles enviados desde el form
    'Formulario
    'nameControl() = Nombres de los controles a condicionar
    Public Function ValidateCtrlInForm(Formulario As Control, nameControl() As String) As Boolean
        Dim valRegistro As Boolean = True
        For Each control In Formulario.Controls
            For i = 0 To nameControl.Length - 1
                If String.IsNullOrWhiteSpace(control.text) And control.name = nameControl(i) Then
                    control.LineIdleColor = System.Drawing.Color.Red
                    valRegistro = False
                End If
            Next
        Next
        Return valRegistro
    End Function

    Public Sub rePaintColor(control As Object)
        For Each item In control
            If item.LineIdleColor = System.Drawing.Color.Red Then
                item.LineIdleColor = System.Drawing.ColorTranslator.FromHtml("#4EAFC1")
            End If
        Next
    End Sub

    Public Sub IsOnlyNumber(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            MsgBox("SOLO SE ACEPTAN NÚMEROS", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public Sub limitMaxLenghtTxt(ByVal MaterialTextBox As Bunifu.Framework.UI.BunifuMaterialTextbox, maxLenght As Integer)
        For Each ctl As Control In MaterialTextBox.Controls
            If ctl.[GetType]() = GetType(TextBox) Then
                Dim txt = CType(ctl, TextBox)
                txt.MaxLength = maxLenght
            End If
        Next
    End Sub 'Limite Textos

    'Retorna los items filtrados desde la lista
    'Filter = Filtro o indice
    'Value = El valor del indice
    'Lista = La lista del indice
    Public Function filterSearch(filter As String, value As String, list As Object)
        Return list.Select(filter & " LIKE '" & value & "%'")
    End Function

    Public Function SetCamelCase(text As String)
        Return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text)
    End Function

    Public Sub scrollForm(pnl As Object, position As Integer)
        pnl.AutoScrollPosition = New Point(0, position)
    End Sub

   

    Public Sub cleanListItems(lst As ListView)
        If lst.Items.Count > 0 Then
            lst.Items.Clear()
        End If
    End Sub

    'Función que gestiona si se ha hecho algún cambio en el richtxtbox de history para condicionar el cambio
    Public Function IsDropChangesInHistory() As Boolean
        Dim bln = True
        If (getBlnMsgVerification()) Then
            If MessageBox.Show("¿DESEA ABANDONAR SIN GUARDAR LOS CAMBIOS EN LA HISTORIA?", "Atención", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                bln = True
                setBlnMsgVerification(False)
            Else
                bln = False
            End If
        End If
        Return bln
    End Function

    'Función encargada de devolver el texto recibido sin ningún espacio, puede ser string o integer
    Public Function trimAnyText(txtToChange As String, typeReturn As String, charSeparator As Char)
        Dim ArrCadena As String() = txtToChange.Split(charSeparator)
        Dim valueReturn As Object = Nothing
        Select Case typeReturn
            Case "string"
                valueReturn = ArrCadena(1).Trim()
            Case "integer"
                valueReturn = CInt(ArrCadena(1).Trim())
        End Select

        Return valueReturn
    End Function

    Public Sub cleanDataBindings(PnlToClean As Object)
        For Each control In PnlToClean.Controls
            control.DataBindings.clear()
        Next
    End Sub

    Public Sub SetTitleAndCenter(text As String, lbl As Label)
        lbl.Text = text
        lbl.Left = (lbl.Parent.Width \ 2) - (lbl.Width \ 2)
    End Sub

    Public Sub FirstInputFocus(Pnl As Control)
        For Each obj As Control In Pnl.Controls
            If obj.[GetType]() = GetType(Bunifu.Framework.UI.BunifuMaterialTextbox) Or obj.[GetType]() = GetType(RichTextBox) Then
                obj.Focus()
                Exit For
            End If
        Next
        scrollForm(Pnl, 0)
    End Sub
End Module