Option Strict On
Public Class CourseAttendee

    Inherits ConferenceAttendee

    Dim objConferenceCostsFile As ConferenceCostsFile

    Sub New(ByVal CorpID As String, ByVal FirstName As String, ByVal LastName As String, _
        ByVal NumOfDays As String, ByVal StoreTrack As Boolean, ByVal AndroidTrack As Boolean, ByVal Security As Boolean, ByVal Design As Boolean, ByVal Databases As Boolean)

        MyBase.New(CorpID, FirstName, LastName, NumOfDays)

        _storeTrack = StoreTrack
        _androidTrack = AndroidTrack
        _Security = Security
        _Design = Design
        _Databases = Databases

    End Sub

    Public Overrides Function ComputeCosts() As Decimal

        Dim CourseCost As Decimal

        If _Security Or _Design Or _Databases Then
            CourseCost = 675D
        End If

        _decCost = (_decConferenceCost * _intNumOfDays) + CourseCost

        objConferenceCostsFile = New ConferenceCostsFile(_intCorpID.ToString(), _strFirstName, _strLastName, _decCost, _storeTrack, _androidTrack, _Security, _
                                                 _Design, _Databases)
        objConferenceCostsFile.WriteRecord()

        Return _decCost

    End Function
End Class
