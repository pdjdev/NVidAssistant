<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ChkTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ProgramMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AppInfoItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppInfoItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideTimeOut = New System.Windows.Forms.Timer(Me.components)
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ExpandBT = New System.Windows.Forms.Label()
        Me.ExpandBTIcon = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VidInfoBT = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.videoBT = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CaptionBT = New System.Windows.Forms.Label()
        Me.VideoSelectStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CaptionSelectStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TopParentPanel = New System.Windows.Forms.Panel()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.ExitBT = New System.Windows.Forms.Panel()
        Me.CloseBT = New System.Windows.Forms.Panel()
        Me.TopLeftPanel = New System.Windows.Forms.Panel()
        Me.VerLabel = New System.Windows.Forms.Label()
        Me.AppLogoPB = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.SettingPanel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PosCenterRB = New System.Windows.Forms.RadioButton()
        Me.PosBRRB = New System.Windows.Forms.RadioButton()
        Me.PosCursorRB = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.infoRTB = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CustomPlayerPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PlayerLocationTB = New System.Windows.Forms.TextBox()
        Me.PlayerArgsTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PlayerComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MidMarginPanel = New System.Windows.Forms.Panel()
        Me.ThumbnailBox = New System.Windows.Forms.PictureBox()
        Me.VideoSelectPanel = New System.Windows.Forms.Panel()
        Me.VideoSelectCB = New System.Windows.Forms.ComboBox()
        Me.PlayerLocateDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TitleFadeInTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ProgramMenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ExpandBTIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TopParentPanel.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        Me.TopLeftPanel.SuspendLayout()
        CType(Me.AppLogoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SettingPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.CustomPlayerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ThumbnailBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VideoSelectPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChkTimer
        '
        Me.ChkTimer.Enabled = True
        Me.ChkTimer.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ProgramMenuStrip
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "네이버 비디오 재생 도우미"
        Me.NotifyIcon1.Visible = True
        '
        'ProgramMenuStrip
        '
        Me.ProgramMenuStrip.BackColor = System.Drawing.Color.White
        Me.ProgramMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ProgramMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppInfoItem1, Me.AppInfoItem2, Me.CloseMenuItem})
        Me.ProgramMenuStrip.Name = "ContextMenuStrip1"
        Me.ProgramMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ProgramMenuStrip.ShowImageMargin = False
        Me.ProgramMenuStrip.Size = New System.Drawing.Size(180, 76)
        '
        'AppInfoItem1
        '
        Me.AppInfoItem1.Font = New System.Drawing.Font("맑은 고딕", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AppInfoItem1.ForeColor = System.Drawing.Color.Gray
        Me.AppInfoItem1.Name = "AppInfoItem1"
        Me.AppInfoItem1.Size = New System.Drawing.Size(179, 24)
        Me.AppInfoItem1.Text = "네이버 비디오 도우미 0.1v"
        '
        'AppInfoItem2
        '
        Me.AppInfoItem2.Font = New System.Drawing.Font("맑은 고딕", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AppInfoItem2.ForeColor = System.Drawing.Color.Gray
        Me.AppInfoItem2.Name = "AppInfoItem2"
        Me.AppInfoItem2.Size = New System.Drawing.Size(179, 24)
        Me.AppInfoItem2.Text = "(NVidAssistant) by pdjdev"
        '
        'CloseMenuItem
        '
        Me.CloseMenuItem.Font = New System.Drawing.Font("맑은 고딕", 10.0!)
        Me.CloseMenuItem.Name = "CloseMenuItem"
        Me.CloseMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.CloseMenuItem.Text = "종료"
        '
        'HideTimeOut
        '
        Me.HideTimeOut.Interval = 500
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(24, 42)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(57, 15)
        Me.TitleLabel.TabIndex = 14
        Me.TitleLabel.Text = "TitleLabel"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ExpandBT)
        Me.Panel1.Controls.Add(Me.ExpandBTIcon)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(176, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Panel1.Size = New System.Drawing.Size(115, 25)
        Me.Panel1.TabIndex = 16
        '
        'ExpandBT
        '
        Me.ExpandBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExpandBT.Font = New System.Drawing.Font("맑은 고딕", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ExpandBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ExpandBT.Location = New System.Drawing.Point(3, 3)
        Me.ExpandBT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ExpandBT.Name = "ExpandBT"
        Me.ExpandBT.Size = New System.Drawing.Size(91, 19)
        Me.ExpandBT.TabIndex = 1
        Me.ExpandBT.Text = "재생/팝업 설정"
        Me.ExpandBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExpandBTIcon
        '
        Me.ExpandBTIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ExpandBTIcon.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExpandBTIcon.Image = CType(resources.GetObject("ExpandBTIcon.Image"), System.Drawing.Image)
        Me.ExpandBTIcon.Location = New System.Drawing.Point(94, 3)
        Me.ExpandBTIcon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExpandBTIcon.Name = "ExpandBTIcon"
        Me.ExpandBTIcon.Size = New System.Drawing.Size(18, 19)
        Me.ExpandBTIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExpandBTIcon.TabIndex = 0
        Me.ExpandBTIcon.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.VidInfoBT)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(118, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Size = New System.Drawing.Size(54, 25)
        Me.Panel2.TabIndex = 17
        '
        'VidInfoBT
        '
        Me.VidInfoBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VidInfoBT.Font = New System.Drawing.Font("맑은 고딕", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.VidInfoBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.VidInfoBT.Location = New System.Drawing.Point(2, 2)
        Me.VidInfoBT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VidInfoBT.Name = "VidInfoBT"
        Me.VidInfoBT.Size = New System.Drawing.Size(50, 21)
        Me.VidInfoBT.TabIndex = 0
        Me.VidInfoBT.Text = "정보"
        Me.VidInfoBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.VidInfoBT, "비디오 정보")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.videoBT)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Size = New System.Drawing.Size(54, 25)
        Me.Panel3.TabIndex = 18
        '
        'videoBT
        '
        Me.videoBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.videoBT.Font = New System.Drawing.Font("맑은 고딕", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.videoBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.videoBT.Location = New System.Drawing.Point(2, 2)
        Me.videoBT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.videoBT.Name = "videoBT"
        Me.videoBT.Size = New System.Drawing.Size(50, 21)
        Me.videoBT.TabIndex = 0
        Me.videoBT.Text = "1080p"
        Me.videoBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.videoBT, "화질 설정")
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CaptionBT)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(60, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Size = New System.Drawing.Size(54, 25)
        Me.Panel4.TabIndex = 19
        '
        'CaptionBT
        '
        Me.CaptionBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CaptionBT.Font = New System.Drawing.Font("맑은 고딕", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CaptionBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.CaptionBT.Location = New System.Drawing.Point(2, 2)
        Me.CaptionBT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CaptionBT.Name = "CaptionBT"
        Me.CaptionBT.Size = New System.Drawing.Size(50, 21)
        Me.CaptionBT.TabIndex = 0
        Me.CaptionBT.Text = "한국어"
        Me.CaptionBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.CaptionBT, "자막 설정")
        '
        'VideoSelectStrip
        '
        Me.VideoSelectStrip.BackColor = System.Drawing.Color.White
        Me.VideoSelectStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.VideoSelectStrip.Name = "OptionStrip"
        Me.VideoSelectStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.VideoSelectStrip.ShowImageMargin = False
        Me.VideoSelectStrip.ShowItemToolTips = False
        Me.VideoSelectStrip.Size = New System.Drawing.Size(36, 4)
        '
        'CaptionSelectStrip
        '
        Me.CaptionSelectStrip.BackColor = System.Drawing.Color.White
        Me.CaptionSelectStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CaptionSelectStrip.Name = "OptionStrip"
        Me.CaptionSelectStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CaptionSelectStrip.ShowImageMargin = False
        Me.CaptionSelectStrip.ShowItemToolTips = False
        Me.CaptionSelectStrip.Size = New System.Drawing.Size(36, 4)
        '
        'TopParentPanel
        '
        Me.TopParentPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TopParentPanel.Controls.Add(Me.TopPanel)
        Me.TopParentPanel.Controls.Add(Me.Panel6)
        Me.TopParentPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopParentPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopParentPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TopParentPanel.Name = "TopParentPanel"
        Me.TopParentPanel.Size = New System.Drawing.Size(315, 46)
        Me.TopParentPanel.TabIndex = 20
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.ExitBT)
        Me.TopPanel.Controls.Add(Me.CloseBT)
        Me.TopPanel.Controls.Add(Me.TopLeftPanel)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(315, 29)
        Me.TopPanel.TabIndex = 1
        '
        'ExitBT
        '
        Me.ExitBT.BackgroundImage = Global.NVidAssistant.My.Resources.Resources._exit
        Me.ExitBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExitBT.Location = New System.Drawing.Point(223, 0)
        Me.ExitBT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExitBT.Name = "ExitBT"
        Me.ExitBT.Padding = New System.Windows.Forms.Padding(0, 10, 16, 6)
        Me.ExitBT.Size = New System.Drawing.Size(46, 29)
        Me.ExitBT.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ExitBT, "종료")
        '
        'CloseBT
        '
        Me.CloseBT.BackgroundImage = Global.NVidAssistant.My.Resources.Resources.closebt
        Me.CloseBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseBT.Location = New System.Drawing.Point(269, 0)
        Me.CloseBT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Padding = New System.Windows.Forms.Padding(0, 10, 16, 6)
        Me.CloseBT.Size = New System.Drawing.Size(46, 29)
        Me.CloseBT.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CloseBT, "닫기")
        '
        'TopLeftPanel
        '
        Me.TopLeftPanel.Controls.Add(Me.VerLabel)
        Me.TopLeftPanel.Controls.Add(Me.AppLogoPB)
        Me.TopLeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TopLeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopLeftPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TopLeftPanel.Name = "TopLeftPanel"
        Me.TopLeftPanel.Padding = New System.Windows.Forms.Padding(16, 13, 0, 3)
        Me.TopLeftPanel.Size = New System.Drawing.Size(186, 29)
        Me.TopLeftPanel.TabIndex = 2
        '
        'VerLabel
        '
        Me.VerLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerLabel.Font = New System.Drawing.Font("맑은 고딕", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.VerLabel.ForeColor = System.Drawing.Color.Gray
        Me.VerLabel.Location = New System.Drawing.Point(137, 13)
        Me.VerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VerLabel.Name = "VerLabel"
        Me.VerLabel.Size = New System.Drawing.Size(49, 13)
        Me.VerLabel.TabIndex = 2
        Me.VerLabel.Text = "v0.1"
        Me.VerLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'AppLogoPB
        '
        Me.AppLogoPB.Dock = System.Windows.Forms.DockStyle.Left
        Me.AppLogoPB.Image = CType(resources.GetObject("AppLogoPB.Image"), System.Drawing.Image)
        Me.AppLogoPB.Location = New System.Drawing.Point(16, 13)
        Me.AppLogoPB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AppLogoPB.Name = "AppLogoPB"
        Me.AppLogoPB.Size = New System.Drawing.Size(121, 13)
        Me.AppLogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppLogoPB.TabIndex = 1
        Me.AppLogoPB.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 29)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(315, 17)
        Me.Panel6.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BackgroundImage = CType(resources.GetObject("Panel9.BackgroundImage"), System.Drawing.Image)
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(14, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(287, 17)
        Me.Panel9.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(301, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(14, 17)
        Me.Panel8.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(14, 17)
        Me.Panel7.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.TitleLabel)
        Me.Panel10.Controls.Add(Me.SettingPanel)
        Me.Panel10.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel10.Controls.Add(Me.MidMarginPanel)
        Me.Panel10.Controls.Add(Me.ThumbnailBox)
        Me.Panel10.Controls.Add(Me.VideoSelectPanel)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 46)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(11, 0, 11, 4)
        Me.Panel10.Size = New System.Drawing.Size(315, 524)
        Me.Panel10.TabIndex = 21
        '
        'SettingPanel
        '
        Me.SettingPanel.Controls.Add(Me.LinkLabel1)
        Me.SettingPanel.Controls.Add(Me.Panel5)
        Me.SettingPanel.Controls.Add(Me.Label2)
        Me.SettingPanel.Controls.Add(Me.infoRTB)
        Me.SettingPanel.Controls.Add(Me.Label5)
        Me.SettingPanel.Controls.Add(Me.CustomPlayerPanel)
        Me.SettingPanel.Controls.Add(Me.PlayerComboBox)
        Me.SettingPanel.Controls.Add(Me.Label1)
        Me.SettingPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SettingPanel.Location = New System.Drawing.Point(11, 231)
        Me.SettingPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SettingPanel.Name = "SettingPanel"
        Me.SettingPanel.Size = New System.Drawing.Size(293, 293)
        Me.SettingPanel.TabIndex = 24
        Me.SettingPanel.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PosCenterRB)
        Me.Panel5.Controls.Add(Me.PosBRRB)
        Me.Panel5.Controls.Add(Me.PosCursorRB)
        Me.Panel5.Location = New System.Drawing.Point(-1, 149)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(288, 34)
        Me.Panel5.TabIndex = 12
        '
        'PosCenterRB
        '
        Me.PosCenterRB.AutoSize = True
        Me.PosCenterRB.Location = New System.Drawing.Point(202, 6)
        Me.PosCenterRB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PosCenterRB.Name = "PosCenterRB"
        Me.PosCenterRB.Size = New System.Drawing.Size(61, 19)
        Me.PosCenterRB.TabIndex = 2
        Me.PosCenterRB.TabStop = True
        Me.PosCenterRB.Text = "가운데"
        Me.PosCenterRB.UseVisualStyleBackColor = True
        '
        'PosBRRB
        '
        Me.PosBRRB.AutoSize = True
        Me.PosBRRB.Location = New System.Drawing.Point(121, 6)
        Me.PosBRRB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PosBRRB.Name = "PosBRRB"
        Me.PosBRRB.Size = New System.Drawing.Size(77, 19)
        Me.PosBRRB.TabIndex = 1
        Me.PosBRRB.TabStop = True
        Me.PosBRRB.Text = "좌측 하단"
        Me.PosBRRB.UseVisualStyleBackColor = True
        '
        'PosCursorRB
        '
        Me.PosCursorRB.AutoSize = True
        Me.PosCursorRB.Location = New System.Drawing.Point(6, 6)
        Me.PosCursorRB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PosCursorRB.Name = "PosCursorRB"
        Me.PosCursorRB.Size = New System.Drawing.Size(113, 19)
        Me.PosCursorRB.TabIndex = 0
        Me.PosCursorRB.TabStop = True
        Me.PosCursorRB.Text = "커서 위치 (기본)"
        Me.PosCursorRB.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "팝업 위치"
        '
        'infoRTB
        '
        Me.infoRTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.infoRTB.Font = New System.Drawing.Font("맑은 고딕", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.infoRTB.Location = New System.Drawing.Point(5, 210)
        Me.infoRTB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.infoRTB.Name = "infoRTB"
        Me.infoRTB.ReadOnly = True
        Me.infoRTB.Size = New System.Drawing.Size(282, 69)
        Me.infoRTB.TabIndex = 9
        Me.infoRTB.Text = resources.GetString("infoRTB.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "정보"
        '
        'CustomPlayerPanel
        '
        Me.CustomPlayerPanel.Controls.Add(Me.Button1)
        Me.CustomPlayerPanel.Controls.Add(Me.Label3)
        Me.CustomPlayerPanel.Controls.Add(Me.Button2)
        Me.CustomPlayerPanel.Controls.Add(Me.PlayerLocationTB)
        Me.CustomPlayerPanel.Controls.Add(Me.PlayerArgsTB)
        Me.CustomPlayerPanel.Controls.Add(Me.Label4)
        Me.CustomPlayerPanel.Location = New System.Drawing.Point(0, 68)
        Me.CustomPlayerPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CustomPlayerPanel.Name = "CustomPlayerPanel"
        Me.CustomPlayerPanel.Size = New System.Drawing.Size(293, 54)
        Me.CustomPlayerPanel.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 22)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "찾아보기..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "위치"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(205, 26)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 22)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "도움말"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PlayerLocationTB
        '
        Me.PlayerLocationTB.Location = New System.Drawing.Point(40, 2)
        Me.PlayerLocationTB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PlayerLocationTB.Name = "PlayerLocationTB"
        Me.PlayerLocationTB.Size = New System.Drawing.Size(161, 23)
        Me.PlayerLocationTB.TabIndex = 3
        '
        'PlayerArgsTB
        '
        Me.PlayerArgsTB.Location = New System.Drawing.Point(66, 26)
        Me.PlayerArgsTB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PlayerArgsTB.Name = "PlayerArgsTB"
        Me.PlayerArgsTB.Size = New System.Drawing.Size(135, 23)
        Me.PlayerArgsTB.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "명령 인자"
        '
        'PlayerComboBox
        '
        Me.PlayerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlayerComboBox.FormattingEnabled = True
        Me.PlayerComboBox.Items.AddRange(New Object() {"팟플레이어 (potplayer.exe)", "VLC media player (vlc.exe)", "Windows Media Player (wmplayer.exe)", "사용자 지정"})
        Me.PlayerComboBox.Location = New System.Drawing.Point(5, 41)
        Me.PlayerComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PlayerComboBox.Name = "PlayerComboBox"
        Me.PlayerComboBox.Size = New System.Drawing.Size(283, 23)
        Me.PlayerComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "재생 플레이어"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 202)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(293, 29)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'MidMarginPanel
        '
        Me.MidMarginPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MidMarginPanel.Location = New System.Drawing.Point(11, 196)
        Me.MidMarginPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MidMarginPanel.Name = "MidMarginPanel"
        Me.MidMarginPanel.Size = New System.Drawing.Size(293, 6)
        Me.MidMarginPanel.TabIndex = 23
        '
        'ThumbnailBox
        '
        Me.ThumbnailBox.BackColor = System.Drawing.Color.Black
        Me.ThumbnailBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ThumbnailBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.ThumbnailBox.Image = CType(resources.GetObject("ThumbnailBox.Image"), System.Drawing.Image)
        Me.ThumbnailBox.Location = New System.Drawing.Point(11, 31)
        Me.ThumbnailBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ThumbnailBox.Name = "ThumbnailBox"
        Me.ThumbnailBox.Size = New System.Drawing.Size(293, 165)
        Me.ThumbnailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ThumbnailBox.TabIndex = 9
        Me.ThumbnailBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ThumbnailBox, "클릭하여 비디오 재생")
        '
        'VideoSelectPanel
        '
        Me.VideoSelectPanel.Controls.Add(Me.VideoSelectCB)
        Me.VideoSelectPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.VideoSelectPanel.Location = New System.Drawing.Point(11, 0)
        Me.VideoSelectPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.VideoSelectPanel.Name = "VideoSelectPanel"
        Me.VideoSelectPanel.Size = New System.Drawing.Size(293, 31)
        Me.VideoSelectPanel.TabIndex = 22
        Me.VideoSelectPanel.Visible = False
        '
        'VideoSelectCB
        '
        Me.VideoSelectCB.Dock = System.Windows.Forms.DockStyle.Top
        Me.VideoSelectCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VideoSelectCB.Font = New System.Drawing.Font("맑은 고딕", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.VideoSelectCB.FormattingEnabled = True
        Me.VideoSelectCB.Location = New System.Drawing.Point(0, 0)
        Me.VideoSelectCB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.VideoSelectCB.Name = "VideoSelectCB"
        Me.VideoSelectCB.Size = New System.Drawing.Size(293, 27)
        Me.VideoSelectCB.TabIndex = 20
        '
        'PlayerLocateDialog
        '
        Me.PlayerLocateDialog.Filter = "실행 파일|*.exe"
        Me.PlayerLocateDialog.Title = "플레이어의 실행 파일을 선택해 주세요"
        '
        'TitleFadeInTimer
        '
        Me.TitleFadeInTimer.Interval = 10
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(157, 191)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(130, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "최신 버전 확인 (GitHub)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(315, 570)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.TopParentPanel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "NVidAssistant"
        Me.ProgramMenuStrip.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ExpandBTIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TopParentPanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        Me.TopLeftPanel.ResumeLayout(False)
        CType(Me.AppLogoPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.SettingPanel.ResumeLayout(False)
        Me.SettingPanel.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.CustomPlayerPanel.ResumeLayout(False)
        Me.CustomPlayerPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ThumbnailBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VideoSelectPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ThumbnailBox As PictureBox
    Friend WithEvents ChkTimer As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents HideTimeOut As Timer
    Friend WithEvents ProgramMenuStrip As ContextMenuStrip
    Friend WithEvents CloseMenuItem As ToolStripMenuItem
    Friend WithEvents TitleLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExpandBTIcon As PictureBox
    Friend WithEvents ExpandBT As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VidInfoBT As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents videoBT As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CaptionBT As Label
    Friend WithEvents VideoSelectStrip As ContextMenuStrip
    Friend WithEvents CaptionSelectStrip As ContextMenuStrip
    Friend WithEvents TopParentPanel As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents AppLogoPB As PictureBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents CloseBT As Panel
    Friend WithEvents TopLeftPanel As Panel
    Friend WithEvents VideoSelectCB As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents VideoSelectPanel As Panel
    Friend WithEvents MidMarginPanel As Panel
    Friend WithEvents VerLabel As Label
    Friend WithEvents SettingPanel As Panel
    Friend WithEvents infoRTB As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PlayerArgsTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PlayerLocationTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PlayerComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PlayerLocateDialog As OpenFileDialog
    Friend WithEvents CustomPlayerPanel As Panel
    Friend WithEvents TitleFadeInTimer As Timer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PosCenterRB As RadioButton
    Friend WithEvents PosBRRB As RadioButton
    Friend WithEvents PosCursorRB As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents ExitBT As Panel
    Friend WithEvents AppInfoItem1 As ToolStripMenuItem
    Friend WithEvents AppInfoItem2 As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
