Imports System.Threading
Public Class ASD


    '/////////////////////////////////載入主界面時做的事////////////////////////////////////
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '/////////////////////注冊大漠插件/////////////////////////
        Dim app As String
        app = Application.StartupPath
        Shell("regsvr32 /s " & app & "\1.dll")
        '//////////////////////////////////////////////////////////

        Me.TopMost = True

        '/////////////////////檢查大漠插件是否正常注冊/////////////////////////
        Try
            '要執行的動作 
            dm = CreateObject("dm.dmsoft")
        Catch exx As Exception
            'Catch ex As System.Net.WebException
            '擷取錯誤並顯示 
            MsgBox("錯誤訊息 ： 自動註冊DLL失敗 " & vbCrLf & "請確保壓縮檔完整解壓在同一資料夾 和資料夾名稱沒有空格",, "Error")
            Shell("regsvr32 /u /s " & app & "\1.dll")
            End
        End Try
        '/////////////////////注冊大漠插件/////////////////////////


        '///////////////////檢查大漠插件是否正常調用/////////////////////
        Dim ver
        dm = CreateObject("dm.dmsoft")
        ver = dm.ver()
        If ver = 0 Then
            MsgBox("当前大漠插件未能正常调用")
        Else
            MsgBox("自動註冊DLL 成功調用插件" & vbCrLf & "此程式供免費使用" & vbCrLf & "切勿轉售或作任何商業用途" & vbCrLf & "使用任何輔助都有風險" & vbCrLf & "如使用此程式而被封鎖" & vbCrLf & "本人不負任何責任", MsgBoxStyle.Information, "成功")
        End If
        '//////////////////////////////////////////////////////////////////


        '///////////////////檢查更新/////////////////////

        Dim VVer As New Ver("https://drive.google.com/uc?export=download&id=16K5KeLoGw49c64cDXGgnZXUvEhaDXOdw", "Ver")

        VVer.Ver()
        Select Case VVer.GetCheckConsequence '取得更新結果
            Case 0 '沒有更新
                Me.TopMost = True
                MsgBox("目前版本是最新的", MsgBoxStyle.Information)

            Case 1 '有更新
                Me.TopMost = True
                MsgBox("有新版本！" & vbCrLf & "目前版本號碼：" & VVer.GetMyVersion & vbCrLf & "最新版本號碼：" & VVer.GetCheckConsequenceNumber, MsgBoxStyle.Information)
                MsgBox("可按最新版本下載 獲取下載網址")

            Case 2 '更新失敗
                Me.TopMost = True
                MsgBox("獲取版本失敗！", MsgBoxStyle.Critical)

        End Select
        '//////////////////////////////////////////////////


        Dim RandomText As Integer
        Randomize()
        RandomText = Int((Rnd() * 999999999))
        Me.Text = Str(RandomText)
        dm = CreateObject("dm.dmsoft")
        hwnd = dm.FindWindow("", "Counter-Strike Online")
        dm.SetKeypadDelay("normal", 0)
        dm.SetKeypadDelay("windows", 0)
        dm.SetKeypadDelay("dx", 0)

        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        ' 	退出登录(LogOut) url

        '////////////////////找cso視窗////////////////////////////
        If hwnd = 0 Then

            '//////////////不登入////////////////
            If GGGGG = 1 Then
            Else
                Dim url As String = "http://w.eydata.net/47d1f1eb475e5a05" '  这里改成自己的地址
                '  这里改成自己的参数名称
                parameters.Add("StatusCode", Me._statusCode)
                parameters.Add("UserName", Me._userName)
                If (WebPost.ApiPost(url, parameters) = "1") Then
                    ' 退出成功,清除本地状态码
                    OperateIniFile.WriteIniData("root", "code", "", "config.ini")
                Else
                    OperateIniFile.WriteIniData("root", "code", "", "config.ini")
                End If
            End If
            '/////////////////////////////////////

            MsgBox("CSO未開啟 !!")
            MsgBox("程式關閉 反注冊DLL完成",, "反注冊DLL")
            Shell("regsvr32 /u /s " & app & "\1.dll")
            End

        End If
        '/////////////////////////////////////////////////////////////


        '////////////////////////初始化////////////////////////
        checkgame.Enabled = True

        Me.Enabled = True

        dm.BindWindow(hwnd, "normal", "normal", "windows", 4)

        Me.TopMost = False

        Me.CenterToScreen()

        Show()

        dm.SetWindowState(hwnd, 5)

        'Thread8.Start() '後台掛機 / 掛災厄

        ComboBox1.SelectedIndex = 0

        ComboBox2.SelectedIndex = 0

        ComboBox3.SelectedIndex = 0

        ComboBox4.SelectedIndex = 0

        ComboBox5.SelectedIndex = 0

        AddKeyItem_LA(Key6)

        Dim name1 = Process.GetCurrentProcess().MainModule.FileName
        Dim rndNum1234 As New Random()
        Rename(name1, rndNum1234.Next(50, 99) * rndNum1234.Next(50, 99) & ".exe")

        '////////////////////////////////////////////////////////////


    End Sub
    '/////////////////////////////////////////////////////////////////////////

    Dim _statusCode As String
    Dim _userName As String
    Dim checkStatus As Timer
    Dim upDateTime As Date

    Public Sub New(ByVal code As String, ByVal userName As String)
        Me._statusCode = code
        Me._userName = userName
        Me.upDateTime = DateTime.Now
        Me.InitializeComponent()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If GGGGG = 1 Then
        Else
            Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
            ' 	退出登录(LogOut) url
            Dim url As String = "http://w.eydata.net/47d1f1eb475e5a05" '  这里改成自己的地址
            '  这里改成自己的参数名称
            parameters.Add("StatusCode", Me._statusCode)
            parameters.Add("UserName", Me._userName)
            If (WebPost.ApiPost(url, parameters) = "1") Then
                ' 退出成功,清除本地状态码
                OperateIniFile.WriteIniData("root", "code", "", "config.ini")
            End If
        End If

        dm.SetWindowState(hwnd, 9)
        dm.SetWindowState(hwnd, 2)
        dm.SetWindowState(hwnd, 9)
        dm.UnBindWindow()

        Me.TopMost = True

        Dim app As String
        app = Application.StartupPath
        Shell("regsvr32 /u /s " & app & "\1.dll")

        End

    End Sub

    '////////////////////////////////////////////////頂置CSO////////////////////////////////////////////////
    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.CheckState = CheckState.Checked Then
            dm.SetWindowState(hwnd, 8)
        Else
            dm.SetWindowState(hwnd, 9)
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////頂置程式//////////////////////////////////////////////////
    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.CheckState = CheckState.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////

    '>>>>>>>>>>>>>>>>>>>>KeyPress<<<<<<<<<<<<<<<<<<<<'
    Private Sub Key_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    '////////////////////////////////////////////////

    '/////////////////////////////////////////////////



    '>>>>>>>>>>>>>>>>>>>>OnlyNumber<<<<<<<<<<<<<<<<<<<<'
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress, TextBox7.KeyPress, TextBox8.KeyPress, TextBox9.KeyPress, TextBox10.KeyPress, TextBox11.KeyPress
        OnlyNumber_LA(e)
    End Sub
    Private Sub txt_KeyPress1(ByVal sender As Object, ByVal e1 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (TextBox1.Text.IndexOf(".") >= 0 And e1.KeyChar = ".") Then e1.Handled = True
        If (TextBox1.Text.IndexOf("-") And e1.KeyChar = "-") Then e1.Handled = True
    End Sub
    Private Sub txt_KeyPress3(ByVal sender As Object, ByVal e1 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If (TextBox3.Text.IndexOf(".") And e1.KeyChar = ".") Then e1.Handled = True
        If (TextBox3.Text.IndexOf("-") >= 0 And e1.KeyChar = "-") Then e1.Handled = True
    End Sub
    Private Sub txt_KeyPress4(ByVal sender As Object, ByVal e1 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (TextBox4.Text.IndexOf(".") And e1.KeyChar = ".") Then e1.Handled = True
        If (TextBox4.Text.IndexOf("-") >= 0 And e1.KeyChar = "-") Then e1.Handled = True
    End Sub
    Private Sub txt_KeyPress5(ByVal sender As Object, ByVal e1 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If (TextBox5.Text.IndexOf(".") And e1.KeyChar = ".") Then e1.Handled = True
        If (TextBox5.Text.IndexOf("-") >= 0 And e1.KeyChar = "-") Then e1.Handled = True
    End Sub
    Private Sub txt_KeyPress6(ByVal sender As Object, ByVal e1 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If (TextBox6.Text.IndexOf(".") And e1.KeyChar = ".") Then e1.Handled = True
        If (TextBox6.Text.IndexOf("-") >= 0 And e1.KeyChar = "-") Then e1.Handled = True
    End Sub
    Private Sub txt_KeyPress7(ByVal sender As Object, ByVal e1 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If (TextBox7.Text.IndexOf(".") And e1.KeyChar = ".") Then e1.Handled = True
        If (TextBox7.Text.IndexOf("-") And e1.KeyChar = "-") Then e1.Handled = True
    End Sub
    Private Sub txt_KeyPress8(ByVal sender As Object, ByVal e1 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If (TextBox8.Text.IndexOf(".") And e1.KeyChar = ".") Then e1.Handled = True
        If (TextBox8.Text.IndexOf("-") And e1.KeyChar = "-") Then e1.Handled = True
    End Sub
    Private Sub txt_KeyPress9(ByVal sender As Object, ByVal e1 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If (TextBox9.Text.IndexOf(".") And e1.KeyChar = ".") Then e1.Handled = True
        If (TextBox9.Text.IndexOf("-") And e1.KeyChar = "-") Then e1.Handled = True
    End Sub
    Private Sub txt_KeyPress10(ByVal sender As Object, ByVal e1 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        If (TextBox10.Text.IndexOf(".") And e1.KeyChar = ".") Then e1.Handled = True
        If (TextBox10.Text.IndexOf("-") And e1.KeyChar = "-") Then e1.Handled = True
    End Sub
    Private Sub txt_KeyPress11(ByVal sender As Object, ByVal e1 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress
        If (TextBox11.Text.IndexOf(".") And e1.KeyChar = ".") Then e1.Handled = True
        If (TextBox11.Text.IndexOf("-") And e1.KeyChar = "-") Then e1.Handled = True
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>關閉熱鍵偵測<<<<<<<<<<<<<<<<<<<<'
    Private Sub EndCheck_Tick(sender As Object, e As EventArgs) Handles EndCheck.Tick

        If GetAsyncKeyState(Keys.F9) <> 0 And GetAsyncKeyState(Keys.F10) <> 0 Then
            EndCheck.Enabled = False
            Timer1.Enabled = False
            KeyOn6 = 0
            Me.TopLevel = True
            Me.Close()
        End If
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////RandomText//////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub RandomText_Tick(sender As Object, e As EventArgs) Handles RandomText.Tick
        Dim RandomText As Integer
        Randomize()
        RandomText = Int((Rnd() * 99))

        Dim sText As String
        '取得亂數字串 
        sText = RandonStr("A1a1A1a1")
        'MsgBox(sText)
        'Me.Text = Str(RandomText)
        Me.Text = (RandomText & sText)
    End Sub

    Private Function RandonInt(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim iRnd As Integer

        Randomize()
        iRnd = CInt(Int((Max - Min + 1) * Rnd()))
        Return iRnd + Min
    End Function

    ''' <summary> 
    ''' 取得亂數字串。 
    ''' </summary> 
    ''' <param name="Format">字串格式化。A: 表示大寫英文字母; a: 表示小寫英文字母; 1: 表示數字。</param> 
    Private Function RandonStr(ByVal Format As String) As String
        Dim N1 As Integer
        Dim sText As String
        Dim sChar As String
        Dim iCharCode As Integer

        sText = String.Empty
        For N1 = 0 To Format.Length - 1
            sChar = Format.Substring(N1, 1)
            If sChar = "A" Then
                'A-Z 的 ASCII 是 65-90 
                iCharCode = RandonInt(65, 90)
            ElseIf sChar = "a" Then
                'a-z 的 ASCII 是 97-122 
                iCharCode = RandonInt(97, 122)
            ElseIf sChar = "1" Then
                '0-9 的 ASCII 是 48-57 
                iCharCode = RandonInt(48, 57)
            End If
            sText = sText + Chr(iCharCode)
        Next
        Return sText
    End Function
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////


    '//////////////////////////////////////checkgame////////////////////////////////
    Private Sub checkgame_Tick(sender As Object, e As EventArgs) Handles checkgame.Tick
        If CheckBox29.CheckState = CheckState.Checked Then
            hwnd = dm.FindWindow("", "Counter-Strike Online")
            If hwnd = 0 Then
                Threading.Thread.Sleep(1000)
                hwnd = dm.FindWindow("", "Counter-Strike Online")
                If hwnd = 0 Then
                    checkgame.Enabled = False
                    Me.Close()
                End If
            End If
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////



    '>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "按," Then
            ListBox1.Items.Add("按下," & ComboBox2.Text)
            ListBox1.Items.Add("放開," & ComboBox2.Text)
        Else
            ListBox1.Items.Add(ComboBox1.Text & ComboBox2.Text)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.TextLength <> 0 Then
            ListBox1.Items.Add("延遲," & TextBox1.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim v As Integer = ListBox1.SelectedIndex
        If v >= 0 Then
            If ComboBox1.Text = "按," Then
                ListBox1.Items.Insert(v, "按下," & ComboBox2.Text)
                ListBox1.Items.Insert(v, "放開," & ComboBox2.Text)
            Else
                ListBox1.Items.Insert(v, ComboBox1.Text & ComboBox2.Text)
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim v As Integer = ListBox1.SelectedIndex
        If TextBox1.TextLength <> 0 Then
            If v >= 0 Then
                ListBox1.Items.Insert(v, "延遲," & TextBox1.Text)
            End If
        End If
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If RadioButton1.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                Timer1.Enabled = True
                KeyOn6 = 1

            Else
                Timer1.Enabled = False
                KeyOn6 = 0
                次數 = 0
                AAAi = 0
            End If
        End If
    End Sub

    '>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<
    '    Dim Thread8 As New Thread(AddressOf gg)
    '    Sub gg()
    'aa:
    '        'Dim VV = Split(AAb, ",")
    '        'If KeyOn6 = 1 Or KeyOnF6 = 1 Then
    '        '    If AAa = 0 Then
    '        '        ModeCheck("N", "N")
    '        '    End If
    '        '    If AAa <> 0 Then
    '        '        Try

    '        '            If VV(0) = "按下" Then
    '        '                ModeCheck("按下", VV(1))
    '        '            End If
    '        '            If VV(0) = "放開" Then
    '        '                ModeCheck("放開", VV(1))
    '        '            End If
    '        '            If VV(0) = "延遲" Then
    '        '                Threading.Thread.Sleep(VV(1))
    '        '            End If


    '        '        Catch

    '        '            AAAi = 0

    '        '            If VV(0) = "按下" Then
    '        '                ModeCheck("按下", VV(1))
    '        '            End If
    '        '            If VV(0) = "放開" Then
    '        '                ModeCheck("放開", VV(1))
    '        '            End If
    '        '            If VV(0) = "延遲" Then
    '        '                Threading.Thread.Sleep(VV(1))
    '        '            End If

    '        '        End Try

    '        '        AAAi += 1

    '        '        GoTo aa

    '        'End If
    '        'End If
    '        Threading.Thread.Sleep(100)
    '        GoTo aa
    '    End Sub

    'Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    '    'AAc = 0

    '    'AAa = ListBox1.Items.Count
    '    'If AAa = 0 Then
    '    '    AAb = "N,N"
    '    'End If
    '    'If AAa <> 0 Then
    '    '    Try
    '    '        AAb = ListBox1.Items.Item(AAAi)
    '    '    Catch
    '    '        AAAi = 0
    '    '        AAb = ListBox1.Items.Item(AAAi)
    '    '    End Try
    '    'End If
    '    'Dim VV = Split(AAb, ",")
    '    'Label1.Text = VV(0)
    '    'Label2.Text = VV(1)
    '    'Label4.Text = AAAi

    '    'AAc = 1

    'End Sub


    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rndNum123 As New Random()
AA:

        If ListBox1.Items.Count = 0 Then
            ModeCheck("N", "N", "N")
        End If

        If ListBox1.Items.Count <> 0 Then

            Try

                AAb = Split(ListBox1.Items.Item(AAAi), ",")

                If AAb(0) = "防呆開啟" Then
                    CheckBox2.CheckState = CheckState.Checked
                End If
                If AAb(0) = "精準模式開啟" Then
                    CheckBox3.CheckState = CheckState.Checked
                End If
                If AAb(0) = "防呆關閉" Then
                    CheckBox2.CheckState = CheckState.Unchecked
                End If
                If AAb(0) = "精準模式關閉" Then
                    CheckBox3.CheckState = CheckState.Unchecked
                End If


                If AAb(0) = "按下" Then
                    ModeCheck("按下", AAb(1), 0)
                End If
                If AAb(0) = "放開" Then
                    ModeCheck("放開", AAb(1), 0)
                End If
                If AAb(0) = "按下mouse" Then
                    ModeCheck("按下mouse", AAb(1), 0)
                End If
                If AAb(0) = "放開mouse" Then
                    ModeCheck("放開mouse", AAb(1), 0)
                End If
                If AAb(0) = "滑鼠移到" Then
                    ModeCheck("滑鼠移到", AAb(1), AAb(2))
                End If
                If AAb(0) = "相對移動" Then
                    ModeCheck("相對移動", AAb(1), AAb(2))
                End If
                If AAb(0) = "滾輪下" Then
                    ModeCheck("滾輪下", 0, 0)
                End If
                If AAb(0) = "滾輪上" Then
                    ModeCheck("滾輪上", 0, 0)
                End If
                If AAb(0) = "跳轉到" Then
                    AAAi = AAb(1)
                    GoTo cc
                End If
                If AAb(0) = "跳轉到*次數" Then
                    If 次數 <> AAb(2) Then
                        次數 += 1
                        AAAi = AAb(1)
                        GoTo cc
                    End If
                    If 次數 = AAb(2) Then
                        次數 = 0
                    End If
                End If

                If AAb(0) = "延遲" Then
                    Threading.Thread.Sleep(AAb(1))
                End If

                If AAb(0) = "隨機延遲" Then
                    Threading.Thread.Sleep(rndNum123.Next(AAb(1), AAb(2)))
                End If

            Catch

                AAAi = 0

                AAb = Split(ListBox1.Items.Item(AAAi), ",")

                If AAb(0) = "防呆開啟" Then
                    CheckBox2.CheckState = CheckState.Checked
                End If
                If AAb(0) = "精準模式開啟" Then
                    CheckBox3.CheckState = CheckState.Checked
                End If
                If AAb(0) = "防呆關閉" Then
                    CheckBox2.CheckState = CheckState.Unchecked
                End If
                If AAb(0) = "精準模式關閉" Then
                    CheckBox3.CheckState = CheckState.Unchecked
                End If

                If AAb(0) = "按下" Then
                    ModeCheck("按下", AAb(1), 0)
                End If
                If AAb(0) = "放開" Then
                    ModeCheck("放開", AAb(1), 0)
                End If
                If AAb(0) = "按下mouse" Then
                    ModeCheck("按下mouse", AAb(1), 0)
                End If
                If AAb(0) = "放開mouse" Then
                    ModeCheck("放開mouse", AAb(1), 0)
                End If
                If AAb(0) = "滑鼠移到" Then
                    ModeCheck("滑鼠移到", AAb(1), AAb(2))
                End If
                If AAb(0) = "相對移動" Then
                    ModeCheck("相對移動", AAb(1), AAb(2))
                End If
                If AAb(0) = "滾輪下" Then
                    ModeCheck("滾輪下", 0, 0)
                End If
                If AAb(0) = "滾輪上" Then
                    ModeCheck("滾輪上", 0, 0)
                End If
                If AAb(0) = "跳轉到" Then
                    AAAi = AAb(1)
                    GoTo cc
                End If
                If AAb(0) = "跳轉到*次數" Then
                    If 次數 <> AAb(2) Then
                        次數 += 1
                        AAAi = AAb(1)
                        GoTo cc
                    End If
                    If 次數 = AAb(2) Then
                        次數 = 0
                    End If
                End If


                If AAb(0) = "延遲" Then
                    Threading.Thread.Sleep(AAb(1))
                End If

                If AAb(0) = "隨機延遲" Then
                    Threading.Thread.Sleep(rndNum123.Next(AAb(1), AAb(2)))
                End If

                If CheckBox2.CheckState = CheckState.Checked Then
                    off()
                End If

                GoTo bb

            End Try

            AAAi += 1

            If CheckBox3.CheckState = CheckState.Checked Then
                GoTo AA
            End If
bb:
                AAAi += 1
cc:
            End If

    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ComboBox4.Text = "按mouse," Then
            ListBox1.Items.Add("按下mouse," & ComboBox3.Text)
            ListBox1.Items.Add("放開mouse," & ComboBox3.Text)
        Else
            ListBox1.Items.Add(ComboBox4.Text & ComboBox3.Text)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim v As Integer = ListBox1.SelectedIndex
        If v >= 0 Then
            If ComboBox4.Text = "按mouse," Then
                ListBox1.Items.Insert(v, "按下mouse," & ComboBox3.Text)
                ListBox1.Items.Insert(v, "放開mouse," & ComboBox3.Text)
            Else
                ListBox1.Items.Insert(v, ComboBox4.Text & ComboBox3.Text)
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim v As Integer = ListBox1.SelectedIndex
        If v >= 0 Then
            ListBox1.Items.RemoveAt(v)
        End If
    End Sub

    Dim aadfgg As Integer
    Dim aadfgg2 As Integer

    Private Sub HotKey_Tick(sender As Object, e As EventArgs) Handles HotKey.Tick
        If TextBox10.TextLength = 0 Then
            TextBox10.Text = 0
        End If
        If TextBox11.TextLength = 0 Then
            TextBox11.Text = 0
        End If
        Dim v As Integer = ListBox1.SelectedIndex
        If v >= 0 Then
            Label1.Text = "選取的為第" & v & "行"
        Else
            Label1.Text = "選取的為第N行"
        End If
        aadfgg = TextBox10.Text
        aadfgg2 = TextBox11.Text
        If aadfgg > aadfgg2 Then
            TextBox11.Text = TextBox10.Text + 1
        End If

        If RadioButton2.Checked Then
            If Key6P.Checked Then
                OnOffCheck6("Press", Key6.Text, "KeyOn6")
            End If
            If Key6O.Checked Then
                OnOffCheck6("On", Key6.Text, "KeyOnF6")
            End If
            If Key6O.Checked Then
                OnOffCheck6("Off", Key6.Text, "KeyOnF6")
            End If
        End If

        If KeyOn6 = 1 Or KeyOnF6 = 1 Then
            Timer1.Enabled = True

            Timer1.Enabled = True
            v9 = 1
        Else
            Timer1.Enabled = False
            次數 = 0
            AAAi = 0
            Timer1.Enabled = False
            If v9 = 1 Then
                off()
                v9 = 0
            End If
        End If

        If GetAsyncKeyState(Keys.F9) Then
            CheckBox1.CheckState = CheckState.Unchecked
        End If

    End Sub

    Sub off()

        Dim iiad = 0

        If ListBox1.Items.Count <> 0 Then
            If AAb(0) = "按下" Then
                ModeCheck("放開", AAb(1), 0)
            End If
            If AAb(0) = "按下mouse" Then
                Select Case AAb(1)
                    Case "左"
                        dm.LeftUp
                    Case "中"
                        dm.MiddleUp
                    Case "右"
                        dm.RightUp
                End Select
            End If
        End If

GGasd:

        If ListBox1.Items.Count <> 0 Then

            Try

                AAb = Split(ListBox1.Items.Item(iiad), ",")

                If AAb(0) = "按下" Then
                    ModeCheck("放開", AAb(1), 0)
                End If
                If AAb(0) = "放開" Then
                    ModeCheck("放開", AAb(1), 0)
                End If
                If AAb(0) = "按下mouse" Then
                    ModeCheck("放開mouse", AAb(1), 0)
                End If
                If AAb(0) = "放開mouse" Then
                    ModeCheck("放開mouse", AAb(1), 0)
                End If


                If AAb(0) = "延遲" Then
                End If

            Catch

                GoTo GGaaa

            End Try

            iiad += 1

            GoTo GGasd
        End If
GGaaa:
    End Sub

    Private Sub Key_KeyPress2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = True
        TextBox2.Text = e.KeyChar
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox2.Text.Length <> 0 Then
            If ComboBox5.Text = "按," Then
                ListBox1.Items.Add("按下," & TextBox2.Text)
                ListBox1.Items.Add("放開," & TextBox2.Text)
            Else
                ListBox1.Items.Add(ComboBox5.Text & TextBox2.Text)
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox2.Text.Length <> 0 Then
            Dim v As Integer = ListBox1.SelectedIndex
            If v >= 0 Then
                If ComboBox5.Text = "按," Then
                    ListBox1.Items.Insert(v, "按下," & TextBox2.Text)
                    ListBox1.Items.Insert(v, "放開," & TextBox2.Text)
                Else
                    ListBox1.Items.Insert(v, ComboBox5.Text & TextBox2.Text)
                End If
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If ListBox1.Items.Count <> 0 Then
            Dim v As Integer = ListBox1.SelectedIndex
            If v > 0 Then
                Dim i = ListBox1.Items(v)
                ListBox1.Items.RemoveAt(v)
                ListBox1.Items.Insert(v - 1, i)
                ListBox1.SelectedIndex = v - 1
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If ListBox1.Items.Count <> 0 Then
            Dim v As Integer = ListBox1.SelectedIndex
            If v < ListBox1.Items.Count - 1 Then
                Dim i = ListBox1.Items(v)
                ListBox1.Items.RemoveAt(v)
                ListBox1.Items.Insert(v + 1, i)
                ListBox1.SelectedIndex = v + 1
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Key6.Enabled = True
            CheckBox1.Enabled = False
            CheckBox1.CheckState = CheckState.Unchecked
        End If
        If RadioButton1.Checked Then
            CheckBox1.Enabled = True
            Key6.Enabled = False
            Key6.SelectedIndex = 0
        End If
    End Sub

    Private Sub 最新版本下載ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 最新版本下載ToolStripMenuItem.Click
        Dim aaa As String = "http://w.eydata.net/6acf5afa311f5f00"
        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        parameters.Add("0", 0)
        Dim ret As String = WebPost.ApiPost(aaa, parameters)
        Process.Start(ret)
    End Sub

    Private Sub 關於ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 關於ToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form4.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox3.Text.Length <> 0 And TextBox4.Text.Length <> 0 Then
            ListBox1.Items.Add("滑鼠移到," & TextBox3.Text & "," & TextBox4.Text)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox3.Text.Length <> 0 And TextBox4.Text.Length <> 0 Then
            Dim v As Integer = ListBox1.SelectedIndex
            If v >= 0 Then
                ListBox1.Items.Insert(v, "滑鼠移到," & TextBox3.Text & "," & TextBox4.Text)
            End If
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox5.Text.Length <> 0 And TextBox6.Text.Length <> 0 Then
            ListBox1.Items.Add("相對移動," & TextBox5.Text & "," & TextBox6.Text)
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox5.Text.Length <> 0 And TextBox6.Text.Length <> 0 Then
            Dim v As Integer = ListBox1.SelectedIndex
            If v >= 0 Then
                ListBox1.Items.Insert(v, "相對移動," & TextBox5.Text & "," & TextBox6.Text)
            End If
        End If
    End Sub

    '>>>>>>>>>>>>>>>>>>>>>>儲存<<<<<<<<<<<<<<<<<<<<<<
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim save As New System.Windows.Forms.SaveFileDialog
        save.InitialDirectory = Application.StartupPath
        save.FileName = "A"
        save.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            MessageBox.Show(save.FileName)
            My.Computer.FileSystem.WriteAllText(save.FileName, "", False)
            Dim i = 0
aa:
            Try
                Dim item = ListBox1.Items.Item(i)
                My.Computer.FileSystem.WriteAllText(save.FileName, item & vbCrLf, True)
            Catch
                GoTo bb
            End Try
            i += 1
            GoTo aa
bb:
        End If
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    '>>>>>>>>>>>>>>>>>>>>>>讀取<<<<<<<<<<<<<<<<<<<<<<
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim open As New System.Windows.Forms.OpenFileDialog
        open.InitialDirectory = Application.StartupPath
        open.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(open.FileName)
            Dim V = Split(fileReader, vbCrLf)
            Dim i = 0
            ListBox1.Items.Clear()
aa:
            Try
                ListBox1.Items.Add(V(i))
            Catch
                ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
                GoTo bb
            End Try
            i += 1
            GoTo aa
        End If
bb:
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox7.Text.Length <> 0 Then
            If TextBox7.Text < ListBox1.Items.Count Then
                ListBox1.Items.Add("跳轉到," & TextBox7.Text)
            End If
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox7.Text.Length <> 0 Then
            Dim v As Integer = ListBox1.SelectedIndex
            If v >= 0 Then
                If TextBox7.Text < ListBox1.Items.Count Then
                    ListBox1.Items.Insert(v, "跳轉到," & TextBox7.Text)
                End If
            End If
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If TextBox8.Text.Length <> 0 And TextBox9.Text.Length <> 0 Then
            If TextBox8.Text < ListBox1.Items.Count Then
                ListBox1.Items.Add("跳轉到*次數," & TextBox8.Text & "," & TextBox9.Text)
            End If
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If TextBox8.Text.Length <> 0 And TextBox9.Text.Length <> 0 Then
            Dim v As Integer = ListBox1.SelectedIndex
            If v >= 0 Then
                If TextBox8.Text < ListBox1.Items.Count Then
                    ListBox1.Items.Insert(v, "跳轉到*次數," & TextBox8.Text & "," & TextBox9.Text)
                End If
            End If
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        dm.BindWindow(hwnd, "normal", "normal", "windows", 4)
        Label21.Text = "後台" 'key
        Label22.Text = "前台" 'mouse
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        dm.BindWindow(hwnd, "normal", "normal", "normal", 4)
        Label21.Text = "前台" 'key
        Label22.Text = "前台" 'mouse
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        dm.BindWindow(hwnd, "normal", "windows", "windows", 4)
        Label21.Text = "後台" 'key
        Label22.Text = "基本後台" 'mouse
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        dm.BindWindow(hwnd, "normal", "dx2", "windows", 4)
        Label21.Text = "後台" 'key
        Label22.Text = "DX後台" 'mouse
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If TextBox10.Text.Length <> 0 And TextBox11.Text.Length <> 0 Then
            If TextBox11.Text > TextBox10.Text Then
                ListBox1.Items.Add("隨機延遲," & TextBox10.Text & "," & TextBox11.Text)
            End If
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If TextBox10.Text.Length <> 0 And TextBox11.Text.Length <> 0 Then
            Dim v As Integer = ListBox1.SelectedIndex
            If v >= 0 Then
                If TextBox11.Text > TextBox10.Text Then
                    ListBox1.Items.Insert(v, "隨機延遲," & TextBox10.Text & "," & TextBox11.Text)
                End If
            End If
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim i = 1
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Items.Insert(0, "防呆開啟")
aa:
            Try
                If ListBox1.Items.Item(i) = "防呆開啟" Or ListBox1.Items.Item(i) = "防呆關閉" Then
                    ListBox1.Items.RemoveAt(i)
                    i += 1
                Else
                    i += 1
                End If
                GoTo aa
            Catch ex As Exception
                i = 1
            End Try
        End If
        If ListBox1.Items.Count = 0 Then
            ListBox1.Items.Add("防呆開啟")
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim i = 1
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Items.Insert(0, "防呆關閉")
aa:
            Try
                If ListBox1.Items.Item(i) = "防呆關閉" Or ListBox1.Items.Item(i) = "防呆開啟" Then
                    ListBox1.Items.RemoveAt(i)
                    i += 1
                Else
                    i += 1
                End If
                GoTo aa
            Catch ex As Exception
                i = 1
            End Try
        End If
        If ListBox1.Items.Count = 0 Then
            ListBox1.Items.Add("防呆關閉")
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim i = 1
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Items.Insert(0, "精準模式開啟")
aa:
            Try
                If ListBox1.Items.Item(i) = "精準模式開啟" Or ListBox1.Items.Item(i) = "精準模式關閉" Then
                    ListBox1.Items.RemoveAt(i)
                    i += 1
                Else
                    i += 1
                End If
                GoTo aa
            Catch ex As Exception
                i = 1
            End Try
        End If
        If ListBox1.Items.Count = 0 Then
            ListBox1.Items.Add("精準模式開啟")
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim i = 1
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Items.Insert(0, "精準模式關閉")
aa:
            Try
                If ListBox1.Items.Item(i) = "精準模式關閉" Or ListBox1.Items.Item(i) = "精準模式開啟" Then
                    ListBox1.Items.RemoveAt(i)
                    i += 1
                Else
                    i += 1
                End If
                GoTo aa
            Catch ex As Exception
                i = 1
            End Try
        End If
        If ListBox1.Items.Count = 0 Then
            ListBox1.Items.Add("精準模式關閉")
        End If
    End Sub



    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<


    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<


    'Threading.Thread.Sleep()

End Class
