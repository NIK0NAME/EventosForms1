Public Class Form2
    Private numers() = {"uno", "dos", "tres", "cuatro"}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Display.Text = numers(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Display.Text = numers(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Display.Text = numers(2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Display.Text = numers(3)
    End Sub
End Class