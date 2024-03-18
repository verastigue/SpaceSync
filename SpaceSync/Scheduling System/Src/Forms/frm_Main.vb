Imports Guna.UI2.WinForms


Public Class frm_Main

    Dim currentBtn As Guna2Button

    Sub activateBtn(clickBtn As Guna2Button, tbp As TabPage)
        deactivateBtn()
        currentBtn = clickBtn
        currentBtn.FillColor = Color.FromArgb(38, 166, 154)
        currentBtn.ShadowDecoration.Enabled = True
        currentBtn.BorderColor = Color.Transparent
        currentBtn.BorderThickness = 0
        tbctrl_Section.SelectedTab = tbp
    End Sub


    Sub deactivateBtn()
        If currentBtn IsNot Nothing Then
            currentBtn.FillColor = Color.Transparent
            currentBtn.ShadowDecoration.Enabled = False
            currentBtn.BorderColor = Color.FromArgb(38, 166, 154)
            currentBtn.BorderThickness = 2
        End If
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activateBtn(btn_Dashboard, tbp_Dashboard)
    End Sub
    Private Sub btn_Dashboard_Click(sender As Object, e As EventArgs) Handles btn_Dashboard.Click
        activateBtn(btn_Dashboard, tbp_Dashboard)
    End Sub

    Private Sub btn_Course_Click(sender As Object, e As EventArgs) Handles btn_Course.Click
        activateBtn(btn_Course, tbp_Course)
    End Sub

    Private Sub btn_Program_Click(sender As Object, e As EventArgs) Handles btn_Program.Click
        activateBtn(btn_Program, tbp_Program)
    End Sub

    Private Sub btn_Instructor_Click(sender As Object, e As EventArgs) Handles btn_Instructor.Click
        activateBtn(btn_Instructor, tbp_Instructor)
    End Sub

    Private Sub btn_Room_Click(sender As Object, e As EventArgs) Handles btn_Room.Click
        activateBtn(btn_Room, tbp_Room)
    End Sub

    Private Sub btn_Schedule_Click(sender As Object, e As EventArgs) Handles btn_Schedule.Click
        activateBtn(btn_Schedule, tbp_Schedule)
    End Sub

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        activateBtn(btn_Print, tbp_Print)
    End Sub

    Private Sub btn_Setting_Click(sender As Object, e As EventArgs) Handles btn_Setting.Click
        activateBtn(btn_Setting, tbp_Setting)
    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
        frm_Login.Show()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub


End Class