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
        Me.TabConfiguracion = New MetroFramework.Controls.MetroTabPage()
        Me.TabVentas = New MetroFramework.Controls.MetroTabPage()
        Me.TabUsuarios = New MetroFramework.Controls.MetroTabPage()
        Me.TabReportes = New MetroFramework.Controls.MetroTabPage()
        Me.cboUsuario = New MetroFramework.Controls.MetroComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.checkBoxTopProduto = New MetroFramework.Controls.MetroCheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.listaCarreras_pnl = New MetroFramework.Controls.MetroPanel()
        Me.listaCursos_pnl = New MetroFramework.Controls.MetroPanel()
        Me.listaCursosVolver_btn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.listaCursos_dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.listaCursos_lbl = New MetroFramework.Controls.MetroLabel()
        Me.listaCarrerasVolver_btn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.listaCarreras_dg = New System.Windows.Forms.DataGridView()
        Me.idCarrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCarrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoCarrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoCarrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.carreras_lbl = New MetroFramework.Controls.MetroLabel()
        Me.nuevaCarrera_btn = New MetroFramework.Controls.MetroButton()
        Me.exportarCarreras_btn = New MetroFramework.Controls.MetroButton()
        Me.registrarCarrera_pnl = New MetroFramework.Controls.MetroPanel()
        Me.ImportarCarreras_cmb = New MetroFramework.Controls.MetroLink()
        Me.guardarCarrera_btn = New MetroFramework.Controls.MetroButton()
        Me.cancelarCarrera_btn = New MetroFramework.Controls.MetroButton()
        Me.min2_lbl = New MetroFramework.Controls.MetroLabel()
        Me.hora2_lbl = New MetroFramework.Controls.MetroLabel()
        Me.minsFin5_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.minsFin4_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.minsFin3_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.minsFin2_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.minsFin1_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.horaFin5_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.horaFin4_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.horaFin3_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.horaFin2_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.horaFin1_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.min1_lbl = New MetroFramework.Controls.MetroLabel()
        Me.hora1_lbl = New MetroFramework.Controls.MetroLabel()
        Me.minsIni5_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.minsIni4_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.minsIni3_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.minsIni2_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.minsIni1_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.horaIni5_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.horaIni4_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.horaIni3_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.horaIni2_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.horaIni1_nmbr = New System.Windows.Forms.NumericUpDown()
        Me.dia5_cmb = New System.Windows.Forms.ComboBox()
        Me.dia4_cmb = New System.Windows.Forms.ComboBox()
        Me.dia3_cmb = New System.Windows.Forms.ComboBox()
        Me.dia2_cmb = New System.Windows.Forms.ComboBox()
        Me.dia1_cmb = New System.Windows.Forms.ComboBox()
        Me.horaFin_lbl = New MetroFramework.Controls.MetroLabel()
        Me.horaIni_lbl = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel35 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel36 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel37 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel38 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel39 = New MetroFramework.Controls.MetroLabel()
        Me.tipoCarrera_cmb = New System.Windows.Forms.ComboBox()
        Me.costoCarrera_text = New MetroFramework.Controls.MetroTextBox()
        Me.nombreCarrera_text = New MetroFramework.Controls.MetroTextBox()
        Me.codigoCarrera_text = New MetroFramework.Controls.MetroTextBox()
        Me.carreraNombre_lbl = New MetroFramework.Controls.MetroLabel()
        Me.tipoCarrera_lbl = New MetroFramework.Controls.MetroLabel()
        Me.costoCarrera_lbl = New MetroFramework.Controls.MetroLabel()
        Me.carreraCodigo_lbl = New MetroFramework.Controls.MetroLabel()
        Me.registrarCarrera_lbl = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.horarioCarrera = New System.Windows.Forms.GroupBox()
        Me.horario_lbl = New MetroFramework.Controls.MetroLabel()
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
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.listaCarreras_pnl.SuspendLayout()
        Me.listaCursos_pnl.SuspendLayout()
        CType(Me.listaCursos_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaCarreras_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.registrarCarrera_pnl.SuspendLayout()
        CType(Me.minsFin5_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsFin4_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsFin3_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsFin2_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsFin1_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin5_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin4_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin3_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin2_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin1_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni5_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni4_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni3_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni2_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni1_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni5_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni4_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni3_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni2_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni1_nmbr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.horarioCarrera.SuspendLayout()
        Me.SuspendLayout()
        '
        'Main
        '
        Me.Main.Controls.Add(Me.TabProductos)
        Me.Main.Controls.Add(Me.Eventos)
        Me.Main.Controls.Add(Me.TabProspectos)
        Me.Main.Controls.Add(Me.KPIHolder)
        Me.Main.Controls.Add(Me.TabConfiguracion)
        Me.Main.Controls.Add(Me.TabVentas)
        Me.Main.Controls.Add(Me.TabUsuarios)
        Me.Main.Controls.Add(Me.TabReportes)
        Me.Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.Main.Location = New System.Drawing.Point(20, 60)
        Me.Main.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Main.Name = "Main"
        Me.Main.SelectedIndex = 0
        Me.Main.Size = New System.Drawing.Size(760, 520)
        Me.Main.Style = MetroFramework.MetroColorStyle.Purple
        Me.Main.TabIndex = 1
        Me.Main.UseSelectable = True
        '
        'TabProductos
        '
        Me.TabProductos.Controls.Add(Me.registrarCarrera_pnl)
        Me.TabProductos.Controls.Add(Me.listaCarreras_pnl)
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
        Me.btnActiIco.Visible = False
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
        Me.btnCarrerasIcon.Visible = False
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
        'TabVentas
        '
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
        'listaCarreras_pnl
        '
        Me.listaCarreras_pnl.Controls.Add(Me.listaCursos_pnl)
        Me.listaCarreras_pnl.Controls.Add(Me.listaCarrerasVolver_btn)
        Me.listaCarreras_pnl.Controls.Add(Me.MetroLabel17)
        Me.listaCarreras_pnl.Controls.Add(Me.listaCarreras_dg)
        Me.listaCarreras_pnl.Controls.Add(Me.carreras_lbl)
        Me.listaCarreras_pnl.Controls.Add(Me.nuevaCarrera_btn)
        Me.listaCarreras_pnl.Controls.Add(Me.exportarCarreras_btn)
        Me.listaCarreras_pnl.HorizontalScrollbarBarColor = True
        Me.listaCarreras_pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.listaCarreras_pnl.HorizontalScrollbarSize = 10
        Me.listaCarreras_pnl.Location = New System.Drawing.Point(0, 3)
        Me.listaCarreras_pnl.Name = "listaCarreras_pnl"
        Me.listaCarreras_pnl.Size = New System.Drawing.Size(767, 461)
        Me.listaCarreras_pnl.Style = MetroFramework.MetroColorStyle.Blue
        Me.listaCarreras_pnl.TabIndex = 86
        Me.listaCarreras_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.listaCarreras_pnl.VerticalScrollbarBarColor = True
        Me.listaCarreras_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.listaCarreras_pnl.VerticalScrollbarSize = 10
        Me.listaCarreras_pnl.Visible = False
        '
        'listaCursos_pnl
        '
        Me.listaCursos_pnl.Controls.Add(Me.listaCursosVolver_btn)
        Me.listaCursos_pnl.Controls.Add(Me.MetroLabel2)
        Me.listaCursos_pnl.Controls.Add(Me.listaCursos_dg)
        Me.listaCursos_pnl.Controls.Add(Me.listaCursos_lbl)
        Me.listaCursos_pnl.HorizontalScrollbarBarColor = True
        Me.listaCursos_pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.listaCursos_pnl.HorizontalScrollbarSize = 10
        Me.listaCursos_pnl.Location = New System.Drawing.Point(548, 431)
        Me.listaCursos_pnl.Name = "listaCursos_pnl"
        Me.listaCursos_pnl.Size = New System.Drawing.Size(0, 3)
        Me.listaCursos_pnl.Style = MetroFramework.MetroColorStyle.Blue
        Me.listaCursos_pnl.TabIndex = 51
        Me.listaCursos_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.listaCursos_pnl.VerticalScrollbarBarColor = True
        Me.listaCursos_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.listaCursos_pnl.VerticalScrollbarSize = 10
        Me.listaCursos_pnl.Visible = False
        '
        'listaCursosVolver_btn
        '
        Me.listaCursosVolver_btn.Location = New System.Drawing.Point(7, 412)
        Me.listaCursosVolver_btn.Name = "listaCursosVolver_btn"
        Me.listaCursosVolver_btn.Size = New System.Drawing.Size(123, 36)
        Me.listaCursosVolver_btn.TabIndex = 50
        Me.listaCursosVolver_btn.Text = "Volver"
        Me.listaCursosVolver_btn.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(723, 7)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(20, 19)
        Me.MetroLabel2.TabIndex = 49
        Me.MetroLabel2.Text = "id"
        Me.MetroLabel2.Visible = False
        '
        'listaCursos_dg
        '
        Me.listaCursos_dg.AllowUserToAddRows = False
        Me.listaCursos_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaCursos_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewImageColumn5})
        Me.listaCursos_dg.Location = New System.Drawing.Point(7, 37)
        Me.listaCursos_dg.Name = "listaCursos_dg"
        Me.listaCursos_dg.RowHeadersVisible = False
        Me.listaCursos_dg.Size = New System.Drawing.Size(739, 344)
        Me.listaCursos_dg.TabIndex = 12
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewImageColumn5
        '
        Me.DataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn5.HeaderText = ""
        Me.DataGridViewImageColumn5.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.ReadOnly = True
        Me.DataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'listaCursos_lbl
        '
        Me.listaCursos_lbl.AutoSize = True
        Me.listaCursos_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.listaCursos_lbl.Location = New System.Drawing.Point(4, 9)
        Me.listaCursos_lbl.Name = "listaCursos_lbl"
        Me.listaCursos_lbl.Size = New System.Drawing.Size(107, 25)
        Me.listaCursos_lbl.TabIndex = 10
        Me.listaCursos_lbl.Text = "Listar Cursos"
        '
        'listaCarrerasVolver_btn
        '
        Me.listaCarrerasVolver_btn.Location = New System.Drawing.Point(7, 412)
        Me.listaCarrerasVolver_btn.Name = "listaCarrerasVolver_btn"
        Me.listaCarrerasVolver_btn.Size = New System.Drawing.Size(123, 36)
        Me.listaCarrerasVolver_btn.TabIndex = 50
        Me.listaCarrerasVolver_btn.Text = "Volver"
        Me.listaCarrerasVolver_btn.UseSelectable = True
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(723, 7)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(20, 19)
        Me.MetroLabel17.TabIndex = 49
        Me.MetroLabel17.Text = "id"
        Me.MetroLabel17.Visible = False
        '
        'listaCarreras_dg
        '
        Me.listaCarreras_dg.AllowUserToAddRows = False
        Me.listaCarreras_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaCarreras_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCarrera, Me.nombreCarrera, Me.CodigoCarrera, Me.CostoCarrera, Me.Horario, Me.DataGridViewImageColumn4})
        Me.listaCarreras_dg.Location = New System.Drawing.Point(7, 37)
        Me.listaCarreras_dg.Name = "listaCarreras_dg"
        Me.listaCarreras_dg.RowHeadersVisible = False
        Me.listaCarreras_dg.Size = New System.Drawing.Size(739, 344)
        Me.listaCarreras_dg.TabIndex = 12
        '
        'idCarrera
        '
        Me.idCarrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.idCarrera.HeaderText = "ID"
        Me.idCarrera.Name = "idCarrera"
        Me.idCarrera.ReadOnly = True
        Me.idCarrera.Visible = False
        '
        'nombreCarrera
        '
        Me.nombreCarrera.HeaderText = "Nombre"
        Me.nombreCarrera.Name = "nombreCarrera"
        '
        'CodigoCarrera
        '
        Me.CodigoCarrera.HeaderText = "Codigo"
        Me.CodigoCarrera.Name = "CodigoCarrera"
        '
        'CostoCarrera
        '
        Me.CostoCarrera.HeaderText = "Costo"
        Me.CostoCarrera.Name = "CostoCarrera"
        '
        'Horario
        '
        Me.Horario.HeaderText = "Horario"
        Me.Horario.Name = "Horario"
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn4.HeaderText = ""
        Me.DataGridViewImageColumn4.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.ReadOnly = True
        Me.DataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'carreras_lbl
        '
        Me.carreras_lbl.AutoSize = True
        Me.carreras_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.carreras_lbl.Location = New System.Drawing.Point(4, 9)
        Me.carreras_lbl.Name = "carreras_lbl"
        Me.carreras_lbl.Size = New System.Drawing.Size(119, 25)
        Me.carreras_lbl.TabIndex = 10
        Me.carreras_lbl.Text = "Listar Carreras"
        '
        'nuevaCarrera_btn
        '
        Me.nuevaCarrera_btn.Location = New System.Drawing.Point(623, 412)
        Me.nuevaCarrera_btn.Name = "nuevaCarrera_btn"
        Me.nuevaCarrera_btn.Size = New System.Drawing.Size(123, 36)
        Me.nuevaCarrera_btn.TabIndex = 9
        Me.nuevaCarrera_btn.Text = "Nueva Carrera"
        Me.nuevaCarrera_btn.UseSelectable = True
        '
        'exportarCarreras_btn
        '
        Me.exportarCarreras_btn.Location = New System.Drawing.Point(485, 412)
        Me.exportarCarreras_btn.Name = "exportarCarreras_btn"
        Me.exportarCarreras_btn.Size = New System.Drawing.Size(123, 36)
        Me.exportarCarreras_btn.TabIndex = 52
        Me.exportarCarreras_btn.Text = "Exportar"
        Me.exportarCarreras_btn.UseSelectable = True
        '
        'registrarCarrera_pnl
        '
        Me.registrarCarrera_pnl.Controls.Add(Me.ImportarCarreras_cmb)
        Me.registrarCarrera_pnl.Controls.Add(Me.guardarCarrera_btn)
        Me.registrarCarrera_pnl.Controls.Add(Me.cancelarCarrera_btn)
        Me.registrarCarrera_pnl.Controls.Add(Me.min2_lbl)
        Me.registrarCarrera_pnl.Controls.Add(Me.hora2_lbl)
        Me.registrarCarrera_pnl.Controls.Add(Me.minsFin5_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.minsFin4_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.minsFin3_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.minsFin2_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.minsFin1_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.horaFin5_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.horaFin4_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.horaFin3_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.horaFin2_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.horaFin1_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.min1_lbl)
        Me.registrarCarrera_pnl.Controls.Add(Me.hora1_lbl)
        Me.registrarCarrera_pnl.Controls.Add(Me.minsIni5_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.minsIni4_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.minsIni3_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.minsIni2_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.minsIni1_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.horaIni5_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.horaIni4_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.horaIni3_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.horaIni2_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.horaIni1_nmbr)
        Me.registrarCarrera_pnl.Controls.Add(Me.dia5_cmb)
        Me.registrarCarrera_pnl.Controls.Add(Me.dia4_cmb)
        Me.registrarCarrera_pnl.Controls.Add(Me.dia3_cmb)
        Me.registrarCarrera_pnl.Controls.Add(Me.dia2_cmb)
        Me.registrarCarrera_pnl.Controls.Add(Me.dia1_cmb)
        Me.registrarCarrera_pnl.Controls.Add(Me.horaFin_lbl)
        Me.registrarCarrera_pnl.Controls.Add(Me.horaIni_lbl)
        Me.registrarCarrera_pnl.Controls.Add(Me.MetroLabel35)
        Me.registrarCarrera_pnl.Controls.Add(Me.MetroLabel36)
        Me.registrarCarrera_pnl.Controls.Add(Me.MetroLabel37)
        Me.registrarCarrera_pnl.Controls.Add(Me.MetroLabel38)
        Me.registrarCarrera_pnl.Controls.Add(Me.MetroLabel39)
        Me.registrarCarrera_pnl.Controls.Add(Me.tipoCarrera_cmb)
        Me.registrarCarrera_pnl.Controls.Add(Me.costoCarrera_text)
        Me.registrarCarrera_pnl.Controls.Add(Me.nombreCarrera_text)
        Me.registrarCarrera_pnl.Controls.Add(Me.codigoCarrera_text)
        Me.registrarCarrera_pnl.Controls.Add(Me.carreraNombre_lbl)
        Me.registrarCarrera_pnl.Controls.Add(Me.tipoCarrera_lbl)
        Me.registrarCarrera_pnl.Controls.Add(Me.costoCarrera_lbl)
        Me.registrarCarrera_pnl.Controls.Add(Me.carreraCodigo_lbl)
        Me.registrarCarrera_pnl.Controls.Add(Me.registrarCarrera_lbl)
        Me.registrarCarrera_pnl.Controls.Add(Me.GroupBox3)
        Me.registrarCarrera_pnl.Controls.Add(Me.GroupBox4)
        Me.registrarCarrera_pnl.Controls.Add(Me.horarioCarrera)
        Me.registrarCarrera_pnl.HorizontalScrollbarBarColor = True
        Me.registrarCarrera_pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.registrarCarrera_pnl.HorizontalScrollbarSize = 10
        Me.registrarCarrera_pnl.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.registrarCarrera_pnl.Location = New System.Drawing.Point(0, 3)
        Me.registrarCarrera_pnl.Name = "registrarCarrera_pnl"
        Me.registrarCarrera_pnl.Size = New System.Drawing.Size(746, 462)
        Me.registrarCarrera_pnl.Style = MetroFramework.MetroColorStyle.Purple
        Me.registrarCarrera_pnl.TabIndex = 84
        Me.registrarCarrera_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.registrarCarrera_pnl.VerticalScrollbarBarColor = True
        Me.registrarCarrera_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.registrarCarrera_pnl.VerticalScrollbarSize = 10
        Me.registrarCarrera_pnl.Visible = False
        '
        'ImportarCarreras_cmb
        '
        Me.ImportarCarreras_cmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImportarCarreras_cmb.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.ImportarCarreras_cmb.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.ImportarCarreras_cmb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ImportarCarreras_cmb.Location = New System.Drawing.Point(142, 9)
        Me.ImportarCarreras_cmb.Name = "ImportarCarreras_cmb"
        Me.ImportarCarreras_cmb.Size = New System.Drawing.Size(147, 23)
        Me.ImportarCarreras_cmb.TabIndex = 90
        Me.ImportarCarreras_cmb.Text = "Importar Datos"
        Me.ImportarCarreras_cmb.UseCustomForeColor = True
        Me.ImportarCarreras_cmb.UseSelectable = True
        '
        'guardarCarrera_btn
        '
        Me.guardarCarrera_btn.Location = New System.Drawing.Point(324, 421)
        Me.guardarCarrera_btn.Name = "guardarCarrera_btn"
        Me.guardarCarrera_btn.Size = New System.Drawing.Size(97, 23)
        Me.guardarCarrera_btn.TabIndex = 88
        Me.guardarCarrera_btn.Text = "Guardar"
        Me.guardarCarrera_btn.UseSelectable = True
        '
        'cancelarCarrera_btn
        '
        Me.cancelarCarrera_btn.Location = New System.Drawing.Point(427, 421)
        Me.cancelarCarrera_btn.Name = "cancelarCarrera_btn"
        Me.cancelarCarrera_btn.Size = New System.Drawing.Size(97, 23)
        Me.cancelarCarrera_btn.TabIndex = 89
        Me.cancelarCarrera_btn.Text = "Cancelar"
        Me.cancelarCarrera_btn.UseSelectable = True
        '
        'min2_lbl
        '
        Me.min2_lbl.AutoSize = True
        Me.min2_lbl.Enabled = False
        Me.min2_lbl.Location = New System.Drawing.Point(594, 224)
        Me.min2_lbl.Name = "min2_lbl"
        Me.min2_lbl.Size = New System.Drawing.Size(55, 19)
        Me.min2_lbl.TabIndex = 74
        Me.min2_lbl.Text = "Minutos"
        '
        'hora2_lbl
        '
        Me.hora2_lbl.AutoSize = True
        Me.hora2_lbl.Enabled = False
        Me.hora2_lbl.Location = New System.Drawing.Point(546, 224)
        Me.hora2_lbl.Name = "hora2_lbl"
        Me.hora2_lbl.Size = New System.Drawing.Size(38, 19)
        Me.hora2_lbl.TabIndex = 73
        Me.hora2_lbl.Text = "Hora"
        '
        'minsFin5_nmbr
        '
        Me.minsFin5_nmbr.Enabled = False
        Me.minsFin5_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin5_nmbr.Location = New System.Drawing.Point(603, 354)
        Me.minsFin5_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin5_nmbr.Name = "minsFin5_nmbr"
        Me.minsFin5_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsFin5_nmbr.TabIndex = 53
        '
        'minsFin4_nmbr
        '
        Me.minsFin4_nmbr.Enabled = False
        Me.minsFin4_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin4_nmbr.Location = New System.Drawing.Point(603, 327)
        Me.minsFin4_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin4_nmbr.Name = "minsFin4_nmbr"
        Me.minsFin4_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsFin4_nmbr.TabIndex = 48
        '
        'minsFin3_nmbr
        '
        Me.minsFin3_nmbr.Enabled = False
        Me.minsFin3_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin3_nmbr.Location = New System.Drawing.Point(603, 300)
        Me.minsFin3_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin3_nmbr.Name = "minsFin3_nmbr"
        Me.minsFin3_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsFin3_nmbr.TabIndex = 43
        '
        'minsFin2_nmbr
        '
        Me.minsFin2_nmbr.Enabled = False
        Me.minsFin2_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin2_nmbr.Location = New System.Drawing.Point(603, 273)
        Me.minsFin2_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin2_nmbr.Name = "minsFin2_nmbr"
        Me.minsFin2_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsFin2_nmbr.TabIndex = 38
        '
        'minsFin1_nmbr
        '
        Me.minsFin1_nmbr.Enabled = False
        Me.minsFin1_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin1_nmbr.Location = New System.Drawing.Point(603, 246)
        Me.minsFin1_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin1_nmbr.Name = "minsFin1_nmbr"
        Me.minsFin1_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsFin1_nmbr.TabIndex = 33
        '
        'horaFin5_nmbr
        '
        Me.horaFin5_nmbr.Enabled = False
        Me.horaFin5_nmbr.Location = New System.Drawing.Point(546, 354)
        Me.horaFin5_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin5_nmbr.Name = "horaFin5_nmbr"
        Me.horaFin5_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaFin5_nmbr.TabIndex = 52
        '
        'horaFin4_nmbr
        '
        Me.horaFin4_nmbr.Enabled = False
        Me.horaFin4_nmbr.Location = New System.Drawing.Point(546, 327)
        Me.horaFin4_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin4_nmbr.Name = "horaFin4_nmbr"
        Me.horaFin4_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaFin4_nmbr.TabIndex = 47
        '
        'horaFin3_nmbr
        '
        Me.horaFin3_nmbr.Enabled = False
        Me.horaFin3_nmbr.Location = New System.Drawing.Point(546, 300)
        Me.horaFin3_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin3_nmbr.Name = "horaFin3_nmbr"
        Me.horaFin3_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaFin3_nmbr.TabIndex = 42
        '
        'horaFin2_nmbr
        '
        Me.horaFin2_nmbr.Enabled = False
        Me.horaFin2_nmbr.Location = New System.Drawing.Point(546, 273)
        Me.horaFin2_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin2_nmbr.Name = "horaFin2_nmbr"
        Me.horaFin2_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaFin2_nmbr.TabIndex = 37
        '
        'horaFin1_nmbr
        '
        Me.horaFin1_nmbr.Enabled = False
        Me.horaFin1_nmbr.Location = New System.Drawing.Point(546, 246)
        Me.horaFin1_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin1_nmbr.Name = "horaFin1_nmbr"
        Me.horaFin1_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaFin1_nmbr.TabIndex = 32
        '
        'min1_lbl
        '
        Me.min1_lbl.AutoSize = True
        Me.min1_lbl.Enabled = False
        Me.min1_lbl.Location = New System.Drawing.Point(462, 224)
        Me.min1_lbl.Name = "min1_lbl"
        Me.min1_lbl.Size = New System.Drawing.Size(55, 19)
        Me.min1_lbl.TabIndex = 62
        Me.min1_lbl.Text = "Minutos"
        '
        'hora1_lbl
        '
        Me.hora1_lbl.AutoSize = True
        Me.hora1_lbl.Enabled = False
        Me.hora1_lbl.Location = New System.Drawing.Point(414, 224)
        Me.hora1_lbl.Name = "hora1_lbl"
        Me.hora1_lbl.Size = New System.Drawing.Size(38, 19)
        Me.hora1_lbl.TabIndex = 61
        Me.hora1_lbl.Text = "Hora"
        '
        'minsIni5_nmbr
        '
        Me.minsIni5_nmbr.Enabled = False
        Me.minsIni5_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni5_nmbr.Location = New System.Drawing.Point(471, 354)
        Me.minsIni5_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni5_nmbr.Name = "minsIni5_nmbr"
        Me.minsIni5_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsIni5_nmbr.TabIndex = 51
        '
        'minsIni4_nmbr
        '
        Me.minsIni4_nmbr.Enabled = False
        Me.minsIni4_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni4_nmbr.Location = New System.Drawing.Point(471, 327)
        Me.minsIni4_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni4_nmbr.Name = "minsIni4_nmbr"
        Me.minsIni4_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsIni4_nmbr.TabIndex = 46
        '
        'minsIni3_nmbr
        '
        Me.minsIni3_nmbr.Enabled = False
        Me.minsIni3_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni3_nmbr.Location = New System.Drawing.Point(471, 300)
        Me.minsIni3_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni3_nmbr.Name = "minsIni3_nmbr"
        Me.minsIni3_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsIni3_nmbr.TabIndex = 41
        '
        'minsIni2_nmbr
        '
        Me.minsIni2_nmbr.Enabled = False
        Me.minsIni2_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni2_nmbr.Location = New System.Drawing.Point(471, 273)
        Me.minsIni2_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni2_nmbr.Name = "minsIni2_nmbr"
        Me.minsIni2_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsIni2_nmbr.TabIndex = 36
        '
        'minsIni1_nmbr
        '
        Me.minsIni1_nmbr.Enabled = False
        Me.minsIni1_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni1_nmbr.Location = New System.Drawing.Point(471, 246)
        Me.minsIni1_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni1_nmbr.Name = "minsIni1_nmbr"
        Me.minsIni1_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsIni1_nmbr.TabIndex = 31
        '
        'horaIni5_nmbr
        '
        Me.horaIni5_nmbr.Enabled = False
        Me.horaIni5_nmbr.Location = New System.Drawing.Point(414, 354)
        Me.horaIni5_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni5_nmbr.Name = "horaIni5_nmbr"
        Me.horaIni5_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaIni5_nmbr.TabIndex = 50
        '
        'horaIni4_nmbr
        '
        Me.horaIni4_nmbr.Enabled = False
        Me.horaIni4_nmbr.Location = New System.Drawing.Point(414, 327)
        Me.horaIni4_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni4_nmbr.Name = "horaIni4_nmbr"
        Me.horaIni4_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaIni4_nmbr.TabIndex = 45
        '
        'horaIni3_nmbr
        '
        Me.horaIni3_nmbr.Enabled = False
        Me.horaIni3_nmbr.Location = New System.Drawing.Point(414, 300)
        Me.horaIni3_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni3_nmbr.Name = "horaIni3_nmbr"
        Me.horaIni3_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaIni3_nmbr.TabIndex = 40
        '
        'horaIni2_nmbr
        '
        Me.horaIni2_nmbr.Enabled = False
        Me.horaIni2_nmbr.Location = New System.Drawing.Point(414, 273)
        Me.horaIni2_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni2_nmbr.Name = "horaIni2_nmbr"
        Me.horaIni2_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaIni2_nmbr.TabIndex = 35
        '
        'horaIni1_nmbr
        '
        Me.horaIni1_nmbr.Enabled = False
        Me.horaIni1_nmbr.Location = New System.Drawing.Point(414, 246)
        Me.horaIni1_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni1_nmbr.Name = "horaIni1_nmbr"
        Me.horaIni1_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaIni1_nmbr.TabIndex = 30
        '
        'dia5_cmb
        '
        Me.dia5_cmb.Enabled = False
        Me.dia5_cmb.FormattingEnabled = True
        Me.dia5_cmb.Location = New System.Drawing.Point(156, 351)
        Me.dia5_cmb.Name = "dia5_cmb"
        Me.dia5_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia5_cmb.TabIndex = 49
        '
        'dia4_cmb
        '
        Me.dia4_cmb.Enabled = False
        Me.dia4_cmb.FormattingEnabled = True
        Me.dia4_cmb.Location = New System.Drawing.Point(156, 324)
        Me.dia4_cmb.Name = "dia4_cmb"
        Me.dia4_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia4_cmb.TabIndex = 44
        '
        'dia3_cmb
        '
        Me.dia3_cmb.Enabled = False
        Me.dia3_cmb.FormattingEnabled = True
        Me.dia3_cmb.Location = New System.Drawing.Point(156, 297)
        Me.dia3_cmb.Name = "dia3_cmb"
        Me.dia3_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia3_cmb.TabIndex = 39
        '
        'dia2_cmb
        '
        Me.dia2_cmb.Enabled = False
        Me.dia2_cmb.FormattingEnabled = True
        Me.dia2_cmb.Location = New System.Drawing.Point(156, 270)
        Me.dia2_cmb.Name = "dia2_cmb"
        Me.dia2_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia2_cmb.TabIndex = 34
        '
        'dia1_cmb
        '
        Me.dia1_cmb.Enabled = False
        Me.dia1_cmb.FormattingEnabled = True
        Me.dia1_cmb.Location = New System.Drawing.Point(156, 243)
        Me.dia1_cmb.Name = "dia1_cmb"
        Me.dia1_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia1_cmb.TabIndex = 29
        '
        'horaFin_lbl
        '
        Me.horaFin_lbl.AutoSize = True
        Me.horaFin_lbl.Enabled = False
        Me.horaFin_lbl.Location = New System.Drawing.Point(562, 191)
        Me.horaFin_lbl.Name = "horaFin_lbl"
        Me.horaFin_lbl.Size = New System.Drawing.Size(59, 19)
        Me.horaFin_lbl.TabIndex = 45
        Me.horaFin_lbl.Text = "Hora Fin"
        '
        'horaIni_lbl
        '
        Me.horaIni_lbl.AutoSize = True
        Me.horaIni_lbl.Enabled = False
        Me.horaIni_lbl.Location = New System.Drawing.Point(426, 191)
        Me.horaIni_lbl.Name = "horaIni_lbl"
        Me.horaIni_lbl.Size = New System.Drawing.Size(72, 19)
        Me.horaIni_lbl.TabIndex = 44
        Me.horaIni_lbl.Text = "Hora Inicio"
        '
        'MetroLabel35
        '
        Me.MetroLabel35.AutoSize = True
        Me.MetroLabel35.Location = New System.Drawing.Point(111, 351)
        Me.MetroLabel35.Name = "MetroLabel35"
        Me.MetroLabel35.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel35.TabIndex = 43
        Me.MetroLabel35.Text = "Dia 5"
        '
        'MetroLabel36
        '
        Me.MetroLabel36.AutoSize = True
        Me.MetroLabel36.Location = New System.Drawing.Point(111, 324)
        Me.MetroLabel36.Name = "MetroLabel36"
        Me.MetroLabel36.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel36.TabIndex = 42
        Me.MetroLabel36.Text = "Dia 4"
        '
        'MetroLabel37
        '
        Me.MetroLabel37.AutoSize = True
        Me.MetroLabel37.Location = New System.Drawing.Point(111, 270)
        Me.MetroLabel37.Name = "MetroLabel37"
        Me.MetroLabel37.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel37.TabIndex = 41
        Me.MetroLabel37.Text = "Dia 2"
        '
        'MetroLabel38
        '
        Me.MetroLabel38.AutoSize = True
        Me.MetroLabel38.Location = New System.Drawing.Point(111, 297)
        Me.MetroLabel38.Name = "MetroLabel38"
        Me.MetroLabel38.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel38.TabIndex = 40
        Me.MetroLabel38.Text = "Dia 3"
        '
        'MetroLabel39
        '
        Me.MetroLabel39.AutoSize = True
        Me.MetroLabel39.Location = New System.Drawing.Point(111, 243)
        Me.MetroLabel39.Name = "MetroLabel39"
        Me.MetroLabel39.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel39.TabIndex = 39
        Me.MetroLabel39.Text = "Dia 1"
        '
        'tipoCarrera_cmb
        '
        Me.tipoCarrera_cmb.FormattingEnabled = True
        Me.tipoCarrera_cmb.ItemHeight = 13
        Me.tipoCarrera_cmb.Location = New System.Drawing.Point(157, 117)
        Me.tipoCarrera_cmb.Name = "tipoCarrera_cmb"
        Me.tipoCarrera_cmb.Size = New System.Drawing.Size(148, 21)
        Me.tipoCarrera_cmb.TabIndex = 27
        '
        'costoCarrera_text
        '
        '
        '
        '
        Me.costoCarrera_text.CustomButton.Image = Nothing
        Me.costoCarrera_text.CustomButton.Location = New System.Drawing.Point(126, 1)
        Me.costoCarrera_text.CustomButton.Name = ""
        Me.costoCarrera_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.costoCarrera_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.costoCarrera_text.CustomButton.TabIndex = 1
        Me.costoCarrera_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.costoCarrera_text.CustomButton.UseSelectable = True
        Me.costoCarrera_text.CustomButton.Visible = False
        Me.costoCarrera_text.Lines = New String(-1) {}
        Me.costoCarrera_text.Location = New System.Drawing.Point(157, 146)
        Me.costoCarrera_text.MaxLength = 8
        Me.costoCarrera_text.Name = "costoCarrera_text"
        Me.costoCarrera_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.costoCarrera_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.costoCarrera_text.SelectedText = ""
        Me.costoCarrera_text.SelectionLength = 0
        Me.costoCarrera_text.SelectionStart = 0
        Me.costoCarrera_text.Size = New System.Drawing.Size(148, 23)
        Me.costoCarrera_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.costoCarrera_text.TabIndex = 28
        Me.costoCarrera_text.UseSelectable = True
        Me.costoCarrera_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.costoCarrera_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'nombreCarrera_text
        '
        '
        '
        '
        Me.nombreCarrera_text.CustomButton.Image = Nothing
        Me.nombreCarrera_text.CustomButton.Location = New System.Drawing.Point(484, 1)
        Me.nombreCarrera_text.CustomButton.Name = ""
        Me.nombreCarrera_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.nombreCarrera_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.nombreCarrera_text.CustomButton.TabIndex = 1
        Me.nombreCarrera_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.nombreCarrera_text.CustomButton.UseSelectable = True
        Me.nombreCarrera_text.CustomButton.Visible = False
        Me.nombreCarrera_text.Lines = New String(-1) {}
        Me.nombreCarrera_text.Location = New System.Drawing.Point(157, 55)
        Me.nombreCarrera_text.MaxLength = 100
        Me.nombreCarrera_text.Name = "nombreCarrera_text"
        Me.nombreCarrera_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nombreCarrera_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nombreCarrera_text.SelectedText = ""
        Me.nombreCarrera_text.SelectionLength = 0
        Me.nombreCarrera_text.SelectionStart = 0
        Me.nombreCarrera_text.Size = New System.Drawing.Size(506, 23)
        Me.nombreCarrera_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.nombreCarrera_text.TabIndex = 25
        Me.nombreCarrera_text.UseSelectable = True
        Me.nombreCarrera_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nombreCarrera_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'codigoCarrera_text
        '
        '
        '
        '
        Me.codigoCarrera_text.CustomButton.Image = Nothing
        Me.codigoCarrera_text.CustomButton.Location = New System.Drawing.Point(126, 1)
        Me.codigoCarrera_text.CustomButton.Name = ""
        Me.codigoCarrera_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.codigoCarrera_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.codigoCarrera_text.CustomButton.TabIndex = 1
        Me.codigoCarrera_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.codigoCarrera_text.CustomButton.UseSelectable = True
        Me.codigoCarrera_text.CustomButton.Visible = False
        Me.codigoCarrera_text.Lines = New String(-1) {}
        Me.codigoCarrera_text.Location = New System.Drawing.Point(157, 86)
        Me.codigoCarrera_text.MaxLength = 20
        Me.codigoCarrera_text.Name = "codigoCarrera_text"
        Me.codigoCarrera_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.codigoCarrera_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.codigoCarrera_text.SelectedText = ""
        Me.codigoCarrera_text.SelectionLength = 0
        Me.codigoCarrera_text.SelectionStart = 0
        Me.codigoCarrera_text.Size = New System.Drawing.Size(148, 23)
        Me.codigoCarrera_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.codigoCarrera_text.TabIndex = 26
        Me.codigoCarrera_text.UseSelectable = True
        Me.codigoCarrera_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.codigoCarrera_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'carreraNombre_lbl
        '
        Me.carreraNombre_lbl.AutoSize = True
        Me.carreraNombre_lbl.Location = New System.Drawing.Point(31, 55)
        Me.carreraNombre_lbl.Name = "carreraNombre_lbl"
        Me.carreraNombre_lbl.Size = New System.Drawing.Size(59, 19)
        Me.carreraNombre_lbl.TabIndex = 14
        Me.carreraNombre_lbl.Text = "Nombre"
        '
        'tipoCarrera_lbl
        '
        Me.tipoCarrera_lbl.AutoSize = True
        Me.tipoCarrera_lbl.Location = New System.Drawing.Point(31, 117)
        Me.tipoCarrera_lbl.Name = "tipoCarrera_lbl"
        Me.tipoCarrera_lbl.Size = New System.Drawing.Size(35, 19)
        Me.tipoCarrera_lbl.TabIndex = 13
        Me.tipoCarrera_lbl.Text = "Tipo"
        '
        'costoCarrera_lbl
        '
        Me.costoCarrera_lbl.AutoSize = True
        Me.costoCarrera_lbl.Location = New System.Drawing.Point(31, 146)
        Me.costoCarrera_lbl.Name = "costoCarrera_lbl"
        Me.costoCarrera_lbl.Size = New System.Drawing.Size(43, 19)
        Me.costoCarrera_lbl.TabIndex = 12
        Me.costoCarrera_lbl.Text = "Costo"
        '
        'carreraCodigo_lbl
        '
        Me.carreraCodigo_lbl.AutoSize = True
        Me.carreraCodigo_lbl.Location = New System.Drawing.Point(31, 86)
        Me.carreraCodigo_lbl.Name = "carreraCodigo_lbl"
        Me.carreraCodigo_lbl.Size = New System.Drawing.Size(102, 19)
        Me.carreraCodigo_lbl.TabIndex = 11
        Me.carreraCodigo_lbl.Text = "Codigo Carrera"
        '
        'registrarCarrera_lbl
        '
        Me.registrarCarrera_lbl.AutoSize = True
        Me.registrarCarrera_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.registrarCarrera_lbl.Location = New System.Drawing.Point(4, 9)
        Me.registrarCarrera_lbl.Name = "registrarCarrera_lbl"
        Me.registrarCarrera_lbl.Size = New System.Drawing.Size(139, 25)
        Me.registrarCarrera_lbl.TabIndex = 10
        Me.registrarCarrera_lbl.Text = "Registrar Carrera"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(399, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 185)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(533, 200)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(124, 185)
        Me.GroupBox4.TabIndex = 75
        Me.GroupBox4.TabStop = False
        '
        'horarioCarrera
        '
        Me.horarioCarrera.BackColor = System.Drawing.SystemColors.Window
        Me.horarioCarrera.Controls.Add(Me.horario_lbl)
        Me.horarioCarrera.Location = New System.Drawing.Point(30, 175)
        Me.horarioCarrera.Name = "horarioCarrera"
        Me.horarioCarrera.Size = New System.Drawing.Size(678, 223)
        Me.horarioCarrera.TabIndex = 77
        Me.horarioCarrera.TabStop = False
        '
        'horario_lbl
        '
        Me.horario_lbl.AutoSize = True
        Me.horario_lbl.Enabled = False
        Me.horario_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.horario_lbl.Location = New System.Drawing.Point(0, -5)
        Me.horario_lbl.Name = "horario_lbl"
        Me.horario_lbl.Size = New System.Drawing.Size(76, 25)
        Me.horario_lbl.TabIndex = 38
        Me.horario_lbl.Text = "Horarios"
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
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.listaCarreras_pnl.ResumeLayout(False)
        Me.listaCarreras_pnl.PerformLayout()
        Me.listaCursos_pnl.ResumeLayout(False)
        Me.listaCursos_pnl.PerformLayout()
        CType(Me.listaCursos_dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaCarreras_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.registrarCarrera_pnl.ResumeLayout(False)
        Me.registrarCarrera_pnl.PerformLayout()
        CType(Me.minsFin5_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsFin4_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsFin3_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsFin2_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsFin1_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin5_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin4_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin3_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin2_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin1_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni5_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni4_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni3_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni2_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni1_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni5_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni4_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni3_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni2_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni1_nmbr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.horarioCarrera.ResumeLayout(False)
        Me.horarioCarrera.PerformLayout()
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
    Friend WithEvents listaCarreras_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents listaCursos_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents listaCursosVolver_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaCursos_dg As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn5 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents listaCursos_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaCarrerasVolver_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaCarreras_dg As System.Windows.Forms.DataGridView
    Friend WithEvents idCarrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreCarrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoCarrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoCarrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Horario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn4 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents carreras_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents nuevaCarrera_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents exportarCarreras_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents registrarCarrera_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents ImportarCarreras_cmb As MetroFramework.Controls.MetroLink
    Friend WithEvents guardarCarrera_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents cancelarCarrera_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents min2_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents hora2_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents minsFin5_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsFin4_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsFin3_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsFin2_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsFin1_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin5_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin4_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin3_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin2_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin1_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents min1_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents hora1_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents minsIni5_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIni4_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIni3_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIni2_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIni1_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni5_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni4_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni3_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni2_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni1_nmbr As System.Windows.Forms.NumericUpDown
    Friend WithEvents dia5_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents dia4_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents dia3_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents dia2_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents dia1_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents horaFin_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents horaIni_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel35 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel36 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel37 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel38 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel39 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tipoCarrera_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents costoCarrera_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents nombreCarrera_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents codigoCarrera_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents carreraNombre_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents tipoCarrera_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents costoCarrera_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents carreraCodigo_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents registrarCarrera_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents horarioCarrera As System.Windows.Forms.GroupBox
    Friend WithEvents horario_lbl As MetroFramework.Controls.MetroLabel
End Class
