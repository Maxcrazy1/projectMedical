Public Class FrmPrincipal
    Public cedula As String
    Public historyId As String
    Dim mover As Boolean
    Dim px, py As Integer
    Private ctrlFrmPrincipal As New InHome
    Private CtrlPnlListPatients As New InPnlLstPatients
    Private listHistory As New InPnlListHistory

    Private Sub FrmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()
    End Sub 'Contador de personas fecha y hora

    'Efecto de desplazamiento 
    Private Sub PanelTop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PnlTop.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PnlTop.MouseUp
        mover = False
    End Sub

    Private Sub PanelTop_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PnlTop.MouseMove
        If mover Then
            Me.Location = PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - px, Control.MousePosition.Y - Me.Location.Y - py))
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PnlInicio1.LblHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Sub 'Secundero

    'Botones del Menu
    Private Sub BtnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegistrar.Click
        PnlRegistro1.BringToFront()
        ctrlFrmPrincipal.setPressButton(Me.BtnRegistrar)
    End Sub 'Btn Registrar

    Private Sub BtnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLista.Click
        If (IsDropChangesInHistory()) Then
            CtrlPnlListPatients.FillPatientList()
            PnlListado1.BringToFront()
            ctrlFrmPrincipal.setPressButton(Me.BtnLista)
        End If
    End Sub 'Btn Lista

    Private Sub BtnDatos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDatos.Click
        If (IsDropChangesInHistory()) Then
            PnlRegistro1.BringToFront()
            ctrlFrmPrincipal.setPressButton(Me.BtnDatos)
        End If
    End Sub 'Btn Datos

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        If (IsDropChangesInHistory()) Then
            PnlHistoryRegister1.BringToFront()
            ctrlFrmPrincipal.setPressButton(Me.BtnHistory)
            resetFieldsHistory()
            listHistory.FillList("StandardHistory")
            listHistory.FillList("HemanHistory")
            resetFields(PnlHistoria1, {"System.Windows.Forms.RichTextBox"})
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        If (IsDropChangesInHistory()) Then
            Dim users As New InPnlSettings
            Dim settings As New InPnlSettings
            PnlSettings1.BringToFront()
            users.LoadListUsers()
            settings.LoadAppConfigXml()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If (IsDropChangesInHistory()) Then
            End
        End If
    End Sub 'BtnCerrar
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub 'BtnMinimizar

End Class