<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_schedule
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
        Me.ckb_sat = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ckb_fri = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ckb_thu = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ckb_wed = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ckb_tue = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ckb_mon = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ckb_sun = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_progHeader = New System.Windows.Forms.Label()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_done = New Guna.UI2.WinForms.Guna2Button()
        Me.cb_instructor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cb_course = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cb_section = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cb_room = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtp_startTime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtp_endTime = New Guna.UI2.WinForms.Guna2DateTimePicker()
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
        'ckb_sat
        '
        Me.ckb_sat.AutoSize = True
        Me.ckb_sat.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ckb_sat.CheckedState.BorderRadius = 0
        Me.ckb_sat.CheckedState.BorderThickness = 0
        Me.ckb_sat.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_sat.CheckMarkColor = System.Drawing.Color.Snow
        Me.ckb_sat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ckb_sat.Location = New System.Drawing.Point(448, 501)
        Me.ckb_sat.Name = "ckb_sat"
        Me.ckb_sat.Size = New System.Drawing.Size(53, 24)
        Me.ckb_sat.TabIndex = 81
        Me.ckb_sat.Text = "Sat"
        Me.ckb_sat.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_sat.UncheckedState.BorderRadius = 0
        Me.ckb_sat.UncheckedState.BorderThickness = 2
        Me.ckb_sat.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'ckb_fri
        '
        Me.ckb_fri.AutoSize = True
        Me.ckb_fri.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ckb_fri.CheckedState.BorderRadius = 0
        Me.ckb_fri.CheckedState.BorderThickness = 0
        Me.ckb_fri.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_fri.CheckMarkColor = System.Drawing.Color.Snow
        Me.ckb_fri.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ckb_fri.Location = New System.Drawing.Point(396, 501)
        Me.ckb_fri.Name = "ckb_fri"
        Me.ckb_fri.Size = New System.Drawing.Size(46, 24)
        Me.ckb_fri.TabIndex = 80
        Me.ckb_fri.Text = "Fri"
        Me.ckb_fri.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_fri.UncheckedState.BorderRadius = 0
        Me.ckb_fri.UncheckedState.BorderThickness = 2
        Me.ckb_fri.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'ckb_thu
        '
        Me.ckb_thu.AutoSize = True
        Me.ckb_thu.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ckb_thu.CheckedState.BorderRadius = 0
        Me.ckb_thu.CheckedState.BorderThickness = 0
        Me.ckb_thu.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_thu.CheckMarkColor = System.Drawing.Color.Snow
        Me.ckb_thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ckb_thu.Location = New System.Drawing.Point(335, 501)
        Me.ckb_thu.Name = "ckb_thu"
        Me.ckb_thu.Size = New System.Drawing.Size(55, 24)
        Me.ckb_thu.TabIndex = 79
        Me.ckb_thu.Text = "Thu"
        Me.ckb_thu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_thu.UncheckedState.BorderRadius = 0
        Me.ckb_thu.UncheckedState.BorderThickness = 2
        Me.ckb_thu.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'ckb_wed
        '
        Me.ckb_wed.AutoSize = True
        Me.ckb_wed.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ckb_wed.CheckedState.BorderRadius = 0
        Me.ckb_wed.CheckedState.BorderThickness = 0
        Me.ckb_wed.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_wed.CheckMarkColor = System.Drawing.Color.Snow
        Me.ckb_wed.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ckb_wed.Location = New System.Drawing.Point(268, 501)
        Me.ckb_wed.Name = "ckb_wed"
        Me.ckb_wed.Size = New System.Drawing.Size(61, 24)
        Me.ckb_wed.TabIndex = 78
        Me.ckb_wed.Text = "Wed"
        Me.ckb_wed.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_wed.UncheckedState.BorderRadius = 0
        Me.ckb_wed.UncheckedState.BorderThickness = 2
        Me.ckb_wed.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'ckb_tue
        '
        Me.ckb_tue.AutoSize = True
        Me.ckb_tue.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ckb_tue.CheckedState.BorderRadius = 0
        Me.ckb_tue.CheckedState.BorderThickness = 0
        Me.ckb_tue.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_tue.CheckMarkColor = System.Drawing.Color.Snow
        Me.ckb_tue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ckb_tue.Location = New System.Drawing.Point(207, 501)
        Me.ckb_tue.Name = "ckb_tue"
        Me.ckb_tue.Size = New System.Drawing.Size(55, 24)
        Me.ckb_tue.TabIndex = 77
        Me.ckb_tue.Text = "Tue"
        Me.ckb_tue.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_tue.UncheckedState.BorderRadius = 0
        Me.ckb_tue.UncheckedState.BorderThickness = 2
        Me.ckb_tue.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'ckb_mon
        '
        Me.ckb_mon.AutoSize = True
        Me.ckb_mon.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ckb_mon.CheckedState.BorderRadius = 0
        Me.ckb_mon.CheckedState.BorderThickness = 0
        Me.ckb_mon.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_mon.CheckMarkColor = System.Drawing.Color.Snow
        Me.ckb_mon.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ckb_mon.Location = New System.Drawing.Point(142, 501)
        Me.ckb_mon.Name = "ckb_mon"
        Me.ckb_mon.Size = New System.Drawing.Size(59, 24)
        Me.ckb_mon.TabIndex = 76
        Me.ckb_mon.Text = "Mon"
        Me.ckb_mon.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_mon.UncheckedState.BorderRadius = 0
        Me.ckb_mon.UncheckedState.BorderThickness = 2
        Me.ckb_mon.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'ckb_sun
        '
        Me.ckb_sun.AutoSize = True
        Me.ckb_sun.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.ckb_sun.CheckedState.BorderRadius = 0
        Me.ckb_sun.CheckedState.BorderThickness = 0
        Me.ckb_sun.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_sun.CheckMarkColor = System.Drawing.Color.Snow
        Me.ckb_sun.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ckb_sun.Location = New System.Drawing.Point(79, 501)
        Me.ckb_sun.Name = "ckb_sun"
        Me.ckb_sun.Size = New System.Drawing.Size(57, 24)
        Me.ckb_sun.TabIndex = 75
        Me.ckb_sun.Text = "Sun"
        Me.ckb_sun.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ckb_sun.UncheckedState.BorderRadius = 0
        Me.ckb_sun.UncheckedState.BorderThickness = 2
        Me.ckb_sun.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 478)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Class Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(76, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Section"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 404)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "End Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 404)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Start Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Room"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Course"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Instructor"
        '
        'lbl_progHeader
        '
        Me.lbl_progHeader.AutoSize = True
        Me.lbl_progHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_progHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.lbl_progHeader.Location = New System.Drawing.Point(181, 59)
        Me.lbl_progHeader.Name = "lbl_progHeader"
        Me.lbl_progHeader.Size = New System.Drawing.Size(209, 29)
        Me.lbl_progHeader.TabIndex = 61
        Me.lbl_progHeader.Text = "ADD SCHEDULE"
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
        Me.btn_cancel.TabIndex = 60
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
        Me.btn_done.TabIndex = 59
        Me.btn_done.Text = "Done"
        '
        'cb_instructor
        '
        Me.cb_instructor.BackColor = System.Drawing.Color.Transparent
        Me.cb_instructor.BorderRadius = 10
        Me.cb_instructor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_instructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_instructor.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_instructor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_instructor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_instructor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_instructor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_instructor.ItemHeight = 30
        Me.cb_instructor.Location = New System.Drawing.Point(76, 132)
        Me.cb_instructor.Name = "cb_instructor"
        Me.cb_instructor.ShadowDecoration.BorderRadius = 10
        Me.cb_instructor.ShadowDecoration.Depth = 64
        Me.cb_instructor.ShadowDecoration.Enabled = True
        Me.cb_instructor.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cb_instructor.Size = New System.Drawing.Size(429, 36)
        Me.cb_instructor.TabIndex = 82
        '
        'cb_course
        '
        Me.cb_course.BackColor = System.Drawing.Color.Transparent
        Me.cb_course.BorderRadius = 10
        Me.cb_course.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_course.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_course.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_course.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_course.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_course.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_course.ItemHeight = 30
        Me.cb_course.Location = New System.Drawing.Point(76, 209)
        Me.cb_course.Name = "cb_course"
        Me.cb_course.ShadowDecoration.BorderRadius = 10
        Me.cb_course.ShadowDecoration.Depth = 64
        Me.cb_course.ShadowDecoration.Enabled = True
        Me.cb_course.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cb_course.Size = New System.Drawing.Size(429, 36)
        Me.cb_course.TabIndex = 83
        '
        'cb_section
        '
        Me.cb_section.BackColor = System.Drawing.Color.Transparent
        Me.cb_section.BorderRadius = 10
        Me.cb_section.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_section.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_section.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_section.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_section.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_section.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_section.ItemHeight = 30
        Me.cb_section.Location = New System.Drawing.Point(76, 279)
        Me.cb_section.Name = "cb_section"
        Me.cb_section.ShadowDecoration.BorderRadius = 10
        Me.cb_section.ShadowDecoration.Depth = 64
        Me.cb_section.ShadowDecoration.Enabled = True
        Me.cb_section.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cb_section.Size = New System.Drawing.Size(429, 36)
        Me.cb_section.TabIndex = 84
        '
        'cb_room
        '
        Me.cb_room.BackColor = System.Drawing.Color.Transparent
        Me.cb_room.BorderRadius = 10
        Me.cb_room.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_room.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_room.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_room.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_room.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_room.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_room.ItemHeight = 30
        Me.cb_room.Location = New System.Drawing.Point(76, 345)
        Me.cb_room.Name = "cb_room"
        Me.cb_room.ShadowDecoration.BorderRadius = 10
        Me.cb_room.ShadowDecoration.Depth = 64
        Me.cb_room.ShadowDecoration.Enabled = True
        Me.cb_room.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cb_room.Size = New System.Drawing.Size(429, 36)
        Me.cb_room.TabIndex = 85
        '
        'dtp_startTime
        '
        Me.dtp_startTime.BackColor = System.Drawing.Color.Transparent
        Me.dtp_startTime.BorderRadius = 10
        Me.dtp_startTime.Checked = True
        Me.dtp_startTime.CustomFormat = "hh:mm tt"
        Me.dtp_startTime.FillColor = System.Drawing.Color.Snow
        Me.dtp_startTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtp_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_startTime.Location = New System.Drawing.Point(76, 424)
        Me.dtp_startTime.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_startTime.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_startTime.Name = "dtp_startTime"
        Me.dtp_startTime.ShadowDecoration.BorderRadius = 10
        Me.dtp_startTime.ShadowDecoration.Depth = 64
        Me.dtp_startTime.ShadowDecoration.Enabled = True
        Me.dtp_startTime.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.dtp_startTime.ShowUpDown = True
        Me.dtp_startTime.Size = New System.Drawing.Size(200, 36)
        Me.dtp_startTime.TabIndex = 86
        Me.dtp_startTime.Value = New Date(2024, 5, 31, 20, 41, 34, 442)
        '
        'dtp_endTime
        '
        Me.dtp_endTime.BackColor = System.Drawing.Color.Transparent
        Me.dtp_endTime.BorderRadius = 10
        Me.dtp_endTime.Checked = True
        Me.dtp_endTime.CustomFormat = "hh:mm tt"
        Me.dtp_endTime.FillColor = System.Drawing.Color.Snow
        Me.dtp_endTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtp_endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_endTime.Location = New System.Drawing.Point(305, 424)
        Me.dtp_endTime.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_endTime.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_endTime.Name = "dtp_endTime"
        Me.dtp_endTime.ShadowDecoration.BorderRadius = 10
        Me.dtp_endTime.ShadowDecoration.Depth = 64
        Me.dtp_endTime.ShadowDecoration.Enabled = True
        Me.dtp_endTime.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.dtp_endTime.ShowUpDown = True
        Me.dtp_endTime.Size = New System.Drawing.Size(200, 36)
        Me.dtp_endTime.TabIndex = 87
        Me.dtp_endTime.Value = New Date(2024, 5, 31, 20, 41, 34, 442)
        '
        'pop_schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 680)
        Me.Controls.Add(Me.dtp_endTime)
        Me.Controls.Add(Me.dtp_startTime)
        Me.Controls.Add(Me.cb_room)
        Me.Controls.Add(Me.cb_section)
        Me.Controls.Add(Me.cb_course)
        Me.Controls.Add(Me.cb_instructor)
        Me.Controls.Add(Me.ckb_sat)
        Me.Controls.Add(Me.ckb_fri)
        Me.Controls.Add(Me.ckb_thu)
        Me.Controls.Add(Me.ckb_wed)
        Me.Controls.Add(Me.ckb_tue)
        Me.Controls.Add(Me.ckb_mon)
        Me.Controls.Add(Me.ckb_sun)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_progHeader)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_done)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pop_schedule"
        Me.Text = "pop_schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents ckb_sat As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ckb_fri As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ckb_thu As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ckb_wed As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ckb_tue As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ckb_mon As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents ckb_sun As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_progHeader As Label
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_done As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtp_startTime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cb_room As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cb_section As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cb_course As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cb_instructor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtp_endTime As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
