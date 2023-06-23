<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Connexion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form_Connexion))
        Label1 = New Label()
        Label2 = New Label()
        txtNomUtilisateur = New TextBox()
        txtMotDePasse = New TextBox()
        Label3 = New Label()
        btnConnexion = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(73, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 17)
        Label1.TabIndex = 0
        Label1.Text = "NomUtilisateur :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(84, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 17)
        Label2.TabIndex = 1
        Label2.Text = "Mot de passe :"
        ' 
        ' txtNomUtilisateur
        ' 
        txtNomUtilisateur.Location = New Point(175, 90)
        txtNomUtilisateur.Name = "txtNomUtilisateur"
        txtNomUtilisateur.Size = New Size(241, 25)
        txtNomUtilisateur.TabIndex = 2
        ' 
        ' txtMotDePasse
        ' 
        txtMotDePasse.Location = New Point(175, 117)
        txtMotDePasse.Name = "txtMotDePasse"
        txtMotDePasse.Size = New Size(241, 25)
        txtMotDePasse.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(204, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 31)
        Label3.TabIndex = 4
        Label3.Text = "Connexion"
        ' 
        ' btnConnexion
        ' 
        btnConnexion.BackColor = Color.White
        btnConnexion.Cursor = Cursors.Hand
        btnConnexion.Location = New Point(204, 162)
        btnConnexion.Name = "btnConnexion"
        btnConnexion.Size = New Size(187, 32)
        btnConnexion.TabIndex = 5
        btnConnexion.Text = "Se connecter"
        btnConnexion.UseVisualStyleBackColor = False
        ' 
        ' Form_Connexion
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGreen
        ClientSize = New Size(524, 220)
        Controls.Add(btnConnexion)
        Controls.Add(Label3)
        Controls.Add(txtMotDePasse)
        Controls.Add(txtNomUtilisateur)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form_Connexion"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomUtilisateur As TextBox
    Friend WithEvents txtMotDePasse As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConnexion As Button
End Class
