<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pop_section
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_done = New Guna.UI2.WinForms.Guna2Button()
        Me.ckb_1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ckb_2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ckb_3 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ckb_4 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ckb_5 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cb_secProgCode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lbl_progHeader = New System.Windows.Forms.Label()
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Name"
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.Transparent
        Me.txt_name.BorderRadius = 10
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.DefaultText = ""
        Me.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_name.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_name.Location = New System.Drawing.Point(76, 289)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.PlaceholderText = ""
        Me.txt_name.SelectedText = ""
        Me.txt_name.ShadowDecoration.BorderRadius = 10
        Me.txt_name.ShadowDecoration.Depth = 64
        Me.txt_name.ShadowDecoration.Enabled = True
        Me.txt_name.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txt_name.Size = New System.Drawing.Size(429, 36)
        Me.txt_name.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Year/s"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Program Code"
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
        Me.btn_cancel.Location = New System.Drawing.Point(79, 394)
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
        Me.btn_done.Location = New System.Drawing.Point(328, 394)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.ShadowDecoration.BorderRadius = 10
        Me.btn_done.ShadowDecoration.Depth = 64
        Me.btn_done.ShadowDecoration.Enabled = True
        Me.btn_done.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btn_done.Size = New System.Drawing.Size(180, 45)
        Me.btn_done.TabIndex = 20
        Me.btn_done.Text = "Done"
        '
        'ckb_1
        '
        Me.ckb_1.AutoSize = True
        Me.ckb_1.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ckb_1.CheckedState.BorderRadius = 0
        Me.ckb_1.CheckedState.BorderThickness = 0
        Me.ckb_1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_1.CheckMarkColor = System.Drawing.Color.Snow
        Me.ckb_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ckb_1.Location = New System.Drawing.Point(79, 222)
        Me.ckb_1.Name = "ckb_1"
        Me.ckb_1.Size = New System.Drawing.Size(37, 24)
        Me.ckb_1.TabIndex = 31
        Me.ckb_1.Text = "1"
        Me.ckb_1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_1.UncheckedState.BorderRadius = 0
        Me.ckb_1.UncheckedState.BorderThickness = 2
        Me.ckb_1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'ckb_2
        '
        Me.ckb_2.AutoSize = True
        Me.ckb_2.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ckb_2.CheckedState.BorderRadius = 0
        Me.ckb_2.CheckedState.BorderThickness = 0
        Me.ckb_2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_2.CheckMarkColor = System.Drawing.Color.Snow
        Me.ckb_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ckb_2.Location = New System.Drawing.Point(176, 222)
        Me.ckb_2.Name = "ckb_2"
        Me.ckb_2.Size = New System.Drawing.Size(37, 24)
        Me.ckb_2.TabIndex = 32
        Me.ckb_2.Text = "2"
        Me.ckb_2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_2.UncheckedState.BorderRadius = 0
        Me.ckb_2.UncheckedState.BorderThickness = 2
        Me.ckb_2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'ckb_3
        '
        Me.ckb_3.AutoSize = True
        Me.ckb_3.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ckb_3.CheckedState.BorderRadius = 0
        Me.ckb_3.CheckedState.BorderThickness = 0
        Me.ckb_3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_3.CheckMarkColor = System.Drawing.Color.Snow
        Me.ckb_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ckb_3.Location = New System.Drawing.Point(273, 222)
        Me.ckb_3.Name = "ckb_3"
        Me.ckb_3.Size = New System.Drawing.Size(37, 24)
        Me.ckb_3.TabIndex = 33
        Me.ckb_3.Text = "3"
        Me.ckb_3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_3.UncheckedState.BorderRadius = 0
        Me.ckb_3.UncheckedState.BorderThickness = 2
        Me.ckb_3.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'ckb_4
        '
        Me.ckb_4.AutoSize = True
        Me.ckb_4.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ckb_4.CheckedState.BorderRadius = 0
        Me.ckb_4.CheckedState.BorderThickness = 0
        Me.ckb_4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_4.CheckMarkColor = System.Drawing.Color.Snow
        Me.ckb_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ckb_4.Location = New System.Drawing.Point(370, 222)
        Me.ckb_4.Name = "ckb_4"
        Me.ckb_4.Size = New System.Drawing.Size(37, 24)
        Me.ckb_4.TabIndex = 34
        Me.ckb_4.Text = "4"
        Me.ckb_4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_4.UncheckedState.BorderRadius = 0
        Me.ckb_4.UncheckedState.BorderThickness = 2
        Me.ckb_4.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'ckb_5
        '
        Me.ckb_5.AutoSize = True
        Me.ckb_5.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ckb_5.CheckedState.BorderRadius = 0
        Me.ckb_5.CheckedState.BorderThickness = 0
        Me.ckb_5.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_5.CheckMarkColor = System.Drawing.Color.Snow
        Me.ckb_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ckb_5.Location = New System.Drawing.Point(467, 222)
        Me.ckb_5.Name = "ckb_5"
        Me.ckb_5.Size = New System.Drawing.Size(37, 24)
        Me.ckb_5.TabIndex = 35
        Me.ckb_5.Text = "5"
        Me.ckb_5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_5.UncheckedState.BorderRadius = 0
        Me.ckb_5.UncheckedState.BorderThickness = 2
        Me.ckb_5.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'cb_secProgCode
        '
        Me.cb_secProgCode.BackColor = System.Drawing.Color.Transparent
        Me.cb_secProgCode.BorderRadius = 10
        Me.cb_secProgCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_secProgCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_secProgCode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_secProgCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_secProgCode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_secProgCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_secProgCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_secProgCode.ItemHeight = 30
        Me.cb_secProgCode.Location = New System.Drawing.Point(79, 142)
        Me.cb_secProgCode.Name = "cb_secProgCode"
        Me.cb_secProgCode.ShadowDecoration.BorderRadius = 10
        Me.cb_secProgCode.ShadowDecoration.Depth = 64
        Me.cb_secProgCode.ShadowDecoration.Enabled = True
        Me.cb_secProgCode.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cb_secProgCode.Size = New System.Drawing.Size(429, 36)
        Me.cb_secProgCode.TabIndex = 36
        '
        'lbl_progHeader
        '
        Me.lbl_progHeader.AutoSize = True
        Me.lbl_progHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_progHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.lbl_progHeader.Location = New System.Drawing.Point(199, 61)
        Me.lbl_progHeader.Name = "lbl_progHeader"
        Me.lbl_progHeader.Size = New System.Drawing.Size(187, 29)
        Me.lbl_progHeader.TabIndex = 22
        Me.lbl_progHeader.Text = "ADD SECTION"
        '
        'pop_section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(580, 502)
        Me.Controls.Add(Me.cb_secProgCode)
        Me.Controls.Add(Me.ckb_5)
        Me.Controls.Add(Me.ckb_4)
        Me.Controls.Add(Me.ckb_3)
        Me.Controls.Add(Me.ckb_2)
        Me.Controls.Add(Me.ckb_1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_progHeader)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_done)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "pop_section"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "pop_section"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents ckb_5 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ckb_4 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ckb_3 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ckb_2 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ckb_1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_done As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cb_secProgCode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lbl_progHeader As Label
End Class
