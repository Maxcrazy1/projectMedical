<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PnlSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PnlSettings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstUsers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cboxRole = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtConfirmedPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUrl = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPath = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnEliminar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNuevo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(77, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'lstUsers
        '
        Me.lstUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstUsers.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lstUsers.FullRowSelect = True
        Me.lstUsers.Location = New System.Drawing.Point(493, 238)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(373, 324)
        Me.lstUsers.TabIndex = 3
        Me.lstUsers.UseCompatibleStateImageBehavior = False
        Me.lstUsers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre de usuario"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Rol de usuario"
        Me.ColumnHeader3.Width = 135
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(77, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nueva contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(77, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Rol"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label5.Location = New System.Drawing.Point(588, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Lista de usuarios"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.Black
        Me.txtUser.HintForeColor = System.Drawing.Color.Black
        Me.txtUser.HintText = ""
        Me.txtUser.isPassword = False
        Me.txtUser.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.txtUser.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.txtUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.txtUser.LineThickness = 4
        Me.txtUser.Location = New System.Drawing.Point(79, 122)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(331, 41)
        Me.txtUser.TabIndex = 14
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cboxRole
        '
        Me.cboxRole.BackColor = System.Drawing.Color.Transparent
        Me.cboxRole.BorderRadius = 3
        Me.cboxRole.DisabledColor = System.Drawing.Color.Gray
        Me.cboxRole.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxRole.ForeColor = System.Drawing.Color.White
        Me.cboxRole.Items = New String() {"Administrador", "Sub - Administrador"}
        Me.cboxRole.Location = New System.Drawing.Point(79, 316)
        Me.cboxRole.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cboxRole.Name = "cboxRole"
        Me.cboxRole.NomalColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.cboxRole.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboxRole.selectedIndex = 1
        Me.cboxRole.Size = New System.Drawing.Size(331, 41)
        Me.cboxRole.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(390, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 39)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Ajustes"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtConfirmedPass
        '
        Me.txtConfirmedPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmedPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmedPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmedPass.ForeColor = System.Drawing.Color.Gray
        Me.txtConfirmedPass.HintForeColor = System.Drawing.Color.Black
        Me.txtConfirmedPass.HintText = ""
        Me.txtConfirmedPass.isPassword = True
        Me.txtConfirmedPass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.txtConfirmedPass.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.txtConfirmedPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.txtConfirmedPass.LineThickness = 4
        Me.txtConfirmedPass.Location = New System.Drawing.Point(514, 122)
        Me.txtConfirmedPass.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtConfirmedPass.Name = "txtConfirmedPass"
        Me.txtConfirmedPass.Size = New System.Drawing.Size(331, 41)
        Me.txtConfirmedPass.TabIndex = 62
        Me.txtConfirmedPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(76, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 21)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Url de base de datos"
        '
        'txtUrl
        '
        Me.txtUrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUrl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUrl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUrl.ForeColor = System.Drawing.Color.Gray
        Me.txtUrl.HintForeColor = System.Drawing.Color.Black
        Me.txtUrl.HintText = ""
        Me.txtUrl.isPassword = True
        Me.txtUrl.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.txtUrl.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.txtUrl.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.txtUrl.LineThickness = 4
        Me.txtUrl.Location = New System.Drawing.Point(79, 419)
        Me.txtUrl.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(331, 41)
        Me.txtUrl.TabIndex = 64
        Me.txtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(79, 497)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 21)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Ruta de la carpeta"
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPath.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.ForeColor = System.Drawing.Color.Gray
        Me.txtPath.HintForeColor = System.Drawing.Color.Black
        Me.txtPath.HintText = ""
        Me.txtPath.isPassword = True
        Me.txtPath.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.txtPath.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.txtPath.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.txtPath.LineThickness = 4
        Me.txtPath.Location = New System.Drawing.Point(82, 521)
        Me.txtPath.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(331, 41)
        Me.txtPath.TabIndex = 66
        Me.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnGuardar
        '
        Me.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.BorderRadius = 2
        Me.btnGuardar.ButtonText = "Guardar"
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DisabledColor = System.Drawing.Color.Gray
        Me.btnGuardar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGuardar.Iconimage = CType(resources.GetObject("btnGuardar.Iconimage"), System.Drawing.Image)
        Me.btnGuardar.Iconimage_right = Nothing
        Me.btnGuardar.Iconimage_right_Selected = Nothing
        Me.btnGuardar.Iconimage_Selected = Nothing
        Me.btnGuardar.IconMarginLeft = 0
        Me.btnGuardar.IconMarginRight = 0
        Me.btnGuardar.IconRightVisible = True
        Me.btnGuardar.IconRightZoom = 0.0R
        Me.btnGuardar.IconVisible = True
        Me.btnGuardar.IconZoom = 50.0R
        Me.btnGuardar.IsTab = False
        Me.btnGuardar.Location = New System.Drawing.Point(79, 621)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnGuardar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGuardar.selected = False
        Me.btnGuardar.Size = New System.Drawing.Size(127, 50)
        Me.btnGuardar.TabIndex = 67
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGuardar.Textcolor = System.Drawing.Color.White
        Me.btnGuardar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnEliminar
        '
        Me.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.BorderRadius = 2
        Me.btnEliminar.ButtonText = "Eliminar"
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.DisabledColor = System.Drawing.Color.Gray
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEliminar.Iconimage = CType(resources.GetObject("btnEliminar.Iconimage"), System.Drawing.Image)
        Me.btnEliminar.Iconimage_right = Nothing
        Me.btnEliminar.Iconimage_right_Selected = Nothing
        Me.btnEliminar.Iconimage_Selected = Nothing
        Me.btnEliminar.IconMarginLeft = 0
        Me.btnEliminar.IconMarginRight = 0
        Me.btnEliminar.IconRightVisible = True
        Me.btnEliminar.IconRightZoom = 0.0R
        Me.btnEliminar.IconVisible = True
        Me.btnEliminar.IconZoom = 50.0R
        Me.btnEliminar.IsTab = False
        Me.btnEliminar.Location = New System.Drawing.Point(286, 621)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnEliminar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEliminar.selected = False
        Me.btnEliminar.Size = New System.Drawing.Size(127, 50)
        Me.btnEliminar.TabIndex = 68
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEliminar.Textcolor = System.Drawing.Color.White
        Me.btnEliminar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNuevo
        '
        Me.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.BorderRadius = 2
        Me.btnNuevo.ButtonText = "Nuevo"
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.DisabledColor = System.Drawing.Color.Gray
        Me.btnNuevo.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNuevo.Iconimage = CType(resources.GetObject("btnNuevo.Iconimage"), System.Drawing.Image)
        Me.btnNuevo.Iconimage_right = Nothing
        Me.btnNuevo.Iconimage_right_Selected = Nothing
        Me.btnNuevo.Iconimage_Selected = Nothing
        Me.btnNuevo.IconMarginLeft = 0
        Me.btnNuevo.IconMarginRight = 0
        Me.btnNuevo.IconRightVisible = True
        Me.btnNuevo.IconRightZoom = 0.0R
        Me.btnNuevo.IconVisible = True
        Me.btnNuevo.IconZoom = 50.0R
        Me.btnNuevo.IsTab = False
        Me.btnNuevo.Location = New System.Drawing.Point(733, 621)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnNuevo.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNuevo.selected = False
        Me.btnNuevo.Size = New System.Drawing.Size(127, 50)
        Me.btnNuevo.TabIndex = 69
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevo.Textcolor = System.Drawing.Color.White
        Me.btnNuevo.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(510, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 21)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Confirmar Contraseña"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Gray
        Me.txtPass.HintForeColor = System.Drawing.Color.Black
        Me.txtPass.HintText = ""
        Me.txtPass.isPassword = True
        Me.txtPass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.txtPass.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.txtPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.txtPass.LineThickness = 4
        Me.txtPass.Location = New System.Drawing.Point(79, 219)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(331, 41)
        Me.txtPass.TabIndex = 71
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PnlSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboxRole)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstUsers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConfirmedPass)
        Me.Name = "PnlSettings"
        Me.Size = New System.Drawing.Size(940, 696)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstUsers As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cboxRole As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtConfirmedPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUrl As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPath As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnGuardar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnEliminar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNuevo As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMaterialTextbox

End Class
