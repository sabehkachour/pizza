Imports System.Reflection.Metadata
Public Class form1.vb
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim taille = lsTtaille.SelectedItem.tostring()
        Dim ingredient As String = ""
        If Rdprop1.Checked Then
            ingredient = "croute fine"
        ElseIf Rdprop2.Checked Then
            ingredient = "croute classique"
        ElseIf Rdprop3.Checked Then
            ingredient = "croute epaisse"
        End If
        Dim ingrsupp As String = ""
        If Chkprop1.Checked Then
            ingrsupp = ingrsupp + "champignion"
        ElseIf Chkprop2.Checked Then
            ingrsupp = ingrsupp + "olives"
        ElseIf Chkprop3.Checked Then
            ingrsupp = ingrsupp + "poivrons"
        ElseIf Chkprop4.Checked Then
            ingrsupp = ingrsupp + "formage supplement"
        End If
        Dim msg As String = "taille:" + taille + "types de croute:" + ingredient + "ingredients supplementaires"
        MessageBox.Show(msg)

    End Sub


End Class
