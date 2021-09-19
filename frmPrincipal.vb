Public Class frmPrincipal
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnCalendar.Click, btnFechas.Click, btnArchivos.Click, btnSecuencial.Click
        Dim boton As Button = CType(sender, Button)
        'este metodo controla los eventos relacionados al menu principal
        Me.Hide()
        Select Case boton.Name
            Case "btnCalendar"
                frmCalendario.Show()
            Case "btnFechas"
                frmFormatos.Show()
            Case "btnArchivos"
                frmEditor.Show()
            Case "btnSecuencial"
                frmArchivos.Show()
        End Select

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
