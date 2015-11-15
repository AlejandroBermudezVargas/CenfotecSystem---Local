<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits MetroFramework.Forms.MetroForm

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
        Me.Main = New MetroFramework.Controls.MetroTabControl()
        Me.TabProductos = New MetroFramework.Controls.MetroTabPage()
        Me.btnActiIco = New MetroFramework.Controls.MetroTile()
        Me.btnCarrerasIcon = New MetroFramework.Controls.MetroTile()
        Me.Eventos = New MetroFramework.Controls.MetroTabPage()
        Me.PanelListarEventos = New MetroFramework.Controls.MetroPanel()
        Me.btnCrearEvento = New MetroFramework.Controls.MetroButton()
        Me.DataListarEventos = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblEventos = New MetroFramework.Controls.MetroLabel()
        Me.PanelCrearEvento = New MetroFramework.Controls.MetroPanel()
        Me.dateFin = New MetroFramework.Controls.MetroDateTime()
        Me.lblFechaFin = New MetroFramework.Controls.MetroLabel()
        Me.btnCancelarEvento = New MetroFramework.Controls.MetroButton()
        Me.btnGuardarEvento = New MetroFramework.Controls.MetroButton()
        Me.lblFechaInicio = New MetroFramework.Controls.MetroLabel()
        Me.dateEventos = New MetroFramework.Controls.MetroDateTime()
        Me.TxtnombreEventos = New MetroFramework.Controls.MetroTextBox()
        Me.lblLugar = New MetroFramework.Controls.MetroLabel()
        Me.EventosLbl = New MetroFramework.Controls.MetroLabel()
        Me.TabProspectos = New MetroFramework.Controls.MetroTabPage()
        Me.PnlListaProspectos = New MetroFramework.Controls.MetroPanel()
        Me.btnAsignarProspecto = New MetroFramework.Controls.MetroButton()
        Me.lblListaProspectos = New MetroFramework.Controls.MetroLabel()
        Me.btnCrearProspecto = New MetroFramework.Controls.MetroButton()
        Me.lstProspectos = New System.Windows.Forms.DataGridView()
        Me.ColumnaIDProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaNombreProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaApellidosProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaNacimientoProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaProcedenciaProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaTelefonoProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaEmailProspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaEditarProspecto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PnlNuevoProspecto = New MetroFramework.Controls.MetroPanel()
        Me.lblIdSeguimiento = New MetroFramework.Controls.MetroLabel()
        Me.lblIdProspecto = New MetroFramework.Controls.MetroLabel()
        Me.cbEventos = New MetroFramework.Controls.MetroComboBox()
        Me.ckbEventoProspecto = New MetroFramework.Controls.MetroCheckBox()
        Me.lblInteres = New MetroFramework.Controls.MetroLabel()
        Me.cbInteresesProspecto = New MetroFramework.Controls.MetroComboBox()
        Me.btnListarSeguimientos = New MetroFramework.Controls.MetroButton()
        Me.btnNuevoSeguimiento = New MetroFramework.Controls.MetroButton()
        Me.txtFechaNacProspecto = New MetroFramework.Controls.MetroDateTime()
        Me.txtDireccionProspecto = New MetroFramework.Controls.MetroTextBox()
        Me.txtProcedenciaProspecto = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelProspecto = New MetroFramework.Controls.MetroTextBox()
        Me.txtEmailProspecto = New MetroFramework.Controls.MetroTextBox()
        Me.txtApellidosProspecto = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombreProspecto = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancelarProspecto = New MetroFramework.Controls.MetroButton()
        Me.btnGuardarProspecto = New MetroFramework.Controls.MetroButton()
        Me.tglEstaInteresado = New MetroFramework.Controls.MetroToggle()
        Me.lblInteresadoProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblProcedenciaProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblDireccionProspecto = New MetroFramework.Controls.MetroLabel()
        Me.tglEstadoProspecto = New MetroFramework.Controls.MetroToggle()
        Me.lblTelefonoProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblEstadoProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblApellidosProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblFechaProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblCorreoProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblNombreProspecto = New MetroFramework.Controls.MetroLabel()
        Me.lblCrearProspectos = New MetroFramework.Controls.MetroLabel()
        Me.lblClienteProspecto = New MetroFramework.Controls.MetroLabel()
        Me.tglEsCliente = New MetroFramework.Controls.MetroToggle()
        Me.KPIHolder = New MetroFramework.Controls.MetroTabPage()
        Me.panSeleccionarTipoKPI = New MetroFramework.Controls.MetroPanel()
        Me.TileKpiProductos = New MetroFramework.Controls.MetroTile()
        Me.TileKpiProspecto = New MetroFramework.Controls.MetroTile()
        Me.TileKpiVentas = New MetroFramework.Controls.MetroTile()
        Me.pnlCrearKpiProducto = New MetroFramework.Controls.MetroPanel()
        Me.TextBoxResultadoKpiProductos = New System.Windows.Forms.RichTextBox()
        Me.btnCancelarKpiProducto = New MetroFramework.Controls.MetroButton()
        Me.btnCrearKpiProducto = New MetroFramework.Controls.MetroButton()
        Me.checkBoxTotalProducto = New MetroFramework.Controls.MetroCheckBox()
        Me.lblCrearKpiProducto = New MetroFramework.Controls.MetroLabel()
        Me.pnlKpiProspectos = New MetroFramework.Controls.MetroPanel()
        Me.TextBoxResultadosKpiProspectos = New System.Windows.Forms.RichTextBox()
        Me.btnCancelarKpiProspecto = New MetroFramework.Controls.MetroButton()
        Me.BtnGenerarKpiProspecto = New MetroFramework.Controls.MetroButton()
        Me.checkboxTotalProspetosCliente = New MetroFramework.Controls.MetroCheckBox()
        Me.checkBoxTotalProspectos = New MetroFramework.Controls.MetroCheckBox()
        Me.lblCrearKpiProspecto = New MetroFramework.Controls.MetroLabel()
        Me.panKpiVentas = New MetroFramework.Controls.MetroPanel()
        Me.TextBoxResultadosVentas = New System.Windows.Forms.RichTextBox()
        Me.btnCancelarKpiVenta = New MetroFramework.Controls.MetroButton()
        Me.btnCrearKpiVenta = New MetroFramework.Controls.MetroButton()
        Me.checkBoxMontoTotalVentas = New MetroFramework.Controls.MetroCheckBox()
        Me.checkBoxTotalVentas = New MetroFramework.Controls.MetroCheckBox()
        Me.crearKPIVentas = New MetroFramework.Controls.MetroLabel()
        Me.TabVentas = New MetroFramework.Controls.MetroTabPage()
        Me.listarVerntas_pnl = New MetroFramework.Controls.MetroPanel()
        Me.volverVenta_btn = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.listaVentas_dg = New System.Windows.Forms.DataGridView()
        Me.idVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.listarVentas_lbl = New MetroFramework.Controls.MetroLabel()
        Me.nuevaVenta_btn = New MetroFramework.Controls.MetroButton()
        Me.RegistrarVentas_pnl = New MetroFramework.Controls.MetroPanel()
        Me.cancelarVenta_btn = New MetroFramework.Controls.MetroButton()
        Me.guardarVenta_btn = New MetroFramework.Controls.MetroButton()
        Me.tipo_prodVenta_cmb = New System.Windows.Forms.ComboBox()
        Me.cod_prod_cmb = New System.Windows.Forms.ComboBox()
        Me.codProdVentas_lbl = New MetroFramework.Controls.MetroLabel()
        Me.productos_cmb = New System.Windows.Forms.ComboBox()
        Me.fecha_lbl = New MetroFramework.Controls.MetroLabel()
        Me.matricula_text = New MetroFramework.Controls.MetroTextBox()
        Me.totalVenta_text = New MetroFramework.Controls.MetroTextBox()
        Me.totalVenta__lbl = New MetroFramework.Controls.MetroLabel()
        Me.cargoMatricula_lbl = New MetroFramework.Controls.MetroLabel()
        Me.costoVenta_text = New MetroFramework.Controls.MetroTextBox()
        Me.tipoVenta_lbl = New MetroFramework.Controls.MetroLabel()
        Me.costoVenta_lbl = New MetroFramework.Controls.MetroLabel()
        Me.ventaProd_lbl = New MetroFramework.Controls.MetroLabel()
        Me.labelVentas_lbl = New MetroFramework.Controls.MetroLabel()
        Me.consultarVentas_pnl = New MetroFramework.Controls.MetroPanel()
        Me.ingresosConsulta_pnl = New System.Windows.Forms.GroupBox()
        Me.ingresosConsulta_dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreConsultaIngresos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalIngresos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periodoConsultaIngresos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.periodos_cmb = New System.Windows.Forms.ComboBox()
        Me.volverConsulta = New MetroFramework.Controls.MetroButton()
        Me.usuarioConsulta_cmb = New System.Windows.Forms.ComboBox()
        Me.userQueryLabel = New MetroFramework.Controls.MetroLabel()
        Me.periodoQuery_lbl = New MetroFramework.Controls.MetroLabel()
        Me.consultarVentas_lbl = New MetroFramework.Controls.MetroLabel()
        Me.ventas_grp = New System.Windows.Forms.GroupBox()
        Me.ventasConsulta_dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreUsuarioConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ventasConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodoConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn10 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.cantidadVentas_lbl = New MetroFramework.Controls.MetroLabel()
        Me.tRegistrar = New MetroFramework.Controls.MetroTile()
        Me.tListaVentas = New MetroFramework.Controls.MetroTile()
        Me.tConsultarVenta = New MetroFramework.Controls.MetroTile()
        Me.TabConfiguracion = New MetroFramework.Controls.MetroTabPage()
        Me.TabUsuarios = New MetroFramework.Controls.MetroTabPage()
        Me.TabReportes = New MetroFramework.Controls.MetroTabPage()
        Me.cboUsuario = New MetroFramework.Controls.MetroComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.checkBoxTopProduto = New MetroFramework.Controls.MetroCheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Main.SuspendLayout()
        Me.TabProductos.SuspendLayout()
        Me.Eventos.SuspendLayout()
        Me.PanelListarEventos.SuspendLayout()
        CType(Me.DataListarEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCrearEvento.SuspendLayout()
        Me.TabProspectos.SuspendLayout()
        Me.PnlListaProspectos.SuspendLayout()
        CType(Me.lstProspectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlNuevoProspecto.SuspendLayout()
        Me.KPIHolder.SuspendLayout()
        Me.panSeleccionarTipoKPI.SuspendLayout()
        Me.pnlCrearKpiProducto.SuspendLayout()
        Me.pnlKpiProspectos.SuspendLayout()
        Me.panKpiVentas.SuspendLayout()
        Me.TabVentas.SuspendLayout()
        Me.listarVerntas_pnl.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaVentas_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistrarVentas_pnl.SuspendLayout()
        Me.consultarVentas_pnl.SuspendLayout()
        Me.ingresosConsulta_pnl.SuspendLayout()
        CType(Me.ingresosConsulta_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ventas_grp.SuspendLayout()
        CType(Me.ventasConsulta_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Main
        '
        Me.Main.Controls.Add(Me.TabProductos)
        Me.Main.Controls.Add(Me.Eventos)
        Me.Main.Controls.Add(Me.TabProspectos)
        Me.Main.Controls.Add(Me.KPIHolder)
        Me.Main.Controls.Add(Me.TabVentas)
        Me.Main.Controls.Add(Me.TabConfiguracion)
        Me.Main.Controls.Add(Me.TabUsuarios)
        Me.Main.Controls.Add(Me.TabReportes)
        Me.Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.Main.Location = New System.Drawing.Point(20, 60)
        Me.Main.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Main.Name = "Main"
        Me.Main.SelectedIndex = 4
        Me.Main.Size = New System.Drawing.Size(760, 520)
        Me.Main.Style = MetroFramework.MetroColorStyle.Purple
        Me.Main.TabIndex = 2
        Me.Main.UseSelectable = True
        '
        'TabProductos
        '
        Me.TabProductos.Controls.Add(Me.btnActiIco)
        Me.TabProductos.Controls.Add(Me.btnCarrerasIcon)
        Me.TabProductos.HorizontalScrollbarBarColor = True
        Me.TabProductos.HorizontalScrollbarHighlightOnWheel = False
        Me.TabProductos.HorizontalScrollbarSize = 10
        Me.TabProductos.Location = New System.Drawing.Point(4, 44)
        Me.TabProductos.Name = "TabProductos"
        Me.TabProductos.Size = New System.Drawing.Size(752, 472)
        Me.TabProductos.TabIndex = 1
        Me.TabProductos.Text = "Productos"
        Me.TabProductos.VerticalScrollbarBarColor = True
        Me.TabProductos.VerticalScrollbarHighlightOnWheel = False
        Me.TabProductos.VerticalScrollbarSize = 10
        '
        'btnActiIco
        '
        Me.btnActiIco.ActiveControl = Nothing
        Me.btnActiIco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActiIco.Location = New System.Drawing.Point(165, 27)
        Me.btnActiIco.Name = "btnActiIco"
        Me.btnActiIco.Size = New System.Drawing.Size(124, 119)
        Me.btnActiIco.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnActiIco.TabIndex = 4
        Me.btnActiIco.Text = "Acti's"
        Me.btnActiIco.UseSelectable = True
        '
        'btnCarrerasIcon
        '
        Me.btnCarrerasIcon.ActiveControl = Nothing
        Me.btnCarrerasIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCarrerasIcon.Location = New System.Drawing.Point(24, 27)
        Me.btnCarrerasIcon.Name = "btnCarrerasIcon"
        Me.btnCarrerasIcon.Size = New System.Drawing.Size(124, 119)
        Me.btnCarrerasIcon.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnCarrerasIcon.TabIndex = 3
        Me.btnCarrerasIcon.Text = "Carreras"
        Me.btnCarrerasIcon.UseSelectable = True
        '
        'Eventos
        '
        Me.Eventos.Controls.Add(Me.PanelListarEventos)
        Me.Eventos.Controls.Add(Me.PanelCrearEvento)
        Me.Eventos.HorizontalScrollbarBarColor = True
        Me.Eventos.HorizontalScrollbarHighlightOnWheel = False
        Me.Eventos.HorizontalScrollbarSize = 10
        Me.Eventos.Location = New System.Drawing.Point(4, 44)
        Me.Eventos.Name = "Eventos"
        Me.Eventos.Size = New System.Drawing.Size(752, 472)
        Me.Eventos.TabIndex = 7
        Me.Eventos.Text = "Eventos"
        Me.Eventos.VerticalScrollbarBarColor = True
        Me.Eventos.VerticalScrollbarHighlightOnWheel = False
        Me.Eventos.VerticalScrollbarSize = 10
        '
        'PanelListarEventos
        '
        Me.PanelListarEventos.Controls.Add(Me.btnCrearEvento)
        Me.PanelListarEventos.Controls.Add(Me.DataListarEventos)
        Me.PanelListarEventos.Controls.Add(Me.lblEventos)
        Me.PanelListarEventos.HorizontalScrollbarBarColor = True
        Me.PanelListarEventos.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelListarEventos.HorizontalScrollbarSize = 10
        Me.PanelListarEventos.Location = New System.Drawing.Point(3, 9)
        Me.PanelListarEventos.Name = "PanelListarEventos"
        Me.PanelListarEventos.Size = New System.Drawing.Size(752, 742)
        Me.PanelListarEventos.TabIndex = 36
        Me.PanelListarEventos.VerticalScrollbarBarColor = True
        Me.PanelListarEventos.VerticalScrollbarHighlightOnWheel = False
        Me.PanelListarEventos.VerticalScrollbarSize = 10
        '
        'btnCrearEvento
        '
        Me.btnCrearEvento.Location = New System.Drawing.Point(620, 412)
        Me.btnCrearEvento.Name = "btnCrearEvento"
        Me.btnCrearEvento.Size = New System.Drawing.Size(123, 36)
        Me.btnCrearEvento.TabIndex = 14
        Me.btnCrearEvento.Text = "Crear Evento"
        Me.btnCrearEvento.UseSelectable = True
        '
        'DataListarEventos
        '
        Me.DataListarEventos.AllowUserToAddRows = False
        Me.DataListarEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListarEventos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.FechaInicio, Me.FechaFin, Me.IdEvento, Me.editar, Me.eliminar})
        Me.DataListarEventos.Location = New System.Drawing.Point(39, 42)
        Me.DataListarEventos.Name = "DataListarEventos"
        Me.DataListarEventos.Size = New System.Drawing.Size(643, 357)
        Me.DataListarEventos.TabIndex = 13
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Lugar"
        Me.Nombre.Name = "Nombre"
        '
        'FechaInicio
        '
        Me.FechaInicio.HeaderText = "Fecha Inicio"
        Me.FechaInicio.Name = "FechaInicio"
        '
        'FechaFin
        '
        Me.FechaFin.HeaderText = "Finaliza"
        Me.FechaFin.Name = "FechaFin"
        '
        'IdEvento
        '
        Me.IdEvento.HeaderText = "ID"
        Me.IdEvento.Name = "IdEvento"
        '
        'editar
        '
        Me.editar.HeaderText = "Editar"
        Me.editar.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.editar.Name = "editar"
        Me.editar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Image = Global.PresentasionWindowsForms.My.Resources.Resources.delete81
        Me.eliminar.Name = "eliminar"
        '
        'lblEventos
        '
        Me.lblEventos.AutoSize = True
        Me.lblEventos.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblEventos.Location = New System.Drawing.Point(4, 9)
        Me.lblEventos.Name = "lblEventos"
        Me.lblEventos.Size = New System.Drawing.Size(70, 25)
        Me.lblEventos.TabIndex = 12
        Me.lblEventos.Text = "Eventos"
        '
        'PanelCrearEvento
        '
        Me.PanelCrearEvento.Controls.Add(Me.dateFin)
        Me.PanelCrearEvento.Controls.Add(Me.lblFechaFin)
        Me.PanelCrearEvento.Controls.Add(Me.btnCancelarEvento)
        Me.PanelCrearEvento.Controls.Add(Me.btnGuardarEvento)
        Me.PanelCrearEvento.Controls.Add(Me.lblFechaInicio)
        Me.PanelCrearEvento.Controls.Add(Me.dateEventos)
        Me.PanelCrearEvento.Controls.Add(Me.TxtnombreEventos)
        Me.PanelCrearEvento.Controls.Add(Me.lblLugar)
        Me.PanelCrearEvento.Controls.Add(Me.EventosLbl)
        Me.PanelCrearEvento.HorizontalScrollbarBarColor = True
        Me.PanelCrearEvento.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelCrearEvento.HorizontalScrollbarSize = 10
        Me.PanelCrearEvento.Location = New System.Drawing.Point(3, 10)
        Me.PanelCrearEvento.Name = "PanelCrearEvento"
        Me.PanelCrearEvento.Size = New System.Drawing.Size(752, 472)
        Me.PanelCrearEvento.TabIndex = 2
        Me.PanelCrearEvento.VerticalScrollbarBarColor = True
        Me.PanelCrearEvento.VerticalScrollbarHighlightOnWheel = False
        Me.PanelCrearEvento.VerticalScrollbarSize = 10
        '
        'dateFin
        '
        Me.dateFin.Location = New System.Drawing.Point(158, 248)
        Me.dateFin.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dateFin.Name = "dateFin"
        Me.dateFin.Size = New System.Drawing.Size(200, 29)
        Me.dateFin.TabIndex = 40
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(24, 248)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(52, 19)
        Me.lblFechaFin.TabIndex = 39
        Me.lblFechaFin.Text = "Finaliza"
        '
        'btnCancelarEvento
        '
        Me.btnCancelarEvento.Location = New System.Drawing.Point(427, 436)
        Me.btnCancelarEvento.Name = "btnCancelarEvento"
        Me.btnCancelarEvento.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarEvento.TabIndex = 38
        Me.btnCancelarEvento.Text = "Cancelar"
        Me.btnCancelarEvento.UseSelectable = True
        '
        'btnGuardarEvento
        '
        Me.btnGuardarEvento.Location = New System.Drawing.Point(324, 436)
        Me.btnGuardarEvento.Name = "btnGuardarEvento"
        Me.btnGuardarEvento.Size = New System.Drawing.Size(97, 23)
        Me.btnGuardarEvento.TabIndex = 37
        Me.btnGuardarEvento.Text = "Guardar"
        Me.btnGuardarEvento.UseSelectable = True
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(24, 153)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(43, 19)
        Me.lblFechaInicio.TabIndex = 27
        Me.lblFechaInicio.Text = "Fecha"
        '
        'dateEventos
        '
        Me.dateEventos.Location = New System.Drawing.Point(158, 153)
        Me.dateEventos.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dateEventos.Name = "dateEventos"
        Me.dateEventos.Size = New System.Drawing.Size(200, 29)
        Me.dateEventos.TabIndex = 26
        '
        'TxtnombreEventos
        '
        '
        '
        '
        Me.TxtnombreEventos.CustomButton.Image = Nothing
        Me.TxtnombreEventos.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.TxtnombreEventos.CustomButton.Name = ""
        Me.TxtnombreEventos.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.TxtnombreEventos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtnombreEventos.CustomButton.TabIndex = 1
        Me.TxtnombreEventos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtnombreEventos.CustomButton.UseSelectable = True
        Me.TxtnombreEventos.CustomButton.Visible = False
        Me.TxtnombreEventos.Lines = New String(-1) {}
        Me.TxtnombreEventos.Location = New System.Drawing.Point(157, 90)
        Me.TxtnombreEventos.MaxLength = 32767
        Me.TxtnombreEventos.Name = "TxtnombreEventos"
        Me.TxtnombreEventos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtnombreEventos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtnombreEventos.SelectedText = ""
        Me.TxtnombreEventos.SelectionLength = 0
        Me.TxtnombreEventos.SelectionStart = 0
        Me.TxtnombreEventos.Size = New System.Drawing.Size(367, 23)
        Me.TxtnombreEventos.Style = MetroFramework.MetroColorStyle.Purple
        Me.TxtnombreEventos.TabIndex = 25
        Me.TxtnombreEventos.UseSelectable = True
        Me.TxtnombreEventos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtnombreEventos.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Location = New System.Drawing.Point(24, 81)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(42, 19)
        Me.lblLugar.TabIndex = 12
        Me.lblLugar.Text = "Lugar"
        '
        'EventosLbl
        '
        Me.EventosLbl.AutoSize = True
        Me.EventosLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.EventosLbl.Location = New System.Drawing.Point(4, 9)
        Me.EventosLbl.Name = "EventosLbl"
        Me.EventosLbl.Size = New System.Drawing.Size(109, 25)
        Me.EventosLbl.TabIndex = 11
        Me.EventosLbl.Text = "Crear Evento"
        '
        'TabProspectos
        '
        Me.TabProspectos.Controls.Add(Me.PnlListaProspectos)
        Me.TabProspectos.Controls.Add(Me.PnlNuevoProspecto)
        Me.TabProspectos.HorizontalScrollbarBarColor = True
        Me.TabProspectos.HorizontalScrollbarHighlightOnWheel = False
        Me.TabProspectos.HorizontalScrollbarSize = 10
        Me.TabProspectos.Location = New System.Drawing.Point(4, 44)
        Me.TabProspectos.Name = "TabProspectos"
        Me.TabProspectos.Size = New System.Drawing.Size(752, 472)
        Me.TabProspectos.TabIndex = 6
        Me.TabProspectos.Text = "Prospectos"
        Me.TabProspectos.VerticalScrollbarBarColor = True
        Me.TabProspectos.VerticalScrollbarHighlightOnWheel = False
        Me.TabProspectos.VerticalScrollbarSize = 10
        '
        'PnlListaProspectos
        '
        Me.PnlListaProspectos.Controls.Add(Me.btnAsignarProspecto)
        Me.PnlListaProspectos.Controls.Add(Me.lblListaProspectos)
        Me.PnlListaProspectos.Controls.Add(Me.btnCrearProspecto)
        Me.PnlListaProspectos.Controls.Add(Me.lstProspectos)
        Me.PnlListaProspectos.HorizontalScrollbarBarColor = True
        Me.PnlListaProspectos.HorizontalScrollbarHighlightOnWheel = False
        Me.PnlListaProspectos.HorizontalScrollbarSize = 10
        Me.PnlListaProspectos.Location = New System.Drawing.Point(0, 20)
        Me.PnlListaProspectos.Name = "PnlListaProspectos"
        Me.PnlListaProspectos.Size = New System.Drawing.Size(749, 452)
        Me.PnlListaProspectos.Style = MetroFramework.MetroColorStyle.White
        Me.PnlListaProspectos.TabIndex = 41
        Me.PnlListaProspectos.VerticalScrollbarBarColor = True
        Me.PnlListaProspectos.VerticalScrollbarHighlightOnWheel = False
        Me.PnlListaProspectos.VerticalScrollbarSize = 10
        '
        'btnAsignarProspecto
        '
        Me.btnAsignarProspecto.Location = New System.Drawing.Point(4, 412)
        Me.btnAsignarProspecto.Name = "btnAsignarProspecto"
        Me.btnAsignarProspecto.Size = New System.Drawing.Size(123, 36)
        Me.btnAsignarProspecto.TabIndex = 43
        Me.btnAsignarProspecto.Text = "Asignar prospectos"
        Me.btnAsignarProspecto.UseSelectable = True
        '
        'lblListaProspectos
        '
        Me.lblListaProspectos.AutoSize = True
        Me.lblListaProspectos.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblListaProspectos.Location = New System.Drawing.Point(4, 0)
        Me.lblListaProspectos.Name = "lblListaProspectos"
        Me.lblListaProspectos.Size = New System.Drawing.Size(132, 25)
        Me.lblListaProspectos.TabIndex = 10
        Me.lblListaProspectos.Text = "Lista prospectos"
        '
        'btnCrearProspecto
        '
        Me.btnCrearProspecto.Location = New System.Drawing.Point(620, 412)
        Me.btnCrearProspecto.Name = "btnCrearProspecto"
        Me.btnCrearProspecto.Size = New System.Drawing.Size(122, 36)
        Me.btnCrearProspecto.TabIndex = 9
        Me.btnCrearProspecto.Text = "Nuevo prospecto"
        Me.btnCrearProspecto.UseSelectable = True
        '
        'lstProspectos
        '
        Me.lstProspectos.AllowUserToAddRows = False
        Me.lstProspectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstProspectos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaIDProspecto, Me.ColumnaNombreProspecto, Me.ColumnaApellidosProspecto, Me.ColumnaNacimientoProspecto, Me.ColumnaProcedenciaProspecto, Me.ColumnaTelefonoProspecto, Me.ColumnaEmailProspecto, Me.ColumnaEditarProspecto})
        Me.lstProspectos.Location = New System.Drawing.Point(4, 37)
        Me.lstProspectos.Name = "lstProspectos"
        Me.lstProspectos.RowHeadersVisible = False
        Me.lstProspectos.Size = New System.Drawing.Size(739, 344)
        Me.lstProspectos.TabIndex = 8
        '
        'ColumnaIDProspecto
        '
        Me.ColumnaIDProspecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaIDProspecto.HeaderText = "ID"
        Me.ColumnaIDProspecto.Name = "ColumnaIDProspecto"
        Me.ColumnaIDProspecto.ReadOnly = True
        Me.ColumnaIDProspecto.Visible = False
        '
        'ColumnaNombreProspecto
        '
        Me.ColumnaNombreProspecto.HeaderText = "Nombre"
        Me.ColumnaNombreProspecto.Name = "ColumnaNombreProspecto"
        Me.ColumnaNombreProspecto.ReadOnly = True
        '
        'ColumnaApellidosProspecto
        '
        Me.ColumnaApellidosProspecto.HeaderText = "Apellidos"
        Me.ColumnaApellidosProspecto.Name = "ColumnaApellidosProspecto"
        Me.ColumnaApellidosProspecto.ReadOnly = True
        '
        'ColumnaNacimientoProspecto
        '
        Me.ColumnaNacimientoProspecto.HeaderText = "Nacimiento"
        Me.ColumnaNacimientoProspecto.Name = "ColumnaNacimientoProspecto"
        Me.ColumnaNacimientoProspecto.ReadOnly = True
        '
        'ColumnaProcedenciaProspecto
        '
        Me.ColumnaProcedenciaProspecto.HeaderText = "Procedencia"
        Me.ColumnaProcedenciaProspecto.Name = "ColumnaProcedenciaProspecto"
        Me.ColumnaProcedenciaProspecto.ReadOnly = True
        '
        'ColumnaTelefonoProspecto
        '
        Me.ColumnaTelefonoProspecto.HeaderText = "Teléfono"
        Me.ColumnaTelefonoProspecto.Name = "ColumnaTelefonoProspecto"
        Me.ColumnaTelefonoProspecto.ReadOnly = True
        '
        'ColumnaEmailProspecto
        '
        Me.ColumnaEmailProspecto.HeaderText = "E-mail"
        Me.ColumnaEmailProspecto.Name = "ColumnaEmailProspecto"
        Me.ColumnaEmailProspecto.ReadOnly = True
        '
        'ColumnaEditarProspecto
        '
        Me.ColumnaEditarProspecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnaEditarProspecto.HeaderText = ""
        Me.ColumnaEditarProspecto.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.ColumnaEditarProspecto.Name = "ColumnaEditarProspecto"
        Me.ColumnaEditarProspecto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaEditarProspecto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PnlNuevoProspecto
        '
        Me.PnlNuevoProspecto.Controls.Add(Me.lblIdSeguimiento)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblIdProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.cbEventos)
        Me.PnlNuevoProspecto.Controls.Add(Me.ckbEventoProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblInteres)
        Me.PnlNuevoProspecto.Controls.Add(Me.cbInteresesProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.btnListarSeguimientos)
        Me.PnlNuevoProspecto.Controls.Add(Me.btnNuevoSeguimiento)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtFechaNacProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtDireccionProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtProcedenciaProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtTelProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtEmailProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtApellidosProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.txtNombreProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.btnCancelarProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.btnGuardarProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.tglEstaInteresado)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblInteresadoProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblProcedenciaProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblDireccionProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.tglEstadoProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblTelefonoProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblEstadoProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblApellidosProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblFechaProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblCorreoProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblNombreProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblCrearProspectos)
        Me.PnlNuevoProspecto.Controls.Add(Me.lblClienteProspecto)
        Me.PnlNuevoProspecto.Controls.Add(Me.tglEsCliente)
        Me.PnlNuevoProspecto.HorizontalScrollbarBarColor = True
        Me.PnlNuevoProspecto.HorizontalScrollbarHighlightOnWheel = False
        Me.PnlNuevoProspecto.HorizontalScrollbarSize = 10
        Me.PnlNuevoProspecto.Location = New System.Drawing.Point(4, 14)
        Me.PnlNuevoProspecto.Name = "PnlNuevoProspecto"
        Me.PnlNuevoProspecto.Size = New System.Drawing.Size(704, 459)
        Me.PnlNuevoProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.PnlNuevoProspecto.TabIndex = 44
        Me.PnlNuevoProspecto.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PnlNuevoProspecto.VerticalScrollbarBarColor = True
        Me.PnlNuevoProspecto.VerticalScrollbarHighlightOnWheel = False
        Me.PnlNuevoProspecto.VerticalScrollbarSize = 10
        Me.PnlNuevoProspecto.Visible = False
        '
        'lblIdSeguimiento
        '
        Me.lblIdSeguimiento.AutoSize = True
        Me.lblIdSeguimiento.Location = New System.Drawing.Point(648, 9)
        Me.lblIdSeguimiento.Name = "lblIdSeguimiento"
        Me.lblIdSeguimiento.Size = New System.Drawing.Size(20, 19)
        Me.lblIdSeguimiento.TabIndex = 48
        Me.lblIdSeguimiento.Text = "-1"
        Me.lblIdSeguimiento.Visible = False
        '
        'lblIdProspecto
        '
        Me.lblIdProspecto.AutoSize = True
        Me.lblIdProspecto.Location = New System.Drawing.Point(671, 9)
        Me.lblIdProspecto.Name = "lblIdProspecto"
        Me.lblIdProspecto.Size = New System.Drawing.Size(20, 19)
        Me.lblIdProspecto.TabIndex = 47
        Me.lblIdProspecto.Text = "-1"
        Me.lblIdProspecto.Visible = False
        '
        'cbEventos
        '
        Me.cbEventos.Enabled = False
        Me.cbEventos.FormattingEnabled = True
        Me.cbEventos.ItemHeight = 23
        Me.cbEventos.Location = New System.Drawing.Point(403, 209)
        Me.cbEventos.Name = "cbEventos"
        Me.cbEventos.Size = New System.Drawing.Size(121, 29)
        Me.cbEventos.Style = MetroFramework.MetroColorStyle.Purple
        Me.cbEventos.TabIndex = 46
        Me.cbEventos.UseSelectable = True
        '
        'ckbEventoProspecto
        '
        Me.ckbEventoProspecto.AutoSize = True
        Me.ckbEventoProspecto.Location = New System.Drawing.Point(329, 217)
        Me.ckbEventoProspecto.Name = "ckbEventoProspecto"
        Me.ckbEventoProspecto.Size = New System.Drawing.Size(59, 15)
        Me.ckbEventoProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.ckbEventoProspecto.TabIndex = 45
        Me.ckbEventoProspecto.Text = "Evento"
        Me.ckbEventoProspecto.UseSelectable = True
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.Location = New System.Drawing.Point(324, 356)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(59, 19)
        Me.lblInteres.TabIndex = 44
        Me.lblInteres.Text = "Intereses"
        '
        'cbInteresesProspecto
        '
        Me.cbInteresesProspecto.Enabled = False
        Me.cbInteresesProspecto.ItemHeight = 23
        Me.cbInteresesProspecto.Location = New System.Drawing.Point(403, 356)
        Me.cbInteresesProspecto.Name = "cbInteresesProspecto"
        Me.cbInteresesProspecto.Size = New System.Drawing.Size(121, 29)
        Me.cbInteresesProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.cbInteresesProspecto.TabIndex = 43
        Me.cbInteresesProspecto.UseSelectable = True
        '
        'btnListarSeguimientos
        '
        Me.btnListarSeguimientos.Location = New System.Drawing.Point(575, 104)
        Me.btnListarSeguimientos.Name = "btnListarSeguimientos"
        Me.btnListarSeguimientos.Size = New System.Drawing.Size(116, 37)
        Me.btnListarSeguimientos.TabIndex = 37
        Me.btnListarSeguimientos.Text = "Lista seguimientos"
        Me.btnListarSeguimientos.UseSelectable = True
        Me.btnListarSeguimientos.Visible = False
        '
        'btnNuevoSeguimiento
        '
        Me.btnNuevoSeguimiento.Location = New System.Drawing.Point(575, 51)
        Me.btnNuevoSeguimiento.Name = "btnNuevoSeguimiento"
        Me.btnNuevoSeguimiento.Size = New System.Drawing.Size(116, 37)
        Me.btnNuevoSeguimiento.TabIndex = 36
        Me.btnNuevoSeguimiento.Text = "Nuevo seguimiento"
        Me.btnNuevoSeguimiento.UseSelectable = True
        Me.btnNuevoSeguimiento.Visible = False
        '
        'txtFechaNacProspecto
        '
        Me.txtFechaNacProspecto.CustomFormat = ""
        Me.txtFechaNacProspecto.Location = New System.Drawing.Point(158, 112)
        Me.txtFechaNacProspecto.MinimumSize = New System.Drawing.Size(4, 29)
        Me.txtFechaNacProspecto.Name = "txtFechaNacProspecto"
        Me.txtFechaNacProspecto.Size = New System.Drawing.Size(367, 29)
        Me.txtFechaNacProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtFechaNacProspecto.TabIndex = 32
        Me.txtFechaNacProspecto.Value = New Date(2015, 11, 1, 16, 55, 54, 0)
        '
        'txtDireccionProspecto
        '
        '
        '
        '
        Me.txtDireccionProspecto.CustomButton.Image = Nothing
        Me.txtDireccionProspecto.CustomButton.Location = New System.Drawing.Point(301, 1)
        Me.txtDireccionProspecto.CustomButton.Name = ""
        Me.txtDireccionProspecto.CustomButton.Size = New System.Drawing.Size(65, 65)
        Me.txtDireccionProspecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDireccionProspecto.CustomButton.TabIndex = 1
        Me.txtDireccionProspecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDireccionProspecto.CustomButton.UseSelectable = True
        Me.txtDireccionProspecto.CustomButton.Visible = False
        Me.txtDireccionProspecto.Lines = New String(-1) {}
        Me.txtDireccionProspecto.Location = New System.Drawing.Point(158, 248)
        Me.txtDireccionProspecto.MaxLength = 32767
        Me.txtDireccionProspecto.Multiline = True
        Me.txtDireccionProspecto.Name = "txtDireccionProspecto"
        Me.txtDireccionProspecto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccionProspecto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccionProspecto.SelectedText = ""
        Me.txtDireccionProspecto.SelectionLength = 0
        Me.txtDireccionProspecto.SelectionStart = 0
        Me.txtDireccionProspecto.Size = New System.Drawing.Size(367, 67)
        Me.txtDireccionProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtDireccionProspecto.TabIndex = 31
        Me.txtDireccionProspecto.UseSelectable = True
        Me.txtDireccionProspecto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDireccionProspecto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtProcedenciaProspecto
        '
        '
        '
        '
        Me.txtProcedenciaProspecto.CustomButton.Image = Nothing
        Me.txtProcedenciaProspecto.CustomButton.Location = New System.Drawing.Point(132, 1)
        Me.txtProcedenciaProspecto.CustomButton.Name = ""
        Me.txtProcedenciaProspecto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtProcedenciaProspecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtProcedenciaProspecto.CustomButton.TabIndex = 1
        Me.txtProcedenciaProspecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtProcedenciaProspecto.CustomButton.UseSelectable = True
        Me.txtProcedenciaProspecto.CustomButton.Visible = False
        Me.txtProcedenciaProspecto.Lines = New String(-1) {}
        Me.txtProcedenciaProspecto.Location = New System.Drawing.Point(158, 213)
        Me.txtProcedenciaProspecto.MaxLength = 32767
        Me.txtProcedenciaProspecto.Name = "txtProcedenciaProspecto"
        Me.txtProcedenciaProspecto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProcedenciaProspecto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtProcedenciaProspecto.SelectedText = ""
        Me.txtProcedenciaProspecto.SelectionLength = 0
        Me.txtProcedenciaProspecto.SelectionStart = 0
        Me.txtProcedenciaProspecto.Size = New System.Drawing.Size(154, 23)
        Me.txtProcedenciaProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtProcedenciaProspecto.TabIndex = 30
        Me.txtProcedenciaProspecto.UseSelectable = True
        Me.txtProcedenciaProspecto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtProcedenciaProspecto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTelProspecto
        '
        '
        '
        '
        Me.txtTelProspecto.CustomButton.Image = Nothing
        Me.txtTelProspecto.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtTelProspecto.CustomButton.Name = ""
        Me.txtTelProspecto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTelProspecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelProspecto.CustomButton.TabIndex = 1
        Me.txtTelProspecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelProspecto.CustomButton.UseSelectable = True
        Me.txtTelProspecto.CustomButton.Visible = False
        Me.txtTelProspecto.Lines = New String(-1) {}
        Me.txtTelProspecto.Location = New System.Drawing.Point(158, 180)
        Me.txtTelProspecto.MaxLength = 32767
        Me.txtTelProspecto.Name = "txtTelProspecto"
        Me.txtTelProspecto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelProspecto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelProspecto.SelectedText = ""
        Me.txtTelProspecto.SelectionLength = 0
        Me.txtTelProspecto.SelectionStart = 0
        Me.txtTelProspecto.Size = New System.Drawing.Size(367, 23)
        Me.txtTelProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtTelProspecto.TabIndex = 28
        Me.txtTelProspecto.UseSelectable = True
        Me.txtTelProspecto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTelProspecto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEmailProspecto
        '
        '
        '
        '
        Me.txtEmailProspecto.CustomButton.Image = Nothing
        Me.txtEmailProspecto.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtEmailProspecto.CustomButton.Name = ""
        Me.txtEmailProspecto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmailProspecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmailProspecto.CustomButton.TabIndex = 1
        Me.txtEmailProspecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmailProspecto.CustomButton.UseSelectable = True
        Me.txtEmailProspecto.CustomButton.Visible = False
        Me.txtEmailProspecto.Lines = New String(-1) {}
        Me.txtEmailProspecto.Location = New System.Drawing.Point(158, 148)
        Me.txtEmailProspecto.MaxLength = 32767
        Me.txtEmailProspecto.Name = "txtEmailProspecto"
        Me.txtEmailProspecto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailProspecto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmailProspecto.SelectedText = ""
        Me.txtEmailProspecto.SelectionLength = 0
        Me.txtEmailProspecto.SelectionStart = 0
        Me.txtEmailProspecto.Size = New System.Drawing.Size(367, 23)
        Me.txtEmailProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtEmailProspecto.TabIndex = 27
        Me.txtEmailProspecto.UseSelectable = True
        Me.txtEmailProspecto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmailProspecto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtApellidosProspecto
        '
        '
        '
        '
        Me.txtApellidosProspecto.CustomButton.Image = Nothing
        Me.txtApellidosProspecto.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtApellidosProspecto.CustomButton.Name = ""
        Me.txtApellidosProspecto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtApellidosProspecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtApellidosProspecto.CustomButton.TabIndex = 1
        Me.txtApellidosProspecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtApellidosProspecto.CustomButton.UseSelectable = True
        Me.txtApellidosProspecto.CustomButton.Visible = False
        Me.txtApellidosProspecto.Lines = New String(-1) {}
        Me.txtApellidosProspecto.Location = New System.Drawing.Point(158, 82)
        Me.txtApellidosProspecto.MaxLength = 32767
        Me.txtApellidosProspecto.Name = "txtApellidosProspecto"
        Me.txtApellidosProspecto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellidosProspecto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApellidosProspecto.SelectedText = ""
        Me.txtApellidosProspecto.SelectionLength = 0
        Me.txtApellidosProspecto.SelectionStart = 0
        Me.txtApellidosProspecto.Size = New System.Drawing.Size(367, 23)
        Me.txtApellidosProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtApellidosProspecto.TabIndex = 25
        Me.txtApellidosProspecto.UseSelectable = True
        Me.txtApellidosProspecto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtApellidosProspecto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNombreProspecto
        '
        '
        '
        '
        Me.txtNombreProspecto.CustomButton.Image = Nothing
        Me.txtNombreProspecto.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtNombreProspecto.CustomButton.Name = ""
        Me.txtNombreProspecto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombreProspecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombreProspecto.CustomButton.TabIndex = 1
        Me.txtNombreProspecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombreProspecto.CustomButton.UseSelectable = True
        Me.txtNombreProspecto.CustomButton.Visible = False
        Me.txtNombreProspecto.Lines = New String(-1) {}
        Me.txtNombreProspecto.Location = New System.Drawing.Point(158, 51)
        Me.txtNombreProspecto.MaxLength = 32767
        Me.txtNombreProspecto.Name = "txtNombreProspecto"
        Me.txtNombreProspecto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreProspecto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreProspecto.SelectedText = ""
        Me.txtNombreProspecto.SelectionLength = 0
        Me.txtNombreProspecto.SelectionStart = 0
        Me.txtNombreProspecto.Size = New System.Drawing.Size(367, 23)
        Me.txtNombreProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtNombreProspecto.TabIndex = 24
        Me.txtNombreProspecto.UseSelectable = True
        Me.txtNombreProspecto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombreProspecto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCancelarProspecto
        '
        Me.btnCancelarProspecto.Location = New System.Drawing.Point(423, 433)
        Me.btnCancelarProspecto.Name = "btnCancelarProspecto"
        Me.btnCancelarProspecto.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarProspecto.TabIndex = 23
        Me.btnCancelarProspecto.Text = "Cancelar"
        Me.btnCancelarProspecto.UseSelectable = True
        '
        'btnGuardarProspecto
        '
        Me.btnGuardarProspecto.Location = New System.Drawing.Point(320, 433)
        Me.btnGuardarProspecto.Name = "btnGuardarProspecto"
        Me.btnGuardarProspecto.Size = New System.Drawing.Size(97, 23)
        Me.btnGuardarProspecto.TabIndex = 22
        Me.btnGuardarProspecto.Text = "Guardar"
        Me.btnGuardarProspecto.UseSelectable = True
        '
        'tglEstaInteresado
        '
        Me.tglEstaInteresado.AutoSize = True
        Me.tglEstaInteresado.Location = New System.Drawing.Point(158, 356)
        Me.tglEstaInteresado.Name = "tglEstaInteresado"
        Me.tglEstaInteresado.Size = New System.Drawing.Size(80, 17)
        Me.tglEstaInteresado.Style = MetroFramework.MetroColorStyle.Purple
        Me.tglEstaInteresado.TabIndex = 21
        Me.tglEstaInteresado.Text = "Off"
        Me.tglEstaInteresado.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tglEstaInteresado.UseSelectable = True
        '
        'lblInteresadoProspecto
        '
        Me.lblInteresadoProspecto.AutoSize = True
        Me.lblInteresadoProspecto.Location = New System.Drawing.Point(24, 354)
        Me.lblInteresadoProspecto.Name = "lblInteresadoProspecto"
        Me.lblInteresadoProspecto.Size = New System.Drawing.Size(70, 19)
        Me.lblInteresadoProspecto.TabIndex = 20
        Me.lblInteresadoProspecto.Text = "Interesado"
        '
        'lblProcedenciaProspecto
        '
        Me.lblProcedenciaProspecto.AutoSize = True
        Me.lblProcedenciaProspecto.Location = New System.Drawing.Point(24, 213)
        Me.lblProcedenciaProspecto.Name = "lblProcedenciaProspecto"
        Me.lblProcedenciaProspecto.Size = New System.Drawing.Size(81, 19)
        Me.lblProcedenciaProspecto.TabIndex = 19
        Me.lblProcedenciaProspecto.Text = "Procedencia"
        '
        'lblDireccionProspecto
        '
        Me.lblDireccionProspecto.AutoSize = True
        Me.lblDireccionProspecto.Location = New System.Drawing.Point(25, 248)
        Me.lblDireccionProspecto.Name = "lblDireccionProspecto"
        Me.lblDireccionProspecto.Size = New System.Drawing.Size(63, 19)
        Me.lblDireccionProspecto.TabIndex = 18
        Me.lblDireccionProspecto.Text = "Dirección"
        '
        'tglEstadoProspecto
        '
        Me.tglEstadoProspecto.AutoSize = True
        Me.tglEstadoProspecto.Checked = True
        Me.tglEstadoProspecto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tglEstadoProspecto.Location = New System.Drawing.Point(158, 328)
        Me.tglEstadoProspecto.Name = "tglEstadoProspecto"
        Me.tglEstadoProspecto.Size = New System.Drawing.Size(80, 17)
        Me.tglEstadoProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.tglEstadoProspecto.TabIndex = 17
        Me.tglEstadoProspecto.Text = "On"
        Me.tglEstadoProspecto.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tglEstadoProspecto.UseSelectable = True
        '
        'lblTelefonoProspecto
        '
        Me.lblTelefonoProspecto.AutoSize = True
        Me.lblTelefonoProspecto.Location = New System.Drawing.Point(24, 180)
        Me.lblTelefonoProspecto.Name = "lblTelefonoProspecto"
        Me.lblTelefonoProspecto.Size = New System.Drawing.Size(58, 19)
        Me.lblTelefonoProspecto.TabIndex = 16
        Me.lblTelefonoProspecto.Text = "Telefono"
        '
        'lblEstadoProspecto
        '
        Me.lblEstadoProspecto.AutoSize = True
        Me.lblEstadoProspecto.Location = New System.Drawing.Point(24, 326)
        Me.lblEstadoProspecto.Name = "lblEstadoProspecto"
        Me.lblEstadoProspecto.Size = New System.Drawing.Size(48, 19)
        Me.lblEstadoProspecto.TabIndex = 15
        Me.lblEstadoProspecto.Text = "Estado"
        '
        'lblApellidosProspecto
        '
        Me.lblApellidosProspecto.AutoSize = True
        Me.lblApellidosProspecto.Location = New System.Drawing.Point(24, 82)
        Me.lblApellidosProspecto.Name = "lblApellidosProspecto"
        Me.lblApellidosProspecto.Size = New System.Drawing.Size(58, 19)
        Me.lblApellidosProspecto.TabIndex = 14
        Me.lblApellidosProspecto.Text = "Apellido"
        '
        'lblFechaProspecto
        '
        Me.lblFechaProspecto.AutoSize = True
        Me.lblFechaProspecto.Location = New System.Drawing.Point(25, 114)
        Me.lblFechaProspecto.Name = "lblFechaProspecto"
        Me.lblFechaProspecto.Size = New System.Drawing.Size(111, 19)
        Me.lblFechaProspecto.TabIndex = 13
        Me.lblFechaProspecto.Text = "Fecha nacimiento"
        '
        'lblCorreoProspecto
        '
        Me.lblCorreoProspecto.AutoSize = True
        Me.lblCorreoProspecto.Location = New System.Drawing.Point(24, 148)
        Me.lblCorreoProspecto.Name = "lblCorreoProspecto"
        Me.lblCorreoProspecto.Size = New System.Drawing.Size(51, 19)
        Me.lblCorreoProspecto.TabIndex = 12
        Me.lblCorreoProspecto.Text = "Correo"
        '
        'lblNombreProspecto
        '
        Me.lblNombreProspecto.AutoSize = True
        Me.lblNombreProspecto.Location = New System.Drawing.Point(24, 51)
        Me.lblNombreProspecto.Name = "lblNombreProspecto"
        Me.lblNombreProspecto.Size = New System.Drawing.Size(59, 19)
        Me.lblNombreProspecto.TabIndex = 11
        Me.lblNombreProspecto.Text = "Nombre"
        '
        'lblCrearProspectos
        '
        Me.lblCrearProspectos.AutoSize = True
        Me.lblCrearProspectos.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCrearProspectos.Location = New System.Drawing.Point(-2, 4)
        Me.lblCrearProspectos.Name = "lblCrearProspectos"
        Me.lblCrearProspectos.Size = New System.Drawing.Size(133, 25)
        Me.lblCrearProspectos.TabIndex = 10
        Me.lblCrearProspectos.Text = "Crear prospecto"
        '
        'lblClienteProspecto
        '
        Me.lblClienteProspecto.AutoSize = True
        Me.lblClienteProspecto.Location = New System.Drawing.Point(25, 384)
        Me.lblClienteProspecto.Name = "lblClienteProspecto"
        Me.lblClienteProspecto.Size = New System.Drawing.Size(49, 19)
        Me.lblClienteProspecto.TabIndex = 34
        Me.lblClienteProspecto.Text = "Cliente"
        '
        'tglEsCliente
        '
        Me.tglEsCliente.AutoSize = True
        Me.tglEsCliente.Location = New System.Drawing.Point(158, 384)
        Me.tglEsCliente.Name = "tglEsCliente"
        Me.tglEsCliente.Size = New System.Drawing.Size(80, 17)
        Me.tglEsCliente.Style = MetroFramework.MetroColorStyle.Purple
        Me.tglEsCliente.TabIndex = 35
        Me.tglEsCliente.Text = "Off"
        Me.tglEsCliente.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tglEsCliente.UseSelectable = True
        '
        'KPIHolder
        '
        Me.KPIHolder.Controls.Add(Me.panSeleccionarTipoKPI)
        Me.KPIHolder.Controls.Add(Me.pnlCrearKpiProducto)
        Me.KPIHolder.Controls.Add(Me.pnlKpiProspectos)
        Me.KPIHolder.Controls.Add(Me.panKpiVentas)
        Me.KPIHolder.HorizontalScrollbarBarColor = True
        Me.KPIHolder.HorizontalScrollbarHighlightOnWheel = False
        Me.KPIHolder.HorizontalScrollbarSize = 10
        Me.KPIHolder.Location = New System.Drawing.Point(4, 44)
        Me.KPIHolder.Name = "KPIHolder"
        Me.KPIHolder.Size = New System.Drawing.Size(752, 472)
        Me.KPIHolder.TabIndex = 3
        Me.KPIHolder.Text = "KPI"
        Me.KPIHolder.UseVisualStyleBackColor = True
        Me.KPIHolder.VerticalScrollbarBarColor = True
        Me.KPIHolder.VerticalScrollbarHighlightOnWheel = False
        Me.KPIHolder.VerticalScrollbarSize = 10
        '
        'panSeleccionarTipoKPI
        '
        Me.panSeleccionarTipoKPI.Controls.Add(Me.TileKpiProductos)
        Me.panSeleccionarTipoKPI.Controls.Add(Me.TileKpiProspecto)
        Me.panSeleccionarTipoKPI.Controls.Add(Me.TileKpiVentas)
        Me.panSeleccionarTipoKPI.HorizontalScrollbarBarColor = True
        Me.panSeleccionarTipoKPI.HorizontalScrollbarHighlightOnWheel = False
        Me.panSeleccionarTipoKPI.HorizontalScrollbarSize = 10
        Me.panSeleccionarTipoKPI.Location = New System.Drawing.Point(1, 15)
        Me.panSeleccionarTipoKPI.Name = "panSeleccionarTipoKPI"
        Me.panSeleccionarTipoKPI.Size = New System.Drawing.Size(752, 742)
        Me.panSeleccionarTipoKPI.TabIndex = 2
        Me.panSeleccionarTipoKPI.VerticalScrollbarBarColor = True
        Me.panSeleccionarTipoKPI.VerticalScrollbarHighlightOnWheel = False
        Me.panSeleccionarTipoKPI.VerticalScrollbarSize = 10
        '
        'TileKpiProductos
        '
        Me.TileKpiProductos.ActiveControl = Nothing
        Me.TileKpiProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TileKpiProductos.Location = New System.Drawing.Point(331, 27)
        Me.TileKpiProductos.Name = "TileKpiProductos"
        Me.TileKpiProductos.Size = New System.Drawing.Size(124, 119)
        Me.TileKpiProductos.Style = MetroFramework.MetroColorStyle.Purple
        Me.TileKpiProductos.TabIndex = 6
        Me.TileKpiProductos.Text = "Productos"
        Me.TileKpiProductos.UseSelectable = True
        '
        'TileKpiProspecto
        '
        Me.TileKpiProspecto.ActiveControl = Nothing
        Me.TileKpiProspecto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TileKpiProspecto.Location = New System.Drawing.Point(178, 27)
        Me.TileKpiProspecto.Name = "TileKpiProspecto"
        Me.TileKpiProspecto.Size = New System.Drawing.Size(124, 119)
        Me.TileKpiProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.TileKpiProspecto.TabIndex = 5
        Me.TileKpiProspecto.Text = "Prospectos"
        Me.TileKpiProspecto.UseSelectable = True
        '
        'TileKpiVentas
        '
        Me.TileKpiVentas.ActiveControl = Nothing
        Me.TileKpiVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TileKpiVentas.Location = New System.Drawing.Point(24, 27)
        Me.TileKpiVentas.Name = "TileKpiVentas"
        Me.TileKpiVentas.Size = New System.Drawing.Size(124, 119)
        Me.TileKpiVentas.Style = MetroFramework.MetroColorStyle.Purple
        Me.TileKpiVentas.TabIndex = 4
        Me.TileKpiVentas.Text = "Ventas"
        Me.TileKpiVentas.UseSelectable = True
        '
        'pnlCrearKpiProducto
        '
        Me.pnlCrearKpiProducto.Controls.Add(Me.TextBoxResultadoKpiProductos)
        Me.pnlCrearKpiProducto.Controls.Add(Me.btnCancelarKpiProducto)
        Me.pnlCrearKpiProducto.Controls.Add(Me.btnCrearKpiProducto)
        Me.pnlCrearKpiProducto.Controls.Add(Me.checkBoxTotalProducto)
        Me.pnlCrearKpiProducto.Controls.Add(Me.lblCrearKpiProducto)
        Me.pnlCrearKpiProducto.HorizontalScrollbarBarColor = True
        Me.pnlCrearKpiProducto.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlCrearKpiProducto.HorizontalScrollbarSize = 10
        Me.pnlCrearKpiProducto.Location = New System.Drawing.Point(3, 15)
        Me.pnlCrearKpiProducto.Name = "pnlCrearKpiProducto"
        Me.pnlCrearKpiProducto.Size = New System.Drawing.Size(752, 742)
        Me.pnlCrearKpiProducto.TabIndex = 25
        Me.pnlCrearKpiProducto.VerticalScrollbarBarColor = True
        Me.pnlCrearKpiProducto.VerticalScrollbarHighlightOnWheel = False
        Me.pnlCrearKpiProducto.VerticalScrollbarSize = 10
        '
        'TextBoxResultadoKpiProductos
        '
        Me.TextBoxResultadoKpiProductos.Location = New System.Drawing.Point(15, 187)
        Me.TextBoxResultadoKpiProductos.Name = "TextBoxResultadoKpiProductos"
        Me.TextBoxResultadoKpiProductos.Size = New System.Drawing.Size(710, 254)
        Me.TextBoxResultadoKpiProductos.TabIndex = 25
        Me.TextBoxResultadoKpiProductos.Text = ""
        '
        'btnCancelarKpiProducto
        '
        Me.btnCancelarKpiProducto.Location = New System.Drawing.Point(248, 112)
        Me.btnCancelarKpiProducto.Name = "btnCancelarKpiProducto"
        Me.btnCancelarKpiProducto.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarKpiProducto.TabIndex = 24
        Me.btnCancelarKpiProducto.Text = "Cancelar"
        Me.btnCancelarKpiProducto.UseSelectable = True
        '
        'btnCrearKpiProducto
        '
        Me.btnCrearKpiProducto.Location = New System.Drawing.Point(123, 112)
        Me.btnCrearKpiProducto.Name = "btnCrearKpiProducto"
        Me.btnCrearKpiProducto.Size = New System.Drawing.Size(97, 23)
        Me.btnCrearKpiProducto.TabIndex = 23
        Me.btnCrearKpiProducto.Text = "Generar"
        Me.btnCrearKpiProducto.UseSelectable = True
        '
        'checkBoxTotalProducto
        '
        Me.checkBoxTotalProducto.AutoSize = True
        Me.checkBoxTotalProducto.Location = New System.Drawing.Point(15, 62)
        Me.checkBoxTotalProducto.Name = "checkBoxTotalProducto"
        Me.checkBoxTotalProducto.Size = New System.Drawing.Size(102, 15)
        Me.checkBoxTotalProducto.TabIndex = 12
        Me.checkBoxTotalProducto.Text = "Total Producto"
        Me.checkBoxTotalProducto.UseSelectable = True
        '
        'lblCrearKpiProducto
        '
        Me.lblCrearKpiProducto.AutoSize = True
        Me.lblCrearKpiProducto.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCrearKpiProducto.Location = New System.Drawing.Point(4, 9)
        Me.lblCrearKpiProducto.Name = "lblCrearKpiProducto"
        Me.lblCrearKpiProducto.Size = New System.Drawing.Size(155, 25)
        Me.lblCrearKpiProducto.TabIndex = 11
        Me.lblCrearKpiProducto.Text = "Crear Kpi Producto"
        '
        'pnlKpiProspectos
        '
        Me.pnlKpiProspectos.Controls.Add(Me.TextBoxResultadosKpiProspectos)
        Me.pnlKpiProspectos.Controls.Add(Me.btnCancelarKpiProspecto)
        Me.pnlKpiProspectos.Controls.Add(Me.BtnGenerarKpiProspecto)
        Me.pnlKpiProspectos.Controls.Add(Me.checkboxTotalProspetosCliente)
        Me.pnlKpiProspectos.Controls.Add(Me.checkBoxTotalProspectos)
        Me.pnlKpiProspectos.Controls.Add(Me.lblCrearKpiProspecto)
        Me.pnlKpiProspectos.HorizontalScrollbarBarColor = True
        Me.pnlKpiProspectos.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlKpiProspectos.HorizontalScrollbarSize = 10
        Me.pnlKpiProspectos.Location = New System.Drawing.Point(1, 0)
        Me.pnlKpiProspectos.Name = "pnlKpiProspectos"
        Me.pnlKpiProspectos.Size = New System.Drawing.Size(752, 742)
        Me.pnlKpiProspectos.TabIndex = 25
        Me.pnlKpiProspectos.VerticalScrollbarBarColor = True
        Me.pnlKpiProspectos.VerticalScrollbarHighlightOnWheel = False
        Me.pnlKpiProspectos.VerticalScrollbarSize = 10
        '
        'TextBoxResultadosKpiProspectos
        '
        Me.TextBoxResultadosKpiProspectos.Location = New System.Drawing.Point(19, 164)
        Me.TextBoxResultadosKpiProspectos.Name = "TextBoxResultadosKpiProspectos"
        Me.TextBoxResultadosKpiProspectos.Size = New System.Drawing.Size(713, 259)
        Me.TextBoxResultadosKpiProspectos.TabIndex = 25
        Me.TextBoxResultadosKpiProspectos.Text = ""
        '
        'btnCancelarKpiProspecto
        '
        Me.btnCancelarKpiProspecto.Location = New System.Drawing.Point(267, 112)
        Me.btnCancelarKpiProspecto.Name = "btnCancelarKpiProspecto"
        Me.btnCancelarKpiProspecto.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarKpiProspecto.TabIndex = 24
        Me.btnCancelarKpiProspecto.Text = "Cancelar"
        Me.btnCancelarKpiProspecto.UseSelectable = True
        '
        'BtnGenerarKpiProspecto
        '
        Me.BtnGenerarKpiProspecto.Location = New System.Drawing.Point(151, 112)
        Me.BtnGenerarKpiProspecto.Name = "BtnGenerarKpiProspecto"
        Me.BtnGenerarKpiProspecto.Size = New System.Drawing.Size(97, 23)
        Me.BtnGenerarKpiProspecto.TabIndex = 23
        Me.BtnGenerarKpiProspecto.Text = "Generar"
        Me.BtnGenerarKpiProspecto.UseSelectable = True
        '
        'checkboxTotalProspetosCliente
        '
        Me.checkboxTotalProspetosCliente.AutoSize = True
        Me.checkboxTotalProspetosCliente.Location = New System.Drawing.Point(152, 60)
        Me.checkboxTotalProspetosCliente.Name = "checkboxTotalProspetosCliente"
        Me.checkboxTotalProspetosCliente.Size = New System.Drawing.Size(167, 15)
        Me.checkboxTotalProspetosCliente.TabIndex = 13
        Me.checkboxTotalProspetosCliente.Text = "Total de Prospectos Cliente"
        Me.checkboxTotalProspetosCliente.UseSelectable = True
        '
        'checkBoxTotalProspectos
        '
        Me.checkBoxTotalProspectos.AutoSize = True
        Me.checkBoxTotalProspectos.Location = New System.Drawing.Point(19, 60)
        Me.checkBoxTotalProspectos.Name = "checkBoxTotalProspectos"
        Me.checkBoxTotalProspectos.Size = New System.Drawing.Size(127, 15)
        Me.checkBoxTotalProspectos.TabIndex = 12
        Me.checkBoxTotalProspectos.Text = "Total de Prospectos"
        Me.checkBoxTotalProspectos.UseSelectable = True
        '
        'lblCrearKpiProspecto
        '
        Me.lblCrearKpiProspecto.AutoSize = True
        Me.lblCrearKpiProspecto.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCrearKpiProspecto.Location = New System.Drawing.Point(4, 9)
        Me.lblCrearKpiProspecto.Name = "lblCrearKpiProspecto"
        Me.lblCrearKpiProspecto.Size = New System.Drawing.Size(161, 25)
        Me.lblCrearKpiProspecto.TabIndex = 11
        Me.lblCrearKpiProspecto.Text = "Crear Kpi Prospecto"
        '
        'panKpiVentas
        '
        Me.panKpiVentas.Controls.Add(Me.TextBoxResultadosVentas)
        Me.panKpiVentas.Controls.Add(Me.btnCancelarKpiVenta)
        Me.panKpiVentas.Controls.Add(Me.btnCrearKpiVenta)
        Me.panKpiVentas.Controls.Add(Me.checkBoxMontoTotalVentas)
        Me.panKpiVentas.Controls.Add(Me.checkBoxTotalVentas)
        Me.panKpiVentas.Controls.Add(Me.crearKPIVentas)
        Me.panKpiVentas.HorizontalScrollbarBarColor = True
        Me.panKpiVentas.HorizontalScrollbarHighlightOnWheel = False
        Me.panKpiVentas.HorizontalScrollbarSize = 10
        Me.panKpiVentas.Location = New System.Drawing.Point(0, 0)
        Me.panKpiVentas.Name = "panKpiVentas"
        Me.panKpiVentas.Size = New System.Drawing.Size(752, 742)
        Me.panKpiVentas.TabIndex = 3
        Me.panKpiVentas.VerticalScrollbarBarColor = True
        Me.panKpiVentas.VerticalScrollbarHighlightOnWheel = False
        Me.panKpiVentas.VerticalScrollbarSize = 10
        '
        'TextBoxResultadosVentas
        '
        Me.TextBoxResultadosVentas.Location = New System.Drawing.Point(21, 208)
        Me.TextBoxResultadosVentas.Name = "TextBoxResultadosVentas"
        Me.TextBoxResultadosVentas.Size = New System.Drawing.Size(713, 259)
        Me.TextBoxResultadosVentas.TabIndex = 25
        Me.TextBoxResultadosVentas.Text = ""
        '
        'btnCancelarKpiVenta
        '
        Me.btnCancelarKpiVenta.Location = New System.Drawing.Point(303, 123)
        Me.btnCancelarKpiVenta.Name = "btnCancelarKpiVenta"
        Me.btnCancelarKpiVenta.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarKpiVenta.TabIndex = 24
        Me.btnCancelarKpiVenta.Text = "Cancelar"
        Me.btnCancelarKpiVenta.UseSelectable = True
        '
        'btnCrearKpiVenta
        '
        Me.btnCrearKpiVenta.Location = New System.Drawing.Point(200, 123)
        Me.btnCrearKpiVenta.Name = "btnCrearKpiVenta"
        Me.btnCrearKpiVenta.Size = New System.Drawing.Size(97, 23)
        Me.btnCrearKpiVenta.TabIndex = 23
        Me.btnCrearKpiVenta.Text = "Generar"
        Me.btnCrearKpiVenta.UseSelectable = True
        '
        'checkBoxMontoTotalVentas
        '
        Me.checkBoxMontoTotalVentas.AutoSize = True
        Me.checkBoxMontoTotalVentas.Location = New System.Drawing.Point(115, 69)
        Me.checkBoxMontoTotalVentas.Name = "checkBoxMontoTotalVentas"
        Me.checkBoxMontoTotalVentas.Size = New System.Drawing.Size(143, 15)
        Me.checkBoxMontoTotalVentas.TabIndex = 14
        Me.checkBoxMontoTotalVentas.Text = "Monto Total de Ventas"
        Me.checkBoxMontoTotalVentas.UseSelectable = True
        '
        'checkBoxTotalVentas
        '
        Me.checkBoxTotalVentas.AutoSize = True
        Me.checkBoxTotalVentas.Location = New System.Drawing.Point(21, 69)
        Me.checkBoxTotalVentas.Name = "checkBoxTotalVentas"
        Me.checkBoxTotalVentas.Size = New System.Drawing.Size(88, 15)
        Me.checkBoxTotalVentas.TabIndex = 12
        Me.checkBoxTotalVentas.Text = "Total Ventas"
        Me.checkBoxTotalVentas.UseSelectable = True
        '
        'crearKPIVentas
        '
        Me.crearKPIVentas.AutoSize = True
        Me.crearKPIVentas.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.crearKPIVentas.Location = New System.Drawing.Point(4, 9)
        Me.crearKPIVentas.Name = "crearKPIVentas"
        Me.crearKPIVentas.Size = New System.Drawing.Size(135, 25)
        Me.crearKPIVentas.TabIndex = 11
        Me.crearKPIVentas.Text = "Crear KPI Ventas"
        '
        'TabVentas
        '
        Me.TabVentas.Controls.Add(Me.listarVerntas_pnl)
        Me.TabVentas.Controls.Add(Me.RegistrarVentas_pnl)
        Me.TabVentas.Controls.Add(Me.consultarVentas_pnl)
        Me.TabVentas.Controls.Add(Me.tRegistrar)
        Me.TabVentas.Controls.Add(Me.tListaVentas)
        Me.TabVentas.Controls.Add(Me.tConsultarVenta)
        Me.TabVentas.HorizontalScrollbarBarColor = True
        Me.TabVentas.HorizontalScrollbarHighlightOnWheel = False
        Me.TabVentas.HorizontalScrollbarSize = 10
        Me.TabVentas.Location = New System.Drawing.Point(4, 44)
        Me.TabVentas.Name = "TabVentas"
        Me.TabVentas.Size = New System.Drawing.Size(752, 472)
        Me.TabVentas.TabIndex = 9
        Me.TabVentas.Text = "Ventas"
        Me.TabVentas.VerticalScrollbarBarColor = True
        Me.TabVentas.VerticalScrollbarHighlightOnWheel = False
        Me.TabVentas.VerticalScrollbarSize = 10
        '
        'listarVerntas_pnl
        '
        Me.listarVerntas_pnl.Controls.Add(Me.volverVenta_btn)
        Me.listarVerntas_pnl.Controls.Add(Me.MetroPanel2)
        Me.listarVerntas_pnl.Controls.Add(Me.MetroLabel6)
        Me.listarVerntas_pnl.Controls.Add(Me.listaVentas_dg)
        Me.listarVerntas_pnl.Controls.Add(Me.listarVentas_lbl)
        Me.listarVerntas_pnl.Controls.Add(Me.nuevaVenta_btn)
        Me.listarVerntas_pnl.HorizontalScrollbarBarColor = True
        Me.listarVerntas_pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.listarVerntas_pnl.HorizontalScrollbarSize = 10
        Me.listarVerntas_pnl.Location = New System.Drawing.Point(0, 3)
        Me.listarVerntas_pnl.Name = "listarVerntas_pnl"
        Me.listarVerntas_pnl.Size = New System.Drawing.Size(767, 461)
        Me.listarVerntas_pnl.Style = MetroFramework.MetroColorStyle.Blue
        Me.listarVerntas_pnl.TabIndex = 58
        Me.listarVerntas_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.listarVerntas_pnl.VerticalScrollbarBarColor = True
        Me.listarVerntas_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.listarVerntas_pnl.VerticalScrollbarSize = 10
        Me.listarVerntas_pnl.Visible = False
        '
        'volverVenta_btn
        '
        Me.volverVenta_btn.Location = New System.Drawing.Point(7, 412)
        Me.volverVenta_btn.Name = "volverVenta_btn"
        Me.volverVenta_btn.Size = New System.Drawing.Size(123, 36)
        Me.volverVenta_btn.TabIndex = 55
        Me.volverVenta_btn.Text = "Volver"
        Me.volverVenta_btn.UseSelectable = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.MetroButton1)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel2.Controls.Add(Me.DataGridView2)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(548, 431)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(0, 3)
        Me.MetroPanel2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroPanel2.TabIndex = 51
        Me.MetroPanel2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        Me.MetroPanel2.Visible = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(7, 412)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(123, 36)
        Me.MetroButton1.TabIndex = 50
        Me.MetroButton1.Text = "Volver"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(723, 7)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(20, 19)
        Me.MetroLabel4.TabIndex = 49
        Me.MetroLabel4.Text = "id"
        Me.MetroLabel4.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewImageColumn8})
        Me.DataGridView2.Location = New System.Drawing.Point(7, 37)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(739, 344)
        Me.DataGridView2.TabIndex = 12
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewImageColumn8
        '
        Me.DataGridViewImageColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn8.HeaderText = ""
        Me.DataGridViewImageColumn8.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.DataGridViewImageColumn8.Name = "DataGridViewImageColumn8"
        Me.DataGridViewImageColumn8.ReadOnly = True
        Me.DataGridViewImageColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(4, 9)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(107, 25)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Listar Cursos"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(723, 7)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(20, 19)
        Me.MetroLabel6.TabIndex = 49
        Me.MetroLabel6.Text = "id"
        Me.MetroLabel6.Visible = False
        '
        'listaVentas_dg
        '
        Me.listaVentas_dg.AllowUserToAddRows = False
        Me.listaVentas_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaVentas_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idVenta, Me.nombreUsuario, Me.FechaVenta, Me.totalVenta, Me.tipoVenta, Me.DataGridViewImageColumn9})
        Me.listaVentas_dg.Location = New System.Drawing.Point(7, 37)
        Me.listaVentas_dg.Name = "listaVentas_dg"
        Me.listaVentas_dg.RowHeadersVisible = False
        Me.listaVentas_dg.Size = New System.Drawing.Size(739, 344)
        Me.listaVentas_dg.TabIndex = 12
        '
        'idVenta
        '
        Me.idVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.idVenta.HeaderText = "ID"
        Me.idVenta.Name = "idVenta"
        Me.idVenta.ReadOnly = True
        Me.idVenta.Visible = False
        '
        'nombreUsuario
        '
        Me.nombreUsuario.HeaderText = "Nombre"
        Me.nombreUsuario.Name = "nombreUsuario"
        '
        'FechaVenta
        '
        Me.FechaVenta.HeaderText = "Fecha"
        Me.FechaVenta.Name = "FechaVenta"
        '
        'totalVenta
        '
        Me.totalVenta.HeaderText = "Venta Total"
        Me.totalVenta.Name = "totalVenta"
        '
        'tipoVenta
        '
        Me.tipoVenta.HeaderText = "Tipo"
        Me.tipoVenta.Name = "tipoVenta"
        '
        'DataGridViewImageColumn9
        '
        Me.DataGridViewImageColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn9.HeaderText = ""
        Me.DataGridViewImageColumn9.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.DataGridViewImageColumn9.Name = "DataGridViewImageColumn9"
        Me.DataGridViewImageColumn9.ReadOnly = True
        Me.DataGridViewImageColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'listarVentas_lbl
        '
        Me.listarVentas_lbl.AutoSize = True
        Me.listarVentas_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.listarVentas_lbl.Location = New System.Drawing.Point(3, 7)
        Me.listarVentas_lbl.Name = "listarVentas_lbl"
        Me.listarVentas_lbl.Size = New System.Drawing.Size(105, 25)
        Me.listarVentas_lbl.TabIndex = 10
        Me.listarVentas_lbl.Text = "Listar Ventas"
        '
        'nuevaVenta_btn
        '
        Me.nuevaVenta_btn.Location = New System.Drawing.Point(623, 412)
        Me.nuevaVenta_btn.Name = "nuevaVenta_btn"
        Me.nuevaVenta_btn.Size = New System.Drawing.Size(123, 36)
        Me.nuevaVenta_btn.TabIndex = 9
        Me.nuevaVenta_btn.Text = "Nueva Venta"
        Me.nuevaVenta_btn.UseSelectable = True
        '
        'RegistrarVentas_pnl
        '
        Me.RegistrarVentas_pnl.Controls.Add(Me.cancelarVenta_btn)
        Me.RegistrarVentas_pnl.Controls.Add(Me.guardarVenta_btn)
        Me.RegistrarVentas_pnl.Controls.Add(Me.tipo_prodVenta_cmb)
        Me.RegistrarVentas_pnl.Controls.Add(Me.cod_prod_cmb)
        Me.RegistrarVentas_pnl.Controls.Add(Me.codProdVentas_lbl)
        Me.RegistrarVentas_pnl.Controls.Add(Me.productos_cmb)
        Me.RegistrarVentas_pnl.Controls.Add(Me.fecha_lbl)
        Me.RegistrarVentas_pnl.Controls.Add(Me.matricula_text)
        Me.RegistrarVentas_pnl.Controls.Add(Me.totalVenta_text)
        Me.RegistrarVentas_pnl.Controls.Add(Me.totalVenta__lbl)
        Me.RegistrarVentas_pnl.Controls.Add(Me.cargoMatricula_lbl)
        Me.RegistrarVentas_pnl.Controls.Add(Me.costoVenta_text)
        Me.RegistrarVentas_pnl.Controls.Add(Me.tipoVenta_lbl)
        Me.RegistrarVentas_pnl.Controls.Add(Me.costoVenta_lbl)
        Me.RegistrarVentas_pnl.Controls.Add(Me.ventaProd_lbl)
        Me.RegistrarVentas_pnl.Controls.Add(Me.labelVentas_lbl)
        Me.RegistrarVentas_pnl.HorizontalScrollbarBarColor = True
        Me.RegistrarVentas_pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.RegistrarVentas_pnl.HorizontalScrollbarSize = 10
        Me.RegistrarVentas_pnl.Location = New System.Drawing.Point(0, 3)
        Me.RegistrarVentas_pnl.Name = "RegistrarVentas_pnl"
        Me.RegistrarVentas_pnl.Size = New System.Drawing.Size(746, 462)
        Me.RegistrarVentas_pnl.Style = MetroFramework.MetroColorStyle.Purple
        Me.RegistrarVentas_pnl.TabIndex = 58
        Me.RegistrarVentas_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.RegistrarVentas_pnl.VerticalScrollbarBarColor = True
        Me.RegistrarVentas_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.RegistrarVentas_pnl.VerticalScrollbarSize = 10
        Me.RegistrarVentas_pnl.Visible = False
        '
        'cancelarVenta_btn
        '
        Me.cancelarVenta_btn.Location = New System.Drawing.Point(426, 421)
        Me.cancelarVenta_btn.Name = "cancelarVenta_btn"
        Me.cancelarVenta_btn.Size = New System.Drawing.Size(97, 23)
        Me.cancelarVenta_btn.TabIndex = 89
        Me.cancelarVenta_btn.Text = "Cancelar"
        Me.cancelarVenta_btn.UseSelectable = True
        '
        'guardarVenta_btn
        '
        Me.guardarVenta_btn.Location = New System.Drawing.Point(323, 421)
        Me.guardarVenta_btn.Name = "guardarVenta_btn"
        Me.guardarVenta_btn.Size = New System.Drawing.Size(97, 23)
        Me.guardarVenta_btn.TabIndex = 88
        Me.guardarVenta_btn.Text = "Guardar"
        Me.guardarVenta_btn.UseSelectable = True
        '
        'tipo_prodVenta_cmb
        '
        Me.tipo_prodVenta_cmb.Enabled = False
        Me.tipo_prodVenta_cmb.FormattingEnabled = True
        Me.tipo_prodVenta_cmb.IntegralHeight = False
        Me.tipo_prodVenta_cmb.ItemHeight = 13
        Me.tipo_prodVenta_cmb.Location = New System.Drawing.Point(157, 119)
        Me.tipo_prodVenta_cmb.Name = "tipo_prodVenta_cmb"
        Me.tipo_prodVenta_cmb.Size = New System.Drawing.Size(194, 21)
        Me.tipo_prodVenta_cmb.TabIndex = 81
        '
        'cod_prod_cmb
        '
        Me.cod_prod_cmb.FormattingEnabled = True
        Me.cod_prod_cmb.IntegralHeight = False
        Me.cod_prod_cmb.ItemHeight = 13
        Me.cod_prod_cmb.Location = New System.Drawing.Point(157, 52)
        Me.cod_prod_cmb.Name = "cod_prod_cmb"
        Me.cod_prod_cmb.Size = New System.Drawing.Size(194, 21)
        Me.cod_prod_cmb.TabIndex = 73
        '
        'codProdVentas_lbl
        '
        Me.codProdVentas_lbl.AutoSize = True
        Me.codProdVentas_lbl.Location = New System.Drawing.Point(29, 52)
        Me.codProdVentas_lbl.Name = "codProdVentas_lbl"
        Me.codProdVentas_lbl.Size = New System.Drawing.Size(95, 19)
        Me.codProdVentas_lbl.TabIndex = 72
        Me.codProdVentas_lbl.Text = "Cod. Producto"
        '
        'productos_cmb
        '
        Me.productos_cmb.FormattingEnabled = True
        Me.productos_cmb.IntegralHeight = False
        Me.productos_cmb.ItemHeight = 13
        Me.productos_cmb.Location = New System.Drawing.Point(157, 85)
        Me.productos_cmb.Name = "productos_cmb"
        Me.productos_cmb.Size = New System.Drawing.Size(506, 21)
        Me.productos_cmb.TabIndex = 74
        '
        'fecha_lbl
        '
        Me.fecha_lbl.AutoSize = True
        Me.fecha_lbl.Location = New System.Drawing.Point(596, 15)
        Me.fecha_lbl.Name = "fecha_lbl"
        Me.fecha_lbl.Size = New System.Drawing.Size(0, 0)
        Me.fecha_lbl.TabIndex = 70
        '
        'matricula_text
        '
        '
        '
        '
        Me.matricula_text.CustomButton.Image = Nothing
        Me.matricula_text.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.matricula_text.CustomButton.Name = ""
        Me.matricula_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.matricula_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.matricula_text.CustomButton.TabIndex = 1
        Me.matricula_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.matricula_text.CustomButton.UseSelectable = True
        Me.matricula_text.CustomButton.Visible = False
        Me.matricula_text.Lines = New String(-1) {}
        Me.matricula_text.Location = New System.Drawing.Point(157, 151)
        Me.matricula_text.MaxLength = 8
        Me.matricula_text.Name = "matricula_text"
        Me.matricula_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.matricula_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.matricula_text.SelectedText = ""
        Me.matricula_text.SelectionLength = 0
        Me.matricula_text.SelectionStart = 0
        Me.matricula_text.Size = New System.Drawing.Size(194, 23)
        Me.matricula_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.matricula_text.TabIndex = 77
        Me.matricula_text.UseSelectable = True
        Me.matricula_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.matricula_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'totalVenta_text
        '
        '
        '
        '
        Me.totalVenta_text.CustomButton.Image = Nothing
        Me.totalVenta_text.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.totalVenta_text.CustomButton.Name = ""
        Me.totalVenta_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.totalVenta_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.totalVenta_text.CustomButton.TabIndex = 1
        Me.totalVenta_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.totalVenta_text.CustomButton.UseSelectable = True
        Me.totalVenta_text.CustomButton.Visible = False
        Me.totalVenta_text.Enabled = False
        Me.totalVenta_text.Lines = New String(-1) {}
        Me.totalVenta_text.Location = New System.Drawing.Point(469, 151)
        Me.totalVenta_text.MaxLength = 32767
        Me.totalVenta_text.Name = "totalVenta_text"
        Me.totalVenta_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalVenta_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.totalVenta_text.SelectedText = ""
        Me.totalVenta_text.SelectionLength = 0
        Me.totalVenta_text.SelectionStart = 0
        Me.totalVenta_text.Size = New System.Drawing.Size(194, 23)
        Me.totalVenta_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.totalVenta_text.TabIndex = 78
        Me.totalVenta_text.UseSelectable = True
        Me.totalVenta_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.totalVenta_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'totalVenta__lbl
        '
        Me.totalVenta__lbl.AutoSize = True
        Me.totalVenta__lbl.Location = New System.Drawing.Point(405, 151)
        Me.totalVenta__lbl.Name = "totalVenta__lbl"
        Me.totalVenta__lbl.Size = New System.Drawing.Size(36, 19)
        Me.totalVenta__lbl.TabIndex = 67
        Me.totalVenta__lbl.Text = "Total"
        '
        'cargoMatricula_lbl
        '
        Me.cargoMatricula_lbl.AutoSize = True
        Me.cargoMatricula_lbl.Location = New System.Drawing.Point(29, 151)
        Me.cargoMatricula_lbl.Name = "cargoMatricula_lbl"
        Me.cargoMatricula_lbl.Size = New System.Drawing.Size(63, 19)
        Me.cargoMatricula_lbl.TabIndex = 66
        Me.cargoMatricula_lbl.Text = "Matricula"
        '
        'costoVenta_text
        '
        '
        '
        '
        Me.costoVenta_text.CustomButton.Image = Nothing
        Me.costoVenta_text.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.costoVenta_text.CustomButton.Name = ""
        Me.costoVenta_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.costoVenta_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.costoVenta_text.CustomButton.TabIndex = 1
        Me.costoVenta_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.costoVenta_text.CustomButton.UseSelectable = True
        Me.costoVenta_text.CustomButton.Visible = False
        Me.costoVenta_text.Enabled = False
        Me.costoVenta_text.Lines = New String(-1) {}
        Me.costoVenta_text.Location = New System.Drawing.Point(469, 119)
        Me.costoVenta_text.MaxLength = 32767
        Me.costoVenta_text.Name = "costoVenta_text"
        Me.costoVenta_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.costoVenta_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.costoVenta_text.SelectedText = ""
        Me.costoVenta_text.SelectionLength = 0
        Me.costoVenta_text.SelectionStart = 0
        Me.costoVenta_text.Size = New System.Drawing.Size(194, 23)
        Me.costoVenta_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.costoVenta_text.TabIndex = 76
        Me.costoVenta_text.UseSelectable = True
        Me.costoVenta_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.costoVenta_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tipoVenta_lbl
        '
        Me.tipoVenta_lbl.AutoSize = True
        Me.tipoVenta_lbl.Location = New System.Drawing.Point(29, 119)
        Me.tipoVenta_lbl.Name = "tipoVenta_lbl"
        Me.tipoVenta_lbl.Size = New System.Drawing.Size(35, 19)
        Me.tipoVenta_lbl.TabIndex = 13
        Me.tipoVenta_lbl.Text = "Tipo"
        '
        'costoVenta_lbl
        '
        Me.costoVenta_lbl.AutoSize = True
        Me.costoVenta_lbl.Location = New System.Drawing.Point(401, 119)
        Me.costoVenta_lbl.Name = "costoVenta_lbl"
        Me.costoVenta_lbl.Size = New System.Drawing.Size(43, 19)
        Me.costoVenta_lbl.TabIndex = 12
        Me.costoVenta_lbl.Text = "Costo"
        '
        'ventaProd_lbl
        '
        Me.ventaProd_lbl.AutoSize = True
        Me.ventaProd_lbl.Location = New System.Drawing.Point(29, 85)
        Me.ventaProd_lbl.Name = "ventaProd_lbl"
        Me.ventaProd_lbl.Size = New System.Drawing.Size(63, 19)
        Me.ventaProd_lbl.TabIndex = 11
        Me.ventaProd_lbl.Text = "Producto"
        '
        'labelVentas_lbl
        '
        Me.labelVentas_lbl.AutoSize = True
        Me.labelVentas_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.labelVentas_lbl.Location = New System.Drawing.Point(4, 9)
        Me.labelVentas_lbl.Name = "labelVentas_lbl"
        Me.labelVentas_lbl.Size = New System.Drawing.Size(125, 25)
        Me.labelVentas_lbl.TabIndex = 10
        Me.labelVentas_lbl.Text = "Registrar Venta"
        '
        'consultarVentas_pnl
        '
        Me.consultarVentas_pnl.Controls.Add(Me.ingresosConsulta_pnl)
        Me.consultarVentas_pnl.Controls.Add(Me.periodos_cmb)
        Me.consultarVentas_pnl.Controls.Add(Me.volverConsulta)
        Me.consultarVentas_pnl.Controls.Add(Me.usuarioConsulta_cmb)
        Me.consultarVentas_pnl.Controls.Add(Me.userQueryLabel)
        Me.consultarVentas_pnl.Controls.Add(Me.periodoQuery_lbl)
        Me.consultarVentas_pnl.Controls.Add(Me.consultarVentas_lbl)
        Me.consultarVentas_pnl.Controls.Add(Me.ventas_grp)
        Me.consultarVentas_pnl.HorizontalScrollbarBarColor = True
        Me.consultarVentas_pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.consultarVentas_pnl.HorizontalScrollbarSize = 10
        Me.consultarVentas_pnl.Location = New System.Drawing.Point(0, 3)
        Me.consultarVentas_pnl.Name = "consultarVentas_pnl"
        Me.consultarVentas_pnl.Size = New System.Drawing.Size(746, 462)
        Me.consultarVentas_pnl.Style = MetroFramework.MetroColorStyle.Purple
        Me.consultarVentas_pnl.TabIndex = 86
        Me.consultarVentas_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.consultarVentas_pnl.VerticalScrollbarBarColor = True
        Me.consultarVentas_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.consultarVentas_pnl.VerticalScrollbarSize = 10
        Me.consultarVentas_pnl.Visible = False
        '
        'ingresosConsulta_pnl
        '
        Me.ingresosConsulta_pnl.BackColor = System.Drawing.SystemColors.Window
        Me.ingresosConsulta_pnl.Controls.Add(Me.ingresosConsulta_dg)
        Me.ingresosConsulta_pnl.Controls.Add(Me.MetroLabel7)
        Me.ingresosConsulta_pnl.Location = New System.Drawing.Point(31, 257)
        Me.ingresosConsulta_pnl.Name = "ingresosConsulta_pnl"
        Me.ingresosConsulta_pnl.Size = New System.Drawing.Size(678, 124)
        Me.ingresosConsulta_pnl.TabIndex = 81
        Me.ingresosConsulta_pnl.TabStop = False
        '
        'ingresosConsulta_dg
        '
        Me.ingresosConsulta_dg.AllowUserToAddRows = False
        Me.ingresosConsulta_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ingresosConsulta_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn33, Me.nombreConsultaIngresos, Me.TotalIngresos, Me.periodoConsultaIngresos, Me.DataGridViewImageColumn11})
        Me.ingresosConsulta_dg.Location = New System.Drawing.Point(13, 16)
        Me.ingresosConsulta_dg.Name = "ingresosConsulta_dg"
        Me.ingresosConsulta_dg.RowHeadersVisible = False
        Me.ingresosConsulta_dg.Size = New System.Drawing.Size(651, 99)
        Me.ingresosConsulta_dg.TabIndex = 39
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn33.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Visible = False
        '
        'nombreConsultaIngresos
        '
        Me.nombreConsultaIngresos.FillWeight = 200.0!
        Me.nombreConsultaIngresos.HeaderText = "Nombre Usuario"
        Me.nombreConsultaIngresos.Name = "nombreConsultaIngresos"
        Me.nombreConsultaIngresos.Width = 200
        '
        'TotalIngresos
        '
        Me.TotalIngresos.HeaderText = "Total Ingresos"
        Me.TotalIngresos.Name = "TotalIngresos"
        '
        'periodoConsultaIngresos
        '
        Me.periodoConsultaIngresos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.periodoConsultaIngresos.HeaderText = "Periodo"
        Me.periodoConsultaIngresos.Name = "periodoConsultaIngresos"
        '
        'DataGridViewImageColumn11
        '
        Me.DataGridViewImageColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn11.HeaderText = ""
        Me.DataGridViewImageColumn11.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.DataGridViewImageColumn11.Name = "DataGridViewImageColumn11"
        Me.DataGridViewImageColumn11.ReadOnly = True
        Me.DataGridViewImageColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(0, -5)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(122, 19)
        Me.MetroLabel7.TabIndex = 38
        Me.MetroLabel7.Text = "Cantidad de Ventas"
        '
        'periodos_cmb
        '
        Me.periodos_cmb.FormattingEnabled = True
        Me.periodos_cmb.ItemHeight = 13
        Me.periodos_cmb.Location = New System.Drawing.Point(448, 55)
        Me.periodos_cmb.Name = "periodos_cmb"
        Me.periodos_cmb.Size = New System.Drawing.Size(148, 21)
        Me.periodos_cmb.TabIndex = 80
        '
        'volverConsulta
        '
        Me.volverConsulta.Location = New System.Drawing.Point(623, 412)
        Me.volverConsulta.Name = "volverConsulta"
        Me.volverConsulta.Size = New System.Drawing.Size(123, 36)
        Me.volverConsulta.TabIndex = 79
        Me.volverConsulta.Text = "Volver"
        Me.volverConsulta.UseSelectable = True
        '
        'usuarioConsulta_cmb
        '
        Me.usuarioConsulta_cmb.FormattingEnabled = True
        Me.usuarioConsulta_cmb.ItemHeight = 13
        Me.usuarioConsulta_cmb.Location = New System.Drawing.Point(90, 55)
        Me.usuarioConsulta_cmb.Name = "usuarioConsulta_cmb"
        Me.usuarioConsulta_cmb.Size = New System.Drawing.Size(148, 21)
        Me.usuarioConsulta_cmb.TabIndex = 27
        '
        'userQueryLabel
        '
        Me.userQueryLabel.AutoSize = True
        Me.userQueryLabel.Location = New System.Drawing.Point(31, 55)
        Me.userQueryLabel.Name = "userQueryLabel"
        Me.userQueryLabel.Size = New System.Drawing.Size(53, 19)
        Me.userQueryLabel.TabIndex = 14
        Me.userQueryLabel.Text = "Usuario"
        '
        'periodoQuery_lbl
        '
        Me.periodoQuery_lbl.AutoSize = True
        Me.periodoQuery_lbl.Location = New System.Drawing.Point(387, 55)
        Me.periodoQuery_lbl.Name = "periodoQuery_lbl"
        Me.periodoQuery_lbl.Size = New System.Drawing.Size(55, 19)
        Me.periodoQuery_lbl.TabIndex = 11
        Me.periodoQuery_lbl.Text = "Periodo"
        '
        'consultarVentas_lbl
        '
        Me.consultarVentas_lbl.AutoSize = True
        Me.consultarVentas_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.consultarVentas_lbl.Location = New System.Drawing.Point(4, 9)
        Me.consultarVentas_lbl.Name = "consultarVentas_lbl"
        Me.consultarVentas_lbl.Size = New System.Drawing.Size(138, 25)
        Me.consultarVentas_lbl.TabIndex = 10
        Me.consultarVentas_lbl.Text = "Consultar Ventas"
        '
        'ventas_grp
        '
        Me.ventas_grp.BackColor = System.Drawing.SystemColors.Window
        Me.ventas_grp.Controls.Add(Me.ventasConsulta_dg)
        Me.ventas_grp.Controls.Add(Me.cantidadVentas_lbl)
        Me.ventas_grp.Location = New System.Drawing.Point(31, 113)
        Me.ventas_grp.Name = "ventas_grp"
        Me.ventas_grp.Size = New System.Drawing.Size(678, 124)
        Me.ventas_grp.TabIndex = 77
        Me.ventas_grp.TabStop = False
        '
        'ventasConsulta_dg
        '
        Me.ventasConsulta_dg.AllowUserToAddRows = False
        Me.ventasConsulta_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ventasConsulta_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.nombreUsuarioConsulta, Me.ventasConsulta, Me.PeriodoConsulta, Me.DataGridViewImageColumn10})
        Me.ventasConsulta_dg.Location = New System.Drawing.Point(13, 16)
        Me.ventasConsulta_dg.Name = "ventasConsulta_dg"
        Me.ventasConsulta_dg.RowHeadersVisible = False
        Me.ventasConsulta_dg.Size = New System.Drawing.Size(651, 99)
        Me.ventasConsulta_dg.TabIndex = 39
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn28.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'nombreUsuarioConsulta
        '
        Me.nombreUsuarioConsulta.FillWeight = 200.0!
        Me.nombreUsuarioConsulta.HeaderText = "Nombre usuario"
        Me.nombreUsuarioConsulta.Name = "nombreUsuarioConsulta"
        Me.nombreUsuarioConsulta.Width = 200
        '
        'ventasConsulta
        '
        Me.ventasConsulta.HeaderText = "Cantidad de Ventas"
        Me.ventasConsulta.Name = "ventasConsulta"
        Me.ventasConsulta.Width = 150
        '
        'PeriodoConsulta
        '
        Me.PeriodoConsulta.HeaderText = "Periodo"
        Me.PeriodoConsulta.Name = "PeriodoConsulta"
        '
        'DataGridViewImageColumn10
        '
        Me.DataGridViewImageColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn10.HeaderText = ""
        Me.DataGridViewImageColumn10.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.DataGridViewImageColumn10.Name = "DataGridViewImageColumn10"
        Me.DataGridViewImageColumn10.ReadOnly = True
        Me.DataGridViewImageColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'cantidadVentas_lbl
        '
        Me.cantidadVentas_lbl.AutoSize = True
        Me.cantidadVentas_lbl.Location = New System.Drawing.Point(0, -5)
        Me.cantidadVentas_lbl.Name = "cantidadVentas_lbl"
        Me.cantidadVentas_lbl.Size = New System.Drawing.Size(122, 19)
        Me.cantidadVentas_lbl.TabIndex = 38
        Me.cantidadVentas_lbl.Text = "Cantidad de Ventas"
        '
        'tRegistrar
        '
        Me.tRegistrar.ActiveControl = Nothing
        Me.tRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tRegistrar.Location = New System.Drawing.Point(307, 27)
        Me.tRegistrar.Name = "tRegistrar"
        Me.tRegistrar.Size = New System.Drawing.Size(124, 119)
        Me.tRegistrar.Style = MetroFramework.MetroColorStyle.Purple
        Me.tRegistrar.TabIndex = 57
        Me.tRegistrar.Text = "Registrar Venta"
        Me.tRegistrar.UseSelectable = True
        '
        'tListaVentas
        '
        Me.tListaVentas.ActiveControl = Nothing
        Me.tListaVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tListaVentas.Location = New System.Drawing.Point(24, 27)
        Me.tListaVentas.Name = "tListaVentas"
        Me.tListaVentas.Size = New System.Drawing.Size(124, 119)
        Me.tListaVentas.Style = MetroFramework.MetroColorStyle.Purple
        Me.tListaVentas.TabIndex = 55
        Me.tListaVentas.Text = "Listar"
        Me.tListaVentas.UseSelectable = True
        '
        'tConsultarVenta
        '
        Me.tConsultarVenta.ActiveControl = Nothing
        Me.tConsultarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tConsultarVenta.Location = New System.Drawing.Point(166, 27)
        Me.tConsultarVenta.Name = "tConsultarVenta"
        Me.tConsultarVenta.Size = New System.Drawing.Size(124, 119)
        Me.tConsultarVenta.Style = MetroFramework.MetroColorStyle.Purple
        Me.tConsultarVenta.TabIndex = 56
        Me.tConsultarVenta.Text = "Consultar"
        Me.tConsultarVenta.UseSelectable = True
        '
        'TabConfiguracion
        '
        Me.TabConfiguracion.HorizontalScrollbarBarColor = True
        Me.TabConfiguracion.HorizontalScrollbarHighlightOnWheel = False
        Me.TabConfiguracion.HorizontalScrollbarSize = 10
        Me.TabConfiguracion.Location = New System.Drawing.Point(4, 44)
        Me.TabConfiguracion.Name = "TabConfiguracion"
        Me.TabConfiguracion.Size = New System.Drawing.Size(752, 472)
        Me.TabConfiguracion.Style = MetroFramework.MetroColorStyle.Silver
        Me.TabConfiguracion.TabIndex = 8
        Me.TabConfiguracion.Text = "Configuración"
        Me.TabConfiguracion.VerticalScrollbarBarColor = True
        Me.TabConfiguracion.VerticalScrollbarHighlightOnWheel = False
        Me.TabConfiguracion.VerticalScrollbarSize = 10
        '
        'TabUsuarios
        '
        Me.TabUsuarios.HorizontalScrollbarBarColor = True
        Me.TabUsuarios.HorizontalScrollbarHighlightOnWheel = False
        Me.TabUsuarios.HorizontalScrollbarSize = 10
        Me.TabUsuarios.Location = New System.Drawing.Point(4, 44)
        Me.TabUsuarios.Name = "TabUsuarios"
        Me.TabUsuarios.Size = New System.Drawing.Size(752, 472)
        Me.TabUsuarios.TabIndex = 2
        Me.TabUsuarios.Text = "Usuarios"
        Me.TabUsuarios.VerticalScrollbarBarColor = True
        Me.TabUsuarios.VerticalScrollbarHighlightOnWheel = False
        Me.TabUsuarios.VerticalScrollbarSize = 10
        '
        'TabReportes
        '
        Me.TabReportes.HorizontalScrollbarBarColor = True
        Me.TabReportes.HorizontalScrollbarHighlightOnWheel = False
        Me.TabReportes.HorizontalScrollbarSize = 10
        Me.TabReportes.Location = New System.Drawing.Point(4, 44)
        Me.TabReportes.Name = "TabReportes"
        Me.TabReportes.Size = New System.Drawing.Size(752, 472)
        Me.TabReportes.TabIndex = 5
        Me.TabReportes.Text = "Reportes"
        Me.TabReportes.VerticalScrollbarBarColor = True
        Me.TabReportes.VerticalScrollbarHighlightOnWheel = False
        Me.TabReportes.VerticalScrollbarSize = 10
        '
        'cboUsuario
        '
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.ItemHeight = 23
        Me.cboUsuario.Items.AddRange(New Object() {"Usuario", "Cerrar sesion", "Salir del sistema"})
        Me.cboUsuario.Location = New System.Drawing.Point(601, 28)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(179, 29)
        Me.cboUsuario.TabIndex = 5
        Me.cboUsuario.UseSelectable = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'checkBoxTopProduto
        '
        Me.checkBoxTopProduto.AutoSize = True
        Me.checkBoxTopProduto.Location = New System.Drawing.Point(123, 62)
        Me.checkBoxTopProduto.Name = "checkBoxTopProduto"
        Me.checkBoxTopProduto.Size = New System.Drawing.Size(96, 15)
        Me.checkBoxTopProduto.TabIndex = 13
        Me.checkBoxTopProduto.Text = "Top Producto"
        Me.checkBoxTopProduto.UseSelectable = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.Main)
        Me.Name = "FrmMain"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Menu Principal"
        Me.Main.ResumeLayout(False)
        Me.TabProductos.ResumeLayout(False)
        Me.Eventos.ResumeLayout(False)
        Me.PanelListarEventos.ResumeLayout(False)
        Me.PanelListarEventos.PerformLayout()
        CType(Me.DataListarEventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCrearEvento.ResumeLayout(False)
        Me.PanelCrearEvento.PerformLayout()
        Me.TabProspectos.ResumeLayout(False)
        Me.PnlListaProspectos.ResumeLayout(False)
        Me.PnlListaProspectos.PerformLayout()
        CType(Me.lstProspectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlNuevoProspecto.ResumeLayout(False)
        Me.PnlNuevoProspecto.PerformLayout()
        Me.KPIHolder.ResumeLayout(False)
        Me.panSeleccionarTipoKPI.ResumeLayout(False)
        Me.pnlCrearKpiProducto.ResumeLayout(False)
        Me.pnlCrearKpiProducto.PerformLayout()
        Me.pnlKpiProspectos.ResumeLayout(False)
        Me.pnlKpiProspectos.PerformLayout()
        Me.panKpiVentas.ResumeLayout(False)
        Me.panKpiVentas.PerformLayout()
        Me.TabVentas.ResumeLayout(False)
        Me.listarVerntas_pnl.ResumeLayout(False)
        Me.listarVerntas_pnl.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaVentas_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistrarVentas_pnl.ResumeLayout(False)
        Me.RegistrarVentas_pnl.PerformLayout()
        Me.consultarVentas_pnl.ResumeLayout(False)
        Me.consultarVentas_pnl.PerformLayout()
        Me.ingresosConsulta_pnl.ResumeLayout(False)
        Me.ingresosConsulta_pnl.PerformLayout()
        CType(Me.ingresosConsulta_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ventas_grp.ResumeLayout(False)
        Me.ventas_grp.PerformLayout()
        CType(Me.ventasConsulta_dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Main As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabProductos As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnCarrerasIcon As MetroFramework.Controls.MetroTile
    Friend WithEvents TabUsuarios As MetroFramework.Controls.MetroTabPage
    Friend WithEvents KPIHolder As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabReportes As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabProspectos As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Eventos As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabConfiguracion As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnActiIco As MetroFramework.Controls.MetroTile
    Friend WithEvents cboUsuario As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TabVentas As MetroFramework.Controls.MetroTabPage
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PanelCrearEvento As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblFechaInicio As MetroFramework.Controls.MetroLabel
    Friend WithEvents dateEventos As MetroFramework.Controls.MetroDateTime
    Friend WithEvents TxtnombreEventos As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblLugar As MetroFramework.Controls.MetroLabel
    Friend WithEvents EventosLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents PanelListarEventos As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblEventos As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataListarEventos As System.Windows.Forms.DataGridView
    Friend WithEvents btnCrearEvento As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelarEvento As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarEvento As MetroFramework.Controls.MetroButton
    Friend WithEvents dateFin As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblFechaFin As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents panSeleccionarTipoKPI As MetroFramework.Controls.MetroPanel
    Friend WithEvents TileKpiVentas As MetroFramework.Controls.MetroTile
    Friend WithEvents TileKpiProductos As MetroFramework.Controls.MetroTile
    Friend WithEvents TileKpiProspecto As MetroFramework.Controls.MetroTile
    Friend WithEvents panKpiVentas As MetroFramework.Controls.MetroPanel
    Friend WithEvents checkBoxTotalVentas As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents crearKPIVentas As MetroFramework.Controls.MetroLabel
    Friend WithEvents checkBoxMontoTotalVentas As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEvento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents editar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnCrearKpiVenta As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelarKpiVenta As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlKpiProspectos As MetroFramework.Controls.MetroPanel
    Friend WithEvents checkboxTotalProspetosCliente As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents checkBoxTotalProspectos As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lblCrearKpiProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancelarKpiProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents BtnGenerarKpiProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlCrearKpiProducto As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblCrearKpiProducto As MetroFramework.Controls.MetroLabel
    Friend WithEvents checkBoxTotalProducto As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents btnCancelarKpiProducto As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCrearKpiProducto As MetroFramework.Controls.MetroButton
    Friend WithEvents TextBoxResultadoKpiProductos As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBoxResultadosVentas As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBoxResultadosKpiProspectos As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents checkBoxTopProduto As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PnlListaProspectos As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnAsignarProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents lblListaProspectos As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCrearProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents lstProspectos As System.Windows.Forms.DataGridView
    Friend WithEvents ColumnaIDProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaNombreProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaApellidosProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaNacimientoProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaProcedenciaProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaTelefonoProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaEmailProspecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaEditarProspecto As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PnlNuevoProspecto As MetroFramework.Controls.MetroPanel
    Friend WithEvents cbEventos As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ckbEventoProspecto As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lblInteres As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbInteresesProspecto As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnListarSeguimientos As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNuevoSeguimiento As MetroFramework.Controls.MetroButton
    Friend WithEvents txtFechaNacProspecto As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDireccionProspecto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtProcedenciaProspecto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelProspecto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEmailProspecto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtApellidosProspecto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombreProspecto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelarProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents tglEstaInteresado As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblInteresadoProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProcedenciaProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDireccionProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents tglEstadoProspecto As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblTelefonoProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEstadoProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblApellidosProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblFechaProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCorreoProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNombreProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCrearProspectos As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblClienteProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents tglEsCliente As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblIdSeguimiento As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblIdProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents tRegistrar As MetroFramework.Controls.MetroTile
    Friend WithEvents tListaVentas As MetroFramework.Controls.MetroTile
    Friend WithEvents tConsultarVenta As MetroFramework.Controls.MetroTile
    Friend WithEvents listarVerntas_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents volverVenta_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn8 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaVentas_dg As System.Windows.Forms.DataGridView
    Friend WithEvents idVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn9 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents listarVentas_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents nuevaVenta_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents RegistrarVentas_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents cancelarVenta_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents guardarVenta_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents tipo_prodVenta_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents cod_prod_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents codProdVentas_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents productos_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents fecha_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents matricula_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents totalVenta_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents totalVenta__lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents cargoMatricula_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents costoVenta_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tipoVenta_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents costoVenta_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents ventaProd_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents labelVentas_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents consultarVentas_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents ingresosConsulta_pnl As System.Windows.Forms.GroupBox
    Friend WithEvents ingresosConsulta_dg As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreConsultaIngresos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalIngresos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents periodoConsultaIngresos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn11 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents periodos_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents volverConsulta As MetroFramework.Controls.MetroButton
    Friend WithEvents usuarioConsulta_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents userQueryLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents periodoQuery_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents consultarVentas_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents ventas_grp As System.Windows.Forms.GroupBox
    Friend WithEvents ventasConsulta_dg As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreUsuarioConsulta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ventasConsulta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodoConsulta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn10 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cantidadVentas_lbl As MetroFramework.Controls.MetroLabel
End Class
