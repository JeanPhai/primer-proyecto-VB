Public Class frmRegistro

    Dim ruta 'declaracion de la variable ruta 

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtNombre.Text <> "" Then 'condicion para crear el txt si el textbox nombre no esta vacio 

            ruta = My.Computer.FileSystem.SpecialDirectories.Desktop & "\registro_datos.txt" ' crear y lugar de crear mi txt 

        End If

        ' condicion para que todos los campos sean obligatorio, en caso de que todo estan vacio 
        If txtNombre.Text = "" And txtApellido.Text = "" And txtDni.Text = "" And txtLocalidad.Text = "" And txtDireccion.Text = "" And txtCelular.Text = "" And txtMonto.Text = "" Then

            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtNombre.Focus()

        ElseIf txtNombre.Text = "" Then ' caso de que el textbox nombre esta vacio
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtNombre.Focus()

        ElseIf Me.txtApellido.Text = "" Then 'caso de que el textbox apellido esta vacio
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtApellido.Focus()

        ElseIf txtDni.Text = "" Then 'caso de que el textbox DNI esta vacio
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtDni.Focus()

        ElseIf txtLocalidad.Text = "" Then 'caso de que el textbox localidad esta vacio
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtLocalidad.Focus()

        ElseIf Me.txtDireccion.Text = "" Then 'caso de que el textbox direccion esta vacio
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtDireccion.Focus()

        ElseIf Me.txtCelular.Text = "" Then 'caso de que el textbox celular esta vacio
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtCelular.Focus()

        ElseIf Me.txtMonto.Text = "" Then 'caso de que el textbox monto esta vacio
            MsgBox("TODOS LOS CAMPOS SON OBLIGATORIOS")
            Me.txtMonto.Focus()

        Else

            'caso de tener todo los textboxes completos, se asigna cada textbox con su correspondiente texto y se deja una linea 
            My.Computer.FileSystem.WriteAllText(ruta, vbCrLf & "Fecha: " & lbFecha.Text & vbCrLf & "Hora: " & lbHora.Text & vbCrLf & "Nombre: " & txtNombre.Text & vbCrLf & "Apellido: " & txtApellido.Text & vbCrLf & "DNI: " & txtDni.Text & vbCrLf & "Localidad: " & txtLocalidad.Text & vbCrLf & "Direccion: " & txtDireccion.Text & vbCrLf & "Celular: " & txtCelular.Text & vbCrLf & "Monto: " & txtMonto.Text & vbCrLf, True)

            MsgBox("INFORMACION GUARDADA")

            'se limpia todo los textboxes 
            Me.txtNombre.Text = ""
            Me.txtApellido.Text = ""
            Me.txtDni.Text = ""
            Me.txtLocalidad.Text = ""
            Me.txtDireccion.Text = ""
            Me.txtCelular.Text = ""
            Me.txtMonto.Text = ""


            Close() 'cerrar el formulario registro 



        End If


    End Sub

    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick

        'Monstrar hora y fecha de la compu en el sistema
        lbHora.Text = DateAndTime.Now.ToLongTimeString

        lbFecha.Text = DateAndTime.Now.ToShortDateString

    End Sub


End Class