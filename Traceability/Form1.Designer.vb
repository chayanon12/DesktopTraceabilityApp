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
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        Label1 = New Label()
        txtURL = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Button4 = New Button()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        txtShow1 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtSendId = New TextBox()
        txtSendId1 = New TextBox()
        txtSendId2 = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Button5 = New Button()
        txtEnter = New TextBox()
        Label11 = New Label()
        Button6 = New Button()
        Button7 = New Button()
        Label12 = New Label()
        txtBtn = New TextBox()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' WebView21
        ' 
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.White
        WebView21.Location = New Point(691, 73)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(1071, 804)
        WebView21.TabIndex = 0
        WebView21.ZoomFactor = 1R
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(691, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 20)
        Label1.TabIndex = 1
        Label1.Text = "Url :"
        ' 
        ' txtURL
        ' 
        txtURL.Location = New Point(732, 35)
        txtURL.Name = "txtURL"
        txtURL.Size = New Size(930, 27)
        txtURL.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1668, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 3
        Button1.Text = "Go"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 20)
        Label2.TabIndex = 4
        Label2.Text = "ทดสอบรับค่าจาก text box"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 20)
        Label3.TabIndex = 5
        Label3.Text = "ID textbox จากหน้าเว็บ"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 68)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(562, 27)
        TextBox2.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 101)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 7
        Button2.Text = "Get Value"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(12, 246)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 11
        Button3.Text = "Get Value"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(12, 213)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(562, 27)
        TextBox3.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(215, 20)
        Label4.TabIndex = 9
        Label4.Text = "ID Drop-down list จากหน้า Web"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(211, 20)
        Label5.TabIndex = 8
        Label5.Text = "ทดสอบรับค่าจาก Drop-down list"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 308)
        Label6.Name = "Label6"
        Label6.Size = New Size(146, 20)
        Label6.TabIndex = 12
        Label6.Text = "ทดสอบรับค่าจาก Table"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(12, 331)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(562, 27)
        TextBox4.TabIndex = 13
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(12, 364)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 14
        Button4.Text = "Get Value"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.MistyRose
        TextBox5.Location = New Point(112, 364)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(223, 27)
        TextBox5.TabIndex = 15
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.MistyRose
        TextBox6.Location = New Point(112, 248)
        TextBox6.Name = "TextBox6"
        TextBox6.ReadOnly = True
        TextBox6.Size = New Size(223, 27)
        TextBox6.TabIndex = 16
        ' 
        ' txtShow1
        ' 
        txtShow1.BackColor = Color.MistyRose
        txtShow1.Location = New Point(112, 101)
        txtShow1.Name = "txtShow1"
        txtShow1.ReadOnly = True
        txtShow1.Size = New Size(223, 27)
        txtShow1.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 473)
        Label7.Name = "Label7"
        Label7.Size = New Size(229, 20)
        Label7.TabIndex = 18
        Label7.Text = "ทดสอบส่งค่าคืนให้ text box ใน ตาราง"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 508)
        Label8.Name = "Label8"
        Label8.Size = New Size(390, 20)
        Label8.TabIndex = 19
        Label8.Text = "ID TextBox ในตาราง จากหน้าเว็บ โดยมี column เดียว และ 2 แถว"
        ' 
        ' txtSendId
        ' 
        txtSendId.Location = New Point(12, 541)
        txtSendId.Name = "txtSendId"
        txtSendId.Size = New Size(562, 27)
        txtSendId.TabIndex = 20
        ' 
        ' txtSendId1
        ' 
        txtSendId1.Location = New Point(12, 613)
        txtSendId1.Name = "txtSendId1"
        txtSendId1.Size = New Size(562, 27)
        txtSendId1.TabIndex = 21
        ' 
        ' txtSendId2
        ' 
        txtSendId2.Location = New Point(12, 693)
        txtSendId2.Name = "txtSendId2"
        txtSendId2.Size = New Size(562, 27)
        txtSendId2.TabIndex = 22
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 581)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 20)
        Label9.TabIndex = 23
        Label9.Text = "ค่าที่ส่งแถวที่ 1"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 657)
        Label10.Name = "Label10"
        Label10.Size = New Size(92, 20)
        Label10.TabIndex = 24
        Label10.Text = "ค่าที่ส่งแถวที่ 2"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(12, 738)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 25
        Button5.Text = "Send Value"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' txtEnter
        ' 
        txtEnter.Location = New Point(12, 793)
        txtEnter.Name = "txtEnter"
        txtEnter.Size = New Size(562, 27)
        txtEnter.TabIndex = 26
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(12, 770)
        Label11.Name = "Label11"
        Label11.Size = New Size(66, 20)
        Label11.TabIndex = 27
        Label11.Text = "Enter ID "
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(12, 826)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 28
        Button6.Text = "Send Enter"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(12, 929)
        Button7.Name = "Button7"
        Button7.Size = New Size(94, 29)
        Button7.TabIndex = 31
        Button7.Text = "btnEnter"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(12, 873)
        Label12.Name = "Label12"
        Label12.Size = New Size(54, 20)
        Label12.TabIndex = 30
        Label12.Text = "Btn ID "
        ' 
        ' txtBtn
        ' 
        txtBtn.Location = New Point(12, 896)
        txtBtn.Name = "txtBtn"
        txtBtn.Size = New Size(562, 27)
        txtBtn.TabIndex = 29
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1801, 965)
        Controls.Add(Button7)
        Controls.Add(Label12)
        Controls.Add(txtBtn)
        Controls.Add(Button6)
        Controls.Add(Label11)
        Controls.Add(txtEnter)
        Controls.Add(Button5)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(txtSendId2)
        Controls.Add(txtSendId1)
        Controls.Add(txtSendId)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtShow1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Button4)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(Button3)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(txtURL)
        Controls.Add(Label1)
        Controls.Add(WebView21)
        Name = "Form1"
        Text = "Form1"
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtURL As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents txtShow1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSendId As TextBox
    Friend WithEvents txtSendId1 As TextBox
    Friend WithEvents txtSendId2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents txtEnter As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBtn As TextBox

End Class
