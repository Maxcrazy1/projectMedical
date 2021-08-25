<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PnlRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PnlRegistro))
        Me.TxtCed = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtApe = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtNom = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProfesion = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtAddress = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboxGen = New Bunifu.Framework.UI.BunifuDropdown()
        Me.dateFirstConsultation = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.CboxEdo = New Bunifu.Framework.UI.BunifuDropdown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNro = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnNuevo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnEliminar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TxtAge = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblDateBirth = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCed
        '
        Me.TxtCed.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCed.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCed.ForeColor = System.Drawing.Color.Black
        Me.TxtCed.HintForeColor = System.Drawing.Color.Black
        Me.TxtCed.HintText = ""
        Me.TxtCed.isPassword = False
        Me.TxtCed.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.TxtCed.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TxtCed.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.TxtCed.LineThickness = 4
        Me.TxtCed.Location = New System.Drawing.Point(88, 137)
        Me.TxtCed.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtCed.Name = "TxtCed"
        Me.TxtCed.Size = New System.Drawing.Size(331, 41)
        Me.TxtCed.TabIndex = 0
        Me.TxtCed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtApe
        '
        Me.TxtApe.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtApe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtApe.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtApe.HintForeColor = System.Drawing.Color.Black
        Me.TxtApe.HintText = ""
        Me.TxtApe.isPassword = False
        Me.TxtApe.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.TxtApe.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TxtApe.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.TxtApe.LineThickness = 4
        Me.TxtApe.Location = New System.Drawing.Point(88, 363)
        Me.TxtApe.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtApe.Name = "TxtApe"
        Me.TxtApe.Size = New System.Drawing.Size(331, 41)
        Me.TxtApe.TabIndex = 2
        Me.TxtApe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtNom
        '
        Me.TxtNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNom.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtNom.HintForeColor = System.Drawing.Color.Black
        Me.TxtNom.HintText = ""
        Me.TxtNom.isPassword = False
        Me.TxtNom.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.TxtNom.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TxtNom.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.TxtNom.LineThickness = 4
        Me.TxtNom.Location = New System.Drawing.Point(88, 250)
        Me.TxtNom.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(331, 41)
        Me.TxtNom.TabIndex = 1
        Me.TxtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(84, 592)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Edad del paciente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(84, 470)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Sexo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(514, 470)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Número de télefono"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCorreo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtCorreo.HintForeColor = System.Drawing.Color.Black
        Me.TxtCorreo.HintText = ""
        Me.TxtCorreo.isPassword = False
        Me.TxtCorreo.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.TxtCorreo.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TxtCorreo.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.TxtCorreo.LineThickness = 4
        Me.TxtCorreo.Location = New System.Drawing.Point(515, 250)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(334, 41)
        Me.TxtCorreo.TabIndex = 6
        Me.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(514, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 21)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Edo. Civil"
        '
        'txtProfesion
        '
        Me.txtProfesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProfesion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProfesion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtProfesion.HintForeColor = System.Drawing.Color.Black
        Me.txtProfesion.HintText = ""
        Me.txtProfesion.isPassword = False
        Me.txtProfesion.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.txtProfesion.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.txtProfesion.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.txtProfesion.LineThickness = 4
        Me.txtProfesion.Location = New System.Drawing.Point(518, 137)
        Me.txtProfesion.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtProfesion.Name = "txtProfesion"
        Me.txtProfesion.Size = New System.Drawing.Size(331, 41)
        Me.txtProfesion.TabIndex = 5
        Me.txtProfesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress.HintForeColor = System.Drawing.Color.Black
        Me.txtAddress.HintText = ""
        Me.txtAddress.isPassword = False
        Me.txtAddress.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.txtAddress.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.txtAddress.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.txtAddress.LineThickness = 4
        Me.txtAddress.Location = New System.Drawing.Point(88, 733)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(765, 41)
        Me.txtAddress.TabIndex = 11
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(520, 589)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 21)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Fecha de la primera consulta"
        '
        'CboxGen
        '
        Me.CboxGen.BackColor = System.Drawing.Color.Transparent
        Me.CboxGen.BorderRadius = 3
        Me.CboxGen.DisabledColor = System.Drawing.Color.Gray
        Me.CboxGen.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxGen.ForeColor = System.Drawing.Color.White
        Me.CboxGen.Items = New String() {"Masculino", "Femenino"}
        Me.CboxGen.Location = New System.Drawing.Point(88, 499)
        Me.CboxGen.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CboxGen.Name = "CboxGen"
        Me.CboxGen.NomalColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.CboxGen.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CboxGen.selectedIndex = 0
        Me.CboxGen.Size = New System.Drawing.Size(258, 35)
        Me.CboxGen.TabIndex = 3
        '
        'dateFirstConsultation
        '
        Me.dateFirstConsultation.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.dateFirstConsultation.BorderRadius = 0
        Me.dateFirstConsultation.ForeColor = System.Drawing.Color.White
        Me.dateFirstConsultation.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFirstConsultation.FormatCustom = Nothing
        Me.dateFirstConsultation.Location = New System.Drawing.Point(515, 618)
        Me.dateFirstConsultation.Name = "dateFirstConsultation"
        Me.dateFirstConsultation.Size = New System.Drawing.Size(331, 36)
        Me.dateFirstConsultation.TabIndex = 10
        Me.dateFirstConsultation.Value = New Date(2015, 1, 1, 0, 0, 0, 0)
        '
        'CboxEdo
        '
        Me.CboxEdo.BackColor = System.Drawing.Color.Transparent
        Me.CboxEdo.BorderRadius = 3
        Me.CboxEdo.DisabledColor = System.Drawing.Color.Gray
        Me.CboxEdo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxEdo.ForeColor = System.Drawing.Color.White
        Me.CboxEdo.Items = New String() {"Soltero", "Casado", "Viudo"}
        Me.CboxEdo.Location = New System.Drawing.Point(517, 369)
        Me.CboxEdo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CboxEdo.Name = "CboxEdo"
        Me.CboxEdo.NomalColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.CboxEdo.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CboxEdo.selectedIndex = 0
        Me.CboxEdo.Size = New System.Drawing.Size(331, 35)
        Me.CboxEdo.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(142, 909)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(650, 21)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(84, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 21)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Cédula de identidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(84, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 21)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Nombres"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(84, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 21)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Apellidos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(514, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 21)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Profesión"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(514, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 21)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Correo electrónico"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(84, 707)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 21)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Dirección"
        '
        'TxtNro
        '
        Me.TxtNro.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNro.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtNro.HintForeColor = System.Drawing.Color.Black
        Me.TxtNro.HintText = ""
        Me.TxtNro.isPassword = False
        Me.TxtNro.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.TxtNro.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TxtNro.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.TxtNro.LineThickness = 4
        Me.TxtNro.Location = New System.Drawing.Point(514, 493)
        Me.TxtNro.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtNro.Name = "TxtNro"
        Me.TxtNro.Size = New System.Drawing.Size(334, 41)
        Me.TxtNro.TabIndex = 53
        Me.TxtNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Futura Md BT", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(313, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(316, 42)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Datos del paciente"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
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
        Me.btnNuevo.Location = New System.Drawing.Point(88, 829)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnNuevo.OnHoverTextColor = System.Drawing.Color.White
        Me.btnNuevo.selected = False
        Me.btnNuevo.Size = New System.Drawing.Size(127, 50)
        Me.btnNuevo.TabIndex = 63
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNuevo.Textcolor = System.Drawing.Color.White
        Me.btnNuevo.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnGuardar
        '
        Me.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
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
        Me.btnGuardar.Location = New System.Drawing.Point(407, 829)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnGuardar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGuardar.selected = False
        Me.btnGuardar.Size = New System.Drawing.Size(127, 50)
        Me.btnGuardar.TabIndex = 64
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGuardar.Textcolor = System.Drawing.Color.White
        Me.btnGuardar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnEliminar
        '
        Me.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
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
        Me.btnEliminar.Location = New System.Drawing.Point(726, 829)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnEliminar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEliminar.selected = False
        Me.btnEliminar.Size = New System.Drawing.Size(127, 50)
        Me.btnEliminar.TabIndex = 65
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEliminar.Textcolor = System.Drawing.Color.White
        Me.btnEliminar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAge.HintForeColor = System.Drawing.Color.Black
        Me.TxtAge.HintText = ""
        Me.TxtAge.isPassword = False
        Me.TxtAge.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.TxtAge.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.TxtAge.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.TxtAge.LineThickness = 4
        Me.TxtAge.Location = New System.Drawing.Point(88, 613)
        Me.TxtAge.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(60, 41)
        Me.TxtAge.TabIndex = 66
        Me.TxtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblDateBirth
        '
        Me.lblDateBirth.AutoSize = True
        Me.lblDateBirth.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblDateBirth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDateBirth.Location = New System.Drawing.Point(84, 571)
        Me.lblDateBirth.Name = "lblDateBirth"
        Me.lblDateBirth.Size = New System.Drawing.Size(50, 21)
        Me.lblDateBirth.TabIndex = 67
        Me.lblDateBirth.Text = "Date"
        '
        'PnlRegistro
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.lblDateBirth)
        Me.Controls.Add(Me.TxtAge)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtNro)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CboxEdo)
        Me.Controls.Add(Me.dateFirstConsultation)
        Me.Controls.Add(Me.CboxGen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtProfesion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.TxtApe)
        Me.Controls.Add(Me.TxtCed)
        Me.Name = "PnlRegistro"
        Me.Size = New System.Drawing.Size(739, 631)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCed As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtApe As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtNom As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCorreo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProfesion As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtAddress As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboxGen As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents dateFirstConsultation As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents CboxEdo As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtNro As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnGuardar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnEliminar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TxtAge As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblDateBirth As System.Windows.Forms.Label

End Class
