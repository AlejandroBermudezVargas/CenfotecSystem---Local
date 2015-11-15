Imports System.Text.RegularExpressions
Imports System.Net.Mail
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
End Class



