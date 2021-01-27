<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PnlHeman_Final
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PnlHeman_Final))
        Me.txtFieldHistory = New System.Windows.Forms.RichTextBox()
        Me.lblFieldHistory = New System.Windows.Forms.Label()
        Me.showMsgs = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRedo = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnUndo = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSelectAll = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnPaste = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCopy = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnDeleteAll = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnTop = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnSaveHistory = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.openFiles = New System.Windows.Forms.OpenFileDialog()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Embol = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BtnBack = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Vinc = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Interf = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Siste = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Intra = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Topicos = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Estero = New Bunifu.Framework.UI.BunifuTileButton()
        Me.trata = New Bunifu.Framework.UI.BunifuTileButton()
        Me.otros = New Bunifu.Framework.UI.BunifuTileButton()
        Me.infec = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Ulcer = New Bunifu.Framework.UI.BunifuTileButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.complic = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Quirur = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Observ = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnNewRegister = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.btnRedo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnUndo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSelectAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPaste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDeleteAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFieldHistory
        '
        Me.txtFieldHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFieldHistory.BulletIndent = 5
        Me.txtFieldHistory.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFieldHistory.Location = New System.Drawing.Point(114, 627)
        Me.txtFieldHistory.Name = "txtFieldHistory"
        Me.txtFieldHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtFieldHistory.Size = New System.Drawing.Size(757, 458)
        Me.txtFieldHistory.TabIndex = 15
        Me.txtFieldHistory.Text = ""
        '
        'lblFieldHistory
        '
        Me.lblFieldHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFieldHistory.AutoSize = True
        Me.lblFieldHistory.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFieldHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFieldHistory.Location = New System.Drawing.Point(186, 554)
        Me.lblFieldHistory.Name = "lblFieldHistory"
        Me.lblFieldHistory.Size = New System.Drawing.Size(613, 41)
        Me.lblFieldHistory.TabIndex = 16
        Me.lblFieldHistory.Text = "Información de las complicaciones"
        Me.lblFieldHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRedo
        '
        Me.btnRedo.BackColor = System.Drawing.Color.Transparent
        Me.btnRedo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRedo.Image = CType(resources.GetObject("btnRedo.Image"), System.Drawing.Image)
        Me.btnRedo.ImageActive = Nothing
        Me.btnRedo.Location = New System.Drawing.Point(42, 933)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Size = New System.Drawing.Size(51, 54)
        Me.btnRedo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRedo.TabIndex = 37
        Me.btnRedo.TabStop = False
        Me.showMsgs.SetToolTip(Me.btnRedo, "Rehacer (Ctrl + y)")
        Me.btnRedo.Zoom = 10
        '
        'BtnUndo
        '
        Me.BtnUndo.BackColor = System.Drawing.Color.Transparent
        Me.BtnUndo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUndo.Image = CType(resources.GetObject("BtnUndo.Image"), System.Drawing.Image)
        Me.BtnUndo.ImageActive = Nothing
        Me.BtnUndo.Location = New System.Drawing.Point(42, 873)
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(51, 54)
        Me.BtnUndo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnUndo.TabIndex = 36
        Me.BtnUndo.TabStop = False
        Me.showMsgs.SetToolTip(Me.BtnUndo, "Deshacer (Ctrl + z)")
        Me.BtnUndo.Zoom = 10
        '
        'btnSelectAll
        '
        Me.btnSelectAll.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectAll.Image = CType(resources.GetObject("btnSelectAll.Image"), System.Drawing.Image)
        Me.btnSelectAll.ImageActive = Nothing
        Me.btnSelectAll.Location = New System.Drawing.Point(42, 813)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(51, 54)
        Me.btnSelectAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSelectAll.TabIndex = 35
        Me.btnSelectAll.TabStop = False
        Me.showMsgs.SetToolTip(Me.btnSelectAll, "Seleccionar Todo (Ctrl + a)")
        Me.btnSelectAll.Zoom = 10
        '
        'btnPaste
        '
        Me.btnPaste.BackColor = System.Drawing.Color.Transparent
        Me.btnPaste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPaste.Image = CType(resources.GetObject("btnPaste.Image"), System.Drawing.Image)
        Me.btnPaste.ImageActive = Nothing
        Me.btnPaste.Location = New System.Drawing.Point(42, 753)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(51, 54)
        Me.btnPaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPaste.TabIndex = 34
        Me.btnPaste.TabStop = False
        Me.showMsgs.SetToolTip(Me.btnPaste, "Pegar (Ctrl + v)")
        Me.btnPaste.Zoom = 10
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.Transparent
        Me.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageActive = Nothing
        Me.btnCopy.Location = New System.Drawing.Point(42, 690)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(51, 54)
        Me.btnCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCopy.TabIndex = 32
        Me.btnCopy.TabStop = False
        Me.showMsgs.SetToolTip(Me.btnCopy, "Copiar (Ctrl + c)")
        Me.btnCopy.Zoom = 10
        '
        'BtnDeleteAll
        '
        Me.BtnDeleteAll.BackColor = System.Drawing.Color.Transparent
        Me.BtnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeleteAll.Image = CType(resources.GetObject("BtnDeleteAll.Image"), System.Drawing.Image)
        Me.BtnDeleteAll.ImageActive = Nothing
        Me.BtnDeleteAll.Location = New System.Drawing.Point(42, 627)
        Me.BtnDeleteAll.Name = "BtnDeleteAll"
        Me.BtnDeleteAll.Size = New System.Drawing.Size(51, 54)
        Me.BtnDeleteAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnDeleteAll.TabIndex = 31
        Me.BtnDeleteAll.TabStop = False
        Me.showMsgs.SetToolTip(Me.BtnDeleteAll, "Borrar todo (Ctrl + q)")
        Me.BtnDeleteAll.Zoom = 10
        '
        'btnTop
        '
        Me.btnTop.BackColor = System.Drawing.Color.Transparent
        Me.btnTop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTop.Image = CType(resources.GetObject("btnTop.Image"), System.Drawing.Image)
        Me.btnTop.ImageActive = Nothing
        Me.btnTop.Location = New System.Drawing.Point(42, 1031)
        Me.btnTop.Name = "btnTop"
        Me.btnTop.Size = New System.Drawing.Size(51, 54)
        Me.btnTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnTop.TabIndex = 30
        Me.btnTop.TabStop = False
        Me.showMsgs.SetToolTip(Me.btnTop, "Ir arriba (Ctrl + w)")
        Me.btnTop.Zoom = 10
        '
        'BtnSaveHistory
        '
        Me.BtnSaveHistory.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnSaveHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnSaveHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSaveHistory.BorderRadius = 2
        Me.BtnSaveHistory.ButtonText = "Guardar"
        Me.BtnSaveHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveHistory.DisabledColor = System.Drawing.Color.Gray
        Me.BtnSaveHistory.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnSaveHistory.Iconimage = CType(resources.GetObject("BtnSaveHistory.Iconimage"), System.Drawing.Image)
        Me.BtnSaveHistory.Iconimage_right = Nothing
        Me.BtnSaveHistory.Iconimage_right_Selected = Nothing
        Me.BtnSaveHistory.Iconimage_Selected = Nothing
        Me.BtnSaveHistory.IconMarginLeft = 0
        Me.BtnSaveHistory.IconMarginRight = 0
        Me.BtnSaveHistory.IconRightVisible = True
        Me.BtnSaveHistory.IconRightZoom = 0.0R
        Me.BtnSaveHistory.IconVisible = True
        Me.BtnSaveHistory.IconZoom = 40.0R
        Me.BtnSaveHistory.IsTab = False
        Me.BtnSaveHistory.Location = New System.Drawing.Point(734, 1125)
        Me.BtnSaveHistory.Name = "BtnSaveHistory"
        Me.BtnSaveHistory.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnSaveHistory.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.BtnSaveHistory.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSaveHistory.selected = False
        Me.BtnSaveHistory.Size = New System.Drawing.Size(137, 48)
        Me.BtnSaveHistory.TabIndex = 27
        Me.BtnSaveHistory.Text = "Guardar"
        Me.BtnSaveHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSaveHistory.Textcolor = System.Drawing.Color.White
        Me.BtnSaveHistory.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showMsgs.SetToolTip(Me.BtnSaveHistory, "Almacenar Información (Ctrl + Enter)")
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(335, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 41)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Pruebas tiroideas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'openFiles
        '
        Me.openFiles.FileName = "Archivo del paciente"
        Me.openFiles.Filter = "Archivos|*.jpg;*.jpeg;*.png;*.doc;*.docx;*.pdf;"
        Me.openFiles.InitialDirectory = "(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)) & ""\Documents"
        Me.openFiles.Multiselect = True
        Me.openFiles.Title = "Por favor seleccione los archivos a almacenar"
        '
        'imgList
        '
        Me.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgList.ImageSize = New System.Drawing.Size(64, 64)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnEliminar})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(203, 30)
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(202, 26)
        Me.BtnEliminar.Text = "Eliminar archivo"
        '
        'Embol
        '
        Me.Embol.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Embol.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Embol.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Embol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Embol.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Embol.ForeColor = System.Drawing.Color.White
        Me.Embol.Image = CType(resources.GetObject("Embol.Image"), System.Drawing.Image)
        Me.Embol.ImagePosition = 19
        Me.Embol.ImageZoom = 55
        Me.Embol.LabelPosition = 54
        Me.Embol.LabelText = "Embolización"
        Me.Embol.Location = New System.Drawing.Point(101, 421)
        Me.Embol.Margin = New System.Windows.Forms.Padding(6)
        Me.Embol.Name = "Embol"
        Me.Embol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Embol.Size = New System.Drawing.Size(237, 79)
        Me.Embol.TabIndex = 59
        '
        'BtnBack
        '
        Me.BtnBack.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBack.BorderRadius = 4
        Me.BtnBack.ButtonText = "Atras"
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.DisabledColor = System.Drawing.Color.Gray
        Me.BtnBack.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnBack.Iconimage = CType(resources.GetObject("BtnBack.Iconimage"), System.Drawing.Image)
        Me.BtnBack.Iconimage_right = Nothing
        Me.BtnBack.Iconimage_right_Selected = Nothing
        Me.BtnBack.Iconimage_Selected = Nothing
        Me.BtnBack.IconMarginLeft = 0
        Me.BtnBack.IconMarginRight = 0
        Me.BtnBack.IconRightVisible = True
        Me.BtnBack.IconRightZoom = 0.0R
        Me.BtnBack.IconVisible = True
        Me.BtnBack.IconZoom = 50.0R
        Me.BtnBack.IsTab = False
        Me.BtnBack.Location = New System.Drawing.Point(114, 1125)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnBack.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.BtnBack.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnBack.selected = False
        Me.BtnBack.Size = New System.Drawing.Size(137, 48)
        Me.BtnBack.TabIndex = 57
        Me.BtnBack.Text = "Atras"
        Me.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnBack.Textcolor = System.Drawing.Color.White
        Me.BtnBack.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Vinc
        '
        Me.Vinc.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Vinc.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Vinc.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Vinc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Vinc.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vinc.ForeColor = System.Drawing.Color.White
        Me.Vinc.Image = CType(resources.GetObject("Vinc.Image"), System.Drawing.Image)
        Me.Vinc.ImagePosition = 19
        Me.Vinc.ImageZoom = 55
        Me.Vinc.LabelPosition = 41
        Me.Vinc.LabelText = "Vincristina"
        Me.Vinc.Location = New System.Drawing.Point(750, 262)
        Me.Vinc.Margin = New System.Windows.Forms.Padding(6)
        Me.Vinc.Name = "Vinc"
        Me.Vinc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Vinc.Size = New System.Drawing.Size(108, 137)
        Me.Vinc.TabIndex = 26
        '
        'Interf
        '
        Me.Interf.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Interf.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Interf.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Interf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Interf.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Interf.ForeColor = System.Drawing.Color.White
        Me.Interf.Image = CType(resources.GetObject("Interf.Image"), System.Drawing.Image)
        Me.Interf.ImagePosition = 19
        Me.Interf.ImageZoom = 55
        Me.Interf.LabelPosition = 41
        Me.Interf.LabelText = "Interferon"
        Me.Interf.Location = New System.Drawing.Point(619, 262)
        Me.Interf.Margin = New System.Windows.Forms.Padding(6)
        Me.Interf.Name = "Interf"
        Me.Interf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Interf.Size = New System.Drawing.Size(108, 137)
        Me.Interf.TabIndex = 25
        '
        'Siste
        '
        Me.Siste.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Siste.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Siste.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Siste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Siste.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Siste.ForeColor = System.Drawing.Color.White
        Me.Siste.Image = CType(resources.GetObject("Siste.Image"), System.Drawing.Image)
        Me.Siste.ImagePosition = 19
        Me.Siste.ImageZoom = 55
        Me.Siste.LabelPosition = 41
        Me.Siste.LabelText = "Sistemico"
        Me.Siste.Location = New System.Drawing.Point(490, 262)
        Me.Siste.Margin = New System.Windows.Forms.Padding(6)
        Me.Siste.Name = "Siste"
        Me.Siste.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Siste.Size = New System.Drawing.Size(108, 137)
        Me.Siste.TabIndex = 24
        '
        'Intra
        '
        Me.Intra.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Intra.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Intra.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Intra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Intra.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Intra.ForeColor = System.Drawing.Color.White
        Me.Intra.Image = CType(resources.GetObject("Intra.Image"), System.Drawing.Image)
        Me.Intra.ImagePosition = 19
        Me.Intra.ImageZoom = 55
        Me.Intra.LabelPosition = 41
        Me.Intra.LabelText = "Intralesional"
        Me.Intra.Location = New System.Drawing.Point(361, 262)
        Me.Intra.Margin = New System.Windows.Forms.Padding(6)
        Me.Intra.Name = "Intra"
        Me.Intra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Intra.Size = New System.Drawing.Size(108, 137)
        Me.Intra.TabIndex = 23
        '
        'Topicos
        '
        Me.Topicos.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Topicos.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Topicos.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Topicos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Topicos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topicos.ForeColor = System.Drawing.Color.White
        Me.Topicos.Image = CType(resources.GetObject("Topicos.Image"), System.Drawing.Image)
        Me.Topicos.ImagePosition = 19
        Me.Topicos.ImageZoom = 55
        Me.Topicos.LabelPosition = 41
        Me.Topicos.LabelText = "Tópicos"
        Me.Topicos.Location = New System.Drawing.Point(230, 262)
        Me.Topicos.Margin = New System.Windows.Forms.Padding(6)
        Me.Topicos.Name = "Topicos"
        Me.Topicos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Topicos.Size = New System.Drawing.Size(108, 137)
        Me.Topicos.TabIndex = 22
        '
        'Estero
        '
        Me.Estero.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Estero.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Estero.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Estero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Estero.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estero.ForeColor = System.Drawing.Color.White
        Me.Estero.Image = CType(resources.GetObject("Estero.Image"), System.Drawing.Image)
        Me.Estero.ImagePosition = 19
        Me.Estero.ImageZoom = 55
        Me.Estero.LabelPosition = 54
        Me.Estero.LabelText = "Esteroides"
        Me.Estero.Location = New System.Drawing.Point(101, 262)
        Me.Estero.Margin = New System.Windows.Forms.Padding(6)
        Me.Estero.Name = "Estero"
        Me.Estero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Estero.Size = New System.Drawing.Size(108, 137)
        Me.Estero.TabIndex = 21
        '
        'trata
        '
        Me.trata.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.trata.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.trata.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.trata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trata.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trata.ForeColor = System.Drawing.Color.White
        Me.trata.Image = CType(resources.GetObject("trata.Image"), System.Drawing.Image)
        Me.trata.ImagePosition = 19
        Me.trata.ImageZoom = 40
        Me.trata.LabelPosition = 41
        Me.trata.LabelText = "Tratamiento"
        Me.trata.Location = New System.Drawing.Point(717, 113)
        Me.trata.Margin = New System.Windows.Forms.Padding(6)
        Me.trata.Name = "trata"
        Me.trata.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.trata.Size = New System.Drawing.Size(140, 137)
        Me.trata.TabIndex = 20
        '
        'otros
        '
        Me.otros.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.otros.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.otros.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.otros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.otros.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otros.ForeColor = System.Drawing.Color.White
        Me.otros.Image = CType(resources.GetObject("otros.Image"), System.Drawing.Image)
        Me.otros.ImagePosition = 19
        Me.otros.ImageZoom = 40
        Me.otros.LabelPosition = 54
        Me.otros.LabelText = "Otros"
        Me.otros.Location = New System.Drawing.Point(563, 113)
        Me.otros.Margin = New System.Windows.Forms.Padding(6)
        Me.otros.Name = "otros"
        Me.otros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.otros.Size = New System.Drawing.Size(140, 137)
        Me.otros.TabIndex = 19
        '
        'infec
        '
        Me.infec.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.infec.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.infec.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.infec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.infec.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infec.ForeColor = System.Drawing.Color.White
        Me.infec.Image = CType(resources.GetObject("infec.Image"), System.Drawing.Image)
        Me.infec.ImagePosition = 19
        Me.infec.ImageZoom = 40
        Me.infec.LabelPosition = 54
        Me.infec.LabelText = "Infección"
        Me.infec.Location = New System.Drawing.Point(409, 113)
        Me.infec.Margin = New System.Windows.Forms.Padding(6)
        Me.infec.Name = "infec"
        Me.infec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.infec.Size = New System.Drawing.Size(140, 137)
        Me.infec.TabIndex = 18
        '
        'Ulcer
        '
        Me.Ulcer.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Ulcer.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Ulcer.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Ulcer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ulcer.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ulcer.ForeColor = System.Drawing.Color.White
        Me.Ulcer.Image = CType(resources.GetObject("Ulcer.Image"), System.Drawing.Image)
        Me.Ulcer.ImagePosition = 19
        Me.Ulcer.ImageZoom = 45
        Me.Ulcer.LabelPosition = 54
        Me.Ulcer.LabelText = "Ulceración"
        Me.Ulcer.Location = New System.Drawing.Point(255, 113)
        Me.Ulcer.Margin = New System.Windows.Forms.Padding(6)
        Me.Ulcer.Name = "Ulcer"
        Me.Ulcer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Ulcer.Size = New System.Drawing.Size(140, 137)
        Me.Ulcer.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(297, 1148)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 41)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'complic
        '
        Me.complic.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.complic.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.complic.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.complic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.complic.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.complic.ForeColor = System.Drawing.Color.White
        Me.complic.Image = CType(resources.GetObject("complic.Image"), System.Drawing.Image)
        Me.complic.ImagePosition = 19
        Me.complic.ImageZoom = 50
        Me.complic.LabelPosition = 54
        Me.complic.LabelText = "Complicaci."
        Me.complic.Location = New System.Drawing.Point(103, 113)
        Me.complic.Margin = New System.Windows.Forms.Padding(6)
        Me.complic.Name = "complic"
        Me.complic.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.complic.Size = New System.Drawing.Size(140, 137)
        Me.complic.TabIndex = 0
        '
        'Quirur
        '
        Me.Quirur.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Quirur.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Quirur.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Quirur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Quirur.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quirur.ForeColor = System.Drawing.Color.White
        Me.Quirur.Image = CType(resources.GetObject("Quirur.Image"), System.Drawing.Image)
        Me.Quirur.ImagePosition = 19
        Me.Quirur.ImageZoom = 55
        Me.Quirur.LabelPosition = 54
        Me.Quirur.LabelText = "Quirurgico"
        Me.Quirur.Location = New System.Drawing.Point(361, 421)
        Me.Quirur.Margin = New System.Windows.Forms.Padding(6)
        Me.Quirur.Name = "Quirur"
        Me.Quirur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Quirur.Size = New System.Drawing.Size(237, 79)
        Me.Quirur.TabIndex = 60
        '
        'Observ
        '
        Me.Observ.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Observ.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Observ.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Observ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Observ.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observ.ForeColor = System.Drawing.Color.White
        Me.Observ.Image = CType(resources.GetObject("Observ.Image"), System.Drawing.Image)
        Me.Observ.ImagePosition = 19
        Me.Observ.ImageZoom = 55
        Me.Observ.LabelPosition = 54
        Me.Observ.LabelText = "Observación"
        Me.Observ.Location = New System.Drawing.Point(619, 421)
        Me.Observ.Margin = New System.Windows.Forms.Padding(6)
        Me.Observ.Name = "Observ"
        Me.Observ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Observ.Size = New System.Drawing.Size(237, 79)
        Me.Observ.TabIndex = 61
        '
        'btnNewRegister
        '
        Me.btnNewRegister.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnNewRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnNewRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNewRegister.BorderRadius = 4
        Me.btnNewRegister.ButtonText = "Nuevo Registro"
        Me.btnNewRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewRegister.DisabledColor = System.Drawing.Color.Gray
        Me.btnNewRegister.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNewRegister.Iconimage = CType(resources.GetObject("btnNewRegister.Iconimage"), System.Drawing.Image)
        Me.btnNewRegister.Iconimage_right = Nothing
        Me.btnNewRegister.Iconimage_right_Selected = Nothing
        Me.btnNewRegister.Iconimage_Selected = Nothing
        Me.btnNewRegister.IconMarginLeft = 0
        Me.btnNewRegister.IconMarginRight = 0
        Me.btnNewRegister.IconRightVisible = True
        Me.btnNewRegister.IconRightZoom = 0.0R
        Me.btnNewRegister.IconVisible = True
        Me.btnNewRegister.IconZoom = 50.0R
        Me.btnNewRegister.IsTab = False
        Me.btnNewRegister.Location = New System.Drawing.Point(424, 1125)
        Me.btnNewRegister.Name = "btnNewRegister"
        Me.btnNewRegister.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnNewRegister.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnNewRegister.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNewRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnNewRegister.selected = False
        Me.btnNewRegister.Size = New System.Drawing.Size(157, 48)
        Me.btnNewRegister.TabIndex = 62
        Me.btnNewRegister.Text = "Nuevo Registro"
        Me.btnNewRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNewRegister.Textcolor = System.Drawing.Color.White
        Me.btnNewRegister.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.OvalShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.OvalShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.OvalShape1.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OvalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape1.Location = New System.Drawing.Point(141, 11)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(36, 35)
        '
        'OvalShape2
        '
        Me.OvalShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.OvalShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.OvalShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.OvalShape2.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OvalShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape2.Location = New System.Drawing.Point(41, 11)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(36, 35)
        '
        'OvalShape3
        '
        Me.OvalShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.OvalShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.OvalShape3.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.OvalShape3.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OvalShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape3.Location = New System.Drawing.Point(91, 11)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(36, 35)
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape3, Me.OvalShape2, Me.OvalShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(871, 1189)
        Me.ShapeContainer2.TabIndex = 63
        Me.ShapeContainer2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 18)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 18)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(152, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 18)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "3"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblSave.Location = New System.Drawing.Point(758, 1105)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(89, 17)
        Me.lblSave.TabIndex = 67
        Me.lblSave.Text = "(Ctrl + Enter)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(469, 1105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "(Ctrl + N)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(149, 1105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "(Alt + ←)"
        '
        'PnlHeman_Final
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNewRegister)
        Me.Controls.Add(Me.Observ)
        Me.Controls.Add(Me.Quirur)
        Me.Controls.Add(Me.Embol)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRedo)
        Me.Controls.Add(Me.BtnUndo)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.btnPaste)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.BtnDeleteAll)
        Me.Controls.Add(Me.btnTop)
        Me.Controls.Add(Me.BtnSaveHistory)
        Me.Controls.Add(Me.Vinc)
        Me.Controls.Add(Me.Interf)
        Me.Controls.Add(Me.Siste)
        Me.Controls.Add(Me.Intra)
        Me.Controls.Add(Me.Topicos)
        Me.Controls.Add(Me.Estero)
        Me.Controls.Add(Me.trata)
        Me.Controls.Add(Me.otros)
        Me.Controls.Add(Me.infec)
        Me.Controls.Add(Me.Ulcer)
        Me.Controls.Add(Me.lblFieldHistory)
        Me.Controls.Add(Me.complic)
        Me.Controls.Add(Me.txtFieldHistory)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PnlHeman_Final"
        Me.Size = New System.Drawing.Size(839, 680)
        CType(Me.btnRedo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnUndo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSelectAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPaste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCopy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDeleteAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents complic As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFieldHistory As System.Windows.Forms.RichTextBox
    Friend WithEvents lblFieldHistory As System.Windows.Forms.Label
    Friend WithEvents Ulcer As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents infec As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents otros As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents trata As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Estero As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Topicos As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Intra As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Siste As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Interf As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Vinc As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnTop As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents showMsgs As System.Windows.Forms.ToolTip
    Friend WithEvents BtnDeleteAll As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCopy As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnPaste As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSelectAll As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnUndo As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnRedo As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents openFiles As System.Windows.Forms.OpenFileDialog
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnSaveHistory As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnBack As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Embol As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Quirur As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Observ As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnNewRegister As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
