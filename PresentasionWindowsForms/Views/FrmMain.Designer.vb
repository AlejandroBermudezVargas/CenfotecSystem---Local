﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblSignOut = New MetroFramework.Controls.MetroLink()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tabReports = New MetroFramework.Controls.MetroTabPage()
        Me.tabKpi = New MetroFramework.Controls.MetroTabPage()
        Me.tabSales = New MetroFramework.Controls.MetroTabPage()
        Me.listarVerntas_pnl = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.RegistrarVentas_pnl = New MetroFramework.Controls.MetroPanel()
        Me.guardarVenta_btn = New MetroFramework.Controls.MetroButton()
        Me.cancelarVenta_btn = New MetroFramework.Controls.MetroButton()
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
        Me.volverVenta_btn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.listaVentas_dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.listarVentas_lbl = New MetroFramework.Controls.MetroLabel()
        Me.nuevaVenta_btn = New MetroFramework.Controls.MetroButton()
        Me.tabEvents = New MetroFramework.Controls.MetroTabPage()
        Me.tabConfiguration = New MetroFramework.Controls.MetroTabPage()
        Me.pnlUpdateUserInfo = New MetroFramework.Controls.MetroPanel()
        Me.tgChangePassUpdateUserInfo = New MetroFramework.Controls.MetroToggle()
        Me.txtPasswordUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.txtNewPassUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.lblNewpassUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.cboDateUpdateUserInfo = New MetroFramework.Controls.MetroDateTime()
        Me.lblDateUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.txtEmailUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.lblEmailUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.txtLastNameUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.txtPhoneUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.txtNameUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.txtIdUpdateUserInfo = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancelUpdateUserInfo = New MetroFramework.Controls.MetroButton()
        Me.btnSaveUpdateUserInfo = New MetroFramework.Controls.MetroButton()
        Me.lblPasswordUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.lblPhoneUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.lblNameUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.lblLastNameUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.lblIdUpdateUserInfo = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.tUpdateUserInformation = New MetroFramework.Controls.MetroTile()
        Me.tSignOutUser = New MetroFramework.Controls.MetroTile()
        Me.tabUsers = New MetroFramework.Controls.MetroTabPage()
        Me.pnlCreateUser = New MetroFramework.Controls.MetroPanel()
        Me.lblPasswordUserBackup = New System.Windows.Forms.Label()
        Me.chkChangeUserPassword = New MetroFramework.Controls.MetroCheckBox()
        Me.cboDateCreateUser = New MetroFramework.Controls.MetroDateTime()
        Me.lblDateCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.txtEmailCreateUser = New MetroFramework.Controls.MetroTextBox()
        Me.lblEmailCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.txtLastNameCreateUser = New MetroFramework.Controls.MetroTextBox()
        Me.cboRolCreateUser = New MetroFramework.Controls.MetroComboBox()
        Me.tgEnableCreateUser = New MetroFramework.Controls.MetroToggle()
        Me.lblRolCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.lblEnabledCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.txtPhoneCreateUser = New MetroFramework.Controls.MetroTextBox()
        Me.txtPasswordCreateUser = New MetroFramework.Controls.MetroTextBox()
        Me.txtNameCreateUser = New MetroFramework.Controls.MetroTextBox()
        Me.txtIdCreateUser = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancelCreateUser = New MetroFramework.Controls.MetroButton()
        Me.btnSaveCreateUser = New MetroFramework.Controls.MetroButton()
        Me.lblPaswordCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.lblPhoneCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.lblNameCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.lblLastNameCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.lblCedulaCreateUser = New MetroFramework.Controls.MetroLabel()
        Me.lblCreateUserTittle = New MetroFramework.Controls.MetroLabel()
        Me.pnlCreateRol = New MetroFramework.Controls.MetroPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tgUsersRol = New MetroFramework.Controls.MetroToggle()
        Me.lblUsersRol = New MetroFramework.Controls.MetroLabel()
        Me.gboPorductsSectionRol = New System.Windows.Forms.GroupBox()
        Me.lblActisRol = New MetroFramework.Controls.MetroLabel()
        Me.lblCareersRol = New MetroFramework.Controls.MetroLabel()
        Me.tgCareersRol = New MetroFramework.Controls.MetroToggle()
        Me.tgActiRol = New MetroFramework.Controls.MetroToggle()
        Me.lblProductsSectionRol = New MetroFramework.Controls.MetroLabel()
        Me.tgConfigurationRol = New MetroFramework.Controls.MetroToggle()
        Me.tgReportsRol = New MetroFramework.Controls.MetroToggle()
        Me.tgKpiRol = New MetroFramework.Controls.MetroToggle()
        Me.tgEventsRol = New MetroFramework.Controls.MetroToggle()
        Me.tgProspectusRol = New MetroFramework.Controls.MetroToggle()
        Me.tgSalesRol = New MetroFramework.Controls.MetroToggle()
        Me.lblConfigurationRol = New MetroFramework.Controls.MetroLabel()
        Me.lblReportsRol = New MetroFramework.Controls.MetroLabel()
        Me.lblKpiRol = New MetroFramework.Controls.MetroLabel()
        Me.lblEventsRol = New MetroFramework.Controls.MetroLabel()
        Me.lblProspectusRol = New MetroFramework.Controls.MetroLabel()
        Me.lblSalesRol = New MetroFramework.Controls.MetroLabel()
        Me.lblPermissionsRol = New MetroFramework.Controls.MetroLabel()
        Me.tgEnabledRol = New MetroFramework.Controls.MetroToggle()
        Me.txtRolName = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancelRol = New MetroFramework.Controls.MetroButton()
        Me.btnSaveRol = New MetroFramework.Controls.MetroButton()
        Me.btnEnabledRol = New MetroFramework.Controls.MetroLabel()
        Me.lblNameRol = New MetroFramework.Controls.MetroLabel()
        Me.lblRolUserTittle = New MetroFramework.Controls.MetroLabel()
        Me.pnlListRols = New MetroFramework.Controls.MetroPanel()
        Me.btnBackRolsUsers = New MetroFramework.Controls.MetroButton()
        Me.lblIdRol = New MetroFramework.Controls.MetroLabel()
        Me.lstRols = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNameRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStateRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblListOfRols = New MetroFramework.Controls.MetroLabel()
        Me.btnNewRol = New MetroFramework.Controls.MetroButton()
        Me.pnListUsers = New MetroFramework.Controls.MetroPanel()
        Me.lblCreateUpdateUserId = New MetroFramework.Controls.MetroLabel()
        Me.lstUsers = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdentificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblRols = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.btnCreateUser = New MetroFramework.Controls.MetroButton()
        Me.PnlListaSeguimientos = New MetroFramework.Controls.MetroPanel()
        Me.lblIdSeguimiento = New MetroFramework.Controls.MetroLabel()
        Me.lblIdProspecto = New MetroFramework.Controls.MetroLabel()
        Me.btnCancelarListaSeguimiento = New MetroFramework.Controls.MetroButton()
        Me.lstSeguimientos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblListaSeguimientos = New MetroFramework.Controls.MetroLabel()
        Me.tabProspectus = New MetroFramework.Controls.MetroTabPage()
        Me.PnlListaProspectos = New MetroFramework.Controls.MetroPanel()
        Me.lblListaProspectos = New MetroFramework.Controls.MetroLabel()
        Me.btnCrearProspecto = New MetroFramework.Controls.MetroButton()
        Me.lstProspectos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PnlNuevoProspecto = New MetroFramework.Controls.MetroPanel()
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
        Me.pnlSeguimientos = New MetroFramework.Controls.MetroPanel()
        Me.txtComentarioSeguimiento = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancelarSeguimiento = New MetroFramework.Controls.MetroButton()
        Me.btnGuardarSeguimiento = New MetroFramework.Controls.MetroButton()
        Me.lblComentarioSeguimiento = New MetroFramework.Controls.MetroLabel()
        Me.txtFechaSeguimiento = New MetroFramework.Controls.MetroDateTime()
        Me.lblFechaSeguimiento = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.PnlListaProspectos = New MetroFramework.Controls.MetroPanel()
        Me.lblListaProspectos = New MetroFramework.Controls.MetroLabel()
        Me.btnCrearProspecto = New MetroFramework.Controls.MetroButton()
        Me.lstProspectos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tabProducts = New MetroFramework.Controls.MetroTabPage()
        Me.listaActis_pnl = New MetroFramework.Controls.MetroPanel()
        Me.exportarActi_btn = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel54 = New MetroFramework.Controls.MetroLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroLabel55 = New MetroFramework.Controls.MetroLabel()
        Me.vovlerActi_btn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel56 = New MetroFramework.Controls.MetroLabel()
        Me.listaActis_dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horario2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.listaActis_lbl = New MetroFramework.Controls.MetroLabel()
        Me.nuevoActi_btn = New MetroFramework.Controls.MetroButton()
        Me.listaCarreras_pnl = New MetroFramework.Controls.MetroPanel()
        Me.exportarCarreras_btn = New MetroFramework.Controls.MetroButton()
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
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.carreras_lbl = New MetroFramework.Controls.MetroLabel()
        Me.nuevaCarrera_btn = New MetroFramework.Controls.MetroButton()
        Me.registrarActi_pnl = New MetroFramework.Controls.MetroPanel()
        Me.cancelarAct_btn = New MetroFramework.Controls.MetroButton()
        Me.guardarAct_btn = New MetroFramework.Controls.MetroButton()
        Me.importarActis_lbl = New MetroFramework.Controls.MetroLink()
        Me.minsFinActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.horaFinActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.minsFin5Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsFin4Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsFin3Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsFin2Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsFin1Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaFin5Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaFin4Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaFin3Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaFin2Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaFin1Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsIniActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.horaIniActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.minsIni5Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsIni4Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsIni3Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsIni2Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.minsIni1Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaIni5Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaIni4Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaIni3Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaIni2Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.horaIni1Acti_nmb = New System.Windows.Forms.NumericUpDown()
        Me.dia5Acti_cmb = New System.Windows.Forms.ComboBox()
        Me.dia4Acti_cmb = New System.Windows.Forms.ComboBox()
        Me.dia3Acti_cmb = New System.Windows.Forms.ComboBox()
        Me.dia2Acti_cmb = New System.Windows.Forms.ComboBox()
        Me.dia1Acti_cmb = New System.Windows.Forms.ComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.dia5_lbl = New MetroFramework.Controls.MetroLabel()
        Me.dia4Acti_lbl = New MetroFramework.Controls.MetroLabel()
        Me.dia2Acti_lbl = New MetroFramework.Controls.MetroLabel()
        Me.dia3Acti_lbl = New MetroFramework.Controls.MetroLabel()
        Me.dia1Acti_lbl = New MetroFramework.Controls.MetroLabel()
        Me.tipoActi_cmb = New System.Windows.Forms.ComboBox()
        Me.costoActi_text = New MetroFramework.Controls.MetroTextBox()
        Me.nombreActi_text = New MetroFramework.Controls.MetroTextBox()
        Me.codigoActi_text = New MetroFramework.Controls.MetroTextBox()
        Me.nombreActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.tipoActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.codigoActi_lbl = New MetroFramework.Controls.MetroLabel()
        Me.acti_lbl = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.horariosActi_grp = New System.Windows.Forms.GroupBox()
        Me.MetroLabel26 = New MetroFramework.Controls.MetroLabel()
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
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.carreras_lbl = New MetroFramework.Controls.MetroLabel()
        Me.nuevaCarrera_btn = New MetroFramework.Controls.MetroButton()
        Me.listaActis_pnl = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel54 = New MetroFramework.Controls.MetroLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroLabel55 = New MetroFramework.Controls.MetroLabel()
        Me.vovlerActi_btn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel56 = New MetroFramework.Controls.MetroLabel()
        Me.listaActis_dg = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horario2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.listaActis_lbl = New MetroFramework.Controls.MetroLabel()
        Me.nuevoActi_btn = New MetroFramework.Controls.MetroButton()
        Me.registrarCarrera_pnl = New MetroFramework.Controls.MetroPanel()
        Me.cancelarCarrera_btn = New MetroFramework.Controls.MetroButton()
        Me.guardarCarrera_btn = New MetroFramework.Controls.MetroButton()
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel51 = New MetroFramework.Controls.MetroLabel()
        Me.tCareers = New MetroFramework.Controls.MetroTile()
        Me.tActis = New MetroFramework.Controls.MetroTile()
        Me.tabsContainer = New MetroFramework.Controls.MetroTabControl()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSales.SuspendLayout()
        Me.listarVerntas_pnl.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RegistrarVentas_pnl.SuspendLayout()
        CType(Me.listaVentas_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConfiguration.SuspendLayout()
        Me.pnlUpdateUserInfo.SuspendLayout()
        Me.tabUsers.SuspendLayout()
        Me.pnlCreateUser.SuspendLayout()
        Me.pnlCreateRol.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gboPorductsSectionRol.SuspendLayout()
        Me.pnlListRols.SuspendLayout()
        CType(Me.lstRols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnListUsers.SuspendLayout()
        CType(Me.lstUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlListaSeguimientos.SuspendLayout()
        CType(Me.lstSeguimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProspectus.SuspendLayout()
        Me.PnlListaProspectos.SuspendLayout()
        CType(Me.lstProspectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlNuevoProspecto.SuspendLayout()
        Me.pnlSeguimientos.SuspendLayout()
        Me.tabProducts.SuspendLayout()
        Me.registrarActi_pnl.SuspendLayout()
        CType(Me.minsFin5Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsFin4Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsFin3Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsFin2Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsFin1Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin5Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin4Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin3Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin2Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaFin1Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni5Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni4Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni3Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni2Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minsIni1Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni5Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni4Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni3Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni2Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.horaIni1Acti_nmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.horariosActi_grp.SuspendLayout()
        Me.listaCarreras_pnl.SuspendLayout()
        Me.listaCursos_pnl.SuspendLayout()
        CType(Me.listaCursos_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaCarreras_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.listaActis_pnl.SuspendLayout()
        Me.MetroPanel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaActis_dg, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox5.SuspendLayout()
        Me.tabsContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(227, 28)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(0, 0)
        Me.MetroLabel1.TabIndex = 3
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblSignOut
        '
        Me.lblSignOut.Location = New System.Drawing.Point(698, 28)
        Me.lblSignOut.Name = "lblSignOut"
        Me.lblSignOut.Size = New System.Drawing.Size(82, 23)
        Me.lblSignOut.TabIndex = 4
        Me.lblSignOut.Text = "Cerrar sesion"
        Me.lblSignOut.UseSelectable = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'tabReports
        '
        Me.tabReports.HorizontalScrollbarBarColor = True
        Me.tabReports.HorizontalScrollbarHighlightOnWheel = False
        Me.tabReports.HorizontalScrollbarSize = 10
        Me.tabReports.Location = New System.Drawing.Point(4, 44)
        Me.tabReports.Name = "tabReports"
        Me.tabReports.Size = New System.Drawing.Size(752, 472)
        Me.tabReports.TabIndex = 5
        Me.tabReports.Text = "Reportes"
        Me.tabReports.VerticalScrollbarBarColor = True
        Me.tabReports.VerticalScrollbarHighlightOnWheel = False
        Me.tabReports.VerticalScrollbarSize = 10
        '
        'tabKpi
        '
        Me.tabKpi.HorizontalScrollbarBarColor = True
        Me.tabKpi.HorizontalScrollbarHighlightOnWheel = False
        Me.tabKpi.HorizontalScrollbarSize = 10
        Me.tabKpi.Location = New System.Drawing.Point(4, 44)
        Me.tabKpi.Name = "tabKpi"
        Me.tabKpi.Size = New System.Drawing.Size(752, 472)
        Me.tabKpi.TabIndex = 3
        Me.tabKpi.Text = "KPI"
        Me.tabKpi.UseVisualStyleBackColor = True
        Me.tabKpi.VerticalScrollbarBarColor = True
        Me.tabKpi.VerticalScrollbarHighlightOnWheel = False
        Me.tabKpi.VerticalScrollbarSize = 10
        '
        'tabSales
        '
        Me.tabSales.Controls.Add(Me.listarVerntas_pnl)
        Me.tabSales.HorizontalScrollbarBarColor = True
        Me.tabSales.HorizontalScrollbarHighlightOnWheel = False
        Me.tabSales.HorizontalScrollbarSize = 10
        Me.tabSales.Location = New System.Drawing.Point(4, 44)
        Me.tabSales.Name = "tabSales"
        Me.tabSales.Size = New System.Drawing.Size(752, 472)
        Me.tabSales.TabIndex = 9
        Me.tabSales.Text = "Ventas"
        Me.tabSales.VerticalScrollbarBarColor = True
        Me.tabSales.VerticalScrollbarHighlightOnWheel = False
        Me.tabSales.VerticalScrollbarSize = 10
        '
        'listarVerntas_pnl
        '
        Me.listarVerntas_pnl.Controls.Add(Me.MetroPanel2)
        Me.listarVerntas_pnl.Controls.Add(Me.RegistrarVentas_pnl)
        Me.listarVerntas_pnl.Controls.Add(Me.volverVenta_btn)
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
        Me.listarVerntas_pnl.TabIndex = 51
        Me.listarVerntas_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.listarVerntas_pnl.VerticalScrollbarBarColor = True
        Me.listarVerntas_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.listarVerntas_pnl.VerticalScrollbarSize = 10
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
        'RegistrarVentas_pnl
        '
        Me.RegistrarVentas_pnl.Controls.Add(Me.guardarVenta_btn)
        Me.RegistrarVentas_pnl.Controls.Add(Me.cancelarVenta_btn)
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
        Me.RegistrarVentas_pnl.TabIndex = 37
        Me.RegistrarVentas_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.RegistrarVentas_pnl.VerticalScrollbarBarColor = True
        Me.RegistrarVentas_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.RegistrarVentas_pnl.VerticalScrollbarSize = 10
        Me.RegistrarVentas_pnl.Visible = False
        '
        'guardarVenta_btn
        '
        Me.guardarVenta_btn.Location = New System.Drawing.Point(620, 412)
        Me.guardarVenta_btn.Name = "guardarVenta_btn"
        Me.guardarVenta_btn.Size = New System.Drawing.Size(123, 36)
        Me.guardarVenta_btn.TabIndex = 83
        Me.guardarVenta_btn.Text = "Guardar"
        Me.guardarVenta_btn.UseSelectable = True
        '
        'cancelarVenta_btn
        '
        Me.cancelarVenta_btn.Location = New System.Drawing.Point(7, 412)
        Me.cancelarVenta_btn.Name = "cancelarVenta_btn"
        Me.cancelarVenta_btn.Size = New System.Drawing.Size(123, 36)
        Me.cancelarVenta_btn.TabIndex = 82
        Me.cancelarVenta_btn.Text = "Cancelar"
        Me.cancelarVenta_btn.UseSelectable = True
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
        Me.matricula_text.MaxLength = 32767
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
        Me.totalVenta_text.Location = New System.Drawing.Point(465, 252)
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
        Me.totalVenta__lbl.Location = New System.Drawing.Point(401, 252)
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
        'volverVenta_btn
        '
        Me.volverVenta_btn.Location = New System.Drawing.Point(7, 412)
        Me.volverVenta_btn.Name = "volverVenta_btn"
        Me.volverVenta_btn.Size = New System.Drawing.Size(123, 36)
        Me.volverVenta_btn.TabIndex = 50
        Me.volverVenta_btn.Text = "Volver"
        Me.volverVenta_btn.UseSelectable = True
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
        Me.listaVentas_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewImageColumn9})
        Me.listaVentas_dg.Location = New System.Drawing.Point(7, 37)
        Me.listaVentas_dg.Name = "listaVentas_dg"
        Me.listaVentas_dg.RowHeadersVisible = False
        Me.listaVentas_dg.Size = New System.Drawing.Size(739, 344)
        Me.listaVentas_dg.TabIndex = 12
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn23.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "Horario"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
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
        Me.listarVentas_lbl.Location = New System.Drawing.Point(4, 9)
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
        'tabEvents
        '
        Me.tabEvents.HorizontalScrollbarBarColor = True
        Me.tabEvents.HorizontalScrollbarHighlightOnWheel = False
        Me.tabEvents.HorizontalScrollbarSize = 10
        Me.tabEvents.Location = New System.Drawing.Point(4, 44)
        Me.tabEvents.Name = "tabEvents"
        Me.tabEvents.Size = New System.Drawing.Size(752, 472)
        Me.tabEvents.TabIndex = 7
        Me.tabEvents.Text = "Eventos"
        Me.tabEvents.VerticalScrollbarBarColor = True
        Me.tabEvents.VerticalScrollbarHighlightOnWheel = False
        Me.tabEvents.VerticalScrollbarSize = 10
        '
        'tabConfiguration
        '
        Me.tabConfiguration.Controls.Add(Me.pnlUpdateUserInfo)
        Me.tabConfiguration.Controls.Add(Me.tUpdateUserInformation)
        Me.tabConfiguration.Controls.Add(Me.tSignOutUser)
        Me.tabConfiguration.HorizontalScrollbarBarColor = True
        Me.tabConfiguration.HorizontalScrollbarHighlightOnWheel = False
        Me.tabConfiguration.HorizontalScrollbarSize = 10
        Me.tabConfiguration.Location = New System.Drawing.Point(4, 44)
        Me.tabConfiguration.Name = "tabConfiguration"
        Me.tabConfiguration.Size = New System.Drawing.Size(752, 472)
        Me.tabConfiguration.Style = MetroFramework.MetroColorStyle.Silver
        Me.tabConfiguration.TabIndex = 8
        Me.tabConfiguration.Text = "Configuración"
        Me.tabConfiguration.VerticalScrollbarBarColor = True
        Me.tabConfiguration.VerticalScrollbarHighlightOnWheel = False
        Me.tabConfiguration.VerticalScrollbarSize = 10
        '
        'pnlUpdateUserInfo
        '
        Me.pnlUpdateUserInfo.Controls.Add(Me.tgChangePassUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtPasswordUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.MetroLabel13)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtNewPassUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblNewpassUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.cboDateUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblDateUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtEmailUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblEmailUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtLastNameUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtPhoneUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtNameUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.txtIdUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.btnCancelUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.btnSaveUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblPasswordUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblPhoneUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblNameUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblLastNameUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.lblIdUpdateUserInfo)
        Me.pnlUpdateUserInfo.Controls.Add(Me.MetroLabel23)
        Me.pnlUpdateUserInfo.HorizontalScrollbarBarColor = True
        Me.pnlUpdateUserInfo.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlUpdateUserInfo.HorizontalScrollbarSize = 10
        Me.pnlUpdateUserInfo.Location = New System.Drawing.Point(3, 5)
        Me.pnlUpdateUserInfo.Name = "pnlUpdateUserInfo"
        Me.pnlUpdateUserInfo.Size = New System.Drawing.Size(746, 462)
        Me.pnlUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.pnlUpdateUserInfo.TabIndex = 6
        Me.pnlUpdateUserInfo.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnlUpdateUserInfo.VerticalScrollbarBarColor = True
        Me.pnlUpdateUserInfo.VerticalScrollbarHighlightOnWheel = False
        Me.pnlUpdateUserInfo.VerticalScrollbarSize = 10
        Me.pnlUpdateUserInfo.Visible = False
        '
        'tgChangePassUpdateUserInfo
        '
        Me.tgChangePassUpdateUserInfo.AutoSize = True
        Me.tgChangePassUpdateUserInfo.Location = New System.Drawing.Point(181, 250)
        Me.tgChangePassUpdateUserInfo.Name = "tgChangePassUpdateUserInfo"
        Me.tgChangePassUpdateUserInfo.Size = New System.Drawing.Size(80, 17)
        Me.tgChangePassUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgChangePassUpdateUserInfo.TabIndex = 50
        Me.tgChangePassUpdateUserInfo.Text = "Off"
        Me.tgChangePassUpdateUserInfo.UseSelectable = True
        '
        'txtPasswordUpdateUserInfo
        '
        '
        '
        '
        Me.txtPasswordUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtPasswordUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtPasswordUpdateUserInfo.CustomButton.Name = ""
        Me.txtPasswordUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPasswordUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPasswordUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtPasswordUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPasswordUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtPasswordUpdateUserInfo.CustomButton.Visible = False
        Me.txtPasswordUpdateUserInfo.Lines = New String(-1) {}
        Me.txtPasswordUpdateUserInfo.Location = New System.Drawing.Point(181, 308)
        Me.txtPasswordUpdateUserInfo.MaxLength = 50
        Me.txtPasswordUpdateUserInfo.Name = "txtPasswordUpdateUserInfo"
        Me.txtPasswordUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPasswordUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPasswordUpdateUserInfo.SelectedText = ""
        Me.txtPasswordUpdateUserInfo.SelectionLength = 0
        Me.txtPasswordUpdateUserInfo.SelectionStart = 0
        Me.txtPasswordUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtPasswordUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtPasswordUpdateUserInfo.TabIndex = 49
        Me.txtPasswordUpdateUserInfo.UseSelectable = True
        Me.txtPasswordUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPasswordUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(25, 312)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(136, 19)
        Me.MetroLabel13.TabIndex = 48
        Me.MetroLabel13.Text = "Confirmar contraseña"
        '
        'txtNewPassUpdateUserInfo
        '
        '
        '
        '
        Me.txtNewPassUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtNewPassUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtNewPassUpdateUserInfo.CustomButton.Name = ""
        Me.txtNewPassUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNewPassUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNewPassUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtNewPassUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNewPassUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtNewPassUpdateUserInfo.CustomButton.Visible = False
        Me.txtNewPassUpdateUserInfo.Enabled = False
        Me.txtNewPassUpdateUserInfo.Lines = New String(-1) {}
        Me.txtNewPassUpdateUserInfo.Location = New System.Drawing.Point(181, 277)
        Me.txtNewPassUpdateUserInfo.MaxLength = 50
        Me.txtNewPassUpdateUserInfo.Name = "txtNewPassUpdateUserInfo"
        Me.txtNewPassUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPassUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNewPassUpdateUserInfo.SelectedText = ""
        Me.txtNewPassUpdateUserInfo.SelectionLength = 0
        Me.txtNewPassUpdateUserInfo.SelectionStart = 0
        Me.txtNewPassUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtNewPassUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtNewPassUpdateUserInfo.TabIndex = 47
        Me.txtNewPassUpdateUserInfo.UseSelectable = True
        Me.txtNewPassUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNewPassUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblNewpassUpdateUserInfo
        '
        Me.lblNewpassUpdateUserInfo.AutoSize = True
        Me.lblNewpassUpdateUserInfo.Enabled = False
        Me.lblNewpassUpdateUserInfo.Location = New System.Drawing.Point(25, 281)
        Me.lblNewpassUpdateUserInfo.Name = "lblNewpassUpdateUserInfo"
        Me.lblNewpassUpdateUserInfo.Size = New System.Drawing.Size(118, 19)
        Me.lblNewpassUpdateUserInfo.TabIndex = 46
        Me.lblNewpassUpdateUserInfo.Text = "Nueva constraseña"
        '
        'cboDateUpdateUserInfo
        '
        Me.cboDateUpdateUserInfo.Location = New System.Drawing.Point(181, 175)
        Me.cboDateUpdateUserInfo.MinimumSize = New System.Drawing.Size(4, 29)
        Me.cboDateUpdateUserInfo.Name = "cboDateUpdateUserInfo"
        Me.cboDateUpdateUserInfo.Size = New System.Drawing.Size(366, 29)
        Me.cboDateUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.cboDateUpdateUserInfo.TabIndex = 45
        '
        'lblDateUpdateUserInfo
        '
        Me.lblDateUpdateUserInfo.AutoSize = True
        Me.lblDateUpdateUserInfo.Location = New System.Drawing.Point(24, 185)
        Me.lblDateUpdateUserInfo.Name = "lblDateUpdateUserInfo"
        Me.lblDateUpdateUserInfo.Size = New System.Drawing.Size(111, 19)
        Me.lblDateUpdateUserInfo.TabIndex = 44
        Me.lblDateUpdateUserInfo.Text = "Fecha nacimiento"
        '
        'txtEmailUpdateUserInfo
        '
        '
        '
        '
        Me.txtEmailUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtEmailUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtEmailUpdateUserInfo.CustomButton.Name = ""
        Me.txtEmailUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmailUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmailUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtEmailUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmailUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtEmailUpdateUserInfo.CustomButton.Visible = False
        Me.txtEmailUpdateUserInfo.Lines = New String(-1) {}
        Me.txtEmailUpdateUserInfo.Location = New System.Drawing.Point(181, 144)
        Me.txtEmailUpdateUserInfo.MaxLength = 50
        Me.txtEmailUpdateUserInfo.Name = "txtEmailUpdateUserInfo"
        Me.txtEmailUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmailUpdateUserInfo.SelectedText = ""
        Me.txtEmailUpdateUserInfo.SelectionLength = 0
        Me.txtEmailUpdateUserInfo.SelectionStart = 0
        Me.txtEmailUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtEmailUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtEmailUpdateUserInfo.TabIndex = 43
        Me.txtEmailUpdateUserInfo.UseSelectable = True
        Me.txtEmailUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmailUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblEmailUpdateUserInfo
        '
        Me.lblEmailUpdateUserInfo.AutoSize = True
        Me.lblEmailUpdateUserInfo.Location = New System.Drawing.Point(24, 148)
        Me.lblEmailUpdateUserInfo.Name = "lblEmailUpdateUserInfo"
        Me.lblEmailUpdateUserInfo.Size = New System.Drawing.Size(51, 19)
        Me.lblEmailUpdateUserInfo.TabIndex = 42
        Me.lblEmailUpdateUserInfo.Text = "Correo"
        '
        'txtLastNameUpdateUserInfo
        '
        '
        '
        '
        Me.txtLastNameUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtLastNameUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtLastNameUpdateUserInfo.CustomButton.Name = ""
        Me.txtLastNameUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLastNameUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLastNameUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtLastNameUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLastNameUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtLastNameUpdateUserInfo.CustomButton.Visible = False
        Me.txtLastNameUpdateUserInfo.Lines = New String(-1) {}
        Me.txtLastNameUpdateUserInfo.Location = New System.Drawing.Point(181, 113)
        Me.txtLastNameUpdateUserInfo.MaxLength = 50
        Me.txtLastNameUpdateUserInfo.Name = "txtLastNameUpdateUserInfo"
        Me.txtLastNameUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastNameUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastNameUpdateUserInfo.SelectedText = ""
        Me.txtLastNameUpdateUserInfo.SelectionLength = 0
        Me.txtLastNameUpdateUserInfo.SelectionStart = 0
        Me.txtLastNameUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtLastNameUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtLastNameUpdateUserInfo.TabIndex = 41
        Me.txtLastNameUpdateUserInfo.UseSelectable = True
        Me.txtLastNameUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLastNameUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPhoneUpdateUserInfo
        '
        '
        '
        '
        Me.txtPhoneUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtPhoneUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtPhoneUpdateUserInfo.CustomButton.Name = ""
        Me.txtPhoneUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPhoneUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhoneUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtPhoneUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhoneUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtPhoneUpdateUserInfo.CustomButton.Visible = False
        Me.txtPhoneUpdateUserInfo.Lines = New String(-1) {}
        Me.txtPhoneUpdateUserInfo.Location = New System.Drawing.Point(181, 215)
        Me.txtPhoneUpdateUserInfo.MaxLength = 30
        Me.txtPhoneUpdateUserInfo.Name = "txtPhoneUpdateUserInfo"
        Me.txtPhoneUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhoneUpdateUserInfo.SelectedText = ""
        Me.txtPhoneUpdateUserInfo.SelectionLength = 0
        Me.txtPhoneUpdateUserInfo.SelectionStart = 0
        Me.txtPhoneUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtPhoneUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtPhoneUpdateUserInfo.TabIndex = 33
        Me.txtPhoneUpdateUserInfo.UseSelectable = True
        Me.txtPhoneUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhoneUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNameUpdateUserInfo
        '
        '
        '
        '
        Me.txtNameUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtNameUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtNameUpdateUserInfo.CustomButton.Name = ""
        Me.txtNameUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNameUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNameUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtNameUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNameUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtNameUpdateUserInfo.CustomButton.Visible = False
        Me.txtNameUpdateUserInfo.Lines = New String(-1) {}
        Me.txtNameUpdateUserInfo.Location = New System.Drawing.Point(181, 82)
        Me.txtNameUpdateUserInfo.MaxLength = 50
        Me.txtNameUpdateUserInfo.Name = "txtNameUpdateUserInfo"
        Me.txtNameUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNameUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNameUpdateUserInfo.SelectedText = ""
        Me.txtNameUpdateUserInfo.SelectionLength = 0
        Me.txtNameUpdateUserInfo.SelectionStart = 0
        Me.txtNameUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtNameUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtNameUpdateUserInfo.TabIndex = 25
        Me.txtNameUpdateUserInfo.UseSelectable = True
        Me.txtNameUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNameUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtIdUpdateUserInfo
        '
        '
        '
        '
        Me.txtIdUpdateUserInfo.CustomButton.Image = Nothing
        Me.txtIdUpdateUserInfo.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtIdUpdateUserInfo.CustomButton.Name = ""
        Me.txtIdUpdateUserInfo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtIdUpdateUserInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIdUpdateUserInfo.CustomButton.TabIndex = 1
        Me.txtIdUpdateUserInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIdUpdateUserInfo.CustomButton.UseSelectable = True
        Me.txtIdUpdateUserInfo.CustomButton.Visible = False
        Me.txtIdUpdateUserInfo.Lines = New String(-1) {}
        Me.txtIdUpdateUserInfo.Location = New System.Drawing.Point(181, 51)
        Me.txtIdUpdateUserInfo.MaxLength = 50
        Me.txtIdUpdateUserInfo.Name = "txtIdUpdateUserInfo"
        Me.txtIdUpdateUserInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdUpdateUserInfo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIdUpdateUserInfo.SelectedText = ""
        Me.txtIdUpdateUserInfo.SelectionLength = 0
        Me.txtIdUpdateUserInfo.SelectionStart = 0
        Me.txtIdUpdateUserInfo.Size = New System.Drawing.Size(367, 23)
        Me.txtIdUpdateUserInfo.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtIdUpdateUserInfo.TabIndex = 24
        Me.txtIdUpdateUserInfo.UseSelectable = True
        Me.txtIdUpdateUserInfo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIdUpdateUserInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCancelUpdateUserInfo
        '
        Me.btnCancelUpdateUserInfo.Location = New System.Drawing.Point(450, 436)
        Me.btnCancelUpdateUserInfo.Name = "btnCancelUpdateUserInfo"
        Me.btnCancelUpdateUserInfo.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelUpdateUserInfo.TabIndex = 23
        Me.btnCancelUpdateUserInfo.Text = "Cancelar"
        Me.btnCancelUpdateUserInfo.UseSelectable = True
        '
        'btnSaveUpdateUserInfo
        '
        Me.btnSaveUpdateUserInfo.Location = New System.Drawing.Point(347, 436)
        Me.btnSaveUpdateUserInfo.Name = "btnSaveUpdateUserInfo"
        Me.btnSaveUpdateUserInfo.Size = New System.Drawing.Size(97, 23)
        Me.btnSaveUpdateUserInfo.TabIndex = 22
        Me.btnSaveUpdateUserInfo.Text = "Guardar"
        Me.btnSaveUpdateUserInfo.UseSelectable = True
        '
        'lblPasswordUpdateUserInfo
        '
        Me.lblPasswordUpdateUserInfo.AutoSize = True
        Me.lblPasswordUpdateUserInfo.Location = New System.Drawing.Point(24, 250)
        Me.lblPasswordUpdateUserInfo.Name = "lblPasswordUpdateUserInfo"
        Me.lblPasswordUpdateUserInfo.Size = New System.Drawing.Size(127, 19)
        Me.lblPasswordUpdateUserInfo.TabIndex = 19
        Me.lblPasswordUpdateUserInfo.Text = "Cambiar contraseña"
        '
        'lblPhoneUpdateUserInfo
        '
        Me.lblPhoneUpdateUserInfo.AutoSize = True
        Me.lblPhoneUpdateUserInfo.Location = New System.Drawing.Point(24, 215)
        Me.lblPhoneUpdateUserInfo.Name = "lblPhoneUpdateUserInfo"
        Me.lblPhoneUpdateUserInfo.Size = New System.Drawing.Size(58, 19)
        Me.lblPhoneUpdateUserInfo.TabIndex = 15
        Me.lblPhoneUpdateUserInfo.Text = "Telefono"
        '
        'lblNameUpdateUserInfo
        '
        Me.lblNameUpdateUserInfo.AutoSize = True
        Me.lblNameUpdateUserInfo.Location = New System.Drawing.Point(24, 82)
        Me.lblNameUpdateUserInfo.Name = "lblNameUpdateUserInfo"
        Me.lblNameUpdateUserInfo.Size = New System.Drawing.Size(59, 19)
        Me.lblNameUpdateUserInfo.TabIndex = 14
        Me.lblNameUpdateUserInfo.Text = "Nombre"
        '
        'lblLastNameUpdateUserInfo
        '
        Me.lblLastNameUpdateUserInfo.AutoSize = True
        Me.lblLastNameUpdateUserInfo.Location = New System.Drawing.Point(25, 114)
        Me.lblLastNameUpdateUserInfo.Name = "lblLastNameUpdateUserInfo"
        Me.lblLastNameUpdateUserInfo.Size = New System.Drawing.Size(58, 19)
        Me.lblLastNameUpdateUserInfo.TabIndex = 13
        Me.lblLastNameUpdateUserInfo.Text = "Apellido"
        '
        'lblIdUpdateUserInfo
        '
        Me.lblIdUpdateUserInfo.AutoSize = True
        Me.lblIdUpdateUserInfo.Location = New System.Drawing.Point(24, 51)
        Me.lblIdUpdateUserInfo.Name = "lblIdUpdateUserInfo"
        Me.lblIdUpdateUserInfo.Size = New System.Drawing.Size(50, 19)
        Me.lblIdUpdateUserInfo.TabIndex = 11
        Me.lblIdUpdateUserInfo.Text = "Cedula"
        '
        'MetroLabel23
        '
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel23.Location = New System.Drawing.Point(4, 9)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(214, 25)
        Me.MetroLabel23.TabIndex = 10
        Me.MetroLabel23.Text = "Modificar datos de usuario"
        '
        'tUpdateUserInformation
        '
        Me.tUpdateUserInformation.ActiveControl = Nothing
        Me.tUpdateUserInformation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tUpdateUserInformation.Location = New System.Drawing.Point(24, 27)
        Me.tUpdateUserInformation.Name = "tUpdateUserInformation"
        Me.tUpdateUserInformation.Size = New System.Drawing.Size(124, 119)
        Me.tUpdateUserInformation.Style = MetroFramework.MetroColorStyle.Purple
        Me.tUpdateUserInformation.TabIndex = 5
        Me.tUpdateUserInformation.Text = "Cambiar datos"
        Me.tUpdateUserInformation.UseSelectable = True
        '
        'tSignOutUser
        '
        Me.tSignOutUser.ActiveControl = Nothing
        Me.tSignOutUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tSignOutUser.Location = New System.Drawing.Point(165, 27)
        Me.tSignOutUser.Name = "tSignOutUser"
        Me.tSignOutUser.Size = New System.Drawing.Size(124, 119)
        Me.tSignOutUser.Style = MetroFramework.MetroColorStyle.Silver
        Me.tSignOutUser.TabIndex = 4
        Me.tSignOutUser.Text = "Cerrar sesión"
        Me.tSignOutUser.UseSelectable = True
        '
        'tabUsers
        '
        Me.tabUsers.Controls.Add(Me.pnlCreateUser)
        Me.tabUsers.Controls.Add(Me.pnlCreateRol)
        Me.tabUsers.Controls.Add(Me.pnlListRols)
        Me.tabUsers.Controls.Add(Me.pnListUsers)
        Me.tabUsers.HorizontalScrollbarBarColor = True
        Me.tabUsers.HorizontalScrollbarHighlightOnWheel = False
        Me.tabUsers.HorizontalScrollbarSize = 10
        Me.tabUsers.Location = New System.Drawing.Point(4, 44)
        Me.tabUsers.Name = "tabUsers"
        Me.tabUsers.Size = New System.Drawing.Size(752, 472)
        Me.tabUsers.TabIndex = 2
        Me.tabUsers.Text = "Usuarios"
        Me.tabUsers.VerticalScrollbarBarColor = True
        Me.tabUsers.VerticalScrollbarHighlightOnWheel = False
        Me.tabUsers.VerticalScrollbarSize = 10
        '
        'pnlCreateUser
        '
        Me.pnlCreateUser.Controls.Add(Me.lblPasswordUserBackup)
        Me.pnlCreateUser.Controls.Add(Me.chkChangeUserPassword)
        Me.pnlCreateUser.Controls.Add(Me.cboDateCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblDateCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.txtEmailCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblEmailCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.txtLastNameCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.cboRolCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.tgEnableCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblRolCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblEnabledCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.txtPhoneCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.txtPasswordCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.txtNameCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.txtIdCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.btnCancelCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.btnSaveCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblPaswordCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblPhoneCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblNameCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblLastNameCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblCedulaCreateUser)
        Me.pnlCreateUser.Controls.Add(Me.lblCreateUserTittle)
        Me.pnlCreateUser.HorizontalScrollbarBarColor = True
        Me.pnlCreateUser.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlCreateUser.HorizontalScrollbarSize = 10
        Me.pnlCreateUser.Location = New System.Drawing.Point(3, 5)
        Me.pnlCreateUser.Name = "pnlCreateUser"
        Me.pnlCreateUser.Size = New System.Drawing.Size(746, 462)
        Me.pnlCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.pnlCreateUser.TabIndex = 5
        Me.pnlCreateUser.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnlCreateUser.VerticalScrollbarBarColor = True
        Me.pnlCreateUser.VerticalScrollbarHighlightOnWheel = False
        Me.pnlCreateUser.VerticalScrollbarSize = 10
        '
        'lblPasswordUserBackup
        '
        Me.lblPasswordUserBackup.AutoSize = True
        Me.lblPasswordUserBackup.Location = New System.Drawing.Point(20, 436)
        Me.lblPasswordUserBackup.Name = "lblPasswordUserBackup"
        Me.lblPasswordUserBackup.Size = New System.Drawing.Size(122, 13)
        Me.lblPasswordUserBackup.TabIndex = 48
        Me.lblPasswordUserBackup.Text = "lblPasswordUserBackup"
        Me.lblPasswordUserBackup.Visible = False
        '
        'chkChangeUserPassword
        '
        Me.chkChangeUserPassword.AutoSize = True
        Me.chkChangeUserPassword.Location = New System.Drawing.Point(531, 254)
        Me.chkChangeUserPassword.Name = "chkChangeUserPassword"
        Me.chkChangeUserPassword.Size = New System.Drawing.Size(68, 15)
        Me.chkChangeUserPassword.Style = MetroFramework.MetroColorStyle.Purple
        Me.chkChangeUserPassword.TabIndex = 47
        Me.chkChangeUserPassword.Text = "Cambiar"
        Me.chkChangeUserPassword.UseSelectable = True
        '
        'cboDateCreateUser
        '
        Me.cboDateCreateUser.Location = New System.Drawing.Point(158, 175)
        Me.cboDateCreateUser.MinimumSize = New System.Drawing.Size(4, 29)
        Me.cboDateCreateUser.Name = "cboDateCreateUser"
        Me.cboDateCreateUser.Size = New System.Drawing.Size(366, 29)
        Me.cboDateCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.cboDateCreateUser.TabIndex = 5
        '
        'lblDateCreateUser
        '
        Me.lblDateCreateUser.AutoSize = True
        Me.lblDateCreateUser.Location = New System.Drawing.Point(24, 185)
        Me.lblDateCreateUser.Name = "lblDateCreateUser"
        Me.lblDateCreateUser.Size = New System.Drawing.Size(111, 19)
        Me.lblDateCreateUser.TabIndex = 44
        Me.lblDateCreateUser.Text = "Fecha nacimiento"
        '
        'txtEmailCreateUser
        '
        '
        '
        '
        Me.txtEmailCreateUser.CustomButton.Image = Nothing
        Me.txtEmailCreateUser.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtEmailCreateUser.CustomButton.Name = ""
        Me.txtEmailCreateUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmailCreateUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmailCreateUser.CustomButton.TabIndex = 1
        Me.txtEmailCreateUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmailCreateUser.CustomButton.UseSelectable = True
        Me.txtEmailCreateUser.CustomButton.Visible = False
        Me.txtEmailCreateUser.Lines = New String(-1) {}
        Me.txtEmailCreateUser.Location = New System.Drawing.Point(158, 144)
        Me.txtEmailCreateUser.MaxLength = 49
        Me.txtEmailCreateUser.Name = "txtEmailCreateUser"
        Me.txtEmailCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailCreateUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmailCreateUser.SelectedText = ""
        Me.txtEmailCreateUser.SelectionLength = 0
        Me.txtEmailCreateUser.SelectionStart = 0
        Me.txtEmailCreateUser.Size = New System.Drawing.Size(367, 23)
        Me.txtEmailCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtEmailCreateUser.TabIndex = 4
        Me.txtEmailCreateUser.UseSelectable = True
        Me.txtEmailCreateUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmailCreateUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblEmailCreateUser
        '
        Me.lblEmailCreateUser.AutoSize = True
        Me.lblEmailCreateUser.Location = New System.Drawing.Point(24, 148)
        Me.lblEmailCreateUser.Name = "lblEmailCreateUser"
        Me.lblEmailCreateUser.Size = New System.Drawing.Size(51, 19)
        Me.lblEmailCreateUser.TabIndex = 42
        Me.lblEmailCreateUser.Text = "Correo"
        '
        'txtLastNameCreateUser
        '
        '
        '
        '
        Me.txtLastNameCreateUser.CustomButton.Image = Nothing
        Me.txtLastNameCreateUser.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtLastNameCreateUser.CustomButton.Name = ""
        Me.txtLastNameCreateUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLastNameCreateUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLastNameCreateUser.CustomButton.TabIndex = 1
        Me.txtLastNameCreateUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLastNameCreateUser.CustomButton.UseSelectable = True
        Me.txtLastNameCreateUser.CustomButton.Visible = False
        Me.txtLastNameCreateUser.Lines = New String(-1) {}
        Me.txtLastNameCreateUser.Location = New System.Drawing.Point(158, 113)
        Me.txtLastNameCreateUser.MaxLength = 49
        Me.txtLastNameCreateUser.Name = "txtLastNameCreateUser"
        Me.txtLastNameCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastNameCreateUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastNameCreateUser.SelectedText = ""
        Me.txtLastNameCreateUser.SelectionLength = 0
        Me.txtLastNameCreateUser.SelectionStart = 0
        Me.txtLastNameCreateUser.Size = New System.Drawing.Size(367, 23)
        Me.txtLastNameCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtLastNameCreateUser.TabIndex = 3
        Me.txtLastNameCreateUser.UseSelectable = True
        Me.txtLastNameCreateUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLastNameCreateUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cboRolCreateUser
        '
        Me.cboRolCreateUser.FormattingEnabled = True
        Me.cboRolCreateUser.ItemHeight = 23
        Me.cboRolCreateUser.Location = New System.Drawing.Point(158, 277)
        Me.cboRolCreateUser.Name = "cboRolCreateUser"
        Me.cboRolCreateUser.Size = New System.Drawing.Size(367, 29)
        Me.cboRolCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.cboRolCreateUser.TabIndex = 8
        Me.cboRolCreateUser.UseSelectable = True
        '
        'tgEnableCreateUser
        '
        Me.tgEnableCreateUser.AutoSize = True
        Me.tgEnableCreateUser.Location = New System.Drawing.Point(158, 321)
        Me.tgEnableCreateUser.Name = "tgEnableCreateUser"
        Me.tgEnableCreateUser.Size = New System.Drawing.Size(80, 17)
        Me.tgEnableCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgEnableCreateUser.TabIndex = 9
        Me.tgEnableCreateUser.Text = "Off"
        Me.tgEnableCreateUser.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tgEnableCreateUser.UseSelectable = True
        '
        'lblRolCreateUser
        '
        Me.lblRolCreateUser.AutoSize = True
        Me.lblRolCreateUser.Location = New System.Drawing.Point(26, 287)
        Me.lblRolCreateUser.Name = "lblRolCreateUser"
        Me.lblRolCreateUser.Size = New System.Drawing.Size(28, 19)
        Me.lblRolCreateUser.TabIndex = 39
        Me.lblRolCreateUser.Text = "Rol"
        '
        'lblEnabledCreateUser
        '
        Me.lblEnabledCreateUser.AutoSize = True
        Me.lblEnabledCreateUser.Location = New System.Drawing.Point(26, 319)
        Me.lblEnabledCreateUser.Name = "lblEnabledCreateUser"
        Me.lblEnabledCreateUser.Size = New System.Drawing.Size(45, 19)
        Me.lblEnabledCreateUser.TabIndex = 37
        Me.lblEnabledCreateUser.Text = "Activo"
        '
        'txtPhoneCreateUser
        '
        '
        '
        '
        Me.txtPhoneCreateUser.CustomButton.Image = Nothing
        Me.txtPhoneCreateUser.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtPhoneCreateUser.CustomButton.Name = ""
        Me.txtPhoneCreateUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPhoneCreateUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhoneCreateUser.CustomButton.TabIndex = 1
        Me.txtPhoneCreateUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhoneCreateUser.CustomButton.UseSelectable = True
        Me.txtPhoneCreateUser.CustomButton.Visible = False
        Me.txtPhoneCreateUser.Lines = New String(-1) {}
        Me.txtPhoneCreateUser.Location = New System.Drawing.Point(158, 215)
        Me.txtPhoneCreateUser.MaxLength = 30
        Me.txtPhoneCreateUser.Name = "txtPhoneCreateUser"
        Me.txtPhoneCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneCreateUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhoneCreateUser.SelectedText = ""
        Me.txtPhoneCreateUser.SelectionLength = 0
        Me.txtPhoneCreateUser.SelectionStart = 0
        Me.txtPhoneCreateUser.Size = New System.Drawing.Size(367, 23)
        Me.txtPhoneCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtPhoneCreateUser.TabIndex = 6
        Me.txtPhoneCreateUser.UseSelectable = True
        Me.txtPhoneCreateUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhoneCreateUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPasswordCreateUser
        '
        '
        '
        '
        Me.txtPasswordCreateUser.CustomButton.Image = Nothing
        Me.txtPasswordCreateUser.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtPasswordCreateUser.CustomButton.Name = ""
        Me.txtPasswordCreateUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPasswordCreateUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPasswordCreateUser.CustomButton.TabIndex = 1
        Me.txtPasswordCreateUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPasswordCreateUser.CustomButton.UseSelectable = True
        Me.txtPasswordCreateUser.CustomButton.Visible = False
        Me.txtPasswordCreateUser.Lines = New String(-1) {}
        Me.txtPasswordCreateUser.Location = New System.Drawing.Point(158, 246)
        Me.txtPasswordCreateUser.MaxLength = 49
        Me.txtPasswordCreateUser.Name = "txtPasswordCreateUser"
        Me.txtPasswordCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPasswordCreateUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPasswordCreateUser.SelectedText = ""
        Me.txtPasswordCreateUser.SelectionLength = 0
        Me.txtPasswordCreateUser.SelectionStart = 0
        Me.txtPasswordCreateUser.Size = New System.Drawing.Size(367, 23)
        Me.txtPasswordCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtPasswordCreateUser.TabIndex = 7
        Me.txtPasswordCreateUser.UseSelectable = True
        Me.txtPasswordCreateUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPasswordCreateUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNameCreateUser
        '
        '
        '
        '
        Me.txtNameCreateUser.CustomButton.Image = Nothing
        Me.txtNameCreateUser.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtNameCreateUser.CustomButton.Name = ""
        Me.txtNameCreateUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNameCreateUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNameCreateUser.CustomButton.TabIndex = 1
        Me.txtNameCreateUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNameCreateUser.CustomButton.UseSelectable = True
        Me.txtNameCreateUser.CustomButton.Visible = False
        Me.txtNameCreateUser.Lines = New String(-1) {}
        Me.txtNameCreateUser.Location = New System.Drawing.Point(158, 82)
        Me.txtNameCreateUser.MaxLength = 49
        Me.txtNameCreateUser.Name = "txtNameCreateUser"
        Me.txtNameCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNameCreateUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNameCreateUser.SelectedText = ""
        Me.txtNameCreateUser.SelectionLength = 0
        Me.txtNameCreateUser.SelectionStart = 0
        Me.txtNameCreateUser.Size = New System.Drawing.Size(367, 23)
        Me.txtNameCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtNameCreateUser.TabIndex = 2
        Me.txtNameCreateUser.UseSelectable = True
        Me.txtNameCreateUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNameCreateUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtIdCreateUser
        '
        '
        '
        '
        Me.txtIdCreateUser.CustomButton.Image = Nothing
        Me.txtIdCreateUser.CustomButton.Location = New System.Drawing.Point(345, 1)
        Me.txtIdCreateUser.CustomButton.Name = ""
        Me.txtIdCreateUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtIdCreateUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIdCreateUser.CustomButton.TabIndex = 1
        Me.txtIdCreateUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIdCreateUser.CustomButton.UseSelectable = True
        Me.txtIdCreateUser.CustomButton.Visible = False
        Me.txtIdCreateUser.Lines = New String(-1) {}
        Me.txtIdCreateUser.Location = New System.Drawing.Point(158, 51)
        Me.txtIdCreateUser.MaxLength = 49
        Me.txtIdCreateUser.Name = "txtIdCreateUser"
        Me.txtIdCreateUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCreateUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIdCreateUser.SelectedText = ""
        Me.txtIdCreateUser.SelectionLength = 0
        Me.txtIdCreateUser.SelectionStart = 0
        Me.txtIdCreateUser.Size = New System.Drawing.Size(367, 23)
        Me.txtIdCreateUser.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtIdCreateUser.TabIndex = 1
        Me.txtIdCreateUser.UseSelectable = True
        Me.txtIdCreateUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIdCreateUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCancelCreateUser
        '
        Me.btnCancelCreateUser.Location = New System.Drawing.Point(427, 436)
        Me.btnCancelCreateUser.Name = "btnCancelCreateUser"
        Me.btnCancelCreateUser.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelCreateUser.TabIndex = 11
        Me.btnCancelCreateUser.Text = "Cancelar"
        Me.btnCancelCreateUser.UseSelectable = True
        '
        'btnSaveCreateUser
        '
        Me.btnSaveCreateUser.Location = New System.Drawing.Point(324, 436)
        Me.btnSaveCreateUser.Name = "btnSaveCreateUser"
        Me.btnSaveCreateUser.Size = New System.Drawing.Size(97, 23)
        Me.btnSaveCreateUser.TabIndex = 10
        Me.btnSaveCreateUser.Text = "Guardar"
        Me.btnSaveCreateUser.UseSelectable = True
        '
        'lblPaswordCreateUser
        '
        Me.lblPaswordCreateUser.AutoSize = True
        Me.lblPaswordCreateUser.Location = New System.Drawing.Point(25, 246)
        Me.lblPaswordCreateUser.Name = "lblPaswordCreateUser"
        Me.lblPaswordCreateUser.Size = New System.Drawing.Size(75, 19)
        Me.lblPaswordCreateUser.TabIndex = 19
        Me.lblPaswordCreateUser.Text = "Contraseña"
        '
        'lblPhoneCreateUser
        '
        Me.lblPhoneCreateUser.AutoSize = True
        Me.lblPhoneCreateUser.Location = New System.Drawing.Point(24, 215)
        Me.lblPhoneCreateUser.Name = "lblPhoneCreateUser"
        Me.lblPhoneCreateUser.Size = New System.Drawing.Size(58, 19)
        Me.lblPhoneCreateUser.TabIndex = 15
        Me.lblPhoneCreateUser.Text = "Telefono"
        '
        'lblNameCreateUser
        '
        Me.lblNameCreateUser.AutoSize = True
        Me.lblNameCreateUser.Location = New System.Drawing.Point(24, 82)
        Me.lblNameCreateUser.Name = "lblNameCreateUser"
        Me.lblNameCreateUser.Size = New System.Drawing.Size(59, 19)
        Me.lblNameCreateUser.TabIndex = 14
        Me.lblNameCreateUser.Text = "Nombre"
        '
        'lblLastNameCreateUser
        '
        Me.lblLastNameCreateUser.AutoSize = True
        Me.lblLastNameCreateUser.Location = New System.Drawing.Point(25, 114)
        Me.lblLastNameCreateUser.Name = "lblLastNameCreateUser"
        Me.lblLastNameCreateUser.Size = New System.Drawing.Size(58, 19)
        Me.lblLastNameCreateUser.TabIndex = 13
        Me.lblLastNameCreateUser.Text = "Apellido"
        '
        'lblCedulaCreateUser
        '
        Me.lblCedulaCreateUser.AutoSize = True
        Me.lblCedulaCreateUser.Location = New System.Drawing.Point(24, 51)
        Me.lblCedulaCreateUser.Name = "lblCedulaCreateUser"
        Me.lblCedulaCreateUser.Size = New System.Drawing.Size(50, 19)
        Me.lblCedulaCreateUser.TabIndex = 11
        Me.lblCedulaCreateUser.Text = "Cedula"
        '
        'lblCreateUserTittle
        '
        Me.lblCreateUserTittle.AutoSize = True
        Me.lblCreateUserTittle.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCreateUserTittle.Location = New System.Drawing.Point(4, 9)
        Me.lblCreateUserTittle.Name = "lblCreateUserTittle"
        Me.lblCreateUserTittle.Size = New System.Drawing.Size(114, 25)
        Me.lblCreateUserTittle.TabIndex = 10
        Me.lblCreateUserTittle.Text = "Crear usuario"
        '
        'pnlCreateRol
        '
        Me.pnlCreateRol.Controls.Add(Me.GroupBox1)
        Me.pnlCreateRol.Controls.Add(Me.lblPermissionsRol)
        Me.pnlCreateRol.Controls.Add(Me.tgEnabledRol)
        Me.pnlCreateRol.Controls.Add(Me.txtRolName)
        Me.pnlCreateRol.Controls.Add(Me.btnCancelRol)
        Me.pnlCreateRol.Controls.Add(Me.btnSaveRol)
        Me.pnlCreateRol.Controls.Add(Me.btnEnabledRol)
        Me.pnlCreateRol.Controls.Add(Me.lblNameRol)
        Me.pnlCreateRol.Controls.Add(Me.lblRolUserTittle)
        Me.pnlCreateRol.HorizontalScrollbarBarColor = True
        Me.pnlCreateRol.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlCreateRol.HorizontalScrollbarSize = 10
        Me.pnlCreateRol.Location = New System.Drawing.Point(0, 1)
        Me.pnlCreateRol.Name = "pnlCreateRol"
        Me.pnlCreateRol.Size = New System.Drawing.Size(753, 461)
        Me.pnlCreateRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.pnlCreateRol.TabIndex = 50
        Me.pnlCreateRol.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnlCreateRol.VerticalScrollbarBarColor = True
        Me.pnlCreateRol.VerticalScrollbarHighlightOnWheel = False
        Me.pnlCreateRol.VerticalScrollbarSize = 10
        Me.pnlCreateRol.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.tgUsersRol)
        Me.GroupBox1.Controls.Add(Me.lblUsersRol)
        Me.GroupBox1.Controls.Add(Me.gboPorductsSectionRol)
        Me.GroupBox1.Controls.Add(Me.lblProductsSectionRol)
        Me.GroupBox1.Controls.Add(Me.tgConfigurationRol)
        Me.GroupBox1.Controls.Add(Me.tgReportsRol)
        Me.GroupBox1.Controls.Add(Me.tgKpiRol)
        Me.GroupBox1.Controls.Add(Me.tgEventsRol)
        Me.GroupBox1.Controls.Add(Me.tgProspectusRol)
        Me.GroupBox1.Controls.Add(Me.tgSalesRol)
        Me.GroupBox1.Controls.Add(Me.lblConfigurationRol)
        Me.GroupBox1.Controls.Add(Me.lblReportsRol)
        Me.GroupBox1.Controls.Add(Me.lblKpiRol)
        Me.GroupBox1.Controls.Add(Me.lblEventsRol)
        Me.GroupBox1.Controls.Add(Me.lblProspectusRol)
        Me.GroupBox1.Controls.Add(Me.lblSalesRol)
        Me.GroupBox1.Location = New System.Drawing.Point(98, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 267)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'tgUsersRol
        '
        Me.tgUsersRol.AutoSize = True
        Me.tgUsersRol.Location = New System.Drawing.Point(346, 173)
        Me.tgUsersRol.Name = "tgUsersRol"
        Me.tgUsersRol.Size = New System.Drawing.Size(80, 17)
        Me.tgUsersRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgUsersRol.TabIndex = 12
        Me.tgUsersRol.Text = "Off"
        Me.tgUsersRol.UseSelectable = True
        '
        'lblUsersRol
        '
        Me.lblUsersRol.AutoSize = True
        Me.lblUsersRol.Location = New System.Drawing.Point(226, 171)
        Me.lblUsersRol.Name = "lblUsersRol"
        Me.lblUsersRol.Size = New System.Drawing.Size(58, 19)
        Me.lblUsersRol.TabIndex = 51
        Me.lblUsersRol.Text = "Usuarios"
        '
        'gboPorductsSectionRol
        '
        Me.gboPorductsSectionRol.BackColor = System.Drawing.Color.White
        Me.gboPorductsSectionRol.Controls.Add(Me.lblActisRol)
        Me.gboPorductsSectionRol.Controls.Add(Me.lblCareersRol)
        Me.gboPorductsSectionRol.Controls.Add(Me.tgCareersRol)
        Me.gboPorductsSectionRol.Controls.Add(Me.tgActiRol)
        Me.gboPorductsSectionRol.Location = New System.Drawing.Point(231, 82)
        Me.gboPorductsSectionRol.Name = "gboPorductsSectionRol"
        Me.gboPorductsSectionRol.Size = New System.Drawing.Size(205, 75)
        Me.gboPorductsSectionRol.TabIndex = 49
        Me.gboPorductsSectionRol.TabStop = False
        '
        'lblActisRol
        '
        Me.lblActisRol.AutoSize = True
        Me.lblActisRol.Location = New System.Drawing.Point(5, 15)
        Me.lblActisRol.Name = "lblActisRol"
        Me.lblActisRol.Size = New System.Drawing.Size(31, 19)
        Me.lblActisRol.TabIndex = 44
        Me.lblActisRol.Text = "Acti"
        '
        'lblCareersRol
        '
        Me.lblCareersRol.AutoSize = True
        Me.lblCareersRol.Location = New System.Drawing.Point(6, 49)
        Me.lblCareersRol.Name = "lblCareersRol"
        Me.lblCareersRol.Size = New System.Drawing.Size(59, 19)
        Me.lblCareersRol.TabIndex = 45
        Me.lblCareersRol.Text = "Carreras"
        '
        'tgCareersRol
        '
        Me.tgCareersRol.AutoSize = True
        Me.tgCareersRol.Location = New System.Drawing.Point(115, 52)
        Me.tgCareersRol.Name = "tgCareersRol"
        Me.tgCareersRol.Size = New System.Drawing.Size(80, 17)
        Me.tgCareersRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgCareersRol.TabIndex = 10
        Me.tgCareersRol.Text = "Off"
        Me.tgCareersRol.UseSelectable = True
        '
        'tgActiRol
        '
        Me.tgActiRol.AutoSize = True
        Me.tgActiRol.Location = New System.Drawing.Point(115, 15)
        Me.tgActiRol.Name = "tgActiRol"
        Me.tgActiRol.Size = New System.Drawing.Size(80, 17)
        Me.tgActiRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgActiRol.TabIndex = 9
        Me.tgActiRol.Text = "Off"
        Me.tgActiRol.UseSelectable = True
        '
        'lblProductsSectionRol
        '
        Me.lblProductsSectionRol.AutoSize = True
        Me.lblProductsSectionRol.Location = New System.Drawing.Point(226, 64)
        Me.lblProductsSectionRol.Name = "lblProductsSectionRol"
        Me.lblProductsSectionRol.Size = New System.Drawing.Size(68, 19)
        Me.lblProductsSectionRol.TabIndex = 50
        Me.lblProductsSectionRol.Text = "Productos"
        '
        'tgConfigurationRol
        '
        Me.tgConfigurationRol.AutoSize = True
        Me.tgConfigurationRol.Location = New System.Drawing.Point(346, 27)
        Me.tgConfigurationRol.Name = "tgConfigurationRol"
        Me.tgConfigurationRol.Size = New System.Drawing.Size(80, 17)
        Me.tgConfigurationRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgConfigurationRol.TabIndex = 8
        Me.tgConfigurationRol.Text = "Off"
        Me.tgConfigurationRol.UseSelectable = True
        '
        'tgReportsRol
        '
        Me.tgReportsRol.AutoSize = True
        Me.tgReportsRol.Location = New System.Drawing.Point(85, 171)
        Me.tgReportsRol.Name = "tgReportsRol"
        Me.tgReportsRol.Size = New System.Drawing.Size(80, 17)
        Me.tgReportsRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgReportsRol.TabIndex = 7
        Me.tgReportsRol.Text = "Off"
        Me.tgReportsRol.UseSelectable = True
        '
        'tgKpiRol
        '
        Me.tgKpiRol.AutoSize = True
        Me.tgKpiRol.Location = New System.Drawing.Point(85, 25)
        Me.tgKpiRol.Name = "tgKpiRol"
        Me.tgKpiRol.Size = New System.Drawing.Size(80, 17)
        Me.tgKpiRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgKpiRol.TabIndex = 3
        Me.tgKpiRol.Text = "Off"
        Me.tgKpiRol.UseSelectable = True
        '
        'tgEventsRol
        '
        Me.tgEventsRol.AutoSize = True
        Me.tgEventsRol.Location = New System.Drawing.Point(85, 133)
        Me.tgEventsRol.Name = "tgEventsRol"
        Me.tgEventsRol.Size = New System.Drawing.Size(80, 17)
        Me.tgEventsRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgEventsRol.TabIndex = 6
        Me.tgEventsRol.Text = "Off"
        Me.tgEventsRol.UseSelectable = True
        '
        'tgProspectusRol
        '
        Me.tgProspectusRol.AutoSize = True
        Me.tgProspectusRol.Location = New System.Drawing.Point(85, 97)
        Me.tgProspectusRol.Name = "tgProspectusRol"
        Me.tgProspectusRol.Size = New System.Drawing.Size(80, 17)
        Me.tgProspectusRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgProspectusRol.TabIndex = 5
        Me.tgProspectusRol.Text = "Off"
        Me.tgProspectusRol.UseSelectable = True
        '
        'tgSalesRol
        '
        Me.tgSalesRol.AutoSize = True
        Me.tgSalesRol.Location = New System.Drawing.Point(85, 61)
        Me.tgSalesRol.Name = "tgSalesRol"
        Me.tgSalesRol.Size = New System.Drawing.Size(80, 17)
        Me.tgSalesRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgSalesRol.TabIndex = 4
        Me.tgSalesRol.Text = "Off"
        Me.tgSalesRol.UseSelectable = True
        '
        'lblConfigurationRol
        '
        Me.lblConfigurationRol.AutoSize = True
        Me.lblConfigurationRol.Location = New System.Drawing.Point(226, 25)
        Me.lblConfigurationRol.Name = "lblConfigurationRol"
        Me.lblConfigurationRol.Size = New System.Drawing.Size(91, 19)
        Me.lblConfigurationRol.TabIndex = 35
        Me.lblConfigurationRol.Text = "Configuracion"
        '
        'lblReportsRol
        '
        Me.lblReportsRol.AutoSize = True
        Me.lblReportsRol.Location = New System.Drawing.Point(7, 171)
        Me.lblReportsRol.Name = "lblReportsRol"
        Me.lblReportsRol.Size = New System.Drawing.Size(62, 19)
        Me.lblReportsRol.TabIndex = 34
        Me.lblReportsRol.Text = "Reportes"
        '
        'lblKpiRol
        '
        Me.lblKpiRol.AutoSize = True
        Me.lblKpiRol.Location = New System.Drawing.Point(6, 23)
        Me.lblKpiRol.Name = "lblKpiRol"
        Me.lblKpiRol.Size = New System.Drawing.Size(27, 19)
        Me.lblKpiRol.TabIndex = 32
        Me.lblKpiRol.Text = "Kpi"
        '
        'lblEventsRol
        '
        Me.lblEventsRol.AutoSize = True
        Me.lblEventsRol.Location = New System.Drawing.Point(7, 131)
        Me.lblEventsRol.Name = "lblEventsRol"
        Me.lblEventsRol.Size = New System.Drawing.Size(53, 19)
        Me.lblEventsRol.TabIndex = 31
        Me.lblEventsRol.Text = "Eventos"
        '
        'lblProspectusRol
        '
        Me.lblProspectusRol.AutoSize = True
        Me.lblProspectusRol.Location = New System.Drawing.Point(7, 95)
        Me.lblProspectusRol.Name = "lblProspectusRol"
        Me.lblProspectusRol.Size = New System.Drawing.Size(73, 19)
        Me.lblProspectusRol.TabIndex = 30
        Me.lblProspectusRol.Text = "Prospectos"
        '
        'lblSalesRol
        '
        Me.lblSalesRol.AutoSize = True
        Me.lblSalesRol.Location = New System.Drawing.Point(6, 59)
        Me.lblSalesRol.Name = "lblSalesRol"
        Me.lblSalesRol.Size = New System.Drawing.Size(46, 19)
        Me.lblSalesRol.TabIndex = 29
        Me.lblSalesRol.Text = "Ventas"
        '
        'lblPermissionsRol
        '
        Me.lblPermissionsRol.AutoSize = True
        Me.lblPermissionsRol.Location = New System.Drawing.Point(23, 133)
        Me.lblPermissionsRol.Name = "lblPermissionsRol"
        Me.lblPermissionsRol.Size = New System.Drawing.Size(61, 19)
        Me.lblPermissionsRol.TabIndex = 26
        Me.lblPermissionsRol.Text = "Permisos"
        '
        'tgEnabledRol
        '
        Me.tgEnabledRol.AutoSize = True
        Me.tgEnabledRol.Location = New System.Drawing.Point(98, 86)
        Me.tgEnabledRol.Name = "tgEnabledRol"
        Me.tgEnabledRol.Size = New System.Drawing.Size(80, 17)
        Me.tgEnabledRol.Style = MetroFramework.MetroColorStyle.Purple
        Me.tgEnabledRol.TabIndex = 2
        Me.tgEnabledRol.Text = "Off"
        Me.tgEnabledRol.UseSelectable = True
        '
        'txtRolName
        '
        '
        '
        '
        Me.txtRolName.CustomButton.Image = Nothing
        Me.txtRolName.CustomButton.Location = New System.Drawing.Point(430, 1)
        Me.txtRolName.CustomButton.Name = ""
        Me.txtRolName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRolName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRolName.CustomButton.TabIndex = 1
        Me.txtRolName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRolName.CustomButton.UseSelectable = True
        Me.txtRolName.CustomButton.Visible = False
        Me.txtRolName.Lines = New String(-1) {}
        Me.txtRolName.Location = New System.Drawing.Point(98, 51)
        Me.txtRolName.MaxLength = 75
        Me.txtRolName.Name = "txtRolName"
        Me.txtRolName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRolName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRolName.SelectedText = ""
        Me.txtRolName.SelectionLength = 0
        Me.txtRolName.SelectionStart = 0
        Me.txtRolName.Size = New System.Drawing.Size(452, 23)
        Me.txtRolName.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtRolName.TabIndex = 1
        Me.txtRolName.UseSelectable = True
        Me.txtRolName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRolName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCancelRol
        '
        Me.btnCancelRol.Location = New System.Drawing.Point(598, 422)
        Me.btnCancelRol.Name = "btnCancelRol"
        Me.btnCancelRol.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelRol.TabIndex = 14
        Me.btnCancelRol.Text = "Cancelar"
        Me.btnCancelRol.UseSelectable = True
        '
        'btnSaveRol
        '
        Me.btnSaveRol.Location = New System.Drawing.Point(494, 422)
        Me.btnSaveRol.Name = "btnSaveRol"
        Me.btnSaveRol.Size = New System.Drawing.Size(97, 23)
        Me.btnSaveRol.TabIndex = 13
        Me.btnSaveRol.Text = "Guardar"
        Me.btnSaveRol.UseSelectable = True
        '
        'btnEnabledRol
        '
        Me.btnEnabledRol.AutoSize = True
        Me.btnEnabledRol.Location = New System.Drawing.Point(24, 82)
        Me.btnEnabledRol.Name = "btnEnabledRol"
        Me.btnEnabledRol.Size = New System.Drawing.Size(45, 19)
        Me.btnEnabledRol.TabIndex = 14
        Me.btnEnabledRol.Text = "Activo"
        '
        'lblNameRol
        '
        Me.lblNameRol.AutoSize = True
        Me.lblNameRol.Location = New System.Drawing.Point(24, 51)
        Me.lblNameRol.Name = "lblNameRol"
        Me.lblNameRol.Size = New System.Drawing.Size(59, 19)
        Me.lblNameRol.TabIndex = 11
        Me.lblNameRol.Text = "Nombre"
        '
        'lblRolUserTittle
        '
        Me.lblRolUserTittle.AutoSize = True
        Me.lblRolUserTittle.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblRolUserTittle.Location = New System.Drawing.Point(4, 9)
        Me.lblRolUserTittle.Name = "lblRolUserTittle"
        Me.lblRolUserTittle.Size = New System.Drawing.Size(78, 25)
        Me.lblRolUserTittle.TabIndex = 10
        Me.lblRolUserTittle.Text = "Crear rol"
        '
        'pnlListRols
        '
        Me.pnlListRols.Controls.Add(Me.btnBackRolsUsers)
        Me.pnlListRols.Controls.Add(Me.lblIdRol)
        Me.pnlListRols.Controls.Add(Me.lstRols)
        Me.pnlListRols.Controls.Add(Me.lblListOfRols)
        Me.pnlListRols.Controls.Add(Me.btnNewRol)
        Me.pnlListRols.HorizontalScrollbarBarColor = True
        Me.pnlListRols.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlListRols.HorizontalScrollbarSize = 10
        Me.pnlListRols.Location = New System.Drawing.Point(0, 3)
        Me.pnlListRols.Name = "pnlListRols"
        Me.pnlListRols.Size = New System.Drawing.Size(767, 461)
        Me.pnlListRols.Style = MetroFramework.MetroColorStyle.Blue
        Me.pnlListRols.TabIndex = 49
        Me.pnlListRols.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnlListRols.VerticalScrollbarBarColor = True
        Me.pnlListRols.VerticalScrollbarHighlightOnWheel = False
        Me.pnlListRols.VerticalScrollbarSize = 10
        Me.pnlListRols.Visible = False
        '
        'btnBackRolsUsers
        '
        Me.btnBackRolsUsers.Location = New System.Drawing.Point(7, 412)
        Me.btnBackRolsUsers.Name = "btnBackRolsUsers"
        Me.btnBackRolsUsers.Size = New System.Drawing.Size(123, 36)
        Me.btnBackRolsUsers.TabIndex = 50
        Me.btnBackRolsUsers.Text = "Volver"
        Me.btnBackRolsUsers.UseSelectable = True
        '
        'lblIdRol
        '
        Me.lblIdRol.AutoSize = True
        Me.lblIdRol.Location = New System.Drawing.Point(723, 7)
        Me.lblIdRol.Name = "lblIdRol"
        Me.lblIdRol.Size = New System.Drawing.Size(20, 19)
        Me.lblIdRol.TabIndex = 49
        Me.lblIdRol.Text = "id"
        Me.lblIdRol.Visible = False
        '
        'lstRols
        '
        Me.lstRols.AllowUserToAddRows = False
        Me.lstRols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstRols.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.colNameRol, Me.colStateRol, Me.DataGridViewImageColumn2})
        Me.lstRols.Location = New System.Drawing.Point(7, 37)
        Me.lstRols.Name = "lstRols"
        Me.lstRols.RowHeadersVisible = False
        Me.lstRols.Size = New System.Drawing.Size(739, 344)
        Me.lstRols.TabIndex = 12
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'colNameRol
        '
        Me.colNameRol.HeaderText = "Nombre"
        Me.colNameRol.Name = "colNameRol"
        '
        'colStateRol
        '
        Me.colStateRol.HeaderText = "Estado"
        Me.colStateRol.Name = "colStateRol"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'lblListOfRols
        '
        Me.lblListOfRols.AutoSize = True
        Me.lblListOfRols.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblListOfRols.Location = New System.Drawing.Point(4, 9)
        Me.lblListOfRols.Name = "lblListOfRols"
        Me.lblListOfRols.Size = New System.Drawing.Size(92, 25)
        Me.lblListOfRols.TabIndex = 10
        Me.lblListOfRols.Text = "Listar roles"
        '
        'btnNewRol
        '
        Me.btnNewRol.Location = New System.Drawing.Point(623, 412)
        Me.btnNewRol.Name = "btnNewRol"
        Me.btnNewRol.Size = New System.Drawing.Size(123, 36)
        Me.btnNewRol.TabIndex = 9
        Me.btnNewRol.Text = "Nuevo rol"
        Me.btnNewRol.UseSelectable = True
        '
        'pnListUsers
        '
        Me.pnListUsers.Controls.Add(Me.lblCreateUpdateUserId)
        Me.pnListUsers.Controls.Add(Me.lstUsers)
        Me.pnListUsers.Controls.Add(Me.lblRols)
        Me.pnListUsers.Controls.Add(Me.MetroLabel14)
        Me.pnListUsers.Controls.Add(Me.btnCreateUser)
        Me.pnListUsers.HorizontalScrollbarBarColor = True
        Me.pnListUsers.HorizontalScrollbarHighlightOnWheel = False
        Me.pnListUsers.HorizontalScrollbarSize = 10
        Me.pnListUsers.Location = New System.Drawing.Point(3, 3)
        Me.pnListUsers.Name = "pnListUsers"
        Me.pnListUsers.Size = New System.Drawing.Size(753, 462)
        Me.pnListUsers.Style = MetroFramework.MetroColorStyle.Blue
        Me.pnListUsers.TabIndex = 48
        Me.pnListUsers.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnListUsers.VerticalScrollbarBarColor = True
        Me.pnListUsers.VerticalScrollbarHighlightOnWheel = False
        Me.pnListUsers.VerticalScrollbarSize = 10
        '
        'lblCreateUpdateUserId
        '
        Me.lblCreateUpdateUserId.AutoSize = True
        Me.lblCreateUpdateUserId.Location = New System.Drawing.Point(723, 7)
        Me.lblCreateUpdateUserId.Name = "lblCreateUpdateUserId"
        Me.lblCreateUpdateUserId.Size = New System.Drawing.Size(20, 19)
        Me.lblCreateUpdateUserId.TabIndex = 49
        Me.lblCreateUpdateUserId.Text = "id"
        Me.lblCreateUpdateUserId.Visible = False
        '
        'lstUsers
        '
        Me.lstUsers.AllowUserToAddRows = False
        Me.lstUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.colIdentificacion, Me.Column1, Me.Column2, Me.Column5, Me.Column6, Me.colState, Me.Column7})
        Me.lstUsers.Location = New System.Drawing.Point(7, 37)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.RowHeadersVisible = False
        Me.lstUsers.Size = New System.Drawing.Size(739, 344)
        Me.lstUsers.TabIndex = 12
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "ID"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'colIdentificacion
        '
        Me.colIdentificacion.HeaderText = "Cédula"
        Me.colIdentificacion.Name = "colIdentificacion"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Apellidos"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Teléfono"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "E-mail"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'colState
        '
        Me.colState.HeaderText = "Estado"
        Me.colState.Name = "colState"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = ""
        Me.Column7.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'lblRols
        '
        Me.lblRols.BackColor = System.Drawing.Color.Ivory
        Me.lblRols.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRols.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.lblRols.Location = New System.Drawing.Point(3, 425)
        Me.lblRols.Name = "lblRols"
        Me.lblRols.Size = New System.Drawing.Size(217, 23)
        Me.lblRols.Style = MetroFramework.MetroColorStyle.Purple
        Me.lblRols.TabIndex = 11
        Me.lblRols.Text = "Administrar roles de usuario"
        Me.lblRols.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblRols.UseSelectable = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel14.Location = New System.Drawing.Point(4, 9)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(113, 25)
        Me.MetroLabel14.TabIndex = 10
        Me.MetroLabel14.Text = "Lista usuarios"
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(620, 412)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(123, 36)
        Me.btnCreateUser.TabIndex = 9
        Me.btnCreateUser.Text = "Nuevo usuario"
        Me.btnCreateUser.UseSelectable = True
        '
        'PnlListaSeguimientos
        '
        Me.PnlListaSeguimientos.Controls.Add(Me.lblIdSeguimiento)
        Me.PnlListaSeguimientos.Controls.Add(Me.lblIdProspecto)
        Me.PnlListaSeguimientos.Controls.Add(Me.btnCancelarListaSeguimiento)
        Me.PnlListaSeguimientos.Controls.Add(Me.lstSeguimientos)
        Me.PnlListaSeguimientos.Controls.Add(Me.lblListaSeguimientos)
        Me.PnlListaSeguimientos.HorizontalScrollbarBarColor = True
        Me.PnlListaSeguimientos.HorizontalScrollbarHighlightOnWheel = False
        Me.PnlListaSeguimientos.HorizontalScrollbarSize = 10
        Me.PnlListaSeguimientos.Location = New System.Drawing.Point(7, 6)
        Me.PnlListaSeguimientos.Name = "PnlListaSeguimientos"
        Me.PnlListaSeguimientos.Size = New System.Drawing.Size(753, 463)
        Me.PnlListaSeguimientos.TabIndex = 42
        Me.PnlListaSeguimientos.VerticalScrollbarBarColor = True
        Me.PnlListaSeguimientos.VerticalScrollbarHighlightOnWheel = False
        Me.PnlListaSeguimientos.VerticalScrollbarSize = 10
        Me.PnlListaSeguimientos.Visible = False
        '
        'lblIdSeguimiento
        '
        Me.lblIdSeguimiento.AutoSize = True
        Me.lblIdSeguimiento.Location = New System.Drawing.Point(717, 443)
        Me.lblIdSeguimiento.Name = "lblIdSeguimiento"
        Me.lblIdSeguimiento.Size = New System.Drawing.Size(20, 19)
        Me.lblIdSeguimiento.TabIndex = 41
        Me.lblIdSeguimiento.Text = "-1"
        Me.lblIdSeguimiento.Visible = False
        '
        'lblIdProspecto
        '
        Me.lblIdProspecto.AutoSize = True
        Me.lblIdProspecto.Location = New System.Drawing.Point(736, 443)
        Me.lblIdProspecto.Name = "lblIdProspecto"
        Me.lblIdProspecto.Size = New System.Drawing.Size(20, 19)
        Me.lblIdProspecto.TabIndex = 40
        Me.lblIdProspecto.Text = "-1"
        Me.lblIdProspecto.Visible = False
        '
        'btnCancelarListaSeguimiento
        '
        Me.btnCancelarListaSeguimiento.Location = New System.Drawing.Point(624, 406)
        Me.btnCancelarListaSeguimiento.Name = "btnCancelarListaSeguimiento"
        Me.btnCancelarListaSeguimiento.Size = New System.Drawing.Size(121, 36)
        Me.btnCancelarListaSeguimiento.TabIndex = 13
        Me.btnCancelarListaSeguimiento.Text = "Atrás"
        Me.btnCancelarListaSeguimiento.UseSelectable = True
        '
        'lstSeguimientos
        '
        Me.lstSeguimientos.AllowUserToAddRows = False
        Me.lstSeguimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstSeguimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewImageColumn3, Me.Column10})
        Me.lstSeguimientos.Location = New System.Drawing.Point(8, 42)
        Me.lstSeguimientos.Name = "lstSeguimientos"
        Me.lstSeguimientos.RowHeadersVisible = False
        Me.lstSeguimientos.Size = New System.Drawing.Size(737, 344)
        Me.lstSeguimientos.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 160
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Comentario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 500
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column10
        '
        Me.Column10.HeaderText = ""
        Me.Column10.Image = Global.PresentasionWindowsForms.My.Resources.Resources.delete81
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 38
        '
        'lblListaSeguimientos
        '
        Me.lblListaSeguimientos.AutoSize = True
        Me.lblListaSeguimientos.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblListaSeguimientos.Location = New System.Drawing.Point(7, 9)
        Me.lblListaSeguimientos.Name = "lblListaSeguimientos"
        Me.lblListaSeguimientos.Size = New System.Drawing.Size(150, 25)
        Me.lblListaSeguimientos.TabIndex = 11
        Me.lblListaSeguimientos.Text = "Lista seguimientos"
        '
        'tabProspectus
        '
        Me.tabProspectus.Controls.Add(Me.PnlNuevoProspecto)
        Me.tabProspectus.Controls.Add(Me.pnlSeguimientos)
        Me.tabProspectus.Controls.Add(Me.PnlListaSeguimientos)
        Me.tabProspectus.Controls.Add(Me.PnlListaProspectos)
        Me.tabProspectus.HorizontalScrollbarBarColor = True
        Me.tabProspectus.HorizontalScrollbarHighlightOnWheel = False
        Me.tabProspectus.HorizontalScrollbarSize = 10
        Me.tabProspectus.Location = New System.Drawing.Point(4, 44)
        Me.tabProspectus.Name = "tabProspectus"
        Me.tabProspectus.Size = New System.Drawing.Size(752, 472)
        Me.tabProspectus.TabIndex = 6
        Me.tabProspectus.Text = "Prospectos"
        Me.tabProspectus.VerticalScrollbarBarColor = True
        Me.tabProspectus.VerticalScrollbarHighlightOnWheel = False
        Me.tabProspectus.VerticalScrollbarSize = 10
        '
        'PnlListaProspectos
        '
        Me.PnlListaProspectos.Controls.Add(Me.lblListaProspectos)
        Me.PnlListaProspectos.Controls.Add(Me.btnCrearProspecto)
        Me.PnlListaProspectos.Controls.Add(Me.lstProspectos)
        Me.PnlListaProspectos.HorizontalScrollbarBarColor = True
        Me.PnlListaProspectos.HorizontalScrollbarHighlightOnWheel = False
        Me.PnlListaProspectos.HorizontalScrollbarSize = 10
        Me.PnlListaProspectos.Location = New System.Drawing.Point(10, 3)
        Me.PnlListaProspectos.Name = "PnlListaProspectos"
        Me.PnlListaProspectos.Size = New System.Drawing.Size(742, 455)
        Me.PnlListaProspectos.Style = MetroFramework.MetroColorStyle.White
        Me.PnlListaProspectos.TabIndex = 40
        Me.PnlListaProspectos.VerticalScrollbarBarColor = True
        Me.PnlListaProspectos.VerticalScrollbarHighlightOnWheel = False
        Me.PnlListaProspectos.VerticalScrollbarSize = 10
        '
        'lblListaProspectos
        '
        Me.lblListaProspectos.AutoSize = True
        Me.lblListaProspectos.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblListaProspectos.Location = New System.Drawing.Point(4, 9)
        Me.lblListaProspectos.Name = "lblListaProspectos"
        Me.lblListaProspectos.Size = New System.Drawing.Size(132, 25)
        Me.lblListaProspectos.TabIndex = 10
        Me.lblListaProspectos.Text = "Lista prospectos"
        '
        'btnCrearProspecto
        '
        Me.btnCrearProspecto.Location = New System.Drawing.Point(620, 412)
        Me.btnCrearProspecto.Name = "btnCrearProspecto"
        Me.btnCrearProspecto.Size = New System.Drawing.Size(123, 36)
        Me.btnCrearProspecto.TabIndex = 9
        Me.btnCrearProspecto.Text = "Nuevo prospecto"
        Me.btnCrearProspecto.UseSelectable = True
        '
        'lstProspectos
        '
        Me.lstProspectos.AllowUserToAddRows = False
        Me.lstProspectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstProspectos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Column3, Me.Column4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewImageColumn1})
        Me.lstProspectos.Location = New System.Drawing.Point(4, 37)
        Me.lstProspectos.Name = "lstProspectos"
        Me.lstProspectos.RowHeadersVisible = False
        Me.lstProspectos.Size = New System.Drawing.Size(739, 344)
        Me.lstProspectos.TabIndex = 8
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nacimiento"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Procedencia"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "E-mail"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PnlNuevoProspecto
        '
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
        Me.PnlNuevoProspecto.Location = New System.Drawing.Point(7, 11)
        Me.PnlNuevoProspecto.Name = "PnlNuevoProspecto"
        Me.PnlNuevoProspecto.Size = New System.Drawing.Size(704, 447)
        Me.PnlNuevoProspecto.Style = MetroFramework.MetroColorStyle.Purple
        Me.PnlNuevoProspecto.TabIndex = 39
        Me.PnlNuevoProspecto.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PnlNuevoProspecto.VerticalScrollbarBarColor = True
        Me.PnlNuevoProspecto.VerticalScrollbarHighlightOnWheel = False
        Me.PnlNuevoProspecto.VerticalScrollbarSize = 10
        Me.PnlNuevoProspecto.Visible = False
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
        Me.txtFechaNacProspecto.MinimumSize = New System.Drawing.Size(0, 29)
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
        Me.btnCancelarProspecto.Location = New System.Drawing.Point(427, 421)
        Me.btnCancelarProspecto.Name = "btnCancelarProspecto"
        Me.btnCancelarProspecto.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarProspecto.TabIndex = 23
        Me.btnCancelarProspecto.Text = "Cancelar"
        Me.btnCancelarProspecto.UseSelectable = True
        '
        'btnGuardarProspecto
        '
        Me.btnGuardarProspecto.Location = New System.Drawing.Point(324, 421)
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
        Me.lblCrearProspectos.Location = New System.Drawing.Point(4, 9)
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
        'pnlSeguimientos
        '
        Me.pnlSeguimientos.Controls.Add(Me.txtComentarioSeguimiento)
        Me.pnlSeguimientos.Controls.Add(Me.btnCancelarSeguimiento)
        Me.pnlSeguimientos.Controls.Add(Me.btnGuardarSeguimiento)
        Me.pnlSeguimientos.Controls.Add(Me.lblComentarioSeguimiento)
        Me.pnlSeguimientos.Controls.Add(Me.txtFechaSeguimiento)
        Me.pnlSeguimientos.Controls.Add(Me.lblFechaSeguimiento)
        Me.pnlSeguimientos.Controls.Add(Me.MetroLabel3)
        Me.pnlSeguimientos.HorizontalScrollbarBarColor = True
        Me.pnlSeguimientos.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlSeguimientos.HorizontalScrollbarSize = 10
        Me.pnlSeguimientos.Location = New System.Drawing.Point(11, 13)
        Me.pnlSeguimientos.Name = "pnlSeguimientos"
        Me.pnlSeguimientos.Size = New System.Drawing.Size(565, 235)
        Me.pnlSeguimientos.TabIndex = 41
        Me.pnlSeguimientos.VerticalScrollbarBarColor = True
        Me.pnlSeguimientos.VerticalScrollbarHighlightOnWheel = False
        Me.pnlSeguimientos.VerticalScrollbarSize = 10
        Me.pnlSeguimientos.Visible = False
        '
        'txtComentarioSeguimiento
        '
        '
        '
        '
        Me.txtComentarioSeguimiento.CustomButton.Image = Nothing
        Me.txtComentarioSeguimiento.CustomButton.Location = New System.Drawing.Point(301, 1)
        Me.txtComentarioSeguimiento.CustomButton.Name = ""
        Me.txtComentarioSeguimiento.CustomButton.Size = New System.Drawing.Size(65, 65)
        Me.txtComentarioSeguimiento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtComentarioSeguimiento.CustomButton.TabIndex = 1
        Me.txtComentarioSeguimiento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtComentarioSeguimiento.CustomButton.UseSelectable = True
        Me.txtComentarioSeguimiento.CustomButton.Visible = False
        Me.txtComentarioSeguimiento.Lines = New String(-1) {}
        Me.txtComentarioSeguimiento.Location = New System.Drawing.Point(155, 94)
        Me.txtComentarioSeguimiento.MaxLength = 32767
        Me.txtComentarioSeguimiento.Multiline = True
        Me.txtComentarioSeguimiento.Name = "txtComentarioSeguimiento"
        Me.txtComentarioSeguimiento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComentarioSeguimiento.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtComentarioSeguimiento.SelectedText = ""
        Me.txtComentarioSeguimiento.SelectionLength = 0
        Me.txtComentarioSeguimiento.SelectionStart = 0
        Me.txtComentarioSeguimiento.Size = New System.Drawing.Size(367, 67)
        Me.txtComentarioSeguimiento.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtComentarioSeguimiento.TabIndex = 39
        Me.txtComentarioSeguimiento.UseSelectable = True
        Me.txtComentarioSeguimiento.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtComentarioSeguimiento.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCancelarSeguimiento
        '
        Me.btnCancelarSeguimiento.Location = New System.Drawing.Point(425, 179)
        Me.btnCancelarSeguimiento.Name = "btnCancelarSeguimiento"
        Me.btnCancelarSeguimiento.Size = New System.Drawing.Size(97, 23)
        Me.btnCancelarSeguimiento.TabIndex = 38
        Me.btnCancelarSeguimiento.Text = "Cancelar"
        Me.btnCancelarSeguimiento.UseSelectable = True
        '
        'btnGuardarSeguimiento
        '
        Me.btnGuardarSeguimiento.Location = New System.Drawing.Point(322, 179)
        Me.btnGuardarSeguimiento.Name = "btnGuardarSeguimiento"
        Me.btnGuardarSeguimiento.Size = New System.Drawing.Size(97, 23)
        Me.btnGuardarSeguimiento.TabIndex = 37
        Me.btnGuardarSeguimiento.Text = "Guardar"
        Me.btnGuardarSeguimiento.UseSelectable = True
        '
        'lblComentarioSeguimiento
        '
        Me.lblComentarioSeguimiento.AutoSize = True
        Me.lblComentarioSeguimiento.Location = New System.Drawing.Point(22, 94)
        Me.lblComentarioSeguimiento.Name = "lblComentarioSeguimiento"
        Me.lblComentarioSeguimiento.Size = New System.Drawing.Size(82, 19)
        Me.lblComentarioSeguimiento.TabIndex = 35
        Me.lblComentarioSeguimiento.Text = "Comentario:"
        '
        'txtFechaSeguimiento
        '
        Me.txtFechaSeguimiento.CustomFormat = ""
        Me.txtFechaSeguimiento.Location = New System.Drawing.Point(155, 44)
        Me.txtFechaSeguimiento.MinimumSize = New System.Drawing.Size(4, 29)
        Me.txtFechaSeguimiento.Name = "txtFechaSeguimiento"
        Me.txtFechaSeguimiento.Size = New System.Drawing.Size(367, 29)
        Me.txtFechaSeguimiento.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtFechaSeguimiento.TabIndex = 34
        Me.txtFechaSeguimiento.Value = New Date(2015, 11, 1, 16, 55, 54, 0)
        '
        'lblFechaSeguimiento
        '
        Me.lblFechaSeguimiento.AutoSize = True
        Me.lblFechaSeguimiento.Location = New System.Drawing.Point(22, 46)
        Me.lblFechaSeguimiento.Name = "lblFechaSeguimiento"
        Me.lblFechaSeguimiento.Size = New System.Drawing.Size(46, 19)
        Me.lblFechaSeguimiento.TabIndex = 33
        Me.lblFechaSeguimiento.Text = "Fecha:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 3)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(151, 25)
        Me.MetroLabel3.TabIndex = 11
        Me.MetroLabel3.Text = "Crear seguimiento"
        '
        'tabProducts
        '
        Me.tabProducts.Controls.Add(Me.registrarActi_pnl)
        Me.tabProducts.Controls.Add(Me.listaCarreras_pnl)
        Me.tabProducts.Controls.Add(Me.listaActis_pnl)
        Me.tabProducts.Controls.Add(Me.registrarCarrera_pnl)
        Me.tabProducts.Controls.Add(Me.tCareers)
        Me.tabProducts.Controls.Add(Me.tActis)
        Me.tabProducts.HorizontalScrollbarBarColor = True
        Me.tabProducts.HorizontalScrollbarHighlightOnWheel = False
        Me.tabProducts.HorizontalScrollbarSize = 10
        Me.tabProducts.Location = New System.Drawing.Point(4, 44)
        Me.tabProducts.Name = "tabProducts"
        Me.tabProducts.Size = New System.Drawing.Size(752, 472)
        Me.tabProducts.TabIndex = 1
        Me.tabProducts.Text = "Productos"
        Me.tabProducts.VerticalScrollbarBarColor = True
        Me.tabProducts.VerticalScrollbarHighlightOnWheel = False
        Me.tabProducts.VerticalScrollbarSize = 10
        '
        'registrarActi_pnl
        '
        Me.registrarActi_pnl.Controls.Add(Me.cancelarActi_btn)
        Me.registrarActi_pnl.Controls.Add(Me.guardarActi_btn)
        Me.registrarActi_pnl.Controls.Add(Me.minsFinActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.horaFinActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.minsFin5Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsFin4Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsFin3Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsFin2Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsFin1Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaFin5Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaFin4Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaFin3Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaFin2Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaFin1Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsIniActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.horaIniActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.minsIni5Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsIni4Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsIni3Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsIni2Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.minsIni1Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaIni5Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaIni4Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaIni3Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaIni2Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.horaIni1Acti_nmb)
        Me.registrarActi_pnl.Controls.Add(Me.dia5Acti_cmb)
        Me.registrarActi_pnl.Controls.Add(Me.dia4Acti_cmb)
        Me.registrarActi_pnl.Controls.Add(Me.dia3Acti_cmb)
        Me.registrarActi_pnl.Controls.Add(Me.dia2Acti_cmb)
        Me.registrarActi_pnl.Controls.Add(Me.dia1Acti_cmb)
        Me.registrarActi_pnl.Controls.Add(Me.MetroLabel8)
        Me.registrarActi_pnl.Controls.Add(Me.MetroLabel9)
        Me.registrarActi_pnl.Controls.Add(Me.dia5_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.dia4Acti_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.dia2Acti_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.dia3Acti_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.dia1Acti_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.tipoActi_cmb)
        Me.registrarActi_pnl.Controls.Add(Me.costoActi_text)
        Me.registrarActi_pnl.Controls.Add(Me.nombreActi_text)
        Me.registrarActi_pnl.Controls.Add(Me.codigoActi_text)
        Me.registrarActi_pnl.Controls.Add(Me.nombreActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.tipoActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.MetroLabel22)
        Me.registrarActi_pnl.Controls.Add(Me.codigoActi_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.acti_lbl)
        Me.registrarActi_pnl.Controls.Add(Me.GroupBox2)
        Me.registrarActi_pnl.Controls.Add(Me.GroupBox6)
        Me.registrarActi_pnl.Controls.Add(Me.horariosActi_grp)
        Me.registrarActi_pnl.HorizontalScrollbarBarColor = True
        Me.registrarActi_pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.registrarActi_pnl.HorizontalScrollbarSize = 10
        Me.registrarActi_pnl.Location = New System.Drawing.Point(0, 3)
        Me.registrarActi_pnl.Name = "registrarActi_pnl"
        Me.registrarActi_pnl.Size = New System.Drawing.Size(746, 462)
        Me.registrarActi_pnl.Style = MetroFramework.MetroColorStyle.Purple
        Me.registrarActi_pnl.TabIndex = 82
        Me.registrarActi_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.registrarActi_pnl.VerticalScrollbarBarColor = True
        Me.registrarActi_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.registrarActi_pnl.VerticalScrollbarSize = 10
        Me.registrarActi_pnl.Visible = False
        '
        'cancelarActi_btn
        '
        Me.cancelarActi_btn.Location = New System.Drawing.Point(7, 412)
        Me.cancelarActi_btn.Name = "cancelarActi_btn"
        Me.cancelarActi_btn.Size = New System.Drawing.Size(123, 36)
        Me.cancelarActi_btn.TabIndex = 79
        Me.cancelarActi_btn.Text = "Cancelar"
        Me.cancelarActi_btn.UseSelectable = True
        '
        'guardarActi_btn
        '
        Me.guardarActi_btn.Location = New System.Drawing.Point(623, 412)
        Me.guardarActi_btn.Name = "guardarActi_btn"
        Me.guardarActi_btn.Size = New System.Drawing.Size(123, 36)
        Me.guardarActi_btn.TabIndex = 78
        Me.guardarActi_btn.Text = "Guardar"
        Me.guardarActi_btn.UseSelectable = True
        '
        'minsFinActi_lbl
        '
        Me.minsFinActi_lbl.AutoSize = True
        Me.minsFinActi_lbl.Location = New System.Drawing.Point(594, 224)
        Me.minsFinActi_lbl.Name = "minsFinActi_lbl"
        Me.minsFinActi_lbl.Size = New System.Drawing.Size(55, 19)
        Me.minsFinActi_lbl.TabIndex = 74
        Me.minsFinActi_lbl.Text = "Minutos"
        '
        'horaFinActi_lbl
        '
        Me.horaFinActi_lbl.AutoSize = True
        Me.horaFinActi_lbl.Location = New System.Drawing.Point(546, 224)
        Me.horaFinActi_lbl.Name = "horaFinActi_lbl"
        Me.horaFinActi_lbl.Size = New System.Drawing.Size(38, 19)
        Me.horaFinActi_lbl.TabIndex = 73
        Me.horaFinActi_lbl.Text = "Hora"
        '
        'minsFin5Acti_nmb
        '
        Me.minsFin5Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin5Acti_nmb.Location = New System.Drawing.Point(603, 354)
        Me.minsFin5Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin5Acti_nmb.Name = "minsFin5Acti_nmb"
        Me.minsFin5Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsFin5Acti_nmb.TabIndex = 53
        '
        'minsFin4Acti_nmb
        '
        Me.minsFin4Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin4Acti_nmb.Location = New System.Drawing.Point(603, 327)
        Me.minsFin4Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin4Acti_nmb.Name = "minsFin4Acti_nmb"
        Me.minsFin4Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsFin4Acti_nmb.TabIndex = 48
        '
        'minsFin3Acti_nmb
        '
        Me.minsFin3Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin3Acti_nmb.Location = New System.Drawing.Point(603, 300)
        Me.minsFin3Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin3Acti_nmb.Name = "minsFin3Acti_nmb"
        Me.minsFin3Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsFin3Acti_nmb.TabIndex = 43
        '
        'minsFin2Acti_nmb
        '
        Me.minsFin2Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin2Acti_nmb.Location = New System.Drawing.Point(603, 273)
        Me.minsFin2Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin2Acti_nmb.Name = "minsFin2Acti_nmb"
        Me.minsFin2Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsFin2Acti_nmb.TabIndex = 38
        '
        'minsFin1Acti_nmb
        '
        Me.minsFin1Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin1Acti_nmb.Location = New System.Drawing.Point(603, 246)
        Me.minsFin1Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin1Acti_nmb.Name = "minsFin1Acti_nmb"
        Me.minsFin1Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsFin1Acti_nmb.TabIndex = 33
        '
        'horaFin5Acti_nmb
        '
        Me.horaFin5Acti_nmb.Location = New System.Drawing.Point(546, 354)
        Me.horaFin5Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin5Acti_nmb.Name = "horaFin5Acti_nmb"
        Me.horaFin5Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaFin5Acti_nmb.TabIndex = 52
        '
        'horaFin4Acti_nmb
        '
        Me.horaFin4Acti_nmb.Location = New System.Drawing.Point(546, 327)
        Me.horaFin4Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin4Acti_nmb.Name = "horaFin4Acti_nmb"
        Me.horaFin4Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaFin4Acti_nmb.TabIndex = 47
        '
        'horaFin3Acti_nmb
        '
        Me.horaFin3Acti_nmb.Location = New System.Drawing.Point(546, 300)
        Me.horaFin3Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin3Acti_nmb.Name = "horaFin3Acti_nmb"
        Me.horaFin3Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaFin3Acti_nmb.TabIndex = 42
        '
        'horaFin2Acti_nmb
        '
        Me.horaFin2Acti_nmb.Location = New System.Drawing.Point(546, 273)
        Me.horaFin2Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin2Acti_nmb.Name = "horaFin2Acti_nmb"
        Me.horaFin2Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaFin2Acti_nmb.TabIndex = 37
        '
        'horaFin1Acti_nmb
        '
        Me.horaFin1Acti_nmb.Location = New System.Drawing.Point(546, 246)
        Me.horaFin1Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin1Acti_nmb.Name = "horaFin1Acti_nmb"
        Me.horaFin1Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaFin1Acti_nmb.TabIndex = 32
        '
        'minsIniActi_lbl
        '
        Me.minsIniActi_lbl.AutoSize = True
        Me.minsIniActi_lbl.Location = New System.Drawing.Point(462, 224)
        Me.minsIniActi_lbl.Name = "minsIniActi_lbl"
        Me.minsIniActi_lbl.Size = New System.Drawing.Size(55, 19)
        Me.minsIniActi_lbl.TabIndex = 62
        Me.minsIniActi_lbl.Text = "Minutos"
        '
        'horaIniActi_lbl
        '
        Me.horaIniActi_lbl.AutoSize = True
        Me.horaIniActi_lbl.Location = New System.Drawing.Point(414, 224)
        Me.horaIniActi_lbl.Name = "horaIniActi_lbl"
        Me.horaIniActi_lbl.Size = New System.Drawing.Size(38, 19)
        Me.horaIniActi_lbl.TabIndex = 61
        Me.horaIniActi_lbl.Text = "Hora"
        '
        'minsIni5Acti_nmb
        '
        Me.minsIni5Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni5Acti_nmb.Location = New System.Drawing.Point(471, 354)
        Me.minsIni5Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni5Acti_nmb.Name = "minsIni5Acti_nmb"
        Me.minsIni5Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsIni5Acti_nmb.TabIndex = 51
        '
        'minsIni4Acti_nmb
        '
        Me.minsIni4Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni4Acti_nmb.Location = New System.Drawing.Point(471, 327)
        Me.minsIni4Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni4Acti_nmb.Name = "minsIni4Acti_nmb"
        Me.minsIni4Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsIni4Acti_nmb.TabIndex = 46
        '
        'minsIni3Acti_nmb
        '
        Me.minsIni3Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni3Acti_nmb.Location = New System.Drawing.Point(471, 300)
        Me.minsIni3Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni3Acti_nmb.Name = "minsIni3Acti_nmb"
        Me.minsIni3Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsIni3Acti_nmb.TabIndex = 41
        '
        'minsIni2Acti_nmb
        '
        Me.minsIni2Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni2Acti_nmb.Location = New System.Drawing.Point(471, 273)
        Me.minsIni2Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni2Acti_nmb.Name = "minsIni2Acti_nmb"
        Me.minsIni2Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsIni2Acti_nmb.TabIndex = 36
        '
        'minsIni1Acti_nmb
        '
        Me.minsIni1Acti_nmb.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni1Acti_nmb.Location = New System.Drawing.Point(471, 246)
        Me.minsIni1Acti_nmb.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni1Acti_nmb.Name = "minsIni1Acti_nmb"
        Me.minsIni1Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.minsIni1Acti_nmb.TabIndex = 31
        '
        'horaIni5Acti_nmb
        '
        Me.horaIni5Acti_nmb.Location = New System.Drawing.Point(414, 354)
        Me.horaIni5Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni5Acti_nmb.Name = "horaIni5Acti_nmb"
        Me.horaIni5Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaIni5Acti_nmb.TabIndex = 50
        '
        'horaIni4Acti_nmb
        '
        Me.horaIni4Acti_nmb.Location = New System.Drawing.Point(414, 327)
        Me.horaIni4Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni4Acti_nmb.Name = "horaIni4Acti_nmb"
        Me.horaIni4Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaIni4Acti_nmb.TabIndex = 45
        '
        'horaIni3Acti_nmb
        '
        Me.horaIni3Acti_nmb.Location = New System.Drawing.Point(414, 300)
        Me.horaIni3Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni3Acti_nmb.Name = "horaIni3Acti_nmb"
        Me.horaIni3Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaIni3Acti_nmb.TabIndex = 40
        '
        'horaIni2Acti_nmb
        '
        Me.horaIni2Acti_nmb.Location = New System.Drawing.Point(414, 273)
        Me.horaIni2Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni2Acti_nmb.Name = "horaIni2Acti_nmb"
        Me.horaIni2Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaIni2Acti_nmb.TabIndex = 35
        '
        'horaIni1Acti_nmb
        '
        Me.horaIni1Acti_nmb.Location = New System.Drawing.Point(414, 246)
        Me.horaIni1Acti_nmb.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni1Acti_nmb.Name = "horaIni1Acti_nmb"
        Me.horaIni1Acti_nmb.Size = New System.Drawing.Size(40, 20)
        Me.horaIni1Acti_nmb.TabIndex = 30
        '
        'dia5Acti_cmb
        '
        Me.dia5Acti_cmb.FormattingEnabled = True
        Me.dia5Acti_cmb.Location = New System.Drawing.Point(156, 351)
        Me.dia5Acti_cmb.Name = "dia5Acti_cmb"
        Me.dia5Acti_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia5Acti_cmb.TabIndex = 49
        '
        'dia4Acti_cmb
        '
        Me.dia4Acti_cmb.FormattingEnabled = True
        Me.dia4Acti_cmb.Location = New System.Drawing.Point(156, 324)
        Me.dia4Acti_cmb.Name = "dia4Acti_cmb"
        Me.dia4Acti_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia4Acti_cmb.TabIndex = 44
        '
        'dia3Acti_cmb
        '
        Me.dia3Acti_cmb.FormattingEnabled = True
        Me.dia3Acti_cmb.Location = New System.Drawing.Point(156, 297)
        Me.dia3Acti_cmb.Name = "dia3Acti_cmb"
        Me.dia3Acti_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia3Acti_cmb.TabIndex = 39
        '
        'dia2Acti_cmb
        '
        Me.dia2Acti_cmb.FormattingEnabled = True
        Me.dia2Acti_cmb.Location = New System.Drawing.Point(156, 270)
        Me.dia2Acti_cmb.Name = "dia2Acti_cmb"
        Me.dia2Acti_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia2Acti_cmb.TabIndex = 34
        '
        'dia1Acti_cmb
        '
        Me.dia1Acti_cmb.FormattingEnabled = True
        Me.dia1Acti_cmb.Location = New System.Drawing.Point(156, 243)
        Me.dia1Acti_cmb.Name = "dia1Acti_cmb"
        Me.dia1Acti_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia1Acti_cmb.TabIndex = 29
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(562, 191)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel8.TabIndex = 45
        Me.MetroLabel8.Text = "Hora Fin"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(426, 191)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel9.TabIndex = 44
        Me.MetroLabel9.Text = "Hora Inicio"
        '
        'dia5_lbl
        '
        Me.dia5_lbl.AutoSize = True
        Me.dia5_lbl.Location = New System.Drawing.Point(111, 351)
        Me.dia5_lbl.Name = "dia5_lbl"
        Me.dia5_lbl.Size = New System.Drawing.Size(39, 19)
        Me.dia5_lbl.TabIndex = 43
        Me.dia5_lbl.Text = "Dia 5"
        '
        'dia4Acti_lbl
        '
        Me.dia4Acti_lbl.AutoSize = True
        Me.dia4Acti_lbl.Location = New System.Drawing.Point(111, 324)
        Me.dia4Acti_lbl.Name = "dia4Acti_lbl"
        Me.dia4Acti_lbl.Size = New System.Drawing.Size(39, 19)
        Me.dia4Acti_lbl.TabIndex = 42
        Me.dia4Acti_lbl.Text = "Dia 4"
        '
        'dia2Acti_lbl
        '
        Me.dia2Acti_lbl.AutoSize = True
        Me.dia2Acti_lbl.Location = New System.Drawing.Point(111, 270)
        Me.dia2Acti_lbl.Name = "dia2Acti_lbl"
        Me.dia2Acti_lbl.Size = New System.Drawing.Size(39, 19)
        Me.dia2Acti_lbl.TabIndex = 41
        Me.dia2Acti_lbl.Text = "Dia 2"
        '
        'dia3Acti_lbl
        '
        Me.dia3Acti_lbl.AutoSize = True
        Me.dia3Acti_lbl.Location = New System.Drawing.Point(111, 297)
        Me.dia3Acti_lbl.Name = "dia3Acti_lbl"
        Me.dia3Acti_lbl.Size = New System.Drawing.Size(39, 19)
        Me.dia3Acti_lbl.TabIndex = 40
        Me.dia3Acti_lbl.Text = "Dia 3"
        '
        'dia1Acti_lbl
        '
        Me.dia1Acti_lbl.AutoSize = True
        Me.dia1Acti_lbl.Location = New System.Drawing.Point(111, 243)
        Me.dia1Acti_lbl.Name = "dia1Acti_lbl"
        Me.dia1Acti_lbl.Size = New System.Drawing.Size(37, 19)
        Me.dia1Acti_lbl.TabIndex = 39
        Me.dia1Acti_lbl.Text = "Dia 1"
        '
        'tipoActi_cmb
        '
        Me.tipoActi_cmb.FormattingEnabled = True
        Me.tipoActi_cmb.ItemHeight = 13
        Me.tipoActi_cmb.Location = New System.Drawing.Point(157, 117)
        Me.tipoActi_cmb.Name = "tipoActi_cmb"
        Me.tipoActi_cmb.Size = New System.Drawing.Size(148, 21)
        Me.tipoActi_cmb.TabIndex = 27
        '
        'costoActi_text
        '
        '
        '
        '
        Me.costoActi_text.CustomButton.Image = Nothing
        Me.costoActi_text.CustomButton.Location = New System.Drawing.Point(126, 1)
        Me.costoActi_text.CustomButton.Name = ""
        Me.costoActi_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.costoActi_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.costoActi_text.CustomButton.TabIndex = 1
        Me.costoActi_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.costoActi_text.CustomButton.UseSelectable = True
        Me.costoActi_text.CustomButton.Visible = False
        Me.costoActi_text.Lines = New String(-1) {}
        Me.costoActi_text.Location = New System.Drawing.Point(157, 146)
        Me.costoActi_text.MaxLength = 32767
        Me.costoActi_text.Name = "costoActi_text"
        Me.costoActi_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.costoActi_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.costoActi_text.SelectedText = ""
        Me.costoActi_text.SelectionLength = 0
        Me.costoActi_text.SelectionStart = 0
        Me.costoActi_text.Size = New System.Drawing.Size(148, 23)
        Me.costoActi_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.costoActi_text.TabIndex = 28
        Me.costoActi_text.UseSelectable = True
        Me.costoActi_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.costoActi_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'nombreActi_text
        '
        '
        '
        '
        Me.nombreActi_text.CustomButton.Image = Nothing
        Me.nombreActi_text.CustomButton.Location = New System.Drawing.Point(484, 1)
        Me.nombreActi_text.CustomButton.Name = ""
        Me.nombreActi_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.nombreActi_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.nombreActi_text.CustomButton.TabIndex = 1
        Me.nombreActi_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.nombreActi_text.CustomButton.UseSelectable = True
        Me.nombreActi_text.CustomButton.Visible = False
        Me.nombreActi_text.Lines = New String(-1) {}
        Me.nombreActi_text.Location = New System.Drawing.Point(157, 55)
        Me.nombreActi_text.MaxLength = 32767
        Me.nombreActi_text.Name = "nombreActi_text"
        Me.nombreActi_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nombreActi_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.nombreActi_text.SelectedText = ""
        Me.nombreActi_text.SelectionLength = 0
        Me.nombreActi_text.SelectionStart = 0
        Me.nombreActi_text.Size = New System.Drawing.Size(506, 23)
        Me.nombreActi_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.nombreActi_text.TabIndex = 25
        Me.nombreActi_text.UseSelectable = True
        Me.nombreActi_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.nombreActi_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'codigoActi_text
        '
        '
        '
        '
        Me.codigoActi_text.CustomButton.Image = Nothing
        Me.codigoActi_text.CustomButton.Location = New System.Drawing.Point(126, 1)
        Me.codigoActi_text.CustomButton.Name = ""
        Me.codigoActi_text.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.codigoActi_text.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.codigoActi_text.CustomButton.TabIndex = 1
        Me.codigoActi_text.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.codigoActi_text.CustomButton.UseSelectable = True
        Me.codigoActi_text.CustomButton.Visible = False
        Me.codigoActi_text.Lines = New String(-1) {}
        Me.codigoActi_text.Location = New System.Drawing.Point(157, 86)
        Me.codigoActi_text.MaxLength = 32767
        Me.codigoActi_text.Name = "codigoActi_text"
        Me.codigoActi_text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.codigoActi_text.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.codigoActi_text.SelectedText = ""
        Me.codigoActi_text.SelectionLength = 0
        Me.codigoActi_text.SelectionStart = 0
        Me.codigoActi_text.Size = New System.Drawing.Size(148, 23)
        Me.codigoActi_text.Style = MetroFramework.MetroColorStyle.Purple
        Me.codigoActi_text.TabIndex = 26
        Me.codigoActi_text.UseSelectable = True
        Me.codigoActi_text.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.codigoActi_text.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'nombreActi_lbl
        '
        Me.nombreActi_lbl.AutoSize = True
        Me.nombreActi_lbl.Location = New System.Drawing.Point(31, 55)
        Me.nombreActi_lbl.Name = "nombreActi_lbl"
        Me.nombreActi_lbl.Size = New System.Drawing.Size(59, 19)
        Me.nombreActi_lbl.TabIndex = 14
        Me.nombreActi_lbl.Text = "Nombre"
        '
        'tipoActi_lbl
        '
        Me.tipoActi_lbl.AutoSize = True
        Me.tipoActi_lbl.Location = New System.Drawing.Point(31, 117)
        Me.tipoActi_lbl.Name = "tipoActi_lbl"
        Me.tipoActi_lbl.Size = New System.Drawing.Size(35, 19)
        Me.tipoActi_lbl.TabIndex = 13
        Me.tipoActi_lbl.Text = "Tipo"
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.Location = New System.Drawing.Point(31, 146)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel22.TabIndex = 12
        Me.MetroLabel22.Text = "Costo"
        '
        'codigoActi_lbl
        '
        Me.codigoActi_lbl.AutoSize = True
        Me.codigoActi_lbl.Location = New System.Drawing.Point(31, 86)
        Me.codigoActi_lbl.Name = "codigoActi_lbl"
        Me.codigoActi_lbl.Size = New System.Drawing.Size(79, 19)
        Me.codigoActi_lbl.TabIndex = 11
        Me.codigoActi_lbl.Text = "Codigo Acti"
        '
        'acti_lbl
        '
        Me.acti_lbl.AutoSize = True
        Me.acti_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.acti_lbl.Location = New System.Drawing.Point(4, 9)
        Me.acti_lbl.Name = "acti_lbl"
        Me.acti_lbl.Size = New System.Drawing.Size(111, 25)
        Me.acti_lbl.TabIndex = 10
        Me.acti_lbl.Text = "Registrar Acti"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Location = New System.Drawing.Point(399, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(124, 185)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox6.Location = New System.Drawing.Point(533, 200)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(124, 185)
        Me.GroupBox6.TabIndex = 75
        Me.GroupBox6.TabStop = False
        '
        'horariosActi_grp
        '
        Me.horariosActi_grp.BackColor = System.Drawing.SystemColors.Window
        Me.horariosActi_grp.Controls.Add(Me.MetroLabel26)
        Me.horariosActi_grp.Location = New System.Drawing.Point(30, 176)
        Me.horariosActi_grp.Name = "horariosActi_grp"
        Me.horariosActi_grp.Size = New System.Drawing.Size(678, 222)
        Me.horariosActi_grp.TabIndex = 77
        Me.horariosActi_grp.TabStop = False
        '
        'MetroLabel26
        '
        Me.MetroLabel26.AutoSize = True
        Me.MetroLabel26.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel26.Location = New System.Drawing.Point(0, -5)
        Me.MetroLabel26.Name = "MetroLabel26"
        Me.MetroLabel26.Size = New System.Drawing.Size(76, 25)
        Me.MetroLabel26.TabIndex = 38
        Me.MetroLabel26.Text = "Horarios"
        '
        'listaCarreras_pnl
        '
        Me.listaCarreras_pnl.Controls.Add(Me.listaCursos_pnl)
        Me.listaCarreras_pnl.Controls.Add(Me.listaCarrerasVolver_btn)
        Me.listaCarreras_pnl.Controls.Add(Me.MetroLabel17)
        Me.listaCarreras_pnl.Controls.Add(Me.listaCarreras_dg)
        Me.listaCarreras_pnl.Controls.Add(Me.carreras_lbl)
        Me.listaCarreras_pnl.Controls.Add(Me.nuevaCarrera_btn)
        Me.listaCarreras_pnl.HorizontalScrollbarBarColor = True
        Me.listaCarreras_pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.listaCarreras_pnl.HorizontalScrollbarSize = 10
        Me.listaCarreras_pnl.Location = New System.Drawing.Point(0, 3)
        Me.listaCarreras_pnl.Name = "listaCarreras_pnl"
        Me.listaCarreras_pnl.Size = New System.Drawing.Size(767, 461)
        Me.listaCarreras_pnl.Style = MetroFramework.MetroColorStyle.Blue
        Me.listaCarreras_pnl.TabIndex = 50
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
        Me.listaCarreras_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.Codigo, Me.Costo, Me.Horario, Me.DataGridViewImageColumn4})
        Me.listaCarreras_dg.Location = New System.Drawing.Point(7, 37)
        Me.listaCarreras_dg.Name = "listaCarreras_dg"
        Me.listaCarreras_dg.RowHeadersVisible = False
        Me.listaCarreras_dg.Size = New System.Drawing.Size(739, 344)
        Me.listaCarreras_dg.TabIndex = 12
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
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
        'listaActis_pnl
        '
        Me.listaActis_pnl.Controls.Add(Me.MetroPanel4)
        Me.listaActis_pnl.Controls.Add(Me.vovlerActi_btn)
        Me.listaActis_pnl.Controls.Add(Me.MetroLabel56)
        Me.listaActis_pnl.Controls.Add(Me.listaActis_dg)
        Me.listaActis_pnl.Controls.Add(Me.listaActis_lbl)
        Me.listaActis_pnl.Controls.Add(Me.nuevoActi_btn)
        Me.listaActis_pnl.HorizontalScrollbarBarColor = True
        Me.listaActis_pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.listaActis_pnl.HorizontalScrollbarSize = 10
        Me.listaActis_pnl.Location = New System.Drawing.Point(0, 3)
        Me.listaActis_pnl.Name = "listaActis_pnl"
        Me.listaActis_pnl.Size = New System.Drawing.Size(767, 461)
        Me.listaActis_pnl.Style = MetroFramework.MetroColorStyle.Blue
        Me.listaActis_pnl.TabIndex = 51
        Me.listaActis_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.listaActis_pnl.VerticalScrollbarBarColor = True
        Me.listaActis_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.listaActis_pnl.VerticalScrollbarSize = 10
        Me.listaActis_pnl.Visible = False
        '
        'MetroPanel4
        '
        Me.MetroPanel4.Controls.Add(Me.MetroButton5)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel54)
        Me.MetroPanel4.Controls.Add(Me.DataGridView1)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel55)
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(548, 431)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(0, 3)
        Me.MetroPanel4.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroPanel4.TabIndex = 51
        Me.MetroPanel4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        Me.MetroPanel4.Visible = False
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(7, 412)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(123, 36)
        Me.MetroButton5.TabIndex = 50
        Me.MetroButton5.Text = "Volver"
        Me.MetroButton5.UseSelectable = True
        '
        'MetroLabel54
        '
        Me.MetroLabel54.AutoSize = True
        Me.MetroLabel54.Location = New System.Drawing.Point(723, 7)
        Me.MetroLabel54.Name = "MetroLabel54"
        Me.MetroLabel54.Size = New System.Drawing.Size(20, 19)
        Me.MetroLabel54.TabIndex = 49
        Me.MetroLabel54.Text = "id"
        Me.MetroLabel54.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewImageColumn6})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(739, 344)
        Me.DataGridView1.TabIndex = 12
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewImageColumn6
        '
        Me.DataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn6.HeaderText = ""
        Me.DataGridViewImageColumn6.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.DataGridViewImageColumn6.Name = "DataGridViewImageColumn6"
        Me.DataGridViewImageColumn6.ReadOnly = True
        Me.DataGridViewImageColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'MetroLabel55
        '
        Me.MetroLabel55.AutoSize = True
        Me.MetroLabel55.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel55.Location = New System.Drawing.Point(4, 9)
        Me.MetroLabel55.Name = "MetroLabel55"
        Me.MetroLabel55.Size = New System.Drawing.Size(107, 25)
        Me.MetroLabel55.TabIndex = 10
        Me.MetroLabel55.Text = "Listar Cursos"
        '
        'vovlerActi_btn
        '
        Me.vovlerActi_btn.Location = New System.Drawing.Point(7, 412)
        Me.vovlerActi_btn.Name = "vovlerActi_btn"
        Me.vovlerActi_btn.Size = New System.Drawing.Size(123, 36)
        Me.vovlerActi_btn.TabIndex = 50
        Me.vovlerActi_btn.Text = "Volver"
        Me.vovlerActi_btn.UseSelectable = True
        '
        'MetroLabel56
        '
        Me.MetroLabel56.AutoSize = True
        Me.MetroLabel56.Location = New System.Drawing.Point(723, 7)
        Me.MetroLabel56.Name = "MetroLabel56"
        Me.MetroLabel56.Size = New System.Drawing.Size(20, 19)
        Me.MetroLabel56.TabIndex = 49
        Me.MetroLabel56.Text = "id"
        Me.MetroLabel56.Visible = False
        '
        'listaActis_dg
        '
        Me.listaActis_dg.AllowUserToAddRows = False
        Me.listaActis_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaActis_dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.Codigo2, Me.costo2, Me.horario2, Me.DataGridViewImageColumn7})
        Me.listaActis_dg.Location = New System.Drawing.Point(7, 37)
        Me.listaActis_dg.Name = "listaActis_dg"
        Me.listaActis_dg.RowHeadersVisible = False
        Me.listaActis_dg.Size = New System.Drawing.Size(739, 344)
        Me.listaActis_dg.TabIndex = 12
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'Codigo2
        '
        Me.Codigo2.HeaderText = "Codigo"
        Me.Codigo2.Name = "Codigo2"
        '
        'costo2
        '
        Me.costo2.HeaderText = "Costo"
        Me.costo2.Name = "costo2"
        '
        'horario2
        '
        Me.horario2.HeaderText = "Horario"
        Me.horario2.Name = "horario2"
        '
        'DataGridViewImageColumn7
        '
        Me.DataGridViewImageColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewImageColumn7.HeaderText = ""
        Me.DataGridViewImageColumn7.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.DataGridViewImageColumn7.Name = "DataGridViewImageColumn7"
        Me.DataGridViewImageColumn7.ReadOnly = True
        Me.DataGridViewImageColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'listaActis_lbl
        '
        Me.listaActis_lbl.AutoSize = True
        Me.listaActis_lbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.listaActis_lbl.Location = New System.Drawing.Point(4, 9)
        Me.listaActis_lbl.Name = "listaActis_lbl"
        Me.listaActis_lbl.Size = New System.Drawing.Size(91, 25)
        Me.listaActis_lbl.TabIndex = 10
        Me.listaActis_lbl.Text = "Listar Actis"
        '
        'nuevoActi_btn
        '
        Me.nuevoActi_btn.Location = New System.Drawing.Point(623, 412)
        Me.nuevoActi_btn.Name = "nuevoActi_btn"
        Me.nuevoActi_btn.Size = New System.Drawing.Size(123, 36)
        Me.nuevoActi_btn.TabIndex = 9
        Me.nuevoActi_btn.Text = "Nuevo Acti"
        Me.nuevoActi_btn.UseSelectable = True
        '
        'registrarCarrera_pnl
        '
        Me.registrarCarrera_pnl.Controls.Add(Me.cancelarCarrera_btn)
        Me.registrarCarrera_pnl.Controls.Add(Me.guardarCarrera_btn)
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
        Me.registrarCarrera_pnl.Controls.Add(Me.GroupBox5)
        Me.registrarCarrera_pnl.HorizontalScrollbarBarColor = True
        Me.registrarCarrera_pnl.HorizontalScrollbarHighlightOnWheel = False
        Me.registrarCarrera_pnl.HorizontalScrollbarSize = 10
        Me.registrarCarrera_pnl.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.registrarCarrera_pnl.Location = New System.Drawing.Point(0, 3)
        Me.registrarCarrera_pnl.Name = "registrarCarrera_pnl"
        Me.registrarCarrera_pnl.Size = New System.Drawing.Size(753, 462)
        Me.registrarCarrera_pnl.Style = MetroFramework.MetroColorStyle.Purple
        Me.registrarCarrera_pnl.TabIndex = 81
        Me.registrarCarrera_pnl.Theme = MetroFramework.MetroThemeStyle.Light
        Me.registrarCarrera_pnl.VerticalScrollbarBarColor = True
        Me.registrarCarrera_pnl.VerticalScrollbarHighlightOnWheel = False
        Me.registrarCarrera_pnl.VerticalScrollbarSize = 10
        Me.registrarCarrera_pnl.Visible = False
        '
        'cancelarCarrera_btn
        '
        Me.cancelarCarrera_btn.Location = New System.Drawing.Point(7, 412)
        Me.cancelarCarrera_btn.Name = "cancelarCarrera_btn"
        Me.cancelarCarrera_btn.Size = New System.Drawing.Size(123, 36)
        Me.cancelarCarrera_btn.TabIndex = 79
        Me.cancelarCarrera_btn.Text = "Cancelar"
        Me.cancelarCarrera_btn.UseSelectable = True
        '
        'guardarCarrera_btn
        '
        Me.guardarCarrera_btn.Location = New System.Drawing.Point(623, 412)
        Me.guardarCarrera_btn.Name = "guardarCarrera_btn"
        Me.guardarCarrera_btn.Size = New System.Drawing.Size(123, 36)
        Me.guardarCarrera_btn.TabIndex = 78
        Me.guardarCarrera_btn.Text = "Guardar"
        Me.guardarCarrera_btn.UseSelectable = True
        '
        'min2_lbl
        '
        Me.min2_lbl.AutoSize = True
        Me.min2_lbl.Location = New System.Drawing.Point(594, 224)
        Me.min2_lbl.Name = "min2_lbl"
        Me.min2_lbl.Size = New System.Drawing.Size(55, 19)
        Me.min2_lbl.TabIndex = 74
        Me.min2_lbl.Text = "Minutos"
        '
        'hora2_lbl
        '
        Me.hora2_lbl.AutoSize = True
        Me.hora2_lbl.Location = New System.Drawing.Point(546, 224)
        Me.hora2_lbl.Name = "hora2_lbl"
        Me.hora2_lbl.Size = New System.Drawing.Size(38, 19)
        Me.hora2_lbl.TabIndex = 73
        Me.hora2_lbl.Text = "Hora"
        '
        'minsFin5_nmbr
        '
        Me.minsFin5_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin5_nmbr.Location = New System.Drawing.Point(603, 354)
        Me.minsFin5_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin5_nmbr.Name = "minsFin5_nmbr"
        Me.minsFin5_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsFin5_nmbr.TabIndex = 53
        '
        'minsFin4_nmbr
        '
        Me.minsFin4_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin4_nmbr.Location = New System.Drawing.Point(603, 327)
        Me.minsFin4_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin4_nmbr.Name = "minsFin4_nmbr"
        Me.minsFin4_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsFin4_nmbr.TabIndex = 48
        '
        'minsFin3_nmbr
        '
        Me.minsFin3_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin3_nmbr.Location = New System.Drawing.Point(603, 300)
        Me.minsFin3_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin3_nmbr.Name = "minsFin3_nmbr"
        Me.minsFin3_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsFin3_nmbr.TabIndex = 43
        '
        'minsFin2_nmbr
        '
        Me.minsFin2_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin2_nmbr.Location = New System.Drawing.Point(603, 273)
        Me.minsFin2_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin2_nmbr.Name = "minsFin2_nmbr"
        Me.minsFin2_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsFin2_nmbr.TabIndex = 38
        '
        'minsFin1_nmbr
        '
        Me.minsFin1_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsFin1_nmbr.Location = New System.Drawing.Point(603, 246)
        Me.minsFin1_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsFin1_nmbr.Name = "minsFin1_nmbr"
        Me.minsFin1_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsFin1_nmbr.TabIndex = 33
        '
        'horaFin5_nmbr
        '
        Me.horaFin5_nmbr.Location = New System.Drawing.Point(546, 354)
        Me.horaFin5_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin5_nmbr.Name = "horaFin5_nmbr"
        Me.horaFin5_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaFin5_nmbr.TabIndex = 52
        '
        'horaFin4_nmbr
        '
        Me.horaFin4_nmbr.Location = New System.Drawing.Point(546, 327)
        Me.horaFin4_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin4_nmbr.Name = "horaFin4_nmbr"
        Me.horaFin4_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaFin4_nmbr.TabIndex = 47
        '
        'horaFin3_nmbr
        '
        Me.horaFin3_nmbr.Location = New System.Drawing.Point(546, 300)
        Me.horaFin3_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin3_nmbr.Name = "horaFin3_nmbr"
        Me.horaFin3_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaFin3_nmbr.TabIndex = 42
        '
        'horaFin2_nmbr
        '
        Me.horaFin2_nmbr.Location = New System.Drawing.Point(546, 273)
        Me.horaFin2_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin2_nmbr.Name = "horaFin2_nmbr"
        Me.horaFin2_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaFin2_nmbr.TabIndex = 37
        '
        'horaFin1_nmbr
        '
        Me.horaFin1_nmbr.Location = New System.Drawing.Point(546, 246)
        Me.horaFin1_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaFin1_nmbr.Name = "horaFin1_nmbr"
        Me.horaFin1_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaFin1_nmbr.TabIndex = 32
        '
        'min1_lbl
        '
        Me.min1_lbl.AutoSize = True
        Me.min1_lbl.Location = New System.Drawing.Point(462, 224)
        Me.min1_lbl.Name = "min1_lbl"
        Me.min1_lbl.Size = New System.Drawing.Size(55, 19)
        Me.min1_lbl.TabIndex = 62
        Me.min1_lbl.Text = "Minutos"
        '
        'hora1_lbl
        '
        Me.hora1_lbl.AutoSize = True
        Me.hora1_lbl.Location = New System.Drawing.Point(414, 224)
        Me.hora1_lbl.Name = "hora1_lbl"
        Me.hora1_lbl.Size = New System.Drawing.Size(38, 19)
        Me.hora1_lbl.TabIndex = 61
        Me.hora1_lbl.Text = "Hora"
        '
        'minsIni5_nmbr
        '
        Me.minsIni5_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni5_nmbr.Location = New System.Drawing.Point(471, 354)
        Me.minsIni5_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni5_nmbr.Name = "minsIni5_nmbr"
        Me.minsIni5_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsIni5_nmbr.TabIndex = 51
        '
        'minsIni4_nmbr
        '
        Me.minsIni4_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni4_nmbr.Location = New System.Drawing.Point(471, 327)
        Me.minsIni4_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni4_nmbr.Name = "minsIni4_nmbr"
        Me.minsIni4_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsIni4_nmbr.TabIndex = 46
        '
        'minsIni3_nmbr
        '
        Me.minsIni3_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni3_nmbr.Location = New System.Drawing.Point(471, 300)
        Me.minsIni3_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni3_nmbr.Name = "minsIni3_nmbr"
        Me.minsIni3_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsIni3_nmbr.TabIndex = 41
        '
        'minsIni2_nmbr
        '
        Me.minsIni2_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni2_nmbr.Location = New System.Drawing.Point(471, 273)
        Me.minsIni2_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni2_nmbr.Name = "minsIni2_nmbr"
        Me.minsIni2_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsIni2_nmbr.TabIndex = 36
        '
        'minsIni1_nmbr
        '
        Me.minsIni1_nmbr.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.minsIni1_nmbr.Location = New System.Drawing.Point(471, 246)
        Me.minsIni1_nmbr.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minsIni1_nmbr.Name = "minsIni1_nmbr"
        Me.minsIni1_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.minsIni1_nmbr.TabIndex = 31
        '
        'horaIni5_nmbr
        '
        Me.horaIni5_nmbr.Location = New System.Drawing.Point(414, 354)
        Me.horaIni5_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni5_nmbr.Name = "horaIni5_nmbr"
        Me.horaIni5_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaIni5_nmbr.TabIndex = 50
        '
        'horaIni4_nmbr
        '
        Me.horaIni4_nmbr.Location = New System.Drawing.Point(414, 327)
        Me.horaIni4_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni4_nmbr.Name = "horaIni4_nmbr"
        Me.horaIni4_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaIni4_nmbr.TabIndex = 45
        '
        'horaIni3_nmbr
        '
        Me.horaIni3_nmbr.Location = New System.Drawing.Point(414, 300)
        Me.horaIni3_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni3_nmbr.Name = "horaIni3_nmbr"
        Me.horaIni3_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaIni3_nmbr.TabIndex = 40
        '
        'horaIni2_nmbr
        '
        Me.horaIni2_nmbr.Location = New System.Drawing.Point(414, 273)
        Me.horaIni2_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni2_nmbr.Name = "horaIni2_nmbr"
        Me.horaIni2_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaIni2_nmbr.TabIndex = 35
        '
        'horaIni1_nmbr
        '
        Me.horaIni1_nmbr.Location = New System.Drawing.Point(414, 246)
        Me.horaIni1_nmbr.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.horaIni1_nmbr.Name = "horaIni1_nmbr"
        Me.horaIni1_nmbr.Size = New System.Drawing.Size(40, 20)
        Me.horaIni1_nmbr.TabIndex = 30
        '
        'dia5_cmb
        '
        Me.dia5_cmb.FormattingEnabled = True
        Me.dia5_cmb.Location = New System.Drawing.Point(156, 351)
        Me.dia5_cmb.Name = "dia5_cmb"
        Me.dia5_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia5_cmb.TabIndex = 49
        '
        'dia4_cmb
        '
        Me.dia4_cmb.FormattingEnabled = True
        Me.dia4_cmb.Location = New System.Drawing.Point(156, 324)
        Me.dia4_cmb.Name = "dia4_cmb"
        Me.dia4_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia4_cmb.TabIndex = 44
        '
        'dia3_cmb
        '
        Me.dia3_cmb.FormattingEnabled = True
        Me.dia3_cmb.Location = New System.Drawing.Point(156, 297)
        Me.dia3_cmb.Name = "dia3_cmb"
        Me.dia3_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia3_cmb.TabIndex = 39
        '
        'dia2_cmb
        '
        Me.dia2_cmb.FormattingEnabled = True
        Me.dia2_cmb.Location = New System.Drawing.Point(156, 270)
        Me.dia2_cmb.Name = "dia2_cmb"
        Me.dia2_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia2_cmb.TabIndex = 34
        '
        'dia1_cmb
        '
        Me.dia1_cmb.FormattingEnabled = True
        Me.dia1_cmb.Location = New System.Drawing.Point(156, 243)
        Me.dia1_cmb.Name = "dia1_cmb"
        Me.dia1_cmb.Size = New System.Drawing.Size(148, 21)
        Me.dia1_cmb.TabIndex = 29
        '
        'horaFin_lbl
        '
        Me.horaFin_lbl.AutoSize = True
        Me.horaFin_lbl.Location = New System.Drawing.Point(562, 191)
        Me.horaFin_lbl.Name = "horaFin_lbl"
        Me.horaFin_lbl.Size = New System.Drawing.Size(59, 19)
        Me.horaFin_lbl.TabIndex = 45
        Me.horaFin_lbl.Text = "Hora Fin"
        '
        'horaIni_lbl
        '
        Me.horaIni_lbl.AutoSize = True
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
        Me.costoCarrera_text.MaxLength = 32767
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
        Me.nombreCarrera_text.MaxLength = 32767
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
        Me.codigoCarrera_text.MaxLength = 32767
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
        Me.GroupBox3.Location = New System.Drawing.Point(399, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 185)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox4.Location = New System.Drawing.Point(533, 200)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(124, 185)
        Me.GroupBox4.TabIndex = 75
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox5.Controls.Add(Me.MetroLabel51)
        Me.GroupBox5.Location = New System.Drawing.Point(30, 176)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(678, 222)
        Me.GroupBox5.TabIndex = 77
        Me.GroupBox5.TabStop = False
        '
        'MetroLabel51
        '
        Me.MetroLabel51.AutoSize = True
        Me.MetroLabel51.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel51.Location = New System.Drawing.Point(0, -5)
        Me.MetroLabel51.Name = "MetroLabel51"
        Me.MetroLabel51.Size = New System.Drawing.Size(76, 25)
        Me.MetroLabel51.TabIndex = 38
        Me.MetroLabel51.Text = "Horarios"
        '
        'tCareers
        '
        Me.tCareers.ActiveControl = Nothing
        Me.tCareers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tCareers.Location = New System.Drawing.Point(24, 27)
        Me.tCareers.Name = "tCareers"
        Me.tCareers.Size = New System.Drawing.Size(124, 119)
        Me.tCareers.Style = MetroFramework.MetroColorStyle.Purple
        Me.tCareers.TabIndex = 3
        Me.tCareers.Text = "Carreras"
        Me.tCareers.UseSelectable = True
        '
        'tActis
        '
        Me.tActis.ActiveControl = Nothing
        Me.tActis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tActis.Location = New System.Drawing.Point(165, 27)
        Me.tActis.Name = "tActis"
        Me.tActis.Size = New System.Drawing.Size(124, 119)
        Me.tActis.Style = MetroFramework.MetroColorStyle.Purple
        Me.tActis.TabIndex = 4
        Me.tActis.Text = "Acti's"
        Me.tActis.UseSelectable = True
        '
        'tabsContainer
        '
        Me.tabsContainer.Controls.Add(Me.tabProducts)
        Me.tabsContainer.Controls.Add(Me.tabProspectus)
        Me.tabsContainer.Controls.Add(Me.tabUsers)
        Me.tabsContainer.Controls.Add(Me.tabConfiguration)
        Me.tabsContainer.Controls.Add(Me.tabSales)
        Me.tabsContainer.Controls.Add(Me.tabKpi)
        Me.tabsContainer.Controls.Add(Me.tabEvents)
        Me.tabsContainer.Controls.Add(Me.tabReports)
        Me.tabsContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabsContainer.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.tabsContainer.Location = New System.Drawing.Point(20, 60)
        Me.tabsContainer.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.tabsContainer.Name = "tabsContainer"
        Me.tabsContainer.SelectedIndex = 0
        Me.tabsContainer.Size = New System.Drawing.Size(760, 520)
        Me.tabsContainer.Style = MetroFramework.MetroColorStyle.Purple
        Me.tabsContainer.TabIndex = 1
        Me.tabsContainer.UseSelectable = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.lblSignOut)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.tabsContainer)
        Me.Name = "FrmMain"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Menu Principal"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSales.ResumeLayout(False)
        Me.listarVerntas_pnl.ResumeLayout(False)
        Me.listarVerntas_pnl.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RegistrarVentas_pnl.ResumeLayout(False)
        Me.RegistrarVentas_pnl.PerformLayout()
        CType(Me.listaVentas_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConfiguration.ResumeLayout(False)
        Me.pnlUpdateUserInfo.ResumeLayout(False)
        Me.pnlUpdateUserInfo.PerformLayout()
        Me.tabUsers.ResumeLayout(False)
        Me.pnlCreateUser.ResumeLayout(False)
        Me.pnlCreateUser.PerformLayout()
        Me.pnlCreateRol.ResumeLayout(False)
        Me.pnlCreateRol.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gboPorductsSectionRol.ResumeLayout(False)
        Me.gboPorductsSectionRol.PerformLayout()
        Me.pnlListRols.ResumeLayout(False)
        Me.pnlListRols.PerformLayout()
        CType(Me.lstRols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnListUsers.ResumeLayout(False)
        Me.pnListUsers.PerformLayout()
        CType(Me.lstUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlListaSeguimientos.ResumeLayout(False)
        Me.PnlListaSeguimientos.PerformLayout()
        CType(Me.lstSeguimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProspectus.ResumeLayout(False)
        Me.PnlListaProspectos.ResumeLayout(False)
        Me.PnlListaProspectos.PerformLayout()
        CType(Me.lstProspectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlNuevoProspecto.ResumeLayout(False)
        Me.PnlNuevoProspecto.PerformLayout()
        Me.pnlSeguimientos.ResumeLayout(False)
        Me.pnlSeguimientos.PerformLayout()
        Me.tabProducts.ResumeLayout(False)
        Me.registrarActi_pnl.ResumeLayout(False)
        Me.registrarActi_pnl.PerformLayout()
        CType(Me.minsFin5Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsFin4Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsFin3Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsFin2Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsFin1Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin5Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin4Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin3Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin2Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaFin1Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni5Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni4Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni3Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni2Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minsIni1Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni5Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni4Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni3Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni2Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.horaIni1Acti_nmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.horariosActi_grp.ResumeLayout(False)
        Me.horariosActi_grp.PerformLayout()
        Me.listaCarreras_pnl.ResumeLayout(False)
        Me.listaCarreras_pnl.PerformLayout()
        Me.listaCursos_pnl.ResumeLayout(False)
        Me.listaCursos_pnl.PerformLayout()
        CType(Me.listaCursos_dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaCarreras_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.listaActis_pnl.ResumeLayout(False)
        Me.listaActis_pnl.PerformLayout()
        Me.MetroPanel4.ResumeLayout(False)
        Me.MetroPanel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaActis_dg, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.tabsContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents lblSignOut As MetroFramework.Controls.MetroLink
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents tabsContainer As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabProducts As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tActis As MetroFramework.Controls.MetroTile
    Friend WithEvents tCareers As MetroFramework.Controls.MetroTile
    Friend WithEvents tabProspectus As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PnlListaSeguimientos As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnCancelarListaSeguimiento As MetroFramework.Controls.MetroButton
    Friend WithEvents lstSeguimientos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lblListaSeguimientos As MetroFramework.Controls.MetroLabel
    Friend WithEvents PnlListaProspectos As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblListaProspectos As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCrearProspecto As MetroFramework.Controls.MetroButton
    Friend WithEvents lstProspectos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PnlNuevoProspecto As MetroFramework.Controls.MetroPanel
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
    Friend WithEvents pnlSeguimientos As MetroFramework.Controls.MetroPanel
    Friend WithEvents txtComentarioSeguimiento As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelarSeguimiento As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarSeguimiento As MetroFramework.Controls.MetroButton
    Friend WithEvents lblComentarioSeguimiento As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFechaSeguimiento As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblFechaSeguimiento As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tabUsers As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabConfiguration As MetroFramework.Controls.MetroTabPage
    Friend WithEvents pnlUpdateUserInfo As MetroFramework.Controls.MetroPanel
    Friend WithEvents tgChangePassUpdateUserInfo As MetroFramework.Controls.MetroToggle
    Friend WithEvents txtPasswordUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNewPassUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNewpassUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboDateUpdateUserInfo As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblDateUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmailUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblEmailUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtLastNameUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPhoneUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNameUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIdUpdateUserInfo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelUpdateUserInfo As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveUpdateUserInfo As MetroFramework.Controls.MetroButton
    Friend WithEvents lblPasswordUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPhoneUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNameUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblLastNameUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblIdUpdateUserInfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tUpdateUserInformation As MetroFramework.Controls.MetroTile
    Friend WithEvents tSignOutUser As MetroFramework.Controls.MetroTile
    Friend WithEvents tabEvents As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabSales As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabKpi As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabReports As MetroFramework.Controls.MetroTabPage
    Friend WithEvents lblIdSeguimiento As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblIdProspecto As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnlListRols As MetroFramework.Controls.MetroPanel
    Friend WithEvents pnlCreateRol As MetroFramework.Controls.MetroPanel
    Friend WithEvents tgEnabledRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents txtRolName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelRol As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveRol As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEnabledRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNameRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblRolUserTittle As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnBackRolsUsers As MetroFramework.Controls.MetroButton
    Friend WithEvents lblIdRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lstRols As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNameRol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStateRol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lblListOfRols As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnNewRol As MetroFramework.Controls.MetroButton
    Friend WithEvents pnListUsers As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblCreateUpdateUserId As MetroFramework.Controls.MetroLabel
    Friend WithEvents lstUsers As System.Windows.Forms.DataGridView
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdentificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lblRols As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCreateUser As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlCreateUser As MetroFramework.Controls.MetroPanel
    Friend WithEvents cboDateCreateUser As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblDateCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmailCreateUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblEmailCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtLastNameCreateUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboRolCreateUser As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tgEnableCreateUser As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblRolCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEnabledCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPhoneCreateUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPasswordCreateUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNameCreateUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIdCreateUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelCreateUser As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveCreateUser As MetroFramework.Controls.MetroButton
    Friend WithEvents lblPaswordCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPhoneCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNameCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblLastNameCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCedulaCreateUser As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCreateUserTittle As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPermissionsRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tgProspectusRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents tgSalesRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblConfigurationRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblReportsRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblKpiRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEventsRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProspectusRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSalesRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents tgConfigurationRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents tgReportsRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents tgKpiRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents tgEventsRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents listaCarreras_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents listaCarrerasVolver_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaCarreras_dg As System.Windows.Forms.DataGridView
    Friend WithEvents carreras_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents nuevaCarrera_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents listaCursos_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents listaCursosVolver_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaCursos_dg As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn5 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents listaCursos_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents registrarCarrera_pnl As MetroFramework.Controls.MetroPanel
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
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel51 As MetroFramework.Controls.MetroLabel
    Friend WithEvents guardarCarrera_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents cancelarCarrera_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents registrarActi_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents cancelarActi_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents guardarActi_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents minsFinActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents horaFinActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents minsFin5Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsFin4Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsFin3Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsFin2Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsFin1Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin5Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin4Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin3Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin2Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaFin1Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIniActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents horaIniActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents minsIni5Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIni4Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIni3Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIni2Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents minsIni1Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni5Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni4Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni3Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni2Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents horaIni1Acti_nmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents dia5Acti_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents dia4Acti_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents dia3Acti_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents dia2Acti_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents dia1Acti_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dia5_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents dia4Acti_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents dia2Acti_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents dia3Acti_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents dia1Acti_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents tipoActi_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents costoActi_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents nombreActi_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents codigoActi_text As MetroFramework.Controls.MetroTextBox
    Friend WithEvents nombreActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents tipoActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents codigoActi_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents acti_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents horariosActi_grp As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel26 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaActis_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel54 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn6 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents MetroLabel55 As MetroFramework.Controls.MetroLabel
    Friend WithEvents vovlerActi_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel56 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaActis_dg As System.Windows.Forms.DataGridView
    Friend WithEvents listaActis_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents nuevoActi_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Horario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn4 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents horario2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn7 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents RegistrarVentas_pnl As MetroFramework.Controls.MetroPanel
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
    Friend WithEvents listarVerntas_pnl As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn8 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents volverVenta_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaVentas_dg As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn9 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents listarVentas_lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents nuevaVenta_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents cancelarVenta_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents guardarVenta_btn As MetroFramework.Controls.MetroButton
    Friend WithEvents gboPorductsSectionRol As System.Windows.Forms.GroupBox
    Friend WithEvents lblActisRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCareersRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents tgCareersRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents tgActiRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblProductsSectionRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents tgUsersRol As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblUsersRol As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbEventos As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ckbEventoProspecto As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lblInteres As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbInteresesProspecto As MetroFramework.Controls.MetroComboBox
    Friend WithEvents chkChangeUserPassword As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lblPasswordUserBackup As System.Windows.Forms.Label
End Class
