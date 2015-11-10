<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pnListUsers = New MetroFramework.Controls.MetroPanel()
        Me.lblRoles = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.btnCreateUser = New MetroFramework.Controls.MetroButton()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lstProspectos = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdentificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnListUsers.SuspendLayout()
        CType(Me.lstProspectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnListUsers
        '
        Me.pnListUsers.Controls.Add(Me.lstProspectos)
        Me.pnListUsers.Controls.Add(Me.lblRoles)
        Me.pnListUsers.Controls.Add(Me.MetroLabel14)
        Me.pnListUsers.Controls.Add(Me.btnCreateUser)
        Me.pnListUsers.HorizontalScrollbarBarColor = True
        Me.pnListUsers.HorizontalScrollbarHighlightOnWheel = False
        Me.pnListUsers.HorizontalScrollbarSize = 10
        Me.pnListUsers.Location = New System.Drawing.Point(102, 68)
        Me.pnListUsers.Name = "pnListUsers"
        Me.pnListUsers.Size = New System.Drawing.Size(746, 462)
        Me.pnListUsers.Style = MetroFramework.MetroColorStyle.Blue
        Me.pnListUsers.TabIndex = 35
        Me.pnListUsers.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pnListUsers.VerticalScrollbarBarColor = True
        Me.pnListUsers.VerticalScrollbarHighlightOnWheel = False
        Me.pnListUsers.VerticalScrollbarSize = 10
        '
        'lblRoles
        '
        Me.lblRoles.BackColor = System.Drawing.Color.Ivory
        Me.lblRoles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRoles.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.lblRoles.Location = New System.Drawing.Point(0, 425)
        Me.lblRoles.Name = "lblRoles"
        Me.lblRoles.Size = New System.Drawing.Size(216, 23)
        Me.lblRoles.Style = MetroFramework.MetroColorStyle.Purple
        Me.lblRoles.TabIndex = 11
        Me.lblRoles.Text = "Administrar roles de usuario"
        Me.lblRoles.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblRoles.UseSelectable = True
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.PresentasionWindowsForms.My.Resources.Resources.pen29
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'lstProspectos
        '
        Me.lstProspectos.AllowUserToAddRows = False
        Me.lstProspectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lstProspectos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.colIdentificacion, Me.Column1, Me.Column2, Me.Column5, Me.Column6, Me.colRol, Me.colState, Me.Column7, Me.Column9})
        Me.lstProspectos.Location = New System.Drawing.Point(7, 37)
        Me.lstProspectos.Name = "lstProspectos"
        Me.lstProspectos.RowHeadersVisible = False
        Me.lstProspectos.Size = New System.Drawing.Size(739, 344)
        Me.lstProspectos.TabIndex = 12
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "ID"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
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
        'colRol
        '
        Me.colRol.HeaderText = "Tipo"
        Me.colRol.Name = "colRol"
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
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = ""
        Me.Column9.Image = Global.PresentasionWindowsForms.My.Resources.Resources.delete81
        Me.Column9.Name = "Column9"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 598)
        Me.Controls.Add(Me.pnListUsers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnListUsers.ResumeLayout(False)
        Me.pnListUsers.PerformLayout()
        CType(Me.lstProspectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnListUsers As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblRoles As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCreateUser As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lstProspectos As System.Windows.Forms.DataGridView
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdentificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewImageColumn
End Class
