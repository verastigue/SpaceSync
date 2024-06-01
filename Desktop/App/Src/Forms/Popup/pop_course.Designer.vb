<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_course
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.cb_courseProg = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_courseDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_subjectCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_progHeader = New System.Windows.Forms.Label()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_done = New Guna.UI2.WinForms.Guna2Button()
        Me.cb_courseCred = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cb_courseYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.Interval = 200
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'cb_courseProg
        '
        Me.cb_courseProg.BackColor = System.Drawing.Color.Transparent
        Me.cb_courseProg.BorderRadius = 10
        Me.cb_courseProg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_courseProg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_courseProg.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_courseProg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_courseProg.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_courseProg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_courseProg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_courseProg.ItemHeight = 30
        Me.cb_courseProg.Location = New System.Drawing.Point(76, 424)
        Me.cb_courseProg.Name = "cb_courseProg"
        Me.cb_courseProg.ShadowDecoration.BorderRadius = 10
        Me.cb_courseProg.ShadowDecoration.Depth = 64
        Me.cb_courseProg.ShadowDecoration.Enabled = True
        Me.cb_courseProg.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cb_courseProg.Size = New System.Drawing.Size(429, 36)
        Me.cb_courseProg.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 404)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Program"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Credits"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Description"
        '
        'txt_courseDesc
        '
        Me.txt_courseDesc.BackColor = System.Drawing.Color.Transparent
        Me.txt_courseDesc.BorderRadius = 10
        Me.txt_courseDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_courseDesc.DefaultText = ""
        Me.txt_courseDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_courseDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_courseDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_courseDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_courseDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_courseDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_courseDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_courseDesc.Location = New System.Drawing.Point(76, 211)
        Me.txt_courseDesc.Multiline = True
        Me.txt_courseDesc.Name = "txt_courseDesc"
        Me.txt_courseDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_courseDesc.PlaceholderText = ""
        Me.txt_courseDesc.SelectedText = ""
        Me.txt_courseDesc.ShadowDecoration.BorderRadius = 10
        Me.txt_courseDesc.ShadowDecoration.Depth = 64
        Me.txt_courseDesc.ShadowDecoration.Enabled = True
        Me.txt_courseDesc.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txt_courseDesc.Size = New System.Drawing.Size(429, 95)
        Me.txt_courseDesc.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Subject Code"
        '
        'txt_subjectCode
        '
        Me.txt_subjectCode.BackColor = System.Drawing.Color.Transparent
        Me.txt_subjectCode.BorderRadius = 10
        Me.txt_subjectCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_subjectCode.DefaultText = ""
        Me.txt_subjectCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_subjectCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_subjectCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_subjectCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_subjectCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_subjectCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_subjectCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_subjectCode.Location = New System.Drawing.Point(76, 134)
        Me.txt_subjectCode.Name = "txt_subjectCode"
        Me.txt_subjectCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_subjectCode.PlaceholderText = ""
        Me.txt_subjectCode.SelectedText = ""
        Me.txt_subjectCode.ShadowDecoration.BorderRadius = 10
        Me.txt_subjectCode.ShadowDecoration.Depth = 64
        Me.txt_subjectCode.ShadowDecoration.Enabled = True
        Me.txt_subjectCode.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txt_subjectCode.Size = New System.Drawing.Size(429, 36)
        Me.txt_subjectCode.TabIndex = 23
        '
        'lbl_progHeader
        '
        Me.lbl_progHeader.AutoSize = True
        Me.lbl_progHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_progHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.lbl_progHeader.Location = New System.Drawing.Point(199, 61)
        Me.lbl_progHeader.Name = "lbl_progHeader"
        Me.lbl_progHeader.Size = New System.Drawing.Size(180, 29)
        Me.lbl_progHeader.TabIndex = 22
        Me.lbl_progHeader.Text = "ADD COURSE"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btn_cancel.BorderRadius = 10
        Me.btn_cancel.BorderThickness = 2
        Me.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cancel.FillColor = System.Drawing.Color.Snow
        Me.btn_cancel.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btn_cancel.Location = New System.Drawing.Point(76, 574)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.ShadowDecoration.BorderRadius = 10
        Me.btn_cancel.ShadowDecoration.Depth = 64
        Me.btn_cancel.ShadowDecoration.Enabled = True
        Me.btn_cancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btn_cancel.Size = New System.Drawing.Size(180, 45)
        Me.btn_cancel.TabIndex = 21
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_done
        '
        Me.btn_done.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_done.BackColor = System.Drawing.Color.Transparent
        Me.btn_done.BorderRadius = 10
        Me.btn_done.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_done.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_done.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_done.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_done.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btn_done.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btn_done.ForeColor = System.Drawing.Color.Snow
        Me.btn_done.Location = New System.Drawing.Point(325, 574)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.ShadowDecoration.BorderRadius = 10
        Me.btn_done.ShadowDecoration.Depth = 64
        Me.btn_done.ShadowDecoration.Enabled = True
        Me.btn_done.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btn_done.Size = New System.Drawing.Size(180, 45)
        Me.btn_done.TabIndex = 20
        Me.btn_done.Text = "Done"
        '
        'cb_courseCred
        '
        Me.cb_courseCred.BackColor = System.Drawing.Color.Transparent
        Me.cb_courseCred.BorderRadius = 10
        Me.cb_courseCred.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_courseCred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_courseCred.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_courseCred.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_courseCred.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_courseCred.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_courseCred.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_courseCred.ItemHeight = 30
        Me.cb_courseCred.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cb_courseCred.Location = New System.Drawing.Point(76, 347)
        Me.cb_courseCred.Name = "cb_courseCred"
        Me.cb_courseCred.ShadowDecoration.BorderRadius = 10
        Me.cb_courseCred.ShadowDecoration.Depth = 64
        Me.cb_courseCred.ShadowDecoration.Enabled = True
        Me.cb_courseCred.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cb_courseCred.Size = New System.Drawing.Size(429, 36)
        Me.cb_courseCred.TabIndex = 31
        '
        'cb_courseYear
        '
        Me.cb_courseYear.BackColor = System.Drawing.Color.Transparent
        Me.cb_courseYear.BorderRadius = 10
        Me.cb_courseYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_courseYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_courseYear.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_courseYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_courseYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_courseYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_courseYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_courseYear.ItemHeight = 30
        Me.cb_courseYear.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cb_courseYear.Location = New System.Drawing.Point(76, 493)
        Me.cb_courseYear.Name = "cb_courseYear"
        Me.cb_courseYear.ShadowDecoration.BorderRadius = 10
        Me.cb_courseYear.ShadowDecoration.Depth = 64
        Me.cb_courseYear.ShadowDecoration.Enabled = True
        Me.cb_courseYear.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cb_courseYear.Size = New System.Drawing.Size(429, 36)
        Me.cb_courseYear.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 473)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Year"
        '
        'pop_course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 680)
        Me.Controls.Add(Me.cb_courseYear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_courseCred)
        Me.Controls.Add(Me.cb_courseProg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_courseDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_subjectCode)
        Me.Controls.Add(Me.lbl_progHeader)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_done)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pop_course"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "pop_course"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents cb_courseProg As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_courseDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_subjectCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_progHeader As Label
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_done As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cb_courseYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_courseCred As Guna.UI2.WinForms.Guna2ComboBox
End Class
