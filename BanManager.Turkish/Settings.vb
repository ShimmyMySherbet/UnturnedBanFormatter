Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SettingsConfig("OnTop") Then
            Me.TopMost = True
            Me.BringToFront()
        Else
            Me.TopMost = False
        End If
        txtname.Text = SettingsConfig("Name")
        txtRDlim.Text = SettingsConfig("Rdelim")
        txtNdelim.Text = SettingsConfig("Ndelim")
        cbOnTop.Checked = SettingsConfig("OnTop")
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.ControlBox = True
    End Sub
    Private Sub btnSaveNClose_Click(sender As Object, e As EventArgs) Handles btnSaveNClose.Click
        SettingsConfig("Name") = txtname.Text
        SettingsConfig("Rdelim") = txtRDlim.Text
        SettingsConfig("Ndelim") = txtNdelim.Text
        SettingsConfig("OnTop") = cbOnTop.Checked
        SettingsConfig.Save()
        Me.Close()
    End Sub

End Class