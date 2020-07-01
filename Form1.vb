Public Class Form1
    Public Vector As New List(Of String)
    Public Cont As Integer = 0
    Public VectorConcat As New List(Of String)
    Public VectorFinal As New List(Of String)
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTerminar.Click
        Dim Palabra As String
        Dim Caracter As String
        Dim dgv As New DataGridView
        Dim CB As New ConversorBinario
        Controls.Add(dgv)
        dgv.Location = New Point(12, 260)
        dgv.Size = New Size(870, 250)
        'Dim c As Integer = CInt(InputBox("How many columns", "Columns", "3"))
        Dim c As Integer = Cont
        Dim r As Integer = Val(TB_CuadrosPag.Text)

        For cc As Integer = 0 To c + 1
            Dim nc As New DataGridViewTextBoxColumn
            If cc = 0 Then
                nc.Name = "Bits"
            ElseIf cc = c + 1 Then
                nc.Name = "Suma"
            Else
                nc.Name = Vector(cc - 1).ToString
            End If
            dgv.Columns.Add(nc)
        Next
        dgv.Rows.Add(r - 1)
        TabControl1.TabPages(0).Controls.Add(dgv)

        Dim rellenador As String = "0"
        Dim cont_lista As Integer = 0
        'Funciona el separador de caracteres, ahora hay que ir separando cada uno de los valores del vector e ir agregando al datagrid en sus celdas e ir rellenando con 0 a la derecha
        For i As Integer = 0 To Cont - 1 Step 1
            Palabra = Vector(i).ToString
            For k As Integer = 0 To Len(Palabra) - 1 Step 1
                Caracter = Mid(Palabra, k + 1, 1)
                'Aux = Caracter + Aux
                If i = 0 Then
                    VectorConcat.Add(Caracter)
                Else
                    VectorConcat(k) = Caracter & VectorConcat(k)
                    'TextBoxValorPulsos.Text = VectorConcat(i)
                End If
                For l As Integer = 0 To N_ContBits.Value - Len(VectorConcat(k)) - 2
                    rellenador &= "0"
                Next
                dgv.Rows(k).Cells(i + 1).Value = VectorConcat(k) + rellenador
                Caracter = " "
                rellenador = "0"
                cont_lista = +1
            Next
        Next
        'Palabra = Vector(0).ToString
        'dgv.Rows(2).Cells(2).Value = Caracter
        For i As Integer = 0 To cont_lista
            dgv.Rows(i).Cells(c + 1).Value = CB.Convertidor(dgv.Rows(i).Cells(c).Value)
        Next
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ButtonAgregar.Enabled = True
        ButtonTerminar.Enabled = True


    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Dim Valor As String
        Valor = TextBoxPulsos.Text.ToString
        TextBoxValorPulsos.Text = TextBoxPulsos.Text + vbCrLf + TextBoxValorPulsos.Text
        Vector.Add(Valor)
        Cont += 1
        TextBoxPulsos.Clear()
    End Sub
End Class
