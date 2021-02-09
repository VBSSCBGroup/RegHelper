Imports System.Windows.Forms

Public Class ImportDialog

	'导入文本路径获取窗口    #2021/02/09
	Public Property Path As String
	Public Property IsFile As Boolean
	'主题色
	Private Shared ReadOnly DaekThemeBackColor As Color = Color.FromArgb(40, 40, 40)
	Private Shared ReadOnly DarkThemeForeColor As Color = Color.FromKnownColor(KnownColor.ControlLightLight)
	Private Shared ReadOnly LightThemeBackColor As Color = Color.FromKnownColor(KnownColor.Control)
	Private Shared ReadOnly LightThemeForeColor As Color = Color.FromKnownColor(KnownColor.ControlText)

	Public Overloads Sub ShowDialog(darktheme As Boolean)
		'更改主题
		If Not darktheme Then
			'窗体颜色
			BackColor = LightThemeBackColor
			ForeColor = LightThemeForeColor
			'遍历窗体内控件
			For Each control As Control In Controls
				control.BackColor = LightThemeBackColor
				control.ForeColor = LightThemeForeColor
				If control.Name.Contains("txt") Or control.Name.Contains("rtx") Then
					control.BackColor = Color.FromKnownColor(KnownColor.White)
					Continue For
				End If
				If control.Name.StartsWith("btn_") Then
					control.BackColor = Color.FromKnownColor(KnownColor.ControlLight)
				End If
			Next
			'遍历容器
			For Each control As Control In TableLayoutPanel.Controls
				control.BackColor = LightThemeBackColor
				control.ForeColor = LightThemeForeColor
			Next
		Else
			'窗体颜色
			BackColor = DaekThemeBackColor
			ForeColor = DarkThemeForeColor
			'遍历窗体内控件
			For Each control As Control In Controls
				control.BackColor = DaekThemeBackColor
				control.ForeColor = DarkThemeForeColor
			Next
			'遍历容器
			For Each control As Control In TableLayoutPanel.Controls
				control.BackColor = DaekThemeBackColor
				control.ForeColor = DarkThemeForeColor
			Next
		End If
		ShowDialog()
	End Sub
	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		If Not CheckUri() Then Exit Sub
		Path = txt_uri.Text
		IsFile = rb_file.Checked
		DialogResult = DialogResult.OK
		Close()
	End Sub

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
		DialogResult = DialogResult.Cancel
		Close()
	End Sub

	Private Sub rb_file_CheckedChanged(sender As RadioButton, e As EventArgs) Handles rb_file.CheckedChanged, rb_site.CheckedChanged
		'单选项
		If rb_file.Checked Then rb_site.Checked = False Else rb_file.Checked = False
	End Sub


	'以下为自定义函数
	Private Function CheckUri() As Boolean
		If rb_file.Checked Then '检查文件路径
			If Not IO.File.Exists(txt_uri.Text) Then SetError($"文件 ""{txt_uri.Text}"" 不存在！") : Return False
		Else '检查页面路径
			If Not Uri.IsWellFormedUriString(txt_uri.Text, UriKind.RelativeOrAbsolute) Then SetError($"Uri路径 ""{txt_uri.Text}"" 不合法！") : Return False
		End If
		Return True
	End Function

	Private Sub SetError(value As String)
		'报错
		MsgBox("[错误提示] " + value, 0 + 16 + 4096, "出错啦 >_<| ")
	End Sub
End Class
