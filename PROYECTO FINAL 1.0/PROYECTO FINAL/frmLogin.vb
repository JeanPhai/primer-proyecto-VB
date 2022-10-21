Public Class FmLogin
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click


        Close()


        End

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        If TxtUsuario.Text = "admin" And TxtContraseña.Text = "1234" Then
            FmVenta.Show()
            Close()

        ElseIf TxtUsuario.Text = "admin" And TxtContraseña.Text <> "1234" Then

            MsgBox("La contraseña ingresada es incorrecta")

            TxtContraseña.Text = ""
            Me.TxtContraseña.Focus()

        ElseIf TxtUsuario.Text <> "admin" And TxtContraseña.Text = "1234" Then

            MsgBox("El usuario ingesado es incorrecto")

            TxtUsuario.Text = ""
            Me.TxtUsuario.Focus()

        ElseIf Txtusuario.Text <> "admin" And TxtContraseña.Text <> "1234" Then

            MsgBox("El usuario y la contraseña ingresada son incorrectos")

            TxtContraseña.Text = ""
            TxtUsuario.Text = ""
            Me.TxtUsuario.Focus()

        Else
            MsgBox("Ingrese el usuario y/o la contraseña")
            Me.TxtUsuario.Text = ""
            Me.TxtContraseña.Text = ""
            Me.TxtUsuario.Focus()


        End If
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged

    End Sub

    Private Sub FmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtUsuario.Focus()

    End Sub
End Class