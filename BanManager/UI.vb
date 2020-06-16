Imports System.IO

Public Class UI
    Public Shared CBDict As New Dictionary(Of CheckBox, String)
    Public Shared NoteDict As New Dictionary(Of CheckBox, String)

    Public Sub UpdateCommand()

        Dim Reasons = GetReasons()
        Dim Notes = GetNotes()
        Dim des = GetBanDuration()
        Dim dur = des.Key
        Dim cmd = "/Ban "
        Dim plr As String = txtPlayer.Text.Trim(" ")
        If plr.Contains(" ") Then
            cmd = cmd & """" & plr & """ "
        Else
            cmd = cmd & plr & " "
        End If
        Dim com As String = ""
        If Reasons.Count <> 0 Then
            com = com & String.Join(SettingsConfig("Rdelim"), Reasons)
        End If
        If Notes.Count <> 0 Then
            If Notes.Count <> 0 Then
                If com.Length <> 0 Then
                    com = com & SettingsConfig("Rdelim")
                End If
                com = com & String.Join(SettingsConfig("Ndelim"), Notes)
            End If
        End If
        If com.Length <> 0 Then
            com = com & SettingsConfig("Rdelim") & SettingsConfig("Name")
        Else
            com = com & SettingsConfig("Name")
        End If
        If com.Length <> 0 Then
            com = com & SettingsConfig("Rdelim") & des.Value
        Else
            com = com & des.Value
        End If
        com = com.Trim(" ")
        If com.Contains(" ") Then
            cmd = cmd & """" & com & """"
        Else
            cmd = cmd & com
        End If
        If dur > 0 Then
            cmd = cmd & " " & dur
        End If
        txtCommandOut.Text = cmd
    End Sub

    Sub shn() Handles MyBase.Shown
        LoadDicts()
        HookHandlers()
        CheckForIllegalCrossThreadCalls = False
        If SettingsConfig("Translation").ToLower() = "en" Or SettingsConfig("Translation").ToLower() = "english" Then
            'Default
        ElseIf SettingsConfig("Translation").ToLower() = "tr" Or SettingsConfig("Translation").ToLower() = "turkish" Then
            Dim Model As TranslationModel = Newtonsoft.Json.JsonConvert.DeserializeObject(Of TranslationModel)(My.Resources.TRanslations.Translastions_Turkish)
            ApplyTranslations(Model)
            If Not String.IsNullOrEmpty(Model.IconURL) Then
                Dim RD As New Threading.Thread(Sub()
                                                   Try

                                                       Dim IconD As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BanManager")
                                                       If Not Directory.Exists(IconD) Then
                                                           Directory.CreateDirectory(IconD)
                                                       End If
                                                       If Not File.Exists(Path.Combine(IconD, $"icon_{Model.TranslationsName}")) Then
                                                           Dim Req As Net.HttpWebRequest = Net.WebRequest.CreateHttp(Model.IconURL)
                                                           Req.Method = "GET"
                                                           Console.WriteLine("DL")
                                                           Dim st As New IO.MemoryStream()
                                                           Req.GetResponse().GetResponseStream().CopyTo(st)
                                                           File.WriteAllBytes(Path.Combine(IconD, $"icon_{Model.TranslationsName}"), st.ToArray())
                                                       End If
                                                       Dim IC As New Icon(Path.Combine(IconD, $"icon_{Model.TranslationsName}"))
                                                       Console.WriteLine("Done")
                                                       Me.Icon = IC
                                                       Console.WriteLine("Icon Set")
                                                   Catch ex As Exception
                                                       Console.WriteLine(ex.Message)
                                                   End Try

                                               End Sub)
                RD.Start()
            End If
        Else
            If IO.File.Exists(SettingsConfig("Translation")) Then
                Dim Model As TranslationModel = Newtonsoft.Json.JsonConvert.DeserializeObject(Of TranslationModel)(IO.File.ReadAllText(SettingsConfig("Translation")))
                ApplyTranslations(Model)
                If Not String.IsNullOrEmpty(Model.IconURL) Then
                    Dim RD As New Threading.Thread(Sub()
                                                       Try

                                                           Dim IconD As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BanManager")
                                                           If Not Directory.Exists(IconD) Then
                                                               Directory.CreateDirectory(IconD)
                                                           End If
                                                           If Not File.Exists(Path.Combine(IconD, $"icon_{Model.TranslationsName}")) Then
                                                               Dim Req As Net.HttpWebRequest = Net.WebRequest.CreateHttp(Model.IconURL)
                                                               Req.Method = "GET"
                                                               Console.WriteLine("DL")
                                                               Dim st As New IO.MemoryStream()
                                                               Req.GetResponse().GetResponseStream().CopyTo(st)
                                                               File.WriteAllBytes(Path.Combine(IconD, $"icon_{Model.TranslationsName}"), st.ToArray())
                                                           End If
                                                           Dim IC As New Icon(Path.Combine(IconD, $"icon_{Model.TranslationsName}"))
                                                           Console.WriteLine("Done")
                                                           Me.Icon = IC
                                                           Console.WriteLine("Icon Set")
                                                       Catch ex As Exception
                                                           Console.WriteLine(ex.Message)
                                                       End Try

                                                   End Sub)
                    RD.Start()
                End If
            Else
                MessageBox.Show(Me, $"Invalid translation '{SettingsConfig("Translation")}'.
Supported Built-in Languages:
 English
 Turkish

Extrnal translations file '{SettingsConfig("Translation")}' not found.

Edit Config.ini to fix this issue.", "Translations Error")

            End If
        End If
        'If IO.File.Exists("out.json") Then

        'Else
        '    WriteDefaultTranslations()
        'End If
    End Sub

    Sub ld() Handles MyBase.Load
        CheckSchema()
        CheckTop()
    End Sub

    Public Shared Sub CheckTop()
        If SettingsConfig("OnTop") Then
            UI.TopMost = True
            UI.BringToFront()
        Else
            UI.TopMost = False
        End If
    End Sub

    Sub HookHandlers()
        For Each et In CBDict
            AddHandler et.Key.CheckedChanged, AddressOf RunUpdate
        Next
        For Each et In NoteDict
            AddHandler et.Key.CheckedChanged, AddressOf RunUpdate
        Next
    End Sub

    Sub RunUpdate() Handles txtDuration.TextChanged, txtNotes.TextChanged, txtOtherReason.TextChanged, txtPlayer.TextChanged
        UpdateCommand()
    End Sub

    Sub LoadDicts()
        CBDict = New Dictionary(Of CheckBox, String) From {
        {cb_falserp, "False RP"},
        {cb_advert, "Advertising"},
        {cb_alt, "Alt Account"},
        {cb_AtemptServerCrash, "Attemped Crashing"},
        {cb_Cheat, "Cheating"},
        {cb_CheatAssisted, "Assisted By Cheater"},
        {cb_fearrp, "Fear RP"},
        {cb_glitch, "Glitching"},
        {cb_GlitchedBase, "Glitched Base"},
        {cb_Greif, "Greifing"},
        {cb_ignoringstaff, "Ignoring Staff Instructions"},
        {cb_kos, "KOS"},
        {cb_LoadAbuse, "Load Abuse"},
        {cb_minge, "Minge"},
        {cb_nointent, "No Intent"},
        {cb_racism, "Racism"},
        {cb_ServerCrash, "Crashing Server"},
        {cb_StaffDis, "Staff Dis"},
        {cb_staffevade, "Staff Evade"},
        {cb_staffimpers, "Staff Impersonation"}}
        NoteDict = New Dictionary(Of CheckBox, String) From {
        {cbChangeName, "Change Name"},
        {cbReadRules, "Read Rules"}}
    End Sub

    Public Function GetReasons() As List(Of String)
        Dim R As New List(Of String)
        For Each R_ In CBDict
            If R_.Key.Checked Then
                R.Add(R_.Value)
            End If
        Next
        If txtOtherReason.Text.Trim(" ") <> "" Then
            R.Add(txtOtherReason.Text.Trim(" "))
        End If
        Return R
    End Function

    Public Function GetNotes() As List(Of String)
        Dim R As New List(Of String)
        For Each R_ In NoteDict
            If R_.Key.Checked Then
                R.Add(R_.Value)
            End If
        Next
        If txtNotes.Text.Trim(" ") <> "" Then
            R.Add(txtNotes.Text.Trim(" "))
        End If
        Return R
    End Function

    Public Shared TimeModels As List(Of TimeModifier) = New List(Of TimeModifier) From {
    New TimeModifier() With {
    .Name = "Second",
    .PluralName = "Seconds",
    .Names = New List(Of String) From {"s", "sec", "seconds", "second"},
    .Value = 1
    },
    New TimeModifier() With {
    .Name = "Minute",
    .PluralName = "Minutes",
    .Names = New List(Of String) From {"m", "min", "minute", "minutes"},
    .Value = 60
    },
    New TimeModifier() With {
    .Name = "Hour",
    .PluralName = "Hours",
    .Names = New List(Of String) From {"h", "hour", "ho", "hr", "hours", "hrs", "hs"},
    .Value = 60 * 60
    },
    New TimeModifier() With {
    .Name = "Day",
    .PluralName = "Days",
    .Names = New List(Of String) From {"d", "day", "dy", "ds", "days", "dys"},
    .Value = 60 * 60 * 24
    },
    New TimeModifier() With {
    .Name = "Week",
    .PluralName = "Weeks",
    .Names = New List(Of String) From {"w", "week", "weeks", "wks"},
    .Value = 60 * 60 * 24 * 7
    },
    New TimeModifier() With {
    .Name = "Year",
    .PluralName = "Years",
    .Names = New List(Of String) From {"y", "year", "years", "yr", "yrs"},
    .Value = 60 * 60 * 24 * 367
    },
    New TimeModifier() With {
    .Name = "Perm",
    .PluralName = "Perm",
    .Names = New List(Of String) From {"p", "pm", "perm", "inf", "forever", ""},
    .Value = -1
    }
    }

    Public Function GetBanDuration() As KeyValuePair(Of Long, String)
        Dim intxt As String = txtDuration.Text.Trim(" ")
        Console.WriteLine($">>'{intxt}'<<")
        Dim vls = GetVals(intxt)

        If Not intxt = "" Then
            Console.WriteLine("MD")
            If IsNumeric(intxt) And Not String.IsNullOrEmpty(intxt) Then
                Return ParseFromFunct(vls)
                Exit Function
            End If
        End If

        Dim Modifier As String = vls.Value.ToLower.Trim(" ")
        Dim Seconds As Long = -1
        'Dim mdr As KeyValuePair(Of String, Double) = New KeyValuePair(Of String, Double)("Perm", -1)

        Dim MDVal As TimeModifier = TimeModels.Where(Function(x)
                                                         Return x.Value = -1
                                                     End Function).FirstOrDefault()

        For Each modi In TimeModels
            If modi.Names.Contains(Modifier) Then
                MDVal = modi
                If modi.Value = -1 Then
                    Seconds = -2
                Else
                    Seconds = vls.Key * modi.Value
                End If
                Exit For
            End If
        Next
        Dim resptxt As String = ""
        If Seconds = -1 Or Seconds = -2 Then
            resptxt = "Perm"
        Else
            resptxt = Math.Round(vls.Key, 1) & " " & QueryPlural(vls.Key, MDVal)
        End If
        Console.WriteLine("Bylen")
        Return New KeyValuePair(Of Long, String)(Seconds, resptxt)
    End Function

    Private Function QueryPlural(amt As Double, Model As TimeModifier) As String
        If amt = 1 Then
            Console.WriteLine("Ret Name")
            Return Model.Name
        Else
            Console.WriteLine("Ret Plur")
            Return Model.PluralName
        End If
    End Function

    Public Function ParseFromFunct(vls As KeyValuePair(Of Double, String)) As KeyValuePair(Of Long, String)
        Console.WriteLine("funct")
        Dim dur As Double = vls.Key
        Dim nam As String = ""
        Dim found As Boolean = False
        For Each Value In TimeModels.OrderByDescending(Function(x)
                                                           Return x.Value
                                                       End Function)
            If Not found Then
                If vls.Key >= Value.Value Then
                    Dim VL As Double = Math.Round(dur / (Value.Value), 1)
                    nam = $"{VL} {QueryPlural(VL, Value)}"
                End If
                found = True
            End If
        Next
        If nam = "" Then
            Dim Def As TimeModifier = TimeModels.FirstOrDefault()
            Dim VL As Double = Math.Round(dur / (Def.Value), 1)
            nam = $"{VL} {QueryPlural(VL, Def)}"
        End If
        Return New KeyValuePair(Of Long, String)(dur, nam)
    End Function

    'Private Function Plurify(dur As Double) As String
    '    Console.WriteLine($"Plur>rec::{dur}")
    '    If dur > 1 Then
    '        Return "s"
    '    Else
    '        Return ""
    '    End If
    'End Function
    Private Function GetVals(str As String) As KeyValuePair(Of Double, String)
        str = str.Trim(" ")
        Dim reb As String = ""
        Dim [mod] As String = ""
        Dim allowed As List(Of Char) = "1234567890".ToList()
        Dim floathit As Boolean = False
        Dim StringHit As Boolean = False
        For Each cha As Char In str
            If StringHit Then
                [mod] = [mod] & cha
            ElseIf allowed.Contains(cha) Then
                reb = reb & cha
            ElseIf cha = "."c And Not floathit Then
                reb = reb & "."
                floathit = True
            Else
                StringHit = True
                [mod] = [mod] & cha
            End If
        Next
        If reb = "" Then
            reb = 1
        End If
        Return New KeyValuePair(Of Double, String)(reb, [mod])
    End Function

    Private Sub pbSett_Click(sender As Object, e As EventArgs) Handles pbSett.Click
        Settings.ShowDialog()
        UpdateCommand()
        CheckTop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.SuspendLayout()
        For Each db In CBDict
            db.Key.Checked = False
        Next
        For Each db In NoteDict
            db.Key.Checked = False
        Next
        txtDuration.Text = ""
        txtNotes.Text = ""
        txtOtherReason.Text = ""
        txtPlayer.Text = ""
        Me.txtCommandOut.Text = ""
        Me.ResumeLayout()
    End Sub

    Private Sub pbCopyCmd_Click() Handles pbCopyCmd.Click, txtCommandOut.DoubleClick
        My.Computer.Clipboard.SetText(txtCommandOut.Text)
    End Sub

    Private Sub handlerc(sender As Object, e As EventArgs) Handles txtPlayer.DoubleClick, txtDuration.DoubleClick, txtNotes.DoubleClick, txtOtherReason.DoubleClick
        Try
            If TypeOf sender Is TextBox Then
                CType(sender, TextBox).Text = My.Computer.Clipboard.GetText
            Else
                Console.WriteLine("wt")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ld(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("tr-TR")
        Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("tr-TR")
    End Sub

    Private Sub LinkGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkGithub.LinkClicked
        Process.Start("https://github.com/ShimmyMySherbet/UnturnedBanFormatter")
    End Sub
End Class