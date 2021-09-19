<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendario
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
        Me.mclCalendar = New System.Windows.Forms.MonthCalendar()
        Me.lblFecha = New System.Windows.Forms.TextBox()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mclCalendar
        '
        Me.mclCalendar.Location = New System.Drawing.Point(109, 114)
        Me.mclCalendar.MaxSelectionCount = 1
        Me.mclCalendar.Name = "mclCalendar"
        Me.mclCalendar.TabIndex = 0
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblFecha.Location = New System.Drawing.Point(136, 21)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.ReadOnly = True
        Me.lblFecha.Size = New System.Drawing.Size(190, 23)
        Me.lblFecha.TabIndex = 1
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(291, 77)
        Me.nudYear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(57, 23)
        Me.nudYear.TabIndex = 2
        Me.nudYear.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.Location = New System.Drawing.Point(83, 78)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(121, 23)
        Me.cboMes.TabIndex = 3
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(355, 19)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(83, 34)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fecha escogida:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(227, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Del "
        '
        'frmCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.cboMes)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.mclCalendar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCalendario"
        Me.Text = "frmCalendario"
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mclCalendar As MonthCalendar
    Friend WithEvents lblFecha As TextBox
    Friend WithEvents nudYear As NumericUpDown
    Friend WithEvents cboMes As ComboBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
End Class
