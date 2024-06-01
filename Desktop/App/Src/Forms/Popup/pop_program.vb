Public Class pop_program
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        create("INSERT INTO tbl_programs(program_code, name, department, NoOfYear) VALUES('" & txt_progCode.Text.ToString.Trim & "', '" & txt_progDesc.Text & "', '" & txt_progDepart.Text & "', '" & CInt(cb_NoYear.SelectedItem) & "')")
        MessageBox.Show("Successfully Created!")
        RefreshData()
    End Sub

End Class