<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PnlListado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PnlListado))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarVariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstPatients = New BrightIdeasSoftware.ObjectListView()
        Me.documentId = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.namePatient = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.lastName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.profession = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.genre = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.lstPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "female.png")
        Me.ImageList1.Images.SetKeyName(1, "male.png")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnEliminar, Me.SeleccionarVariosToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(220, 56)
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(219, 26)
        Me.BtnEliminar.Text = "Eliminar"
        '
        'SeleccionarVariosToolStripMenuItem
        '
        Me.SeleccionarVariosToolStripMenuItem.Name = "SeleccionarVariosToolStripMenuItem"
        Me.SeleccionarVariosToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.SeleccionarVariosToolStripMenuItem.Text = "Seleccionar varios"
        '
        'txtSearch
        '
        Me.txtSearch.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtSearch.BorderThickness = 3
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.isPassword = False
        Me.txtSearch.Location = New System.Drawing.Point(178, 84)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(582, 46)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(335, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 32)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Texto de busqueda"
        '
        'lstPatients
        '
        Me.lstPatients.AllColumns.Add(Me.documentId)
        Me.lstPatients.AllColumns.Add(Me.namePatient)
        Me.lstPatients.AllColumns.Add(Me.lastName)
        Me.lstPatients.AllColumns.Add(Me.profession)
        Me.lstPatients.AllColumns.Add(Me.genre)
        Me.lstPatients.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lstPatients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPatients.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstPatients.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.documentId, Me.namePatient, Me.lastName, Me.profession, Me.genre})
        Me.lstPatients.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstPatients.EmptyListMsg = "No hay pacientes registrados"
        Me.lstPatients.EmptyListMsgFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lstPatients.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lstPatients.FullRowSelect = True
        Me.lstPatients.Location = New System.Drawing.Point(72, 171)
        Me.lstPatients.Name = "lstPatients"
        Me.lstPatients.ShowGroups = False
        Me.lstPatients.Size = New System.Drawing.Size(795, 467)
        Me.lstPatients.SmallImageList = Me.ImageList1
        Me.lstPatients.TabIndex = 11
        Me.lstPatients.UseAlternatingBackColors = True
        Me.lstPatients.UseCompatibleStateImageBehavior = False
        Me.lstPatients.UseFiltering = True
        Me.lstPatients.View = System.Windows.Forms.View.Details
        '
        'documentId
        '
        Me.documentId.AspectName = "documentId"
        Me.documentId.Text = "Cédula"
        Me.documentId.UseInitialLetterForGroup = True
        Me.documentId.Width = 120
        '
        'namePatient
        '
        Me.namePatient.AspectName = "namePatient"
        Me.namePatient.DisplayIndex = 2
        Me.namePatient.Text = "Nombre"
        Me.namePatient.Width = 190
        '
        'lastName
        '
        Me.lastName.AspectName = "lastName"
        Me.lastName.DisplayIndex = 3
        Me.lastName.Text = "Apellido"
        Me.lastName.Width = 190
        '
        'profession
        '
        Me.profession.AspectName = "profession"
        Me.profession.DisplayIndex = 1
        Me.profession.Text = "Profesión"
        Me.profession.Width = 160
        '
        'genre
        '
        Me.genre.AspectName = "genre"
        Me.genre.Text = "Sexo"
        Me.genre.Width = 130
        '
        'PnlListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.lstPatients)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "PnlListado"
        Me.Size = New System.Drawing.Size(940, 696)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.lstPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SeleccionarVariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents profession As BrightIdeasSoftware.OLVColumn
    Friend WithEvents namePatient As BrightIdeasSoftware.OLVColumn
    Friend WithEvents lastName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents genre As BrightIdeasSoftware.OLVColumn
    Public WithEvents lstPatients As BrightIdeasSoftware.ObjectListView
    Public WithEvents documentId As BrightIdeasSoftware.OLVColumn

End Class
