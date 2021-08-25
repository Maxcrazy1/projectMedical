<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PnlHistoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PnlHistoria))
        Me.txtFieldHistory = New System.Windows.Forms.RichTextBox()
        Me.lblFieldHistory = New System.Windows.Forms.Label()
        Me.fieldDateConsultation = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.showMsgs = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRedo = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnUndo = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSelectAll = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnPaste = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCopy = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnDeleteAll = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnTop = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnSaveHistory = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAddFiles = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnOpenFolder = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.controles = New Bunifu.Framework.UI.BunifuTileButton()
        Me.plan = New Bunifu.Framework.UI.BunifuTileButton()
        Me.DX = New Bunifu.Framework.UI.BunifuTileButton()
        Me.unas = New Bunifu.Framework.UI.BunifuTileButton()
        Me.mucosas = New Bunifu.Framework.UI.BunifuTileButton()
        Me.cuero = New Bunifu.Framework.UI.BunifuTileButton()
        Me.piel = New Bunifu.Framework.UI.BunifuTileButton()
        Me.habitos = New Bunifu.Framework.UI.BunifuTileButton()
        Me.familiares = New Bunifu.Framework.UI.BunifuTileButton()
        Me.personales = New Bunifu.Framework.UI.BunifuTileButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.enfermedad = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.openFiles = New System.Windows.Forms.OpenFileDialog()
        Me.listFiles = New System.Windows.Forms.ListView()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnNew = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.btnRedo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnUndo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSelectAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPaste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDeleteAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFieldHistory
        '
        Me.txtFieldHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFieldHistory.BulletIndent = 5
        Me.txtFieldHistory.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFieldHistory.Location = New System.Drawing.Point(93, 559)
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
        Me.lblFieldHistory.Location = New System.Drawing.Point(143, 496)
        Me.lblFieldHistory.Name = "lblFieldHistory"
        Me.lblFieldHistory.Size = New System.Drawing.Size(654, 41)
        Me.lblFieldHistory.TabIndex = 16
        Me.lblFieldHistory.Text = "Información de la enfermedad actual"
        Me.lblFieldHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fieldDateConsultation
        '
        Me.fieldDateConsultation.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.fieldDateConsultation.BorderRadius = 4
        Me.fieldDateConsultation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fieldDateConsultation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.fieldDateConsultation.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fieldDateConsultation.FormatCustom = Nothing
        Me.fieldDateConsultation.Location = New System.Drawing.Point(93, 417)
        Me.fieldDateConsultation.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.fieldDateConsultation.Name = "fieldDateConsultation"
        Me.fieldDateConsultation.Size = New System.Drawing.Size(303, 36)
        Me.fieldDateConsultation.TabIndex = 28
        Me.fieldDateConsultation.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Fecha de la consulta"
        '
        'btnRedo
        '
        Me.btnRedo.BackColor = System.Drawing.Color.Transparent
        Me.btnRedo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRedo.Image = CType(resources.GetObject("btnRedo.Image"), System.Drawing.Image)
        Me.btnRedo.ImageActive = Nothing
        Me.btnRedo.Location = New System.Drawing.Point(21, 865)
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
        Me.BtnUndo.Location = New System.Drawing.Point(21, 805)
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
        Me.btnSelectAll.Location = New System.Drawing.Point(21, 745)
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
        Me.btnPaste.Location = New System.Drawing.Point(21, 685)
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
        Me.btnCopy.Location = New System.Drawing.Point(21, 622)
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
        Me.BtnDeleteAll.Location = New System.Drawing.Point(21, 559)
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
        Me.btnTop.Location = New System.Drawing.Point(21, 963)
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
        Me.BtnSaveHistory.ButtonText = "Guardar información"
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
        Me.BtnSaveHistory.Location = New System.Drawing.Point(643, 1416)
        Me.BtnSaveHistory.Name = "BtnSaveHistory"
        Me.BtnSaveHistory.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnSaveHistory.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.BtnSaveHistory.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnSaveHistory.selected = False
        Me.BtnSaveHistory.Size = New System.Drawing.Size(207, 48)
        Me.BtnSaveHistory.TabIndex = 27
        Me.BtnSaveHistory.Text = "Guardar información"
        Me.BtnSaveHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSaveHistory.Textcolor = System.Drawing.Color.White
        Me.BtnSaveHistory.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showMsgs.SetToolTip(Me.BtnSaveHistory, "Almacenar Información (Ctrl + Enter)")
        '
        'btnAddFiles
        '
        Me.btnAddFiles.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnAddFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnAddFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddFiles.BorderRadius = 2
        Me.btnAddFiles.ButtonText = "Añadir archivos"
        Me.btnAddFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFiles.DisabledColor = System.Drawing.Color.Gray
        Me.btnAddFiles.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAddFiles.Iconimage = CType(resources.GetObject("btnAddFiles.Iconimage"), System.Drawing.Image)
        Me.btnAddFiles.Iconimage_right = Nothing
        Me.btnAddFiles.Iconimage_right_Selected = Nothing
        Me.btnAddFiles.Iconimage_Selected = Nothing
        Me.btnAddFiles.IconMarginLeft = 0
        Me.btnAddFiles.IconMarginRight = 0
        Me.btnAddFiles.IconRightVisible = True
        Me.btnAddFiles.IconRightZoom = 0.0R
        Me.btnAddFiles.IconVisible = True
        Me.btnAddFiles.IconZoom = 40.0R
        Me.btnAddFiles.IsTab = False
        Me.btnAddFiles.Location = New System.Drawing.Point(723, 1060)
        Me.btnAddFiles.Name = "btnAddFiles"
        Me.btnAddFiles.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnAddFiles.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnAddFiles.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAddFiles.selected = False
        Me.btnAddFiles.Size = New System.Drawing.Size(127, 45)
        Me.btnAddFiles.TabIndex = 60
        Me.btnAddFiles.Text = "Añadir archivos"
        Me.btnAddFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddFiles.Textcolor = System.Drawing.Color.White
        Me.btnAddFiles.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showMsgs.SetToolTip(Me.btnAddFiles, "Almacenar Información (Ctrl + Enter)")
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnOpenFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnOpenFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOpenFolder.BorderRadius = 2
        Me.btnOpenFolder.ButtonText = "Abrir carpeta"
        Me.btnOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenFolder.DisabledColor = System.Drawing.Color.Gray
        Me.btnOpenFolder.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOpenFolder.Iconimage = CType(resources.GetObject("btnOpenFolder.Iconimage"), System.Drawing.Image)
        Me.btnOpenFolder.Iconimage_right = Nothing
        Me.btnOpenFolder.Iconimage_right_Selected = Nothing
        Me.btnOpenFolder.Iconimage_Selected = Nothing
        Me.btnOpenFolder.IconMarginLeft = 0
        Me.btnOpenFolder.IconMarginRight = 0
        Me.btnOpenFolder.IconRightVisible = True
        Me.btnOpenFolder.IconRightZoom = 0.0R
        Me.btnOpenFolder.IconVisible = True
        Me.btnOpenFolder.IconZoom = 40.0R
        Me.btnOpenFolder.IsTab = False
        Me.btnOpenFolder.Location = New System.Drawing.Point(93, 1060)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnOpenFolder.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnOpenFolder.OnHoverTextColor = System.Drawing.Color.White
        Me.btnOpenFolder.selected = False
        Me.btnOpenFolder.Size = New System.Drawing.Size(127, 45)
        Me.btnOpenFolder.TabIndex = 62
        Me.btnOpenFolder.Text = "Abrir carpeta"
        Me.btnOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnOpenFolder.Textcolor = System.Drawing.Color.White
        Me.btnOpenFolder.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showMsgs.SetToolTip(Me.btnOpenFolder, "Almacenar Información (Ctrl + Enter)")
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(527, 1432)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "(Ctrl + Enter) ->"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(273, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(385, 41)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Campos de la historia"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'controles
        '
        Me.controles.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.controles.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.controles.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.controles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.controles.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.controles.ForeColor = System.Drawing.Color.White
        Me.controles.Image = CType(resources.GetObject("controles.Image"), System.Drawing.Image)
        Me.controles.ImagePosition = 19
        Me.controles.ImageZoom = 55
        Me.controles.LabelPosition = 41
        Me.controles.LabelText = "Controles"
        Me.controles.Location = New System.Drawing.Point(742, 242)
        Me.controles.Margin = New System.Windows.Forms.Padding(6)
        Me.controles.Name = "controles"
        Me.controles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.controles.Size = New System.Drawing.Size(108, 137)
        Me.controles.TabIndex = 26
        '
        'plan
        '
        Me.plan.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.plan.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.plan.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.plan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.plan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plan.ForeColor = System.Drawing.Color.White
        Me.plan.Image = CType(resources.GetObject("plan.Image"), System.Drawing.Image)
        Me.plan.ImagePosition = 19
        Me.plan.ImageZoom = 55
        Me.plan.LabelPosition = 41
        Me.plan.LabelText = "Plan"
        Me.plan.Location = New System.Drawing.Point(611, 242)
        Me.plan.Margin = New System.Windows.Forms.Padding(6)
        Me.plan.Name = "plan"
        Me.plan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.plan.Size = New System.Drawing.Size(108, 137)
        Me.plan.TabIndex = 25
        '
        'DX
        '
        Me.DX.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.DX.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.DX.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.DX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DX.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DX.ForeColor = System.Drawing.Color.White
        Me.DX.Image = CType(resources.GetObject("DX.Image"), System.Drawing.Image)
        Me.DX.ImagePosition = 19
        Me.DX.ImageZoom = 55
        Me.DX.LabelPosition = 41
        Me.DX.LabelText = "Dx"
        Me.DX.Location = New System.Drawing.Point(482, 242)
        Me.DX.Margin = New System.Windows.Forms.Padding(6)
        Me.DX.Name = "DX"
        Me.DX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DX.Size = New System.Drawing.Size(108, 137)
        Me.DX.TabIndex = 24
        '
        'unas
        '
        Me.unas.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.unas.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.unas.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.unas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.unas.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unas.ForeColor = System.Drawing.Color.White
        Me.unas.Image = CType(resources.GetObject("unas.Image"), System.Drawing.Image)
        Me.unas.ImagePosition = 19
        Me.unas.ImageZoom = 55
        Me.unas.LabelPosition = 41
        Me.unas.LabelText = "Uñas"
        Me.unas.Location = New System.Drawing.Point(353, 242)
        Me.unas.Margin = New System.Windows.Forms.Padding(6)
        Me.unas.Name = "unas"
        Me.unas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.unas.Size = New System.Drawing.Size(108, 137)
        Me.unas.TabIndex = 23
        '
        'mucosas
        '
        Me.mucosas.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.mucosas.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.mucosas.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.mucosas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mucosas.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mucosas.ForeColor = System.Drawing.Color.White
        Me.mucosas.Image = CType(resources.GetObject("mucosas.Image"), System.Drawing.Image)
        Me.mucosas.ImagePosition = 19
        Me.mucosas.ImageZoom = 55
        Me.mucosas.LabelPosition = 41
        Me.mucosas.LabelText = "Mucosas"
        Me.mucosas.Location = New System.Drawing.Point(222, 242)
        Me.mucosas.Margin = New System.Windows.Forms.Padding(6)
        Me.mucosas.Name = "mucosas"
        Me.mucosas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mucosas.Size = New System.Drawing.Size(108, 137)
        Me.mucosas.TabIndex = 22
        '
        'cuero
        '
        Me.cuero.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cuero.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cuero.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.cuero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cuero.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuero.ForeColor = System.Drawing.Color.White
        Me.cuero.Image = CType(resources.GetObject("cuero.Image"), System.Drawing.Image)
        Me.cuero.ImagePosition = 19
        Me.cuero.ImageZoom = 55
        Me.cuero.LabelPosition = 54
        Me.cuero.LabelText = "Cuero Cabelludo"
        Me.cuero.Location = New System.Drawing.Point(93, 242)
        Me.cuero.Margin = New System.Windows.Forms.Padding(6)
        Me.cuero.Name = "cuero"
        Me.cuero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cuero.Size = New System.Drawing.Size(108, 137)
        Me.cuero.TabIndex = 21
        '
        'piel
        '
        Me.piel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.piel.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.piel.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.piel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.piel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.piel.ForeColor = System.Drawing.Color.White
        Me.piel.Image = CType(resources.GetObject("piel.Image"), System.Drawing.Image)
        Me.piel.ImagePosition = 19
        Me.piel.ImageZoom = 40
        Me.piel.LabelPosition = 41
        Me.piel.LabelText = "Piel"
        Me.piel.Location = New System.Drawing.Point(710, 93)
        Me.piel.Margin = New System.Windows.Forms.Padding(6)
        Me.piel.Name = "piel"
        Me.piel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.piel.Size = New System.Drawing.Size(140, 137)
        Me.piel.TabIndex = 20
        '
        'habitos
        '
        Me.habitos.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.habitos.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.habitos.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.habitos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.habitos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.habitos.ForeColor = System.Drawing.Color.White
        Me.habitos.Image = CType(resources.GetObject("habitos.Image"), System.Drawing.Image)
        Me.habitos.ImagePosition = 19
        Me.habitos.ImageZoom = 40
        Me.habitos.LabelPosition = 54
        Me.habitos.LabelText = "Hábitos Psicobio."
        Me.habitos.Location = New System.Drawing.Point(549, 93)
        Me.habitos.Margin = New System.Windows.Forms.Padding(6)
        Me.habitos.Name = "habitos"
        Me.habitos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.habitos.Size = New System.Drawing.Size(140, 137)
        Me.habitos.TabIndex = 19
        '
        'familiares
        '
        Me.familiares.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.familiares.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.familiares.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.familiares.Cursor = System.Windows.Forms.Cursors.Hand
        Me.familiares.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.familiares.ForeColor = System.Drawing.Color.White
        Me.familiares.Image = CType(resources.GetObject("familiares.Image"), System.Drawing.Image)
        Me.familiares.ImagePosition = 19
        Me.familiares.ImageZoom = 40
        Me.familiares.LabelPosition = 54
        Me.familiares.LabelText = "Antec. Familiares"
        Me.familiares.Location = New System.Drawing.Point(397, 93)
        Me.familiares.Margin = New System.Windows.Forms.Padding(6)
        Me.familiares.Name = "familiares"
        Me.familiares.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.familiares.Size = New System.Drawing.Size(140, 137)
        Me.familiares.TabIndex = 18
        '
        'personales
        '
        Me.personales.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.personales.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.personales.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.personales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.personales.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personales.ForeColor = System.Drawing.Color.White
        Me.personales.Image = CType(resources.GetObject("personales.Image"), System.Drawing.Image)
        Me.personales.ImagePosition = 19
        Me.personales.ImageZoom = 45
        Me.personales.LabelPosition = 54
        Me.personales.LabelText = "Antec. Personales"
        Me.personales.Location = New System.Drawing.Point(245, 93)
        Me.personales.Margin = New System.Windows.Forms.Padding(6)
        Me.personales.Name = "personales"
        Me.personales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.personales.Size = New System.Drawing.Size(140, 137)
        Me.personales.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(411, 1446)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 41)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'enfermedad
        '
        Me.enfermedad.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.enfermedad.color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.enfermedad.colorActive = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.enfermedad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enfermedad.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enfermedad.ForeColor = System.Drawing.Color.White
        Me.enfermedad.Image = CType(resources.GetObject("enfermedad.Image"), System.Drawing.Image)
        Me.enfermedad.ImagePosition = 19
        Me.enfermedad.ImageZoom = 50
        Me.enfermedad.LabelPosition = 54
        Me.enfermedad.LabelText = "Enfermedad Actual"
        Me.enfermedad.Location = New System.Drawing.Point(93, 93)
        Me.enfermedad.Margin = New System.Windows.Forms.Padding(6)
        Me.enfermedad.Name = "enfermedad"
        Me.enfermedad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.enfermedad.Size = New System.Drawing.Size(140, 137)
        Me.enfermedad.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(310, 1432)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "<- (Ctrl + N)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMedia
        '
        Me.lblMedia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMedia.Location = New System.Drawing.Point(289, 1060)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(362, 41)
        Me.lblMedia.TabIndex = 59
        Me.lblMedia.Text = "Archivos multimedia"
        Me.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'openFiles
        '
        Me.openFiles.FileName = "Archivo del paciente"
        Me.openFiles.Filter = "Archivos|*.jpg;*.jpeg;*.png;*.doc;*.docx;*.pdf;"
        Me.openFiles.InitialDirectory = "(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)) & ""\Documents"
        Me.openFiles.Multiselect = True
        Me.openFiles.Title = "Por favor seleccione los archivos a almacenar"
        '
        'listFiles
        '
        Me.listFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.listFiles.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listFiles.LargeImageList = Me.imgList
        Me.listFiles.Location = New System.Drawing.Point(93, 1126)
        Me.listFiles.Name = "listFiles"
        Me.listFiles.Size = New System.Drawing.Size(757, 241)
        Me.listFiles.SmallImageList = Me.imgList
        Me.listFiles.TabIndex = 61
        Me.listFiles.UseCompatibleStateImageBehavior = False
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
        'BtnNew
        '
        Me.BtnNew.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNew.BorderRadius = 4
        Me.BtnNew.ButtonText = "Nuevo Registro"
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.DisabledColor = System.Drawing.Color.Gray
        Me.BtnNew.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnNew.Iconimage = CType(resources.GetObject("BtnNew.Iconimage"), System.Drawing.Image)
        Me.BtnNew.Iconimage_right = Nothing
        Me.BtnNew.Iconimage_right_Selected = Nothing
        Me.BtnNew.Iconimage_Selected = Nothing
        Me.BtnNew.IconMarginLeft = 0
        Me.BtnNew.IconMarginRight = 0
        Me.BtnNew.IconRightVisible = True
        Me.BtnNew.IconRightZoom = 0.0R
        Me.BtnNew.IconVisible = True
        Me.BtnNew.IconZoom = 50.0R
        Me.BtnNew.IsTab = False
        Me.BtnNew.Location = New System.Drawing.Point(93, 1416)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnNew.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.BtnNew.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnNew.selected = False
        Me.BtnNew.Size = New System.Drawing.Size(207, 48)
        Me.BtnNew.TabIndex = 57
        Me.BtnNew.Text = "Nuevo Registro"
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnNew.Textcolor = System.Drawing.Color.White
        Me.BtnNew.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PnlHistoria
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.btnOpenFolder)
        Me.Controls.Add(Me.btnAddFiles)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRedo)
        Me.Controls.Add(Me.BtnUndo)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.btnPaste)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.BtnDeleteAll)
        Me.Controls.Add(Me.btnTop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fieldDateConsultation)
        Me.Controls.Add(Me.BtnSaveHistory)
        Me.Controls.Add(Me.controles)
        Me.Controls.Add(Me.plan)
        Me.Controls.Add(Me.DX)
        Me.Controls.Add(Me.unas)
        Me.Controls.Add(Me.mucosas)
        Me.Controls.Add(Me.cuero)
        Me.Controls.Add(Me.piel)
        Me.Controls.Add(Me.habitos)
        Me.Controls.Add(Me.familiares)
        Me.Controls.Add(Me.personales)
        Me.Controls.Add(Me.lblFieldHistory)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.enfermedad)
        Me.Controls.Add(Me.txtFieldHistory)
        Me.Controls.Add(Me.listFiles)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PnlHistoria"
        Me.Size = New System.Drawing.Size(895, 588)
        CType(Me.btnRedo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnUndo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSelectAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPaste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCopy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDeleteAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents enfermedad As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFieldHistory As System.Windows.Forms.RichTextBox
    Friend WithEvents lblFieldHistory As System.Windows.Forms.Label
    Friend WithEvents personales As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents familiares As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents habitos As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents piel As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents cuero As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents mucosas As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents unas As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents DX As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents plan As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents controles As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents fieldDateConsultation As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTop As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents showMsgs As System.Windows.Forms.ToolTip
    Friend WithEvents BtnDeleteAll As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCopy As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnPaste As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSelectAll As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnUndo As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnRedo As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMedia As System.Windows.Forms.Label
    Friend WithEvents openFiles As System.Windows.Forms.OpenFileDialog
    Friend WithEvents listFiles As System.Windows.Forms.ListView
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnSaveHistory As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAddFiles As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnOpenFolder As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnNew As Bunifu.Framework.UI.BunifuFlatButton

End Class
