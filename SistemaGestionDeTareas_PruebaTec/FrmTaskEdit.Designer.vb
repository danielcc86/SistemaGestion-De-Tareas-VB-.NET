<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTaskEdit
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCreateTask = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.dtpDateLimit = New System.Windows.Forms.DateTimePicker()
        Me.rtxtDescription = New System.Windows.Forms.RichTextBox()
        Me.txtTittle = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblDateLimit = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(450, 485)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 33)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCreateTask
        '
        Me.btnCreateTask.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateTask.Location = New System.Drawing.Point(69, 485)
        Me.btnCreateTask.Name = "btnCreateTask"
        Me.btnCreateTask.Size = New System.Drawing.Size(89, 33)
        Me.btnCreateTask.TabIndex = 28
        Me.btnCreateTask.Text = "Editar"
        Me.btnCreateTask.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Nueva", "En proceso", "En Revision", "Completada"})
        Me.cmbStatus.Location = New System.Drawing.Point(183, 305)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(292, 21)
        Me.cmbStatus.TabIndex = 27
        Me.cmbStatus.Text = "--Seleccionar--"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Casa", "Trabajo", "Educación", "Salud", "Ocio"})
        Me.cmbCategory.Location = New System.Drawing.Point(183, 215)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(292, 21)
        Me.cmbCategory.TabIndex = 26
        '
        'dtpDateLimit
        '
        Me.dtpDateLimit.Enabled = False
        Me.dtpDateLimit.Location = New System.Drawing.Point(183, 260)
        Me.dtpDateLimit.Name = "dtpDateLimit"
        Me.dtpDateLimit.Size = New System.Drawing.Size(292, 20)
        Me.dtpDateLimit.TabIndex = 25
        '
        'rtxtDescription
        '
        Me.rtxtDescription.Location = New System.Drawing.Point(183, 351)
        Me.rtxtDescription.Name = "rtxtDescription"
        Me.rtxtDescription.Size = New System.Drawing.Size(294, 106)
        Me.rtxtDescription.TabIndex = 24
        Me.rtxtDescription.Text = ""
        '
        'txtTittle
        '
        Me.txtTittle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTittle.Location = New System.Drawing.Point(183, 164)
        Me.txtTittle.Name = "txtTittle"
        Me.txtTittle.Size = New System.Drawing.Size(294, 25)
        Me.txtTittle.TabIndex = 23
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(183, 116)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(294, 25)
        Me.txtCode.TabIndex = 22
        '
        'lblDateLimit
        '
        Me.lblDateLimit.AutoSize = True
        Me.lblDateLimit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateLimit.Location = New System.Drawing.Point(67, 260)
        Me.lblDateLimit.Name = "lblDateLimit"
        Me.lblDateLimit.Size = New System.Drawing.Size(106, 17)
        Me.lblDateLimit.TabIndex = 21
        Me.lblDateLimit.Text = "Fecha Limite:"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(67, 215)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(85, 17)
        Me.lblCategory.TabIndex = 20
        Me.lblCategory.Text = "Categoría:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(66, 379)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(101, 17)
        Me.lblDescription.TabIndex = 19
        Me.lblDescription.Text = "Descripción:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(67, 305)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(63, 17)
        Me.lblStatus.TabIndex = 18
        Me.lblStatus.Text = "Estado:"
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.Location = New System.Drawing.Point(67, 164)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(100, 17)
        Me.lblTittle.TabIndex = 17
        Me.lblTittle.Text = "Titulo Tarea:"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(67, 116)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(64, 17)
        Me.lblCode.TabIndex = 16
        Me.lblCode.Text = "Código:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "EDITAR TAREA"
        '
        'FrmTaskEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(605, 560)
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
        Me.Name = "FrmTaskEdit"
        Me.Text = "FrmTaskEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnCreateTask As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents dtpDateLimit As DateTimePicker
    Friend WithEvents rtxtDescription As RichTextBox
    Friend WithEvents txtTittle As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents lblDateLimit As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTittle As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents Label1 As Label
End Class
