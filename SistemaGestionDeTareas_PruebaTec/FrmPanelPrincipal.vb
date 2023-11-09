Imports System.Net.Http
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports Newtonsoft.Json



Public Class FrmPanelPrincipal
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Me.Hide()
        FrmTaskCreate.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.Hide()
        If dgvTaskList.SelectedRows.Count > 0 Then
            ' Obtener los datos de la fila seleccionada
            Dim rowSelected As DataGridViewRow = dgvTaskList.SelectedRows(0)

            ' Obtener los valores de las celdas de la fila seleccionada
            Dim code As String = rowSelected.Cells("taskCode").Value.ToString()
            Dim tittle As String = rowSelected.Cells("taskTitulo").Value.ToString()
            Dim statusName As String = rowSelected.Cells("StatusName").Value.ToString()
            Dim categoryName As String = rowSelected.Cells("taskCategory").Value.ToString()
            Dim EndDate As String = rowSelected.Cells("EndDate").Value.ToString()
            Dim Description As String = rowSelected.Cells("taskDescription").Value.ToString()

            ' Abrir el formulario de edición y pasar los valores
            Dim formEditar As New FrmTaskEdit(code, tittle, statusName, categoryName, EndDate, Description)
            formEditar.Show()
        Else
            MessageBox.Show("Por favor, seleccione una fila para editar.")
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvTaskList.SelectedRows.Count > 0 Then
            ' Obtener los datos de la fila seleccionada
            Dim rowSelected As DataGridViewRow = dgvTaskList.SelectedRows(0)

            Dim code As String = rowSelected.Cells("taskCode").Value.ToString()
            Dim url As String = $"Https://localhost:7169/api/Tasks/Eliminar?code={code}"

            Dim client As New HttpClient()

            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync(New Uri(url))

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Tarea eliminada exitosamente.")
                    Await GetTask()
                Else
                    MessageBox.Show("Error al eliminar la tarea. Código de estado: " & response.StatusCode)
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                client.Dispose()
            End Try

        Else
            MessageBox.Show("Por favor, seleccione una fila para editar.")
        End If
    End Sub

    Private Async Sub Tareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await GetTask() ' Llama a la función de carga de tareas al cargar el formulario
    End Sub

    Public Async Function GetTask() As Task(Of Task)

        Dim url As String = "Https://localhost:7169/api/Tasks/Tareas"

        Dim client As New HttpClient()

        Try
            Dim response As HttpResponseMessage = Await client.GetAsync(url)

            If response.IsSuccessStatusCode Then
                Dim content As String = Await response.Content.ReadAsStringAsync()

                ' Deserializar la respuesta JSON a una lista de tareas 
                Dim tasks As List(Of Task) = JsonConvert.DeserializeObject(Of List(Of Task))(content)

                ' Asignar la lista de tareas al DataGridView
                dgvTaskList.DataSource = tasks
            Else
                MessageBox.Show("Error al obtener datos de la API.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            client.Dispose()
        End Try
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Async Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim listTask As String = "Todas"
        Dim category As String = cmbFilter.SelectedItem
        Dim url As String
        If category <> listTask Then
            url = $"Https://localhost:7169/api/Tasks/TareasPorCategoria?category={category}"

            Dim client As New HttpClient()

            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(New Uri(url))

                If response.IsSuccessStatusCode Then
                    Dim content As String = Await response.Content.ReadAsStringAsync()

                    ' Deserializar la respuesta JSON a una lista de tareas (clase Task)
                    Dim tasks As List(Of Task) = JsonConvert.DeserializeObject(Of List(Of Task))(content)

                    ' Asignar la lista de tareas al DataGridView
                    dgvTaskList.DataSource = tasks
                Else
                    MessageBox.Show("Error al obtener datos de la API.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                client.Dispose()
            End Try
        Else
            Await GetTask()
        End If
    End Sub
End Class
