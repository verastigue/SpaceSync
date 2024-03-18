Imports System.Media

Public Class frm_Setup

    Dim user As New Users

    Private Sub frm_Setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ckb_stHideIcon.Checked = True
        txt_stPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click

        If txt_schoolName.Text IsNot "" And txt_schoolId.Text IsNot "" And txt_schoolAddress.Text IsNot "" And txt_stUsername.Text IsNot "" And txt_stPassword.Text IsNot "" Then
            If user.validateUsername(txt_stUsername.Text) Then
                MessageBox.Show("username is already taken")
            Else
                user.addNewUser(txt_stUsername.Text, txt_stPassword.Text, "Admin")
                Me.Hide()
                frm_Login.Show()
            End If
        ElseIf txt_schoolName.Text IsNot "" Or txt_schoolId.Text IsNot "" Or txt_schoolAddress.Text IsNot "" Or txt_stUsername.Text IsNot "" Or txt_stPassword.Text IsNot "" Then
            If txt_schoolName.Text = "" Then
                txt_schoolName.BorderColor = Color.FromArgb(255, 138, 128)
            ElseIf txt_schoolId.Text = "" Then
                txt_schoolId.BorderColor = Color.FromArgb(255, 138, 128)
            ElseIf txt_schoolAddress.Text = "" Then
                txt_schoolAddress.BorderColor = Color.FromArgb(255, 138, 128)
            ElseIf txt_stUsername.Text = "" Then
                txt_stUsername.BorderColor = Color.FromArgb(255, 138, 128)
            ElseIf txt_stPassword.Text = "" Then
                txt_stPassword.BorderColor = Color.FromArgb(255, 138, 128)
            End If
        Else
            txt_schoolName.BorderColor = Color.FromArgb(255, 138, 128)
            txt_schoolId.BorderColor = Color.FromArgb(255, 138, 128)
            txt_schoolAddress.BorderColor = Color.FromArgb(255, 138, 128)
            txt_stUsername.BorderColor = Color.FromArgb(255, 138, 128)
            txt_stPassword.BorderColor = Color.FromArgb(255, 138, 128)

        End If
    End Sub

    Private Sub btn_stExit_Click(sender As Object, e As EventArgs) Handles btn_stExit.Click
        Application.Exit()
    End Sub

    Private Sub ckb_stHideIcon_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_stHideIcon.CheckedChanged
        If ckb_stHideIcon.Checked = True Then
            txt_stPassword.UseSystemPasswordChar = True
        Else
            txt_stPassword.UseSystemPasswordChar = False
        End If

    End Sub
End Class
