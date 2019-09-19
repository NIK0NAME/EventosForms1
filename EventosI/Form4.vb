Public Class Form4

    Dim list As New List(Of Integer)
    Dim max As Integer = 0
    Dim min As Integer = 100
    Dim med As Integer = 0
    Private Sub AddNum_Click(sender As Object, e As EventArgs) Handles addNum.Click

        list.Add(Convert.ToInt32(inNum.Text))
        For Each num In list
            If max < num Then
                max = num
            End If
            If min > num Then
                min = num
            End If
            med += num
        Next
        med = med / (list.Count)
        inNum.Text = ""
        minBox.Text = Convert.ToString(min)
        maxBox.Text = Convert.ToString(max)
        medBox.Text = Convert.ToString(med)
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        minBox.Text = "0"
        maxBox.Text = "0"
        medBox.Text = "0"
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        list = New List(Of Integer)
        minBox.Text = "0"
        maxBox.Text = "0"
        medBox.Text = "0"

        max = 0
        min = 100
        med = 0
    End Sub
End Class