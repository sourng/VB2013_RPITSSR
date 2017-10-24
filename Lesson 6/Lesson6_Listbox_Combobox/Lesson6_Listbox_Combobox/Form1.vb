﻿Public Class Form1

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'ListPorducts.Items.Add("Red Win")
        ListPorducts.Items.Add(txtProductName.Text)

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' ListPorducts.Items.Remove(ListPorducts.SelectedItem)
    
        If ListPorducts.SelectedItems.Count > 0 Then
            ' MUST loop backwards thru collections when removing
            ' or you will remove the wrong things, miss stuff and
            ' run out early
            For n As Integer = ListPorducts.SelectedItems.Count - 1 To 0 Step -1
                ' remove the current selected item from items
                ListPorducts.Items.Remove(ListPorducts.SelectedItems(n))
            Next n
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListPorducts.Items.Clear()
    End Sub
End Class
