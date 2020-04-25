Public Class UI
    Dim CBDict As New Dictionary(Of CheckBox, String)
    Dim NoteDict As New Dictionary(Of CheckBox, String)

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
        {cbChangeName, "Chaneg Name"},
        {cbReadRules, "Read Rules"},
        {cb_FalseRaid, "False Raid"}}
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
    Public ModifierIndex As New Dictionary(Of List(Of String), KeyValuePair(Of String, Double)) From {
        {New List(Of String) From
        {
            "s", "sec", "seconds", "second"
        }, New KeyValuePair(Of String, Double)("Second", 1)},
        {New List(Of String) From
        {
            "m", "min", "minute", "minutes"
        }, New KeyValuePair(Of String, Double)("Minute", 60)},
        {New List(Of String) From
        {
            "h", "hour", "ho", "hr", "hours", "hrs", "hs"
        }, New KeyValuePair(Of String, Double)("Hour", 60 * 60)},
        {New List(Of String) From
        {
            "d", "day", "dy", "ds", "days", "dys"
        }, New KeyValuePair(Of String, Double)("Day", 60 * 60 * 24)},
        {New List(Of String) From
        {
            "w", "week", "weeks", "wks"
        }, New KeyValuePair(Of String, Double)("Week", 60 * 60 * 24 * 7)},
        {New List(Of String) From
        {
            "y", "year", "years", "yr", "yrs"
        }, New KeyValuePair(Of String, Double)("Year", 60 * 60 * 24 * 365)},
        {New List(Of String) From
        {
            "p", "pm", "perm", "inf", "forever", ""
        }, New KeyValuePair(Of String, Double)("Perm", -1)}
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
        Dim mdr As KeyValuePair(Of String, Double) = New KeyValuePair(Of String, Double)("Perm", -1)
        For Each modi In ModifierIndex
            If modi.Key.Contains(Modifier) Then
                mdr = modi.Value
                If modi.Value.Key = "Perm" Then
                    Seconds = -2
                Else
                    Seconds = vls.Key * modi.Value.Value
                End If
                Exit For
            End If
        Next
        Dim resptxt As String = ""
        If Seconds = -1 Or Seconds = -2 Then
            resptxt = "Perm"
        Else
            resptxt = Math.Round(vls.Key, 1) & " " & mdr.Key & (Plurify(vls.Key))
        End If
        Console.WriteLine("Bylen")
        Return New KeyValuePair(Of Long, String)(Seconds, resptxt)
    End Function

    Public Function ParseFromFunct(vls As KeyValuePair(Of Double, String)) As KeyValuePair(Of Long, String)
        Console.WriteLine("funct")
        Dim dur As Double = vls.Key
        Dim nam As String = ""
        Select Case True
            Case dur >= 60 * 60 * 24 * 365
                'years
                Dim yrs As Double = Math.Round(dur / (60 * 60 * 24 * 365), 1)
                nam = $"{yrs} Year{Plurify(yrs)}"
            Case dur >= 60 * 60 * 24 * 7
                'week
                Dim yrs As Double = Math.Round(dur / (60 * 60 * 24 * 7), 1)
                nam = $"{yrs} Week{Plurify(yrs)}"
            Case dur >= 60 * 60 * 24
                'day
                Dim yrs As Double = Math.Round(dur / (60 * 60 * 24), 1)
                nam = $"{yrs} Day{Plurify(yrs)}"
            Case dur >= 60 * 60
                'hour
                Dim yrs As Double = Math.Round(dur / (60 * 60), 1)
                nam = $"{yrs} Hour{Plurify(yrs)}"
            Case dur >= 60
                'min
                Dim yrs As Double = Math.Round(dur / 60, 1)
                nam = $"{yrs} Minute{Plurify(yrs)}"
            Case Else
                'sec
                Dim yrs As Double = Math.Round(dur, 1)
                nam = $"{yrs} Second{Plurify(yrs)}"
        End Select
        Return New KeyValuePair(Of Long, String)(dur, nam)
    End Function

    Private Function Plurify(dur As Double) As String
        Console.WriteLine($"Plur>rec::{dur}")
        If dur > 1 Then
            Return "s"
        Else
            Return ""
        End If
    End Function
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
End Class