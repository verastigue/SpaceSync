<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_room
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
        Me.cb_typeRoom = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_roomNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_progHeader = New System.Windows.Forms.Label()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_done = New Guna.UI2.WinForms.Guna2Button()
        Me.cb_floorLevel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_bldgName = New Guna.UI2.WinForms.Guna2TextBox()
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
        'cb_typeRoom
        '
        Me.cb_typeRoom.BackColor = System.Drawing.Color.Transparent
        Me.cb_typeRoom.BorderRadius = 10
        Me.cb_typeRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_typeRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_typeRoom.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_typeRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_typeRoom.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_typeRoom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_typeRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_typeRoom.ItemHeight = 30
        Me.cb_typeRoom.Location = New System.Drawing.Point(76, 376)
        Me.cb_typeRoom.Name = "cb_typeRoom"
        Me.cb_typeRoom.ShadowDecoration.BorderRadius = 10
        Me.cb_typeRoom.ShadowDecoration.Depth = 64
        Me.cb_typeRoom.ShadowDecoration.Enabled = True
        Me.cb_typeRoom.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cb_typeRoom.Size = New System.Drawing.Size(429, 36)
        Me.cb_typeRoom.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Type of Room"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Floor Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Building Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Room No"
        '
        'txt_roomNo
        '
        Me.txt_roomNo.BackColor = System.Drawing.Color.Transparent
        Me.txt_roomNo.BorderRadius = 10
        Me.txt_roomNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_roomNo.DefaultText = ""
        Me.txt_roomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_roomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_roomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_roomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_roomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_roomNo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_roomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_roomNo.Location = New System.Drawing.Point(76, 150)
        Me.txt_roomNo.Name = "txt_roomNo"
        Me.txt_roomNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_roomNo.PlaceholderText = ""
        Me.txt_roomNo.SelectedText = ""
        Me.txt_roomNo.ShadowDecoration.BorderRadius = 10
        Me.txt_roomNo.ShadowDecoration.Depth = 64
        Me.txt_roomNo.ShadowDecoration.Enabled = True
        Me.txt_roomNo.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txt_roomNo.Size = New System.Drawing.Size(429, 36)
        Me.txt_roomNo.TabIndex = 23
        '
        'lbl_progHeader
        '
        Me.lbl_progHeader.AutoSize = True
        Me.lbl_progHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_progHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.lbl_progHeader.Location = New System.Drawing.Point(206, 61)
        Me.lbl_progHeader.Name = "lbl_progHeader"
        Me.lbl_progHeader.Size = New System.Drawing.Size(151, 29)
        Me.lbl_progHeader.TabIndex = 22
        Me.lbl_progHeader.Text = "ADD ROOM"
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
        Me.btn_cancel.Location = New System.Drawing.Point(76, 463)
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
        Me.btn_done.Location = New System.Drawing.Point(325, 463)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.ShadowDecoration.BorderRadius = 10
        Me.btn_done.ShadowDecoration.Depth = 64
        Me.btn_done.ShadowDecoration.Enabled = True
        Me.btn_done.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btn_done.Size = New System.Drawing.Size(180, 45)
        Me.btn_done.TabIndex = 20
        Me.btn_done.Text = "Done"
        '
        'cb_floorLevel
        '
        Me.cb_floorLevel.BackColor = System.Drawing.Color.Transparent
        Me.cb_floorLevel.BorderRadius = 10
        Me.cb_floorLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_floorLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_floorLevel.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_floorLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_floorLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_floorLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_floorLevel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_floorLevel.ItemHeight = 30
        Me.cb_floorLevel.Location = New System.Drawing.Point(76, 297)
        Me.cb_floorLevel.Name = "cb_floorLevel"
        Me.cb_floorLevel.ShadowDecoration.BorderRadius = 10
        Me.cb_floorLevel.ShadowDecoration.Depth = 64
        Me.cb_floorLevel.ShadowDecoration.Enabled = True
        Me.cb_floorLevel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cb_floorLevel.Size = New System.Drawing.Size(429, 36)
        Me.cb_floorLevel.TabIndex = 31
        '
        'txt_bldgName
        '
        Me.txt_bldgName.BackColor = System.Drawing.Color.Transparent
        Me.txt_bldgName.BorderRadius = 10
        Me.txt_bldgName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_bldgName.DefaultText = ""
        Me.txt_bldgName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_bldgName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_bldgName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_bldgName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_bldgName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_bldgName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_bldgName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_bldgName.Location = New System.Drawing.Point(76, 227)
        Me.txt_bldgName.Name = "txt_bldgName"
        Me.txt_bldgName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_bldgName.PlaceholderText = ""
        Me.txt_bldgName.SelectedText = ""
        Me.txt_bldgName.ShadowDecoration.BorderRadius = 10
        Me.txt_bldgName.ShadowDecoration.Depth = 64
        Me.txt_bldgName.ShadowDecoration.Enabled = True
        Me.txt_bldgName.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txt_bldgName.Size = New System.Drawing.Size(429, 36)
        Me.txt_bldgName.TabIndex = 32
        '
        'pop_room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 575)
        Me.Controls.Add(Me.txt_bldgName)
        Me.Controls.Add(Me.cb_floorLevel)
        Me.Controls.Add(Me.cb_typeRoom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_roomNo)
        Me.Controls.Add(Me.lbl_progHeader)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_done)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pop_room"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "pop_room"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents cb_typeRoom As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_roomNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_progHeader As Label
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_done As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_bldgName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cb_floorLevel As Guna.UI2.WinForms.Guna2ComboBox
End Class
