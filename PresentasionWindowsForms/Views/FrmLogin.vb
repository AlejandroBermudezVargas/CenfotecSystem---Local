Imports PresentasionWindowsForms.My.Resources
Public Class FrmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSignInLogin_Click(sender As Object, e As EventArgs) Handles btnSignInLogin.Click
        Dim user As UserModel = Users_controller.login(txtEmailLogin.Text, txtPasswordLogin.Text)
        If (Not user Is Nothing) Then
            Dim main As New FrmMain(user)
            If (user.rol.activo) Then
                If user.activo Then
                    For Each permiso As PermissionModel In user.rol.permisos
                        Select Case permiso.nombre
                            Case "acti"
                                main.tActis.Visible = True
                            Case "carreras"
                                main.tCareers.Visible = True
                            Case "ventas"
                                main.tabsContainer.TabPages.Add(main.tabSales)
                            Case "prospectos"
                                main.tabsContainer.TabPages.Add(main.tabProspectus)
                            Case "usuarios"
                                main.tabsContainer.TabPages.Add(main.tabUsers)
                            Case "eventos"
                                main.tabsContainer.TabPages.Add(main.tabEvents)
                            Case "kpis"
                                main.tabsContainer.TabPages.Add(main.tabKpi)
                            Case "reportes"
                                main.tabsContainer.TabPages.Add(main.tabReports)
                            Case "configuracion"
                                main.tabsContainer.TabPages.Add(main.tabConfiguration)
                        End Select
                        If ((main.tActis.Visible) Or (main.tCareers.Visible)) Then
                            main.tabsContainer.TabPages.Add(main.tabProducts)
                        End If
                    Next
                    Me.Hide()
                    main.ShowDialog()
                    Me.Close()
                Else
                    ErrorProvider1.SetError(txtEmailLogin, respuestasDelSistema.INACTIVE_USER)
                End If
            Else
                ErrorProvider1.SetError(txtEmailLogin, respuestasDelSistema.INACTIVE_ROL)
            End If
        Else
            ErrorProvider1.SetError(txtEmailLogin, respuestasDelSistema.USER_NOT_EXIST)
        End If

    End Sub
End Class