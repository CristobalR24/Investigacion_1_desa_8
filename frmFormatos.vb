Public Class frmFormatos
    Private formato As String 'variable global formato

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFormato1.SelectedIndexChanged
        Select Case cboFormato1.SelectedIndex 'dependiedo de lo que seleccionemos en
            Case 0                          'el combobox se asignara a formato un tipo predefinido
                formato = "General Date"
            Case 1
                formato = "Long Date"
            Case 2
                formato = "short Date"
            Case 3
                formato = "Long Time"
            Case 4
                formato = "Short Time"
        End Select
        DarFormato()
    End Sub
    Private Sub DarFormato()
        txtMuestra.Text = Format(dtpElegir.Value, formato) 'da formato al texto elegido en el timepicker
    End Sub
    Private Sub Ir_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        formato = txtPropio1.Text 'dar formato propio
        Dim p As Integer = 0
        '------------
        For Each element As Char In formato 'metodo que evita colocar numeros en formato propio
            If IsNumeric(element) Then      'ya que no hay ningun codigo de formato que use numeros
                p = p + 1
            End If
        Next

        If p = 0 Then
            '---------
        End If
        DarFormato()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpElegir.ValueChanged, MyBase.Load
        txtMuestra.Text = dtpElegir.Value.ToString 'cada vez que se entre a esta funcionalidad
    End Sub                                     'el texto resultado tendra el valor del timepicker

    Private Sub btnRegresar2_Click(sender As Object, e As EventArgs) Handles btnRegresar2.Click
        Me.Hide()
        frmPrincipal.Show()
    End Sub


End Class