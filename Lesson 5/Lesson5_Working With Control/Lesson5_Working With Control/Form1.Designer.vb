<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtValue1 = New System.Windows.Forms.TextBox()
        Me.txtValue2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Value 1"
        '
        'txtValue1
        '
        Me.txtValue1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtValue1.Location = New System.Drawing.Point(143, 54)
        Me.txtValue1.Name = "txtValue1"
        Me.txtValue1.Size = New System.Drawing.Size(190, 20)
        Me.txtValue1.TabIndex = 1
        '
        'txtValue2
        '
        Me.txtValue2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtValue2.Location = New System.Drawing.Point(143, 90)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(190, 20)
        Me.txtValue2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Value 2"
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.Color.Orange
        Me.txtResult.Location = New System.Drawing.Point(143, 127)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(190, 20)
        Me.txtResult.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Result"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(143, 168)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(83, 35)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 309)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtValue2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValue1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValue1 As System.Windows.Forms.TextBox
    Friend WithEvents txtValue2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
