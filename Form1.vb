Public Class Form1
    Dim reSleepTime As Integer
    Dim SleepTime As Integer
    Dim GivenTime As Integer
    Dim StartCnclTmrAfter As Integer
    Dim SleepNum As Integer
    Dim MousePosX As Decimal
    Dim MousePosY As Decimal
    Dim IsSleepTime As Boolean
    Dim EndTime As Date

    Const MAX_SLEEPTIME As Integer = 604800 '7 days, 168 hours

    'Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        progLoad()
    End Sub

    'Home -------------------------------------------------------------------------------
    'Start Button
    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        If (StartBtn.Text = "Start") Then
            LockControls()
            GivenTime = TimeSet(reSleepTime, SleepTime)
            OutputSetupStart(GivenTime)
            MainTmr.Enabled = True

            If (IsSleepTime = 0) Then
                SleepComputer()
            End If
        Else
            UnlockControls()
            MainTmr.Enabled = False
            OutputSetupStop(GivenTime)
        End If
    End Sub

    'Close Button
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

    'Main Timer
    Private Sub MainTmr_Tick(sender As Object, e As EventArgs) Handles MainTmr.Tick
        GivenTime = GivenTime - 1
        GivenTime = ProgBarUpdate(GivenTime)

        If (GivenTime = reSleepTime - StartCnclTmrAfter And IsSleepTime = False) Then
            Notifier.Text = Now.ToShortTimeString + ": SS active..."
            ' MouseCheck = False        NOT IN USE, Check for mouse1 press
            EndTime = TimeOfDay.AddSeconds(GivenTime)
            TmeClock.Text = EndTime.ToShortTimeString
            MousePosX = MousePosition.X
            MousePosY = MousePosition.Y
            CancelTmr.Enabled = True
        End If
    End Sub

    'Cancel Timer (SmartSleep)
    Private Sub CancelTmr_Tick(sender As Object, e As EventArgs) Handles CancelTmr.Tick
        If (MousePosition.X > (MousePosX + 150)) Or (MousePosition.X < (MousePosX - 150)) Or (MousePosition.Y > (MousePosY + 150)) Or (MousePosition.Y < (MousePosY - 150)) Then
            UnlockControls()
            MainTmr.Enabled = False
            OutputSetupStop(GivenTime)
            CancelTmr.Enabled = False
        End If
    End Sub

    'Time -------------------------------------------------------------------------------
    're-sleep timer +15 sec
    Private Sub RSup15_Click(sender As Object, e As EventArgs) Handles RSup15.Click
        If (reSleepTime + 15 <= 600) Then
            reSleepTime += 15
            ResetActiveLabels(reSleepTime, SleepTime)
        End If
    End Sub

    're-sleep timer -15 sec
    Private Sub RSdown15_Click(sender As Object, e As EventArgs) Handles RSdown15.Click
        If (reSleepTime <> 30) Then
            reSleepTime -= 15
            ResetActiveLabels(reSleepTime, SleepTime)
        End If
    End Sub

    're-sleep timer +1 min
    Private Sub RSup1_Click(sender As Object, e As EventArgs) Handles RSup1.Click
        If (reSleepTime + 60 <= 600) Then
            reSleepTime += 60
            ResetActiveLabels(reSleepTime, SleepTime)
        End If
    End Sub

    're-sleep timer -1 min
    Private Sub RSdown1_Click(sender As Object, e As EventArgs) Handles RSdown1.Click
        If (reSleepTime > 60) Then
            reSleepTime -= 60
            ResetActiveLabels(reSleepTime, SleepTime)
        End If
    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'sleep timer +15 min
    Private Sub Sup15_Click(sender As Object, e As EventArgs) Handles Sup15.Click
        If (SleepTime + 900 <= MAX_SLEEPTIME) Then
            SleepTime += 900
            ResetActiveLabels(reSleepTime, SleepTime)
        End If
    End Sub

    'sleep timer -15 min
    Private Sub Sdown15_Click(sender As Object, e As EventArgs) Handles Sdown15.Click
        If (SleepTime >= 900) Then
            SleepTime -= 900
            ResetActiveLabels(reSleepTime, SleepTime)
        End If
    End Sub

    'sleep timer +1 hour
    Private Sub Sup1_Click(sender As Object, e As EventArgs) Handles Sup1.Click
        If (SleepTime + 3600 <= MAX_SLEEPTIME) Then
            SleepTime += 3600
            ResetActiveLabels(reSleepTime, SleepTime)
        End If
    End Sub

    'sleep timer -1 hour
    Private Sub Sdown1_Click(sender As Object, e As EventArgs) Handles Sdown1.Click
        If (SleepTime > 3600) Then
            SleepTime -= 3600
            ResetActiveLabels(reSleepTime, SleepTime)
        End If
    End Sub
    'Functions
    '==============================================================================================
    Function progLoad()
        ' Loads all the label texts and loads predefined variables
        reSleepTime = 120
        SleepTime = 0
        GivenTime = 0
        StartCnclTmrAfter = 20
        SleepNum = My.Settings.SleepNum
        IsSleepTime = False
        EndTime = Now

        'home labels
        GivenTime = TimeSet(reSleepTime, SleepTime)
        'active labels
        ResetActiveLabels(reSleepTime, SleepTime)
        'time and time remaining
        TmeTot.Text = formatTime(GivenTime)
        TmeRem.Text = formatTime(GivenTime)
        'clock
        TmeClock.Text = "N/A"

        'timeTab time labels
        T_rSleepLbl.Text = formatTime(reSleepTime)
        T_sleepLbl.Text = formatTime(SleepTime)

        VersionNum.Text = "2.0.1.7 Pre-Release"
        Notifier.Text = Now.ToShortTimeString + ": program loaded!"
    End Function

    Function formatTime(inputSeconds) As String
        ' Returns the time as formatted in Hours:Minutes:Seconds
        Dim returningSentence As String
        Dim hour As Int16
        Dim min As Int16
        Dim sec As Int16
        hour = Math.Floor(inputSeconds / 3600)
        min = Math.Floor((inputSeconds - (hour * 3600)) / 60)
        sec = inputSeconds Mod 60
        returningSentence = hour.ToString("D2") + " : " + min.ToString("D2") + " : " + sec.ToString("D2")
        Return returningSentence
    End Function

    Function LockControls()
        'Locks proper controls on home page
        TabControl.TabPages.Remove(TabTime)
        TabControl.TabPages.Remove(TabSettings)
        TabControl.TabPages.Remove(TabRecords)
        TabControl.TabPages.Remove(TabSupport)
        'bottom button
        StartBtn.Text = "Stop"
    End Function

    Function UnlockControls()
        'Unlocks controls on home page
        TabControl.TabPages.Insert(1, TabTime)
        TabControl.TabPages.Insert(2, TabSettings)
        TabControl.TabPages.Insert(3, TabRecords)
        TabControl.TabPages.Insert(4, TabSupport)
        'bottom button
        StartBtn.Text = "Start"
    End Function

    Function TimeSet(reSleep As Integer, Sleep As Integer) As Integer
        'Sets the given time
        Dim time As Integer
        If (SleepTime <> 0) Then
            time = SleepTime
            IsSleepTime = True
        Else
            time = reSleepTime
            IsSleepTime = False
        End If
        Return time
    End Function

    Function OutputSetupStart(time As Integer)
        'Output label setup for when the start button is pressed

        'active Labels
        If (time = SleepTime) Then
            H_sleepLbl.BackColor = Color.DeepSkyBlue
            H_sleepLbl.Text = "Active"
        ElseIf (time = reSleepTime) Then
            H_rSleepLbl.BackColor = Color.DeepSkyBlue
            H_rSleepLbl.Text = "Active"
        End If

        'progress bar
        TimeBar.Maximum = time
        TimeBar.Value = time
        'top labels
        TmeTot.Text = formatTime(time)
        TmeRem.Text = formatTime(time)
        'bottom clock label
        If (time = SleepTime) Then  'End sleep timer time.
            EndTime = TimeOfDay.AddSeconds(time)
            TmeClock.Text = EndTime.ToShortTimeString
        End If
    End Function

    Function OutputSetupStop(time As Integer)
        'Output label setup for when the stop button is pressed

        'Active labels
        ResetActiveLabels(reSleepTime, SleepTime)
        'progress bar
        TimeBar.Maximum = time
        TimeBar.Value = time
        'top labels
        If (IsSleepTime = True) Then
            TmeTot.Text = formatTime(SleepTime)
        Else
            TmeTot.Text = formatTime(reSleepTime)
        End If
        TmeRem.Text = formatTime(time)
        'bottom clock label
        TmeClock.Text = "N/A"
    End Function

    Function ResetActiveLabels(reSleep As Integer, sleep As Integer)
        'Resets the active labels to their correct status
        'resleep label
        If (reSleep <> 0) Then
            H_rSleepLbl.BackColor = Color.Lime
            H_rSleepLbl.Text = "Enabled"
            ' time tab
            T_rSleepLbl.BackColor = Color.Lime
        Else
            H_rSleepLbl.BackColor = Color.Firebrick
            H_rSleepLbl.Text = "Disabled"
            'time tab
            T_rSleepLbl.BackColor = Color.Firebrick
        End If
        T_rSleepLbl.Text = formatTime(reSleepTime)

        'sleep label
        If (sleep <> 0) Then
            H_sleepLbl.BackColor = Color.Lime
            H_sleepLbl.Text = "Enabled"
            ' time tab
            T_sleepLbl.BackColor = Color.Lime
        Else
            H_sleepLbl.BackColor = Color.Firebrick
            H_sleepLbl.Text = "Disabled"
            'time tab
            T_sleepLbl.BackColor = Color.Firebrick
        End If
        T_sleepLbl.Text = formatTime(SleepTime)
    End Function

    Function ProgBarUpdate(time As Integer) As Integer
        ' commands needed to be ran after every tick (second)

        TimeBar.Value = time
        TmeRem.Text = formatTime(time)

        If (time = 0 And IsSleepTime = True) Then   'Sleep timer end
            time = reSleepTime
            SleepTime = 0
            IsSleepTime = False
            OutputSetupStart(time)
            ResetActiveLabels(time, SleepTime)
            H_rSleepLbl.BackColor = Color.DeepSkyBlue
            H_rSleepLbl.Text = "Active"
            SleepComputer() '==SLEEP==

        ElseIf (time = 0) Then                      'ReSleep timer end
            MainTmr.Enabled = 0
            time = TimeSet(reSleepTime, SleepTime)
            OutputSetupStart(time)
            MainTmr.Enabled = 1
            SleepComputer() '==SLEEP==
        End If
        Return time
    End Function

    Function SleepComputer()
        My.Settings.SleepNum = My.Settings.SleepNum + 1
        My.Settings.Save()
        Notifier.Text = Now.ToShortTimeString + ": sleeping.. (#" + My.Settings.SleepNum.ToString() + ")"
        Shell("shutdown -h")
    End Function



    'Deletes Sleep Count (temp)
    Private Sub DeleteData_Click(sender As Object, e As EventArgs) Handles DeleteData.Click
        My.Settings.SleepNum = 0
        My.Settings.Save()
    End Sub
End Class
