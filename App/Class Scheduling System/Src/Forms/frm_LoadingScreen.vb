Public Class frm_LoadingScreen
    Private Sub frm_LoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.loadingBar.Value = 0
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.loadingBar.Value += 5

        If loadingBar.Value >= 100 Then


            Timer1.Stop()
            If school.CountSchool() > 0 Then
                frm_Login.Show()
            Else
                frm_Setup.Show()
            End If

            Me.Hide()
        End If
    End Sub
End Class
