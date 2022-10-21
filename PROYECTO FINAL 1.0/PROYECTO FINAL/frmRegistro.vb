Public Class frmRegistro

    Dim ruta

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtNombre.Text <> "" Then

            ruta = My.Computer.FileSystem.SpecialDirectories.Desktop & "\registro_datos.txt"

        End If

        If txtNombre.Text = "" And txtApellido.Text = "" And txtDni.Text = "" And txtLocalidad.Text = "" And txtDireccion.Text = "" And txtCelular.Text = "" And txtMonto.Text = "" Then

            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtNombre.Focus()

        ElseIf txtNombre.Text = "" Then
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtNombre.Focus()

        ElseIf Me.txtApellido.Text = "" Then
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtApellido.Focus()

        ElseIf txtDni.Text = "" Then
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtDni.Focus()

        ElseIf txtLocalidad.Text = "" Then
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtLocalidad.Focus()

        ElseIf Me.txtDireccion.Text = "" Then
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtDireccion.Focus()

        ElseIf Me.txtCelular.Text = "" Then
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtCelular.Focus()

        ElseIf Me.txtMonto.Text = "" Then
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtMonto.Focus()

        Else
            My.Computer.FileSystem.WriteAllText(ruta, vbCrLf & "Fecha: " & lbFecha.Text & vbCrLf & "Hora: " & lbHora.Text & vbCrLf & "Nombre: " & txtNombre.Text & vbCrLf & "Apellido: " & txtApellido.Text & vbCrLf & "DNI: " & txtDni.Text & vbCrLf & "Localidad: " & txtLocalidad.Text & vbCrLf & "Direccion: " & txtDireccion.Text & vbCrLf & "Celular: " & txtCelular.Text & vbCrLf & "Monto: " & txtMonto.Text & vbCrLf, True)

            MsgBox("INFORMACION GUARDADA")

            Me.txtNombre.Text = ""
            Me.txtApellido.Text = ""
            Me.txtDni.Text = ""
            Me.txtLocalidad.Text = ""
            Me.txtDireccion.Text = ""
            Me.txtCelular.Text = ""
            Me.txtMonto.Text = ""


            Close()



        End If


    End Sub

    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick

        'Monstrar hora y fecha de la compu en el sistema
        lbHora.Text = DateAndTime.Now.ToLongTimeString

        lbFecha.Text = DateAndTime.Now.ToShortDateString

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class