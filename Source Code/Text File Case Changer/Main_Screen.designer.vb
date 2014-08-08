<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Screen))
        Me.startAsyncButton1 = New System.Windows.Forms.Button
        Me.Status_Textbox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.FullErrors_Checkbox = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.InputTargetFileType_Textbox = New System.Windows.Forms.TextBox
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.InputTargetFile_Textbox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Browse1_Button = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.cancelAsyncButton = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.inputsuccess_label = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lastinputline_label = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.datelaunched_label = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.inputlines_label = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.StatusResults_RichtextBox = New System.Windows.Forms.RichTextBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'startAsyncButton1
        '
        Me.startAsyncButton1.Location = New System.Drawing.Point(32, 337)
        Me.startAsyncButton1.Name = "startAsyncButton1"
        Me.startAsyncButton1.Size = New System.Drawing.Size(109, 23)
        Me.startAsyncButton1.TabIndex = 15
        Me.startAsyncButton1.Text = "Change Case!"
        Me.startAsyncButton1.UseVisualStyleBackColor = True
        '
        'Status_Textbox
        '
        Me.Status_Textbox.BackColor = System.Drawing.Color.White
        Me.Status_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Status_Textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_Textbox.ForeColor = System.Drawing.Color.Maroon
        Me.Status_Textbox.Location = New System.Drawing.Point(12, 8)
        Me.Status_Textbox.Name = "Status_Textbox"
        Me.Status_Textbox.ReadOnly = True
        Me.Status_Textbox.Size = New System.Drawing.Size(217, 10)
        Me.Status_Textbox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Version {0}{1:00}{2:00}.{3}"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.Label1, "Application Build Number")
        '
        'FullErrors_Checkbox
        '
        Me.FullErrors_Checkbox.AutoSize = True
        Me.FullErrors_Checkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullErrors_Checkbox.Location = New System.Drawing.Point(367, 8)
        Me.FullErrors_Checkbox.Name = "FullErrors_Checkbox"
        Me.FullErrors_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.FullErrors_Checkbox.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.FullErrors_Checkbox, "Check to enable full error processing mode.")
        Me.FullErrors_Checkbox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(370, 36)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "To change the case of a plain text file's contents, simply select a file, select " & _
            "your choice and hit the 'Change Case' button to proceed."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.InputTargetFileType_Textbox)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.InputTargetFile_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Browse1_Button)
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(15, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 106)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(199, 58)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(83, 17)
        Me.RadioButton5.TabIndex = 42
        Me.RadioButton5.Text = "Proper Case"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'InputTargetFileType_Textbox
        '
        Me.InputTargetFileType_Textbox.Location = New System.Drawing.Point(352, 30)
        Me.InputTargetFileType_Textbox.Name = "InputTargetFileType_Textbox"
        Me.InputTargetFileType_Textbox.Size = New System.Drawing.Size(19, 20)
        Me.InputTargetFileType_Textbox.TabIndex = 41
        Me.InputTargetFileType_Textbox.Text = "1"
        Me.InputTargetFileType_Textbox.Visible = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(100, 81)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton4.TabIndex = 40
        Me.RadioButton4.Text = "Sentence case"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(18, 81)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton3.TabIndex = 39
        Me.RadioButton3.Text = "Title Case"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(100, 58)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(93, 17)
        Me.RadioButton2.TabIndex = 38
        Me.RadioButton2.Text = "UPPER CASE"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(18, 58)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton1.TabIndex = 37
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "lower case"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'InputTargetFile_Textbox
        '
        Me.InputTargetFile_Textbox.AllowDrop = True
        Me.InputTargetFile_Textbox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.InputTargetFile_Textbox.Location = New System.Drawing.Point(17, 32)
        Me.InputTargetFile_Textbox.Name = "InputTargetFile_Textbox"
        Me.InputTargetFile_Textbox.ReadOnly = True
        Me.InputTargetFile_Textbox.Size = New System.Drawing.Size(265, 20)
        Me.InputTargetFile_Textbox.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Source Text File:"
        '
        'Browse1_Button
        '
        Me.Browse1_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse1_Button.Location = New System.Drawing.Point(288, 30)
        Me.Browse1_Button.Name = "Browse1_Button"
        Me.Browse1_Button.Size = New System.Drawing.Size(53, 23)
        Me.Browse1_Button.TabIndex = 25
        Me.Browse1_Button.Text = "Browse"
        Me.Browse1_Button.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(264, 347)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(97, 13)
        Me.LinkLabel1.TabIndex = 40
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "[Open Activity Log]"
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "Open activity log")
        Me.LinkLabel1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.SteelBlue
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 376)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(361, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 39
        '
        'cancelAsyncButton
        '
        Me.cancelAsyncButton.Enabled = False
        Me.cancelAsyncButton.Location = New System.Drawing.Point(147, 337)
        Me.cancelAsyncButton.Name = "cancelAsyncButton"
        Me.cancelAsyncButton.Size = New System.Drawing.Size(111, 23)
        Me.cancelAsyncButton.TabIndex = 38
        Me.cancelAsyncButton.Text = "Cancel"
        Me.cancelAsyncButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.inputsuccess_label)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lastinputline_label)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.datelaunched_label)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.inputlines_label)
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(15, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 134)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operation Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(14, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Lines Written:"
        '
        'inputsuccess_label
        '
        Me.inputsuccess_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputsuccess_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inputsuccess_label.Location = New System.Drawing.Point(110, 43)
        Me.inputsuccess_label.Name = "inputsuccess_label"
        Me.inputsuccess_label.Size = New System.Drawing.Size(236, 23)
        Me.inputsuccess_label.TabIndex = 32
        Me.inputsuccess_label.Text = "(no result)"
        Me.inputsuccess_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(15, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Last Line Parsed:"
        '
        'lastinputline_label
        '
        Me.lastinputline_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastinputline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lastinputline_label.Location = New System.Drawing.Point(110, 72)
        Me.lastinputline_label.Name = "lastinputline_label"
        Me.lastinputline_label.Size = New System.Drawing.Size(236, 23)
        Me.lastinputline_label.TabIndex = 20
        Me.lastinputline_label.Text = "(no result)"
        Me.lastinputline_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(14, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Operational Time:"
        '
        'datelaunched_label
        '
        Me.datelaunched_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datelaunched_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datelaunched_label.Location = New System.Drawing.Point(110, 99)
        Me.datelaunched_label.Name = "datelaunched_label"
        Me.datelaunched_label.Size = New System.Drawing.Size(236, 23)
        Me.datelaunched_label.TabIndex = 23
        Me.datelaunched_label.Text = "(no result)"
        Me.datelaunched_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(15, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Lines Parsed:"
        '
        'inputlines_label
        '
        Me.inputlines_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputlines_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inputlines_label.Location = New System.Drawing.Point(110, 18)
        Me.inputlines_label.Name = "inputlines_label"
        Me.inputlines_label.Size = New System.Drawing.Size(236, 23)
        Me.inputlines_label.TabIndex = 25
        Me.inputlines_label.Text = "(no result)"
        Me.inputlines_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Status_Textbox)
        Me.Panel1.Controls.Add(Me.FullErrors_Checkbox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 493)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 31)
        Me.Panel1.TabIndex = 42
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Location = New System.Drawing.Point(264, 334)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(91, 13)
        Me.LinkLabel2.TabIndex = 57
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "[Open Result File]"
        Me.ToolTip1.SetToolTip(Me.LinkLabel2, "Open last file generated")
        Me.LinkLabel2.Visible = False
        '
        'StatusResults_RichtextBox
        '
        Me.StatusResults_RichtextBox.BackColor = System.Drawing.Color.White
        Me.StatusResults_RichtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StatusResults_RichtextBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.StatusResults_RichtextBox.ForeColor = System.Drawing.Color.SteelBlue
        Me.StatusResults_RichtextBox.Location = New System.Drawing.Point(15, 407)
        Me.StatusResults_RichtextBox.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.StatusResults_RichtextBox.Name = "StatusResults_RichtextBox"
        Me.StatusResults_RichtextBox.ReadOnly = True
        Me.StatusResults_RichtextBox.Size = New System.Drawing.Size(359, 80)
        Me.StatusResults_RichtextBox.TabIndex = 43
        Me.StatusResults_RichtextBox.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(152, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem1.Text = "Clear Window"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(392, 24)
        Me.MenuStrip1.TabIndex = 56
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Main_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(392, 524)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusResults_RichtextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.cancelAsyncButton)
        Me.Controls.Add(Me.startAsyncButton1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 558)
        Me.MinimumSize = New System.Drawing.Size(400, 558)
        Me.Name = "Main_Screen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startAsyncButton1 As System.Windows.Forms.Button
    Friend WithEvents Status_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FullErrors_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Browse1_Button As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents cancelAsyncButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents lastinputline_label As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents datelaunched_label As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents inputlines_label As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents InputTargetFile_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents StatusResults_RichtextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents inputsuccess_label As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents InputTargetFileType_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel

End Class
