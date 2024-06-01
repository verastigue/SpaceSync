<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pop_instrucCourse
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnl_instrucDet = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_progHeader = New System.Windows.Forms.Label()
        Me.btn_backDet = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_nextInsCourse = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dtgv_InstrucCourse = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnl_instrucDet.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dtgv_InstrucCourse, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pnl_instrucDet
        '
        Me.pnl_instrucDet.Controls.Add(Me.Guna2Panel1)
        Me.pnl_instrucDet.Controls.Add(Me.lbl_progHeader)
        Me.pnl_instrucDet.Controls.Add(Me.btn_backDet)
        Me.pnl_instrucDet.Controls.Add(Me.btn_nextInsCourse)
        Me.pnl_instrucDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_instrucDet.Location = New System.Drawing.Point(0, 0)
        Me.pnl_instrucDet.Name = "pnl_instrucDet"
        Me.pnl_instrucDet.Size = New System.Drawing.Size(580, 680)
        Me.pnl_instrucDet.TabIndex = 60
        '
        'lbl_progHeader
        '
        Me.lbl_progHeader.AutoSize = True
        Me.lbl_progHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_progHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.lbl_progHeader.Location = New System.Drawing.Point(102, 54)
        Me.lbl_progHeader.Name = "lbl_progHeader"
        Me.lbl_progHeader.Size = New System.Drawing.Size(378, 29)
        Me.lbl_progHeader.TabIndex = 61
        Me.lbl_progHeader.Text = "ADD INSTRUCTOR'S COURSE"
        '
        'btn_backDet
        '
        Me.btn_backDet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_backDet.BackColor = System.Drawing.Color.Transparent
        Me.btn_backDet.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btn_backDet.BorderRadius = 10
        Me.btn_backDet.BorderThickness = 2
        Me.btn_backDet.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_backDet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_backDet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_backDet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_backDet.FillColor = System.Drawing.Color.Snow
        Me.btn_backDet.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btn_backDet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btn_backDet.Location = New System.Drawing.Point(76, 574)
        Me.btn_backDet.Name = "btn_backDet"
        Me.btn_backDet.ShadowDecoration.BorderRadius = 10
        Me.btn_backDet.ShadowDecoration.Depth = 64
        Me.btn_backDet.ShadowDecoration.Enabled = True
        Me.btn_backDet.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btn_backDet.Size = New System.Drawing.Size(180, 45)
        Me.btn_backDet.TabIndex = 60
        Me.btn_backDet.Text = "Back"
        '
        'btn_nextInsCourse
        '
        Me.btn_nextInsCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_nextInsCourse.BackColor = System.Drawing.Color.Transparent
        Me.btn_nextInsCourse.BorderRadius = 10
        Me.btn_nextInsCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_nextInsCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_nextInsCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_nextInsCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_nextInsCourse.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btn_nextInsCourse.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btn_nextInsCourse.ForeColor = System.Drawing.Color.Snow
        Me.btn_nextInsCourse.Location = New System.Drawing.Point(325, 574)
        Me.btn_nextInsCourse.Name = "btn_nextInsCourse"
        Me.btn_nextInsCourse.ShadowDecoration.BorderRadius = 10
        Me.btn_nextInsCourse.ShadowDecoration.Depth = 64
        Me.btn_nextInsCourse.ShadowDecoration.Enabled = True
        Me.btn_nextInsCourse.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.btn_nextInsCourse.Size = New System.Drawing.Size(180, 45)
        Me.btn_nextInsCourse.TabIndex = 59
        Me.btn_nextInsCourse.Text = "Next"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.dtgv_InstrucCourse)
        Me.Guna2Panel1.Location = New System.Drawing.Point(76, 113)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 0
        Me.Guna2Panel1.ShadowDecoration.Depth = 64
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.Guna2Panel1.Size = New System.Drawing.Size(429, 428)
        Me.Guna2Panel1.TabIndex = 62
        '
        'dtgv_InstrucCourse
        '
        Me.dtgv_InstrucCourse.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dtgv_InstrucCourse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv_InstrucCourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.dtgv_InstrucCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(106, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_InstrucCourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgv_InstrucCourse.ColumnHeadersHeight = 29
        Me.dtgv_InstrucCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv_InstrucCourse.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgv_InstrucCourse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgv_InstrucCourse.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgv_InstrucCourse.Location = New System.Drawing.Point(0, 0)
        Me.dtgv_InstrucCourse.MultiSelect = False
        Me.dtgv_InstrucCourse.Name = "dtgv_InstrucCourse"
        Me.dtgv_InstrucCourse.ReadOnly = True
        Me.dtgv_InstrucCourse.RowHeadersVisible = False
        Me.dtgv_InstrucCourse.Size = New System.Drawing.Size(429, 428)
        Me.dtgv_InstrucCourse.TabIndex = 1
        Me.dtgv_InstrucCourse.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgv_InstrucCourse.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtgv_InstrucCourse.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtgv_InstrucCourse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtgv_InstrucCourse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtgv_InstrucCourse.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtgv_InstrucCourse.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgv_InstrucCourse.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgv_InstrucCourse.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgv_InstrucCourse.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgv_InstrucCourse.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtgv_InstrucCourse.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtgv_InstrucCourse.ThemeStyle.HeaderStyle.Height = 29
        Me.dtgv_InstrucCourse.ThemeStyle.ReadOnly = True
        Me.dtgv_InstrucCourse.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgv_InstrucCourse.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.dtgv_InstrucCourse.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgv_InstrucCourse.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtgv_InstrucCourse.ThemeStyle.RowsStyle.Height = 22
        Me.dtgv_InstrucCourse.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgv_InstrucCourse.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'pop_instrucCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 680)
        Me.Controls.Add(Me.pnl_instrucDet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pop_instrucCourse"
        Me.Text = "pop_instrucCourse"
        Me.pnl_instrucDet.ResumeLayout(False)
        Me.pnl_instrucDet.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.dtgv_InstrucCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnl_instrucDet As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_progHeader As Label
    Friend WithEvents btn_backDet As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_nextInsCourse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dtgv_InstrucCourse As Guna.UI2.WinForms.Guna2DataGridView
End Class
