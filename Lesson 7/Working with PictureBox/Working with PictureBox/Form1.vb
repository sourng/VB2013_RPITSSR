Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String
        path = My.Application.Info.DirectoryPath
        Dim path1 As String = path.Replace("\bin\Debug", "\")


        path1 = path1 & "myImages\9.jpg"
        Me.PictureBox2.Image = Image.FromFile(path1)



        '  Me.Label1.Text = path ' path1 & "myImages\9.jpg"


        ' Dim myPath As String = path & "\testImages\bandmember.jpg"
        'Me.Label1.Text = myPath



        'Me.PictureBox2.Image = Image.FromFile(myPath)

        ' Me.PictureBox2.Image = Image.FromFile("C:\Users\SENG Sourng\Pictures\9.jpg")

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If OFD_FileImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OFD_FileImage.FileName)
        End If


    End Sub

    Private Sub PictureBox2_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox2.DoubleClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim path As String
        path = My.Application.Info.DirectoryPath
        Dim path1 As String = path.Replace("\bin\Debug", "\")

        path1 = path1 & "myImages\" & ComboBox1.Text
        Me.PictureBox2.Image = Image.FromFile(path1)
    End Sub

   
    Private Sub rbt_9_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_9.CheckedChanged
        If rbt_9.Checked = True Then
            Dim path As String
            path = My.Application.Info.DirectoryPath
            Dim path1 As String = path.Replace("\bin\Debug", "\")

            path1 = path1 & "myImages\9.jpg"
            Me.PictureBox2.Image = Image.FromFile(path1)
        End If
    End Sub

    Private Sub rbt_10_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_10.CheckedChanged
        If rbt_10.Checked = True Then
            Dim path As String
            path = My.Application.Info.DirectoryPath
            Dim path1 As String = path.Replace("\bin\Debug", "\")

            path1 = path1 & "myImages\10.jpg"
            Me.PictureBox2.Image = Image.FromFile(path1)
        End If
    End Sub

    Private Sub rbt_11_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_11.CheckedChanged
        If rbt_11.Checked = True Then
            Dim path As String
            path = My.Application.Info.DirectoryPath
            Dim path1 As String = path.Replace("\bin\Debug", "\")

            path1 = path1 & "myImages\11.jpg"
            Me.PictureBox2.Image = Image.FromFile(path1)
        End If
    End Sub

 
    Private Sub rbt_12_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_12.CheckedChanged
        If rbt_12.Checked = True Then
            Dim path As String
            path = My.Application.Info.DirectoryPath
            Dim path1 As String = path.Replace("\bin\Debug", "\")

            path1 = path1 & "myImages\12.jpg"
            Me.PictureBox2.Image = Image.FromFile(path1)
        End If
    End Sub

    Private Sub btnBrow_Click(sender As Object, e As EventArgs) Handles btnBrow.Click
        If OFD_FileImage.ShowDialog = Windows.Forms.DialogResult.OK Then 'បើសិន​ OpenFileDialogs បង្ហាញ ហើយ​រើស​រូប​រួច​ចុច​ OK ពិតមែន​ នោះ​វា​នឹង​ដំណើរកូដ​ខាង​ក្រោម​


            Dim ImagePath = OFD_FileImage.FileName  'កូដសម្រាប់ចាប់​ទីតាំងរូប​
            PictureBox2.Image = Image.FromFile(ImagePath)
            'PictureBox2 គឺជា​ឈ្មោះ​របស់​ Control PictureBox

        End If
    End Sub
End Class
