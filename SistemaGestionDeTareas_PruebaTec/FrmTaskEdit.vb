Imports Newtonsoft.Json
Imports System.Net.Http
Imports SistemaGestionDeTareas_PruebaTec.FrmPanelPrincipal

Public Class FrmTaskEdit
    Private code As String
    Private tittle As String
    Private statusName As String
    Private categoryName As String
    Private endDate As String
    Private description As String

    Private WithEvents panelPrincipal As FrmPanelPrincipal

    Public Sub New(code As String, tittle As String, statusName As String, categoryName As String, endDate As String, description As String)

        InitializeComponent()

        Me.code = code
        Me.tittle = tittle
        Me.statusName = statusName
        Me.categoryName = categoryName
        Me.endDate = endDate
        Me.description = description

        AddHandler Me.Load, AddressOf FrmTaskEdit_Load
    End Sub

    Private Sub FrmTaskEdit_Load(sender As Object, e As EventArgs)
        txtCode.Text = Me.code
        txtTittle.Text = Me.tittle
        cmbStatus.Text = Me.statusName
        cmbCategory.Text = Me.categoryName
        dtpDateLimit.Text = Me.endDate
        rtxtDescription.Text = Me.description

        ' Eliminar el controlador de eventos después de asignar los valores
        RemoveHandler Me.Load, AddressOf FrmTaskEdit_Load
    End Sub

    Private Async Sub btnCreateTask_Click(sender As Object, e As EventArgs) Handles btnCreateTask.Click
        Dim codeTask As String = txtCode.Text
        Dim tittleTask As String = txtTittle.Text
        Dim categoryTask As String = If(cmbCategory.SelectedItem IsNot Nothing, cmbCategory.SelectedItem, cmbCategory.Text)
        Dim endDateTask As Date = dtpDateLimit.Value
        Dim statusTask As String = If(cmbStatus.SelectedItem IsNot Nothing, cmbStatus.SelectedItem, cmbStatus.Text)
        Dim descriptionTask As String = rtxtDescription.Text


        Dim url As String = "Https://localhost:7169/api/Tasks/Editar"

        Dim client As New HttpClient()

        Dim newTask = New With {
            .taskCode = codeTask,
            .taskTitulo = tittleTask,
            .taskCategory = categoryTask,
            .EndDate = endDateTask,
            .StatusName = statusTask,
            .taskDescription = descriptionTask
        }

        Try
            Dim jsonTarea As String = JsonConvert.SerializeObject(newTask)
            Dim content = New StringContent(jsonTarea, System.Text.Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PutAsync(url, content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Tarea Actualizada exitosamente.")

            Else
                MessageBox.Show("Error al actualizar la tarea. Código de estado: " & response.StatusCode)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            client.Dispose()
        End Try

        txtCode.Text = ""
        txtTittle.Text = ""
        cmbCategory.SelectedIndex = 0
        dtpDateLimit.Value = DateTime.Now
        cmbStatus.SelectedIndex = 0
        rtxtDescription.Text = ""

    End Sub

    Private Async Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        FrmPanelPrincipal.Show()
        Await FrmPanelPrincipal.GetTask()

    End Sub

    Public Sub New(ByRef principal As FrmPanelPrincipal)

        InitializeComponent()
        panelPrincipal = principal

    End Sub
End Class