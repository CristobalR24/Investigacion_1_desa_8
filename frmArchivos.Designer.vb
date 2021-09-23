<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArchivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArchivos))
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.btnLeer = New System.Windows.Forms.Button()
        Me.btnRegresar1 = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtCampo1 = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.ofdLectura = New System.Windows.Forms.OpenFileDialog()
        Me.btnEscribir = New System.Windows.Forms.Button()
        Me.sfdEscribir = New System.Windows.Forms.SaveFileDialog()
        Me.lblIndicaciones = New System.Windows.Forms.Label()
        Me.cboColumna = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresca = New System.Windows.Forms.Button()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToResizeColumns = False
        Me.dgvDatos.AllowUserToResizeRows = False
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(43, 168)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RowTemplate.Height = 25
        Me.dgvDatos.Size = New System.Drawing.Size(353, 105)
        Me.dgvDatos.TabIndex = 6
        '
        'btnLeer
        '
        Me.btnLeer.BackColor = System.Drawing.Color.Wheat
        Me.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLeer.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLeer.Location = New System.Drawing.Point(241, 19)
        Me.btnLeer.Name = "btnLeer"
        Me.btnLeer.Size = New System.Drawing.Size(96, 27)
        Me.btnLeer.TabIndex = 0
        Me.btnLeer.Text = "Leer Archivo"
        Me.btnLeer.UseVisualStyleBackColor = False
        '
        'btnRegresar1
        '
        Me.btnRegresar1.BackColor = System.Drawing.Color.LightBlue
        Me.btnRegresar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar1.Location = New System.Drawing.Point(351, 19)
        Me.btnRegresar1.Name = "btnRegresar1"
        Me.btnRegresar1.Size = New System.Drawing.Size(83, 27)
        Me.btnRegresar1.TabIndex = 1
        Me.btnRegresar1.Text = "Regresar"
        Me.btnRegresar1.UseVisualStyleBackColor = False
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDireccion.Location = New System.Drawing.Point(27, 23)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(208, 23)
        Me.txtDireccion.TabIndex = 2
        Me.txtDireccion.WordWrap = False
        '
        'txtCampo1
        '
        Me.txtCampo1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCampo1.Location = New System.Drawing.Point(43, 95)
        Me.txtCampo1.Name = "txtCampo1"
        Me.txtCampo1.Size = New System.Drawing.Size(193, 23)
        Me.txtCampo1.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Wheat
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBuscar.Location = New System.Drawing.Point(242, 90)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(95, 28)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'ofdLectura
        '
        Me.ofdLectura.FileName = "OpenFileDialog1"
        '
        'btnEscribir
        '
        Me.btnEscribir.BackColor = System.Drawing.Color.Khaki
        Me.btnEscribir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEscribir.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEscribir.Location = New System.Drawing.Point(290, 277)
        Me.btnEscribir.Name = "btnEscribir"
        Me.btnEscribir.Size = New System.Drawing.Size(106, 38)
        Me.btnEscribir.TabIndex = 8
        Me.btnEscribir.Text = "Guardar"
        Me.btnEscribir.UseVisualStyleBackColor = False
        Me.btnEscribir.Visible = False
        '
        'lblIndicaciones
        '
        Me.lblIndicaciones.AutoSize = True
        Me.lblIndicaciones.BackColor = System.Drawing.Color.Khaki
        Me.lblIndicaciones.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIndicaciones.Location = New System.Drawing.Point(12, 290)
        Me.lblIndicaciones.Name = "lblIndicaciones"
        Me.lblIndicaciones.Size = New System.Drawing.Size(272, 14)
        Me.lblIndicaciones.TabIndex = 9
        Me.lblIndicaciones.Text = "ninguna coincidencia, agrege datos y guardelos:"
        Me.lblIndicaciones.Visible = False
        '
        'cboColumna
        '
        Me.cboColumna.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cboColumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumna.Enabled = False
        Me.cboColumna.FormattingEnabled = True
        Me.cboColumna.Location = New System.Drawing.Point(115, 124)
        Me.cboColumna.Name = "cboColumna"
        Me.cboColumna.Size = New System.Drawing.Size(121, 23)
        Me.cboColumna.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(43, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Columna:"
        '
        'btnRefresca
        '
        Me.btnRefresca.BackColor = System.Drawing.Color.Khaki
        Me.btnRefresca.Enabled = False
        Me.btnRefresca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresca.Location = New System.Drawing.Point(321, 139)
        Me.btnRefresca.Name = "btnRefresca"
        Me.btnRefresca.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresca.TabIndex = 12
        Me.btnRefresca.Text = "Recargar"
        Me.btnRefresca.UseVisualStyleBackColor = False
        '
        'frmArchivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(446, 327)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRefresca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboColumna)
        Me.Controls.Add(Me.lblIndicaciones)
        Me.Controls.Add(Me.btnEscribir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.txtCampo1)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.btnRegresar1)
        Me.Controls.Add(Me.btnLeer)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArchivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmArchivos"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLeer As Button
    Friend WithEvents btnRegresar1 As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtCampo1 As TextBox
    Friend WithEvents txtCampo2 As TextBox
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents ofdLectura As OpenFileDialog
    Friend WithEvents btnEscribir As Button
    Friend WithEvents sfdEscribir As SaveFileDialog
    Friend WithEvents lblIndicaciones As Label
    Friend WithEvents cboColumna As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefresca As Button
End Class
