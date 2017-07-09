Option Strict On
Public Class ConferenceAttendee

    Protected _intCorpID As Integer
    Protected _strFirstName As String
    Protected _strLastName As String
    Protected _intNumOfDays As Integer
    Protected _decCost As Decimal
    Protected _storeTrack As Boolean
    Protected _androidTrack As Boolean
    Protected _security As Boolean
    Protected _design As Boolean
    Protected _databases As Boolean
    Protected _decConferenceCost As Decimal = 350D

    Dim objConferenceCostsFile As ConferenceCostsFile

    Sub New(ByVal intCorpID As String, ByVal strFirstName As String, ByVal strLastName As String, _
        ByVal intNumOfDays As String)

        _intCorpID = Convert.ToInt32(intCorpID)
        _strFirstName = strFirstName
        _strLastName = strLastName
        _intNumOfDays = Convert.ToInt32(intNumOfDays)

    End Sub

    Overridable Function ComputeCosts() As Decimal

        _decCost = _intNumOfDays * _decConferenceCost

        objConferenceCostsFile = New ConferenceCostsFile(_intCorpID.ToString(), _strFirstName, _strLastName, _decCost, _storeTrack, _androidTrack, _security, _
                                                 _design, _databases)
        objConferenceCostsFile.WriteRecord()

        Return _decCost

    End Function
End Class


