Imports System.Text
Imports System.Text.RegularExpressions
Public Class MainForm
	Private Shared ReadOnly DaekThemeBackColor As Color = Color.FromArgb(40, 40, 40)
	Private Shared ReadOnly DarkThemeForeColor As Color = Color.FromKnownColor(KnownColor.ControlLightLight)
	Private Shared ReadOnly LightThemeBackColor As Color = Color.FromKnownColor(KnownColor.Control)
	Private Shared ReadOnly LightThemeForeColor As Color = Color.FromKnownColor(KnownColor.ControlText)
	Private DarkTheme As Boolean = True

	Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		InitCellHeader()
		NotifyIcon.Visible = True
	End Sub

	Private Sub btn_upgrade_Click(sender As Object, e As EventArgs) Handles btn_upgrade.Click
		'将datagridview的字符串拼接到content中
		If DataGridView.Rows.Count = 1 Or DataGridView.Rows.Item(0).Cells.Item(0).Value = "" Then '验证空值
			SetError("单元格为空值！")
			Exit Sub
		End If
		Dim sb As New StringBuilder
		For Each row As DataGridViewRow In DataGridView.Rows '转化
			If IsNothing(row.Cells.Item(0).Value) Then Continue For
			sb.Append(row.Cells.Item(0).Value.ToString().Replace("{\n}", vbNewLine))
		Next
		rtx_content.Clear()
		rtx_content.Text = sb.ToString()
		sb.Clear()
		sb = Nothing
	End Sub

	Private Sub btn_clearData_Click(sender As Object, e As EventArgs) Handles btn_clearData.Click
		'初始化datagridview表格内容
		InitCellHeader()
	End Sub

	Private Sub btn_clearContent_Click(sender As Object, e As EventArgs) Handles btn_clearContent.Click
		'清空源字符串内容
		rtx_content.Clear()
	End Sub

	Private Sub btn_importPage_Click(sender As Object, e As EventArgs) Handles btn_importPage.Click
		'导入文本
		Dim import As New ImportDialog()
		Dim text As String = ""
		import.ShowDialog(DarkTheme)
		If import.DialogResult = DialogResult.Cancel Then import.Dispose() : Exit Sub
		If import.IsFile Then
			Try
				text = IO.File.ReadAllText(import.Path)
			Catch ex As Exception
				SetError($"[引发错误] {ex.Message}")
			End Try
		Else
			Try
				text = New Gossamer(import.Path).getContentDocument()
			Catch ex As Exception
				SetError($"[引发错误] {ex.Message}")
			End Try
		End If
		import.Dispose()
		rtx_content.Text = text
	End Sub

	Private Sub btn_theme_Click(sender As Object, e As EventArgs) Handles btn_theme.Click
		'改变主题颜色    #2021/02/09
		'判断
		If DarkTheme Then
			'窗体颜色
			BackColor = LightThemeBackColor
			ForeColor = LightThemeForeColor
			'遍历窗体内控件
			For Each control As Control In Controls
				control.BackColor = LightThemeBackColor
				control.ForeColor = LightThemeForeColor
				If control.Name.StartsWith("txt") Or control.Name.StartsWith("rtx_") Then
					control.BackColor = Color.FromKnownColor(KnownColor.White)
					Continue For
				End If
				If control.Name.StartsWith("btn_") Then
					control.BackColor = Color.FromKnownColor(KnownColor.ControlLight)
				End If
			Next
			'遍历容器
			For Each control As Control In gb_public.Controls
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
			For Each control As Control In gb_reg.Controls
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
			'表格
			DataGridView.BackgroundColor = LightThemeBackColor
			With DataGridView
				.ColumnHeadersDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.White)
				.ColumnHeadersDefaultCellStyle.ForeColor = LightThemeForeColor
				.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.White)
				.DefaultCellStyle.ForeColor = LightThemeForeColor
				.RowHeadersDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.White)
				.RowHeadersDefaultCellStyle.ForeColor = LightThemeForeColor
				.RowsDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.White)
				.RowsDefaultCellStyle.ForeColor = LightThemeForeColor
			End With
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
			For Each control As Control In gb_public.Controls
				control.BackColor = DaekThemeBackColor
				control.ForeColor = DarkThemeForeColor
			Next
			For Each control As Control In gb_reg.Controls
				control.BackColor = DaekThemeBackColor
				control.ForeColor = DarkThemeForeColor
			Next
			'表格
			DataGridView.BackgroundColor = DaekThemeBackColor
			With DataGridView
				.ColumnHeadersDefaultCellStyle.BackColor = DaekThemeBackColor
				.ColumnHeadersDefaultCellStyle.ForeColor = DarkThemeForeColor
				.DefaultCellStyle.BackColor = DaekThemeBackColor
				.DefaultCellStyle.ForeColor = DarkThemeForeColor
				.RowHeadersDefaultCellStyle.BackColor = DaekThemeBackColor
				.RowHeadersDefaultCellStyle.ForeColor = DarkThemeForeColor
				.RowsDefaultCellStyle.BackColor = DaekThemeBackColor
				.RowsDefaultCellStyle.ForeColor = DarkThemeForeColor
			End With
		End If
		DarkTheme = Not DarkTheme
	End Sub

	Private Sub btn_extract_Click(sender As Object, e As EventArgs) Handles btn_extract.Click
		'提取源字符串内容
		'查错
		If txt_startString.Text = "" Then
			SetError("未填写起始字符串（空值请填写{\0}）")
			Exit Sub
		ElseIf txt_endString.Text = "" Then
			SetError("未填写结束字符串（空值请填写{\0}）")
			Exit Sub
		End If
		Dim pattern As String = ""
		If txt_startString.Text = "{\0}" Then pattern += "\s\S" Else pattern += txt_startString.Text.Replace("{\t}", vbTab)
		pattern += "(.+?)"
		If txt_endString.Text = "{\0}" Then pattern += "\s\S" Else pattern += txt_endString.Text.Replace("{\t}", vbTab)
		InitCellHeader()
		Dim ar As New List(Of String)
		For Each match As Match In New Regex(pattern).Matches(rtx_content.Text.Replace(vbNewLine, "{\n}"))
			ar.Add(match.Value.Replace(txt_startString.Text, "").Replace(txt_endString.Text, "").Replace(vbNewLine, "{\n}").Replace("{\t}", vbTab)) '新增换行符可视化    #2021/02/09
		Next
		AddCells(ar.ToArray())
	End Sub

	Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
		'根据正则表达式提取字符串
		If txt_pattern.Text = "" Then SetError("未指定正则表达式，请验证输入！") : Exit Sub
		Dim reg As New Regex(txt_pattern.Text)
		InitCellHeader()
		For Each match As Match In reg.Matches(rtx_content.Text)
			AddCell(match.Value.Replace(vbNewLine, "{\n}")) '新增换行符可视化    #2021/02/09
		Next
	End Sub

	Private Sub btn_split_Click(sender As Object, e As EventArgs) Handles btn_split.Click
		'分割字符串
		If txt_split.Text = "" Then SetError("未指定分割字符或字符串，请验证输入！") : Exit Sub
		'新增对指令{\n}（表示换行）的支持    #2021/02/09
		'更新算法：使用 StringBuilder 优化速度和交互性    #2021/02/09
		Dim ar As String() = rtx_content.Text.Split(New StringBuilder(txt_split.Text).Replace("{\n}", vbNewLine).Replace("{\t}", vbTab).ToString())
		InitCellHeader()
		AddCells(ar)
	End Sub

	Private Sub btn_replace_Click(sender As Object, e As EventArgs) Handles btn_replace.Click
		'支持对正则表达式检索的的字符串进行替换    #2021/02/09
		If DataGridView.Rows.Count = 0 Then SetError("未指定需要被替换的字符串！") : Exit Sub
		Dim tar As String = txt_replace.Text
		If tar = "{\0}" Then tar = ""
		If tar = "{\n}" Then tar = vbNewLine
		Dim sb As New StringBuilder(rtx_content.Text)
		For Each row As DataGridViewRow In DataGridView.Rows
			If IsNothing(row.Cells(0).Value) Then Continue For
			sb.Replace(row.Cells(0).Value, tar)
		Next
		sb.Replace("{\n}", vbNewLine).Replace("{\0}", "").Replace("{\t}", vbTab)
		rtx_content.Text = sb.ToString()
	End Sub

	Private Sub rtx_content_TextChanged(sender As Object, e As EventArgs) Handles rtx_content.TextChanged
		'自动修正源字符串格式
		'需要优化算法
		Dim start As Integer = rtx_content.SelectionStart
		rtx_content.Text = New StringBuilder(rtx_content.Text).Replace(vbCr, vbNewLine).Replace(vbLf, vbNewLine).ToString()
		rtx_content.SelectionStart = start
	End Sub


	' 以下为自定义函数
	Private Sub InitCellHeader()
		'初始化datagridview
		DataGridView.SuspendLayout()
		'【遗留问题】 重绘滚动条 ScrollBar 的颜色
		'【遗留问题】 无法阻止单击排序
		With DataGridView.Columns
			.Clear()
			.Add("StringGroups", "字符串组 (String Groups)")
			.Item(0).Width = 330
		End With
	End Sub
	Private Sub AddCell(value As String)
		DataGridView.Rows.Add(value)
	End Sub
	Private Sub AddCells(value As String())
		For Each v As String In value
			DataGridView.Rows.Add(v)
		Next
	End Sub
	Private Sub SetError(value As String)
		'报错
		MsgBox("[错误提示] " + value, 0 + 16 + 4096, "出错啦 >_<| ")
	End Sub
End Class
