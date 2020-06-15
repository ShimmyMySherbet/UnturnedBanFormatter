Public Class TranslationModel
    Public WindowTitle As String = "Ban Manager"
    Public SettingsTitle As String = "Settings"
    Public MainPage As New List(Of TranslationMapping)
    Public SettingsPage As New List(Of TranslationMapping)
    Public TimeModels As List(Of TimeModifier)
    Public ReasonMappings As New List(Of ReasonMapping)
    Public NoteMappings As New List(Of ReasonMapping)
End Class

Public Module TranslationsModel
    Public Sub WriteDefaultTranslations()
        Dim D As New TranslationModel
        D.TimeModels = UI.TimeModels
        For Each LB As Label In UI.Controls.OfType(Of Label)
            D.MainPage.Add(New TranslationMapping() With {
                               .Control = LB.Name,
                               .Value = LB.Text})
        Next
        For Each LB As CheckBox In UI.Controls.OfType(Of CheckBox)
            D.MainPage.Add(New TranslationMapping() With {
                               .Control = LB.Name,
                               .Value = LB.Text})
        Next


        For Each LB As Button In UI.Controls.OfType(Of Button)
            D.MainPage.Add(New TranslationMapping() With {
                               .Control = LB.Name,
                               .Value = LB.Text})
        Next

        For Each LB As Label In Settings.Controls.OfType(Of Label)
            D.SettingsPage.Add(New TranslationMapping() With {
                               .Control = LB.Name,
                               .Value = LB.Text})
        Next
        For Each LB As CheckBox In Settings.Controls.OfType(Of CheckBox)
            D.SettingsPage.Add(New TranslationMapping() With {
                               .Control = LB.Name,
                               .Value = LB.Text})
        Next
        For Each LB As Button In Settings.Controls.OfType(Of Button)
            D.SettingsPage.Add(New TranslationMapping() With {
                               .Control = LB.Name,
                               .Value = LB.Text})
        Next

        For Each ENT In UI.CBDict
            D.ReasonMappings.Add(New ReasonMapping() With {
                                 .ReasonControl = ENT.Key.Name,
                                 .ReasonText = ENT.Value})
        Next
        For Each ENT In UI.NoteDict
            D.NoteMappings.Add(New ReasonMapping() With {
                                 .ReasonControl = ENT.Key.Name,
                                 .ReasonText = ENT.Value})
        Next
        IO.File.WriteAllText("out.json", Newtonsoft.Json.JsonConvert.SerializeObject(D))
    End Sub


    Public Sub ApplyTranslations(Model As String)
        Dim MD As TranslationModel = Newtonsoft.Json.JsonConvert.DeserializeObject(Of TranslationModel)(Model)
    End Sub

    Public Sub ApplyTranslations(Model() As Byte)
        Dim MD As TranslationModel = Newtonsoft.Json.JsonConvert.DeserializeObject(Of TranslationModel)(System.Text.Encoding.UTF8.GetString(Model))
        ApplyTranslations(MD)
    End Sub

    Public Sub ApplyTranslations(Model As TranslationModel)
        UI.Text = Model.WindowTitle
        Settings.Text = Model.SettingsTitle
        UI.TimeModels = Model.TimeModels
        For Each ent In Model.MainPage

            For Each lbl In UI.Controls.OfType(Of Label)
                If lbl.Name.ToLower = ent.Control.ToLower Then
                    lbl.Text = ent.Value
                End If
            Next

            For Each lbl In UI.Controls.OfType(Of CheckBox)
                If lbl.Name.ToLower = ent.Control.ToLower Then
                    lbl.Text = ent.Value
                End If
            Next

            For Each lbl In UI.Controls.OfType(Of Button)
                If lbl.Name.ToLower = ent.Control.ToLower Then
                    lbl.Text = ent.Value
                End If
            Next

        Next

        For Each ent In Model.SettingsPage

            For Each lbl In Settings.Controls.OfType(Of Label)
                If lbl.Name.ToLower = ent.Control.ToLower Then
                    lbl.Text = ent.Value
                End If
            Next

            For Each lbl In Settings.Controls.OfType(Of CheckBox)
                If lbl.Name.ToLower = ent.Control.ToLower Then
                    lbl.Text = ent.Value
                End If
            Next
            For Each lbl In Settings.Controls.OfType(Of Button)
                If lbl.Name.ToLower = ent.Control.ToLower Then
                    lbl.Text = ent.Value
                End If
            Next

        Next

        UI.CBDict = New Dictionary(Of CheckBox, String)
        UI.NoteDict = New Dictionary(Of CheckBox, String)

        For Each vd In Model.ReasonMappings
            For Each lbl In UI.Controls.OfType(Of CheckBox)
                If lbl.Name.ToLower = vd.ReasonControl.ToLower Then
                    UI.CBDict.Add(lbl, vd.ReasonText)
                End If
            Next
        Next

        For Each vd In Model.NoteMappings
            For Each lbl In UI.Controls.OfType(Of CheckBox)
                If lbl.Name.ToLower = vd.ReasonControl.ToLower Then
                    UI.NoteDict.Add(lbl, vd.ReasonText)
                End If
            Next
        Next

    End Sub



End Module

Public Class TranslationMapping
    Public Control As String
    Public Value As String
End Class
Public Class ReasonMapping
    Public ReasonControl As String
    Public ReasonText As String
End Class