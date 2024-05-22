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
        gunaChart = New Guna.Charts.WinForms.GunaScatterDataset()
        GunaAreaDataset1 = New Guna.Charts.WinForms.GunaAreaDataset()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' gunaChart
        ' 
        gunaChart.BorderColor = Color.Empty
        gunaChart.FillColor = Color.Empty
        gunaChart.Label = "Scatter1"
        ' 
        ' GunaAreaDataset1
        ' 
        GunaAreaDataset1.BorderColor = Color.Empty
        GunaAreaDataset1.FillColor = Color.Empty
        GunaAreaDataset1.Label = "Area1"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(466, 269)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' testing
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 731)
        Controls.Add(Button1)
        Name = "testing"
        Text = "testing"
        ResumeLayout(False)
    End Sub

    Friend WithEvents gunaChart As Guna.Charts.WinForms.GunaScatterDataset
    Friend WithEvents GunaAreaDataset1 As Guna.Charts.WinForms.GunaAreaDataset
    Friend WithEvents Button1 As Button
End Class
