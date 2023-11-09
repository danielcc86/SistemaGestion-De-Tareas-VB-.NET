Imports System.Net.Http
Imports System.Runtime.CompilerServices

Public Class FrmLogin

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String
        Dim password As String

        user = txtUserName.Text
        password = txtPassword.Text

        Dim url As String = $"Https://localhost:7169/api/Users/ValidacionUsuario?userName={user}&password={password}"

        Dim client As New HttpClient()
        Try
            Dim response As HttpResponseMessage = Await client.GetAsync(New Uri(url))

            If response.IsSuccessStatusCode Then
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                Dim jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(responseContent)

                Dim isValid As Boolean = jsonResponse("isValid")
                Dim validationValue As Integer = jsonResponse("validationValue")
                If validationValue = 1 Then
                    Me.Hide()
                    FrmPanelPrincipal.Show()
                Else
                    MsgBox("Usuario o contraseña no validos... Intente nuevamente...")
                End If

            Else
                MessageBox.Show("Error al ralizar la validacion. Código de estado: " & response.StatusCode)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            client.Dispose()
        End Try
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtUserName.Focus()
    End Sub

    Private Sub lblRegisterUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegisterUser.LinkClicked
        Me.Hide()
        FrmRegistroUsuario.Show()
    End Sub
End Class
