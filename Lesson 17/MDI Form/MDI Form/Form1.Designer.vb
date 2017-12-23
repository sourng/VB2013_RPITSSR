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
        Me.lvUsers = New System.Windows.Forms.ListView()
        Me.No = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtDistrict = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBOD = New System.Windows.Forms.DateTimePicker()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lbl_LName = New System.Windows.Forms.Label()
        Me.txtCommune = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lbl_FName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblUserImageFile = New System.Windows.Forms.Label()
        Me.lblImageFile = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvUsers
        '
        Me.lvUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.No, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvUsers.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvUsers.FullRowSelect = True
        Me.lvUsers.Location = New System.Drawing.Point(12, 292)
        Me.lvUsers.Name = "lvUsers"
        Me.lvUsers.Size = New System.Drawing.Size(786, 199)
        Me.lvUsers.TabIndex = 2
        Me.lvUsers.UseCompatibleStateImageBehavior = False
        Me.lvUsers.View = System.Windows.Forms.View.Details
        '
        'No
        '
        Me.No.Text = "#ល.រ"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "នាមត្រកូល"
        Me.ColumnHeader1.Width = 160
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "នាមឈ្មោះ"
        Me.ColumnHeader2.Width = 160
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ភេទ"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ឆ្នាំកំណើត"
        Me.ColumnHeader4.Width = 147
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "អ៊ីម៉ែល"
        Me.ColumnHeader5.Width = 172
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "អាស័យដ្ឋាន"
        Me.ColumnHeader6.Width = 220
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ទូរស័ព្ទ"
        Me.ColumnHeader7.Width = 160
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ប្រាក់បៀវត្ស"
        Me.ColumnHeader8.Width = 160
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtProvince)
        Me.GroupBox1.Controls.Add(Me.txtDistrict)
        Me.GroupBox1.Controls.Add(Me.txtSalary)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtBOD)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.lbl_LName)
        Me.GroupBox1.Controls.Add(Me.txtCommune)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.lbl_FName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 248)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "បំពេញ​ព័ត៌មាន​របស់​អ្នក​ប្រើ​ប្រាស់​"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(643, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 27)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "ខេត្ត/ក្រុង"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(474, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 27)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "ស្រុក/ខ័ណ្ឌ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(324, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 27)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "ឃុំ/សង្កាត់"
        '
        'txtProvince
        '
        Me.txtProvince.BackColor = System.Drawing.Color.AliceBlue
        Me.txtProvince.Location = New System.Drawing.Point(648, 146)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(168, 36)
        Me.txtProvince.TabIndex = 10
        '
        'txtDistrict
        '
        Me.txtDistrict.BackColor = System.Drawing.Color.AliceBlue
        Me.txtDistrict.Location = New System.Drawing.Point(480, 146)
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.Size = New System.Drawing.Size(162, 36)
        Me.txtDistrict.TabIndex = 9
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(388, 199)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(169, 36)
        Me.txtSalary.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(330, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 27)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "បៀវត្ស"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(104, 196)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(192, 36)
        Me.txtPhone.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 27)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "ទូរស័ព្ទ"
        '
        'txtBOD
        '
        Me.txtBOD.CustomFormat = "dd-MMM-yyyy"
        Me.txtBOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtBOD.Location = New System.Drawing.Point(28, 146)
        Me.txtBOD.Name = "txtBOD"
        Me.txtBOD.Size = New System.Drawing.Size(198, 36)
        Me.txtBOD.TabIndex = 7
        Me.txtBOD.Value = New Date(2017, 10, 14, 19, 49, 46, 0)
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(623, 35)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(259, 36)
        Me.txtLName.TabIndex = 3
        '
        'lbl_LName
        '
        Me.lbl_LName.AutoSize = True
        Me.lbl_LName.Location = New System.Drawing.Point(544, 40)
        Me.lbl_LName.Name = "lbl_LName"
        Me.lbl_LName.Size = New System.Drawing.Size(57, 27)
        Me.lbl_LName.TabIndex = 13
        Me.lbl_LName.Text = "នាមខ្លួន"
        '
        'txtCommune
        '
        Me.txtCommune.BackColor = System.Drawing.Color.AliceBlue
        Me.txtCommune.Location = New System.Drawing.Point(330, 146)
        Me.txtCommune.Name = "txtCommune"
        Me.txtCommune.Size = New System.Drawing.Size(144, 36)
        Me.txtCommune.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(237, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 27)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "អាស័យដ្ឋាន"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 27)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "ឆ្នាំកំណើត"
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(90, 74)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(122, 35)
        Me.cboGender.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(624, 77)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(252, 36)
        Me.txtPassword.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ភេទ"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(331, 77)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(184, 36)
        Me.txtEmail.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(521, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "លេខសំង៉ាត់"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(268, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "អ៊ីម៉ែល"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(90, 35)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(122, 36)
        Me.txtID.TabIndex = 1
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(329, 35)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(183, 36)
        Me.txtFName.TabIndex = 2
        '
        'lbl_FName
        '
        Me.lbl_FName.AutoSize = True
        Me.lbl_FName.Location = New System.Drawing.Point(232, 40)
        Me.lbl_FName.Name = "lbl_FName"
        Me.lbl_FName.Size = New System.Drawing.Size(77, 27)
        Me.lbl_FName.TabIndex = 0
        Me.lbl_FName.Text = "នាមត្រកូល"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "លេខរៀង"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(563, 197)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(68, 38)
        Me.btnNew.TabIndex = 25
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(637, 199)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(68, 38)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(711, 199)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(68, 38)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(794, 199)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(68, 38)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblUserImageFile
        '
        Me.lblUserImageFile.AutoSize = True
        Me.lblUserImageFile.Location = New System.Drawing.Point(477, 276)
        Me.lblUserImageFile.Name = "lblUserImageFile"
        Me.lblUserImageFile.Size = New System.Drawing.Size(77, 13)
        Me.lblUserImageFile.TabIndex = 17
        Me.lblUserImageFile.Text = "UserImage File"
        '
        'lblImageFile
        '
        Me.lblImageFile.AutoSize = True
        Me.lblImageFile.Location = New System.Drawing.Point(364, 276)
        Me.lblImageFile.Name = "lblImageFile"
        Me.lblImageFile.Size = New System.Drawing.Size(52, 13)
        Me.lblImageFile.TabIndex = 16
        Me.lblImageFile.Text = "Image file"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 505)
        Me.Controls.Add(Me.lblUserImageFile)
        Me.Controls.Add(Me.lblImageFile)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lvUsers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvUsers As System.Windows.Forms.ListView
    Friend WithEvents No As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents txtDistrict As System.Windows.Forms.TextBox
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBOD As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_LName As System.Windows.Forms.Label
    Friend WithEvents txtCommune As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblUserImageFile As System.Windows.Forms.Label
    Friend WithEvents lblImageFile As System.Windows.Forms.Label

End Class
