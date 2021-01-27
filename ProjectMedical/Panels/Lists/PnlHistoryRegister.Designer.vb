<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PnlHistoryRegister
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PnlHistoryRegister))
        Me.listImage = New System.Windows.Forms.ImageList(Me.components)
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.MenuLeft = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosRecientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosAntiguosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExportar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnDeleteRegister = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnNew = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TabHistory = New System.Windows.Forms.TabControl()
        Me.TabRegistro = New System.Windows.Forms.TabPage()
        Me.lstHistory = New BrightIdeasSoftware.ObjectListView()
        Me.historyId = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.TabHema = New System.Windows.Forms.TabPage()
        Me.lstHeman = New BrightIdeasSoftware.ObjectListView()
        Me.hemanHistoryId = CType(New BrightIdeasSoftware.OLVColumn(),BrightIdeasSoftware.OLVColumn)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuLeft.SuspendLayout
        Me.TabHistory.SuspendLayout
        Me.TabRegistro.SuspendLayout
        CType(Me.lstHistory,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabHema.SuspendLayout
        CType(Me.lstHeman,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'listImage
        '
        Me.listImage.ImageStream = CType(resources.GetObject("listImage.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.listImage.TransparentColor = System.Drawing.Color.Transparent
        Me.listImage.Images.SetKeyName(0, "donante.png")
        '
        'lblRegister
        '
        Me.lblRegister.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblRegister.AutoSize = true
        Me.lblRegister.Font = New System.Drawing.Font("Century Gothic", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63,Byte),Integer), CType(CType(142,Byte),Integer), CType(CType(157,Byte),Integer))
        Me.lblRegister.Location = New System.Drawing.Point(222, 33)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(301, 39)
        Me.lblRegister.TabIndex = 60
        Me.lblRegister.Text = "Registros historicos"
        Me.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuLeft
        '
        Me.MenuLeft.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OToolStripMenuItem})
        Me.MenuLeft.Name = "MenuLeft"
        Me.MenuLeft.Size = New System.Drawing.Size(139, 26)
        '
        'OToolStripMenuItem
        '
        Me.OToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrosRecientesToolStripMenuItem, Me.RegistrosAntiguosToolStripMenuItem})
        Me.OToolStripMenuItem.Name = "OToolStripMenuItem"
        Me.OToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.OToolStripMenuItem.Text = "Ordenar por"
        '
        'RegistrosRecientesToolStripMenuItem
        '
        Me.RegistrosRecientesToolStripMenuItem.Name = "RegistrosRecientesToolStripMenuItem"
        Me.RegistrosRecientesToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RegistrosRecientesToolStripMenuItem.Text = "Registros recientes"
        '
        'RegistrosAntiguosToolStripMenuItem
        '
        Me.RegistrosAntiguosToolStripMenuItem.Name = "RegistrosAntiguosToolStripMenuItem"
        Me.RegistrosAntiguosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RegistrosAntiguosToolStripMenuItem.Text = "Registros antiguos"
        '
        'BtnExportar
        '
        Me.BtnExportar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(163,Byte),Integer))
        Me.BtnExportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(163,Byte),Integer))
        Me.BtnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExportar.BorderRadius = 4
        Me.BtnExportar.ButtonText = "Exportar a Word"
        Me.BtnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportar.DisabledColor = System.Drawing.Color.Gray
        Me.BtnExportar.Enabled = false
        Me.BtnExportar.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnExportar.Iconimage = CType(resources.GetObject("BtnExportar.Iconimage"),System.Drawing.Image)
        Me.BtnExportar.Iconimage_right = Nothing
        Me.BtnExportar.Iconimage_right_Selected = Nothing
        Me.BtnExportar.Iconimage_Selected = Nothing
        Me.BtnExportar.IconMarginLeft = 0
        Me.BtnExportar.IconMarginRight = 0
        Me.BtnExportar.IconRightVisible = true
        Me.BtnExportar.IconRightZoom = 0R
        Me.BtnExportar.IconVisible = true
        Me.BtnExportar.IconZoom = 50R
        Me.BtnExportar.IsTab = false
        Me.BtnExportar.Location = New System.Drawing.Point(657, 596)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(163,Byte),Integer))
        Me.BtnExportar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(141,Byte),Integer))
        Me.BtnExportar.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnExportar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnExportar.selected = false
        Me.BtnExportar.Size = New System.Drawing.Size(164, 48)
        Me.BtnExportar.TabIndex = 58
        Me.BtnExportar.Text = "Exportar a Word"
        Me.BtnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExportar.Textcolor = System.Drawing.Color.White
        Me.BtnExportar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'BtnDeleteRegister
        '
        Me.BtnDeleteRegister.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(163,Byte),Integer))
        Me.BtnDeleteRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(163,Byte),Integer))
        Me.BtnDeleteRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeleteRegister.BorderRadius = 4
        Me.BtnDeleteRegister.ButtonText = "Eliminar Registro"
        Me.BtnDeleteRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeleteRegister.DisabledColor = System.Drawing.Color.Gray
        Me.BtnDeleteRegister.Enabled = false
        Me.BtnDeleteRegister.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnDeleteRegister.Iconimage = CType(resources.GetObject("BtnDeleteRegister.Iconimage"),System.Drawing.Image)
        Me.BtnDeleteRegister.Iconimage_right = Nothing
        Me.BtnDeleteRegister.Iconimage_right_Selected = Nothing
        Me.BtnDeleteRegister.Iconimage_Selected = Nothing
        Me.BtnDeleteRegister.IconMarginLeft = 0
        Me.BtnDeleteRegister.IconMarginRight = 0
        Me.BtnDeleteRegister.IconRightVisible = true
        Me.BtnDeleteRegister.IconRightZoom = 0R
        Me.BtnDeleteRegister.IconVisible = true
        Me.BtnDeleteRegister.IconZoom = 50R
        Me.BtnDeleteRegister.IsTab = false
        Me.BtnDeleteRegister.Location = New System.Drawing.Point(394, 596)
        Me.BtnDeleteRegister.Name = "BtnDeleteRegister"
        Me.BtnDeleteRegister.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(163,Byte),Integer))
        Me.BtnDeleteRegister.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(141,Byte),Integer))
        Me.BtnDeleteRegister.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnDeleteRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnDeleteRegister.selected = false
        Me.BtnDeleteRegister.Size = New System.Drawing.Size(164, 48)
        Me.BtnDeleteRegister.TabIndex = 61
        Me.BtnDeleteRegister.Text = "Eliminar Registro"
        Me.BtnDeleteRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDeleteRegister.Textcolor = System.Drawing.Color.White
        Me.BtnDeleteRegister.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'BtnNew
        '
        Me.BtnNew.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(163,Byte),Integer))
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(163,Byte),Integer))
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNew.BorderRadius = 4
        Me.BtnNew.ButtonText = "Nuevo Registro"
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.DisabledColor = System.Drawing.Color.Gray
        Me.BtnNew.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnNew.Iconimage = CType(resources.GetObject("BtnNew.Iconimage"),System.Drawing.Image)
        Me.BtnNew.Iconimage_right = Nothing
        Me.BtnNew.Iconimage_right_Selected = Nothing
        Me.BtnNew.Iconimage_Selected = Nothing
        Me.BtnNew.IconMarginLeft = 0
        Me.BtnNew.IconMarginRight = 0
        Me.BtnNew.IconRightVisible = true
        Me.BtnNew.IconRightZoom = 0R
        Me.BtnNew.IconVisible = true
        Me.BtnNew.IconZoom = 50R
        Me.BtnNew.IsTab = false
        Me.BtnNew.Location = New System.Drawing.Point(124, 596)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(163,Byte),Integer))
        Me.BtnNew.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(57,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(141,Byte),Integer))
        Me.BtnNew.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnNew.selected = false
        Me.BtnNew.Size = New System.Drawing.Size(164, 48)
        Me.BtnNew.TabIndex = 56
        Me.BtnNew.Text = "Nuevo Registro"
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNew.Textcolor = System.Drawing.Color.White
        Me.BtnNew.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        '
        'TabHistory
        '
        Me.TabHistory.Controls.Add(Me.TabRegistro)
        Me.TabHistory.Controls.Add(Me.TabHema)
        Me.TabHistory.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabHistory.Font = New System.Drawing.Font("Century Gothic", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TabHistory.Location = New System.Drawing.Point(103, 38)
        Me.TabHistory.Name = "TabHistory"
        Me.TabHistory.SelectedIndex = 0
        Me.TabHistory.Size = New System.Drawing.Size(747, 537)
        Me.TabHistory.TabIndex = 62
        '
        'TabRegistro
        '
        Me.TabRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(254,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.TabRegistro.Controls.Add(Me.lstHistory)
        Me.TabRegistro.Controls.Add(Me.lblRegister)
        Me.TabRegistro.Location = New System.Drawing.Point(4, 30)
        Me.TabRegistro.Name = "TabRegistro"
        Me.TabRegistro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRegistro.Size = New System.Drawing.Size(739, 503)
        Me.TabRegistro.TabIndex = 0
        Me.TabRegistro.Text = "Registros historicos"
        '
        'lstHistory
        '
        Me.lstHistory.AllColumns.Add(Me.historyId)
        Me.lstHistory.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(203,Byte),Integer), CType(CType(241,Byte),Integer), CType(CType(233,Byte),Integer))
        Me.lstHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lstHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(254,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.lstHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.historyId})
        Me.lstHistory.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstHistory.EmptyListMsg = "El paciente no tiene registros"
        Me.lstHistory.EmptyListMsgFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lstHistory.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lstHistory.FullRowSelect = true
        Me.lstHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstHistory.Location = New System.Drawing.Point(52, 104)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.ShowGroups = false
        Me.lstHistory.Size = New System.Drawing.Size(641, 349)
        Me.lstHistory.SmallImageList = Me.listImage
        Me.lstHistory.TabIndex = 62
        Me.lstHistory.TileSize = New System.Drawing.Size(200, 36)
        Me.lstHistory.UseAlternatingBackColors = true
        Me.lstHistory.UseCompatibleStateImageBehavior = false
        Me.lstHistory.UseFiltering = true
        Me.lstHistory.View = System.Windows.Forms.View.SmallIcon
        '
        'historyId
        '
        Me.historyId.AspectName = "historyId"
        Me.historyId.Text = "historyId"
        Me.historyId.UseInitialLetterForGroup = true
        Me.historyId.Width = 120
        '
        'TabHema
        '
        Me.TabHema.BackColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(254,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.TabHema.Controls.Add(Me.lstHeman)
        Me.TabHema.Controls.Add(Me.Label1)
        Me.TabHema.Location = New System.Drawing.Point(4, 30)
        Me.TabHema.Name = "TabHema"
        Me.TabHema.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHema.Size = New System.Drawing.Size(739, 503)
        Me.TabHema.TabIndex = 1
        Me.TabHema.Text = "Registros de Hemangioma"
        '
        'lstHeman
        '
        Me.lstHeman.AllColumns.Add(Me.hemanHistoryId)
        Me.lstHeman.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(203,Byte),Integer), CType(CType(241,Byte),Integer), CType(CType(233,Byte),Integer))
        Me.lstHeman.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lstHeman.BackColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(254,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.lstHeman.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.hemanHistoryId})
        Me.lstHeman.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstHeman.EmptyListMsg = "El paciente no tiene registros"
        Me.lstHeman.EmptyListMsgFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lstHeman.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lstHeman.FullRowSelect = true
        Me.lstHeman.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstHeman.Location = New System.Drawing.Point(52, 104)
        Me.lstHeman.Name = "lstHeman"
        Me.lstHeman.ShowGroups = false
        Me.lstHeman.Size = New System.Drawing.Size(641, 349)
        Me.lstHeman.SmallImageList = Me.listImage
        Me.lstHeman.TabIndex = 64
        Me.lstHeman.TileSize = New System.Drawing.Size(200, 36)
        Me.lstHeman.UseAlternatingBackColors = true
        Me.lstHeman.UseCompatibleStateImageBehavior = false
        Me.lstHeman.UseFilterIndicator = false
        Me.lstHeman.View = System.Windows.Forms.View.SmallIcon
        '
        'hemanHistoryId
        '
        Me.hemanHistoryId.AspectName = "hemanHistoryId"
        Me.hemanHistoryId.Text = "historyId"
        Me.hemanHistoryId.UseInitialLetterForGroup = true
        Me.hemanHistoryId.Width = 120
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63,Byte),Integer), CType(CType(142,Byte),Integer), CType(CType(157,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(159, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 39)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Registros de hemangioma"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlHistoryRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(254,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Controls.Add(Me.TabHistory)
        Me.Controls.Add(Me.BtnDeleteRegister)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.BtnNew)
        Me.Name = "PnlHistoryRegister"
        Me.Size = New System.Drawing.Size(884, 675)
        Me.MenuLeft.ResumeLayout(false)
        Me.TabHistory.ResumeLayout(false)
        Me.TabRegistro.ResumeLayout(false)
        Me.TabRegistro.PerformLayout
        CType(Me.lstHistory,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabHema.ResumeLayout(false)
        Me.TabHema.PerformLayout
        CType(Me.lstHeman,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents lblRegister As System.Windows.Forms.Label
    Friend WithEvents listImage As System.Windows.Forms.ImageList
    Friend WithEvents MenuLeft As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrosRecientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrosAntiguosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnExportar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnDeleteRegister As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnNew As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TabHistory As System.Windows.Forms.TabControl
    Friend WithEvents TabRegistro As System.Windows.Forms.TabPage
    Friend WithEvents TabHema As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lstHistory As BrightIdeasSoftware.ObjectListView
    Public WithEvents historyId As BrightIdeasSoftware.OLVColumn
    Public WithEvents lstHeman As BrightIdeasSoftware.ObjectListView
    Public WithEvents hemanHistoryId As BrightIdeasSoftware.OLVColumn

End Class
