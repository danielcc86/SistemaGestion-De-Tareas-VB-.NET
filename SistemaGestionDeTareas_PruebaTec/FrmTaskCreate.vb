Imports Newtonsoft.Json
Imports System.Net.Http

Public Class FrmTaskCreate
    Private Sub FrmTaskCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub btnCreateTask_Click(sender As Object, e As EventArgs) Handles btnCreateTask.Click
        Dim codeTask As String = txtCode.Text
        Dim tittleTask As String = txtTittle.Text
        Dim categoryTask As String = cmbCategory.SelectedItem
        Dim endDateTask As Date = dtpDateLimit.Value
        Dim statusTask As String = cmbStatus.SelectedItem
        Dim descriptionTask As String = rtxtDescription.Text

        Dim url As String = "Https://localhost:7169/api/Tasks/crear"

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

            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Tarea creada exitosamente.")

            Else
                MessageBox.Show("Error al crear la tarea. Código de estado: " & response.StatusCode)
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

End Class