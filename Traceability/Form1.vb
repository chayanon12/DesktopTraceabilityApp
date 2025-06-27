Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await WebView21.EnsureCoreWebView2Async(Nothing)
        WebView21.Source = New Uri("http://10.17.74.228:8080/TraceabilitySystem")
        WebView21.ZoomFactor = 0.65
        Await WebView21.ExecuteScriptAsync("window.scrollBy(0, 100);")
        Await WebView21.ExecuteScriptAsync("window.scrollBy(0, -100);")

    End Sub


    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtURL.Text <> "" Then
            Await WebView21.EnsureCoreWebView2Async(Nothing)
            WebView21.Source = New Uri(txtURL.Text)
        Else
            MessageBox.Show("Please Fill URL", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Async Function getDatabyID(ByVal reqID As String) As Task(Of String)
        Dim elementId As String = reqID
        Dim result As String = ""
        Dim scriptTxtField As String = ""
        scriptTxtField = $"document.getElementById('{elementId}')?.value"
        result = Await WebView21.ExecuteScriptAsync(scriptTxtField)
        If String.IsNullOrWhiteSpace(result) OrElse result = "null" Then
            scriptTxtField = $"document.getElementById('{elementId}')?.innerText"
            result = Await WebView21.ExecuteScriptAsync(scriptTxtField)
        End If
        Return result
    End Function
    Private Async Function SetTextFieldValue(id As String, value As String) As Task
        Dim escapedValue = value.Replace("'", "\'")
        Dim script As String = $"
        document.getElementById('{id}').value = '{escapedValue}';
        window.dispatchEvent(new CustomEvent('{id}', {{ detail: '{escapedValue}' }}));
    "
        Await WebView21.ExecuteScriptAsync(script)
    End Function


    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WebView21 Is Nothing OrElse WebView21.Source Is Nothing Then
            MessageBox.Show("WebBrowser ยังไม่มีข้อมูล", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If TextBox2.Text.Trim = "" Then
            MessageBox.Show("ยังไม่ได้กรอก ID", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result As String = Await getDatabyID(TextBox2.Text.Trim())

        If result IsNot Nothing AndAlso result <> "null" Then
            txtShow1.Text = result.Trim(""""c)
        Else
            MessageBox.Show("ไม่พบ element ที่ชื่อ " & TextBox2.Text.Trim, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Async Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If WebView21 Is Nothing OrElse WebView21.Source Is Nothing Then
            MessageBox.Show("WebBrowser ยังไม่มีข้อมูล", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtSendId.Text = "" Then
            MessageBox.Show("กรุณากรอก id", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        Try
            Await SetTextFieldValue(txtSendId.Text, txtSendId1.Text)
        Catch ex As Exception
            MessageBox.Show("ไม่สามารถใส่ค่าได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Async Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txtEnter.Text <> "" Then
            Dim elementId = txtEnter.Text.Trim
            Dim script = $"
                        var el = document.getElementById('{elementId}');
                        if (el) {{
                            var event = new KeyboardEvent('keydown', {{
                                bubbles: true,
                                cancelable: true,
                                key: 'Enter',
                                code: 'Enter',
                                which: 13,
                                keyCode: 13
                            }});
                            el.dispatchEvent(event);
                        }}
            "
            Await WebView21.ExecuteScriptAsync(script)
        End If
    End Sub

    Private Async Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If txtBtn.Text <> "" Then
            Dim elementId = txtBtn.Text.Trim
            Dim script = $"
                       (function() {{
                        var el = document.getElementById('{elementId}');
                        if (el) {{
                            el.click();
                        }}
                    }})();"
            Await WebView21.ExecuteScriptAsync(script)
        End If
    End Sub
End Class
