Public Class FmVenta
    Private Sub CmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProducto.SelectedIndexChanged
        Focus()

        'Cargar los articulos en el combobox

        Dim cod As Integer 'variable codigo 
        Dim nom As String 'variable nombre 
        Dim precio As Double 'variable precio

        'asignacion de los variables al combobox 
        cod = CmbProducto.SelectedIndex
        nom = CmbProducto.SelectedIndex
        precio = CmbProducto.SelectedIndex


        'Asignar cada producto a su codigo unico, su precio, y su nombre 
        Select Case cod

            Case 0
                TxtCodigo.Text = "0011"
            Case 1
                TxtCodigo.Text = "0022"
            Case 2
                TxtCodigo.Text = "0033"
            Case Else
                TxtCodigo.Text = "0044"

        End Select

        Select Case nom
            Case 0
                TxtNombre.Text = "ACEITE DE GIRASOL 500ML"
            Case 1
                TxtNombre.Text = " ARROZ LUCCHETTI 500G"
            Case 2
                TxtNombre.Text = "PURE DE TOMATE ARCOR 500ML"
            Case Else
                TxtNombre.Text = "COCA COLA 1.5L"

        End Select

        Select Case precio
            Case 0
                TxtPrecio.Text = "600"
            Case 1
                TxtPrecio.Text = "140"
            Case 2
                TxtPrecio.Text = "190"
            Case 3
                TxtPrecio.Text = "370"
        End Select


    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click




        'iniciar cada textbox con valor 0
        TxtSubtotal.Text = 0
        TxtIva.Text = 0
        TxtTotal.Text = 0


        'iniciar los textbox con valor 0
        TxtEfectivo.Text = 0
        TxtDvolucion.Text = 0


        Dim cant As Integer ' declaracion de variable cantidad 

        cant = Me.TxtCantidad.Text 'Guardar el valor ingresado el txt text en el variable cant 

        If Me.TxtCantidad.Text = 0 Then 'Condicion si el valor de cantidad es igual a 0
            MsgBox("Ingrese una cantidad valida")

        ElseIf CmbProducto.Text = "" Then 'Condicion si no hay ningun producto selecionado

            MsgBox("Seleccione un articulo")


        Else ' si ninguno de las condiciones anteriores se cumplen entonces se agrega los productos en la datagridview  


            Dgvlista.Rows.Add(TxtCodigo.Text, CmbProducto.Text, TxtPrecio.Text, TxtCantidad.Text, (TxtPrecio.Text * TxtCantidad.Text)) 'Agregar producto con su codigo unico, descripcion, precio, cantidad en el datagridview 


        End If


        'limpar cada uno de los txt despues de presionar boton agregar 
        TxtCodigo.Text = ""
        CmbProducto.Text = ""
        TxtNombre.Text = ""
        TxtPrecio.Text = ""
        TxtCantidad.Text = "1"

        Me.CmbProducto.Focus() ' poner el focus en el combobox producto 




    End Sub

    Private Sub BtnTotales_Click(sender As Object, e As EventArgs) Handles BtnTotales.Click

        'Bucle para hacer la suma

        Dim total As Double = 0 'decclaracion de la variable total

        For i = 0 To Dgvlista.Rows.Count - 1 Step 1 'de uno a uno 

            total += Dgvlista.Rows.Item(i).Cells.Item(4).Value 'Sumar valor del campo precio anterior mas el siguiente 

        Next
        'Calculo de  iva
        Dim iva As Double = total * 0.21

        'Calculo de la subtotal
        Dim subtotal As Double = total - iva

        'Monstrar cada resultado en su corespondiente textbox 
        TxtSubtotal.Text = subtotal.ToString
        TxtIva.Text = iva.ToString
        TxtTotal.Text = total.ToString
    End Sub

    Private Sub BtnVender_Click(sender As Object, e As EventArgs) Handles BtnVender.Click



        'Condicion en caso el textbox efectivo esta vacio o igual a 0 el textbox efectivo toma el valor del textbox total, es decir paga justo el cliente 


        If TxtEfectivo.Text = 0 Or TxtEfectivo.Text = "" Then

            TxtEfectivo.Text = TxtTotal.Text



        Else 'en cualquier otro caso el textbox efectivo es igual 0

            Me.TxtEfectivo.Text = 0


        End If

        Dim total As Double = Me.TxtTotal.Text

        Dim efectivo As Double = Me.TxtEfectivo.Text


        If total > efectivo Then ' en caso que el monto de efectivo ingresado es inferior al total, es decir la venta ya esta realizada, se limpia cada textbox 



            'asignar a cada textbox su valor iniciar 
            Me.TxtSubtotal.Text = 0
            Me.TxtIva.Text = 0
            Me.TxtTotal.Text = 0
            Me.TxtEfectivo.Text = 0
            Me.TxtDvolucion.Text = 0


        ElseIf Me.TxtEfectivo.Text <> 0 Then

            'Calculo de la devolucion
            TxtDvolucion.Text = TxtEfectivo.Text - TxtTotal.Text

            'Limpiar datagridview
            Dgvlista.Rows.Clear()

        End If

        If Val(Me.TxtIva.Text) >= 210 Then ' condicion para abrir el formulario registro al superar 1000 pesos la venta 
            frmRegistro.ShowDialog()

            'se limpia los textbox
            Me.TxtIva.Text = ""
            Me.TxtSubtotal.Text = ""


        End If



    End Sub

    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick

        'Monstrar hora y fecha de la compu en el sistema
        LbHora.Text = DateAndTime.Now.ToLongTimeString

        LbFecha.Text = DateAndTime.Now.ToShortDateString

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        'funcion para eliminar cada fila de datagridview seleccionada 
        For Each r As DataGridViewRow In Dgvlista.SelectedRows
            Dgvlista.Rows.Remove(r)

        Next






    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        ' boton para cerrar el sistema 
        End

    End Sub


End Class
