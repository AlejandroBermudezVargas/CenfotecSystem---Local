<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.lblForgotPasswordLogin = New MetroFramework.Controls.MetroLink()
        Me.btnSignInLogin = New MetroFramework.Controls.MetroButton()
        Me.txtPasswordLogin = New MetroFramework.Controls.MetroTextBox()
        Me.lblEmailLogin = New MetroFramework.Controls.MetroLabel()
        Me.txtEmailLogin = New MetroFramework.Controls.MetroTextBox()
        Me.lblPasswordLogin = New MetroFramework.Controls.MetroLabel()
        Me.HtmlLabel2 = New MetroFramework.Drawing.Html.HtmlLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblForgotPasswordLogin
        '
        Me.lblForgotPasswordLogin.ForeColor = System.Drawing.Color.Black
        Me.lblForgotPasswordLogin.Location = New System.Drawing.Point(35, 407)
        Me.lblForgotPasswordLogin.Name = "lblForgotPasswordLogin"
        Me.lblForgotPasswordLogin.Size = New System.Drawing.Size(157, 23)
        Me.lblForgotPasswordLogin.Style = MetroFramework.MetroColorStyle.Purple
        Me.lblForgotPasswordLogin.TabIndex = 14
        Me.lblForgotPasswordLogin.Text = "¿Olvidaste tu contraseña?"
        Me.lblForgotPasswordLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblForgotPasswordLogin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblForgotPasswordLogin.UseSelectable = True
        '
        'btnSignInLogin
        '
        Me.btnSignInLogin.Location = New System.Drawing.Point(250, 335)
        Me.btnSignInLogin.Name = "btnSignInLogin"
        Me.btnSignInLogin.Size = New System.Drawing.Size(133, 30)
        Me.btnSignInLogin.Style = MetroFramework.MetroColorStyle.Lime
        Me.btnSignInLogin.TabIndex = 13
        Me.btnSignInLogin.Text = "Iniciar sesion"
        Me.btnSignInLogin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSignInLogin.UseSelectable = True
        '
        'txtPasswordLogin
        '
        '
        '
        '
        Me.txtPasswordLogin.CustomButton.Image = Nothing
        Me.txtPasswordLogin.CustomButton.Location = New System.Drawing.Point(244, 1)
        Me.txtPasswordLogin.CustomButton.Name = ""
        Me.txtPasswordLogin.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPasswordLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPasswordLogin.CustomButton.TabIndex = 1
        Me.txtPasswordLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPasswordLogin.CustomButton.UseSelectable = True
        Me.txtPasswordLogin.CustomButton.Visible = False
        Me.txtPasswordLogin.Lines = New String() {"Admin1379"}
        Me.txtPasswordLogin.Location = New System.Drawing.Point(117, 292)
        Me.txtPasswordLogin.Margin = New System.Windows.Forms.Padding(4, 10, 3, 3)
        Me.txtPasswordLogin.MaxLength = 50
        Me.txtPasswordLogin.Name = "txtPasswordLogin"
        Me.txtPasswordLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPasswordLogin.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPasswordLogin.SelectedText = ""
        Me.txtPasswordLogin.SelectionLength = 0
        Me.txtPasswordLogin.SelectionStart = 0
        Me.txtPasswordLogin.Size = New System.Drawing.Size(266, 23)
        Me.txtPasswordLogin.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtPasswordLogin.TabIndex = 12
        Me.txtPasswordLogin.Text = "Admin1379"
        Me.txtPasswordLogin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPasswordLogin.UseSelectable = True
        Me.txtPasswordLogin.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPasswordLogin.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblEmailLogin
        '
        Me.lblEmailLogin.AutoSize = True
        Me.lblEmailLogin.Location = New System.Drawing.Point(35, 245)
        Me.lblEmailLogin.Name = "lblEmailLogin"
        Me.lblEmailLogin.Size = New System.Drawing.Size(53, 19)
        Me.lblEmailLogin.TabIndex = 11
        Me.lblEmailLogin.Text = "Usuario"
        '
        'txtEmailLogin
        '
        '
        '
        '
        Me.txtEmailLogin.CustomButton.Image = Nothing
        Me.txtEmailLogin.CustomButton.Location = New System.Drawing.Point(244, 1)
        Me.txtEmailLogin.CustomButton.Name = ""
        Me.txtEmailLogin.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmailLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmailLogin.CustomButton.TabIndex = 1
        Me.txtEmailLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmailLogin.CustomButton.UseSelectable = True
        Me.txtEmailLogin.CustomButton.Visible = False
        Me.txtEmailLogin.Lines = New String() {"admin@ucenfotec.ac.cr"}
        Me.txtEmailLogin.Location = New System.Drawing.Point(117, 245)
        Me.txtEmailLogin.Margin = New System.Windows.Forms.Padding(4, 10, 3, 3)
        Me.txtEmailLogin.MaxLength = 50
        Me.txtEmailLogin.Name = "txtEmailLogin"
        Me.txtEmailLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailLogin.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmailLogin.SelectedText = ""
        Me.txtEmailLogin.SelectionLength = 0
        Me.txtEmailLogin.SelectionStart = 0
        Me.txtEmailLogin.Size = New System.Drawing.Size(266, 23)
        Me.txtEmailLogin.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtEmailLogin.TabIndex = 10
        Me.txtEmailLogin.Text = "admin@ucenfotec.ac.cr"
        Me.txtEmailLogin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmailLogin.UseSelectable = True
        Me.txtEmailLogin.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmailLogin.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblPasswordLogin
        '
        Me.lblPasswordLogin.AutoSize = True
        Me.lblPasswordLogin.Location = New System.Drawing.Point(35, 292)
        Me.lblPasswordLogin.Name = "lblPasswordLogin"
        Me.lblPasswordLogin.Size = New System.Drawing.Size(75, 19)
        Me.lblPasswordLogin.TabIndex = 9
        Me.lblPasswordLogin.Text = "Contraseña"
        '
        'HtmlLabel2
        '
        Me.HtmlLabel2.AutoScroll = True
        Me.HtmlLabel2.AutoScrollMinSize = New System.Drawing.Size(10, 0)
        Me.HtmlLabel2.AutoSize = False
        Me.HtmlLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.HtmlLabel2.BackgroundImage = Global.PresentasionWindowsForms.My.Resources.Resources.logoU
        Me.HtmlLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HtmlLabel2.Location = New System.Drawing.Point(108, 84)
        Me.HtmlLabel2.Name = "HtmlLabel2"
        Me.HtmlLabel2.Size = New System.Drawing.Size(210, 105)
        Me.HtmlLabel2.TabIndex = 8
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 493)
        Me.Controls.Add(Me.lblForgotPasswordLogin)
        Me.Controls.Add(Me.btnSignInLogin)
        Me.Controls.Add(Me.txtPasswordLogin)
        Me.Controls.Add(Me.lblEmailLogin)
        Me.Controls.Add(Me.txtEmailLogin)
        Me.Controls.Add(Me.lblPasswordLogin)
        Me.Controls.Add(Me.HtmlLabel2)
        Me.MaximumSize = New System.Drawing.Size(432, 493)
        Me.MinimumSize = New System.Drawing.Size(432, 493)
        Me.Name = "FrmLogin"
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Inicio de sesión"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblForgotPasswordLogin As MetroFramework.Controls.MetroLink
    Friend WithEvents btnSignInLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents txtPasswordLogin As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblEmailLogin As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmailLogin As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPasswordLogin As MetroFramework.Controls.MetroLabel
    Friend WithEvents HtmlLabel2 As MetroFramework.Drawing.Html.HtmlLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
