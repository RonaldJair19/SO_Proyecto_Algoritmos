Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dgv As New DataGridView
        Controls.Add(dgv)
        dgv.Location = New Point(12, 12)
        dgv.Size = New Size(250, 250)
        Dim c As Integer = CInt(InputBox("How many columns", "Columns", "3"))
        Dim r As Integer = CInt(InputBox("How many rows", "Rows", "3"))

        For cc As Integer = 0 To c - 1
            Dim nc As New DataGridViewTextBoxColumn
            nc.Name = "Column" & cc.ToString
            dgv.Columns.Add(nc)
        Next
        dgv.Rows.Add(r - 1)
        TabControl1.TabPages(0).Controls.Add(dgv)
    End Sub
End Class
