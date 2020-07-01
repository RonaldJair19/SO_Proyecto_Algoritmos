<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageEnvejecimiento = New System.Windows.Forms.TabPage()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.ButtonTerminar = New System.Windows.Forms.Button()
        Me.TextBoxValorPulsos = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxPulsos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.N_ContBits = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_CuadrosPag = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPageSC = New System.Windows.Forms.TabPage()
        Me.TabPageSegmentacion = New System.Windows.Forms.TabPage()
        Me.TabPageP_M_PA = New System.Windows.Forms.TabPage()
        Me.TabPageSP = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPageEnvejecimiento.SuspendLayout()
        CType(Me.N_ContBits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageEnvejecimiento)
        Me.TabControl1.Controls.Add(Me.TabPageSC)
        Me.TabControl1.Controls.Add(Me.TabPageSegmentacion)
        Me.TabControl1.Controls.Add(Me.TabPageP_M_PA)
        Me.TabControl1.Controls.Add(Me.TabPageSP)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 148)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(906, 586)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageEnvejecimiento
        '
        Me.TabPageEnvejecimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPageEnvejecimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageEnvejecimiento.Controls.Add(Me.ButtonAgregar)
        Me.TabPageEnvejecimiento.Controls.Add(Me.ButtonTerminar)
        Me.TabPageEnvejecimiento.Controls.Add(Me.TextBoxValorPulsos)
        Me.TabPageEnvejecimiento.Controls.Add(Me.Button1)
        Me.TabPageEnvejecimiento.Controls.Add(Me.TextBoxPulsos)
        Me.TabPageEnvejecimiento.Controls.Add(Me.Label4)
        Me.TabPageEnvejecimiento.Controls.Add(Me.N_ContBits)
        Me.TabPageEnvejecimiento.Controls.Add(Me.Label3)
        Me.TabPageEnvejecimiento.Controls.Add(Me.TB_CuadrosPag)
        Me.TabPageEnvejecimiento.Controls.Add(Me.Label2)
        Me.TabPageEnvejecimiento.Controls.Add(Me.Label1)
        Me.TabPageEnvejecimiento.Location = New System.Drawing.Point(4, 27)
        Me.TabPageEnvejecimiento.Name = "TabPageEnvejecimiento"
        Me.TabPageEnvejecimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEnvejecimiento.Size = New System.Drawing.Size(898, 555)
        Me.TabPageEnvejecimiento.TabIndex = 0
        Me.TabPageEnvejecimiento.Text = "A. de Envejecimiento"
        Me.TabPageEnvejecimiento.UseVisualStyleBackColor = True
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonAgregar.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonAgregar.Enabled = False
        Me.ButtonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonAgregar.FlatAppearance.BorderSize = 2
        Me.ButtonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAgregar.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregar.ForeColor = System.Drawing.Color.White
        Me.ButtonAgregar.Location = New System.Drawing.Point(546, 97)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(90, 35)
        Me.ButtonAgregar.TabIndex = 12
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = False
        '
        'ButtonTerminar
        '
        Me.ButtonTerminar.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonTerminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonTerminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonTerminar.Enabled = False
        Me.ButtonTerminar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonTerminar.FlatAppearance.BorderSize = 2
        Me.ButtonTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonTerminar.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTerminar.ForeColor = System.Drawing.Color.White
        Me.ButtonTerminar.Location = New System.Drawing.Point(752, 97)
        Me.ButtonTerminar.Name = "ButtonTerminar"
        Me.ButtonTerminar.Size = New System.Drawing.Size(102, 35)
        Me.ButtonTerminar.TabIndex = 11
        Me.ButtonTerminar.Text = "Terminar"
        Me.ButtonTerminar.UseVisualStyleBackColor = False
        '
        'TextBoxValorPulsos
        '
        Me.TextBoxValorPulsos.Location = New System.Drawing.Point(502, 138)
        Me.TextBoxValorPulsos.Multiline = True
        Me.TextBoxValorPulsos.Name = "TextBoxValorPulsos"
        Me.TextBoxValorPulsos.ReadOnly = True
        Me.TextBoxValorPulsos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBoxValorPulsos.Size = New System.Drawing.Size(386, 88)
        Me.TextBoxValorPulsos.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(187, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBoxPulsos
        '
        Me.TextBoxPulsos.Location = New System.Drawing.Point(742, 61)
        Me.TextBoxPulsos.Name = "TextBoxPulsos"
        Me.TextBoxPulsos.Size = New System.Drawing.Size(146, 27)
        Me.TextBoxPulsos.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(499, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Agrege los pulsos de reloj:"
        '
        'N_ContBits
        '
        Me.N_ContBits.Location = New System.Drawing.Point(379, 104)
        Me.N_ContBits.Name = "N_ContBits"
        Me.N_ContBits.Size = New System.Drawing.Size(100, 27)
        Me.N_ContBits.TabIndex = 5
        Me.N_ContBits.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(337, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ingrese el tamaño del contador en bits:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TB_CuadrosPag
        '
        Me.TB_CuadrosPag.Location = New System.Drawing.Point(379, 61)
        Me.TB_CuadrosPag.Name = "TB_CuadrosPag"
        Me.TB_CuadrosPag.Size = New System.Drawing.Size(100, 27)
        Me.TB_CuadrosPag.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(356, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese la cantidad de cuadros de página:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Algoritmo de envejecimiento"
        '
        'TabPageSC
        '
        Me.TabPageSC.Location = New System.Drawing.Point(4, 27)
        Me.TabPageSC.Name = "TabPageSC"
        Me.TabPageSC.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSC.Size = New System.Drawing.Size(898, 555)
        Me.TabPageSC.TabIndex = 1
        Me.TabPageSC.Text = "A. Sistema Compañero"
        Me.TabPageSC.UseVisualStyleBackColor = True
        '
        'TabPageSegmentacion
        '
        Me.TabPageSegmentacion.Location = New System.Drawing.Point(4, 27)
        Me.TabPageSegmentacion.Name = "TabPageSegmentacion"
        Me.TabPageSegmentacion.Size = New System.Drawing.Size(898, 555)
        Me.TabPageSegmentacion.TabIndex = 2
        Me.TabPageSegmentacion.Text = "Segmentación"
        Me.TabPageSegmentacion.UseVisualStyleBackColor = True
        '
        'TabPageP_M_PA
        '
        Me.TabPageP_M_PA.Location = New System.Drawing.Point(4, 27)
        Me.TabPageP_M_PA.Name = "TabPageP_M_PA"
        Me.TabPageP_M_PA.Size = New System.Drawing.Size(898, 555)
        Me.TabPageP_M_PA.TabIndex = 3
        Me.TabPageP_M_PA.Text = "A. P_M_PA"
        Me.TabPageP_M_PA.UseVisualStyleBackColor = True
        '
        'TabPageSP
        '
        Me.TabPageSP.Location = New System.Drawing.Point(4, 27)
        Me.TabPageSP.Name = "TabPageSP"
        Me.TabPageSP.Size = New System.Drawing.Size(898, 555)
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
        Me.ClientSize = New System.Drawing.Size(930, 738)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Proyecto_Memoria"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageEnvejecimiento.ResumeLayout(False)
        Me.TabPageEnvejecimiento.PerformLayout()
        CType(Me.N_ContBits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageEnvejecimiento As TabPage
    Friend WithEvents TabPageSC As TabPage
    Friend WithEvents TabPageSegmentacion As TabPage
    Friend WithEvents TabPageP_M_PA As TabPage
    Friend WithEvents TabPageSP As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TB_CuadrosPag As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents N_ContBits As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxPulsos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxValorPulsos As TextBox
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents ButtonTerminar As Button
End Class
