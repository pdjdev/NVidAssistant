Imports System.Runtime.InteropServices
Imports Newtonsoft.Json.Linq

Public Class Form1

    Dim currentURL As String '현재 입력링크(텍스트)
    Dim subject As String '비디오 제목

    Dim postVidUrl As New List(Of String)
    'Dim postVidName As New List(Of String)

    Dim videoName As New List(Of String)
    Dim videoURL As New List(Of String)
    Dim videoSize As New List(Of Integer)

    Dim captionName As New List(Of String)
    Dim captionURL As New List(Of String)

    Dim vidOK As Boolean = False
    Dim prevClipTxt As String = ""
    Dim infoText As String = Nothing

    Dim videoIndex As Integer = -1
    Dim captionIndex As Integer = -1

    Public isClosing = False
    Dim normalHeight As Integer = 0

#Region "창 이동"

    Private Function DoSnap(ByVal pos As Integer, ByVal edge As Integer) As Boolean
        Dim delta As Integer = pos - edge
        Return delta > 0 AndAlso delta <= dpicalc(Me, 20)
    End Function

    Protected Overrides Sub OnResizeEnd(ByVal e As EventArgs)
        MyBase.OnResizeEnd(e)
        Dim scn As Screen = Screen.FromPoint(Me.Location)
        If DoSnap(Me.Left, scn.WorkingArea.Left) Then Me.Left = scn.WorkingArea.Left
        If DoSnap(Me.Top, scn.WorkingArea.Top) Then Me.Top = scn.WorkingArea.Top
        If DoSnap(scn.WorkingArea.Right, Me.Right) Then Me.Left = scn.WorkingArea.Right - Me.Width
        If DoSnap(scn.WorkingArea.Bottom, Me.Bottom) Then Me.Top = scn.WorkingArea.Bottom - Me.Height
    End Sub

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTBORDER As Integer = 18
    Private Const HTBOTTOM As Integer = 15
    Private Const HTBOTTOMLEFT As Integer = 16
    Private Const HTBOTTOMRIGHT As Integer = 17
    Private Const HTCAPTION As Integer = 2
    Private Const HTLEFT As Integer = 10
    Private Const HTRIGHT As Integer = 11
    Private Const HTTOP As Integer = 12
    Private Const HTTOPLEFT As Integer = 13
    Private Const HTTOPRIGHT As Integer = 14

    Private Sub MoveForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub MoveArea_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TopPanel.MouseDown,
        TopLeftPanel.MouseDown, AppLogoPB.MouseDown, VerLabel.MouseDown
        MoveForm()
    End Sub

#End Region

