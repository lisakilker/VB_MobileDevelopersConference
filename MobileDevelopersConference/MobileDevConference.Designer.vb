<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMobileDevConference
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picPicture = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCorpID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblNumOfDays = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtCorpID = New System.Windows.Forms.TextBox()
        Me.txtNumOfDays = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.gboPreConference = New System.Windows.Forms.GroupBox()
        Me.radStoreTrack = New System.Windows.Forms.RadioButton()
        Me.radAndroidTrack = New System.Windows.Forms.RadioButton()
        Me.gboCourses = New System.Windows.Forms.GroupBox()
        Me.radDatabases = New System.Windows.Forms.RadioButton()
        Me.radDesign = New System.Windows.Forms.RadioButton()
        Me.radSecurity = New System.Windows.Forms.RadioButton()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboPreConference.SuspendLayout()
        Me.gboCourses.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPicture
        '
        Me.picPicture.Image = Global.MobileDevelopersConference.My.Resources.Resources.Mobile
        Me.picPicture.Location = New System.Drawing.Point(161, 3)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(263, 105)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPicture.TabIndex = 0
        Me.picPicture.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(147, 111)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(291, 58)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Mobile Developer's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conference Registration"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCorpID
        '
        Me.lblCorpID.AutoSize = True
        Me.lblCorpID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorpID.Location = New System.Drawing.Point(187, 196)
        Me.lblCorpID.Name = "lblCorpID"
        Me.lblCorpID.Size = New System.Drawing.Size(104, 16)
        Me.lblCorpID.TabIndex = 2
        Me.lblCorpID.Text = "Corporation ID:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(16, 241)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 16)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name:"
        '
        'lblNumOfDays
        '
        Me.lblNumOfDays.AutoSize = True
        Me.lblNumOfDays.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfDays.Location = New System.Drawing.Point(16, 279)
        Me.lblNumOfDays.Name = "lblNumOfDays"
        Me.lblNumOfDays.Size = New System.Drawing.Size(112, 16)
        Me.lblNumOfDays.TabIndex = 4
        Me.lblNumOfDays.Text = "Number of Days:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(293, 238)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(79, 16)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Last Name:"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblDisplay.Location = New System.Drawing.Point(212, 478)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(54, 16)
        Me.lblDisplay.TabIndex = 6
        Me.lblDisplay.Text = "Display"
        Me.lblDisplay.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Coral
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(154, 427)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(131, 36)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate Costs"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Coral
        Me.btnClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(320, 427)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 36)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(102, 238)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(173, 22)
        Me.txtFirstName.TabIndex = 2
        '
        'txtCorpID
        '
        Me.txtCorpID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorpID.Location = New System.Drawing.Point(297, 193)
        Me.txtCorpID.Name = "txtCorpID"
        Me.txtCorpID.Size = New System.Drawing.Size(100, 22)
        Me.txtCorpID.TabIndex = 1
        '
        'txtNumOfDays
        '
        Me.txtNumOfDays.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOfDays.Location = New System.Drawing.Point(134, 276)
        Me.txtNumOfDays.Name = "txtNumOfDays"
        Me.txtNumOfDays.Size = New System.Drawing.Size(42, 22)
        Me.txtNumOfDays.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(378, 236)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(176, 22)
        Me.txtLastName.TabIndex = 3
        '
        'gboPreConference
        '
        Me.gboPreConference.Controls.Add(Me.radStoreTrack)
        Me.gboPreConference.Controls.Add(Me.radAndroidTrack)
        Me.gboPreConference.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboPreConference.Location = New System.Drawing.Point(118, 316)
        Me.gboPreConference.Name = "gboPreConference"
        Me.gboPreConference.Size = New System.Drawing.Size(167, 94)
        Me.gboPreConference.TabIndex = 13
        Me.gboPreConference.TabStop = False
        Me.gboPreConference.Text = "Pre-Conference"
        '
        'radStoreTrack
        '
        Me.radStoreTrack.AutoSize = True
        Me.radStoreTrack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStoreTrack.Location = New System.Drawing.Point(7, 62)
        Me.radStoreTrack.Name = "radStoreTrack"
        Me.radStoreTrack.Size = New System.Drawing.Size(150, 20)
        Me.radStoreTrack.TabIndex = 6
        Me.radStoreTrack.TabStop = True
        Me.radStoreTrack.Text = "Windows Store Track"
        Me.radStoreTrack.UseVisualStyleBackColor = True
        '
        'radAndroidTrack
        '
        Me.radAndroidTrack.AutoSize = True
        Me.radAndroidTrack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAndroidTrack.Location = New System.Drawing.Point(7, 24)
        Me.radAndroidTrack.Name = "radAndroidTrack"
        Me.radAndroidTrack.Size = New System.Drawing.Size(115, 36)
        Me.radAndroidTrack.TabIndex = 5
        Me.radAndroidTrack.Text = "Pre-Conference" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Android Track"
        Me.radAndroidTrack.UseVisualStyleBackColor = True
        '
        'gboCourses
        '
        Me.gboCourses.Controls.Add(Me.radDatabases)
        Me.gboCourses.Controls.Add(Me.radDesign)
        Me.gboCourses.Controls.Add(Me.radSecurity)
        Me.gboCourses.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboCourses.Location = New System.Drawing.Point(320, 313)
        Me.gboCourses.Name = "gboCourses"
        Me.gboCourses.Size = New System.Drawing.Size(171, 97)
        Me.gboCourses.TabIndex = 14
        Me.gboCourses.TabStop = False
        Me.gboCourses.Text = "Courses"
        Me.gboCourses.Visible = False
        '
        'radDatabases
        '
        Me.radDatabases.AutoSize = True
        Me.radDatabases.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDatabases.Location = New System.Drawing.Point(7, 71)
        Me.radDatabases.Name = "radDatabases"
        Me.radDatabases.Size = New System.Drawing.Size(130, 20)
        Me.radDatabases.TabIndex = 9
        Me.radDatabases.TabStop = True
        Me.radDatabases.Text = "Mobile Databases"
        Me.radDatabases.UseVisualStyleBackColor = True
        '
        'radDesign
        '
        Me.radDesign.AutoSize = True
        Me.radDesign.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDesign.Location = New System.Drawing.Point(7, 49)
        Me.radDesign.Name = "radDesign"
        Me.radDesign.Size = New System.Drawing.Size(108, 20)
        Me.radDesign.TabIndex = 8
        Me.radDesign.TabStop = True
        Me.radDesign.Text = "Mobile Design"
        Me.radDesign.UseVisualStyleBackColor = True
        '
        'radSecurity
        '
        Me.radSecurity.AutoSize = True
        Me.radSecurity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSecurity.Location = New System.Drawing.Point(7, 28)
        Me.radSecurity.Name = "radSecurity"
        Me.radSecurity.Size = New System.Drawing.Size(116, 20)
        Me.radSecurity.TabIndex = 7
        Me.radSecurity.TabStop = True
        Me.radSecurity.Text = "Mobile Security"
        Me.radSecurity.UseVisualStyleBackColor = True
        '
        'frmMobileDevConference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 509)
        Me.Controls.Add(Me.gboCourses)
        Me.Controls.Add(Me.gboPreConference)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtNumOfDays)
        Me.Controls.Add(Me.txtCorpID)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblNumOfDays)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblCorpID)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picPicture)
        Me.Name = "frmMobileDevConference"
        Me.Text = "Register Today!"
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboPreConference.ResumeLayout(False)
        Me.gboPreConference.PerformLayout()
        Me.gboCourses.ResumeLayout(False)
        Me.gboCourses.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPicture As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCorpID As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblNumOfDays As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtCorpID As System.Windows.Forms.TextBox
    Friend WithEvents txtNumOfDays As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents gboPreConference As System.Windows.Forms.GroupBox
    Friend WithEvents radStoreTrack As System.Windows.Forms.RadioButton
    Friend WithEvents radAndroidTrack As System.Windows.Forms.RadioButton
    Friend WithEvents gboCourses As System.Windows.Forms.GroupBox
    Friend WithEvents radDatabases As System.Windows.Forms.RadioButton
    Friend WithEvents radDesign As System.Windows.Forms.RadioButton
    Friend WithEvents radSecurity As System.Windows.Forms.RadioButton

End Class
