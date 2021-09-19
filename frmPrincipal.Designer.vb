<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalendar = New System.Windows.Forms.Button()
        Me.btnArchivos = New System.Windows.Forms.Button()
        Me.btnSecuencial = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnFechas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(144, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Investigación 1"
        '
        'btnCalendar
        '
        Me.btnCalendar.Location = New System.Drawing.Point(137, 60)
        Me.btnCalendar.Name = "btnCalendar"
        Me.btnCalendar.Size = New System.Drawing.Size(153, 42)
        Me.btnCalendar.TabIndex = 1
        Me.btnCalendar.Text = "Calendario"
        Me.btnCalendar.UseVisualStyleBackColor = True
        '
        'btnArchivos
        '
        Me.btnArchivos.Location = New System.Drawing.Point(137, 156)
        Me.btnArchivos.Name = "btnArchivos"
        Me.btnArchivos.Size = New System.Drawing.Size(153, 42)
        Me.btnArchivos.TabIndex = 3
        Me.btnArchivos.Text = "Cajas de dialogo"
        Me.btnArchivos.UseVisualStyleBackColor = True
        '
        'btnSecuencial
        '
        Me.btnSecuencial.Location = New System.Drawing.Point(137, 204)
        Me.btnSecuencial.Name = "btnSecuencial"
        Me.btnSecuencial.Size = New System.Drawing.Size(153, 42)
        Me.btnSecuencial.TabIndex = 4
        Me.btnSecuencial.Text = "Archivo secuencial"
        Me.btnSecuencial.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(365, 9)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(73, 32)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnFechas
        '
        Me.btnFechas.Location = New System.Drawing.Point(137, 108)
        Me.btnFechas.Name = "btnFechas"
        Me.btnFechas.Size = New System.Drawing.Size(153, 42)
        Me.btnFechas.TabIndex = 6
        Me.btnFechas.Text = "Formato de fechas"
        Me.btnFechas.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFechas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSecuencial)
        Me.Controls.Add(Me.btnArchivos)
        Me.Controls.Add(Me.btnCalendar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPrincipal"
        Me.Text = "Investigación 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalendar As Button
    Friend WithEvents btnArchivos As Button
    Friend WithEvents btnSecuencial As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnFechas As Button
End Class
