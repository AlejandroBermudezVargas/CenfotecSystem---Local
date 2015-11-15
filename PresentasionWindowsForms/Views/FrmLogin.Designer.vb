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
        Me.lblOlvidoContrasenna = New MetroFramework.Controls.MetroLink()
        Me.btnIniciarSesion = New MetroFramework.Controls.MetroButton()
        Me.txtContrasenna = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtUsuario = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.HtmlLabel2 = New MetroFramework.Drawing.Html.HtmlLabel()
        Me.SuspendLayout()
        '
        'lblOlvidoContrasenna
        '
        Me.lblOlvidoContrasenna.ForeColor = System.Drawing.Color.Black
        Me.lblOlvidoContrasenna.Location = New System.Drawing.Point(35, 407)
        Me.lblOlvidoContrasenna.Name = "lblOlvidoContrasenna"
        Me.lblOlvidoContrasenna.Size = New System.Drawing.Size(157, 23)
        Me.lblOlvidoContrasenna.Style = MetroFramework.MetroColorStyle.Purple
        Me.lblOlvidoContrasenna.TabIndex = 14
        Me.lblOlvidoContrasenna.Text = "¿Olvidaste tu contraseña?"
        Me.lblOlvidoContrasenna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOlvidoContrasenna.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblOlvidoContrasenna.UseSelectable = True
        Me.lblOlvidoContrasenna.Visible = False
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.Location = New System.Drawing.Point(250, 335)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(133, 30)
        Me.btnIniciarSesion.Style = MetroFramework.MetroColorStyle.Lime
        Me.btnIniciarSesion.TabIndex = 13
        Me.btnIniciarSesion.Text = "Iniciar sesion"
        Me.btnIniciarSesion.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnIniciarSesion.UseSelectable = True
        '
        'txtContrasenna
        '
        '
        '
        '
        Me.txtContrasenna.CustomButton.Image = Nothing
        Me.txtContrasenna.CustomButton.Location = New System.Drawing.Point(244, 1)
        Me.txtContrasenna.CustomButton.Name = ""
        Me.txtContrasenna.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtContrasenna.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtContrasenna.CustomButton.TabIndex = 1
        Me.txtContrasenna.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContrasenna.CustomButton.UseSelectable = True
        Me.txtContrasenna.CustomButton.Visible = False
        Me.txtContrasenna.Lines = New String(-1) {}
        Me.txtContrasenna.Location = New System.Drawing.Point(117, 292)
        Me.txtContrasenna.Margin = New System.Windows.Forms.Padding(4, 10, 3, 3)
        Me.txtContrasenna.MaxLength = 32767
        Me.txtContrasenna.Name = "txtContrasenna"
        Me.txtContrasenna.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContrasenna.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContrasenna.SelectedText = ""
        Me.txtContrasenna.SelectionLength = 0
        Me.txtContrasenna.SelectionStart = 0
        Me.txtContrasenna.Size = New System.Drawing.Size(266, 23)
        Me.txtContrasenna.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtContrasenna.TabIndex = 12
        Me.txtContrasenna.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContrasenna.UseSelectable = True
        Me.txtContrasenna.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtContrasenna.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(35, 245)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel2.TabIndex = 11
        Me.MetroLabel2.Text = "Usuario"
        '
        'txtUsuario
        '
        '
        '
        '
        Me.txtUsuario.CustomButton.Image = Nothing
        Me.txtUsuario.CustomButton.Location = New System.Drawing.Point(244, 1)
        Me.txtUsuario.CustomButton.Name = ""
        Me.txtUsuario.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsuario.CustomButton.TabIndex = 1
        Me.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsuario.CustomButton.UseSelectable = True
        Me.txtUsuario.CustomButton.Visible = False
        Me.txtUsuario.Lines = New String(-1) {}
        Me.txtUsuario.Location = New System.Drawing.Point(117, 245)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 10, 3, 3)
        Me.txtUsuario.MaxLength = 32767
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.SelectionLength = 0
        Me.txtUsuario.SelectionStart = 0
        Me.txtUsuario.Size = New System.Drawing.Size(266, 23)
        Me.txtUsuario.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtUsuario.TabIndex = 10
        Me.txtUsuario.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsuario.UseSelectable = True
        Me.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(35, 292)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Contraseña"
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
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 493)
        Me.Controls.Add(Me.lblOlvidoContrasenna)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.Controls.Add(Me.txtContrasenna)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.HtmlLabel2)
        Me.Name = "FrmLogin"
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Inicio de sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOlvidoContrasenna As MetroFramework.Controls.MetroLink
    Friend WithEvents btnIniciarSesion As MetroFramework.Controls.MetroButton
    Friend WithEvents txtContrasenna As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtUsuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents HtmlLabel2 As MetroFramework.Drawing.Html.HtmlLabel
End Class
