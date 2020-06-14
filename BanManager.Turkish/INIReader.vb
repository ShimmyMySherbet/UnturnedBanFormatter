Public Class INIFile
    Private Data As New List(Of IniLine)
    Private LoadFile As String = ""
    Private _changed As Boolean = False
    Public ReadOnly Property FileModified
        Get
            Return _changed
        End Get
    End Property
    Public Sub New(Optional file As String = "")
        If file <> "" Then
            Dim ioinf As New IO.FileInfo(file)
            If ioinf.Exists Then
                file = ioinf.FullName
                LoadFile = file
                For Each line In IO.File.ReadAllLines(file)
                    If Not line.StartsWith("#") And line <> "" And line.Contains("=") Then
                        Dim Key As String = line.Split("=")(0)
                        Dim Value As String = line.Remove(0, Key.Length + 1)
                        Data.Add(New IniLine With {
                              .Key = Key,
                              .Value = Value,
                              .IsDataEntry = True,
                              .Line = ""})
                    Else
                        Data.Add(New IniLine With {
                              .IsDataEntry = False,
                              .Line = line})
                    End If
                Next
            Else
                LoadFile = file
            End If

        End If
    End Sub
    Public ReadOnly Property INIFileLineCount
        Get
            Return Data.Count
        End Get
    End Property
    Public ReadOnly Property Keys As List(Of String)
        Get
            Dim res As New List(Of String)
            Data.ForEach(Sub(x)
                             If x.IsDataEntry Then
                                 res.Add(x.Key)
                             End If
                         End Sub)
            Return res
        End Get
    End Property
    Public ReadOnly Property Values As List(Of String)
        Get
            Dim res As New List(Of String)
            Data.ForEach(Sub(x)
                             If x.IsDataEntry Then
                                 res.Add(x.Value)
                             End If
                         End Sub)
            Return res
        End Get
    End Property
    Default Public Property Value(Key As String) As String
        Get
            Return Data.Where(Function(x)
                                  If x.IsDataEntry Then
                                      Return x.Key.ToLower = Key.ToLower
                                  Else
                                      Return False
                                  End If
                              End Function).First().Value
        End Get
        Set(value As String)
            Dim found As Boolean = False
            For Each x In Data
                If x.IsDataEntry Then
                    If x.Key.ToLower = Key.ToLower Then
                        x.Value = value
                        found = True
                        Exit For
                    End If
                End If
            Next
            If Not found Then
                Data.Add(New IniLine With {
                         .IsDataEntry = True,
                         .Key = Key,
                         .Value = value,
                         .Line = ""})
            End If
            _changed = True
        End Set
    End Property
    Public Sub WriteComment(Comment As String)
        Data.Add(New IniLine With {
                 .IsDataEntry = False, .Line = "#" & Comment})
        _changed = True
    End Sub
    Public Sub WriteLine(Optional Line As String = "")
        Data.Add(New IniLine With {
                .IsDataEntry = False, .Line = Line})
        _changed = True
    End Sub
    Public ReadOnly Property DataDictionary As Dictionary(Of String, String)
        Get
            Dim dict As New Dictionary(Of String, String)
            For Each x In Data
                If x.IsDataEntry Then
                    dict.Add(x.Key, x.Value)
                End If
            Next
            Return dict
        End Get
    End Property
    Public Function KeySet(Key As String) As Boolean
        Dim ret As Boolean = False
        For Each x In Data
            If x.IsDataEntry Then
                If x.Key.ToLower = Key.ToLower Then
                    ret = True
                End If
            End If
        Next
        Return ret
    End Function
    Public Sub Save(Optional File As String = "", Optional Overwrite As Boolean = True)
        If File = "" Then
            If LoadFile <> "" Then
                File = LoadFile
            Else
                Throw New Exception("Cannot save; no specified file or load file.")
            End If
        End If
        If Overwrite Then
            IO.File.WriteAllText(File, ToINIString())
        Else
            IO.File.AppendAllLines(File, IniLines())
        End If
        _changed = False
    End Sub
    Public Sub Save(Stream As IO.Stream, Optional Encoding As System.Text.Encoding = Nothing)
        If Encoding Is Nothing Then
            Encoding = System.Text.Encoding.UTF8
        End If
        Dim Bytes() As Byte = Encoding.GetBytes(ToINIString())
        Stream.Write(Bytes, 0, Bytes.Count)
        _changed = False
    End Sub
    Public Function ToINIString() As String
        Dim Lines As New List(Of String)
        For Each entry In Data
            If entry.IsDataEntry Then
                Lines.Add($"{entry.Key}={entry.Value}")
            Else
                Lines.Add(entry.Line)
            End If
        Next
        Return String.Join(vbNewLine, Lines)
    End Function
    Private Function IniLines() As List(Of String)
        Dim Lines As New List(Of String)
        For Each entry In Data
            If entry.IsDataEntry Then
                Lines.Add($"{entry.Key}={entry.Value}")
            Else
                Lines.Add(entry.Line)
            End If
        Next
        Return Lines
    End Function
    Private Class IniLine
        Public IsDataEntry As Boolean = False
        Public Line As String = ""
        Public Key As String = ""
        Public Value As String = ""
    End Class
End Class
