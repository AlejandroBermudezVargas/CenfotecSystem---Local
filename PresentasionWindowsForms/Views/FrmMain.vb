Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports PresentasionWindowsForms.My.Resources

Public Class FrmMain
    Private user As UserModel
    Sub New(ByRef puser As UserModel)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        user = puser
        Me.Text = user.nombre + " " + user.apellido
        Me.tActis.Visible = False
        Me.tCareers.Visible = False
        Me.tabsContainer.TabPages.Remove(Me.tabProducts)
        Me.tabsContainer.TabPages.Remove(Me.tabProspectus)
        Me.tabsContainer.TabPages.Remove(Me.tabSales)
        Me.tabsContainer.TabPages.Remove(Me.tabEvents)
        Me.tabsContainer.TabPages.Remove(Me.tabKpi)
        Me.tabsContainer.TabPages.Remove(Me.tabUsers)
        Me.tabsContainer.TabPages.Remove(Me.tabReports)
        Me.tabsContainer.TabPages.Remove(Me.tabConfiguration)
    End Sub

    '////////////////USUARIOS///////////////////////////////////////

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.llenarListaProspectos()
        hideCreateUserForm()
        showListOfUsers()
        'llenarTablaCarreras()
        llenarComboTiposActi()
        llenarComboTiposCarrera()
        LlenarComboDias()
        llenarComboTipoVenta()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: crear user
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hideCreateUserForm()
        Me.pnlCreateUser.Hide()
        clearCreateUserForm()
    End Sub


    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: Listar usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showListUserForm()
        Me.pnListUsers.Show()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: Listar usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hideListUserForm()
        Me.pnlCreateUser.Hide()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: crear usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearCreateUserForm()
        txtIdCreateUser.Text = ""
        txtNameCreateUser.Text = ""
        txtLastNameCreateUser.Text = ""
        txtPasswordCreateUser.Text = ""
        txtPhoneCreateUser.Text = ""
        txtEmailCreateUser.Text = ""
        tgEnableCreateUser.Checked = False
        chkChangeUserPassword.Checked = False
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: crear usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showCreateUserForm(ByVal id As String)
        clearCreateUserForm()
        Me.pnlCreateUser.Visible = True
        Dim roles As List(Of RolModel) = RolsController.obtener()
        'Llenar roles
        Dim comboSource As New Dictionary(Of String, String)()
        For Each rol As RolModel In roles
            comboSource.Add(rol.id_rol.ToString, rol.nombre)
        Next
        cboRolCreateUser.DataSource = New BindingSource(comboSource, Nothing)
        lblCreateUpdateUserId.Text = id
        cboRolCreateUser.DisplayMember = "Value"
        cboRolCreateUser.ValueMember = "Key"
        If id = "-1" Then
            lblCreateUserTittle.Text = "Crear usuario"
            txtPasswordCreateUser.Enabled = True
            chkChangeUserPassword.Visible = False
        Else
            lblCreateUserTittle.Text = "Modificar usuario"
            Dim user As UserModel = Users_controller.getUser(id)
            If (Not user Is Nothing) Then
                txtIdCreateUser.Text = user.cedula
                txtNameCreateUser.Text = user.nombre
                txtLastNameCreateUser.Text = user.apellido
                txtEmailCreateUser.Text = user.correo
                txtPhoneCreateUser.Text = user.telefono
                txtPasswordCreateUser.Text = user.password
                cboRolCreateUser.SelectedIndex = cboRolCreateUser.FindStringExact(user.rol.nombre)
                tgEnableCreateUser.Checked = user.activo
                cboDateCreateUser.Value = user.fecha_nacimiento
                txtPasswordCreateUser.Enabled = False
                lblPasswordUserBackup.Text = user.password
            Else
                MsgBox(respuestasDelSistema.POPULATE_FILLS_ERROR, MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: Listar usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hideListOfUsers()
        pnListUsers.Hide()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: Listar usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showListOfUsers()
        pnListUsers.Show()
        populateListOfUsers()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: cambiar datos de usuario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hideUpdateUserInfo()
        pnlUpdateUserInfo.Hide()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: cambiar datos de usuario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showUpdateUserInfo()
        pnlUpdateUserInfo.Show()
    End Sub


    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: crear usuario y modificar usuario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnSaveCreateUser_Click(sender As Object, e As EventArgs) Handles btnSaveCreateUser.Click
        Dim id_rol As String = DirectCast(cboRolCreateUser.SelectedItem, KeyValuePair(Of String, String)).Key
        If (validateCreateUserForm()) Then
            If String.Compare(lblCreateUpdateUserId.Text, "-1") = 0 Then
                If (Users_controller.create(txtIdCreateUser.Text, txtNameCreateUser.Text, txtLastNameCreateUser.Text,
                                    txtEmailCreateUser.Text, txtPhoneCreateUser.Text, txtPasswordCreateUser.Text,
                                    id_rol, tgEnableCreateUser.Checked, cboDateCreateUser.Value)) Then
                    showListOfUsers()
                    hideCreateUserForm()
                    MsgBox(respuestasDelSistema.CREATE_USER_SUCCESS, MsgBoxStyle.Information)
                Else
                    MsgBox(respuestasDelSistema.UPDATE__USER_ERROR, MsgBoxStyle.Critical)
                End If
            Else
                If (chkChangeUserPassword.Checked) Then
                    If (Users_controller.updateUserAndPassword(lblCreateUpdateUserId.Text, txtIdCreateUser.Text, txtNameCreateUser.Text, txtLastNameCreateUser.Text,
                                                txtEmailCreateUser.Text, txtPhoneCreateUser.Text, txtPasswordCreateUser.Text,
                                                id_rol, tgEnableCreateUser.Checked, cboDateCreateUser.Value)) Then
                        MsgBox(respuestasDelSistema.UPDATE_USER_SUCCESS, MsgBoxStyle.Information)
                        showListOfUsers()
                        hideCreateUserForm()
                    Else
                        MsgBox(respuestasDelSistema.UPDATE__USER_ERROR, MsgBoxStyle.Critical)
                    End If
                Else 'no quiere cambiar la contraseña
                    If (Users_controller.update(lblCreateUpdateUserId.Text, txtIdCreateUser.Text, txtNameCreateUser.Text, txtLastNameCreateUser.Text,
                                                txtEmailCreateUser.Text, txtPhoneCreateUser.Text, txtPasswordCreateUser.Text,
                                                id_rol, tgEnableCreateUser.Checked, cboDateCreateUser.Value)) Then
                        MsgBox(respuestasDelSistema.UPDATE_USER_SUCCESS, MsgBoxStyle.Information)
                        showListOfUsers()
                        hideCreateUserForm()
                    Else
                        MsgBox(respuestasDelSistema.UPDATE__USER_ERROR, MsgBoxStyle.Critical)
                    End If
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: crear usuario y modificar usuario
    ''' </summary>
    ''' <remarks></remarks>
    Private Function validateCreateUserForm() As Boolean
        Dim result As Boolean = True
        If isAUserId(txtIdCreateUser.Text) Then
            result = False
            ErrorProvider1.SetError(txtIdCreateUser, ValidationsMessages.INVALID_USER_ID)
            txtIdCreateUser.WithError = True
        End If
        If Not OnlyTextAllowSpaces(txtNameCreateUser.Text) Then
            result = False
            ErrorProvider1.SetError(txtNameCreateUser, ValidationsMessages.ONLY_TEXT_ALLOW_SPACES)
        End If
        If Not OnlyTextAllowSpaces(txtLastNameCreateUser.Text) Then
            result = False
            ErrorProvider1.SetError(txtLastNameCreateUser, ValidationsMessages.ONLY_TEXT_ALLOW_SPACES)
        End If
        If Not IsEmail(txtEmailCreateUser.Text) Then
            result = False
            ErrorProvider1.SetError(txtEmailCreateUser, ValidationsMessages.INVALID_EMAIL)
        End If
        If Not isAPhoneNumber(txtPhoneCreateUser.Text) Or txtPhoneCreateUser.Text.Length < 8 Then
            result = False
            ErrorProvider1.SetError(txtPhoneCreateUser, ValidationsMessages.INVALID_PHONE_NUMBER)
        End If
        If (chkChangeUserPassword.Checked) Then
            If Not IsGoodPassword(txtPasswordCreateUser.Text) Then
                ErrorProvider1.SetError(txtPasswordCreateUser, ValidationsMessages.PASSWORD_INCORRECT_FORMAT)
                result = False
            End If
        End If
        Return result
    End Function

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: cerrar sesion
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Users_controller.signOut(user)
        Application.Exit()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: cerrar sesion
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub lblSignOut_Click(sender As Object, e As EventArgs) Handles lblSignOut.Click
        Dim login As New FrmLogin()
        Me.Hide()
        login.ShowDialog()
        Me.Close()
    End Sub


    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: crear usuario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnCancelCreateUser_Click(sender As Object, e As EventArgs) Handles btnCancelCreateUser.Click
        hideCreateUserForm()
        showListOfUsers()
        clearCreateUserForm()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 3-11-2015
    ''' caso de uso: crear usuario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        showCreateUserForm(-1)
        hideListOfUsers()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 5-11-2015
    ''' caso de uso: listar usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub populateListOfUsers()
        lstUsers.Rows.Clear()
        Dim estado = "Inactivo"
        Dim usuarios As List(Of UserModel) = Users_controller.getUsers()
        If (Not usuarios Is Nothing) Then
            For Each usuario As UserModel In usuarios
                If usuario.activo Then
                    estado = "Activo"
                End If
                lstUsers.Rows.Add(usuario.id_usuario, usuario.cedula, usuario.nombre, usuario.apellido, usuario.telefono,
                                      usuario.correo, estado)
            Next
        End If
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 5-11-2015
    ''' caso de uso: listar usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub lstUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lstUsers.CellContentClick
        Select Case e.ColumnIndex
            Case 7
                Dim id As String = lstUsers.Rows(e.RowIndex).Cells(0).Value
                hideListOfUsers()
                showCreateUserForm(id)
        End Select
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 5-11-2015
    ''' caso de uso: modificar datos de usuario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnSaveUpdateUserInfo_Click(sender As Object, e As EventArgs) Handles btnSaveUpdateUserInfo.Click
        If (validateUpdateUserForm()) Then
            If Not (Users_controller.login(user.correo, txtPasswordUpdateUserInfo.Text)) Is Nothing Then
                If tgChangePassUpdateUserInfo.Checked Then
                    If (Users_controller.updateUserAndPassword(user.id_usuario, txtIdUpdateUserInfo.Text, txtNameUpdateUserInfo.Text, txtLastNameUpdateUserInfo.Text,
                                            txtEmailUpdateUserInfo.Text, txtPhoneUpdateUserInfo.Text, txtNewPassUpdateUserInfo.Text, user.id_rol, user.activo, cboDateUpdateUserInfo.Value)) Then
                        MsgBox(respuestasDelSistema.UPDATE_USER_SUCCESS, MsgBoxStyle.Information)
                        hideUpdateUserInfo()
                    Else
                        MsgBox(respuestasDelSistema.UPDATE__USER_ERROR, MsgBoxStyle.Critical)
                    End If
                Else 'No quiere actualizar la contraseña
                    If (Users_controller.update(user.id_usuario, txtIdUpdateUserInfo.Text, txtNameUpdateUserInfo.Text, txtLastNameUpdateUserInfo.Text,
                                            txtEmailUpdateUserInfo.Text, txtPhoneUpdateUserInfo.Text, user.password, user.id_rol, user.activo, cboDateUpdateUserInfo.Value)) Then
                        MsgBox(respuestasDelSistema.UPDATE_USER_SUCCESS, MsgBoxStyle.Information)
                        hideUpdateUserInfo()
                    Else
                        MsgBox(respuestasDelSistema.UPDATE__USER_ERROR, MsgBoxStyle.Critical)
                    End If
                End If
            Else
                MsgBox(MsgBox(respuestasDelSistema.USER_NOT_EXIST, MsgBoxStyle.Critical))
            End If
        End If
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 5-11-2015
    ''' caso de uso: create usuarios y modificar usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Function validateUpdateUserForm() As Boolean
        Dim result As Boolean = True
        If isAUserId(txtIdUpdateUserInfo.Text) Then
            result = False
            ErrorProvider1.SetError(txtIdUpdateUserInfo, ValidationsMessages.INVALID_USER_ID)
            txtIdUpdateUserInfo.WithError = True
        End If
        If Not OnlyTextAllowSpaces(txtNameUpdateUserInfo.Text) Then
            result = False
            ErrorProvider1.SetError(txtNameUpdateUserInfo, ValidationsMessages.ONLY_TEXT_ALLOW_SPACES)
        End If
        If Not OnlyTextAllowSpaces(txtLastNameUpdateUserInfo.Text) Then
            result = False
            ErrorProvider1.SetError(txtLastNameUpdateUserInfo, ValidationsMessages.ONLY_TEXT_ALLOW_SPACES)
        End If
        If Not IsEmail(txtEmailUpdateUserInfo.Text) Then
            result = False
            ErrorProvider1.SetError(txtEmailUpdateUserInfo, ValidationsMessages.INVALID_EMAIL)
        End If
        If Not isAPhoneNumber(txtPhoneUpdateUserInfo.Text) Then
            result = False
            ErrorProvider1.SetError(txtPhoneUpdateUserInfo, ValidationsMessages.INVALID_PHONE_NUMBER)
        End If
        If Not IsGoodPassword(txtPasswordUpdateUserInfo.Text) Then
            ErrorProvider1.SetError(txtPasswordUpdateUserInfo, ValidationsMessages.PASSWORD_INCORRECT_FORMAT)
            result = False
        End If
        Return result
    End Function


    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 5-11-2015
    ''' caso de uso: create usuarios y modificar usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub tUpdateUserInformation_Click(sender As Object, e As EventArgs) Handles tUpdateUserInformation.Click
        showUpdateUserInfo()
        Dim usuario As UserModel = Users_controller.getUser(user.id_usuario)
        If (Not usuario Is Nothing) Then
            txtIdUpdateUserInfo.Text = usuario.cedula
            txtNameUpdateUserInfo.Text = usuario.nombre
            txtLastNameUpdateUserInfo.Text = usuario.apellido
            txtEmailUpdateUserInfo.Text = usuario.correo
            txtPhoneUpdateUserInfo.Text = usuario.telefono
        Else
            MsgBox(respuestasDelSistema.POPULATE_FILLS_ERROR, MsgBoxStyle.Critical)
        End If
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 5-11-2015
    ''' caso de uso: create usuarios y modificar usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnCancelUpdateUserInfo_Click(sender As Object, e As EventArgs) Handles btnCancelUpdateUserInfo.Click
        hideUpdateUserInfo()
    End Sub


    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 5-11-2015
    ''' caso de uso: create usuarios y modificar usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub tgChangePassUpdateUserInfo_Click(sender As Object, e As EventArgs) Handles tgChangePassUpdateUserInfo.Click
        txtNewPassUpdateUserInfo.Enabled = tgChangePassUpdateUserInfo.Checked
        lblNewpassUpdateUserInfo.Enabled = tgChangePassUpdateUserInfo.Checked
        txtNewPassUpdateUserInfo.Text = ""
    End Sub

    Private Sub tabsContainer_Click(sender As Object, e As EventArgs) Handles tabsContainer.Click
        showListOfUsers()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 5-11-2015
    ''' caso de uso: cerrar sesion
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub tSignOutUser_Click(sender As Object, e As EventArgs) Handles tSignOutUser.Click
        Dim login As New FrmLogin()
        Me.Hide()
        login.ShowDialog()
        Me.Close()
    End Sub


    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 7-11-2015
    ''' caso de uso: crear rol
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
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 7-11-2015
    ''' caso de uso: create usuarios y modificar usuarios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showListOfRols()
        pnlListRols.Show()
        populateListOfRols()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 7-11-2015
    ''' caso de uso: listar roles
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hideListOfRols()
        pnlListRols.Hide()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 7-11-2015
    ''' caso de uso: crear rol y modificar rol
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub showCreateRolForm(ByVal id As String)
        lblIdRol.Text = id
        pnlCreateRol.Show()
        cleanCreateRolForm()
        If id = "-1" Then
            lblRolUserTittle.Text = "Crear rol"
        Else
            lblRolUserTittle.Text = "Modificar rol"
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
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 7-11-2015
    ''' caso de uso: crear rol y modificar rol
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub hideCreateRolForm()
        pnlCreateRol.Hide()
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 7-11-2015
    ''' caso de uso: listar roles
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub populateListOfRols()
        lstRols.Rows.Clear()
        Dim estado = "Inactivo"
        Dim rols As List(Of RolModel) = RolsController.obtener()
        If (Not rols Is Nothing) Then
            For Each rol As RolModel In rols
                If rol.activo Then
                    estado = "Activo"
                End If
                lstRols.Rows.Add(rol.id_rol, rol.nombre, estado)
            Next
        End If
    End Sub

    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 7-11-2015
    ''' caso de uso: crear rol y modificar rol
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
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 7-11-2015
    ''' caso de uso: modificar rol
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub lstRols_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lstRols.CellContentClick
        Dim id As String = lstRols.Rows(e.RowIndex).Cells(0).Value
        Select Case e.ColumnIndex
            Case 3
                hideListOfRols()
                showCreateRolForm(id)
        End Select
    End Sub

    '////////////////////PROSPECTOS////////////////////////
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
            Me.limpiarForm()
            PnlListaProspectos.Visible = True
            PnlNuevoProspecto.Visible = False
            lblIdProspecto.Text = -1
        End If
    End Sub

    Private Sub btnCrearProspecto_Click(sender As Object, e As EventArgs) Handles btnCrearProspecto.Click
        btnNuevoSeguimiento.Visible = False
        btnListarSeguimientos.Visible = False
        PnlListaProspectos.Visible = False
        PnlNuevoProspecto.Visible = True
    End Sub

    Private Sub btnCancelarProspecto_Click(sender As Object, e As EventArgs) Handles btnCancelarProspecto.Click
        Me.limpiarForm()
        PnlListaProspectos.Visible = True
        PnlNuevoProspecto.Visible = False
    End Sub

    Private Sub llenarListaProspectos()
        Dim prospectos = ProspectusController.listar()
        If (Not prospectos.Equals(Nothing)) Then
            For Each prosp As Prospecto In prospectos
                lstProspectos.Rows.Add(prosp.Id_prospecto, prosp.Nombre, prosp.Apellidos, Format(prosp.Fecha_nacimiento, "dd-MM-yyyy"),
                                       prosp.Procedencia, prosp.Telefono, prosp.Email)
            Next
        End If
    End Sub

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

    Private Sub limpiarForm()
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

    Private Sub limpiarFormSeguimiento()
        txtComentarioSeguimiento.Clear()
        txtFechaSeguimiento.Value = Date.Now
    End Sub

    Private Sub btnNuevoSeguimiento_Click(sender As Object, e As EventArgs) Handles btnNuevoSeguimiento.Click
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
        If (Not eventos.Equals(Nothing)) Then
            For Each evento As Evento In eventos
                comboData.Add(evento.Id_evento, evento.Lugar)
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

    Private Sub lblRols_Click(sender As Object, e As EventArgs) Handles lblRols.Click
        hideListOfUsers()
        showListOfRols()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btnBackRolsUsers.Click
        hideListOfRols()
        showListOfUsers()
    End Sub


    Private Sub btnNewRol_Click(sender As Object, e As EventArgs) Handles btnNewRol.Click
        showCreateRolForm("-1")
        hideListOfRols()
    End Sub
    '/////////////PRODUCTOS/////////////////////////////////////////////
    Private Sub listaCarreras_dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles tCareers.Click
        listaCarreras_pnl.Visible = True
        llenarTablaCarreras()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs)
        listaCursos_pnl.Visible = True
    End Sub

    Private Sub listaCarrerasVolver_btn_Click(sender As Object, e As EventArgs) Handles listaCarrerasVolver_btn.Click
        listaCarreras_pnl.Visible = False
    End Sub

    Private Sub nuevaCarrera_btn_Click(sender As Object, e As EventArgs) Handles nuevaCarrera_btn.Click
        registrarCarrera_pnl.visible = True
    End Sub

    Private Sub LlenarComboDias()

        Dim dias() As String = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes"}

        dia1_cmb.MaxDropDownItems = dias.Length
        dia2_cmb.MaxDropDownItems = dias.Length
        dia3_cmb.MaxDropDownItems = dias.Length
        dia4_cmb.MaxDropDownItems = dias.Length
        dia5_cmb.MaxDropDownItems = dias.Length
        dia1Acti_cmb.MaxDropDownItems = dias.Length
        dia2Acti_cmb.MaxDropDownItems = dias.Length
        dia3Acti_cmb.MaxDropDownItems = dias.Length
        dia4Acti_cmb.MaxDropDownItems = dias.Length
        dia5Acti_cmb.MaxDropDownItems = dias.Length

        For i = 0 To (dias.Length - 1)
            dia1_cmb.Items.Add(dias(i))
            dia2_cmb.Items.Add(dias(i))
            dia3_cmb.Items.Add(dias(i))
            dia4_cmb.Items.Add(dias(i))
            dia5_cmb.Items.Add(dias(i))
            dia1Acti_cmb.Items.Add(dias(i))
            dia2Acti_cmb.Items.Add(dias(i))
            dia3Acti_cmb.Items.Add(dias(i))
            dia4Acti_cmb.Items.Add(dias(i))
            dia5Acti_cmb.Items.Add(dias(i))

        Next
    End Sub
    Private Function crearHorariosCarrera() As String

        Dim horario1 As String = ""
        Dim horario2 As String = ""
        Dim horario3 As String = ""
        Dim horario4 As String = ""
        Dim horario5 As String = ""

        If horaIni1_nmbr.Value <> 0 Then
            Dim horaIni = horaIni1_nmbr.Value.ToString("00")
            Dim minIni = minsIni1_nmbr.Value.ToString("00")
            Dim horaFin = horaFin1_nmbr.Value.ToString("00")
            Dim minFin = minsFin1_nmbr.Value.ToString("00")
            horario1 = dia1_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin
        End If

        If horaIni2_nmbr.Value <> 0 Then
            Dim horaIni = horaIni2_nmbr.Value.ToString("00")
            Dim minIni = minsIni2_nmbr.Value.ToString("00")
            Dim horaFin = horaFin2_nmbr.Value.ToString("00")
            Dim minFin = minsFin2_nmbr.Value.ToString("00")
            horario2 = dia2_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin
        End If

        If horaIni3_nmbr.Value <> 0 Then
            Dim horaIni = horaIni3_nmbr.Value.ToString("00")
            Dim minIni = minsIni3_nmbr.Value.ToString("00")
            Dim horaFin = horaFin3_nmbr.Value.ToString("00")
            Dim minFin = minsFin3_nmbr.Value.ToString("00")
            horario3 = dia3_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin
        End If

        If horaIni4_nmbr.Value <> 0 Then
            Dim horaIni = horaIni4_nmbr.Value.ToString("00")
            Dim minIni = minsIni4_nmbr.Value.ToString("00")
            Dim horaFin = horaFin4_nmbr.Value.ToString("00")
            Dim minFin = minsFin4_nmbr.Value.ToString("00")
            horario4 = dia4_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin
        End If

        If horaIni5_nmbr.Value <> 0 Then
            Dim horaIni = horaIni5_nmbr.Value.ToString("00")
            Dim minIni = minsIni5_nmbr.Value.ToString("00")
            Dim horaFin = horaFin5_nmbr.Value.ToString("00")
            Dim minFin = minsFin5_nmbr.Value.ToString("00")
            horario5 = dia5_cmb.Text & " de " & horaIni & ":" & minIni & " a " & horaFin & ":" & minFin

        End If

        Dim resul As String = Trim(horario1 & vbNewLine & horario2 & vbNewLine & horario3 & vbNewLine & horario4 & vbNewLine & horario5)
        Return resul
    End Function

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
    Private Sub guardarCarrera_btn_Click(sender As Object, e As EventArgs) Handles guardarCarrera_btn.Click
        Dim horarios = crearHorariosCarrera()
        Dim id_tipo = (DirectCast(tipoCarrera_cmb.SelectedItem, KeyValuePair(Of String, String)).Key)

        Dim IsCorrect = ProductsController.RegistrarProducto(nombreCarrera_text.Text, costoCarrera_text.Text, codigoCarrera_text.Text, horarios, id_tipo)

        If IsCorrect Then
            MsgBox("Todo Tuanis")
            limpiarFormCarrera()
        Else
            MsgBox("Ha ocurrido un error.")
        End If

    End Sub

    Private Sub cancelarCarrera_btn_Click(sender As Object, e As EventArgs) Handles cancelarCarrera_btn.Click
        limpiarFormCarrera()
    End Sub

    Private Sub limpiarFormCarrera()

        nombreCarrera_text.Text = ""
        costoCarrera_text.Text = ""
        codigoCarrera_text.Text = ""
        dia1_cmb.Text = ""
        dia2_cmb.Text = ""
        dia3_cmb.Text = ""
        dia4_cmb.Text = ""
        dia5_cmb.Text = ""
        horaFin1_nmbr.Value = 0
        horaFin2_nmbr.Value = 0
        horaFin3_nmbr.Value = 0
        horaFin4_nmbr.Value = 0
        horaIni1_nmbr.Value = 0
        horaIni2_nmbr.Value = 0
        horaIni3_nmbr.Value = 0
        horaIni4_nmbr.Value = 0
        minsFin1_nmbr.Value = 0
        minsFin2_nmbr.Value = 0
        minsFin3_nmbr.Value = 0
        minsFin4_nmbr.Value = 0
        minsFin5_nmbr.Value = 0
        minsIni1_nmbr.Value = 0
        minsIni2_nmbr.Value = 0
        minsIni3_nmbr.Value = 0
        minsIni4_nmbr.Value = 0
        minsIni5_nmbr.Value = 0
        registrarCarrera_pnl.Visible = False
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

    Private Sub llenarComboTiposCarrera()

        'Dim tipos As List(Of Tipo_Producto) = ProductTypeController.obtenerLista
        Dim comboSource As New Dictionary(Of String, String)()
        'For Each tipo As Tipo_Producto In tipos
        comboSource.Add(2, "Carrera")
        'Next
        tipoCarrera_cmb.DataSource = New BindingSource(comboSource, Nothing)
        tipoCarrera_cmb.DisplayMember = "Value"
        tipoCarrera_cmb.ValueMember = "Key"
    End Sub
    Private Sub llenarComboTiposActi()
        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add(1, "Acti")
        tipoActi_cmb.DataSource = New BindingSource(comboSource, Nothing)
        tipoActi_cmb.DisplayMember = "Value"
        tipoActi_cmb.ValueMember = "Key"
    End Sub

    Private Sub MetroTile2_Click_1(sender As Object, e As EventArgs) Handles tActis.Click
        listaActis_pnl.Visible = True
        llenarTablaActis()
    End Sub

    Private Sub nuevoActi_btn_Click(sender As Object, e As EventArgs) Handles nuevoActi_btn.Click
        registrarActi_pnl.Visible = True
    End Sub

    Private Sub vovlerActi_btn_Click(sender As Object, e As EventArgs) Handles vovlerActi_btn.Click
        listaActis_pnl.Visible = False
    End Sub

    Private Sub cancelarActi_btn_Click(sender As Object, e As EventArgs) Handles cancelarActi_btn.Click
        limpiarFormActi()
    End Sub

    Private Sub guardarActi_btn_Click(sender As Object, e As EventArgs) Handles guardarActi_btn.Click
        Dim horarios = crearHorariosActi()
        Dim id_tipo = (DirectCast(tipoActi_cmb.SelectedItem, KeyValuePair(Of String, String)).Key)
        Dim IsCorrect = ProductsController.RegistrarProducto(nombreActi_text.Text, costoActi_text.Text, codigoActi_text.Text, horarios, id_tipo)

        If IsCorrect Then
            MsgBox("Todo Tuanis")
            limpiarFormActi()
        Else
            MsgBox("Ha ocurrido un error.")
        End If
    End Sub

    Private Sub llenarTablaCarreras()
        listaCarreras_dg.Rows.Clear()
        Dim carreras As List(Of Producto) = ProductsController.obtenerListaProductos()
        If (Not carreras Is Nothing) Then
            For Each carrera As Producto In carreras
                If (carrera.Id_Tipo_Product = 2) Then
                    listaCarreras_dg.Rows.Add(carrera.Id_producto, carrera.Nombre, carrera.Codigo_Producto, carrera.Costo, carrera.Horario)
                End If
            Next
        End If
    End Sub

    Private Sub llenarTablaActis()
        listaActis_dg.Rows.Clear()
        Dim actis As List(Of Producto) = ProductsController.obtenerListaProductos()
        If (Not actis Is Nothing) Then
            For Each acti As Producto In actis
                If (acti.Id_Tipo_Product = 1) Then
                    listaActis_dg.Rows.Add(acti.Id_producto, acti.Nombre, acti.Codigo_Producto, acti.Costo, acti.Horario)
                End If
            Next
        End If
    End Sub

    Private Sub nuevaVenta_btn_Click(sender As Object, e As EventArgs) Handles nuevaVenta_btn.Click
        RegistrarVentas_pnl.Visible = True
    End Sub

    Private Sub volverVenta_btn_Click(sender As Object, e As EventArgs) Handles volverVenta_btn.Click
        listarVerntas_pnl.Visible = False
    End Sub

    Private Sub llenarTablaVentas()
        'listaVentas_dg.Rows.Clear()
        'Dim venta As List(Of Sale) = SalesController.RegistrarVenta(Today(), )
        'If (Not actis Is Nothing) Then
        '    For Each acti As Producto In actis
        '        If (acti.Id_Tipo_Product = 5) Then
        '            listaActis_dg.Rows.Add(acti.Id_producto, acti.Nombre, acti.Codigo_Producto, acti.Costo, acti.Horario)
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub cancelarVenta_btn_Click(sender As Object, e As EventArgs) Handles cancelarVenta_btn.Click
        RegistrarVentas_pnl.Visible = False
    End Sub

    Private Sub guardarVenta_btn_Click(sender As Object, e As EventArgs) Handles guardarVenta_btn.Click
        Dim totalPagar As Double
        Dim fecha As Date
        Dim id_usuario As Integer
        Dim tipo As String

        id_usuario = 1
        tipo = tipo_prodVenta_cmb.SelectedText
        fecha = Today
        totalPagar = calcularTotal()
        SalesController.RegistrarVenta(fecha, totalPagar, id_usuario, tipo)
    End Sub

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
            productos_cmb.SelectedIndex = producto.Id_Tipo_Product
            cod_prod_cmb.SelectedIndex = productos_cmb.SelectedIndex

        End If
    End Sub

    Private Sub llenarComboTipoVenta()

        'Dim tipos As List(Of Tipo_Producto) = ProductTypeController.obtenerLista
        'Dim comboSource As New Dictionary(Of String, String)()
        'comboSource.Add("", "")
        'For Each tipo As Tipo_Producto In tipos
        '    comboSource.Add(tipo.Id_Tipo_Producto.ToString, tipo.Nombre)
        'Next
        'tipo_prodVenta_cmb.DataSource = New BindingSource(comboSource, Nothing)
        'tipo_prodVenta_cmb.DisplayMember = "Value"
        'tipo_prodVenta_cmb.ValueMember = "Key"
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



    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 7-11-2015
    ''' caso de uso: crear rol y modificar
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub btnCancelRol_Click(sender As Object, e As EventArgs) Handles btnCancelRol.Click
        hideCreateRolForm()
        showListOfRols()
    End Sub


    ''' <summary>
    ''' autor: Alejandro Bermudez Vargas
    ''' fecha: 7-11-2015
    ''' caso de uso: cambiar datos de usuario
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub chkChangeUserPassword_Click(sender As Object, e As EventArgs) Handles chkChangeUserPassword.Click
        txtPasswordCreateUser.Enabled = chkChangeUserPassword.Checked
        txtPasswordCreateUser.Text = lblPasswordUserBackup.Text
    End Sub
End Class