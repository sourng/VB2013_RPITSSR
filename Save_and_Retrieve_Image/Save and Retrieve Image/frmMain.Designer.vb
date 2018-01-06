<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.imgSave = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.imgRetrieve = New System.Windows.Forms.PictureBox
        Me.btnRetrieve = New System.Windows.Forms.Button
        Me.cboImageID = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        CType(Me.imgSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgRetrieve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgSave
        '
        Me.imgSave.Location = New System.Drawing.Point(38, 66)
        Me.imgSave.Name = "imgSave"
        Me.imgSave.Size = New System.Drawing.Size(143, 120)
        Me.imgSave.TabIndex = 2
        Me.imgSave.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(199, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Save Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(199, 66)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(156, 23)
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "Load Image from File"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'imgRetrieve
        '
        Me.imgRetrieve.Location = New System.Drawing.Point(38, 198)
        Me.imgRetrieve.Name = "imgRetrieve"
        Me.imgRetrieve.Size = New System.Drawing.Size(143, 120)
        Me.imgRetrieve.TabIndex = 5
        Me.imgRetrieve.TabStop = False
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(199, 225)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(156, 23)
        Me.btnRetrieve.TabIndex = 6
        Me.btnRetrieve.Text = "Load Image from Database"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'cboImageID
        '
        Me.cboImageID.FormattingEnabled = True
        Me.cboImageID.Location = New System.Drawing.Point(199, 198)
        Me.cboImageID.Name = "cboImageID"
        Me.cboImageID.Size = New System.Drawing.Size(90, 21)
        Me.cboImageID.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Save and Retrieve Image from Database"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(196, 305)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(161, 13)
        Me.LinkLabel1.TabIndex = 35
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://www.sourcecodester.com"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 344)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboImageID)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.imgRetrieve)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.imgSave)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.imgSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgRetrieve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgSave As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents imgRetrieve As System.Windows.Forms.PictureBox
    Friend WithEvents btnRetrieve As System.Windows.Forms.Button
    Friend WithEvents cboImageID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
