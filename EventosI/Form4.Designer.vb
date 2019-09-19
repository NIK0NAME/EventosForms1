<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.inNum = New System.Windows.Forms.TextBox()
        Me.addNum = New System.Windows.Forms.Button()
        Me.minBox = New System.Windows.Forms.TextBox()
        Me.medBox = New System.Windows.Forms.TextBox()
        Me.maxBox = New System.Windows.Forms.TextBox()
        Me.labelmin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introducir numeros:"
        '
        'inNum
        '
        Me.inNum.Location = New System.Drawing.Point(115, 16)
        Me.inNum.Name = "inNum"
        Me.inNum.Size = New System.Drawing.Size(75, 20)
        Me.inNum.TabIndex = 1
        '
        'addNum
        '
        Me.addNum.Location = New System.Drawing.Point(196, 15)
        Me.addNum.Name = "addNum"
        Me.addNum.Size = New System.Drawing.Size(75, 23)
        Me.addNum.TabIndex = 2
        Me.addNum.Text = "Guardar"
        Me.addNum.UseVisualStyleBackColor = True
        '
        'minBox
        '
        Me.minBox.Location = New System.Drawing.Point(15, 72)
        Me.minBox.Name = "minBox"
        Me.minBox.Size = New System.Drawing.Size(55, 20)
        Me.minBox.TabIndex = 3
        '
        'medBox
        '
        Me.medBox.Location = New System.Drawing.Point(172, 72)
        Me.medBox.Name = "medBox"
        Me.medBox.Size = New System.Drawing.Size(55, 20)
        Me.medBox.TabIndex = 4
        '
        'maxBox
        '
        Me.maxBox.Location = New System.Drawing.Point(343, 72)
        Me.maxBox.Name = "maxBox"
        Me.maxBox.Size = New System.Drawing.Size(55, 20)
        Me.maxBox.TabIndex = 5
        '
        'labelmin
        '
        Me.labelmin.AutoSize = True
        Me.labelmin.Location = New System.Drawing.Point(12, 56)
        Me.labelmin.Name = "labelmin"
        Me.labelmin.Size = New System.Drawing.Size(40, 13)
        Me.labelmin.TabIndex = 6
        Me.labelmin.Text = "Minimo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Media"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(340, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Maxiomo"
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(277, 15)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 9
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 106)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelmin)
        Me.Controls.Add(Me.maxBox)
        Me.Controls.Add(Me.medBox)
        Me.Controls.Add(Me.minBox)
        Me.Controls.Add(Me.addNum)
        Me.Controls.Add(Me.inNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inNum As TextBox
    Friend WithEvents addNum As Button
    Friend WithEvents minBox As TextBox
    Friend WithEvents medBox As TextBox
    Friend WithEvents maxBox As TextBox
    Friend WithEvents labelmin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents reset As Button
End Class
