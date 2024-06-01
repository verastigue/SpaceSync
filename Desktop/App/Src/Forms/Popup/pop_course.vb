Public Class pop_course
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click

        Dim selectedProgramCode As String = CType(cb_courseProg.SelectedItem, DataRowView)("program_code").ToString()

        create("INSERT INTO tbl_courses(course_code, description, credits, program_code, yrLevel) VALUES('" & txt_subjectCode.Text & "', '" & txt_courseDesc.Text & "', '" & CInt(cb_courseCred.SelectedItem) & "', '" & selectedProgramCode & "', '" & CInt(cb_courseYear.SelectedItem) & "')")
        MessageBox.Show("Successfully")
        RefreshData()
    End Sub
End Class