Module SettingsMod
    Public SettingsConfig As New INIFile(IO.Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly.Location()) & "\config.ini")
    Sub CheckSchema()
        If SettingsConfig.INIFileLineCount = 0 Then
            SettingsConfig.WriteComment("Auto Generated Config File for Shimmy's BanManager")
        End If
        If Not SettingsConfig.KeySet("Name") Then
            SettingsConfig("Name") = ""
        End If
        If Not SettingsConfig.KeySet("RDelim") Then
            SettingsConfig("RDelim") = "//"
        End If
        If Not SettingsConfig.KeySet("NDelim") Then
            SettingsConfig("NDelim") = "/"
        End If
        If Not SettingsConfig.KeySet("OnTop") Then
            SettingsConfig("OnTop") = False
        End If
        If SettingsConfig.FileModified Then
            SettingsConfig.Save()
        End If
    End Sub
End Module
