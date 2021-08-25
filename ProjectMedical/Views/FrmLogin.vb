Public Class FrmLogin
    Dim mover As Boolean
    Dim px, py As Integer

    'Btn Para ingresar 
    Private Sub BtnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngreso.Click
        Dim ctrlCrud As New ctrlCrud
        ctrlCrud.loginDataUser()
    End Sub

    'Efecto de desplazamiento 
    Private Sub PanelTop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BunifuGradientPanel1.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub
    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BunifuGradientPanel1.MouseUp
        mover = False
    End Sub
    Private Sub PanelTop_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles BunifuGradientPanel1.MouseMove
        If mover Then
            Me.Location = PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - px, Control.MousePosition.Y - Me.Location.Y - py))
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        End
    End Sub  'Cerrar

    Private Sub PictureBox2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        TxtPass.isPassword = False
    End Sub 'Clave visible
    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        TxtPass.isPassword = True
    End Sub 'Clave bloqueada

    Private Sub TxtPass_Enter(sender As Object, e As EventArgs) Handles TxtPass.Enter
        TxtPass.isPassword = True
    End Sub

    Private Sub TxtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUser.KeyDown
        If e.KeyCode = Keys.L And e.Control Then
            FrmPath.Show()
            FrmPath.Focus()
        End If
    End Sub
End Class
