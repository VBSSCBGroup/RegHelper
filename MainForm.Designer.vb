<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
	Inherits System.Windows.Forms.Form

	'Form 重写 Dispose，以清理组件列表。
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Windows 窗体设计器所必需的
	Private components As System.ComponentModel.IContainer

	'注意: 以下过程是 Windows 窗体设计器所必需的
	'可以使用 Windows 窗体设计器修改它。  
	'不要使用代码编辑器修改它。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
		Me.rtx_content = New System.Windows.Forms.RichTextBox()
		Me.lb_rtxTitle = New System.Windows.Forms.Label()
		Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.DataGridView = New System.Windows.Forms.DataGridView()
		Me.StringGroups = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.gb_public = New System.Windows.Forms.GroupBox()
		Me.btn_theme = New System.Windows.Forms.Button()
		Me.btn_importPage = New System.Windows.Forms.Button()
		Me.btn_clearContent = New System.Windows.Forms.Button()
		Me.btn_clearData = New System.Windows.Forms.Button()
		Me.btn_upgrade = New System.Windows.Forms.Button()
		Me.gb_reg = New System.Windows.Forms.GroupBox()
		Me.btn_split = New System.Windows.Forms.Button()
		Me.btn_extract = New System.Windows.Forms.Button()
		Me.btn_replace = New System.Windows.Forms.Button()
		Me.btn_select = New System.Windows.Forms.Button()
		Me.txt_replace = New System.Windows.Forms.TextBox()
		Me.txt_endString = New System.Windows.Forms.TextBox()
		Me.txt_startString = New System.Windows.Forms.TextBox()
		Me.lb_endString = New System.Windows.Forms.Label()
		Me.txt_split = New System.Windows.Forms.TextBox()
		Me.txt_pattern = New System.Windows.Forms.TextBox()
		Me.lb_startString = New System.Windows.Forms.Label()
		Me.lb_replace = New System.Windows.Forms.Label()
		Me.lb_pattern = New System.Windows.Forms.Label()
		Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
		CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gb_public.SuspendLayout()
		Me.gb_reg.SuspendLayout()
		Me.SuspendLayout()
		'
		'BackgroundWorker
		'
		Me.BackgroundWorker.WorkerReportsProgress = True
		Me.BackgroundWorker.WorkerSupportsCancellation = True
		'
		'rtx_content
		'
		Me.rtx_content.AcceptsTab = True
		Me.rtx_content.AutoWordSelection = True
		Me.rtx_content.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.rtx_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.rtx_content.EnableAutoDragDrop = True
		Me.rtx_content.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.rtx_content.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.rtx_content.Location = New System.Drawing.Point(12, 60)
		Me.rtx_content.Name = "rtx_content"
		Me.rtx_content.Size = New System.Drawing.Size(468, 539)
		Me.rtx_content.TabIndex = 0
		Me.rtx_content.Text = ""
		'
		'lb_rtxTitle
		'
		Me.lb_rtxTitle.AutoSize = True
		Me.lb_rtxTitle.BackColor = System.Drawing.Color.Transparent
		Me.lb_rtxTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.lb_rtxTitle.Font = New System.Drawing.Font("宋体", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lb_rtxTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.lb_rtxTitle.Location = New System.Drawing.Point(12, 19)
		Me.lb_rtxTitle.Name = "lb_rtxTitle"
		Me.lb_rtxTitle.Size = New System.Drawing.Size(398, 29)
		Me.lb_rtxTitle.TabIndex = 1
		Me.lb_rtxTitle.Text = "源字符串 (Source String)："
		'
		'NotifyIcon
		'
		Me.NotifyIcon.BalloonTipTitle = "String Parser"
		Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
		Me.NotifyIcon.Text = "String Parser"
		Me.NotifyIcon.Visible = True
		'
		'DataGridView
		'
		Me.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		DataGridViewCellStyle9.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlLightLight
		DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.CornflowerBlue
		DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
		DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
		Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StringGroups})
		DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		DataGridViewCellStyle10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlLightLight
		DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.CornflowerBlue
		DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
		DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle10
		Me.DataGridView.EnableHeadersVisualStyles = False
		Me.DataGridView.Location = New System.Drawing.Point(501, 60)
		Me.DataGridView.Name = "DataGridView"
		DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		DataGridViewCellStyle11.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlLightLight
		DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CornflowerBlue
		DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
		DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
		DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlLightLight
		DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.CornflowerBlue
		DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle12
		Me.DataGridView.RowTemplate.Height = 23
		Me.DataGridView.Size = New System.Drawing.Size(380, 539)
		Me.DataGridView.TabIndex = 5
		'
		'StringGroups
		'
		Me.StringGroups.HeaderText = "字符串组 (String Groups)"
		Me.StringGroups.Name = "StringGroups"
		Me.StringGroups.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.StringGroups.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.StringGroups.Width = 330
		'
		'gb_public
		'
		Me.gb_public.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.gb_public.Controls.Add(Me.btn_theme)
		Me.gb_public.Controls.Add(Me.btn_importPage)
		Me.gb_public.Controls.Add(Me.btn_clearContent)
		Me.gb_public.Controls.Add(Me.btn_clearData)
		Me.gb_public.Controls.Add(Me.btn_upgrade)
		Me.gb_public.Font = New System.Drawing.Font("宋体", 11.0!)
		Me.gb_public.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.gb_public.Location = New System.Drawing.Point(896, 60)
		Me.gb_public.Name = "gb_public"
		Me.gb_public.Size = New System.Drawing.Size(176, 174)
		Me.gb_public.TabIndex = 3
		Me.gb_public.TabStop = False
		Me.gb_public.Text = "主操作"
		'
		'btn_theme
		'
		Me.btn_theme.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.btn_theme.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.btn_theme.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btn_theme.Location = New System.Drawing.Point(6, 140)
		Me.btn_theme.Name = "btn_theme"
		Me.btn_theme.Size = New System.Drawing.Size(164, 23)
		Me.btn_theme.TabIndex = 30
		Me.btn_theme.Text = "更换主题"
		Me.btn_theme.UseVisualStyleBackColor = False
		'
		'btn_importPage
		'
		Me.btn_importPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.btn_importPage.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.btn_importPage.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btn_importPage.Location = New System.Drawing.Point(6, 111)
		Me.btn_importPage.Name = "btn_importPage"
		Me.btn_importPage.Size = New System.Drawing.Size(164, 23)
		Me.btn_importPage.TabIndex = 25
		Me.btn_importPage.Text = "从页面/文件导入"
		Me.btn_importPage.UseVisualStyleBackColor = False
		'
		'btn_clearContent
		'
		Me.btn_clearContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.btn_clearContent.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.btn_clearContent.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btn_clearContent.Location = New System.Drawing.Point(6, 82)
		Me.btn_clearContent.Name = "btn_clearContent"
		Me.btn_clearContent.Size = New System.Drawing.Size(164, 23)
		Me.btn_clearContent.TabIndex = 20
		Me.btn_clearContent.Text = "清空源字符串"
		Me.btn_clearContent.UseVisualStyleBackColor = False
		'
		'btn_clearData
		'
		Me.btn_clearData.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.btn_clearData.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.btn_clearData.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btn_clearData.Location = New System.Drawing.Point(6, 53)
		Me.btn_clearData.Name = "btn_clearData"
		Me.btn_clearData.Size = New System.Drawing.Size(164, 23)
		Me.btn_clearData.TabIndex = 15
		Me.btn_clearData.Text = "清空表格内容"
		Me.btn_clearData.UseVisualStyleBackColor = False
		'
		'btn_upgrade
		'
		Me.btn_upgrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.btn_upgrade.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.btn_upgrade.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btn_upgrade.Location = New System.Drawing.Point(6, 24)
		Me.btn_upgrade.Name = "btn_upgrade"
		Me.btn_upgrade.Size = New System.Drawing.Size(164, 23)
		Me.btn_upgrade.TabIndex = 10
		Me.btn_upgrade.Text = "更新到源字符串"
		Me.btn_upgrade.UseVisualStyleBackColor = False
		'
		'gb_reg
		'
		Me.gb_reg.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.gb_reg.Controls.Add(Me.btn_split)
		Me.gb_reg.Controls.Add(Me.btn_extract)
		Me.gb_reg.Controls.Add(Me.btn_replace)
		Me.gb_reg.Controls.Add(Me.btn_select)
		Me.gb_reg.Controls.Add(Me.txt_replace)
		Me.gb_reg.Controls.Add(Me.txt_endString)
		Me.gb_reg.Controls.Add(Me.txt_startString)
		Me.gb_reg.Controls.Add(Me.lb_endString)
		Me.gb_reg.Controls.Add(Me.txt_split)
		Me.gb_reg.Controls.Add(Me.txt_pattern)
		Me.gb_reg.Controls.Add(Me.lb_startString)
		Me.gb_reg.Controls.Add(Me.lb_replace)
		Me.gb_reg.Controls.Add(Me.lb_pattern)
		Me.gb_reg.Font = New System.Drawing.Font("宋体", 11.0!)
		Me.gb_reg.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.gb_reg.Location = New System.Drawing.Point(896, 264)
		Me.gb_reg.Name = "gb_reg"
		Me.gb_reg.Size = New System.Drawing.Size(176, 290)
		Me.gb_reg.TabIndex = 3
		Me.gb_reg.TabStop = False
		Me.gb_reg.Text = "正则表达式 (RegEx)"
		'
		'btn_split
		'
		Me.btn_split.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.btn_split.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.btn_split.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btn_split.Location = New System.Drawing.Point(125, 260)
		Me.btn_split.Name = "btn_split"
		Me.btn_split.Size = New System.Drawing.Size(45, 23)
		Me.btn_split.TabIndex = 70
		Me.btn_split.Text = "分割"
		Me.btn_split.UseVisualStyleBackColor = False
		'
		'btn_extract
		'
		Me.btn_extract.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.btn_extract.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.btn_extract.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btn_extract.Location = New System.Drawing.Point(6, 231)
		Me.btn_extract.Name = "btn_extract"
		Me.btn_extract.Size = New System.Drawing.Size(164, 23)
		Me.btn_extract.TabIndex = 60
		Me.btn_extract.Text = "抽取"
		Me.btn_extract.UseVisualStyleBackColor = False
		'
		'btn_replace
		'
		Me.btn_replace.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.btn_replace.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.btn_replace.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btn_replace.Location = New System.Drawing.Point(6, 111)
		Me.btn_replace.Name = "btn_replace"
		Me.btn_replace.Size = New System.Drawing.Size(164, 23)
		Me.btn_replace.TabIndex = 45
		Me.btn_replace.Text = "替换"
		Me.btn_replace.UseVisualStyleBackColor = False
		'
		'btn_select
		'
		Me.btn_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.btn_select.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.btn_select.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btn_select.Location = New System.Drawing.Point(6, 53)
		Me.btn_select.Name = "btn_select"
		Me.btn_select.Size = New System.Drawing.Size(164, 23)
		Me.btn_select.TabIndex = 6
		Me.btn_select.Text = "查找"
		Me.btn_select.UseVisualStyleBackColor = False
		'
		'txt_replace
		'
		Me.txt_replace.AllowDrop = True
		Me.txt_replace.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.txt_replace.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.txt_replace.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.txt_replace.Location = New System.Drawing.Point(70, 82)
		Me.txt_replace.Name = "txt_replace"
		Me.txt_replace.Size = New System.Drawing.Size(100, 23)
		Me.txt_replace.TabIndex = 40
		'
		'txt_endString
		'
		Me.txt_endString.AllowDrop = True
		Me.txt_endString.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.txt_endString.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.txt_endString.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.txt_endString.Location = New System.Drawing.Point(6, 202)
		Me.txt_endString.Name = "txt_endString"
		Me.txt_endString.Size = New System.Drawing.Size(164, 23)
		Me.txt_endString.TabIndex = 55
		'
		'txt_startString
		'
		Me.txt_startString.AllowDrop = True
		Me.txt_startString.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.txt_startString.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.txt_startString.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.txt_startString.Location = New System.Drawing.Point(6, 159)
		Me.txt_startString.Name = "txt_startString"
		Me.txt_startString.Size = New System.Drawing.Size(164, 23)
		Me.txt_startString.TabIndex = 50
		'
		'lb_endString
		'
		Me.lb_endString.AutoSize = True
		Me.lb_endString.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.lb_endString.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.lb_endString.Location = New System.Drawing.Point(6, 185)
		Me.lb_endString.Name = "lb_endString"
		Me.lb_endString.Size = New System.Drawing.Size(91, 14)
		Me.lb_endString.TabIndex = 0
		Me.lb_endString.Text = "终止字符串："
		'
		'txt_split
		'
		Me.txt_split.AllowDrop = True
		Me.txt_split.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.txt_split.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.txt_split.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.txt_split.Location = New System.Drawing.Point(6, 260)
		Me.txt_split.Name = "txt_split"
		Me.txt_split.Size = New System.Drawing.Size(113, 23)
		Me.txt_split.TabIndex = 65
		'
		'txt_pattern
		'
		Me.txt_pattern.AllowDrop = True
		Me.txt_pattern.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.txt_pattern.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.txt_pattern.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.txt_pattern.Location = New System.Drawing.Point(70, 24)
		Me.txt_pattern.Name = "txt_pattern"
		Me.txt_pattern.Size = New System.Drawing.Size(100, 23)
		Me.txt_pattern.TabIndex = 35
		'
		'lb_startString
		'
		Me.lb_startString.AutoSize = True
		Me.lb_startString.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.lb_startString.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.lb_startString.Location = New System.Drawing.Point(6, 142)
		Me.lb_startString.Name = "lb_startString"
		Me.lb_startString.Size = New System.Drawing.Size(91, 14)
		Me.lb_startString.TabIndex = 0
		Me.lb_startString.Text = "起始字符串："
		'
		'lb_replace
		'
		Me.lb_replace.AutoSize = True
		Me.lb_replace.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.lb_replace.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.lb_replace.Location = New System.Drawing.Point(6, 85)
		Me.lb_replace.Name = "lb_replace"
		Me.lb_replace.Size = New System.Drawing.Size(63, 14)
		Me.lb_replace.TabIndex = 0
		Me.lb_replace.Text = "替换为："
		'
		'lb_pattern
		'
		Me.lb_pattern.AutoSize = True
		Me.lb_pattern.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.lb_pattern.Font = New System.Drawing.Font("宋体", 10.0!)
		Me.lb_pattern.Location = New System.Drawing.Point(6, 26)
		Me.lb_pattern.Name = "lb_pattern"
		Me.lb_pattern.Size = New System.Drawing.Size(63, 14)
		Me.lb_pattern.TabIndex = 0
		Me.lb_pattern.Text = "表达式："
		'
		'ToolTip
		'
		Me.ToolTip.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.ToolTip.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.ToolTip.IsBalloon = True
		Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.ToolTip.ToolTipTitle = "提示："
		'
		'MainForm
		'
		Me.AllowDrop = True
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1084, 611)
		Me.Controls.Add(Me.gb_reg)
		Me.Controls.Add(Me.gb_public)
		Me.Controls.Add(Me.DataGridView)
		Me.Controls.Add(Me.lb_rtxTitle)
		Me.Controls.Add(Me.rtx_content)
		Me.DoubleBuffered = True
		Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.Text = "String Parser (Beta)"
		CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gb_public.ResumeLayout(False)
		Me.gb_reg.ResumeLayout(False)
		Me.gb_reg.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
	Friend WithEvents rtx_content As RichTextBox
	Friend WithEvents lb_rtxTitle As Label
	Friend WithEvents DataGridView As DataGridView
	Friend WithEvents NotifyIcon As NotifyIcon
	Friend WithEvents gb_public As GroupBox
	Friend WithEvents StringGroups As DataGridViewTextBoxColumn
	Friend WithEvents gb_reg As GroupBox
	Friend WithEvents btn_extract As Button
	Friend WithEvents btn_replace As Button
	Friend WithEvents btn_select As Button
	Friend WithEvents txt_replace As TextBox
	Friend WithEvents txt_endString As TextBox
	Friend WithEvents txt_startString As TextBox
	Friend WithEvents lb_endString As Label
	Friend WithEvents txt_pattern As TextBox
	Friend WithEvents lb_startString As Label
	Friend WithEvents lb_replace As Label
	Friend WithEvents lb_pattern As Label
	Friend WithEvents btn_clearContent As Button
	Friend WithEvents btn_clearData As Button
	Friend WithEvents btn_upgrade As Button
	Friend WithEvents btn_split As Button
	Friend WithEvents txt_split As TextBox
	Friend WithEvents btn_theme As Button
	Friend WithEvents btn_importPage As Button
	Friend WithEvents ToolTip As ToolTip
End Class
