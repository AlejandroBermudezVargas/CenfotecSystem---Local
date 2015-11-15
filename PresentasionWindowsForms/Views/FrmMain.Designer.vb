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
        Me.TabConfiguracion = New MetroFramework.Controls.MetroTabPage()
        Me.TabProspectos = New MetroFramework.Controls.MetroTabPage()
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
        Me.TabUsuarios = New MetroFramework.Controls.MetroTabPage()
        Me.TabReportes = New MetroFramework.Controls.MetroTabPage()
        Me.cboUsuario = New MetroFramework.Controls.MetroComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.checkBoxTopProduto = New MetroFramework.Controls.MetroCheckBox()
        Me.Main.SuspendLayout()
        Me.TabProductos.SuspendLayout()
        Me.Eventos.SuspendLayout()
        Me.PanelListarEventos.SuspendLayout()
        CType(Me.DataListarEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCrearEvento.SuspendLayout()
        Me.KPIHolder.SuspendLayout()
        Me.panSeleccionarTipoKPI.SuspendLayout()
        Me.pnlCrearKpiProducto.SuspendLayout()
        Me.pnlKpiProspectos.SuspendLayout()
        Me.panKpiVentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Main
        '
        Me.Main.Controls.Add(Me.TabProductos)
        Me.Main.Controls.Add(Me.TabConfiguracion)
        Me.Main.Controls.Add(Me.TabProspectos)
        Me.Main.Controls.Add(Me.Eventos)
        Me.Main.Controls.Add(Me.KPIHolder)
        Me.Main.Controls.Add(Me.TabVentas)
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
        Me.Main.TabIndex = 1
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
        'TabProspectos
        '
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
        Me.crearKPIVentas.Size = New System.Drawing.Size(137, 25)
        Me.crearKPIVentas.TabIndex = 11
        Me.crearKPIVentas.Text = "Crear KPI Ventas"
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
        Me.KPIHolder.ResumeLayout(False)
        Me.panSeleccionarTipoKPI.ResumeLayout(False)
        Me.pnlCrearKpiProducto.ResumeLayout(False)
        Me.pnlCrearKpiProducto.PerformLayout()
        Me.pnlKpiProspectos.ResumeLayout(False)
        Me.pnlKpiProspectos.PerformLayout()
        Me.panKpiVentas.ResumeLayout(False)
        Me.panKpiVentas.PerformLayout()
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
End Class
