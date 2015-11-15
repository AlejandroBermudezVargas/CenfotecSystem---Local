Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports PresentasionWindowsForms.My.Resources

Public Class FrmMain

    Private user As UserModel

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Login</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Login</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Sub New(ByRef puser As UserModel)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        user = puser
        Me.Text = user.nombre + " " + user.apellido
        'Me.tActis.Visible = False
        'Me.tCareers.Visible = False
        Me.Main.TabPages.Remove(Me.TabProductos)
        Me.Main.TabPages.Remove(Me.TabProspectos)
        Me.Main.TabPages.Remove(Me.TabVentas)
        Me.Main.TabPages.Remove(Me.Eventos)
        Me.Main.TabPages.Remove(Me.KPIHolder)
        Me.Main.TabPages.Remove(Me.TabUsuarios)
        Me.Main.TabPages.Remove(Me.TabReportes)
        Me.Main.TabPages.Remove(Me.TabConfiguracion)
    End Sub

    Dim idEventoModificar As Integer

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboUsuario.Text = "Usuario"
        Me.llenarEventos()
        Me.llenarListaProspectos()
        TabProductos.Focus()
    End Sub

    Private Sub btnCrearEvento_Click(sender As Object, e As EventArgs) Handles btnCrearEvento.Click
        PanelListarEventos.Visible = False
        PanelListarEventos.Enabled = False
        PanelCrearEvento.Enabled = True
        PanelCrearEvento.Visible = True
    End Sub

    Private Sub btnCancelarEvento_Click(sender As Object, e As EventArgs) Handles btnCancelarEvento.Click
        PanelListarEventos.Visible = True
        PanelListarEventos.Enabled = True
        PanelCrearEvento.Enabled = False
        PanelCrearEvento.Visible = False
    End Sub

    Private Sub btnGuardarEvento_Click(sender As Object, e As EventArgs) Handles btnGuardarEvento.Click
        Dim objecto = EventosController.CrearEvento(idEventoModificar, TxtnombreEventos.Text, dateEventos.Text, dateFin.Text)
        If (objecto.Equals(True)) Then
            MsgBox("El Evento se creo con exito", MsgBoxStyle.Information, "Evento Guardado")
            Me.llenarEventos()
        Else
            MsgBox("El Evento se creo con exito", MsgBoxStyle.Critical, "Error")
        End If
        idEventoModificar = Nothing
    End Sub

    Private Sub llenarEventos()
        Dim eventos = EventosController.ListarEventos()
        If (Not eventos.Equals(Nothing)) Then
            For Each eve As Evento In eventos
                DataListarEventos.Rows.Add(eve.Lugar, eve.FechaInicio, eve.FechaFin, eve.IdEvento)
            Next
        End If
    End Sub


    Private Sub DataListarEventos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataListarEventos.CellContentClick
        Dim id As String = DataListarEventos.Rows(e.RowIndex).Cells(3).Value
        Select Case e.ColumnIndex
            Case 4
                Dim evento As Evento = EventosController.getEvento(id)
                idEventoModificar = evento.IdEvento
                TxtnombreEventos.Text = evento.Lugar
                dateEventos.Text = evento.FechaInicio
                dateFin.Text = evento.FechaFin
                PanelListarEventos.Visible = False
                PanelCrearEvento.Visible = True
            Case 5
                Dim result = EventosController.eliminar(id)
                If (result.Equals(True)) Then
                    DataListarEventos.Rows.Remove(DataListarEventos.Rows(e.RowIndex))
                    MsgBox("El evento se elimino con exito", 0, "Exito")
                Else
                    MsgBox("No se pudo eliminar el evento", 0, "Error")
                End If
            Case Else
                Exit Sub
        End Select
    End Sub

    Private Sub TileKpiVentas_Click(sender As Object, e As EventArgs) Handles TileKpiVentas.Click
        panSeleccionarTipoKPI.Visible = False
        panKpiVentas.Visible = True
        pnlKpiProspectos.Visible = False
        pnlCrearKpiProducto.Visible = False
    End Sub

    Private Sub TileKpiProspecto_Click(sender As Object, e As EventArgs) Handles TileKpiProspecto.Click
        panSeleccionarTipoKPI.Visible = False
        pnlKpiProspectos.Visible = True
        panKpiVentas.Visible = False
        pnlCrearKpiProducto.Visible = False
    End Sub

    Private Sub TileKpiProductos_Click(sender As Object, e As EventArgs) Handles TileKpiProductos.Click
        panSeleccionarTipoKPI.Visible = False
        pnlCrearKpiProducto.Visible = True
        pnlKpiProspectos.Visible = False
        panKpiVentas.Visible = False
    End Sub

    Private Sub btnCrearKpiProducto_Click(sender As Object, e As EventArgs) Handles btnCrearKpiProducto.Click
        Dim resultado As String = ""
        If (checkBoxTotalProducto.Checked) Then
            resultado = ProductsController.totalProductos()
        ElseIf (checkBoxTotalProducto.Checked = False) Then
            MsgBox("Por Favor Seleccione una opcion")
            resultado = "No se selecciono una opcion"
        End If
        TextBoxResultadoKpiProductos.AppendText(resultado)
        TextBoxResultadoKpiProductos.AppendText(Environment.NewLine)
    End Sub

    Private Sub btnCrearKpiVenta_Click(sender As Object, e As EventArgs) Handles btnCrearKpiVenta.Click
        Dim resultado As String = ""
        If (checkBoxMontoTotalVentas.Checked) Then
            resultado = SalesController.obtenerKpiTotalVentas()
        ElseIf (checkBoxTotalVentas.Checked) Then
            resultado = SalesController.obtenerTotalMontoVentas()
        End If
        If (checkBoxTotalVentas.Checked = False And checkBoxMontoTotalVentas.Checked = False) Then
            MsgBox("Por Favor Seleccione una opcion")
            resultado = "No se selecciono una opcion"
        End If

        TextBoxResultadosVentas.AppendText(resultado)
        TextBoxResultadosVentas.AppendText(Environment.NewLine)
    End Sub

    Private Sub btnCancelarKpiVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarKpiVenta.Click
        panKpiVentas.Visible = False
        panSeleccionarTipoKPI.Visible = True
    End Sub

    Private Sub BtnGenerarKpiProspecto_Click(sender As Object, e As EventArgs) Handles BtnGenerarKpiProspecto.Click
        Dim resultado As String = ""
        If (checkBoxTotalProspectos.Checked) Then
            resultado = ProspectusController.getTotalProspectos()
        ElseIf (checkboxTotalProspetosCliente.Checked) Then
            resultado = ProspectusController.getTotalProspectosClientes()
        End If
        If (checkboxTotalProspetosCliente.Checked = False And checkBoxTotalProspectos.Checked = False) Then
            MsgBox("Por Favor Seleccione una opcion")
            resultado = "No se selecciono una opcion"
        End If
        TextBoxResultadosKpiProspectos.AppendText(resultado)
        TextBoxResultadosKpiProspectos.AppendText(Environment.NewLine)
    End Sub

    Private Sub btnCancelarKpiProspecto_Click(sender As Object, e As EventArgs) Handles btnCancelarKpiProspecto.Click
        pnlKpiProspectos.Visible = False
        panSeleccionarTipoKPI.Visible = True
    End Sub

    Private Sub btnCancelarKpiProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarKpiProducto.Click
        pnlCrearKpiProducto.Visible = False
        panSeleccionarTipoKPI.Visible = True
    End Sub

    '//////////////////////////////////////// PROSPECTOS ////////////////////////////////////////

    Private Sub llenarListaProspectos()
        Dim prospectos = ProspectusController.listar()
        If (Not prospectos.Equals(Nothing)) Then
            For Each prosp As Prospecto In prospectos
                lstProspectos.Rows.Add(prosp.Id_prospecto, prosp.Nombre, prosp.Apellidos, Format(prosp.Fecha_nacimiento, "dd-MM-yyyy"),
                                       prosp.Procedencia, prosp.Telefono, prosp.Email)
            Next
        End If
    End Sub

    Private Sub btnCrearProspecto_Click(sender As Object, e As EventArgs) Handles btnCrearProspecto.Click
        btnNuevoSeguimiento.Visible = False
        btnListarSeguimientos.Visible = False
        PnlListaProspectos.Visible = False
        PnlNuevoProspecto.Visible = True
    End Sub

    Private Sub btnCancelarProspecto_Click(sender As Object, e As EventArgs) Handles btnCancelarProspecto.Click
        Me.limpiarFormProspectos()
        PnlListaProspectos.Visible = True
        PnlNuevoProspecto.Visible = False
    End Sub

    Private Sub limpiarFormProspectos()
        lblIdProspecto.Text = -1
        txtNombreProspecto.Clear()
        txtApellidosProspecto.Clear()
        txtFechaNacProspecto.Value = Date.Now
        txtProcedenciaProspecto.Clear()
        txtProcedenciaProspecto.Enabled = True
        tglEstadoProspecto.Checked = True
        txtTelProspecto.Clear()
        txtEmailProspecto.Clear()
        txtDireccionProspecto.Clear()
        tglEstaInteresado.Checked = False
        tglEsCliente.Checked = False
        ckbEventoProspecto.Checked = False
    End Sub

    Private Sub btnGuardarProspecto_Click(sender As Object, e As EventArgs) Handles btnGuardarProspecto.Click
        Dim listaIntereses As New List(Of Tipo_Producto)
        If (tglEstaInteresado.Checked = True) Then
            Dim interes As New Tipo_Producto
            Dim idInteres = (DirectCast(cbInteresesProspecto.SelectedItem, KeyValuePair(Of String, String)).Key)
            Dim nombreInteres = (DirectCast(cbInteresesProspecto.SelectedItem, KeyValuePair(Of String, String)).Value)
            interes.Id_Tipo_Producto = idInteres
            interes.Nombre = nombreInteres
            listaIntereses.Add(interes)
        End If
        If validateProspectusForm() Then
            Dim resul = ProspectusController.guardarOActualizar(CInt(lblIdProspecto.Text), txtNombreProspecto.Text, txtApellidosProspecto.Text, txtFechaNacProspecto.Value,
                                         txtProcedenciaProspecto.Text, tglEstadoProspecto.Checked, txtTelProspecto.Text,
                                         txtEmailProspecto.Text, txtDireccionProspecto.Text, tglEstaInteresado.Checked,
                                         tglEsCliente.Checked, listaIntereses)
            If (resul.Equals(True)) Then
                MsgBox(respuestasDelSistema.CREATE_USER_SUCCESS, MsgBoxStyle.Information)
            Else
                MsgBox(respuestasDelSistema.CREATE_USER_ERROR, MsgBoxStyle.Critical)
            End If
            lstProspectos.Rows.Clear()
            Me.llenarListaProspectos()
            Me.limpiarFormProspectos()
            PnlListaProspectos.Visible = True
            PnlNuevoProspecto.Visible = False
            lblIdProspecto.Text = -1
        End If
    End Sub

    Public Function validateProspectusForm() As Boolean
        Dim result As Boolean = True
        If Not IsEmail(txtEmailProspecto.Text) Then
            result = False
            ErrorProvider1.SetError(txtEmailProspecto, ValidationsMessages.INVALID_EMAIL)
        End If
        If Not isAPhoneNumber(txtTelProspecto.Text) Then
            result = False
            ErrorProvider1.SetError(txtTelProspecto, ValidationsMessages.INVALID_PHONE_NUMBER)
        End If
        If String.IsNullOrEmpty(txtNombreProspecto.Text) Then
            result = False
            ErrorProvider1.SetError(txtNombreProspecto, ValidationsMessages.EMPTY_FIELD)
        End If
        If String.IsNullOrEmpty(txtApellidosProspecto.Text) Then
            result = False
            ErrorProvider1.SetError(txtApellidosProspecto, ValidationsMessages.EMPTY_FIELD)
        End If
        Return result
    End Function

    'VALIDACIONES
    Function IsEmail(ByVal text As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailExpression.IsMatch(text)
    End Function

    Function IsGoodPassword(ByVal text As String) As Boolean
        '- 8 caracteres
        '- no mas de 15 caracteres
        '- Letra mayuscula, minuscula y un numero
        Static regularExpression As New Regex("^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,15}$")
        Return regularExpression.IsMatch(text)
    End Function

    Function isAUserId(ByVal text As String) As Boolean 'Minimo 9
        Static regularExpression As New Regex("^[0-9]{9,15}$")
        Return regularExpression.IsMatch(text)
    End Function

    Function isAPhoneNumber(ByVal text As String) As Boolean 'Minimo 8
        Static regularExpression As New Regex("^[0-9]{8,15}$")
        Return regularExpression.IsMatch(text)
    End Function

    Function OnlyTextAllowSpaces(ByVal text As String) As Boolean
        Static regularExpression As New Regex("^[a-zA-Z ]*$")
        Return regularExpression.IsMatch(text)
    End Function

    Private Sub TabProductos_Click(sender As Object, e As EventArgs) Handles TabProductos.Click

    End Sub

    Private Sub tListaVentas_Click(sender As Object, e As EventArgs) Handles tListaVentas.Click
        listarVerntas_pnl.Visible = True
    End Sub

    Private Sub tRegistrar_Click(sender As Object, e As EventArgs) Handles tRegistrar.Click
        llenarComboProductos()
        llenarComboCodigos()
        llenarComboTipoVenta()
        RegistrarVentas_pnl.Visible = True
    End Sub

    Private Sub tConsultarVenta_Click(sender As Object, e As EventArgs) Handles tConsultarVenta.Click
        consultarVentas_pnl.Visible = True
    End Sub

    Private Sub volverConsulta_Click(sender As Object, e As EventArgs) Handles volverConsulta.Click
        consultarVentas_pnl.Visible = False
    End Sub

    Private Sub cancelarVenta_btn_Click(sender As Object, e As EventArgs) Handles cancelarVenta_btn.Click
        RegistrarVentas_pnl.Visible = False
    End Sub

    Private Sub guardarVenta_btn_Click(sender As Object, e As EventArgs) Handles guardarVenta_btn.Click
        Dim totalPagar As Double
        Dim fecha As Date
        Dim id_usuario As Integer
        Dim tipo As String

        id_usuario = user.id_usuario
        tipo = tipo_prodVenta_cmb.Text
        fecha = Today
        totalPagar = calcularTotal()
        Dim isCorrect = SalesController.RegistrarVenta(fecha, totalPagar, id_usuario, tipo)
        If isCorrect Then
            MsgBox("La nueva venta se ha agregado con exito.", MsgBoxStyle.Information)
            LimpiarFormVenta()
            llenarTablaVentas()
            RegistrarVentas_pnl.Visible = False
            listarVerntas_pnl.Visible = True
        Else
            MsgBox("No se ha podido ingresar la nueva venta.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub LimpiarFormVenta()
        productos_cmb.SelectedIndex = 0
        cod_prod_cmb.SelectedIndex = 0
        matricula_text.Text = ""
        costoVenta_text.Text = ""
    End Sub

    Private Sub nuevaVenta_btn_Click(sender As Object, e As EventArgs) Handles nuevaVenta_btn.Click
        llenarComboProductos()
        llenarComboCodigos()
        llenarComboTipoVenta()
        RegistrarVentas_pnl.Visible = True
    End Sub

    Private Sub volverVenta_btn_Click(sender As Object, e As EventArgs) Handles volverVenta_btn.Click
        listarVerntas_pnl.Visible = False
    End Sub
    Private Sub llenarTablaVentas()
        listaVentas_dg.Rows.Clear()
        Dim usuario As UserModel = Nothing

        Dim ventas As List(Of Sale) = SalesController.obtenerListaVentas()
        If (Not ventas Is Nothing) Then
            For Each venta As Sale In ventas
                If user.id_rol = 1 Then
                    usuario = Users_controller.getUser(venta.Id_Usuario)
                    listaVentas_dg.Rows.Add(venta.SaleId, usuario.nombre & " " & usuario.apellido, venta.Monto, venta.Fecha, venta.Tipo)
                Else

                    If venta.Id_Usuario = user.id_usuario Then
                        usuario = Users_controller.getUser(venta.Id_Usuario)
                        listaVentas_dg.Rows.Add(venta.SaleId, usuario.nombre & " " & usuario.apellido, venta.Monto, venta.Fecha, venta.Tipo)
                    End If
                End If
            Next
        End If
    End Sub
    Public Function calcularTotal() As Double
        Dim totalPagar As Double
        Dim matricula As Double

        If matricula_text.Text = "" Then
            matricula = 0.0
        Else
            matricula = Double.Parse(matricula_text.Text)
        End If
        If costoVenta_text.Text <> "" Then
            totalPagar = Double.Parse(costoVenta_text.Text)
        End If
        totalPagar = totalPagar + matricula
        totalVenta_text.Text = totalPagar
        Return totalPagar
    End Function
    Private Sub cod_prod_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cod_prod_cmb.SelectedIndexChanged
        Dim id As Integer
        Dim producto As Producto

        If IsNothing(cod_prod_cmb.SelectedValue) Or (DirectCast(cod_prod_cmb.SelectedItem, KeyValuePair(Of String, String)).Key) = "" Then
            id = 0
        Else
            id = CInt(DirectCast(cod_prod_cmb.SelectedItem, KeyValuePair(Of String, String)).Key)
            producto = ProductsController.obtenerProducto(id)
            costoVenta_text.Text = producto.Costo
            tipo_prodVenta_cmb.SelectedIndex = producto.Id_Tipo_Product
            productos_cmb.SelectedIndex = cod_prod_cmb.SelectedIndex

        End If
    End Sub

    Private Sub productos_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles productos_cmb.SelectedIndexChanged
        Dim id As Integer
        Dim producto As Producto
        If IsNothing(productos_cmb.SelectedValue) Or (DirectCast(productos_cmb.SelectedItem, KeyValuePair(Of String, String)).Key) = "" Then
            id = 0
        Else
            id = CInt(DirectCast(productos_cmb.SelectedItem, KeyValuePair(Of String, String)).Key)
            producto = ProductsController.obtenerProducto(id)
            costoVenta_text.Text = producto.Costo
            tipo_prodVenta_cmb.SelectedIndex = producto.Id_Tipo_Product
            cod_prod_cmb.SelectedIndex = productos_cmb.SelectedIndex

        End If
    End Sub

    Private Sub costo_text_Click(sender As Object, e As EventArgs) Handles costoVenta_text.TextChanged
        calcularTotal()
    End Sub

    Private Sub matricula_text_Click(sender As Object, e As EventArgs) Handles matricula_text.TextChanged
        calcularTotal()
    End Sub

    Private Sub llenarComboProductos()
        Dim productos As List(Of Producto) = ProductsController.obtenerListaProductos
        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("", "Elija uno")
        If Not IsNothing(productos) Then
            For Each prod As Producto In productos
                comboSource.Add(prod.Id_Producto.ToString, prod.Nombre)
            Next
        End If
        productos_cmb.DataSource = New BindingSource(comboSource, Nothing)
        productos_cmb.DisplayMember = "Value"
        productos_cmb.ValueMember = "Key"
    End Sub

    Private Sub llenarComboCodigos()

        Dim productos As List(Of Producto) = ProductsController.obtenerListaProductos
        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("", "Elija uno")
        If Not IsNothing(productos) Then
            For Each prod As Producto In productos
                comboSource.Add(prod.Id_Producto, prod.Codigo_Producto)
            Next
        End If
        cod_prod_cmb.DataSource = New BindingSource(comboSource, Nothing)
        cod_prod_cmb.DisplayMember = "Value"
        cod_prod_cmb.ValueMember = "Key"
    End Sub
    Private Sub llenarComboTipoVenta()

        Dim tipos As List(Of Tipo_Producto) = ProductTypeController.obtenerLista
        Dim comboSource As New Dictionary(Of String, String)()

        comboSource.Add("", "")
        If IsNothing(tipos) Then
            MsgBox("Se ha producido un error y no se pueden cargar los datos de tipo de producto.", MsgBoxStyle.Critical)
        Else
            For Each tipo As Tipo_Producto In tipos
                comboSource.Add(tipo.Id_Tipo_Producto.ToString, tipo.Nombre)
            Next
        End If
        tipo_prodVenta_cmb.DataSource = New BindingSource(comboSource, Nothing)
        tipo_prodVenta_cmb.DisplayMember = "Value"
        tipo_prodVenta_cmb.ValueMember = "Key"
    End Sub
End Class



