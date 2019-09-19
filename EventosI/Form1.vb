Public Class Form1

    Dim f1 = New Form2()
    Private Sub Formulari1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Formulari1ToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub Formulari2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Formulari2ToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub Formulari3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Formulari3ToolStripMenuItem.Click
        Form4.MdiParent = Me
        Form4.Show()
    End Sub

    Private Sub ConversorDeTempertaturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversorDeTempertaturaToolStripMenuItem.Click
        Form5.MdiParent = Me
        Form5.Show()
    End Sub
End Class
