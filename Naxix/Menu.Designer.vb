<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Menu))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Cursor = Cursors.Hand
        Button1.Image = My.Resources.Resources.talent_search
        resources.ApplyResources(Button1, "Button1")
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button2.Cursor = Cursors.Hand
        Button2.Image = My.Resources.Resources.budget__2_
        resources.ApplyResources(Button2, "Button2")
        Button2.Name = "Button2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Button3.Cursor = Cursors.Hand
        Button3.Image = My.Resources.Resources.bullhorn
        resources.ApplyResources(Button3, "Button3")
        Button3.Name = "Button3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button5.Cursor = Cursors.Hand
        Button5.Image = My.Resources.Resources.programmer
        resources.ApplyResources(Button5, "Button5")
        Button5.Name = "Button5"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.LightSteelBlue
        Button6.Cursor = Cursors.Hand
        Button6.Image = My.Resources.Resources.setting
        resources.ApplyResources(Button6, "Button6")
        Button6.Name = "Button6"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Yellow
        Button4.Cursor = Cursors.Hand
        Button4.Image = My.Resources.Resources.growth
        resources.ApplyResources(Button4, "Button4")
        Button4.Name = "Button4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Menu
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Button4)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        MaximizeBox = False
        Name = "Menu"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
End Class
