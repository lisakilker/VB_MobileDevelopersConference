Public Class ConferenceCostsFile

    Private _intCorpID As Integer
    Private _strFirstName As String
    Private _strLastName As String
    Private _strConferenceType As String
    Private _strCourseType As String
    Private _storeTrack As Boolean
    Private _androidTrack As Boolean
    Private _security As Boolean
    Private _design As Boolean
    Private _databases As Boolean
    Private _decCost As Decimal

    Sub New(ByVal CorpId As String, FirstName As String, LastName As String, ByVal Cost As Decimal, ByVal Windows As Boolean, _
              ByVal Android As Boolean, ByVal Security As Boolean, ByVal Design As Boolean, ByVal Databases As Boolean)

        _intCorpID = CorpId
        _strFirstName = FirstName
        _strLastName = LastName
        _decCost = Cost
        _security = Security
        _design = Design
        _databases = Databases
        _storeTrack = Windows
        _androidTrack = Android

        If _storeTrack Then
            _strConferenceType = "Windows Store Track"
        ElseIf _androidTrack Then
            _strConferenceType = "Android Track"
        End If

        If _security Then
            _strCourseType = "Mobile Security"
        ElseIf _design Then
            _strCourseType = "Mobile Design"
        ElseIf _databases Then
            _strCourseType = "Mobile Database"
        End If

    End Sub

    Sub WriteRecord()

        Dim strNameAndLocationOfFile As String = "C:\Users\LisaKilker\Documents\Visual Studio 2012\Projects\MobileDevelopersConference\MobileDevs.txt"

        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strNameAndLocationOfFile)

            objWriter.Write(_intCorpID & ",")
            objWriter.Write(_strFirstName & ",")
            objWriter.Write(_strLastName & ",")
            objWriter.Write(_strConferenceType & ",")
            objWriter.Write(_strCourseType & ",")
            objWriter.WriteLine(_decCost & ",")
            objWriter.Close()

        Catch ex As Exception
            MsgBox("That file does not exist")
            Application.Exit()
        End Try



    End Sub

End Class
