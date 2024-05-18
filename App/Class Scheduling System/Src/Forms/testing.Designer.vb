<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testing
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1 = New Panel()
        CheckBoxICS = New CheckBox()
        CheckBoxIBE = New CheckBox()
        CheckBoxITE = New CheckBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        FlowLayoutPanel1.Location = New Point(0, 65)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(877, 592)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.AutoScroll = True
        Panel1.Controls.Add(CheckBoxITE)
        Panel1.Controls.Add(CheckBoxIBE)
        Panel1.Controls.Add(CheckBoxICS)
        Panel1.Controls.Add(FlowLayoutPanel1)
        Panel1.Location = New Point(12, 62)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(877, 657)
        Panel1.TabIndex = 1
        ' 
        ' CheckBoxICS
        ' 
        CheckBoxICS.AutoSize = True
        CheckBoxICS.Location = New Point(280, 24)
        CheckBoxICS.Name = "CheckBoxICS"
        CheckBoxICS.Size = New Size(43, 19)
        CheckBoxICS.TabIndex = 4
        CheckBoxICS.Text = "ICS"
        CheckBoxICS.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxIBE
        ' 
        CheckBoxIBE.AutoSize = True
        CheckBoxIBE.Location = New Point(334, 24)
        CheckBoxIBE.Name = "CheckBoxIBE"
        CheckBoxIBE.Size = New Size(42, 19)
        CheckBoxIBE.TabIndex = 5
        CheckBoxIBE.Text = "IBE"
        CheckBoxIBE.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxITE
        ' 
        CheckBoxITE.AutoSize = True
        CheckBoxITE.Location = New Point(395, 24)
        CheckBoxITE.Name = "CheckBoxITE"
        CheckBoxITE.Size = New Size(41, 19)
        CheckBoxITE.TabIndex = 6
        CheckBoxITE.Text = "ITE"
        CheckBoxITE.UseVisualStyleBackColor = True
        ' 
        ' testing
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 731)
        Controls.Add(Panel1)
        Name = "testing"
        Text = "testing"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBoxITE As CheckBox
    Friend WithEvents CheckBoxIBE As CheckBox
    Friend WithEvents CheckBoxICS As CheckBox
End Class
