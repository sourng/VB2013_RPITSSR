Public Class Form1
    Dim CustName(3, 4) As String

    Private Sub btnTestArray_Click(sender As Object, e As EventArgs) Handles btnTestArray.Click
        Dim CusName(6) As String  'ការ​បង្កើត​ Array

        CusName(0) = "Thida"
        CusName(1) = "Bopha"
        CusName(2) = "Nara"


        Dim i As Integer
        For i = 0 To CusName.Length - 1
            CusName(i) = InputBox("Enter Name :")
        Next

        For i = 0 To CusName.Length - 1
            ListBox1.Items.Add(CusName(i))
        Next

        'MsgBox("ប្រវែង​របស់​ Array មាន​ :" & CusName.Length)


    End Sub

    Private Sub btnTwoDimenssion_Click(sender As Object, e As EventArgs) Handles btnTwoDimenssion.Click

        CustName(0, 0) = "003"
        CustName(0, 1) = "Kaka"
        CustName(0, 2) = "F"
        CustName(0, 3) = "20"

        CustName(1, 0) = "001"
        CustName(1, 1) = "Thida"
        CustName(1, 2) = "M"
        CustName(1, 3) = "28"

        CustName(2, 0) = "002"
        CustName(2, 1) = "Bopha"
        CustName(2, 2) = "F"
        CustName(2, 3) = "19"

        Dim i As Integer
        For i = 0 To 2
            'For j = 0 To 3
            'ListBox1.Items.Add(CusName(i, 0) & "  " & CusName(i, 1) & "  " & CusName(i, 2) & " " & CusName(i, 3))

            ListView1.Items.Add(CustName(i, 0))
            ListView1.Items(i).SubItems.Add(CustName(i, 1))
            ListView1.Items(i).SubItems.Add(CustName(i, 2))
            ListView1.Items(i).SubItems.Add(CustName(i, 3))

            'Next
        Next
    End Sub

 
End Class
