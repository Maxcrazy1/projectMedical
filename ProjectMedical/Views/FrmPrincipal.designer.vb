Imports System.IO
Imports System.Drawing.Text

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnClose = New System.Windows.Forms.Label()
        Me.BtnMini = New System.Windows.Forms.Label()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.btnSettings = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.PnlInicio1 = New ProjectMedical.PnlInicio()
        Me.PnlHistoryRegister1 = New ProjectMedical.PnlHistoryRegister()
        Me.PnlHistoria1 = New ProjectMedical.PnlHistoria()
        Me.PnlSettings1 = New ProjectMedical.PnlSettings()
        Me.PnlRegistro1 = New ProjectMedical.PnlRegistro()
        Me.PnlListado1 = New ProjectMedical.PnlListado()
        Me.PnlHeman_21 = New ProjectMedical.PnlHeman_2()
        Me.PnlHeman_11 = New ProjectMedical.PnlHeman_1()
        Me.PnlHeman_Final1 = New ProjectMedical.PnlHeman_Final()
        Me.PnlLeft = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BtnRegistrar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblRoleUser = New System.Windows.Forms.Label()
        Me.lblNameUsr = New System.Windows.Forms.Label()
        Me.imgRole = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDra = New System.Windows.Forms.Label()
        Me.lblProfesion = New System.Windows.Forms.Label()
        Me.BtnHistory = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.BtnLista = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnDatos = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PnlTop.SuspendLayout()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelView.SuspendLayout()
        Me.PnlLeft.SuspendLayout()
        CType(Me.imgRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 8
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClose.Location = New System.Drawing.Point(1156, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 28)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btnClose, "Cerrar")
        '
        'BtnMini
        '
        Me.BtnMini.AutoSize = True
        Me.BtnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMini.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMini.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnMini.Location = New System.Drawing.Point(1118, -12)
        Me.BtnMini.Name = "BtnMini"
        Me.BtnMini.Size = New System.Drawing.Size(33, 39)
        Me.BtnMini.TabIndex = 3
        Me.BtnMini.Text = "_"
        Me.ToolTip1.SetToolTip(Me.BtnMini, "Minimizar")
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.PnlTop.Controls.Add(Me.btnSettings)
        Me.PnlTop.Controls.Add(Me.lblName)
        Me.PnlTop.Controls.Add(Me.BtnMini)
        Me.PnlTop.Controls.Add(Me.btnClose)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(1198, 43)
        Me.PnlTop.TabIndex = 1
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.Location = New System.Drawing.Point(1078, 6)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(34, 37)
        Me.btnSettings.TabIndex = 13
        Me.btnSettings.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnSettings, "Ajustes del sistema")
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Futura Md BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(283, 22)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Paciente | Alejandro Uscategui"
        Me.lblName.Visible = False
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.ForeColor = System.Drawing.SystemColors.Control
        Me.Lbl1.Location = New System.Drawing.Point(358, 11)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(219, 22)
        Me.Lbl1.TabIndex = 9
        Me.Lbl1.Text = "IUTA Altos Mirandinos |"
        '
        'Timer1
        '
        '
        'PanelView
        '
        Me.PanelView.Controls.Add(Me.PnlInicio1)
        Me.PanelView.Controls.Add(Me.PnlHistoryRegister1)
        Me.PanelView.Controls.Add(Me.PnlHistoria1)
        Me.PanelView.Controls.Add(Me.PnlSettings1)
        Me.PanelView.Controls.Add(Me.PnlRegistro1)
        Me.PanelView.Controls.Add(Me.PnlListado1)
        Me.PanelView.Controls.Add(Me.PnlHeman_21)
        Me.PanelView.Controls.Add(Me.PnlHeman_11)
        Me.PanelView.Controls.Add(Me.PnlHeman_Final1)
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(256, 43)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(942, 690)
        Me.PanelView.TabIndex = 2
        '
        'PnlInicio1
        '
        Me.PnlInicio1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnlInicio1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlInicio1.Location = New System.Drawing.Point(0, 0)
        Me.PnlInicio1.Name = "PnlInicio1"
        Me.PnlInicio1.Size = New System.Drawing.Size(942, 690)
        Me.PnlInicio1.TabIndex = 1
        '
        'PnlHistoryRegister1
        '
        Me.PnlHistoryRegister1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnlHistoryRegister1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlHistoryRegister1.Location = New System.Drawing.Point(0, 0)
        Me.PnlHistoryRegister1.Name = "PnlHistoryRegister1"
        Me.PnlHistoryRegister1.Size = New System.Drawing.Size(942, 690)
        Me.PnlHistoryRegister1.TabIndex = 4
        '
        'PnlHistoria1
        '
        Me.PnlHistoria1.AutoScroll = True
        Me.PnlHistoria1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnlHistoria1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlHistoria1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlHistoria1.Location = New System.Drawing.Point(0, 0)
        Me.PnlHistoria1.Name = "PnlHistoria1"
        Me.PnlHistoria1.Size = New System.Drawing.Size(942, 690)
        Me.PnlHistoria1.TabIndex = 3
        '
        'PnlSettings1
        '
        Me.PnlSettings1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnlSettings1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSettings1.Location = New System.Drawing.Point(0, 0)
        Me.PnlSettings1.Name = "PnlSettings1"
        Me.PnlSettings1.Size = New System.Drawing.Size(942, 690)
        Me.PnlSettings1.TabIndex = 5
        '
        'PnlRegistro1
        '
        Me.PnlRegistro1.AutoScroll = True
        Me.PnlRegistro1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnlRegistro1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlRegistro1.Location = New System.Drawing.Point(0, 0)
        Me.PnlRegistro1.Name = "PnlRegistro1"
        Me.PnlRegistro1.Size = New System.Drawing.Size(942, 690)
        Me.PnlRegistro1.TabIndex = 0
        '
        'PnlListado1
        '
        Me.PnlListado1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnlListado1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlListado1.Location = New System.Drawing.Point(0, 0)
        Me.PnlListado1.Name = "PnlListado1"
        Me.PnlListado1.Size = New System.Drawing.Size(942, 690)
        Me.PnlListado1.TabIndex = 2
        '
        'PnlHeman_21
        '
        Me.PnlHeman_21.AutoScroll = True
        Me.PnlHeman_21.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnlHeman_21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlHeman_21.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeman_21.Name = "PnlHeman_21"
        Me.PnlHeman_21.Size = New System.Drawing.Size(942, 690)
        Me.PnlHeman_21.TabIndex = 7
        '
        'PnlHeman_11
        '
        Me.PnlHeman_11.AutoScroll = True
        Me.PnlHeman_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnlHeman_11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlHeman_11.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeman_11.Name = "PnlHeman_11"
        Me.PnlHeman_11.Size = New System.Drawing.Size(942, 690)
        Me.PnlHeman_11.TabIndex = 6
        '
        'PnlHeman_Final1
        '
        Me.PnlHeman_Final1.AutoScroll = True
        Me.PnlHeman_Final1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnlHeman_Final1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlHeman_Final1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlHeman_Final1.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeman_Final1.Name = "PnlHeman_Final1"
        Me.PnlHeman_Final1.Size = New System.Drawing.Size(942, 690)
        Me.PnlHeman_Final1.TabIndex = 8
        '
        'PnlLeft
        '
        Me.PnlLeft.BackgroundImage = CType(resources.GetObject("PnlLeft.BackgroundImage"), System.Drawing.Image)
        Me.PnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlLeft.Controls.Add(Me.BunifuFlatButton1)
        Me.PnlLeft.Controls.Add(Me.BtnRegistrar)
        Me.PnlLeft.Controls.Add(Me.lblRoleUser)
        Me.PnlLeft.Controls.Add(Me.lblNameUsr)
        Me.PnlLeft.Controls.Add(Me.imgRole)
        Me.PnlLeft.Controls.Add(Me.PictureBox1)
        Me.PnlLeft.Controls.Add(Me.lblDra)
        Me.PnlLeft.Controls.Add(Me.lblProfesion)
        Me.PnlLeft.Controls.Add(Me.BtnHistory)
        Me.PnlLeft.Controls.Add(Me.ShapeContainer1)
        Me.PnlLeft.Controls.Add(Me.BtnLista)
        Me.PnlLeft.Controls.Add(Me.BtnDatos)
        Me.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlLeft.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.PnlLeft.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.PnlLeft.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.PnlLeft.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.PnlLeft.Location = New System.Drawing.Point(0, 43)
        Me.PnlLeft.Name = "PnlLeft"
        Me.PnlLeft.Quality = 10
        Me.PnlLeft.Size = New System.Drawing.Size(256, 690)
        Me.PnlLeft.TabIndex = 0
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRegistrar.BorderRadius = 0
        Me.BtnRegistrar.ButtonText = " Nuevo Paciente"
        Me.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegistrar.DisabledColor = System.Drawing.Color.Gray
        Me.BtnRegistrar.Font = New System.Drawing.Font("Futura Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnRegistrar.Iconimage = CType(resources.GetObject("BtnRegistrar.Iconimage"), System.Drawing.Image)
        Me.BtnRegistrar.Iconimage_right = Nothing
        Me.BtnRegistrar.Iconimage_right_Selected = Nothing
        Me.BtnRegistrar.Iconimage_Selected = Nothing
        Me.BtnRegistrar.IconMarginLeft = 7
        Me.BtnRegistrar.IconMarginRight = 0
        Me.BtnRegistrar.IconRightVisible = True
        Me.BtnRegistrar.IconRightZoom = 0.0R
        Me.BtnRegistrar.IconVisible = True
        Me.BtnRegistrar.IconZoom = 70.0R
        Me.BtnRegistrar.IsTab = False
        Me.BtnRegistrar.Location = New System.Drawing.Point(-2, 200)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Normalcolor = System.Drawing.Color.Transparent
        Me.BtnRegistrar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnRegistrar.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnRegistrar.selected = False
        Me.BtnRegistrar.Size = New System.Drawing.Size(268, 58)
        Me.BtnRegistrar.TabIndex = 0
        Me.BtnRegistrar.Text = " Nuevo Paciente"
        Me.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnRegistrar.Textcolor = System.Drawing.Color.White
        Me.BtnRegistrar.TextFont = New System.Drawing.Font("Futura Md BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblRoleUser
        '
        Me.lblRoleUser.AutoSize = True
        Me.lblRoleUser.BackColor = System.Drawing.Color.Transparent
        Me.lblRoleUser.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoleUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblRoleUser.Location = New System.Drawing.Point(67, 137)
        Me.lblRoleUser.Name = "lblRoleUser"
        Me.lblRoleUser.Size = New System.Drawing.Size(122, 19)
        Me.lblRoleUser.TabIndex = 17
        Me.lblRoleUser.Text = "Administrador"
        '
        'lblNameUsr
        '
        Me.lblNameUsr.AutoSize = True
        Me.lblNameUsr.BackColor = System.Drawing.Color.Transparent
        Me.lblNameUsr.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameUsr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblNameUsr.Location = New System.Drawing.Point(86, 114)
        Me.lblNameUsr.Name = "lblNameUsr"
        Me.lblNameUsr.Size = New System.Drawing.Size(84, 19)
        Me.lblNameUsr.TabIndex = 16
        Me.lblNameUsr.Text = "Andreina"
        '
        'imgRole
        '
        Me.imgRole.BackColor = System.Drawing.Color.Transparent
        Me.imgRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgRole.Location = New System.Drawing.Point(78, 16)
        Me.imgRole.Name = "imgRole"
        Me.imgRole.Size = New System.Drawing.Size(100, 92)
        Me.imgRole.TabIndex = 15
        Me.imgRole.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(91, 546)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 65)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lblDra
        '
        Me.lblDra.AutoSize = True
        Me.lblDra.BackColor = System.Drawing.Color.Transparent
        Me.lblDra.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblDra.Location = New System.Drawing.Point(16, 626)
        Me.lblDra.Name = "lblDra"
        Me.lblDra.Size = New System.Drawing.Size(224, 20)
        Me.lblDra.TabIndex = 9
        Me.lblDra.Text = "Dra. Ana Maria Sáenz M." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblDra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProfesion
        '
        Me.lblProfesion.AutoSize = True
        Me.lblProfesion.BackColor = System.Drawing.Color.Transparent
        Me.lblProfesion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblProfesion.Location = New System.Drawing.Point(74, 654)
        Me.lblProfesion.Name = "lblProfesion"
        Me.lblProfesion.Size = New System.Drawing.Size(106, 34)
        Me.lblProfesion.TabIndex = 10
        Me.lblProfesion.Text = "DERMÁTOLOGA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblProfesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHistory
        '
        Me.BtnHistory.Activecolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnHistory.BackColor = System.Drawing.Color.Transparent
        Me.BtnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHistory.BorderRadius = 0
        Me.BtnHistory.ButtonText = " Historia del paciente"
        Me.BtnHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHistory.DisabledColor = System.Drawing.Color.Gray
        Me.BtnHistory.Font = New System.Drawing.Font("Futura Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHistory.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnHistory.Iconimage = CType(resources.GetObject("BtnHistory.Iconimage"), System.Drawing.Image)
        Me.BtnHistory.Iconimage_right = Nothing
        Me.BtnHistory.Iconimage_right_Selected = Nothing
        Me.BtnHistory.Iconimage_Selected = Nothing
        Me.BtnHistory.IconMarginLeft = 7
        Me.BtnHistory.IconMarginRight = 0
        Me.BtnHistory.IconRightVisible = True
        Me.BtnHistory.IconRightZoom = 0.0R
        Me.BtnHistory.IconVisible = True
        Me.BtnHistory.IconZoom = 70.0R
        Me.BtnHistory.IsTab = False
        Me.BtnHistory.Location = New System.Drawing.Point(-2, 431)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Normalcolor = System.Drawing.Color.Transparent
        Me.BtnHistory.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnHistory.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnHistory.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnHistory.selected = False
        Me.BtnHistory.Size = New System.Drawing.Size(268, 58)
        Me.BtnHistory.TabIndex = 12
        Me.BtnHistory.Text = " Historia del paciente"
        Me.BtnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnHistory.Textcolor = System.Drawing.Color.White
        Me.BtnHistory.TextFont = New System.Drawing.Font("Futura Md BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHistory.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(256, 690)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 257
        Me.LineShape1.Y1 = 176
        Me.LineShape1.Y2 = 176
        '
        'BtnLista
        '
        Me.BtnLista.Activecolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnLista.BackColor = System.Drawing.Color.Transparent
        Me.BtnLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLista.BorderRadius = 0
        Me.BtnLista.ButtonText = " Lista de pacientes"
        Me.BtnLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLista.DisabledColor = System.Drawing.Color.Gray
        Me.BtnLista.Font = New System.Drawing.Font("Futura Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLista.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnLista.Iconimage = CType(resources.GetObject("BtnLista.Iconimage"), System.Drawing.Image)
        Me.BtnLista.Iconimage_right = Nothing
        Me.BtnLista.Iconimage_right_Selected = Nothing
        Me.BtnLista.Iconimage_Selected = Nothing
        Me.BtnLista.IconMarginLeft = 7
        Me.BtnLista.IconMarginRight = 0
        Me.BtnLista.IconRightVisible = True
        Me.BtnLista.IconRightZoom = 0.0R
        Me.BtnLista.IconVisible = True
        Me.BtnLista.IconZoom = 70.0R
        Me.BtnLista.IsTab = False
        Me.BtnLista.Location = New System.Drawing.Point(-2, 277)
        Me.BtnLista.Name = "BtnLista"
        Me.BtnLista.Normalcolor = System.Drawing.Color.Transparent
        Me.BtnLista.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnLista.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnLista.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLista.selected = False
        Me.BtnLista.Size = New System.Drawing.Size(268, 58)
        Me.BtnLista.TabIndex = 2
        Me.BtnLista.Text = " Lista de pacientes"
        Me.BtnLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnLista.Textcolor = System.Drawing.Color.White
        Me.BtnLista.TextFont = New System.Drawing.Font("Futura Md BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnDatos
        '
        Me.BtnDatos.Activecolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnDatos.BackColor = System.Drawing.Color.Transparent
        Me.BtnDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDatos.BorderRadius = 0
        Me.BtnDatos.ButtonText = "  Datos del Paciente"
        Me.BtnDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDatos.DisabledColor = System.Drawing.Color.Gray
        Me.BtnDatos.Font = New System.Drawing.Font("Futura Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDatos.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnDatos.Iconimage = CType(resources.GetObject("BtnDatos.Iconimage"), System.Drawing.Image)
        Me.BtnDatos.Iconimage_right = Nothing
        Me.BtnDatos.Iconimage_right_Selected = Nothing
        Me.BtnDatos.Iconimage_Selected = Nothing
        Me.BtnDatos.IconMarginLeft = 7
        Me.BtnDatos.IconMarginRight = 0
        Me.BtnDatos.IconRightVisible = True
        Me.BtnDatos.IconRightZoom = 0.0R
        Me.BtnDatos.IconVisible = True
        Me.BtnDatos.IconZoom = 70.0R
        Me.BtnDatos.IsTab = False
        Me.BtnDatos.Location = New System.Drawing.Point(-2, 200)
        Me.BtnDatos.Name = "BtnDatos"
        Me.BtnDatos.Normalcolor = System.Drawing.Color.Transparent
        Me.BtnDatos.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnDatos.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnDatos.selected = False
        Me.BtnDatos.Size = New System.Drawing.Size(268, 58)
        Me.BtnDatos.TabIndex = 5
        Me.BtnDatos.Text = "  Datos del Paciente"
        Me.BtnDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnDatos.Textcolor = System.Drawing.Color.White
        Me.BtnDatos.TextFont = New System.Drawing.Font("Futura Md BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = " Pacientes en espera (2)"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Futura Md BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 7
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 70.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(-2, 354)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(268, 58)
        Me.BunifuFlatButton1.TabIndex = 18
        Me.BunifuFlatButton1.Text = " Pacientes en espera (2)"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Futura Md BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.Visible = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1198, 733)
        Me.Controls.Add(Me.PanelView)
        Me.Controls.Add(Me.PnlLeft)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelView.ResumeLayout(False)
        Me.PnlLeft.ResumeLayout(False)
        Me.PnlLeft.PerformLayout()
        CType(Me.imgRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PnlLeft As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BtnLista As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnRegistrar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PnlTop As System.Windows.Forms.Panel
    Friend WithEvents BtnMini As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents BtnDatos As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PanelView As System.Windows.Forms.Panel
    Friend WithEvents PnlInicio1 As ProjectMedical.PnlInicio
    Friend WithEvents PnlListado1 As ProjectMedical.PnlListado
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents PnlRegistro1 As ProjectMedical.PnlRegistro
    Friend WithEvents lblProfesion As System.Windows.Forms.Label
    Friend WithEvents lblDra As System.Windows.Forms.Label
    Friend WithEvents PnlHistoria1 As ProjectMedical.PnlHistoria
    Friend WithEvents BtnHistory As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PnlHistoryRegister1 As ProjectMedical.PnlHistoryRegister
    Friend WithEvents PnlSettings1 As ProjectMedical.PnlSettings
    Friend WithEvents btnSettings As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblRoleUser As System.Windows.Forms.Label
    Friend WithEvents lblNameUsr As System.Windows.Forms.Label
    Friend WithEvents imgRole As System.Windows.Forms.PictureBox
    Friend WithEvents PnlHeman_11 As ProjectMedical.PnlHeman_1
    Friend WithEvents PnlHeman_21 As ProjectMedical.PnlHeman_2
    Friend WithEvents PnlHeman_Final1 As ProjectMedical.PnlHeman_Final
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    ' Friend WithEvents PnlRegistro1 As ConSql.PnlRegistro

End Class

