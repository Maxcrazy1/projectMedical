<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPath
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
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.BtnSetPath = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(24, 29)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(420, 20)
        Me.txtPath.TabIndex = 0
        '
        'BtnSetPath
        '
        Me.BtnSetPath.Location = New System.Drawing.Point(489, 26)
        Me.BtnSetPath.Name = "BtnSetPath"
        Me.BtnSetPath.Size = New System.Drawing.Size(75, 23)
        Me.BtnSetPath.TabIndex = 1
        Me.BtnSetPath.Text = "Set"
        Me.BtnSetPath.UseVisualStyleBackColor = True
        '
        'FormPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 77)
        Me.Controls.Add(Me.BtnSetPath)
        Me.Controls.Add(Me.txtPath)
        Me.Name = "FormPath"
        Me.Text = "Set new path DB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents BtnSetPath As System.Windows.Forms.Button
End Class
