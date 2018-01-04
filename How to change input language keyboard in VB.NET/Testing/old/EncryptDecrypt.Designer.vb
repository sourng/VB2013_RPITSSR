<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EncryptDecrypt
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
        Me.TxtEncrypt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEncryptResult = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDecryptResult = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDecrypt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Encrypt"
        '
        'TxtEncrypt
        '
        Me.TxtEncrypt.Location = New System.Drawing.Point(58, 69)
        Me.TxtEncrypt.Name = "TxtEncrypt"
        Me.TxtEncrypt.Size = New System.Drawing.Size(190, 20)
        Me.TxtEncrypt.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Encrypt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Result"
        '
        'TxtEncryptResult
        '
        Me.TxtEncryptResult.Location = New System.Drawing.Point(58, 108)
        Me.TxtEncryptResult.Multiline = True
        Me.TxtEncryptResult.Name = "TxtEncryptResult"
        Me.TxtEncryptResult.Size = New System.Drawing.Size(190, 82)
        Me.TxtEncryptResult.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Result"
        '
        'TxtDecryptResult
        '
        Me.TxtDecryptResult.Location = New System.Drawing.Point(269, 170)
        Me.TxtDecryptResult.Name = "TxtDecryptResult"
        Me.TxtDecryptResult.Size = New System.Drawing.Size(190, 20)
        Me.TxtDecryptResult.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Decrypt"
        '
        'TxtDecrypt
        '
        Me.TxtDecrypt.Location = New System.Drawing.Point(269, 69)
        Me.TxtDecrypt.Multiline = True
        Me.TxtDecrypt.Name = "TxtDecrypt"
        Me.TxtDecrypt.Size = New System.Drawing.Size(190, 82)
        Me.TxtDecrypt.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(269, 196)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Decrypt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EncryptDecrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 299)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtDecrypt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtEncryptResult)
        Me.Controls.Add(Me.TxtDecryptResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtEncrypt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EncryptDecrypt"
        Me.Text = "EncryptDecrypt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtEncryptResult As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDecryptResult As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
