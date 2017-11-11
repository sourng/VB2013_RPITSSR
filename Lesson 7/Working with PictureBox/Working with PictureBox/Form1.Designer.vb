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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.rbt_9 = New System.Windows.Forms.RadioButton()
        Me.rbt_10 = New System.Windows.Forms.RadioButton()
        Me.rbt_11 = New System.Windows.Forms.RadioButton()
        Me.rbt_12 = New System.Windows.Forms.RadioButton()
        Me.btnBrow = New System.Windows.Forms.Button()
        Me.OFD_FileImage = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Working_with_PictureBox.My.Resources.Resources._1
        Me.PictureBox1.Location = New System.Drawing.Point(21, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 276)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(494, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(235, 283)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"9.jpg", "10.png"})
        Me.ComboBox1.Location = New System.Drawing.Point(274, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'rbt_9
        '
        Me.rbt_9.AutoSize = True
        Me.rbt_9.Location = New System.Drawing.Point(301, 155)
        Me.rbt_9.Name = "rbt_9"
        Me.rbt_9.Size = New System.Drawing.Size(63, 17)
        Me.rbt_9.TabIndex = 4
        Me.rbt_9.Text = "Image 9"
        Me.rbt_9.UseVisualStyleBackColor = True
        '
        'rbt_10
        '
        Me.rbt_10.AutoSize = True
        Me.rbt_10.Location = New System.Drawing.Point(301, 178)
        Me.rbt_10.Name = "rbt_10"
        Me.rbt_10.Size = New System.Drawing.Size(69, 17)
        Me.rbt_10.TabIndex = 5
        Me.rbt_10.Text = "Image 10"
        Me.rbt_10.UseVisualStyleBackColor = True
        '
        'rbt_11
        '
        Me.rbt_11.AutoSize = True
        Me.rbt_11.Location = New System.Drawing.Point(301, 201)
        Me.rbt_11.Name = "rbt_11"
        Me.rbt_11.Size = New System.Drawing.Size(69, 17)
        Me.rbt_11.TabIndex = 6
        Me.rbt_11.Text = "Image 11"
        Me.rbt_11.UseVisualStyleBackColor = True
        '
        'rbt_12
        '
        Me.rbt_12.AutoSize = True
        Me.rbt_12.Location = New System.Drawing.Point(301, 224)
        Me.rbt_12.Name = "rbt_12"
        Me.rbt_12.Size = New System.Drawing.Size(69, 17)
        Me.rbt_12.TabIndex = 7
        Me.rbt_12.Text = "Image 12"
        Me.rbt_12.UseVisualStyleBackColor = True
        '
        'btnBrow
        '
        Me.btnBrow.Location = New System.Drawing.Point(551, 325)
        Me.btnBrow.Name = "btnBrow"
        Me.btnBrow.Size = New System.Drawing.Size(102, 33)
        Me.btnBrow.TabIndex = 8
        Me.btnBrow.Text = "Brow Image"
        Me.btnBrow.UseVisualStyleBackColor = True
        '
        'OFD_FileImage
        '
        Me.OFD_FileImage.FileName = "OFD_FileImage"
        Me.OFD_FileImage.Filter = "JPEG Files| *.JPG|GIF Files|*.GIF|Windows Bitmaps|*.BMP|All Files|*.*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 375)
        Me.Controls.Add(Me.btnBrow)
        Me.Controls.Add(Me.rbt_12)
        Me.Controls.Add(Me.rbt_11)
        Me.Controls.Add(Me.rbt_10)
        Me.Controls.Add(Me.rbt_9)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents rbt_9 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_10 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_11 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_12 As System.Windows.Forms.RadioButton
    Friend WithEvents btnBrow As System.Windows.Forms.Button
    Friend WithEvents OFD_FileImage As System.Windows.Forms.OpenFileDialog

End Class
