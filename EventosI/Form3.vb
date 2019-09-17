Public Class Form3
    Dim patada As Integer
    Dim puno As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If patada > Then

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'patada en la boca
        patada += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'puño en la boca
        puno += 1
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        patada = 0
        puno = 0
    End Sub
End Class