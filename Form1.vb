Public Class Form1
    Private Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        Try
            Dim adam As New ConexionADAM("COM6", "00")
            Dim respuesta As String = adam.LeerAnalogicas()

            lblentera.Text = respuesta

           txtS1.Text = respuesta.Substring(1, 7)
            txtS2.Text = respuesta.Substring(8, 7)
            txtS3.Text = respuesta.Substring(15, 7)
            txtS4.Text = respuesta.Substring(22, 7)
            txtS5.Text = respuesta.Substring(29, 7)
            txtS6.Text = respuesta.Substring(36, 7)
            txtS7.Text = respuesta.Substring(43, 7)
            txtS8.Text = respuesta.Substring(50, 7)


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

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtS3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtS5.TextChanged

    End Sub
End Class
