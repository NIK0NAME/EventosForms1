<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cBox = New System.Windows.Forms.TextBox()
        Me.fBox = New System.Windows.Forms.TextBox()
        Me.convert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Temperatura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Centigrados Cº"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fahrenheit Fº"
        '
        'cBox
        '
        Me.cBox.Location = New System.Drawing.Point(194, 56)
        Me.cBox.Name = "cBox"
        Me.cBox.Size = New System.Drawing.Size(54, 20)
        Me.cBox.TabIndex = 3
        '
        'fBox
        '
        Me.fBox.Location = New System.Drawing.Point(194, 96)
        Me.fBox.Name = "fBox"
        Me.fBox.Size = New System.Drawing.Size(54, 20)
        Me.fBox.TabIndex = 4
        '
        'convert
        '
        Me.convert.Location = New System.Drawing.Point(138, 139)
        Me.convert.Name = "convert"
        Me.convert.Size = New System.Drawing.Size(75, 23)
        Me.convert.TabIndex = 5
        Me.convert.Text = "Convertir"
        Me.convert.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 183)
        Me.Controls.Add(Me.convert)
        Me.Controls.Add(Me.fBox)
        Me.Controls.Add(Me.cBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Conversor de Temperatura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cBox As TextBox
    Friend WithEvents fBox As TextBox
    Friend WithEvents convert As Button
End Class
