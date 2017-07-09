Option Strict On

Public Class frmMobileDevConference

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCorpID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtNumOfDays.Clear()
        lblDisplay.Visible = False
        radAndroidTrack.Checked = False
        radStoreTrack.Checked = False
        radSecurity.Checked = False
        radDesign.Checked = False
        radDatabases.Checked = False
        lblDisplay.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim objConferenceAttendee As ConferenceAttendee
        Dim objCourseAttendee As CourseAttendee
        Dim InputError As Boolean = False

        If Not IsNumeric(txtCorpID.Text) Then
            MsgBox("Please enter a numeric value for your Corporation ID", , "Entry Error")
            txtCorpID.Clear()
            txtCorpID.Focus()
            InputError = True

        ElseIf Convert.ToInt32(txtCorpID.TextLength) < 1 Or Convert.ToInt32(txtCorpID.TextLength) > 5 Then
            MsgBox("Please enter your Corporation ID", , "Entry Error")
            txtCorpID.Clear()
            txtCorpID.Focus()
            InputError = True

        ElseIf txtFirstName.TextLength < 1 Or txtFirstName.Text < "A" Then
            MsgBox("Please enter your first name", , "Entry Error")
            txtFirstName.Clear()
            txtFirstName.Focus()
            InputError = True

        ElseIf txtLastName.TextLength < 1 Or txtLastName.Text < "A" Then
            MsgBox("Please enter your last name", , "Entry Error")
            txtLastName.Clear()
            txtLastName.Focus()
            InputError = True

        ElseIf Not IsNumeric(txtNumOfDays.Text) Then
            MsgBox("Number of Days must be in numeric form", , "Entry Error")
            txtNumOfDays.Clear()
            txtNumOfDays.Focus()
            InputError = True

        ElseIf Convert.ToInt32(txtNumOfDays.Text) < 1 Or Convert.ToInt32(txtNumOfDays.Text) > 4 Then
            MsgBox("Please enter the number of day you'll be attending", , "Entry Error")
            txtNumOfDays.Clear()
            txtNumOfDays.Focus()
            InputError = True

        ElseIf radAndroidTrack.Checked = False And radStoreTrack.Checked = False Then
            MsgBox("Please select a conference type", , "Entry Error")
            radAndroidTrack.Checked = False
            radStoreTrack.Checked = False
            InputError = True
        End If

        If Not InputError Then

            If radSecurity.Checked = False And radDesign.Checked = False And radDatabases.Checked = False Then
                objConferenceAttendee = New ConferenceAttendee(txtCorpID.Text, txtFirstName.Text, txtLastName.Text, txtNumOfDays.Text)
                lblDisplay.Visible = True
                lblDisplay.Text = "Your total cost is:  " & (objConferenceAttendee.ComputeCosts()).ToString("C2")

            Else
                objCourseAttendee = New CourseAttendee(txtCorpID.Text, txtFirstName.Text, txtLastName.Text, txtNumOfDays.Text, radAndroidTrack.Checked, radStoreTrack.Checked, radSecurity.Checked, radDesign.Checked, radDatabases.Checked)
                lblDisplay.Visible = True
                lblDisplay.Text = "Your total cost is:  " & (objCourseAttendee.ComputeCosts()).ToString("C2")

            End If
        End If
    End Sub

    Private Sub radAndroidTrack_CheckedChanged(sender As Object, e As EventArgs) Handles radAndroidTrack.CheckedChanged
        gboCourses.Visible = True
    End Sub

    Private Sub radStoreTrack_CheckedChanged(sender As Object, e As EventArgs) Handles radStoreTrack.CheckedChanged
        gboCourses.Visible = True
    End Sub
End Class
