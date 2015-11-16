Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports PresentasionWindowsForms.My.Resources

Public Class FrmMain
    Shared modProduct As Boolean = False
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
        Me.llenarEventos()
        Me.llenarListaProspectos()
        llenarTablaActis()
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
        If lblIdProspecto.Equals(-1) Then
            lblCrearProspectos.Text = "Editar prospecto"
        Else
            lblCrearProspectos.Text = "Crear prospecto"
        End If
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

    Private Sub lstProspectos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lstProspectos.CellContentClick
        If e.ColumnIndex = 7 Then
            Dim id As String = lstProspectos.Rows(e.RowIndex).Cells(0).Value
            Dim ppros As Prospecto = ProspectusController.getProspecto(id)
            lblIdProspecto.Text = ppros.Id_prospecto
            txtNombreProspecto.Text = ppros.Nombre
            txtApellidosProspecto.Text = ppros.Apellidos
            txtFechaNacProspecto.Text = ppros.Fecha_nacimiento
            txtProcedenciaProspecto.Text = ppros.Procedencia
            tglEstadoProspecto.Checked = ppros.Estado
            txtTelProspecto.Text = ppros.Telefono
            txtEmailProspecto.Text = ppros.Email
            txtDireccionProspecto.Text = ppros.Direccion
            tglEstaInteresado.Checked = ppros.Interesado
            tglEsCliente.Checked = ppros.Cliente
            btnNuevoSeguimiento.Visible = True
            btnListarSeguimientos.Visible = True
            PnlListaProspectos.Visible = False
            PnlNuevoProspecto.Visible = True
        Else
            Exit Sub
        End If
    End Sub

    Public Sub llenarComboIntereses()
        Dim comboData As New Dictionary(Of String, String)()
        comboData.Add(1, "Acti")
        comboData.Add(2, "Carrera")
        cbInteresesProspecto.DataSource = New BindingSource(comboData, Nothing)
        cbInteresesProspecto.DisplayMember = "Value"
        cbInteresesProspecto.ValueMember = "Key"
    End Sub

    Public Sub llenarComboEventos()
        Dim eventos = EventosController.ListarEventos()
        Dim comboData As New Dictionary(Of String, String)()
        If (eventos.Count > 0) Then
            For Each evento As Evento In eventos
                comboData.Add(evento.IdEvento, evento.Lugar)
            Next
            cbEventos.DataSource = New BindingSource(comboData, Nothing)
            cbEventos.DisplayMember = "Value"
            cbEventos.ValueMember = "Key"
        End If
    End Sub

    Private Sub tglEstaInteresado_CheckedChanged(sender As Object, e As EventArgs) Handles tglEstaInteresado.CheckedChanged
        If (tglEstaInteresado.Checked = True) Then
            txtProcedenciaProspecto.Enabled = False
            cbInteresesProspecto.Enabled = True
            llenarComboIntereses()
        Else
            txtProcedenciaProspecto.Enabled = True
            cbInteresesProspecto.Enabled = False
        End If
    End Sub

    Private Sub ckbEventoProspecto_CheckedChanged(sender As Object, e As EventArgs) Handles ckbEventoProspecto.CheckedChanged
        If (ckbEventoProspecto.Checked = True) Then
            txtProcedenciaProspecto.Enabled = False
            cbEventos.Enabled = True
            llenarComboEventos()
        Else
            txtProcedenciaProspecto.Enabled = True
            cbEventos.Enabled = False
        End If
    End Sub

    Private Sub tglEstadoProspecto_CheckedChanged(sender As Object, e As EventArgs) Handles tglEstadoProspecto.CheckedChanged
        If tglEstadoProspecto.Checked = True Then
            habilitarFormProspectos(True)
        Else
            habilitarFormProspectos(False)
        End If
    End Sub

    Private Sub habilitarFormProspectos(ByVal valor As Boolean)
        txtNombreProspecto.Enabled = valor
        txtApellidosProspecto.Enabled = valor
        txtFechaNacProspecto.Enabled = valor
        txtEmailProspecto.Enabled = valor
        txtTelProspecto.Enabled = valor
        txtProcedenciaProspecto.Enabled = valor
        txtDireccionProspecto.Enabled = valor
        tglEstaInteresado.Enabled = valor
        tglEsCliente.Enabled = valor
        ckbEventoProspecto.Enabled = valor
        If tglEstaInteresado.Checked = True Then
            cbInteresesProspecto.Enabled = valor
        End If
        If ckbEventoProspecto.Checked = True Then
            cbEventos.Enabled = valor
        End If
    End Sub

    Private Sub btnAsignarProspecto_Click_1(sender As Object, e As EventArgs) Handles btnAsignarProspecto.Click
        PnlListaProspectos.Visible = False
        pnlAsignarProspecto.Visible = True
        llenarListBoxVendedores()
        llenarListBoxProspectos()
    End Sub

    Dim data1 As New Dictionary(Of Integer, String)()
    Dim data2 As New Dictionary(Of Integer, String)()
    Dim data3 As New Dictionary(Of Integer, String)()

    Public Sub llenarListBoxVendedores()
        If data1.Count.Equals(0) Then
            Dim users = Users_controller.getUsers()
            If users.Count > 0 Then
                For Each user As UserModel In users
                    Dim rol As RolModel = RolsController.getRol(user.id_rol)
                    If rol.nombre.Equals("Telemercadeo") Or rol.nombre.Equals("Ventas") Then
                        data1.Add(user.id_usuario, user.nombre + "" + user.apellido)
                    End If
                Next
                ltbVendedoresSlt.DataSource = New BindingSource(data1, Nothing)
                ltbVendedoresSlt.DisplayMember = "Value"
                ltbVendedoresSlt.ValueMember = "Key"
            End If
        End If
    End Sub

    Public Sub llenarListBoxProspectos()
        If data2.Count.Equals(0) Then
            Dim prospectos = ProspectusController.listar()
            If prospectos.Count > 0 Then
                For Each prosp As Prospecto In prospectos
                    If prosp.Estado.Equals(True) Then
                        data2.Add(prosp.Id_prospecto, prosp.Nombre + " " + prosp.Apellidos)
                    End If
                Next
                ltbProspectosSlt.DataSource = New BindingSource(data2, Nothing)
                ltbProspectosSlt.DisplayMember = "Value"
                ltbProspectosSlt.ValueMember = "Key"
            End If
        End If
    End Sub

    Private Sub btnCancelarAsignarProsp_Click(sender As Object, e As EventArgs) Handles btnCancelarAsignarProsp.Click
        data1.Clear()
        data2.Clear()
        data3.Clear()
        pnlAsignarProspecto.Visible = False
        PnlListaProspectos.Visible = True
    End Sub

    Private Sub btnAsignarListaProsp_Click(sender As Object, e As EventArgs) Handles btnAsignarListaProsp.Click
        If (data2.Count > 0) Then
            Dim llave = DirectCast(ltbProspectosSlt.SelectedItem, KeyValuePair(Of Integer, String)).Key
            Dim valor = DirectCast(ltbProspectosSlt.SelectedItem, KeyValuePair(Of Integer, String)).Value
            data3.Add(llave, valor)
            data2.Remove(DirectCast(ltbProspectosSlt.SelectedItem, KeyValuePair(Of Integer, String)).Key)
            ltbProspectosSlt.DataSource = Nothing
            ltbProspectosSlt.DataSource = New BindingSource(data2, Nothing)
            ltbProspectosSlt.DisplayMember = "Value"
            ltbProspectosSlt.ValueMember = "Key"
            ltbProspAsignados.DataSource = Nothing
            ltbProspAsignados.DataSource = New BindingSource(data3, Nothing)
            ltbProspAsignados.DisplayMember = "Value"
            ltbProspAsignados.ValueMember = "Key"
        End If
    End Sub

    Private Sub btnQuitarProspAsignado_Click(sender As Object, e As EventArgs) Handles btnQuitarProspAsignado.Click
        If data3.Count > 0 Then
            Dim llave = DirectCast(ltbProspAsignados.SelectedItem, KeyValuePair(Of Integer, String)).Key
            Dim valor = DirectCast(ltbProspAsignados.SelectedItem, KeyValuePair(Of Integer, String)).Value
            data2.Add(llave, valor)
            data3.Remove(DirectCast(ltbProspAsignados.SelectedItem, KeyValuePair(Of Integer, String)).Key)
            ltbProspAsignados.DataSource = Nothing
            ltbProspAsignados.DataSource = New BindingSource(data3, Nothing)
            ltbProspAsignados.DisplayMember = "Value"
            ltbProspAsignados.ValueMember = "Key"
            ltbProspectosSlt.DataSource = Nothing
            ltbProspectosSlt.DataSource = New BindingSource(data2, Nothing)
            ltbProspectosSlt.DisplayMember = "Value"
            ltbProspectosSlt.ValueMember = "Key"
        End If
    End Sub



    Private Sub ltbVendedoresSlt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltbVendedoresSlt.SelectedIndexChanged
        data2.Clear()
        data3.Clear()
        ltbProspAsignados.DataSource = Nothing
        llenarListBoxProspectos()
    End Sub
    '
    'SEGUIMIENTOS
    '
    Private Sub lstSeguimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lstSeguimientos.CellContentClick
        Select Case e.ColumnIndex
            Case 3
                Dim id As String = lstSeguimientos.Rows(e.RowIndex).Cells(0).Value
                Dim pseg As Seguimiento = SeguimientoController.getSeguimiento(id)
                lblIdSeguimiento.Text = pseg.Id_seguimiento
                txtFechaSeguimiento.Value = pseg.Fecha
                txtComentarioSeguimiento.Text = pseg.Comentario
                PnlListaSeguimientos.Visible = False
                pnlSeguimientos.Visible = True
            Case 4
                Dim id As String = lstSeguimientos.Rows(e.RowIndex).Cells(0).Value
                Dim resul = SeguimientoController.eliminar(id)
                If (resul.Equals(True)) Then
                    lstSeguimientos.Rows.Remove(lstSeguimientos.Rows(e.RowIndex))
                    MsgBox("El registro se eliminó con éxito", MsgBoxStyle.Information)
                Else
                    MsgBox("Imposible eliminar el registro", MsgBoxStyle.Critical)
                End If
            Case Else
                Exit Sub
        End Select
    End Sub

    Private Sub limpiarFormSeguimiento()
        txtComentarioSeguimiento.Clear()
        txtFechaSeguimiento.Value = Date.Now
    End Sub

    Private Sub btnNuevoSeguimiento_Click(sender As Object, e As EventArgs) Handles btnNuevoSeguimiento.Click
        If lblIdSeguimiento.Equals(-1) Then
            lblCrearSeguimiento.Text = "Editar seguimiento"
        Else
            lblCrearSeguimiento.Text = "Crear seguimiento"
        End If
        PnlNuevoProspecto.Visible = False
        pnlSeguimientos.Visible = True
    End Sub

    Private Sub btnCancelarSeguimiento_Click(sender As Object, e As EventArgs) Handles btnCancelarSeguimiento.Click
        Me.limpiarFormSeguimiento()
        PnlNuevoProspecto.Visible = True
        pnlSeguimientos.Visible = False
    End Sub

    Private Sub btnGuardarSeguimiento_Click(sender As Object, e As EventArgs) Handles btnGuardarSeguimiento.Click
        If String.IsNullOrEmpty(txtComentarioSeguimiento.Text) Then
            ErrorProvider1.SetError(txtComentarioSeguimiento, ValidationsMessages.EMPTY_FIELD)
        Else
            Dim resul = SeguimientoController.guardarOActualizar(CInt(lblIdSeguimiento.Text), CInt(lblIdProspecto.Text), txtFechaSeguimiento.Value, txtComentarioSeguimiento.Text)
            If (resul.Equals(True)) Then
                MsgBox("El registro ha sido creado exitosamente", MsgBoxStyle.Information)
                Me.limpiarFormSeguimiento()
                PnlNuevoProspecto.Visible = True
                pnlSeguimientos.Visible = False
            Else
                MsgBox("Hubo un error al guardar el registro", MsgBoxStyle.Critical)
            End If
            lblIdSeguimiento.Text = -1
        End If
    End Sub

    Private Sub btnListarSeguimientos_Click(sender As Object, e As EventArgs) Handles btnListarSeguimientos.Click
        Me.llenarListaSeguimientos()
        PnlListaSeguimientos.Visible = True
        PnlNuevoProspecto.Visible = False
    End Sub

    Private Sub btnCancelarListaSeguimiento_Click(sender As Object, e As EventArgs) Handles btnCancelarListaSeguimiento.Click
        PnlListaSeguimientos.Visible = False
        PnlNuevoProspecto.Visible = True
    End Sub

    Private Sub llenarListaSeguimientos()
        lstSeguimientos.Rows.Clear()
        Dim seguimientos = SeguimientoController.listar(CInt(lblIdProspecto.Text))
        If (Not seguimientos.Equals(Nothing)) Then
            For Each seg As Seguimiento In seguimientos
                lstSeguimientos.Rows.Add(seg.Id_seguimiento, Format(seg.Fecha, "dd-MM-yyyy"), seg.Comentario)
            Next
        End If
    End Sub

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

    Private Sub btnActiIco_Click(sender As Object, e As EventArgs) Handles btnActiIco.Click
        listaActis_pnl.Visible = True
    End Sub

    Private Sub nuevoActi_btn_Click(sender As Object, e As EventArgs) Handles nuevoActi_btn.Click
        llenarActi()
        LlenarComboDias()
        registrarActi_pnl.Visible = True
    End Sub

    Private Sub guardarAct_btn_Click(sender As Object, e As EventArgs) Handles guardarAct_btn.Click
        ErrorProvider1.Clear()

        Dim horarios = crearHorariosActi()
        Dim id_tipo = (DirectCast(tipoActi_cmb.SelectedItem, KeyValuePair(Of String, String)).Key)
        If nombreActi_text.Text = "" Then
            ErrorProvider1.SetError(nombreActi_text, "Debe ingresar un nombre para el nuevo curso.")
            Exit Sub
        ElseIf codigoActi_text.Text = "" Then
            ErrorProvider1.SetError(codigoActi_text, "Debe ingresar un código para el nuevo curso.")
            Exit Sub
        ElseIf costoActi_text.Text = "" Then
            ErrorProvider1.SetError(costoActi_text, "Debe ingresar un costo para el nuevo curso.")
            Exit Sub
        ElseIf horarios.Length = 8 Then
            horaIni1Acti_nmb.ToString()
            ErrorProvider1.SetError(horariosActi_grp, "Debe elegir al menos un dia y una hora para el nuevo curso.")
            Exit Sub
        ElseIf Not modProduct Then
            Dim IsCorrect = ProductsController.RegistrarProducto(nombreActi_text.Text, costoActi_text.Text, codigoActi_text.Text, horarios, id_tipo, fechaInicio_dp.Value)
            If IsCorrect Then
                MsgBox("El nuevo curso se ha agregado con exito.", MsgBoxStyle.Information)
                limpiarFormActi()
                llenarTablaActis()
                listaActis_pnl.Visible = True
            Else
                MsgBox("No se ha podido ingresar el nuevo curso.", MsgBoxStyle.Critical)
            End If
        Else
            Dim IsCorrect = ProductsController.RegistrarProducto(nombreActi_text.Text, costoActi_text.Text, codigoActi_text.Text, horarios, id_tipo, fechaInicio_dp.Value)
            If IsCorrect Then
                MsgBox("El nuevo curso se ha agregado con exito.", MsgBoxStyle.Information)
                limpiarFormActi()
                llenarTablaActis()
                listaActis_pnl.Visible = True
            Else
                MsgBox("No se ha podido ingresar el nuevo curso.", MsgBoxStyle.Critical)
            End If

        End If
    End Sub
    Private Function crearHorariosActi() As String

        Dim horario1 As String = ""
        Dim horario2 As String = ""
        Dim horario3 As String = ""
        Dim horario4 As String = ""
        Dim horario5 As String = ""

        If horaIni1Acti_nmb.Value <> 0 Then
            Dim horaIni = horaIni1Acti_nmb.Value.ToString("00")
            Dim minIni = minsIni1Acti_nmb.Value.ToString("00")
            Dim horaFin = horaFin1Acti_nmb.Value.ToString("00")
            Dim minFin = minsFin1Acti_nmb.Value.ToString("00")
            horario1 = dia1Acti_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin
        End If

        If horaIni2Acti_nmb.Value <> 0 Then
            Dim horaIni = horaIni2Acti_nmb.Value.ToString("00")
            Dim minIni = minsIni2Acti_nmb.Value.ToString("00")
            Dim horaFin = horaFin2Acti_nmb.Value.ToString("00")
            Dim minFin = minsFin2Acti_nmb.Value.ToString("00")
            horario2 = dia2Acti_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin
        End If

        If horaIni3Acti_nmb.Value <> 0 Then
            Dim horaIni = horaIni3Acti_nmb.Value.ToString("00")
            Dim minIni = minsIni3Acti_nmb.Value.ToString("00")
            Dim horaFin = horaFin3Acti_nmb.Value.ToString("00")
            Dim minFin = minsFin3Acti_nmb.Value.ToString("00")
            horario3 = dia3Acti_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin
        End If

        If horaIni4Acti_nmb.Value <> 0 Then
            Dim horaIni = horaIni4Acti_nmb.Value.ToString("00")
            Dim minIni = minsIni4Acti_nmb.Value.ToString("00")
            Dim horaFin = horaFin4Acti_nmb.Value.ToString("00")
            Dim minFin = minsFin4Acti_nmb.Value.ToString("00")
            horario4 = dia4Acti_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin
        End If

        If horaIni5Acti_nmb.Value <> 0 Then
            Dim horaIni = horaIni5Acti_nmb.Value.ToString("00")
            Dim minIni = minsIni5Acti_nmb.Value.ToString("00")
            Dim horaFin = horaFin5Acti_nmb.Value.ToString("00")
            Dim minFin = minsFin5Acti_nmb.Value.ToString("00")
            horario5 = dia5Acti_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin

        End If

        Dim resul As String = Trim(horario1 & vbNewLine & horario2 & vbNewLine & horario3 & vbNewLine & horario4 & vbNewLine & horario5)
        Return resul
    End Function

    Private Sub llenarActi()

        'Dim tipos As List(Of Tipo_Producto) = ProductTypeController.obtenerLista
        Dim comboSource As New Dictionary(Of String, String)()
        'For Each tipo As Tipo_Producto In tipos
        comboSource.Add(1, "Acti")
        'Next
        tipoActi_cmb.DataSource = New BindingSource(comboSource, Nothing)
        tipoActi_cmb.DisplayMember = "Value"
        tipoActi_cmb.ValueMember = "Key"
    End Sub
    Private Sub limpiarFormActi()

        nombreActi_text.Text = ""
        costoActi_text.Text = ""
        codigoActi_text.Text = ""
        dia1Acti_cmb.Text = ""
        dia2Acti_cmb.Text = ""
        dia3Acti_cmb.Text = ""
        dia4Acti_cmb.Text = ""
        dia5Acti_cmb.Text = ""
        horaFin1Acti_nmb.Value = 0
        horaFin2Acti_nmb.Value = 0
        horaFin3Acti_nmb.Value = 0
        horaFin4Acti_nmb.Value = 0
        horaIni1Acti_nmb.Value = 0
        horaIni2Acti_nmb.Value = 0
        horaIni3Acti_nmb.Value = 0
        horaIni4Acti_nmb.Value = 0
        minsFin1Acti_nmb.Value = 0
        minsFin2Acti_nmb.Value = 0
        minsFin3Acti_nmb.Value = 0
        minsFin4Acti_nmb.Value = 0
        minsFin5Acti_nmb.Value = 0
        minsIni1Acti_nmb.Value = 0
        minsIni2Acti_nmb.Value = 0
        minsIni3Acti_nmb.Value = 0
        minsIni4Acti_nmb.Value = 0
        minsIni5Acti_nmb.Value = 0
        registrarActi_pnl.Visible = False
    End Sub

    Private Sub llenarTablaActis()
        listaActis_dg.Rows.Clear()
        Dim actis As List(Of Producto) = ProductsController.obtenerListaProductos()
        If (Not actis Is Nothing) Then
            For Each acti As Producto In actis
                If (acti.Id_Tipo_Product = 1) Then
                    listaActis_dg.Rows.Add(acti.Id_producto, acti.Nombre, acti.Codigo_Producto, acti.Costo, acti.Horario, Format(acti.Fecha_inicio, "dd-MM-yyyy"))
                End If
            Next
        End If
    End Sub

    Private Sub vovlerActi_btn_Click(sender As Object, e As EventArgs) Handles vovlerActi_btn.Click
        listaActis_pnl.Visible = False
    End Sub

    Private Sub LlenarComboDias()

        Dim dias() As String = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes"}

        dia1Acti_cmb.MaxDropDownItems = dias.Length
        dia2Acti_cmb.MaxDropDownItems = dias.Length
        dia3Acti_cmb.MaxDropDownItems = dias.Length
        dia4Acti_cmb.MaxDropDownItems = dias.Length
        dia5Acti_cmb.MaxDropDownItems = dias.Length

        For i = 0 To (dias.Length - 1)
            dia1Acti_cmb.Items.Add(dias(i))
            dia2Acti_cmb.Items.Add(dias(i))
            dia3Acti_cmb.Items.Add(dias(i))
            dia4Acti_cmb.Items.Add(dias(i))
            dia5Acti_cmb.Items.Add(dias(i))

        Next
    End Sub

    Private Sub cancelarAct_btn_Click(sender As Object, e As EventArgs) Handles cancelarAct_btn.Click
        registrarActi_pnl.Visible = False
    End Sub

    'USERS

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Close Session</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub lblCloseSession_Click(sender As Object, e As EventArgs) Handles lblCloseSession.Click
        Dim login As New FrmLogin()
        Me.Hide()
        login.ShowDialog()
        Me.Close()
    End Sub


    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Close Session</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Users_controller.signOut(user)
        Application.Exit()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>List rols</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showListOfRols()
        pnlListRols.Show()
        populateListOfRols()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>List rols</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hideListOfRols()
        pnlListRols.Hide()
    End Sub


    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>List rols</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub populateListOfRols()
        lstListRols.Rows.Clear()
        Dim estado = "Inactivo"
        Dim rols As List(Of RolModel) = RolsController.obtener()
        If (Not rols Is Nothing) Then
            For Each rol As RolModel In rols
                If rol.activo Then
                    estado = "Activo"
                End If
                lstListRols.Rows.Add(rol.id_rol, rol.nombre, estado)
            Next
        End If
    End Sub


    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>List rols</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Main_Click(sender As Object, e As EventArgs) Handles Main.Click
        showListOfRols()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Create rol</usecase>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hideCreateRolForm()
        pnlCreateRol.Hide()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Create rol</usecase>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cleanCreateRolForm()
        txtRolName.Text = ""
        tgEnabledRol.Checked = False
        tgKpiRol.Checked = False
        tgActiRol.Checked = False
        tgSalesRol.Checked = False
        tgProspectusRol.Checked = False
        tgEventsRol.Checked = False
        tgReportsRol.Checked = False
        tgConfigurationRol.Checked = False
        tgUsersRol.Checked = False
        tgCareersRol.Checked = False
    End Sub


    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Create rol</usecase>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showCreateRolForm(ByVal id As String)
        lblIdRol.Text = id
        pnlCreateRol.Show()
        cleanCreateRolForm()
        If id = "-1" Then
            lblCreateRolTittle.Text = "Crear rol"
        Else
            lblCreateRolTittle.Text = "Modificar rol"
            Dim rol As RolModel = RolsController.getRol(id)
            If (Not rol Is Nothing) Then
                txtRolName.Text = rol.nombre
                tgEnabledRol.Checked = rol.activo
                For Each permiso As PermissionModel In rol.permisos
                    Select Case permiso.nombre
                        Case "acti"
                            tgActiRol.Checked = True
                        Case "carreras"
                            tgCareersRol.Checked = True
                        Case "ventas"
                            tgSalesRol.Checked = True
                        Case "prospectos"
                            tgProspectusRol.Checked = True
                        Case "usuarios"
                            tgUsersRol.Checked = True
                        Case "eventos"
                            tgEventsRol.Checked = True
                        Case "kpis"
                            tgKpiRol.Checked = True
                        Case "reportes"
                            tgReportsRol.Checked = True
                        Case "configuracion"
                            tgConfigurationRol.Checked = True
                    End Select
                Next
            Else
                MsgBox(respuestasDelSistema.POPULATE_FILLS_ERROR, MsgBoxStyle.Critical)
            End If
        End If
    End Sub




    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Create rol</usecase>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnSaveRol_Click(sender As Object, e As EventArgs) Handles btnSaveRol.Click
        If (OnlyTextAllowSpaces(txtRolName.Text)) Then
            Dim permissions As New List(Of PermissionModel)
            If tgActiRol.Checked Then
                permissions.Add(New PermissionModel(1))
            End If
            If tgCareersRol.Checked Then
                permissions.Add(New PermissionModel(2))
            End If
            If tgSalesRol.Checked Then
                permissions.Add(New PermissionModel(3))
            End If
            If tgProspectusRol.Checked Then
                permissions.Add(New PermissionModel(4))
            End If
            If tgEventsRol.Checked Then
                permissions.Add(New PermissionModel(5))
            End If
            If tgKpiRol.Checked Then
                permissions.Add(New PermissionModel(6))
            End If
            If tgUsersRol.Checked Then
                permissions.Add(New PermissionModel(7))
            End If
            If tgReportsRol.Checked Then
                permissions.Add(New PermissionModel(8))
            End If
            If tgConfigurationRol.Checked Then
                permissions.Add(New PermissionModel(9))
            End If
            If String.Compare(lblIdRol.Text, "-1") = 0 Then
                If (RolsController.create(txtRolName.Text, tgEnabledRol.Checked, permissions)) Then
                    MsgBox(respuestasDelSistema.CREATE_ROL_SUCCESS, MsgBoxStyle.Information)
                    showListOfRols()
                    hideCreateRolForm()
                Else
                    MsgBox(respuestasDelSistema.CREATE_ROL_ERROR, MsgBoxStyle.Critical)
                End If
            Else
                If (RolsController.update(lblIdRol.Text, txtRolName.Text, tgEnabledRol.Checked, permissions)) Then
                    MsgBox(respuestasDelSistema.UPDATE_ROL_SUCCESS, MsgBoxStyle.Information)
                    showListOfRols()
                    hideCreateRolForm()
                Else
                    MsgBox(respuestasDelSistema.UPDATE_ROL_ERROR, MsgBoxStyle.Critical)
                End If
            End If

        Else
            ErrorProvider1.SetError(txtRolName, ValidationsMessages.ONLY_TEXT_ALLOW_SPACES)
        End If
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Create rol</usecase>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnNewRol_Click(sender As Object, e As EventArgs) Handles btnNewRol.Click
        showCreateRolForm("-1")
        hideListOfRols()
    End Sub

    ''' <summary>
    ''' <autor>Alejandro Bermudez Vargas</autor>
    ''' <Date>3-11-2015</Date>
    ''' <usecase>Update rol</usecase>
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub lstListRols_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lstListRols.CellContentClick
        Dim id As String = lstListRols.Rows(e.RowIndex).Cells(0).Value
        Select Case e.ColumnIndex
            Case 3
                hideListOfRols()
                showCreateRolForm(id)
        End Select
    End Sub
End Class



