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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalendario))
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
        Me.mclCalendar.BackColor = System.Drawing.Color.LightBlue
        Me.mclCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.mclCalendar.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mclCalendar.Location = New System.Drawing.Point(109, 114)
        Me.mclCalendar.MaxSelectionCount = 1
        Me.mclCalendar.Name = "mclCalendar"
        Me.mclCalendar.ScrollChange = 1
        Me.mclCalendar.TabIndex = 0
        Me.mclCalendar.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.mclCalendar.TrailingForeColor = System.Drawing.SystemColors.ControlDarkDark
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblFecha.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblFecha.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFecha.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFecha.Location = New System.Drawing.Point(136, 21)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.ReadOnly = True
        Me.lblFecha.ShortcutsEnabled = False
        Me.lblFecha.Size = New System.Drawing.Size(190, 25)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lblFecha.WordWrap = False
        '
        'nudYear
        '
        Me.nudYear.BackColor = System.Drawing.Color.MintCream
        Me.nudYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudYear.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nudYear.Location = New System.Drawing.Point(292, 77)
        Me.nudYear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1753, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(57, 20)
        Me.nudYear.TabIndex = 2
        Me.nudYear.Value = New Decimal(New Integer() {1753, 0, 0, 0})
        '
        'cboMes
        '
        Me.cboMes.BackColor = System.Drawing.Color.PaleTurquoise
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboMes.Location = New System.Drawing.Point(91, 76)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(121, 21)
        Me.cboMes.TabIndex = 3
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru
        Me.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Location = New System.Drawing.Point(355, 19)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(83, 34)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(14, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fecha escogida:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(227, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Del "
        '
        'frmCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.cboMes)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.mclCalendar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCalendario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
