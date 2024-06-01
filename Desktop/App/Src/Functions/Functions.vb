Imports Guna.UI2.WinForms

Module Functions
    'FOR HANDLE BUTOON
    Dim currentBtn As Guna2Button

    'THIS IS FOR NAVIGATION BUTTON
    Sub HandleButton_Click(clickBtn As Guna2Button, tbp As TabPage)


        If currentBtn IsNot Nothing Then
            currentBtn.FillColor = Color.FromArgb(11, 102, 106)
        End If

        currentBtn = clickBtn
        currentBtn.FillColor = Color.FromArgb(38, 166, 154)

        frm_Main.tbctrl_Section.SelectedTab = tbp
    End Sub

End Module
