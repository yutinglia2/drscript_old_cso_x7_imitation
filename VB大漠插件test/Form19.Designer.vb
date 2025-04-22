<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ckbRememberMe = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtLoginUserPwd = New System.Windows.Forms.TextBox()
        Me.txtLoginUserName = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.txtRegEmail = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtRegPwd = New System.Windows.Forms.TextBox()
        Me.txtRegUserName = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.button3 = New System.Windows.Forms.Button()
        Me.txtUpPwd2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUpPwd1 = New System.Windows.Forms.TextBox()
        Me.txtUpPwdUserName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.txtRetrieveEmail = New System.Windows.Forms.TextBox()
        Me.txtRetrieveUserName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.TabPage3)
        Me.tabControl1.Controls.Add(Me.TabPage4)
        Me.tabControl1.Controls.Add(Me.TabPage5)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabControl1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.tabControl1.Location = New System.Drawing.Point(0, 78)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(446, 172)
        Me.tabControl1.TabIndex = 6
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.Button1)
        Me.tabPage1.Controls.Add(Me.Label3)
        Me.tabPage1.Controls.Add(Me.Label7)
        Me.tabPage1.Controls.Add(Me.ckbRememberMe)
        Me.tabPage1.Controls.Add(Me.btnLogin)
        Me.tabPage1.Controls.Add(Me.txtLoginUserPwd)
        Me.tabPage1.Controls.Add(Me.txtLoginUserName)
        Me.tabPage1.Controls.Add(Me.label1)
        Me.tabPage1.Controls.Add(Me.label2)
        Me.tabPage1.Location = New System.Drawing.Point(4, 26)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(438, 142)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "登入"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(238, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 102)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "不登入"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "帳號"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "密碼"
        '
        'ckbRememberMe
        '
        Me.ckbRememberMe.AutoSize = True
        Me.ckbRememberMe.Location = New System.Drawing.Point(13, 102)
        Me.ckbRememberMe.Name = "ckbRememberMe"
        Me.ckbRememberMe.Size = New System.Drawing.Size(59, 20)
        Me.ckbRememberMe.TabIndex = 5
        Me.ckbRememberMe.Text = "記住"
        Me.ckbRememberMe.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(138, 97)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(82, 28)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "登入"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtLoginUserPwd
        '
        Me.txtLoginUserPwd.Location = New System.Drawing.Point(53, 59)
        Me.txtLoginUserPwd.Name = "txtLoginUserPwd"
        Me.txtLoginUserPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.txtLoginUserPwd.Size = New System.Drawing.Size(167, 26)
        Me.txtLoginUserPwd.TabIndex = 3
        '
        'txtLoginUserName
        '
        Me.txtLoginUserName.Location = New System.Drawing.Point(53, 23)
        Me.txtLoginUserName.Name = "txtLoginUserName"
        Me.txtLoginUserName.Size = New System.Drawing.Size(167, 26)
        Me.txtLoginUserName.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(34, 33)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(0, 16)
        Me.label1.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(50, 69)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(0, 16)
        Me.label2.TabIndex = 1
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.LinkLabel1)
        Me.tabPage2.Controls.Add(Me.Label15)
        Me.tabPage2.Controls.Add(Me.Label8)
        Me.tabPage2.Controls.Add(Me.btnReg)
        Me.tabPage2.Controls.Add(Me.txtRegEmail)
        Me.tabPage2.Controls.Add(Me.label6)
        Me.tabPage2.Controls.Add(Me.txtRegPwd)
        Me.tabPage2.Controls.Add(Me.txtRegUserName)
        Me.tabPage2.Controls.Add(Me.label4)
        Me.tabPage2.Controls.Add(Me.label5)
        Me.tabPage2.Location = New System.Drawing.Point(4, 26)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(438, 142)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "註冊"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(229, 106)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(72, 16)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Facebook"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(226, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(168, 32)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "註冊不到或找不回密碼" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "可聯絡作者"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(227, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 48)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "注意 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "帳號必須是以字母開頭" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "的6-16位字母或數字"
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(139, 107)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(82, 28)
        Me.btnReg.TabIndex = 10
        Me.btnReg.Text = "註冊"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'txtRegEmail
        '
        Me.txtRegEmail.Location = New System.Drawing.Point(54, 73)
        Me.txtRegEmail.Name = "txtRegEmail"
        Me.txtRegEmail.Size = New System.Drawing.Size(167, 26)
        Me.txtRegEmail.TabIndex = 9
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(8, 76)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(40, 16)
        Me.label6.TabIndex = 8
        Me.label6.Text = "電郵"
        '
        'txtRegPwd
        '
        Me.txtRegPwd.Location = New System.Drawing.Point(54, 41)
        Me.txtRegPwd.Name = "txtRegPwd"
        Me.txtRegPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.txtRegPwd.Size = New System.Drawing.Size(167, 26)
        Me.txtRegPwd.TabIndex = 7
        '
        'txtRegUserName
        '
        Me.txtRegUserName.Location = New System.Drawing.Point(54, 9)
        Me.txtRegUserName.Name = "txtRegUserName"
        Me.txtRegUserName.Size = New System.Drawing.Size(167, 26)
        Me.txtRegUserName.TabIndex = 6
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(8, 12)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(40, 16)
        Me.label4.TabIndex = 4
        Me.label4.Text = "帳號"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(8, 44)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(40, 16)
        Me.label5.TabIndex = 5
        Me.label5.Text = "密碼"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.button3)
        Me.TabPage3.Controls.Add(Me.txtUpPwd2)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.txtUpPwd1)
        Me.TabPage3.Controls.Add(Me.txtUpPwdUserName)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(438, 142)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "修改密碼"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(203, 105)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(82, 28)
        Me.button3.TabIndex = 24
        Me.button3.Text = "修改密碼"
        Me.button3.UseVisualStyleBackColor = True
        '
        'txtUpPwd2
        '
        Me.txtUpPwd2.Location = New System.Drawing.Point(118, 70)
        Me.txtUpPwd2.Name = "txtUpPwd2"
        Me.txtUpPwd2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.txtUpPwd2.Size = New System.Drawing.Size(167, 26)
        Me.txtUpPwd2.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "新密碼"
        '
        'txtUpPwd1
        '
        Me.txtUpPwd1.Location = New System.Drawing.Point(118, 38)
        Me.txtUpPwd1.Name = "txtUpPwd1"
        Me.txtUpPwd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.txtUpPwd1.Size = New System.Drawing.Size(167, 26)
        Me.txtUpPwd1.TabIndex = 21
        '
        'txtUpPwdUserName
        '
        Me.txtUpPwdUserName.Location = New System.Drawing.Point(118, 6)
        Me.txtUpPwdUserName.Name = "txtUpPwdUserName"
        Me.txtUpPwdUserName.Size = New System.Drawing.Size(167, 26)
        Me.txtUpPwdUserName.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "帳號"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(56, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "舊密碼"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.LinkLabel2)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.btnRetrieve)
        Me.TabPage4.Controls.Add(Me.txtRetrieveEmail)
        Me.TabPage4.Controls.Add(Me.txtRetrieveUserName)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(438, 142)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "找回密碼"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(234, 58)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(72, 16)
        Me.LinkLabel2.TabIndex = 22
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Facebook"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(231, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(168, 32)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "註冊不到或找不回密碼" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "可聯絡作者"
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(144, 98)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(82, 28)
        Me.btnRetrieve.TabIndex = 20
        Me.btnRetrieve.Text = "找回密碼"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'txtRetrieveEmail
        '
        Me.txtRetrieveEmail.Location = New System.Drawing.Point(59, 55)
        Me.txtRetrieveEmail.Name = "txtRetrieveEmail"
        Me.txtRetrieveEmail.Size = New System.Drawing.Size(167, 26)
        Me.txtRetrieveEmail.TabIndex = 19
        '
        'txtRetrieveUserName
        '
        Me.txtRetrieveUserName.Location = New System.Drawing.Point(59, 19)
        Me.txtRetrieveUserName.Name = "txtRetrieveUserName"
        Me.txtRetrieveUserName.Size = New System.Drawing.Size(167, 26)
        Me.txtRetrieveUserName.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "帳號"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "電郵"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Button4)
        Me.TabPage5.Controls.Add(Me.Button2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(438, 142)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "公告 / 最新版本下載"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(162, 81)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 47)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "最新版本下載"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 47)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "線上公告"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe Script", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(103, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(227, 61)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "DR Script"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(446, 250)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tabControl1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Login"
        Me.Text = "Login"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage2 As TabPage
    Private WithEvents btnReg As Button
    Private WithEvents txtRegEmail As TextBox
    Private WithEvents label6 As Label
    Private WithEvents txtRegPwd As TextBox
    Private WithEvents txtRegUserName As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label5 As Label
    Private WithEvents tabPage1 As TabPage
    Private WithEvents ckbRememberMe As CheckBox
    Private WithEvents btnLogin As Button
    Private WithEvents txtLoginUserPwd As TextBox
    Private WithEvents txtLoginUserName As TextBox
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TabPage3 As TabPage
    Private WithEvents button3 As Button
    Private WithEvents txtUpPwd2 As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents txtUpPwd1 As TextBox
    Private WithEvents txtUpPwdUserName As TextBox
    Private WithEvents Label11 As Label
    Private WithEvents Label12 As Label
    Friend WithEvents TabPage4 As TabPage
    Private WithEvents btnRetrieve As Button
    Private WithEvents txtRetrieveEmail As TextBox
    Private WithEvents txtRetrieveUserName As TextBox
    Private WithEvents Label13 As Label
    Private WithEvents Label14 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label15 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label9 As Label
End Class
