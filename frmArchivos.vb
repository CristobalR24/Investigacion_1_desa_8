Imports System.IO
Imports System.WindowsPublic
Class frmArchivos

    Private Sub secuenciales(sender As Object, e As EventArgs) Handles btnLeer.Click, btnEscribir.Click

        Dim boton As Button = CType(sender, Button)
        'se determina si se esta abriendo un archivo o guardando uno
        Select Case boton.Name
            Case "btnLeer"
                Limpiar()
                ofdLectura.InitialDirectory = "C:\\Documents"

                ofdLectura.ValidateNames = True
                ofdLectura.CheckPathExists = True

                ofdLectura.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"

                Dim Resultado As DialogResult = ofdLectura.ShowDialog()

                If Resultado = Windows.Forms.DialogResult.OK Then

                    txtDireccion.Text = ofdLectura.FileName
                    'llamamos al metodo cargar datos
                    CargarDatos()
                    cboColumna.Enabled = True 'una vez cargador podemos buscar
                    btnBuscar.Enabled = True
                End If

            Case "btnEscribir"

                sfdEscribir.InitialDirectory = "C:\\Documents"
                sfdEscribir.ValidateNames = True
                sfdEscribir.RestoreDirectory = True
                sfdEscribir.CheckPathExists = True
                'No tendrá que colocar [NombreArchivo] + Extensión ya que lo hará solo
                sfdEscribir.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                'Variable que almacena el resultado de la interacción 
                Dim Result As DialogResult = sfdEscribir.ShowDialog()

                If Result = Windows.Forms.DialogResult.OK Then
                    'Guardamos el documento con su contenido
                    Try
                        'obtenemos el texto del archivo
                        Dim text As String = File.ReadAllText(ofdLectura.FileName)

                        For f = 0 To dgvDatos.Rows.Count - 1
                            text = text & vbCrLf 'salto de linea en cada nueva fila
                            For c = 0 To dgvDatos.Columns.Count - 1
                                If Not dgvDatos.Item(c, f).Value Is Nothing Then 'se va leyendo columna por columna en cada fila
                                    text = text + dgvDatos.Item(c, f).Value.ToString + "," 'y se separan con coma

                                End If
                            Next
                            text = text.Substring(0, text.Length - 1) 'eliminamos la ultima coma extra para no crear 
                        Next                                            'columnas innecesarias

                        File.WriteAllText(sfdEscribir.FileName, text) 'permite escribir archivos
                        MessageBox.Show("datos guardados")
                        Limpiar()

                    Catch ex As Exception

                    End Try


                End If

        End Select
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar1.Click
        Limpiar()
        Me.Hide()
        frmPrincipal.Show()
    End Sub
    Private Sub Limpiar() 'metodo encargado de dejar el forms como nuevo
        dgvDatos.Rows.Clear()
        dgvDatos.Columns.Clear()
        txtDireccion.Clear()
        txtCampo1.Clear()
        btnBuscar.Enabled = False
        btnEscribir.Visible = False
        lblIndicaciones.Visible = False
        cboColumna.Enabled = False
        cboColumna.Items.Clear()
        btnRefresca.Enabled = False
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dato As String
        Dim c As Integer
        dato = txtCampo1.Text
        c = cboColumna.SelectedIndex 'seleccionamos la columna en donde buscaremos
        'contamos hacia atras para no tener conflictos con los datos borrados
        For f = dgvDatos.Rows.Count - 1 To 0 Step -1
            If Not dgvDatos.Item(c, f).Value Is Nothing Then
                'leemos fila por fila
                If dgvDatos.Item(c, f).Value.ToString.ToLower.Equals(dato.ToLower) = False Then
                    dgvDatos.Rows.RemoveAt(f) 'si un dato no coincide con la busqueda lo remueve
                End If
            End If
        Next


        If dgvDatos.Rows.Count = 0 Then 'si la busqueda no arrojo resultados
            dgvDatos.AllowUserToAddRows = True 'el usuario puede añadir datos
            btnEscribir.Visible = True 'aparece el boton de guardar
            lblIndicaciones.Visible = True 'aparece un pequeño mensaje 
        Else
            btnRefresca.Enabled = True
        End If

    End Sub

    Private Sub CargarDatos()
        dgvDatos.AllowUserToAddRows = False 'no permitimos agregar campos al menos que no se encuentren
        dgvDatos.Rows.Clear()
        dgvDatos.Columns.Clear()
        Dim lector As New StreamReader(ofdLectura.FileName) 'nos permite leer el archivo
        Dim filatitulos As Integer = 0 'nos asegura que los nombres de las col. solo se asignen una vez
        Dim fila As Integer = 0 'nos dara el numero de filas
        Dim linea As String

        Do
            linea = lector.ReadLine()
            If Not linea Is Nothing Then

                If filatitulos = 0 Then
                    dgvDatos.ColumnCount = linea.Split(",").Length 'nuestro delimitador es una coma, nos dara el no. de col.
                    For x = 0 To dgvDatos.ColumnCount - 1
                        dgvDatos.Columns(x).HeaderText = linea.Split(",")(x) 'obtenemos el titulo de cada columna
                        cboColumna.Items.Insert(x, dgvDatos.Columns(x).HeaderText) 'estas columnas tambien se insertan en un combobox
                    Next
                    filatitulos += 1 'sumamos para que ya no entre a este if
                Else
                    dgvDatos.ColumnCount = linea.Split(",").Length
                    dgvDatos.Rows.Add()
                    For x = 0 To dgvDatos.ColumnCount - 1 'insertamos los datos
                        dgvDatos.Item(x, fila).Value = linea.Split(",")(x)
                    Next
                    fila += 1 'necesitamos el numero de fila para insertar datos
                End If

            End If
        Loop Until linea Is Nothing
        lector.Close() 'cerramos el stream reader

        cboColumna.SelectedIndex = 0 'esto es para no tener un espacio en blanco en el combobox

    End Sub

    Private Sub btnRefresca_Click(sender As Object, e As EventArgs) Handles btnRefresca.Click
        CargarDatos()
        lblIndicaciones.Visible = False
        btnEscribir.Visible = False
    End Sub
End Class
