Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uName As String = OperateIniFile.ReadIniData("root", "name", "", "config.ini")
        Dim uPwd As String = OperateIniFile.ReadIniData("root", "pwd", "", "config.ini")
        If (uName.Length > 0) Then
            Me.ckbRememberMe.Checked = True
            Me.txtLoginUserName.Text = uName
            Me.txtLoginUserPwd.Text = uPwd
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' 用户登录(UserLogin) url
        Dim url As String = "http://w.eydata.net/07dbbb2bf9709ffb" ' 这里改成自己的地址
        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        Try
            Dim code As String = OperateIniFile.ReadIniData("root", "code", "", "config.ini")
            Dim upName As String = OperateIniFile.ReadIniData("root", "upName", "", "config.ini")
            If ((code.Length > 0) AndAlso (upName.Length > 0)) Then
                ' 	退出登录(LogOut) url
                Dim logOutUrl As String = "http://w.eydata.net/47d1f1eb475e5a05" ' 这里改成自己的地址
                '  这里改成自己的参数名称
                parameters.Add("StatusCode", code)
                parameters.Add("UserName", upName)
                WebPost.ApiPost(logOutUrl, parameters)
                parameters.Clear()
            End If
            '  这里改成自己的参数名称
            parameters.Add("UserName", Me.txtLoginUserName.Text.Trim)
            parameters.Add("UserPwd", Me.txtLoginUserPwd.Text)
            parameters.Add("Version", "99.5.1")
            parameters.Add("Mac", "")
            Dim ret As String = WebPost.ApiPost(url, parameters)
            If (ret.Length = &H20) Then
                OperateIniFile.WriteIniData("root", "code", ret, "config.ini")
                OperateIniFile.WriteIniData("root", "upName", Me.txtLoginUserName.Text.Trim, "config.ini")
                If Me.ckbRememberMe.Checked Then
                    OperateIniFile.WriteIniData("root", "name", Me.txtLoginUserName.Text, "config.ini")
                    OperateIniFile.WriteIniData("root", "pwd", Me.txtLoginUserPwd.Text, "config.ini")
                Else
                    OperateIniFile.WriteIniData("root", "name", "", "config.ini")
                    OperateIniFile.WriteIniData("root", "pwd", "", "config.ini")
                End If
                Dim asddddd As New ASD(ret, Me.txtLoginUserName.Text.Trim)
                MyBase.Hide()
                asddddd.Show()
            Else
                MessageBox.Show((ChrW(30331) & ChrW(24405) & ChrW(22833) & ChrW(36133) & "," & ChrW(38169) & ChrW(35823) & ChrW(20195) & ChrW(30721) & ": " & ret))
            End If
        Catch exception1 As Exception
            MessageBox.Show(ChrW(32593) & ChrW(32476) & ChrW(36830) & ChrW(25509) & ChrW(22833) & ChrW(36133) & "!")
        End Try
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        ' UserRegin | 用户注册 url
        Dim url As String = "http://w.eydata.net/ac4263338f6b9e90" ' 这里改成自己的地址
        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        Try
            '  这里改成自己的参数名称
            parameters.Add("UserName", Me.txtRegUserName.Text.Trim)
            parameters.Add("UserPwd", Me.txtRegPwd.Text)
            parameters.Add("Email", Me.txtRegEmail.Text)
            parameters.Add("Mac", "")
            Dim ret As String = WebPost.ApiPost(url, parameters)
            If (ret = "1") Then
                MessageBox.Show(ChrW(27880) & ChrW(20876) & ChrW(25104) & ChrW(21151) & "!")
            Else
                MessageBox.Show((ChrW(27880) & ChrW(20876) & ChrW(22833) & ChrW(36133) & "," & ChrW(38169) & ChrW(35823) & ChrW(20195) & ChrW(30721) & ": " & ret))
            End If
        Catch exception1 As Exception
            MessageBox.Show(ChrW(32593) & ChrW(32476) & ChrW(36830) & ChrW(25509) & ChrW(22833) & ChrW(36133) & "!")
        End Try
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Dim asd As New ASD(0, 0)
    '    MyBase.Hide()
    '    asd.Show()
    'End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ' UpdatePwd | 修改用户密码
        Dim url As String = "http://w.eydata.net/3e02d974a4352d32" ' 这里改成自己的地址
        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        Try
            '  这里改成自己的参数名称
            parameters.Add("UserName", Me.txtUpPwdUserName.Text)
            parameters.Add("UserPwd", Me.txtUpPwd1.Text)
            parameters.Add("NewUserPwd", Me.txtUpPwd2.Text)
            Dim ret As String = WebPost.ApiPost(url, parameters)
            If (Integer.Parse(ret) >= 1) Then
                MessageBox.Show(ChrW(20462) & ChrW(25913) & ChrW(23494) & ChrW(30721) & ChrW(25104) & ChrW(21151) & "!")
            Else
                MessageBox.Show((ChrW(20462) & ChrW(25913) & ChrW(23494) & ChrW(30721) & ChrW(22833) & ChrW(36133) & "," & ChrW(38169) & ChrW(35823) & ChrW(20195) & ChrW(30721) & ": " & ret))
            End If
        Catch exception1 As Exception
            MessageBox.Show(ChrW(32593) & ChrW(32476) & ChrW(36830) & ChrW(25509) & ChrW(22833) & ChrW(36133) & "!")
        End Try
    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        ' UpdatePwdByEmail | 用户密码找回
        Dim url As String = "http://w.eydata.net/17bc242f41441c1a" ' 这里改成自己的地址
        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        Try
            '  这里改成自己的参数名称
            parameters.Add("UserName", Me.txtRetrieveUserName.Text)
            parameters.Add("Email", Me.txtRetrieveEmail.Text)
            Dim ret As String = WebPost.ApiPost(url, parameters)
            If (Integer.Parse(ret) >= 1) Then
                MessageBox.Show(ChrW(25214) & ChrW(22238) & ChrW(23494) & ChrW(30721) & ChrW(25104) & ChrW(21151) & "," & ChrW(35831) & ChrW(27880) & ChrW(24847) & ChrW(37038) & ChrW(31665) & ChrW(26597) & ChrW(25910) & "!")
            Else
                MessageBox.Show((ChrW(25214) & ChrW(22238) & ChrW(23494) & ChrW(30721) & ChrW(22833) & ChrW(36133) & "," & ChrW(38169) & ChrW(35823) & ChrW(20195) & ChrW(30721) & ": " & ret))
            End If
        Catch exception1 As Exception
            MessageBox.Show(ChrW(32593) & ChrW(32476) & ChrW(36830) & ChrW(25509) & ChrW(22833) & ChrW(36133) & "!")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.facebook.com/yutinglia")
    End Sub

    'Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    '    Dim asd As New ASD(0, 0)
    '    MyBase.Hide()
    '    asd.Show()
    '    GGGGG = 1

    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim aaa As String = "http://w.eydata.net/f903eb8ad1c1d6ad"
        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        parameters.Add("0", 0)
        Dim ret As String = WebPost.ApiPost(aaa, parameters)
        MessageBox.Show(ret)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim aaa As String = "http://w.eydata.net/6acf5afa311f5f00"
        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        parameters.Add("0", 0)
        Dim ret As String = WebPost.ApiPost(aaa, parameters)
        Process.Start(ret)
    End Sub

    Private Sub ckbRememberMe_CheckedChanged(sender As Object, e As EventArgs) Handles ckbRememberMe.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim asd As New ASD(0, 0)
        MyBase.Hide()
        asd.Show()
        GGGGG = 1

    End Sub


    'Dim timer As String = 60
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    If timer <> 0 Then
    '        timer -= 1
    '        Button1.Text = "不登入使用" & " " & "( " & timer & " )"
    '    End If
    '    If timer = 0 Then
    '        Button1.Text = "不登入使用"
    '        Button1.Enabled = True
    '    End If
    'End Sub


End Class
