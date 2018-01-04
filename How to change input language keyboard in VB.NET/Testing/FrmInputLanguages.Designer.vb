<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInputLanguages
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtKhmerKeyboard = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEnglishKeyboard = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Khmer Keyboard"
        '
        'TxtKhmerKeyboard
        '
        Me.TxtKhmerKeyboard.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKhmerKeyboard.Location = New System.Drawing.Point(162, 38)
        Me.TxtKhmerKeyboard.Name = "TxtKhmerKeyboard"
        Me.TxtKhmerKeyboard.Size = New System.Drawing.Size(189, 37)
        Me.TxtKhmerKeyboard.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "English Keyboard"
        '
        'TxtEnglishKeyboard
        '
        Me.TxtEnglishKeyboard.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnglishKeyboard.Location = New System.Drawing.Point(162, 81)
        Me.TxtEnglishKeyboard.Name = "TxtEnglishKeyboard"
        Me.TxtEnglishKeyboard.Size = New System.Drawing.Size(189, 37)
        Me.TxtEnglishKeyboard.TabIndex = 1
        '
        'FrmInputLanguages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 155)
        Me.Controls.Add(Me.TxtEnglishKeyboard)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtKhmerKeyboard)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmInputLanguages"
        Me.Text = "FrmInputLanguages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtKhmerKeyboard As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtEnglishKeyboard As System.Windows.Forms.TextBox
End Class
