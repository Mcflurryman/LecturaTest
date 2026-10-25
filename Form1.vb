Public Class Form1
    Private Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        Try
            Dim adam As New ConexionADAM("COM6", "01")
            Dim respuesta As String = adam.LeerAnalogicas()

            lblentera.Text = respuesta

            lblS1.Text = respuesta.Substring(1, 7)
            lblS2.Text = respuesta.Substring(8, 7)
            lblS3.Text = respuesta.Substring(15, 7)
            lblS4.Text = respuesta.Substring(22, 7)
            lblS5.Text = respuesta.Substring(29, 7)
            lblS6.Text = respuesta.Substring(36, 7)
            lblS7.Text = respuesta.Substring(43, 7)


        Catch ex As Exception
            MessageBox.Show("Error al leer el módulo ADAM: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaveDB_Click(sender As Object, e As EventArgs) Handles btnSaveDB.Click
        Try
            Dim SaveDB As New AbrirConexionSQL()

        Catch ex As Exception

        End Try
    End Sub
End Class
