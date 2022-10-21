Public Class FmLogin
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        'Cerrar la app al hacer click en la tecla cancelar
        Close()


        End

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        If TxtUsuario.Text = "admin" And TxtContraseña.Text = "1234" Then ' validacion de la contraseña correcta
            FmVenta.Show() ' monstrar por pantalla el formulario de venta 
            Close() ' cerrar el formulario de login 

        ElseIf TxtUsuario.Text = "admin" And TxtContraseña.Text <> "1234" Then ' si la contraseña son incerrecta

            MsgBox("La contraseña ingresada es incorrecta")

            TxtContraseña.Text = ""
            Me.TxtContraseña.Focus()

        ElseIf TxtUsuario.Text <> "admin" And TxtContraseña.Text = "1234" Then ' si el usuario es incorrecto

            MsgBox("El usuario ingesado es incorrecto")

            TxtUsuario.Text = ""
            Me.TxtUsuario.Focus()

        ElseIf TxtUsuario.Text <> "admin" And TxtContraseña.Text <> "1234" Then ' si la contraseña y el usurio ingresados son incorrectos 

            MsgBox("El usuario y la contraseña ingresados son incorrectos")

            TxtContraseña.Text = ""
            TxtUsuario.Text = ""
            Me.TxtUsuario.Focus()

        Else
            MsgBox("Ingrese el usuario y/o la contraseña") ' en cualquier otro caso, si no se cumple ninguna de las condiciones previas 
            Me.TxtUsuario.Text = ""
            Me.TxtContraseña.Text = ""
            Me.TxtUsuario.Focus()


        End If
    End Sub


    Private Sub FmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtUsuario.Focus() ' tener el focus en el textbox de usuario al ingresar en el formulario login

    End Sub
End Class