#Region "Aero 그림자 효과 (Vista이상)"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

    Public Function GetVideoId(OriginalURL As String)
        Dim vidkey As String = ""
        Dim url As String = OriginalURL

        '소스코드인 경우
        If url.Contains("src=""") Then
            url = midReturn(url, "src=""", """")
            vidkey = midReturn(url, "vid=", "&")
        Else '플레이어 URL인 경우
            vidkey = midReturn(url, "vid=", "&")
        End If

        Return vidkey
    End Function

    Sub GetVideoIDS(userid As String, postid As String)

        postVidUrl.Clear()
        VideoSelectCB.Items.Clear()

        Dim data As String = webget("http://blog.naver.com/PostView.nhn?blogId=" + userid + "&logNo=" + postid + "&redirect=Dlog&widgetTypeCall=true&directAccess=false")
        Dim keyList As New List(Of String)
        Dim videoList As New List(Of String)
        Dim outKeyList As New List(Of String)

        '일단 포스트에 비디오가 있는 경우에만
        If data.Contains(", ""vid"" : """) Then
            videoList.AddRange(multipleMidReturn(", ""vid"" : """, """,", data)) '비디오 ID와
            keyList.AddRange(multipleMidReturn(", ""inkey"" : """, """,", data)) 'inkey 값 수집

            For i = 0 To videoList.Count - 1 Step 1
                data = webget("http://serviceapi.nmv.naver.com/flash/getShareInfo.nhn?vid=" + videoList(i) + "&inKey=" + keyList(i))
                outKeyList.Add(midReturn(data, "&outKey=", "&"))
            Next


            For i = 0 To videoList.Count - 1 Step 1
                VideoSelectCB.Items.Add((i + 1).ToString + "번째 비디오 (" + Mid(videoList(i), 1, 9) + ")")
                postVidUrl.Add("http://serviceapi.nmv.naver.com/flash/convertIframeTag.nhn?vid=" + videoList(i) + "&outKey=" + outKeyList(i))
            Next

            '비디오가 딱 하나 있을때
            If videoList.Count = 1 Then
                VideoSelectPanel.Visible = False
                '비디오가 두개 이상 있을때
            ElseIf videoList.Count > 1 Then
                VideoSelectPanel.Visible = True
            End If

            If videoList.Count > 0 Then
                VideoSelectCB.SelectedIndex = 0
                analyzeLink(postVidUrl(0), False)
            End If

        End If
    End Sub

    Private Sub PlayButtonClick()
        ChkTimer.Stop()

        Dim Args As String = Nothing
        Dim processName As String = Nothing
        Dim playerAvailable As Boolean = True


        Select Case PlayerComboBox.SelectedIndex
            Case 0 '팟플레이어
                Args = """" + videoURL(videoIndex) + """"

                If Not CaptionBT.Text = "(없음)" And Not captionIndex = -1 Then
                    Args += " /sub=""" + captionURL(captionIndex) + """"
                End If

                If My.Computer.FileSystem.FileExists("C:\Program Files\DAUM\PotPlayer\PotPlayer64.exe") Then
                    processName = "C:\Program Files\DAUM\PotPlayer\PotPlayer64.exe"

                ElseIf My.Computer.FileSystem.FileExists("C:\Program Files\DAUM\PotPlayer\PotPlayer.exe") Then
                    processName = "C:\Program Files\DAUM\PotPlayer\PotPlayer.exe"

                ElseIf My.Computer.FileSystem.FileExists("C:\Program Files (x86)\DAUM\PotPlayer\PotPlayer64.exe") Then
                    processName = "C:\Program Files (x86)\DAUM\PotPlayer\PotPlayer64.exe"

                ElseIf My.Computer.FileSystem.FileExists("C:\Program Files\DAUM\PotPlayer\PotPlayer.exe") Then
                    processName = "C:\Program Files\DAUM\PotPlayer\PotPlayer.exe"

                Else
                    playerAvailable = False

                End If

            Case 1 'VLC

                Args = """" + videoURL(videoIndex) + """"

                If Not CaptionBT.Text = "(없음)" And Not captionIndex = -1 Then
                    My.Computer.Network.DownloadFile(New Uri(captionURL(captionIndex)), My.Computer.FileSystem.SpecialDirectories.Temp + "\nva_tmp.vtt",
                                                             Nothing, Nothing, 1000, True)
                    Args += " :sub-file=""" + My.Computer.FileSystem.SpecialDirectories.Temp + "\nva_tmp.vtt"""
                End If

                If My.Computer.FileSystem.FileExists("C:\Program Files\VideoLAN\VLC\vlc.exe") Then
                    processName = "C:\Program Files\VideoLAN\VLC\vlc.exe"

                ElseIf My.Computer.FileSystem.FileExists("C:\Program Files (x86)\VideoLAN\VLC\vlc.exe") Then
                    processName = "C:\Program Files (x86)\VideoLAN\VLC\vlc.exe"

                Else
                    playerAvailable = False

                End If

            Case 2 'wmp

                Args = """" + videoURL(videoIndex) + """"

                If My.Computer.FileSystem.FileExists("C:\Program Files\Windows Media Player\wmplayer.exe") Then
                    processName = "C:\Program Files\Windows Media Player\wmplayer.exe"

                ElseIf My.Computer.FileSystem.FileExists("C:\Program Files (x86)\Windows Media Player\wmplayer.exe") Then
                    processName = "C:\Program Files (x86)\Windows Media Player\wmplayer.exe"

                Else
                    playerAvailable = False

                End If

            Case 3 '커스텀

                If PlayerArgsTB.Text.Contains("[vid]") Then
                    Args = PlayerArgsTB.Text.Replace("[vid]", videoURL(videoIndex))


                    If Not CaptionBT.Text = "(없음)" And Not captionIndex = -1 Then

                        If Args.Contains("[cap]") Then
                            Args = Args.Replace("[cap]", captionURL(captionIndex))
                        ElseIf Args.Contains("[ocap]") Then
                            My.Computer.Network.DownloadFile(New Uri(captionURL(captionIndex)), My.Computer.FileSystem.SpecialDirectories.Temp + "\nva_tmp.vtt",
                                                             Nothing, Nothing, 1000, True)
                            Args = Args.Replace("[ocap]", My.Computer.FileSystem.SpecialDirectories.Temp + "\nva_tmp.vtt")
                        End If

                    End If

                    If My.Computer.FileSystem.FileExists(PlayerLocationTB.Text) Then
                        processName = PlayerLocationTB.Text
                    Else
                        playerAvailable = False
                    End If


                Else

                    playerAvailable = False

                End If

            Case Else
                playerAvailable = False

        End Select


        If playerAvailable Then
            Process.Start(processName, Args)
            Debug.Print("pn: " + processName + ", args:" + args)

            FadeOut(Me)
            GC.Collect()
            'WindowState = FormWindowState.Minimized
            HideTimeOut.Start()
            ChkTimer.Start()
        Else
            If PlayerComboBox.SelectedIndex = 3 And PlayerArgsTB.Text.Contains("[vid]") = False Then
                MsgBox("사용자 지정 플레이어의 명령 인자 값이 올바르지 않습니다.", vbCritical)

            ElseIf PlayerComboBox.SelectedIndex = -1 Then
                MsgBox("재생할 플레이어가 설정되지 않았습니다", vbInformation)

            Else
                MsgBox("설정한 플레이어가 설치되어 있지 않습니다." + vbCr + "해당 플레이어를 설치하거나 다른 플레이어로 설정한 뒤 다시 시도해 주세요.", vbExclamation)

            End If

        End If


    End Sub

    Private Sub RecommendEntering()
        Dim nowClipTxt As String = Clipboard.GetText

        If (Not nowClipTxt = prevClipTxt) Then

            Dim validate As Boolean = True
            Dim post As Boolean = False

            Dim postid As String = Nothing
            Dim postnum As String = Nothing

            Dim currentCurPos As Point = Cursor.Position

            '1차 점검 serviceapi여부
            If nowClipTxt.Contains("blog.naver.com") Then

                'blog.naver.com/PostView.naver?blogId=12si27&logNo=221147180196 꼴일 경우
                If nowClipTxt.Contains("blogId=") Then

                    '2차 점검 vid outkey 여부
                    Try
                        postid = midReturn(nowClipTxt, "blogId=", "&")
                        postnum = midReturn(nowClipTxt, "logNo=", "&")

                    Catch ex As Exception
                        validate = False

                    End Try

                Else 'blog.naver.com/12si27/221147180196 꼴일 경우

                    '2차 점검 vid outkey 여부
                    Try
                        postid = midReturn(nowClipTxt, "blog.naver.com/", "/")
                        postnum = midReturn(nowClipTxt + "/", postid + "/", "/")

                    Catch ex As Exception
                        validate = False

                    End Try


                End If

                '위에서 통과하였다면, post가 맞음
                post = validate


            ElseIf nowClipTxt.Contains("serviceapi.nmv.naver.com") Then '공유 링크일 경우

                Try
                    postid = midReturn(nowClipTxt, "vid=", "&")
                    postnum = midReturn(nowClipTxt, "outKey=", "&")

                Catch ex As Exception
                    validate = False

                End Try

            ElseIf nowClipTxt.Contains("tv.naver.com/v/") Then '공유 링크일 경우

                Try
                    postid = midReturn(nowClipTxt + "/", "/v/", "/")

                Catch ex As Exception
                    validate = False

                End Try

            Else '아무것도 아닐경우
                validate = False
            End If

            If validate Then

                '감지되었을때 액션
                vidOK = False


                If post Then
                    '포스트 단위 비디오 불러오기 작업 수행
                    GetVideoIDS(postid, postnum)
                Else
                    '바로 비디오 불러오기 작업 수행
                    VideoSelectPanel.Visible = False
                    analyzeLink(nowClipTxt, nowClipTxt.Contains("tv.naver.com/v/"))
                End If


                    If vidOK Then
                    FadeOut(Me)
                    setNormalHeight()
                    Height = normalHeight
                    DoExpand(False)

                    Select Case GetINI("SETTING", "PopupLocation", "", ININamePath)
                        Case "Cursor"
                            checkAndSetDekstopLocaton(currentCurPos.X, currentCurPos.Y, currentCurPos)

                        Case "BottomRight"
                            Dim mg As Integer = Convert.ToInt32(dpicalc(Me, 20))
                            checkAndSetDekstopLocaton(Screen.GetWorkingArea(currentCurPos).X + Screen.GetWorkingArea(currentCurPos).Width - Width - mg,
                                                Screen.GetWorkingArea(currentCurPos).Y + Screen.GetWorkingArea(currentCurPos).Height - normalHeight - mg,
                                                currentCurPos)

                        Case "Center"
                            checkAndSetDekstopLocaton((Screen.GetWorkingArea(currentCurPos).X + Screen.GetWorkingArea(currentCurPos).Width - Width) / 2,
                                                (Screen.GetWorkingArea(currentCurPos).Y + Screen.GetWorkingArea(currentCurPos).Height - normalHeight) / 2,
                                                currentCurPos)

                        Case Else
                            checkAndSetDekstopLocaton(currentCurPos.X, currentCurPos.Y, currentCurPos)

                    End Select

                    Show()
                    WindowState = FormWindowState.Normal
                    TopMost = True
                    Refresh()
                    FadeIn(Me, 1)


                    Try
                        Clipboard.Clear()
                    Catch ex As Exception
                    End Try
                End If

            End If

            prevClipTxt = nowClipTxt
        End If

    End Sub

    Sub checkAndSetDekstopLocaton(x As Integer, y As Integer, cursorPos As Point)

        Dim WorkingArea = Screen.GetWorkingArea(cursorPos)
        Dim nx = x, ny = y

        '스크린 범위 좌우에서 너무 좌측으로 간 경우
        If x < WorkingArea.X Then
            nx = WorkingArea.X
            '스크린 범위 좌우에서 너무 우측으로 간 경우
        ElseIf x > WorkingArea.X + WorkingArea.Width - Width Then
            nx = WorkingArea.X + WorkingArea.Width - Width
        End If

        '스크린 범위 상하에서 너무 위쪽으로 간 경우
        If y < WorkingArea.Y Then
            ny = WorkingArea.Y
        ElseIf y > WorkingArea.Y + WorkingArea.Height - normalHeight Then
            ny = WorkingArea.Y + WorkingArea.Height - normalHeight
        End If

        SetDesktopLocation(nx, ny)

    End Sub

    Sub setNormalHeight()

        normalHeight = TopParentPanel.Height

        If VideoSelectCB.Items.Count > 1 Then
            normalHeight += VideoSelectPanel.Height
        End If

        normalHeight += ThumbnailBox.Height
        normalHeight += MidMarginPanel.Height
        normalHeight += TableLayoutPanel1.Height
        normalHeight += Panel10.Padding.Bottom

    End Sub

    Sub analyzeLink(url As String, isnavertv As Boolean)

        ChkTimer.Stop()

        '값 초기화
        videoName.Clear()
        videoURL.Clear()
        videoSize.Clear()

        captionName.Clear()
        captionURL.Clear()

        videoIndex = -1
        captionIndex = -1

        Dim key1 As String = Nothing
        Dim key2 As String = Nothing

        '네이버 TV일 경우
        If isnavertv Then
            url = midReturn(url + "/", "/v/", "/")
            Dim tvsource As String = webget("https://tv.naver.com/v/" + url)
            key1 = midReturn(tvsource, """videoId"" : """, """")
            key2 = midReturn(tvsource, """inKey"" : """, """")

        Else '아닐 경우
            '소스코드인 경우
            If url.Contains("src=""") Then
                url = midReturn(url, "src=""", """")
                key1 = midReturn(url + "&", "vid=", "&")
                key2 = Mid(url, url.IndexOf("outKey=") + 8, url.Length)
            Else '플레이어 URL인 경우
                key1 = midReturn(url, "vid=", "&")
                key2 = midReturn(url + "&", "outKey=", "&")
            End If

        End If

        Dim dataJson As String = webget("http://apis.naver.com/rmcnmv/rmcnmv/vod/play/v2.0/" + key1 + "?key=" + key2)

        Dim json As JObject = JObject.Parse(dataJson)


        Dim tmp1 = json.SelectToken("meta")

        Dim postURL As String = tmp1.SelectToken("url").ToString '원영상 포스트 링크
        Dim user_name As String = tmp1.SelectToken("user").SelectToken("name").ToString '조회수
        Dim user_id As String = tmp1.SelectToken("user").SelectToken("id").ToString '조회수
        subject = tmp1.SelectToken("subject").ToString '동영상 제목
        Dim count As String = tmp1.SelectToken("count").ToString '조회수
        Dim coverURL As String = tmp1.SelectToken("cover").SelectToken("source").ToString '동영상 썸네일

        tmp1 = json.SelectToken("videos")


        Dim videos = tmp1.SelectToken("list")

        For Each raw In videos
            videoName.Add(raw.SelectToken("encodingOption").SelectToken("name"))
            videoURL.Add(raw.SelectToken("source"))
            videoSize.Add(Convert.ToInt64(raw.SelectToken("size")))
        Next



        tmp1 = json.SelectToken("captions")

        If tmp1 IsNot Nothing Then

            Dim captions = tmp1.SelectToken("list")

            For Each raw In captions
                captionName.Add(raw.SelectToken("label"))
                captionURL.Add(raw.SelectToken("source"))
            Next
        End If

        captionName.Add("(없음)")

        If videoName.Count > 1 Then

            videoIndex = 0
            Dim qualityRate As Short = 0
            ' 1080p = 5 720p = 4 480p = 3 360p = 2 270p = 1 나머지 0

            For Each name As String In videoName
                If name.Contains("1080p") Or name.Contains("1080P") Then
                    If 5 >= qualityRate Then
                        videoIndex = videoName.IndexOf(name)
                        qualityRate = 5
                    End If

                ElseIf name.Contains("720p") Or name.Contains("720P") Then
                    If 4 >= qualityRate Then
                        videoIndex = videoName.IndexOf(name)
                        qualityRate = 4
                    End If

                ElseIf name.Contains("480p") Or name.Contains("480P") Then
                    If 3 >= qualityRate Then
                        videoIndex = videoName.IndexOf(name)
                        qualityRate = 3
                    End If

                ElseIf name.Contains("360p") Or name.Contains("360P") Then
                    If 2 >= qualityRate Then
                        videoIndex = videoName.IndexOf(name)
                        qualityRate = 2
                    End If

                ElseIf name.Contains("270p") Or name.Contains("270P") Then
                    If 1 >= qualityRate Then
                        videoIndex = videoName.IndexOf(name)
                        qualityRate = 1
                    End If

                End If
            Next
            videoBT.Text = videoName(videoIndex)
        End If

        If captionName.Count > 1 Then
            captionIndex = 0
            CaptionBT.Text = captionName(captionIndex)
        Else
            captionIndex = captionName.Count
            CaptionBT.Text = captionName(captionIndex - 1)
        End If

        '영상 썸네일 채우기
        Dim tClient As Net.WebClient = New Net.WebClient
        ThumbnailBox.BackgroundImage = Bitmap.FromStream(New IO.MemoryStream(tClient.DownloadData(coverURL)))

        infoText = "제목: " + subject + vbCr
        infoText += "게시자: " + user_name + " (" + user_id + ")" + vbCr
        infoText += "조회수: " + count + vbCr
        infoText += "원주소: " + postURL + vbCr

        vidOK = True
        ChkTimer.Start()

        TitleLabelUpdate(subject)

        ThumbnailBox.Refresh()
        TitleLabel.Refresh()

    End Sub

    Private Sub TitleLabelUpdate(text As String)

        TitleFadeInTimer.Start()

        TitleLabel.Parent = ThumbnailBox
        TitleLabel.Text = text
        TitleLabel.BackColor = Color.Transparent
        TitleLabel.Location = New Point(10, 10)
        TitleLabel.AutoSize = False
        TitleLabel.Height = ThumbnailBox.Height - 20
        TitleLabel.Width = ThumbnailBox.Width - 20
        TitleLabel.ForeColor = Color.FromArgb(80, 80, 80)
        TitleLabel.Visible = True
        TitleLabel.Font = New Font("맑은 고딕", 10)
        TitleLabel.BringToFront()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0
        'WindowState = FormWindowState.Minimized

        Dim pcinfo As String = "OS: " + My.Computer.Info.OSFullName + " (" + My.Computer.Info.OSVersion + ")" + vbCr _
            + "Mem: " + (My.Computer.Info.TotalPhysicalMemory).ToString + " (" + Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024, 2).ToString + "GB)" + vbCr _
            + "Platform: " + My.Computer.Info.OSPlatform

        VerLabel.Text = "v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
        AppInfoItem1.Text = "네이버 비디오 도우미 v" + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString

        If My.Computer.FileSystem.DirectoryExists("C:\Program Files (x86)") Then
            pcinfo += " (64Bit OS)"
        Else
            pcinfo += " (32Bit OS)"
        End If


        infoRTB.Text = infoRTB.Text.Replace("[pcinfo]", pcinfo)

        Select Case GetINI("SETTING", "Player", "", ININamePath)
            Case "0" '팟플레이어
                PlayerComboBox.SelectedIndex = 0

            Case "1" 'vlc
                PlayerComboBox.SelectedIndex = 1

            Case "2" 'wmp
                PlayerComboBox.SelectedIndex = 2

            Case "3" '사용자 지정
                PlayerComboBox.SelectedIndex = 3

            Case Else
                PlayerComboBox.SelectedIndex = 0

        End Select

        Select Case GetINI("SETTING", "PopupLocation", "", ININamePath)
            Case "Cursor" '팟플레이어
                PosCursorRB.Checked = True

            Case "BottomRight" 'vlc
                PosBRRB.Checked = True

            Case "Center" 'wmp
                PosCenterRB.Checked = True

            Case Else
                PosCursorRB.Checked = True

        End Select


        PlayerLocationTB.Text = GetINI("SETTING", "CustomPlayerPath", "", ININamePath)
        PlayerArgsTB.Text = GetINI("SETTING", "CustomPlayerArgs", "", ININamePath)
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Hide()
    End Sub

    Private Sub ChkTimer_Tick(sender As Object, e As EventArgs) Handles ChkTimer.Tick
        Try
            RecommendEntering()
        Catch ex As Exception
            Debug.WriteLine("체크 실패: " + ex.Message)
        End Try

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FadeOut(Me)
        GC.Collect()

        If Not isclosing Then
            e.Cancel = True
            HideTimeOut.Start()
        End If
    End Sub

    Private Sub HideTimeOut_Tick(sender As Object, e As EventArgs) Handles HideTimeOut.Tick
        Hide()
        HideTimeOut.Stop()
    End Sub

    Private Sub CloseMenuItem_Click(sender As Object, e As EventArgs) Handles CloseMenuItem.Click
        isclosing = True
        Application.Exit()
    End Sub

    Private Sub ThumbnailBox_Click(sender As Object, e As EventArgs) Handles ThumbnailBox.Click, TitleLabel.Click
        PlayButtonClick()
    End Sub

    Private Sub ThumbnailBox_MouseEnter(sender As Object, e As EventArgs) Handles ThumbnailBox.MouseEnter, TitleLabel.MouseEnter
        ThumbnailBox.Image = My.Resources.frame
    End Sub

    Private Sub ThumbnailBox_MouseLeave(sender As Object, e As EventArgs) Handles ThumbnailBox.MouseLeave, TitleLabel.MouseLeave
        ThumbnailBox.Image = My.Resources.frame_inactive
    End Sub

    Private Sub VidInfoBT_Click(sender As Object, e As EventArgs) Handles VidInfoBT.Click
        MsgBox(infoText, MsgBoxStyle.Information)
    End Sub

    Private Sub QualityBT_Click(sender As Object, e As EventArgs) Handles videoBT.Click
        VideoSelectStrip.Items.Clear()
        For Each i As String In videoName
            VideoSelectStrip.Items.Add(i)
        Next
        VideoSelectStrip.Show(Cursor.Position.X, Cursor.Position.Y)
    End Sub

    Private Sub CaptionBT_Click(sender As Object, e As EventArgs) Handles CaptionBT.Click
        CaptionSelectStrip.Items.Clear()
        For Each i As String In captionName
            CaptionSelectStrip.Items.Add(i)
        Next
        CaptionSelectStrip.Show(Cursor.Position.X, Cursor.Position.Y)
    End Sub

    Private Sub OptionStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles VideoSelectStrip.ItemClicked
        Dim item = e.ClickedItem
        videoIndex = VideoSelectStrip.Items.IndexOf(item)
        videoBT.Text = item.Text
    End Sub

    Private Sub CaptionSelectStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles CaptionSelectStrip.ItemClicked
        Dim item = e.ClickedItem
        captionIndex = CaptionSelectStrip.Items.IndexOf(item)
        CaptionBT.Text = item.Text
    End Sub

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        Close()
    End Sub

    Private Sub ExitBT_Click(sender As Object, e As EventArgs) Handles ExitBT.Click
        If MsgBox("네이버 비디오 도우미를 종료하시겠습니까?", vbYesNo + vbQuestion) = vbYes Then
            isClosing = True
            Application.Exit()
        End If
    End Sub

    Private Sub VideoSelectCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VideoSelectCB.SelectedIndexChanged
        analyzeLink(postVidUrl(VideoSelectCB.SelectedIndex), False)
    End Sub

    Private Sub videoBT_MouseEnter(sender As Object, e As EventArgs) Handles videoBT.MouseEnter, CaptionBT.MouseEnter, VidInfoBT.MouseEnter
        Dim lb As Label = sender
        lb.ForeColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub videoBT_MouseLeave(sender As Object, e As EventArgs) Handles videoBT.MouseLeave, CaptionBT.MouseLeave, VidInfoBT.MouseLeave
        Dim lb As Label = sender
        lb.ForeColor = Color.FromArgb(129, 129, 129)
    End Sub

    Private Sub ExpandBT_Click(sender As Object, e As EventArgs) Handles ExpandBT.Click, ExpandBTIcon.Click
        '확장이 되어있는 경우
        If SettingPanel.Visible Then
            DoExpand(False)
        Else '확장이 되어있지 않은 경우
            DoExpand(True)
        End If
    End Sub

    Private Sub DoExpand(expand As Boolean)

        Dim dpiFactor As Double = dpicalc(Me, 96) / 96
        Dim delta = Convert.ToInt32(2 * dpiFactor)

        If expand Then
            Dim targetHeight = normalHeight + SettingPanel.Height

            If Location.Y + targetHeight > Screen.GetWorkingArea(Location).Y _
                                         + Screen.GetWorkingArea(Location).Height Then
                Dim targetY = Screen.GetWorkingArea(Location).Y + Screen.GetWorkingArea(Location).Height _
                            - targetHeight - Convert.ToInt32(dpicalc(Me, 20))
                Dim delta2 = Convert.ToInt32(2 * dpiFactor)

                While Location.Y > targetY + Convert.ToInt32(delta2)
                    delta2 += 7 * dpiFactor
                    SetDesktopLocation(Location.X, Location.Y - Convert.ToInt32(delta2))
                    Threading.Thread.Sleep(10)

                End While
                SetDesktopLocation(Location.X, targetY)

            End If

            While Height < targetHeight - delta
                delta += 5 * dpiFactor
                Height += Convert.ToInt32(delta)
                Threading.Thread.Sleep(10)
            End While

            SettingPanel.Visible = True
            Height = targetHeight + Convert.ToInt32(20 * dpiFactor)
            SettingPanel.Refresh()
            Threading.Thread.Sleep(20)

            While Height > targetHeight + Convert.ToInt32(4 * dpiFactor)
                Height -= Convert.ToInt32(4 * dpiFactor)
                Threading.Thread.Sleep(10)
            End While

            Height = targetHeight

            ExpandBT.Text = "닫기"
            ExpandBTIcon.Image = My.Resources.collapse
        Else

            While Height > normalHeight + delta
                delta += 5 * dpiFactor
                Height -= Convert.ToInt32(delta)
                Threading.Thread.Sleep(10)
            End While

            Height = normalHeight
            SettingPanel.Visible = False
            ExpandBT.Text = "재생/팝업 설정"
            ExpandBTIcon.Image = My.Resources.expand
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("영상 위치: [vid]" + vbCr + "자막 위치: [cap]" + vbCr + "오프라인 자막 위치: [ocap]" + vbCr + "영상 위치 ([vid])는 생략할 수 없습니다." + vbCr _
               + vbCr + "'C:\player'에 있는 'player.exe'라는 플레이어로 '/cap' 명령 인자를 이용해 자막과 함께 재생을 원할 경우:" _
               + vbCr + "위치: C:\player\player.exe" + vbCr + "명령 인자:""[vid]"" /cap=""[cap]""", vbInformation)
    End Sub

    Private Sub PlayerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlayerComboBox.SelectedIndexChanged
        SetINI("SETTING", "Player", PlayerComboBox.SelectedIndex.ToString, ININamePath)
        If PlayerComboBox.SelectedIndex = 3 Then
            CustomPlayerPanel.Enabled = True
        Else
            CustomPlayerPanel.Enabled = False
        End If
    End Sub

    Private Sub PlayerLocationTB_TextChanged(sender As Object, e As EventArgs) Handles PlayerLocationTB.TextChanged
        SetINI("SETTING", "CustomPlayerPath", PlayerLocationTB.Text, ININamePath)
    End Sub

    Private Sub PlayerArgsTB_TextChanged(sender As Object, e As EventArgs) Handles PlayerArgsTB.TextChanged
        SetINI("SETTING", "CustomPlayerArgs", """" + PlayerArgsTB.Text + """", ININamePath)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result = PlayerLocateDialog.ShowDialog
        If result = DialogResult.OK Then
            PlayerLocationTB.Text = PlayerLocateDialog.FileName
        End If
    End Sub

    Private Sub ExpandBT_MouseEnter(sender As Object, e As EventArgs) Handles ExpandBT.MouseEnter, ExpandBTIcon.MouseEnter
        ExpandBT.ForeColor = Color.FromArgb(30, 30, 30)
        ExpandBTIcon.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub ExpandBT_MouseLeave(sender As Object, e As EventArgs) Handles ExpandBT.MouseLeave, ExpandBTIcon.MouseLeave
        ExpandBT.ForeColor = Color.FromArgb(129, 129, 129)
        ExpandBTIcon.BackColor = Color.FromArgb(129, 129, 129)
    End Sub

    Private Sub TitleFadeInTimer_Tick(sender As Object, e As EventArgs) Handles TitleFadeInTimer.Tick
        Dim col = TitleLabel.ForeColor.R

        If col < 255 - 20 Then
            TitleLabel.ForeColor = Color.FromArgb(col + 20, col + 20, col + 20)
        Else
            TitleLabel.ForeColor = Color.FromArgb(255, 255, 255)
            TitleFadeInTimer.Stop()
        End If

    End Sub

    Private Sub PosCursorRB_CheckedChanged(sender As Object, e As EventArgs) Handles PosCursorRB.CheckedChanged
        If PosCursorRB.Checked Then
            SetINI("SETTING", "PopupLocation", "Cursor", ININamePath)
        End If
    End Sub

    Private Sub PosBRRB_CheckedChanged(sender As Object, e As EventArgs) Handles PosBRRB.CheckedChanged
        If PosBRRB.Checked Then
            SetINI("SETTING", "PopupLocation", "BottomRight", ININamePath)
        End If
    End Sub

    Private Sub PosCenterRB_CheckedChanged(sender As Object, e As EventArgs) Handles PosCenterRB.CheckedChanged
        If PosCenterRB.Checked Then
            SetINI("SETTING", "PopupLocation", "Center", ININamePath)
        End If
    End Sub

    Private Sub CloseBT_MouseEnter(sender As Object, e As EventArgs) Handles CloseBT.MouseEnter, ExitBT.MouseEnter
        sender.BackColor = Color.White
    End Sub

    Private Sub CloseBT_MouseLeave(sender As Object, e As EventArgs) Handles CloseBT.MouseLeave, ExitBT.MouseLeave
        sender.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.Click
        ProgramMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/pdjdev/NVidAssistant")
    End Sub
End Class
