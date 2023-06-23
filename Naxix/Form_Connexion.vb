
Public Class Form_Connexion

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        Dim username As String = txtNomUtilisateur.Text.Trim()
        Dim password As String = txtMotDePasse.Text.Trim()

        If ValidateUser(username, password) Then
            MessageBox.Show("Connexion réussie!")
            Me.Hide()
            Dim menu As New Menu()
            menu.Show()


        Else
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect!")
        End If
    End Sub

End Class
