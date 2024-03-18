Imports System.Media
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frm_Login

    Dim user As New Users

    'FORM LOAD
    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ckb_lgHideIcon.Checked = True
        txt_lgPassword.UseSystemPasswordChar = True
        cb_lgRole.BorderColor = defaultBorder
    End Sub

    'BUTTON LOGIN
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If cb_lgRole.SelectedItem = "Select Role" Then
            cb_lgRole.BorderColor = warningBorder
        ElseIf txt_lgUsername.Text = "" Or txt_lgPassword.Text = "" Then

            If txt_lgUsername.Text = "" And txt_lgPassword.Text = "" Then

                txt_lgUsername.BorderColor = errorBorder
                txt_lgPassword.BorderColor = errorBorder
                lbl_lgErrorMessage.Text = "Fill all the fields"
            ElseIf txt_lgUsername.Text = "" Then
                txt_lgUsername.BorderColor = errorBorder
                lbl_lgErrorMessage.Text = "Fill this field"
            Else
                txt_lgPassword.BorderColor = errorBorder
                lbl_lgErrorMessage.Text = "Fill this field"
            End If
            lbl_lgErrorMessage.Visible = True
        Else
            If user.loginUser(txt_lgUsername.Text, txt_lgPassword.Text, cb_lgRole.Text) Then
                If cb_lgRole.SelectedItem = "Viewer" Then
                    frm_Main.pnl_sidebar.Visible = False
                End If
                Me.Close()
                frm_Main.lbl_role.Text = cb_lgRole.SelectedItem
                frm_Main.Show()
            Else
                txt_lgUsername.BorderColor = errorBorder
                txt_lgPassword.BorderColor = errorBorder
                cb_lgRole.BorderColor = errorBorder
                lbl_lgErrorMessage.Text = "Invalid username, password or role!"
                lbl_lgErrorMessage.Visible = True
                SystemSounds.Beep.Play()
            End If
        End If
    End Sub

    'BUTTON EXIT
    Private Sub btn_lgExit_Click(sender As Object, e As EventArgs) Handles btn_lgExit.Click
        Application.Exit()
    End Sub

    'CHECKBOX ICON
    Private Sub ckb_lgHideIcon_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_lgHideIcon.CheckedChanged
        If ckb_lgHideIcon.Checked = True Then
            txt_lgPassword.UseSystemPasswordChar = True
        Else
            txt_lgPassword.UseSystemPasswordChar = False
        End If
    End Sub

    'TEXTBOX USERNAME
    Private Sub txt_lgUsername_TextChanged(sender As Object, e As EventArgs) Handles txt_lgUsername.TextChanged
        txt_lgUsername.BorderColor = defaultBorder
        txt_lgPassword.BorderColor = defaultBorder
        cb_lgRole.BorderColor = defaultBorder
        lbl_lgErrorMessage.Visible = False
    End Sub

    'TEXTBOX PASSWORD
    Private Sub txt_lgPassword_TextChanged(sender As Object, e As EventArgs) Handles txt_lgPassword.TextChanged
        txt_lgPassword.BorderColor = defaultBorder
        txt_lgUsername.BorderColor = defaultBorder
        cb_lgRole.BorderColor = defaultBorder
        lbl_lgErrorMessage.Visible = False
    End Sub

    'COMBOCOX ROLE
    Private Sub cb_lgRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_lgRole.SelectedIndexChanged
        txt_lgUsername.BorderColor = defaultBorder
        txt_lgPassword.BorderColor = defaultBorder
        lbl_lgErrorMessage.Visible = False
        If cb_lgRole.SelectedItem = "Select Role" Then
            cb_lgRole.BorderColor = defaultBorder
            lbl_lgErrorMessage.Text = "Select Your role"
            lbl_lgErrorMessage.Visible = True
        Else
            cb_lgRole.BorderColor = defaultBorder
        End If
    End Sub


End Class