Module Module1


    Public dm As Object

    Public hwnd As Object

    Public GGGGG As Object

    Public KeySet As Object

    Public OnSet As Object

    Public KeyOn1, KeyOnF1, KeyOn2, KeyOnF2, KeyOn3, KeyOnF3, KeyOn4, KeyOnF4, KeyOn5, KeyOnF5, KeyOn6, KeyOnF6, KeyOn7, KeyOn8, KeyOnF8 As Object

    Public time1, time2, time3, time4, 蓋亞, Desperado, time5, time6, 湛盧BUG, time7, time8, time9, time10, 極道滅殺, time11, time12, time13, time14, time15, time16, qwe, time17, time18, time19, time20, 刷槍, time21, time22, GS123 As String

    Public timerv As Integer = 20

    Public timerv2 As Integer = 100

    Public mode, modee As String

    Public AAAi As Integer = 0

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As UInt32) As Short

    Public mkey1 As String = "["
    Public mkey2 As String = "]"

    Public AAa, AAb, AAc, v9

    Public 次數 As Integer = 0

    Public VV13

    '>>>>>>>>>>>>>>>>>>>>按鍵資料<<<<<<<<<<<<<<<<<<<<'
    Dim strKey() As String = {"None", "Enter", "Shift", "Ctrl", "Alt", "Space", "PageUp", "PageDown", "Insert", "Delete", "Home", "End", "Left", "Up", "Right", "Down", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "ESCAPE", "滑鼠中鍵", "滑鼠側鍵1", "滑鼠側鍵2"}
    Private Const WM_KEYDOWN As Integer = &H100
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>按鍵資料2<<<<<<<<<<<<<<<<<<<<'
    Dim strKey2() As String = {"None", "Enter", "Shift", "Ctrl", "Alt", "Space", "PageUp", "PageDown", "Insert", "Delete", "Home", "End", "Left", "Up", "Right", "Down", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "ESCAPE", "[", "]", ",", ".", ";", "'", "-", "="}
    Private Const WM_KEYDOWN2 As Integer = &H100
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>將所有按鍵加入至ComboBox2<<<<<<<<<<<<<<<<<<<<'
    Public Sub AddKeyItem_LA2(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        For i = 0 To strKey2.Length - 1
            cbo.Items.Add(strKey2(i))
        Next
        cbo.SelectedIndex = 0
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>後台判定<<<<<<<<<<<<<<<<<<<<'
    Public Function MouseKey(ByVal LR As String, ByVal DU As String)
        If mode = 1 Then
            Select Case LR
                Case "L"
                    Select Case DU
                        Case "Down"
                            dm.LeftDown
                        Case "Up"
                            dm.LeftUp
                    End Select
                Case "R"
                    Select Case DU
                        Case "Down"
                            dm.RightDown
                        Case "Up"
                            dm.RightUp
                    End Select
                    Return 0
            End Select
        End If
        If mode = 2 Then
            Select Case LR
                Case "L"
                    Select Case DU
                        Case "Down"
                            dm.KeyDownChar(mkey1)
                        Case "Up"
                            dm.KeyUpChar(mkey1)
                    End Select
                Case "R"
                    Select Case DU
                        Case "Down"
                            dm.KeyDownChar(mkey2)
                        Case "Up"
                            dm.KeyUpChar(mkey2)
                    End Select
                    Return 0
            End Select
        End If
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'


    '>>>>>>>>>>>>>>>>>>>>模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp11 As String
    Dim kp12 As String
    Public Function OnOffCheck6(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp11 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp11 = 0
                End If
            Case "On"
                If kp12 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp12 = 1
                    End If
                End If
            Case "Off"
                If kp12 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp12 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn6"
                KeyOn6 = kp11
            Case "KeyOnF6"
                KeyOnF6 = kp12
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'



    '/////////////////////////////LeftClick///////////////////////////////
    Public Function LeftClick()
        dm.LeftDown
        Threading.Thread.Sleep(50)
        dm.LeftUp
    End Function
    '///////////////////////////////////////////////////////////////////////
    '/////////////////////////////MouseMoveR///////////////////////////////
    Public Function MouseMoveR()
        dm.MoveR(50, 50)
        Threading.Thread.Sleep(time17)
        dm.MoveR(-50, -50)
        Threading.Thread.Sleep(time17)
    End Function
    '///////////////////////////////////////////////////////////////////////

    '>>>>>>>>>>>>>>>>>>>>熱鍵判定<<<<<<<<<<<<<<<<<<<<'
    Public Function GetKey(ByVal KeyType As String, ByVal KeyCode As String)
        Dim code As UInt32 = toKeyValue(KeyCode)
        Dim onoff As String = 0
        Select Case KeyType
            Case "Press"
                If GetAsyncKeyState(code) <> 0 Then
                    Return 1
                End If
                If GetAsyncKeyState(code) = 0 Then
                    Return 0
                End If
            Case "On"
                If GetAsyncKeyState(code) <> 0 Then
                    Do Until GetAsyncKeyState(code) = 0
                    Loop
                    Return 1
                End If
            Case "Off"
                If GetAsyncKeyState(code) <> 0 Then
                    Return 0
                End If
            Case Else
                Return 0
        End Select
    End Function

    Public Function GetKeyOff(ByVal KeyCode As String, ByVal vvvKey As String)
        Dim code As UInt32 = toKeyValue(KeyCode)
        If vvvKey = 0 Then
            If GetAsyncKeyState(code) <> 0 Then
                Return 0
            End If
        End If

    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>KeyCode<<<<<<<<<<<<<<<<<<<<'
    Private Function toKeyValue(ByVal KeyCode As String) As Integer
        Dim intKey() As Integer = {0, &HD, &H10, &H11, &H12, &H20, &H21, &H22, &H2D, &H2E, &H24, &H23, &H25, &H26, &H27, &H28, &H30, &H31, &H32, &H33, &H34, &H35, &H36, &H37, &H38, &H39, &H41, &H42, &H43, &H44, &H45, &H46, &H47, &H48, &H49, &H4A, &H4B, &H4C, &H4D, &H4E, &H4F, &H50, &H51, &H52, &H53, &H54, &H55, &H56, &H57, &H58, &H59, &H5A, &H70, &H71, &H72, &H73, &H74, &H75, &H76, &H77, &H78, &H79, &H7A, &H7B, &H1B, &H4, &H5, &H6, &HDB, &HDD}
        For i = 0 To strKey.Length - 1
            If strKey(i) = KeyCode Then Return intKey(i)
        Next
        Return False
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>將所有按鍵加入至ComboBox<<<<<<<<<<<<<<<<<<<<'
    Public Sub AddKeyItem_LA(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        For i = 0 To strKey.Length - 1
            cbo.Items.Add(strKey(i))
        Next
        cbo.SelectedIndex = 0
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>僅能輸入數字<<<<<<<<<<<<<<<<<<<<'
    Public Sub OnlyNumber_LA(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 8, 45, 48 To 57, 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    Public Function ModeCheck(ByVal Mode As String, ByVal Mode2 As String, ByVal Mode3 As String)
        Select Case Mode
            Case "N"

            Case "按下"
                dm.KeyDownChar(Mode2)
            Case "放開"
                dm.KeyUpChar(Mode2)
            Case "延遲"

            Case "按下mouse"
                Select Case Mode2
                    Case "左"
                        dm.LeftDown
                    Case "中"
                        dm.MiddleDown
                    Case "右"
                        dm.RightDown
                End Select
            Case "放開mouse"
                Select Case Mode2
                    Case "左"
                        dm.LeftUp
                    Case "中"
                        dm.MiddleUp
                    Case "右"
                        dm.RightUp
                End Select

            Case "滑鼠移到"
                dm.MoveTo(Mode2, Mode3)
            Case "相對移動"
                dm.MoveR(Mode2, Mode3)
            Case "滾輪上"
                dm.WheelUp
            Case "滾輪下"
                dm.WheelDown

            Case Else
                Return 0
        End Select
    End Function


End Module
