<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PnlWaitList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PnlWaitList))
        Me.lstPatients = New BrightIdeasSoftware.ObjectListView()
        Me.documentId = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.namePatient = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.lastName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.profession = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.genre = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnNew = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.lstPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lstPatients.Location = New System.Drawing.Point(74, 118)
        Me.lstPatients.Name = "lstPatients"
        Me.lstPatients.ShowGroups = False
        Me.lstPatients.Size = New System.Drawing.Size(794, 463)
        Me.lstPatients.TabIndex = 14
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(365, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 32)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Lista de espera"
        '
        'BtnNew
        '
        Me.BtnNew.Activecolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNew.BorderRadius = 4
        Me.BtnNew.ButtonText = "Añadir paciente"
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
        Me.BtnNew.Location = New System.Drawing.Point(388, 615)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.BtnNew.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnNew.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnNew.selected = False
        Me.BtnNew.Size = New System.Drawing.Size(164, 48)
        Me.BtnNew.TabIndex = 57
        Me.BtnNew.Text = "Añadir paciente"
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNew.Textcolor = System.Drawing.Color.White
        Me.BtnNew.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PnlWaitList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.lstPatients)
        Me.Controls.Add(Me.Label2)
        Me.Name = "PnlWaitList"
        Me.Size = New System.Drawing.Size(940, 696)
        CType(Me.lstPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lstPatients As BrightIdeasSoftware.ObjectListView
    Public WithEvents documentId As BrightIdeasSoftware.OLVColumn
    Friend WithEvents namePatient As BrightIdeasSoftware.OLVColumn
    Friend WithEvents lastName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents profession As BrightIdeasSoftware.OLVColumn
    Friend WithEvents genre As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnNew As Bunifu.Framework.UI.BunifuFlatButton

End Class
