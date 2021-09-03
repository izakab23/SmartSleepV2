<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabHome = New System.Windows.Forms.TabPage()
        Me.Notifier = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TmeClock = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.H_sleepLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.H_rSleepLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TmeTot = New System.Windows.Forms.Label()
        Me.TmeRem = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.TimeBar = New System.Windows.Forms.ProgressBar()
        Me.TabTime = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.T_rSleepLbl = New System.Windows.Forms.Label()
        Me.T_sleepLbl = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Sdown1 = New System.Windows.Forms.Button()
        Me.Sup1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Sdown15 = New System.Windows.Forms.Button()
        Me.Sup15 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RSdown1 = New System.Windows.Forms.Button()
        Me.RSup1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RSdown15 = New System.Windows.Forms.Button()
        Me.RSup15 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.TabRecords = New System.Windows.Forms.TabPage()
        Me.TabSupport = New System.Windows.Forms.TabPage()
        Me.VersionNum = New System.Windows.Forms.Label()
        Me.MainTmr = New System.Windows.Forms.Timer(Me.components)
        Me.CancelTmr = New System.Windows.Forms.Timer(Me.components)
        Me.DeleteData = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.TabHome.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTime.SuspendLayout()
        Me.TabRecords.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabHome)
        Me.TabControl.Controls.Add(Me.TabTime)
        Me.TabControl.Controls.Add(Me.TabSettings)
        Me.TabControl.Controls.Add(Me.TabRecords)
        Me.TabControl.Controls.Add(Me.TabSupport)
        Me.TabControl.Location = New System.Drawing.Point(-5, 0)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Padding = New System.Drawing.Point(10, 5)
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(389, 411)
        Me.TabControl.TabIndex = 0
        '
        'TabHome
        '
        Me.TabHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabHome.Controls.Add(Me.Notifier)
        Me.TabHome.Controls.Add(Me.Label5)
        Me.TabHome.Controls.Add(Me.Label2)
        Me.TabHome.Controls.Add(Me.Label3)
        Me.TabHome.Controls.Add(Me.TmeClock)
        Me.TabHome.Controls.Add(Me.Label6)
        Me.TabHome.Controls.Add(Me.H_sleepLbl)
        Me.TabHome.Controls.Add(Me.Label4)
        Me.TabHome.Controls.Add(Me.H_rSleepLbl)
        Me.TabHome.Controls.Add(Me.PictureBox1)
        Me.TabHome.Controls.Add(Me.TmeTot)
        Me.TabHome.Controls.Add(Me.TmeRem)
        Me.TabHome.Controls.Add(Me.Label9)
        Me.TabHome.Controls.Add(Me.CloseBtn)
        Me.TabHome.Controls.Add(Me.Label1)
        Me.TabHome.Controls.Add(Me.StartBtn)
        Me.TabHome.Controls.Add(Me.TimeBar)
        Me.TabHome.Location = New System.Drawing.Point(4, 26)
        Me.TabHome.Name = "TabHome"
        Me.TabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHome.Size = New System.Drawing.Size(381, 381)
        Me.TabHome.TabIndex = 0
        Me.TabHome.Text = "Home"
        Me.TabHome.ToolTipText = "Shows primary timers"
        '
        'Notifier
        '
        Me.Notifier.AutoSize = True
        Me.Notifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notifier.ForeColor = System.Drawing.Color.DarkGray
        Me.Notifier.Location = New System.Drawing.Point(15, 309)
        Me.Notifier.Name = "Notifier"
        Me.Notifier.Size = New System.Drawing.Size(55, 18)
        Me.Notifier.TabIndex = 60
        Me.Notifier.Text = "Notifier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(158, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(50, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 25)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Time Remaining:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(13, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "________________________________________"
        '
        'TmeClock
        '
        Me.TmeClock.AutoSize = True
        Me.TmeClock.Cursor = System.Windows.Forms.Cursors.Default
        Me.TmeClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TmeClock.ForeColor = System.Drawing.Color.Gainsboro
        Me.TmeClock.Location = New System.Drawing.Point(229, 270)
        Me.TmeClock.Name = "TmeClock"
        Me.TmeClock.Size = New System.Drawing.Size(108, 25)
        Me.TmeClock.TabIndex = 56
        Me.TmeClock.Text = "TmeClock"
        Me.TmeClock.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(13, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 25)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Estimated End Time:"
        '
        'H_sleepLbl
        '
        Me.H_sleepLbl.BackColor = System.Drawing.Color.Firebrick
        Me.H_sleepLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H_sleepLbl.ForeColor = System.Drawing.Color.Black
        Me.H_sleepLbl.Location = New System.Drawing.Point(177, 61)
        Me.H_sleepLbl.Name = "H_sleepLbl"
        Me.H_sleepLbl.Size = New System.Drawing.Size(79, 20)
        Me.H_sleepLbl.TabIndex = 53
        Me.H_sleepLbl.Text = "Disabled"
        Me.H_sleepLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(41, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 24)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Sleep Timer:"
        '
        'H_rSleepLbl
        '
        Me.H_rSleepLbl.BackColor = System.Drawing.Color.Lime
        Me.H_rSleepLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H_rSleepLbl.ForeColor = System.Drawing.Color.Black
        Me.H_rSleepLbl.Location = New System.Drawing.Point(177, 28)
        Me.H_rSleepLbl.Name = "H_rSleepLbl"
        Me.H_rSleepLbl.Size = New System.Drawing.Size(79, 20)
        Me.H_rSleepLbl.TabIndex = 50
        Me.H_rSleepLbl.Text = "Enabled"
        Me.H_rSleepLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SSv2.My.Resources.Resources.SSIcon
        Me.PictureBox1.Location = New System.Drawing.Point(278, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'TmeTot
        '
        Me.TmeTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TmeTot.AutoSize = True
        Me.TmeTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TmeTot.ForeColor = System.Drawing.Color.Gainsboro
        Me.TmeTot.Location = New System.Drawing.Point(229, 120)
        Me.TmeTot.Name = "TmeTot"
        Me.TmeTot.Size = New System.Drawing.Size(85, 25)
        Me.TmeTot.TabIndex = 19
        Me.TmeTot.Text = "TmeTot"
        Me.TmeTot.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TmeRem
        '
        Me.TmeRem.AutoSize = True
        Me.TmeRem.Cursor = System.Windows.Forms.Cursors.Default
        Me.TmeRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TmeRem.ForeColor = System.Drawing.Color.Gainsboro
        Me.TmeRem.Location = New System.Drawing.Point(229, 164)
        Me.TmeRem.Name = "TmeRem"
        Me.TmeRem.Size = New System.Drawing.Size(98, 25)
        Me.TmeRem.TabIndex = 18
        Me.TmeRem.Text = "TmeRem"
        Me.TmeRem.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(8, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 24)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Re-Sleep Timer:"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CloseBtn.Location = New System.Drawing.Point(294, 350)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn.TabIndex = 14
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(-1, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "______________________________________________________________"
        '
        'StartBtn
        '
        Me.StartBtn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.StartBtn.Location = New System.Drawing.Point(213, 350)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(75, 23)
        Me.StartBtn.TabIndex = 11
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = False
        '
        'TimeBar
        '
        Me.TimeBar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TimeBar.Location = New System.Drawing.Point(12, 209)
        Me.TimeBar.MarqueeAnimationSpeed = 25
        Me.TimeBar.Maximum = 120
        Me.TimeBar.Name = "TimeBar"
        Me.TimeBar.Size = New System.Drawing.Size(355, 48)
        Me.TimeBar.Step = 1
        Me.TimeBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.TimeBar.TabIndex = 2
        Me.TimeBar.Value = 120
        '
        'TabTime
        '
        Me.TabTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabTime.Controls.Add(Me.Label17)
        Me.TabTime.Controls.Add(Me.Label19)
        Me.TabTime.Controls.Add(Me.T_rSleepLbl)
        Me.TabTime.Controls.Add(Me.T_sleepLbl)
        Me.TabTime.Controls.Add(Me.Label15)
        Me.TabTime.Controls.Add(Me.Sdown1)
        Me.TabTime.Controls.Add(Me.Sup1)
        Me.TabTime.Controls.Add(Me.Label16)
        Me.TabTime.Controls.Add(Me.Sdown15)
        Me.TabTime.Controls.Add(Me.Sup15)
        Me.TabTime.Controls.Add(Me.Label14)
        Me.TabTime.Controls.Add(Me.RSdown1)
        Me.TabTime.Controls.Add(Me.RSup1)
        Me.TabTime.Controls.Add(Me.Label13)
        Me.TabTime.Controls.Add(Me.RSdown15)
        Me.TabTime.Controls.Add(Me.RSup15)
        Me.TabTime.Controls.Add(Me.Label12)
        Me.TabTime.Controls.Add(Me.Label11)
        Me.TabTime.Controls.Add(Me.Label10)
        Me.TabTime.Controls.Add(Me.Label7)
        Me.TabTime.Controls.Add(Me.Label8)
        Me.TabTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TabTime.Location = New System.Drawing.Point(4, 26)
        Me.TabTime.Name = "TabTime"
        Me.TabTime.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTime.Size = New System.Drawing.Size(381, 381)
        Me.TabTime.TabIndex = 1
        Me.TabTime.Text = "Time"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label17.Location = New System.Drawing.Point(-1, 327)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(379, 13)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "______________________________________________________________"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label19.Location = New System.Drawing.Point(13, 216)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(355, 13)
        Me.Label19.TabIndex = 77
        Me.Label19.Text = "__________________________________________________________"
        '
        'T_rSleepLbl
        '
        Me.T_rSleepLbl.BackColor = System.Drawing.Color.Lime
        Me.T_rSleepLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_rSleepLbl.ForeColor = System.Drawing.Color.Black
        Me.T_rSleepLbl.Location = New System.Drawing.Point(177, 28)
        Me.T_rSleepLbl.Name = "T_rSleepLbl"
        Me.T_rSleepLbl.Size = New System.Drawing.Size(109, 20)
        Me.T_rSleepLbl.TabIndex = 76
        Me.T_rSleepLbl.Text = "T_rSleepLbl"
        Me.T_rSleepLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'T_sleepLbl
        '
        Me.T_sleepLbl.BackColor = System.Drawing.Color.Firebrick
        Me.T_sleepLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_sleepLbl.ForeColor = System.Drawing.Color.Black
        Me.T_sleepLbl.Location = New System.Drawing.Point(177, 61)
        Me.T_sleepLbl.Name = "T_sleepLbl"
        Me.T_sleepLbl.Size = New System.Drawing.Size(109, 20)
        Me.T_sleepLbl.TabIndex = 75
        Me.T_sleepLbl.Text = "T_sleepLbl"
        Me.T_sleepLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label15.Location = New System.Drawing.Point(290, 285)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 20)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "1 hour"
        '
        'Sdown1
        '
        Me.Sdown1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Sdown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Sdown1.Location = New System.Drawing.Point(277, 308)
        Me.Sdown1.Name = "Sdown1"
        Me.Sdown1.Size = New System.Drawing.Size(75, 23)
        Me.Sdown1.TabIndex = 73
        Me.Sdown1.Text = "▼"
        Me.Sdown1.UseVisualStyleBackColor = False
        '
        'Sup1
        '
        Me.Sup1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Sup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Sup1.Location = New System.Drawing.Point(277, 259)
        Me.Sup1.Name = "Sup1"
        Me.Sup1.Size = New System.Drawing.Size(75, 23)
        Me.Sup1.TabIndex = 72
        Me.Sup1.Text = "▲"
        Me.Sup1.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label16.Location = New System.Drawing.Point(172, 285)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 20)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "15 min"
        '
        'Sdown15
        '
        Me.Sdown15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Sdown15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Sdown15.Location = New System.Drawing.Point(163, 308)
        Me.Sdown15.Name = "Sdown15"
        Me.Sdown15.Size = New System.Drawing.Size(75, 23)
        Me.Sdown15.TabIndex = 70
        Me.Sdown15.Text = "▼"
        Me.Sdown15.UseVisualStyleBackColor = False
        '
        'Sup15
        '
        Me.Sup15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Sup15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Sup15.Location = New System.Drawing.Point(163, 259)
        Me.Sup15.Name = "Sup15"
        Me.Sup15.Size = New System.Drawing.Size(75, 23)
        Me.Sup15.TabIndex = 69
        Me.Sup15.Text = "▲"
        Me.Sup15.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label14.Location = New System.Drawing.Point(290, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 20)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "1 min"
        '
        'RSdown1
        '
        Me.RSdown1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RSdown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RSdown1.Location = New System.Drawing.Point(277, 174)
        Me.RSdown1.Name = "RSdown1"
        Me.RSdown1.Size = New System.Drawing.Size(75, 23)
        Me.RSdown1.TabIndex = 67
        Me.RSdown1.Text = "▼"
        Me.RSdown1.UseVisualStyleBackColor = False
        '
        'RSup1
        '
        Me.RSup1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RSup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RSup1.Location = New System.Drawing.Point(277, 125)
        Me.RSup1.Name = "RSup1"
        Me.RSup1.Size = New System.Drawing.Size(75, 23)
        Me.RSup1.TabIndex = 66
        Me.RSup1.Text = "▲"
        Me.RSup1.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label13.Location = New System.Drawing.Point(172, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 20)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "15 sec"
        '
        'RSdown15
        '
        Me.RSdown15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RSdown15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RSdown15.Location = New System.Drawing.Point(163, 174)
        Me.RSdown15.Name = "RSdown15"
        Me.RSdown15.Size = New System.Drawing.Size(75, 23)
        Me.RSdown15.TabIndex = 64
        Me.RSdown15.Text = "▼"
        Me.RSdown15.UseVisualStyleBackColor = False
        '
        'RSup15
        '
        Me.RSup15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RSup15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RSup15.Location = New System.Drawing.Point(163, 125)
        Me.RSup15.Name = "RSup15"
        Me.RSup15.Size = New System.Drawing.Size(75, 23)
        Me.RSup15.TabIndex = 63
        Me.RSup15.Text = "▲"
        Me.RSup15.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label12.Location = New System.Drawing.Point(38, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 24)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Sleep Timer:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(8, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 24)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Re-Sleep Timer:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(13, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(355, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "__________________________________________________________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(41, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 24)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Sleep Timer:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(8, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 24)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Re-Sleep Timer:"
        '
        'TabSettings
        '
        Me.TabSettings.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabSettings.Location = New System.Drawing.Point(4, 26)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Size = New System.Drawing.Size(381, 381)
        Me.TabSettings.TabIndex = 2
        Me.TabSettings.Text = "Settings"
        '
        'TabRecords
        '
        Me.TabRecords.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabRecords.Controls.Add(Me.DeleteData)
        Me.TabRecords.Location = New System.Drawing.Point(4, 26)
        Me.TabRecords.Name = "TabRecords"
        Me.TabRecords.Size = New System.Drawing.Size(381, 381)
        Me.TabRecords.TabIndex = 3
        Me.TabRecords.Text = "Records"
        '
        'TabSupport
        '
        Me.TabSupport.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabSupport.Location = New System.Drawing.Point(4, 26)
        Me.TabSupport.Name = "TabSupport"
        Me.TabSupport.Size = New System.Drawing.Size(381, 381)
        Me.TabSupport.TabIndex = 4
        Me.TabSupport.Text = "Support"
        '
        'VersionNum
        '
        Me.VersionNum.AutoSize = True
        Me.VersionNum.BackColor = System.Drawing.Color.Black
        Me.VersionNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionNum.ForeColor = System.Drawing.Color.DimGray
        Me.VersionNum.Location = New System.Drawing.Point(286, 6)
        Me.VersionNum.Name = "VersionNum"
        Me.VersionNum.Size = New System.Drawing.Size(57, 12)
        Me.VersionNum.TabIndex = 1
        Me.VersionNum.Text = "VersionNum"
        '
        'MainTmr
        '
        Me.MainTmr.Interval = 1000
        '
        'CancelTmr
        '
        Me.CancelTmr.Interval = 1
        '
        'DeleteData
        '
        Me.DeleteData.Location = New System.Drawing.Point(289, 346)
        Me.DeleteData.Name = "DeleteData"
        Me.DeleteData.Size = New System.Drawing.Size(75, 23)
        Me.DeleteData.TabIndex = 0
        Me.DeleteData.Text = "Delete"
        Me.DeleteData.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(380, 407)
        Me.Controls.Add(Me.VersionNum)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SmartSleep"
        Me.TabControl.ResumeLayout(False)
        Me.TabHome.ResumeLayout(False)
        Me.TabHome.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTime.ResumeLayout(False)
        Me.TabTime.PerformLayout()
        Me.TabRecords.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabHome As TabPage
    Friend WithEvents TabTime As TabPage
    Friend WithEvents TabSettings As TabPage
    Friend WithEvents TabRecords As TabPage
    Friend WithEvents TabSupport As TabPage
    Friend WithEvents VersionNum As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StartBtn As Button
    Friend WithEvents TimeBar As ProgressBar
    Friend WithEvents H_rSleepLbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TmeTot As Label
    Friend WithEvents TmeRem As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CloseBtn As Button
    Friend WithEvents MainTmr As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents H_sleepLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TmeClock As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents T_rSleepLbl As Label
    Friend WithEvents T_sleepLbl As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Sdown1 As Button
    Friend WithEvents Sup1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Sdown15 As Button
    Friend WithEvents Sup15 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents RSdown1 As Button
    Friend WithEvents RSup1 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents RSdown15 As Button
    Friend WithEvents RSup15 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Notifier As Label
    Friend WithEvents CancelTmr As Timer
    Friend WithEvents DeleteData As Button
End Class
