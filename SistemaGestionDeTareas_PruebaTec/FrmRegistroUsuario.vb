Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class FrmRegistroUsuario
    Private Async Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        Dim _name As String = txtNameUser.Text
        Dim _lastName As String = txtLastNameUser.Text
        Dim _userName As String = txtUser.Text
        Dim _pssUser As String = txtPassUser.Text


        Dim url As String = "Https://localhost:7169/api/Users/crear"

        Dim client As New HttpClient()

        Dim newUser = New With {
            .name = _name,
            .lastName = _lastName,
            .UserName = _userName,
            .Password = _pssUser
        }

        Try
            Dim jsonUser As String = JsonConvert.SerializeObject(newUser)
            Dim content = New StringContent(jsonUser, System.Text.Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Usuario registrado exitosamente.")

            Else
                MessageBox.Show("Error al crear el nuevo usuario. Código de estado: " & response.StatusCode)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            client.Dispose()
        End Try

        txtNameUser.Text = ""
        txtLastNameUser.Text = ""
        txtUser.Text = ""
        txtPassUser.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub
End Class