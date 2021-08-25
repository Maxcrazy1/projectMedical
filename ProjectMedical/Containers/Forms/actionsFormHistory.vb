Public Class ActionsFormHistory
    Private ctrHistory As New History

    'Atajos de teclado
    Public Sub bindKey(e As KeyEventArgs)
        Dim frm = FrmPrincipal.PnlHistoria1
        If e.KeyCode = Keys.W And e.Control Then
            scrollForm(FrmPrincipal.PnlHistoria1, 0)
        ElseIf e.KeyCode = Keys.Q And e.Control Then
            frm.txtFieldHistory.Text = ""
        ElseIf e.KeyCode = Keys.Z And e.Control Then
            frm.txtFieldHistory.Undo()
        ElseIf e.KeyCode = Keys.Y And e.Control Then
            frm.txtFieldHistory.Redo()
        ElseIf e.KeyCode = Keys.N And e.Control Then
            resetfieldsHistory()
        End If
    End Sub

    'Selecciona todo de richtxtBox
    Public Sub selectAllText(txt As Object)
        txt.SelectAll()
    End Sub

    'Copiar de richtxtBox
    Public Sub copyText(txt As Object)
        Clipboard.SetText(txt.Text)
    End Sub

    'Pega de richtxtBox
    Public Sub pasteText(txt As Object)
        txt.Text = Clipboard.GetText
    End Sub

    'Fija el cursor en el RichTextBox
    Public Sub setCursorText(txt As RichTextBox)
        txt.Focus()
        txt.SelectionStart = txt.TextLength
        txt.ScrollToCaret()
    End Sub
End Class
