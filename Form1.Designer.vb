<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageEnvejecimiento = New System.Windows.Forms.TabPage()
        Me.TabPageSC = New System.Windows.Forms.TabPage()
        Me.TabPageSegmentacion = New System.Windows.Forms.TabPage()
        Me.TabPageP_M_PA = New System.Windows.Forms.TabPage()
        Me.TabPageSP = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageEnvejecimiento)
        Me.TabControl1.Controls.Add(Me.TabPageSC)
        Me.TabControl1.Controls.Add(Me.TabPageSegmentacion)
        Me.TabControl1.Controls.Add(Me.TabPageP_M_PA)
        Me.TabControl1.Controls.Add(Me.TabPageSP)
        Me.TabControl1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 148)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(906, 565)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageEnvejecimiento
        '
        Me.TabPageEnvejecimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPageEnvejecimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageEnvejecimiento.Location = New System.Drawing.Point(4, 27)
        Me.TabPageEnvejecimiento.Name = "TabPageEnvejecimiento"
        Me.TabPageEnvejecimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEnvejecimiento.Size = New System.Drawing.Size(898, 534)
        Me.TabPageEnvejecimiento.TabIndex = 0
        Me.TabPageEnvejecimiento.Text = "A. de Envejecimiento"
        Me.TabPageEnvejecimiento.UseVisualStyleBackColor = True
        '
        'TabPageSC
        '
        Me.TabPageSC.Location = New System.Drawing.Point(4, 27)
        Me.TabPageSC.Name = "TabPageSC"
        Me.TabPageSC.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSC.Size = New System.Drawing.Size(898, 534)
        Me.TabPageSC.TabIndex = 1
        Me.TabPageSC.Text = "A. Sistema Compañero"
        Me.TabPageSC.UseVisualStyleBackColor = True
        '
        'TabPageSegmentacion
        '
        Me.TabPageSegmentacion.Location = New System.Drawing.Point(4, 27)
        Me.TabPageSegmentacion.Name = "TabPageSegmentacion"
        Me.TabPageSegmentacion.Size = New System.Drawing.Size(898, 534)
        Me.TabPageSegmentacion.TabIndex = 2
        Me.TabPageSegmentacion.Text = "Segmentación"
        Me.TabPageSegmentacion.UseVisualStyleBackColor = True
        '
        'TabPageP_M_PA
        '
        Me.TabPageP_M_PA.Location = New System.Drawing.Point(4, 27)
        Me.TabPageP_M_PA.Name = "TabPageP_M_PA"
        Me.TabPageP_M_PA.Size = New System.Drawing.Size(898, 534)
        Me.TabPageP_M_PA.TabIndex = 3
        Me.TabPageP_M_PA.Text = "TabPage1"
        Me.TabPageP_M_PA.UseVisualStyleBackColor = True
        '
        'TabPageSP
        '
        Me.TabPageSP.Location = New System.Drawing.Point(4, 27)
        Me.TabPageSP.Name = "TabPageSP"
        Me.TabPageSP.Size = New System.Drawing.Size(898, 534)
        Me.TabPageSP.TabIndex = 4
        Me.TabPageSP.Text = "A. Sustitución de Páginas"
        Me.TabPageSP.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(926, 141)
        Me.Panel1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 725)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Proyecto_Memoria"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageEnvejecimiento As TabPage
    Friend WithEvents TabPageSC As TabPage
    Friend WithEvents TabPageSegmentacion As TabPage
    Friend WithEvents TabPageP_M_PA As TabPage
    Friend WithEvents TabPageSP As TabPage
    Friend WithEvents Panel1 As Panel
End Class
