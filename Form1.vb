Public Class Form1
    Public Vector(15) As Integer
    Public Cont As Integer = 0
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTerminar.Click
        Dim dgv As New DataGridView
        Controls.Add(dgv)
        dgv.Location = New Point(12, 260)
        dgv.Size = New Size(870, 250)
        'Dim c As Integer = CInt(InputBox("How many columns", "Columns", "3"))
        Dim c As Integer = Val(N_ContBits.Text)
        Dim r As Integer = Val(TB_CuadrosPag.Text)
        Dim i As Integer

        For cc As Integer = 0 To c
            Dim nc As New DataGridViewTextBoxColumn
            If cc = 0 Then
                nc.Name = "Bits"
            ElseIf cc = c Then
                nc.Name = "Suma"
            Else
                nc.Name = Vector(cc - 1).ToString
            End If
            dgv.Columns.Add(nc)
        Next
        dgv.Rows.Add(r - 1)
        TabControl1.TabPages(0).Controls.Add(dgv)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ButtonAgregar.Enabled = True
        ButtonTerminar.Enabled = True


    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim Valor As Integer
        Valor = Val(TextBoxPulsos.Text)
        TextBoxValorPulsos.Text = TextBoxPulsos.Text + vbCrLf + TextBoxValorPulsos.Text
        Vector(Cont) = Valor
        Cont += 1
        TextBoxPulsos.Clear()
    End Sub
End Class
