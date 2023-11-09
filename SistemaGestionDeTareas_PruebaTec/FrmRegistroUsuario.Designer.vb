<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroUsuario
    Inherits System.Windows.Forms.Form

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
        Me.lblNameRegister = New System.Windows.Forms.Label()
        Me.lblLastNameRegister = New System.Windows.Forms.Label()
        Me.lblUserNameRegister = New System.Windows.Forms.Label()
        Me.lblPasswordRegister = New System.Windows.Forms.Label()
        Me.txtNameUser = New System.Windows.Forms.TextBox()
        Me.txtLastNameUser = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassUser = New System.Windows.Forms.TextBox()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNameRegister
        '
        Me.lblNameRegister.AutoSize = True
        Me.lblNameRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblNameRegister.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNameRegister.Location = New System.Drawing.Point(69, 70)
        Me.lblNameRegister.Name = "lblNameRegister"
        Me.lblNameRegister.Size = New System.Drawing.Size(71, 17)
        Me.lblNameRegister.TabIndex = 0
        Me.lblNameRegister.Text = "Nombre:"
        '
        'lblLastNameRegister
        '
        Me.lblLastNameRegister.AutoSize = True
        Me.lblLastNameRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblLastNameRegister.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastNameRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLastNameRegister.Location = New System.Drawing.Point(69, 127)
        Me.lblLastNameRegister.Name = "lblLastNameRegister"
        Me.lblLastNameRegister.Size = New System.Drawing.Size(72, 17)
        Me.lblLastNameRegister.TabIndex = 1
        Me.lblLastNameRegister.Text = "Apellido:"
        '
        'lblUserNameRegister
        '
        Me.lblUserNameRegister.AutoSize = True
        Me.lblUserNameRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblUserNameRegister.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserNameRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUserNameRegister.Location = New System.Drawing.Point(69, 179)
        Me.lblUserNameRegister.Name = "lblUserNameRegister"
        Me.lblUserNameRegister.Size = New System.Drawing.Size(70, 17)
        Me.lblUserNameRegister.TabIndex = 2
        Me.lblUserNameRegister.Text = "Usuario:"
        '
        'lblPasswordRegister
        '
        Me.lblPasswordRegister.AutoSize = True
        Me.lblPasswordRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordRegister.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPasswordRegister.Location = New System.Drawing.Point(69, 239)
        Me.lblPasswordRegister.Name = "lblPasswordRegister"
        Me.lblPasswordRegister.Size = New System.Drawing.Size(98, 17)
        Me.lblPasswordRegister.TabIndex = 3
        Me.lblPasswordRegister.Text = "Contraseña:"
        '
        'txtNameUser
        '
        Me.txtNameUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameUser.Location = New System.Drawing.Point(186, 70)
        Me.txtNameUser.Name = "txtNameUser"
        Me.txtNameUser.Size = New System.Drawing.Size(161, 25)
        Me.txtNameUser.TabIndex = 4
        '
        'txtLastNameUser
        '
        Me.txtLastNameUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastNameUser.Location = New System.Drawing.Point(186, 123)
        Me.txtLastNameUser.Name = "txtLastNameUser"
        Me.txtLastNameUser.Size = New System.Drawing.Size(161, 25)
        Me.txtLastNameUser.TabIndex = 5
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(186, 175)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(161, 25)
        Me.txtUser.TabIndex = 6
        '
        'txtPassUser
        '
        Me.txtPassUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassUser.Location = New System.Drawing.Point(186, 235)
        Me.txtPassUser.Name = "txtPassUser"
        Me.txtPassUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassUser.Size = New System.Drawing.Size(161, 25)
        Me.txtPassUser.TabIndex = 7
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateUser.Location = New System.Drawing.Point(70, 344)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(74, 36)
        Me.btnCreateUser.TabIndex = 8
        Me.btnCreateUser.Text = "Crear"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(294, 344)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(74, 36)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(109, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "- CREAR NUEVO USUARIO -"
        '
        'FrmRegistroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(450, 441)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.txtPassUser)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtLastNameUser)
        Me.Controls.Add(Me.txtNameUser)
        Me.Controls.Add(Me.lblPasswordRegister)
        Me.Controls.Add(Me.lblUserNameRegister)
        Me.Controls.Add(Me.lblLastNameRegister)
        Me.Controls.Add(Me.lblNameRegister)
        Me.Name = "FrmRegistroUsuario"
        Me.Text = "FrmRegistroUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNameRegister As Label
    Friend WithEvents lblLastNameRegister As Label
    Friend WithEvents lblUserNameRegister As Label
    Friend WithEvents lblPasswordRegister As Label
    Friend WithEvents txtNameUser As TextBox
    Friend WithEvents txtLastNameUser As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassUser As TextBox
    Friend WithEvents btnCreateUser As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
End Class
