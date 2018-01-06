Imports System.Data.OleDb
Imports System.IO

Public Class frmMain
    Dim cnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=..\Data.mdb"

    Dim imgName As String
    Dim daImage As OleDbDataAdapter
    Dim dsImage As DataSet

    Private Sub FillCombo()
        Try
            Dim CN As New OleDbConnection(cnString)

            CN.Open()
            daImage = New OleDbDataAdapter()
            daImage.SelectCommand = New OleDbCommand("SELECT * FROM images", CN)
            dsImage = New DataSet("dsImage")

            daImage.Fill(dsImage)

            Dim dtable As DataTable

            dtable = dsImage.Tables(0)
            cboImageID.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cboImageID.Items.Add(drow(0).ToString())
                cboImageID.SelectedIndex = 0
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            Dim dlgImage As FileDialog = New OpenFileDialog()

            dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If dlgImage.ShowDialog() = DialogResult.OK Then
                imgName = dlgImage.FileName

                Dim newimg As New Bitmap(imgName)

                imgSave.SizeMode = PictureBoxSizeMode.StretchImage
                imgSave.Image = DirectCast(newimg, Image)
            End If

            dlgImage = Nothing
        Catch ae As System.ArgumentException
            imgName = " "

            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If imgName <> "" Then
                Dim fs As FileStream

                fs = New FileStream(imgName, FileMode.Open, FileAccess.Read)

                Dim picByte As Byte() = New Byte(fs.Length - 1) {}

                fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))

                fs.Close()

                Dim CN As New OleDbConnection(cnString)

                CN.Open()

                Dim strSQL As String

                strSQL = "INSERT INTO Images([Image]) values (" & " @Img)"

                Dim imgParam As New OleDbParameter()

                imgParam.OleDbType = OleDbType.Binary
                imgParam.ParameterName = "Img"
                imgParam.Value = picByte

                Dim cmd As New OleDbCommand(strSQL, CN)

                cmd.Parameters.Add(imgParam)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Image successfully saved.")

                cmd.Dispose()
                CN.Close()
                CN.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        FillCombo()
    End Sub

    Private Sub btnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click
        Dim dataTable As DataTable = dsImage.Tables(0)

        If imgRetrieve.Image IsNot Nothing Then

            imgRetrieve.Image.Dispose()
        End If

        Dim fsImage As New FileStream("image.jpg", FileMode.Create)

        For Each dataRow As DataRow In dataTable.Rows
            If dataRow(0).ToString() = cboImageID.SelectedItem.ToString() Then

                Dim blob As Byte() = DirectCast(dataRow(1), Byte())

                fsImage.Write(blob, 0, blob.Length)
                fsImage.Close()
                fsImage = Nothing

                imgRetrieve.Image = Image.FromFile("image.jpg")
                imgRetrieve.SizeMode = PictureBoxSizeMode.StretchImage
                imgRetrieve.Refresh()
            End If
        Next
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCombo()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.sourcecodester.com")
    End Sub
End Class
