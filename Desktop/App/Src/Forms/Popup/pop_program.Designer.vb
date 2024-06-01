<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_program
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
        Me.btn_done = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.lbl_progHeader = New System.Windows.Forms.Label()
        Me.txt_progCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_progDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_progDepart = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_NoYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
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
        Me.btn_done.TabIndex = 7
        Me.btn_done.Text = "Done"
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
        Me.btn_cancel.TabIndex = 8
        Me.btn_cancel.Text = "Cancel"
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
        'lbl_progHeader
        '
        Me.lbl_progHeader.AutoSize = True
        Me.lbl_progHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_progHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.lbl_progHeader.Location = New System.Drawing.Point(199, 61)
        Me.lbl_progHeader.Name = "lbl_progHeader"
        Me.lbl_progHeader.Size = New System.Drawing.Size(201, 29)
        Me.lbl_progHeader.TabIndex = 10
        Me.lbl_progHeader.Text = "ADD PROGRAM"
        '
        'txt_progCode
        '
        Me.txt_progCode.BackColor = System.Drawing.Color.Transparent
        Me.txt_progCode.BorderRadius = 10
        Me.txt_progCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_progCode.DefaultText = ""
        Me.txt_progCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_progCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_progCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_progCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_progCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_progCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_progCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_progCode.Location = New System.Drawing.Point(76, 150)
        Me.txt_progCode.Name = "txt_progCode"
        Me.txt_progCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_progCode.PlaceholderText = ""
        Me.txt_progCode.SelectedText = ""
        Me.txt_progCode.ShadowDecoration.BorderRadius = 10
        Me.txt_progCode.ShadowDecoration.Depth = 64
        Me.txt_progCode.ShadowDecoration.Enabled = True
        Me.txt_progCode.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txt_progCode.Size = New System.Drawing.Size(429, 36)
        Me.txt_progCode.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Program Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Description"
        '
        'txt_progDesc
        '
        Me.txt_progDesc.BackColor = System.Drawing.Color.Transparent
        Me.txt_progDesc.BorderRadius = 10
        Me.txt_progDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_progDesc.DefaultText = ""
        Me.txt_progDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_progDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_progDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_progDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_progDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_progDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_progDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_progDesc.Location = New System.Drawing.Point(76, 227)
        Me.txt_progDesc.Multiline = True
        Me.txt_progDesc.Name = "txt_progDesc"
        Me.txt_progDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_progDesc.PlaceholderText = ""
        Me.txt_progDesc.SelectedText = ""
        Me.txt_progDesc.ShadowDecoration.BorderRadius = 10
        Me.txt_progDesc.ShadowDecoration.Depth = 64
        Me.txt_progDesc.ShadowDecoration.Enabled = True
        Me.txt_progDesc.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txt_progDesc.Size = New System.Drawing.Size(429, 144)
        Me.txt_progDesc.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Department"
        '
        'txt_progDepart
        '
        Me.txt_progDepart.BackColor = System.Drawing.Color.Transparent
        Me.txt_progDepart.BorderRadius = 10
        Me.txt_progDepart.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_progDepart.DefaultText = ""
        Me.txt_progDepart.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_progDepart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_progDepart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_progDepart.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_progDepart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_progDepart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_progDepart.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.txt_progDepart.Location = New System.Drawing.Point(76, 408)
        Me.txt_progDepart.Name = "txt_progDepart"
        Me.txt_progDepart.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_progDepart.PlaceholderText = ""
        Me.txt_progDepart.SelectedText = ""
        Me.txt_progDepart.ShadowDecoration.BorderRadius = 10
        Me.txt_progDepart.ShadowDecoration.Depth = 64
        Me.txt_progDepart.ShadowDecoration.Enabled = True
        Me.txt_progDepart.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.txt_progDepart.Size = New System.Drawing.Size(429, 36)
        Me.txt_progDepart.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 465)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "No of year"
        '
        'cb_NoYear
        '
        Me.cb_NoYear.BackColor = System.Drawing.Color.Transparent
        Me.cb_NoYear.BorderRadius = 10
        Me.cb_NoYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_NoYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_NoYear.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_NoYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_NoYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cb_NoYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_NoYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.cb_NoYear.ItemHeight = 30
        Me.cb_NoYear.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cb_NoYear.Location = New System.Drawing.Point(76, 485)
        Me.cb_NoYear.Name = "cb_NoYear"
        Me.cb_NoYear.ShadowDecoration.BorderRadius = 10
        Me.cb_NoYear.ShadowDecoration.Depth = 64
        Me.cb_NoYear.ShadowDecoration.Enabled = True
        Me.cb_NoYear.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.cb_NoYear.Size = New System.Drawing.Size(429, 36)
        Me.cb_NoYear.TabIndex = 19
        '
        'pop_program
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(580, 680)
        Me.Controls.Add(Me.cb_NoYear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_progDepart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_progDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_progCode)
        Me.Controls.Add(Me.lbl_progHeader)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_done)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pop_program"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "pop_program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_done As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents lbl_progHeader As Label
    Friend WithEvents cb_NoYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_progDepart As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_progDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_progCode As Guna.UI2.WinForms.Guna2TextBox
End Class
