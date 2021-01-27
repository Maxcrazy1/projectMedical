Imports System.Drawing.Text

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnIngreso = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TxtPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtUser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(643, 257)
        Me.BunifuGradientPanel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(258, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 129)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(614, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.BtnIngreso)
        Me.Panel2.Controls.Add(Me.TxtPass)
        Me.Panel2.Controls.Add(Me.TxtUser)
        Me.Panel2.Location = New System.Drawing.Point(121, 165)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 333)
        Me.Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Usuario"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(340, 174)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 39)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'BtnIngreso
        '
        Me.BtnIngreso.Activecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BtnIngreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BtnIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnIngreso.BorderRadius = 5
        Me.BtnIngreso.ButtonText = "Ingresar"
        Me.BtnIngreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngreso.DisabledColor = System.Drawing.Color.Gray
        Me.BtnIngreso.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnIngreso.Iconimage = Nothing
        Me.BtnIngreso.Iconimage_right = Nothing
        Me.BtnIngreso.Iconimage_right_Selected = Nothing
        Me.BtnIngreso.Iconimage_Selected = Nothing
        Me.BtnIngreso.IconMarginLeft = 0
        Me.BtnIngreso.IconMarginRight = 0
        Me.BtnIngreso.IconRightVisible = True
        Me.BtnIngreso.IconRightZoom = 0.0R
        Me.BtnIngreso.IconVisible = True
        Me.BtnIngreso.IconZoom = 90.0R
        Me.BtnIngreso.IsTab = False
        Me.BtnIngreso.Location = New System.Drawing.Point(71, 263)
        Me.BtnIngreso.Name = "BtnIngreso"
        Me.BtnIngreso.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BtnIngreso.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BtnIngreso.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnIngreso.selected = False
        Me.BtnIngreso.Size = New System.Drawing.Size(258, 41)
        Me.BtnIngreso.TabIndex = 0
        Me.BtnIngreso.Text = "Ingresar"
        Me.BtnIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnIngreso.Textcolor = System.Drawing.Color.White
        Me.BtnIngreso.TextFont = New System.Drawing.Font("Futura Md BT", 14.25!)
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.Color.White
        Me.TxtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.ForeColor = System.Drawing.Color.Gray
        Me.TxtPass.HintForeColor = System.Drawing.Color.Black
        Me.TxtPass.HintText = ""
        Me.TxtPass.isPassword = False
        Me.TxtPass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.TxtPass.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TxtPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.TxtPass.LineThickness = 4
        Me.TxtPass.Location = New System.Drawing.Point(71, 173)
        Me.TxtPass.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(258, 41)
        Me.TxtPass.TabIndex = 0
        Me.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.Color.White
        Me.TxtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.ForeColor = System.Drawing.Color.Gray
        Me.TxtUser.HintForeColor = System.Drawing.Color.Black
        Me.TxtUser.HintText = ""
        Me.TxtUser.isPassword = False
        Me.TxtUser.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.TxtUser.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TxtUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.TxtUser.LineThickness = 4
        Me.TxtUser.Location = New System.Drawing.Point(71, 67)
        Me.TxtUser.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(258, 41)
        Me.TxtUser.TabIndex = 1
        Me.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 8
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Futura Md BT", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(132, 521)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(379, 45)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sistema de pacientes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(201, 574)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dra. Ana Maria Sáenz M."
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(643, 615)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnIngreso As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TxtPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtUser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
