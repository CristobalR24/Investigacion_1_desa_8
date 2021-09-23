<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormatos))
        Me.dtpElegir = New System.Windows.Forms.DateTimePicker()
        Me.txtMuestra = New System.Windows.Forms.TextBox()
        Me.cboFormato1 = New System.Windows.Forms.ComboBox()
        Me.txtPropio1 = New System.Windows.Forms.TextBox()
        Me.btnIr = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegresar2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpElegir
        '
        Me.dtpElegir.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpElegir.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpElegir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpElegir.Location = New System.Drawing.Point(118, 55)
        Me.dtpElegir.Name = "dtpElegir"
        Me.dtpElegir.Size = New System.Drawing.Size(206, 20)
        Me.dtpElegir.TabIndex = 0
        '
        'txtMuestra
        '
        Me.txtMuestra.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtMuestra.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtMuestra.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMuestra.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtMuestra.Location = New System.Drawing.Point(60, 92)
        Me.txtMuestra.Name = "txtMuestra"
        Me.txtMuestra.ReadOnly = True
        Me.txtMuestra.Size = New System.Drawing.Size(314, 25)
        Me.txtMuestra.TabIndex = 1
        Me.txtMuestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMuestra.WordWrap = False
        '
        'cboFormato1
        '
        Me.cboFormato1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.cboFormato1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboFormato1.FormattingEnabled = True
        Me.cboFormato1.Items.AddRange(New Object() {"Fecha general", "Fecha larga", "Fecha corta", "Tiempo largo", "Tiempo corto"})
        Me.cboFormato1.Location = New System.Drawing.Point(25, 150)
        Me.cboFormato1.Name = "cboFormato1"
        Me.cboFormato1.Size = New System.Drawing.Size(181, 23)
        Me.cboFormato1.TabIndex = 6
        Me.cboFormato1.Tag = ""
        '
        'txtPropio1
        '
        Me.txtPropio1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPropio1.Location = New System.Drawing.Point(247, 150)
        Me.txtPropio1.Name = "txtPropio1"
        Me.txtPropio1.Size = New System.Drawing.Size(145, 23)
        Me.txtPropio1.TabIndex = 7
        '
        'btnIr
        '
        Me.btnIr.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnIr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIr.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnIr.Location = New System.Drawing.Point(390, 150)
        Me.btnIr.Name = "btnIr"
        Me.btnIr.Size = New System.Drawing.Size(39, 23)
        Me.btnIr.TabIndex = 8
        Me.btnIr.Text = "->"
        Me.btnIr.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(247, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "MM/dd/yyyy h:mm:ss tt "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(250, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "h:mm:ss tt "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(247, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "dd/MM/yyyy  -  MMM.d.yyyy"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(247, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "M  -  MM  -  MMM  -  MMMM      "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(247, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Formatos sugeridos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(25, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Formatos predefinidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(247, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Formato propio:"
        '
        'btnRegresar2
        '
        Me.btnRegresar2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnRegresar2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRegresar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru
        Me.btnRegresar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan
        Me.btnRegresar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar2.Location = New System.Drawing.Point(352, 12)
        Me.btnRegresar2.Name = "btnRegresar2"
        Me.btnRegresar2.Size = New System.Drawing.Size(84, 34)
        Me.btnRegresar2.TabIndex = 23
        Me.btnRegresar2.Text = "Regresar"
        Me.btnRegresar2.UseVisualStyleBackColor = False
        '
        'frmFormatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRegresar2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnIr)
        Me.Controls.Add(Me.txtPropio1)
        Me.Controls.Add(Me.cboFormato1)
        Me.Controls.Add(Me.txtMuestra)
        Me.Controls.Add(Me.dtpElegir)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFormatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFormatos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpElegir As DateTimePicker
    Friend WithEvents txtMuestra As TextBox
    Friend WithEvents cboFormato1 As ComboBox
    Friend WithEvents txtPropio1 As TextBox
    Friend WithEvents btnIr As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegresar2 As Button
End Class
