Imports System.IO
Imports System.Windows
Public Class frmEditor
    Private Sub logica(sender As Object, e As EventArgs) Handles btnAbrir.Click, btnGuardar.Click

        Dim boton As Button = CType(sender, Button)

        Select Case boton.Name
            Case "btnAbrir"

                OpenFileDialog1.InitialDirectory = "C:\\Documents"



                OpenFileDialog1.ValidateNames = True
                OpenFileDialog1.CheckPathExists = True


                OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"

                Dim Resultado As DialogResult = OpenFileDialog1.ShowDialog()

                If Resultado = Windows.Forms.DialogResult.OK Then
                    Dim path As String = OpenFileDialog1.FileName
                    Try
                        Dim text As String = File.ReadAllText(path)
                        txtTexto.Text = text.ToString
                    Catch ex As Exception

                    End Try
                End If

            Case "btnGuardar"

                SaveFileDialog1.InitialDirectory = "C:\\Documents"
                SaveFileDialog1.ValidateNames = True
                SaveFileDialog1.RestoreDirectory = True
                SaveFileDialog1.CheckPathExists = True
                'No tendrá que colocar [NombreArchivo] + Extensión ya que lo hará solo
                SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                'Variable que almacena el resultado de la interacción 
                Dim Result As DialogResult = SaveFileDialog1.ShowDialog()

                If Result = Windows.Forms.DialogResult.OK Then
                    'Guardamos el documento con su contenido
                    Try
                        File.WriteAllText(SaveFileDialog1.FileName, txtTexto.Text)
                    Catch ex As Exception

                    End Try


                End If


        End Select
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        frmPrincipal.Show()
    End Sub
End Class
