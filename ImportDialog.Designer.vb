<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportDialog
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportDialog))
		Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
		Me.OK_Button = New System.Windows.Forms.Button()
		Me.Cancel_Button = New System.Windows.Forms.Button()
		Me.txt_uri = New System.Windows.Forms.TextBox()
		Me.lb_uri = New System.Windows.Forms.Label()
		Me.rb_site = New System.Windows.Forms.RadioButton()
		Me.rb_file = New System.Windows.Forms.RadioButton()
		Me.TableLayoutPanel.SuspendLayout()
		Me.SuspendLayout()
		'
		'TableLayoutPanel
		'
		Me.TableLayoutPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel.ColumnCount = 2
		Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel.Controls.Add(Me.OK_Button, 0, 0)
		Me.TableLayoutPanel.Controls.Add(Me.Cancel_Button, 1, 0)
		Me.TableLayoutPanel.Location = New System.Drawing.Point(277, 55)
		Me.TableLayoutPanel.Name = "TableLayoutPanel"
		Me.TableLayoutPanel.RowCount = 1
		Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel.Size = New System.Drawing.Size(146, 27)
		Me.TableLayoutPanel.TabIndex = 0
		'
		'OK_Button
		'
		Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.OK_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.OK_Button.Location = New System.Drawing.Point(3, 3)
		Me.OK_Button.Name = "OK_Button"
		Me.OK_Button.Size = New System.Drawing.Size(67, 21)
		Me.OK_Button.TabIndex = 0
		Me.OK_Button.Text = "确定"
		'
		'Cancel_Button
		'
		Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Cancel_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
		Me.Cancel_Button.Name = "Cancel_Button"
		Me.Cancel_Button.Size = New System.Drawing.Size(67, 21)
		Me.Cancel_Button.TabIndex = 1
		Me.Cancel_Button.Text = "取消"
		'
		'txt_uri
		'
		Me.txt_uri.AllowDrop = True
		Me.txt_uri.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.txt_uri.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.txt_uri.Location = New System.Drawing.Point(99, 14)
		Me.txt_uri.Name = "txt_uri"
		Me.txt_uri.Size = New System.Drawing.Size(324, 21)
		Me.txt_uri.TabIndex = 1
		'
		'lb_uri
		'
		Me.lb_uri.AutoSize = True
		Me.lb_uri.BackColor = System.Drawing.Color.Transparent
		Me.lb_uri.Font = New System.Drawing.Font("宋体", 10.5!)
		Me.lb_uri.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.lb_uri.Location = New System.Drawing.Point(12, 13)
		Me.lb_uri.Name = "lb_uri"
		Me.lb_uri.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
		Me.lb_uri.Size = New System.Drawing.Size(79, 20)
		Me.lb_uri.TabIndex = 2
		Me.lb_uri.Text = "链接/路径:"
		'
		'rb_site
		'
		Me.rb_site.AutoSize = True
		Me.rb_site.Checked = True
		Me.rb_site.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.rb_site.Location = New System.Drawing.Point(28, 60)
		Me.rb_site.Name = "rb_site"
		Me.rb_site.Size = New System.Drawing.Size(107, 16)
		Me.rb_site.TabIndex = 3
		Me.rb_site.TabStop = True
		Me.rb_site.Text = "导入链接 (URL)"
		Me.rb_site.UseVisualStyleBackColor = True
		'
		'rb_file
		'
		Me.rb_file.AutoSize = True
		Me.rb_file.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.rb_file.Location = New System.Drawing.Point(178, 60)
		Me.rb_file.Name = "rb_file"
		Me.rb_file.Size = New System.Drawing.Size(71, 16)
		Me.rb_file.TabIndex = 3
		Me.rb_file.Text = "导入文件"
		Me.rb_file.UseVisualStyleBackColor = True
		'
		'ImportDialog
		'
		Me.AcceptButton = Me.OK_Button
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
		Me.CancelButton = Me.Cancel_Button
		Me.ClientSize = New System.Drawing.Size(435, 99)
		Me.Controls.Add(Me.rb_file)
		Me.Controls.Add(Me.rb_site)
		Me.Controls.Add(Me.lb_uri)
		Me.Controls.Add(Me.txt_uri)
		Me.Controls.Add(Me.TableLayoutPanel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "ImportDialog"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "导入链接/路径"
		Me.TableLayoutPanel.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents OK_Button As System.Windows.Forms.Button
	Friend WithEvents Cancel_Button As System.Windows.Forms.Button
	Friend WithEvents txt_uri As TextBox
	Friend WithEvents lb_uri As Label
	Friend WithEvents rb_site As RadioButton
	Friend WithEvents rb_file As RadioButton
End Class
