<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblFactorial = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtFactorial = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(48, 26)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(57, 15)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "NUMERO"
        '
        'lblFactorial
        '
        Me.lblFactorial.AutoSize = True
        Me.lblFactorial.Location = New System.Drawing.Point(48, 79)
        Me.lblFactorial.Name = "lblFactorial"
        Me.lblFactorial.Size = New System.Drawing.Size(66, 15)
        Me.lblFactorial.TabIndex = 1
        Me.lblFactorial.Text = "FACTORIAL"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(124, 26)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 23)
        Me.txtNumero.TabIndex = 2
        '
        'txtFactorial
        '
        Me.txtFactorial.Enabled = False
        Me.txtFactorial.Location = New System.Drawing.Point(124, 71)
        Me.txtFactorial.Name = "txtFactorial"
        Me.txtFactorial.Size = New System.Drawing.Size(100, 23)
        Me.txtFactorial.TabIndex = 3
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(48, 115)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(149, 115)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 358)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtFactorial)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblFactorial)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero As Label
    Friend WithEvents lblFactorial As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtFactorial As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
End Class
