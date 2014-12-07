'Created by Nathan Gaffney
'06/DEC/2014
'Chapter 12 Lessob C Exercise 4
'CST 271 Visual Basic
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If ddlStoreNumber.SelectedIndex = 0 Then
            lblManager.Text = "Jeffery Jefferson"
            lblAssistant.Text = "Paula Hendricks"
        ElseIf ddlStoreNumber.SelectedIndex = 1 Then
            lblManager.Text = "Barbara Millerton"
            lblAssistant.Text = "Sung Lee"
        ElseIf ddlStoreNumber.SelectedIndex = 2 Then
            lblManager.Text = "Inez Baily"
            lblAssistant.Text = "Homer Gomez"
        ElseIf ddlStoreNumber.SelectedIndex = 3 Then
            lblManager.Text = "Lou Chen"
            lblAssistant.Text = "Jake Johansen"
        ElseIf ddlStoreNumber.SelectedIndex = 4 Then
            lblManager.Text = "Henry Abernathy"
            lblAssistant.Text = "Ingrid Nadkarni"
        End If
    End Sub
End Class
