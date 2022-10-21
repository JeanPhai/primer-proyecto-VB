<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.CmbProducto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dgvlista = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtDvolucion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnVender = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtIva = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnTotales = New System.Windows.Forms.Button()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.HoraFecha = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Controls.Add(Me.TxtPrecio)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Controls.Add(Me.CmbProducto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.ForestGreen
        Me.GroupBox1.Location = New System.Drawing.Point(22, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Productos "
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.IndianRed
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(477, 60)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(262, 30)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Location = New System.Drawing.Point(73, 60)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(262, 30)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "AGREGAR"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(679, 32)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 1
        Me.TxtCantidad.Text = "1"
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(573, 32)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.ReadOnly = True
        Me.TxtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrecio.TabIndex = 8
        Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(358, 32)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(209, 20)
        Me.TxtNombre.TabIndex = 7
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(252, 32)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.TabIndex = 6
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbProducto
        '
        Me.CmbProducto.FormattingEnabled = True
        Me.CmbProducto.Items.AddRange(New Object() {"ACEITE DE GIRASOL 990ML", "ARROZ LUCCHETTI 500G", "PURE DE TOMATE ARCOR 500ML", "COCA COLA 1.5L"})
        Me.CmbProducto.Location = New System.Drawing.Point(6, 32)
        Me.CmbProducto.Name = "CmbProducto"
        Me.CmbProducto.Size = New System.Drawing.Size(240, 21)
        Me.CmbProducto.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.ForestGreen
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(700, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CANTIDAD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.ForestGreen
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(602, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PRECIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.ForestGreen
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(429, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.ForestGreen
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(280, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CODIGO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.ForestGreen
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(84, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCTOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Dgvlista)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.ForestGreen
        Me.GroupBox2.Location = New System.Drawing.Point(22, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(811, 417)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos Agregados"
        '
        'Dgvlista
        '
        Me.Dgvlista.AllowUserToAddRows = False
        Me.Dgvlista.AllowUserToDeleteRows = False
        Me.Dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgvlista.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.Dgvlista.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Dgvlista.Location = New System.Drawing.Point(6, 19)
        Me.Dgvlista.Name = "Dgvlista"
        Me.Dgvlista.ReadOnly = True
        Me.Dgvlista.Size = New System.Drawing.Size(799, 392)
        Me.Dgvlista.TabIndex = 0
        '
        'Column1
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.FillWeight = 50.0!
        Me.Column1.HeaderText = "CODIGO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.FillWeight = 120.0!
        Me.Column2.HeaderText = "PRODUCTO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.FillWeight = 30.0!
        Me.Column3.HeaderText = "PRECIO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.FillWeight = 30.0!
        Me.Column4.HeaderText = "CANTIDAD"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column5.FillWeight = 30.0!
        Me.Column5.HeaderText = "TOTAL"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Controls.Add(Me.TxtDvolucion)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtEfectivo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.BtnVender)
        Me.GroupBox3.Controls.Add(Me.TxtTotal)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtIva)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.BtnTotales)
        Me.GroupBox3.Controls.Add(Me.TxtSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.ForestGreen
        Me.GroupBox3.Location = New System.Drawing.Point(839, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(254, 434)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales "
        '
        'TxtDvolucion
        '
        Me.TxtDvolucion.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDvolucion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDvolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDvolucion.ForeColor = System.Drawing.Color.ForestGreen
        Me.TxtDvolucion.Location = New System.Drawing.Point(99, 373)
        Me.TxtDvolucion.Name = "TxtDvolucion"
        Me.TxtDvolucion.ReadOnly = True
        Me.TxtDvolucion.Size = New System.Drawing.Size(149, 40)
        Me.TxtDvolucion.TabIndex = 11
        Me.TxtDvolucion.Text = "0"
        Me.TxtDvolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label10.Location = New System.Drawing.Point(6, 390)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "DEVOLUCION"
        '
        'TxtEfectivo
        '
        Me.TxtEfectivo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEfectivo.ForeColor = System.Drawing.Color.ForestGreen
        Me.TxtEfectivo.Location = New System.Drawing.Point(88, 254)
        Me.TxtEfectivo.Name = "TxtEfectivo"
        Me.TxtEfectivo.Size = New System.Drawing.Size(160, 40)
        Me.TxtEfectivo.TabIndex = 9
        Me.TxtEfectivo.Text = "0"
        Me.TxtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label9.Location = New System.Drawing.Point(6, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "EFECTIVO:"
        '
        'BtnVender
        '
        Me.BtnVender.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnVender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVender.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.BtnVender.FlatAppearance.BorderSize = 0
        Me.BtnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVender.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVender.ForeColor = System.Drawing.Color.White
        Me.BtnVender.Location = New System.Drawing.Point(6, 307)
        Me.BtnVender.Name = "BtnVender"
        Me.BtnVender.Size = New System.Drawing.Size(242, 55)
        Me.BtnVender.TabIndex = 7
        Me.BtnVender.Text = "COBRAR"
        Me.BtnVender.UseVisualStyleBackColor = False
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.Color.ForestGreen
        Me.TxtTotal.Location = New System.Drawing.Point(88, 126)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(160, 40)
        Me.TxtTotal.TabIndex = 6
        Me.TxtTotal.Text = "0"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label8.Location = New System.Drawing.Point(6, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "TOTAL "
        '
        'TxtIva
        '
        Me.TxtIva.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtIva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIva.ForeColor = System.Drawing.Color.Transparent
        Me.TxtIva.Location = New System.Drawing.Point(88, 72)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.ReadOnly = True
        Me.TxtIva.Size = New System.Drawing.Size(160, 29)
        Me.TxtIva.TabIndex = 4
        Me.TxtIva.Text = "0"
        Me.TxtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(6, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "IVA 21%"
        '
        'BtnTotales
        '
        Me.BtnTotales.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnTotales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTotales.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.BtnTotales.FlatAppearance.BorderSize = 0
        Me.BtnTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTotales.ForeColor = System.Drawing.Color.White
        Me.BtnTotales.Location = New System.Drawing.Point(6, 179)
        Me.BtnTotales.Name = "BtnTotales"
        Me.BtnTotales.Size = New System.Drawing.Size(242, 52)
        Me.BtnTotales.TabIndex = 2
        Me.BtnTotales.Text = "VER TOTALES"
        Me.BtnTotales.UseVisualStyleBackColor = False
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubtotal.ForeColor = System.Drawing.Color.ForestGreen
        Me.TxtSubtotal.Location = New System.Drawing.Point(88, 19)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.ReadOnly = True
        Me.TxtSubtotal.Size = New System.Drawing.Size(160, 34)
        Me.TxtSubtotal.TabIndex = 1
        Me.TxtSubtotal.Text = "0"
        Me.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label6.Location = New System.Drawing.Point(6, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "SUB TOTAL"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.IndianRed
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSalir.Location = New System.Drawing.Point(839, 473)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(254, 79)
        Me.BtnSalir.TabIndex = 12
        Me.BtnSalir.Text = "SALIR"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'LbHora
        '
        Me.LbHora.AutoSize = True
        Me.LbHora.BackColor = System.Drawing.Color.ForestGreen
        Me.LbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHora.ForeColor = System.Drawing.Color.Transparent
        Me.LbHora.Location = New System.Drawing.Point(1040, 9)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.Size = New System.Drawing.Size(38, 13)
        Me.LbHora.TabIndex = 3
        Me.LbHora.Text = "Hora "
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.BackColor = System.Drawing.Color.ForestGreen
        Me.LbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.ForeColor = System.Drawing.Color.Transparent
        Me.LbFecha.Location = New System.Drawing.Point(959, 9)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(35, 13)
        Me.LbFecha.TabIndex = 4
        Me.LbFecha.Text = "Feha"
        '
        'HoraFecha
        '
        Me.HoraFecha.Enabled = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.ForestGreen
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(416, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(201, 25)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "PUNTO DE VENTA"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1120, 576)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PUNTO DE VENTA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents CmbProducto As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtEfectivo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnVender As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtIva As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnTotales As Button
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtDvolucion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LbHora As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents HoraFecha As Timer
    Friend WithEvents Dgvlista As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
