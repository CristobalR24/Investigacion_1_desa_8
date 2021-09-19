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
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToResizeColumns = False
        Me.dgvDatos.AllowUserToResizeRows = False
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDatos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(43, 168)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RowTemplate.Height = 25
        Me.dgvDatos.Size = New System.Drawing.Size(353, 105)
        Me.dgvDatos.TabIndex = 6
        '
        'btnLeer
        '
        Me.btnLeer.Location = New System.Drawing.Point(257, 23)
        Me.btnLeer.Name = "btnLeer"
        Me.btnLeer.Size = New System.Drawing.Size(81, 28)
        Me.btnLeer.TabIndex = 0
        Me.btnLeer.Text = "Leer Archivo"
        Me.btnLeer.UseVisualStyleBackColor = True
        '
        'btnRegresar1
        '
        Me.btnRegresar1.Location = New System.Drawing.Point(363, 23)
        Me.btnRegresar1.Name = "btnRegresar1"
        Me.btnRegresar1.Size = New System.Drawing.Size(71, 28)
        Me.btnRegresar1.TabIndex = 1
        Me.btnRegresar1.Text = "Regresar"
        Me.btnRegresar1.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(43, 27)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(208, 23)
        Me.txtDireccion.TabIndex = 2
        '
        'txtCampo1
        '
        Me.txtCampo1.Location = New System.Drawing.Point(43, 95)
        Me.txtCampo1.Name = "txtCampo1"
        Me.txtCampo1.Size = New System.Drawing.Size(193, 23)
        Me.txtCampo1.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Location = New System.Drawing.Point(241, 86)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(97, 39)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ofdLectura
        '
        Me.ofdLectura.FileName = "OpenFileDialog1"
        '
        'btnEscribir
        '
        Me.btnEscribir.Location = New System.Drawing.Point(282, 277)
        Me.btnEscribir.Name = "btnEscribir"
        Me.btnEscribir.Size = New System.Drawing.Size(114, 38)
        Me.btnEscribir.TabIndex = 8
        Me.btnEscribir.Text = "Guardar"
        Me.btnEscribir.UseVisualStyleBackColor = True
        Me.btnEscribir.Visible = False
        '
        'lblIndicaciones
        '
        Me.lblIndicaciones.AutoSize = True
        Me.lblIndicaciones.Location = New System.Drawing.Point(14, 289)
        Me.lblIndicaciones.Name = "lblIndicaciones"
        Me.lblIndicaciones.Size = New System.Drawing.Size(262, 15)
        Me.lblIndicaciones.TabIndex = 9
        Me.lblIndicaciones.Text = "ninguna coincidencia, agrege datos y guardelos:"
        Me.lblIndicaciones.Visible = False
        '
        'cboColumna
        '
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
        Me.Label1.Location = New System.Drawing.Point(50, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Columna:"
        '
        'frmArchivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 327)
        Me.ControlBox = False
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
        Me.Name = "frmArchivos"
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
End Class
