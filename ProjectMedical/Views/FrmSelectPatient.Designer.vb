<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectPatient
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.PnlListado1 = New ProjectMedical.PnlListado()
        Me.PnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.PnlTop.Controls.Add(Me.lblName)
        Me.PnlTop.Controls.Add(Me.btnClose)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(661, 43)
        Me.PnlTop.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Futura Md BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(313, 22)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Agregar paciente a lista de espera"
        Me.lblName.Visible = False
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClose.Location = New System.Drawing.Point(627, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 28)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        '
        'PnlListado1
        '
        Me.PnlListado1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnlListado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlListado1.Location = New System.Drawing.Point(0, 44)
        Me.PnlListado1.Name = "PnlListado1"
        Me.PnlListado1.Size = New System.Drawing.Size(661, 442)
        Me.PnlListado1.TabIndex = 3
        '
        'FrmSelectPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 485)
        Me.Controls.Add(Me.PnlListado1)
        Me.Controls.Add(Me.PnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSelectPatient"
        Me.Text = "FrmSelectPatient"
        Me.PnlTop.ResumeLayout(False)
        Me.PnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents PnlListado1 As ProjectMedical.PnlListado
End Class
