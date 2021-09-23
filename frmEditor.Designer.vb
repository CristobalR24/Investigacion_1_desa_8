<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditor))
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtTexto = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAbrir
        '
        Me.btnAbrir.BackColor = System.Drawing.Color.Khaki
        Me.btnAbrir.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.btnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbrir.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAbrir.Location = New System.Drawing.Point(21, 78)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(164, 40)
        Me.btnAbrir.TabIndex = 0
        Me.btnAbrir.Text = "Abrir archivo"
        Me.btnAbrir.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Khaki
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGuardar.Location = New System.Drawing.Point(21, 171)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(164, 40)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar Archivo"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtTexto
        '
        Me.txtTexto.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtTexto.Location = New System.Drawing.Point(208, 47)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(215, 223)
        Me.txtTexto.TabIndex = 2
        Me.txtTexto.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.LightBlue
        Me.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Location = New System.Drawing.Point(355, 7)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(83, 34)
        Me.btnRegresar.TabIndex = 5
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'frmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 322)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAbrir)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditor"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAbrir As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtTexto As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnRegresar As Button
End Class
