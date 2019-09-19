Public Class Form5
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles cBox.TextChanged
        If cBox.Text <> "" Then
            fBox.ReadOnly = True
        Else
            fBox.ReadOnly = False
        End If
    End Sub

    Private Sub FBox_TextChanged(sender As Object, e As EventArgs) Handles fBox.TextChanged
        If fBox.Text <> "" Then
            cBox.ReadOnly = True
        Else
            cBox.ReadOnly = False
        End If
    End Sub

    Private Sub Convert_Click(sender As Object, e As EventArgs) Handles convert.Click
        If fBox.Text <> "" Then
            cBox.Text = (fBox.Text - 32) * 5 / 9
            fBox.Text = ""
        Else
            fBox.Text = (cBox.Text * 9 / 5) + 32
            cBox.Text = ""
        End If
    End Sub
End Class