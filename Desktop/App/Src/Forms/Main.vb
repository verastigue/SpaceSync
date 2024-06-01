Imports Guna.UI2.WinForms

Public Class frm_Main
    'FORM LOAD
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbctrl_Section.TabMenuVisible = False
        RefreshData()
    End Sub

    'NAVIGATION
    Private Sub NavItem_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click, btn_course.Click, btn_program.Click, btn_section.Click, btn_instructor.Click, btn_room.Click, btn_schedule.Click, btn_print.Click, btn_setting.Click, btn_section.Click, btn_monitor.Click
        Dim btn = DirectCast(sender, Guna2Button)
        Dim tabPage As TabPage = Nothing

        Select Case btn.Name
            Case "btn_dashboard"
                tabPage = tbp_Dashboard
            Case "btn_monitor"
                tabPage = tbp_Monitor
            Case "btn_course"
                tabPage = tbp_Course
            Case "btn_program"
                tabPage = tbp_Program
            Case "btn_instructor"
                tabPage = tbp_Instructor
            Case "btn_room"
                tabPage = tbp_Room
            Case "btn_schedule"
                tabPage = tbp_Schedule
            Case "btn_print"
                tabPage = tbp_Print
            Case "btn_setting"
                tabPage = tbp_Setting
            Case "btn_section"
                tabPage = tbp_Section
        End Select

        HandleButton_Click(btn, tabPage)
    End Sub

    Private Sub btn_createProg_Click(sender As Object, e As EventArgs) Handles btn_createProg.Click
        Dim popup As New pop_program()
        popup.StartPosition = FormStartPosition.CenterParent
        popup.ShowDialog(Me)
    End Sub

    Private Sub btn_createSec_Click(sender As Object, e As EventArgs) Handles btn_createSec.Click
        Dim popup As New pop_section
        popup.StartPosition = FormStartPosition.CenterParent

        'FILL THE PROGRAM CODE
        popup.cb_secProgCode.DataSource = programsData
        popup.cb_secProgCode.DisplayMember = "program_code"
        popup.cb_secProgCode.ValueMember = "program_code"

        popup.ShowDialog(Me)
    End Sub

    'COURSE
    Private Sub btn_createCourse_Click(sender As Object, e As EventArgs) Handles btn_createCourse.Click
        Dim popup As New pop_course
        popup.StartPosition = FormStartPosition.CenterParent

        'FILL THE PROGRAM CODE
        popup.cb_courseProg.DataSource = programsData
        popup.cb_courseProg.DisplayMember = "program_code"
        popup.cb_courseProg.ValueMember = "program_code"

        popup.ShowDialog(Me)
    End Sub

    Private Sub btn_createInstruc_Click(sender As Object, e As EventArgs) Handles btn_createInstruc.Click
        Dim popup As New pop_instructor
        popup.StartPosition = FormStartPosition.CenterParent
        popup.ShowDialog(Me)
    End Sub

    Private Sub btn_createRoom_Click(sender As Object, e As EventArgs) Handles btn_createRoom.Click
        Dim popup As New pop_room
        popup.StartPosition = FormStartPosition.CenterParent
        popup.ShowDialog(Me)
    End Sub

    Private Sub btn_createSched_Click(sender As Object, e As EventArgs) Handles btn_createSched.Click
        Dim popup As New pop_schedule
        popup.StartPosition = FormStartPosition.CenterParent
        popup.ShowDialog(Me)
    End Sub

    Private Sub frm_Main_dtgv_program_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_program.CellContentClick

    End Sub



End Class