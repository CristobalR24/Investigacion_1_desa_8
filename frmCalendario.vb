Public Class frmCalendario
    Private _year As Integer
    Private _mes As Integer
    'Private formato As String = "short Date" 'formato por defecto en este programa
    Public Property dia 'definimos dia y hora como propiedades publicas
    Public Property hora
    Public Property mes As Integer 'creamos mes como propiedad y añadimos set/get
        Get
            Return _mes
        End Get
        Set(value As Integer)
            If _mes <> value Then 'si el valor actual de mes es distinto al valor asignado
                _mes = value 'igualamos los valores
                If _mes <> cboMes.SelectedIndex + 1 Then 'si el mes es distinto al que aparece en el combobox
                    cboMes.SelectedIndex = _mes - 1 'cuando escogemos por el month calendar
                End If
                If _mes <> mclCalendar.SelectionStart.Month And _year > 0 And dia > 0 Then
                    'si el mes es distinto al que aparece en el month calendar
                    mclCalendar.SelectionStart = New Date(_year, _mes, dia) 'cuando escogemos por el combobox
                End If
            End If
            'el proposito es que podamos elegir el mes tanto por datepicker como por combobox
        End Set
    End Property
    Public Property year As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            If _year <> value Then
                _year = value
                If _year <> nudYear.Value Then
                    nudYear.Value = _year 'si escogemos por month calendar
                End If
                If _year <> mclCalendar.SelectionStart.Year And _mes > 0 And dia > 0 Then
                    mclCalendar.SelectionStart = New Date(_year, _mes, dia) 'si escogemos por input numerico
                End If
            End If
        End Set
    End Property

    Public Sub cambiarFecha(ByVal Fecha As DateTime) 'metodo que cambia la fecha en el texto de resultado
        dia = Fecha.Day
        mes = Fecha.Month
        year = Fecha.Year
        lblFecha.Text = Fecha.ToString("dd/MM/yyyy")
    End Sub
    Private Sub frmCalendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiarFecha(Now) 'la primera vez que entremos a esta funcionalidad se mostrara la fecha del sistema
    End Sub

    Private Sub nudYear_ValueChanged(sender As Object, e As EventArgs) Handles nudYear.ValueChanged
        year = nudYear.Value 'se setea el año escogido en el input numerico a la propiedad year
    End Sub

    Private Sub cboMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMes.SelectedIndexChanged
        mes = cboMes.SelectedIndex + 1 'se setea el año escogido en el combobox a la propiedad mes
        'se suma uno porque el index empieza en 0 (de 0-11 pasa a 1-12)
    End Sub

    Private Sub mclCalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mclCalendar.DateChanged
        cambiarFecha(mclCalendar.SelectionStart)
        'cambia la fecha en el texto de resultado dependiendo del valor escogido en el month calendar
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        frmPrincipal.Show()
    End Sub

End Class