
Option Explicit On
Imports System.IO ' for filestream functionality

Public Class Form1
    Dim m_PanStartPoint As New Point 'for Pan Function
    Dim DrawRectangle As Boolean = False 'for draw rectangle function
    Dim rect As Rectangle 'for draw rectangle function
    Dim DrawRectangle_Mouse_X_Start As Integer 'for draw rectangle function
    Dim DrawRectangle_Mouse_Y_Start As Integer 'for draw rectangle function
    Dim DrawRectangle_Mouse_X_End As Integer 'for draw rectangle function
    Dim DrawRectangle_Mouse_Y_End As Integer 'for draw rectangle function
    Dim currentfilename As String = Nothing 'copy of current image filename
    Dim original As Image = Nothing 'original image used for zoom feature


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1 To 7
            Me.ListView1.Items.Add("Hello" & i, i & ".png")
        Next
    End Sub

    Private Sub ResetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem1.Click

    End Sub
End Class
