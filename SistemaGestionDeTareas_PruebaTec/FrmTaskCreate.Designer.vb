<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTaskCreate
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblDateLimit = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtTittle = New System.Windows.Forms.TextBox()
        Me.rtxtDescription = New System.Windows.Forms.RichTextBox()
        Me.dtpDateLimit = New System.Windows.Forms.DateTimePicker()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.btnCreateTask = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CREAR NUEVA TAREA"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(75, 104)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(64, 17)
        Me.lblCode.TabIndex = 1
        Me.lblCode.Text = "Código:"
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.Location = New System.Drawing.Point(75, 152)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(100, 17)
        Me.lblTittle.TabIndex = 2
        Me.lblTittle.Text = "Titulo Tarea:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(75, 293)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(63, 17)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Estado:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(74, 367)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(101, 17)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Descripción:"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(75, 203)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(85, 17)
        Me.lblCategory.TabIndex = 5
        Me.lblCategory.Text = "Categoría:"
        '
        'lblDateLimit
        '
        Me.lblDateLimit.AutoSize = True
        Me.lblDateLimit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateLimit.Location = New System.Drawing.Point(75, 248)
        Me.lblDateLimit.Name = "lblDateLimit"
        Me.lblDateLimit.Size = New System.Drawing.Size(106, 17)
        Me.lblDateLimit.TabIndex = 6
        Me.lblDateLimit.Text = "Fecha Limite:"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(191, 104)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(294, 25)
        Me.txtCode.TabIndex = 7
        '
        'txtTittle
        '
        Me.txtTittle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTittle.Location = New System.Drawing.Point(191, 152)
        Me.txtTittle.Name = "txtTittle"
        Me.txtTittle.Size = New System.Drawing.Size(294, 25)
        Me.txtTittle.TabIndex = 8
        '
        'rtxtDescription
        '
        Me.rtxtDescription.Location = New System.Drawing.Point(191, 339)
        Me.rtxtDescription.Name = "rtxtDescription"
        Me.rtxtDescription.Size = New System.Drawing.Size(294, 106)
        Me.rtxtDescription.TabIndex = 9
        Me.rtxtDescription.Text = ""
        '
        'dtpDateLimit
        '
        Me.dtpDateLimit.Location = New System.Drawing.Point(191, 248)
        Me.dtpDateLimit.Name = "dtpDateLimit"
        Me.dtpDateLimit.Size = New System.Drawing.Size(292, 20)
        Me.dtpDateLimit.TabIndex = 10
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Casa", "Trabajo", "Educación", "Salud", "Ocio"})
        Me.cmbCategory.Location = New System.Drawing.Point(191, 203)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(292, 21)
        Me.cmbCategory.TabIndex = 11
        Me.cmbCategory.Text = "--Seleccionar--"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Nueva", "En proceso", "En Revision", "Completada"})
        Me.cmbStatus.Location = New System.Drawing.Point(191, 293)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(292, 21)
        Me.cmbStatus.TabIndex = 12
        Me.cmbStatus.Text = "--Seleccionar--"
        '
        'btnCreateTask
        '
        Me.btnCreateTask.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateTask.Location = New System.Drawing.Point(77, 473)
        Me.btnCreateTask.Name = "btnCreateTask"
        Me.btnCreateTask.Size = New System.Drawing.Size(89, 33)
        Me.btnCreateTask.TabIndex = 13
        Me.btnCreateTask.Text = "Crear"
        Me.btnCreateTask.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(458, 473)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 33)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FrmTaskCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(600, 530)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCreateTask)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.dtpDateLimit)
        Me.Controls.Add(Me.rtxtDescription)
        Me.Controls.Add(Me.txtTittle)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblDateLimit)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblTittle)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmTaskCreate"
        Me.Text = "Creación Nueva Tarea"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents lblTittle As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblDateLimit As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtTittle As TextBox
    Friend WithEvents rtxtDescription As RichTextBox
    Friend WithEvents dtpDateLimit As DateTimePicker
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnCreateTask As Button
    Friend WithEvents btnExit As Button
End Class
