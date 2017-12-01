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
        Me.btnConst = New System.Windows.Forms.Button()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.btnVariables = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.btnFindRoot = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRoot = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConst
        '
        Me.btnConst.Location = New System.Drawing.Point(87, 171)
        Me.btnConst.Name = "btnConst"
        Me.btnConst.Size = New System.Drawing.Size(94, 29)
        Me.btnConst.TabIndex = 0
        Me.btnConst.Text = "Constant"
        Me.btnConst.UseVisualStyleBackColor = True
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(87, 24)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(219, 20)
        Me.txtA.TabIndex = 1
        '
        'btnVariables
        '
        Me.btnVariables.Location = New System.Drawing.Point(202, 171)
        Me.btnVariables.Name = "btnVariables"
        Me.btnVariables.Size = New System.Drawing.Size(104, 30)
        Me.btnVariables.TabIndex = 2
        Me.btnVariables.Text = "Variable"
        Me.btnVariables.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Value A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Value B"
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(87, 50)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(219, 20)
        Me.txtB.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Value C"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(87, 76)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(219, 20)
        Me.txtC.TabIndex = 6
        '
        'btnFindRoot
        '
        Me.btnFindRoot.Location = New System.Drawing.Point(92, 101)
        Me.btnFindRoot.Name = "btnFindRoot"
        Me.btnFindRoot.Size = New System.Drawing.Size(213, 22)
        Me.btnFindRoot.TabIndex = 8
        Me.btnFindRoot.Text = "Find Root"
        Me.btnFindRoot.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Result :"
        '
        'lblRoot
        '
        Me.lblRoot.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblRoot.Location = New System.Drawing.Point(89, 126)
        Me.lblRoot.Name = "lblRoot"
        Me.lblRoot.Padding = New System.Windows.Forms.Padding(4)
        Me.lblRoot.Size = New System.Drawing.Size(216, 24)
        Me.lblRoot.TabIndex = 10
        Me.lblRoot.Text = "Result :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 212)
        Me.Controls.Add(Me.lblRoot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFindRoot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVariables)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.btnConst)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConst As System.Windows.Forms.Button
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents btnVariables As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents btnFindRoot As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRoot As System.Windows.Forms.Label

End Class
