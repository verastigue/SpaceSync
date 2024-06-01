Imports Guna.UI2.WinForms

Public Class pop_instructor

    Private Sub btn_cancel_Click_1(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub cb_emploStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_emploStatus.SelectedIndexChanged
        Dim isFullTime As Boolean = (cb_emploStatus.SelectedItem = "Full Time")
        ckb_sun.Checked = isFullTime
        ckb_mon.Checked = isFullTime
        ckb_tue.Checked = isFullTime
        ckb_wed.Checked = isFullTime
        ckb_thu.Checked = isFullTime
        ckb_fri.Checked = isFullTime
        ckb_sat.Checked = isFullTime
    End Sub

    Private Sub btn_nextInsCourse_Click(sender As Object, e As EventArgs) Handles btn_nextInsCourse.Click
        ' Assigning the input values to the module variables
        instrucotNo = txt_instrucNo.Text
        firstName = txt_firstname.Text
        lastName = txt_lastname.Text
        email = txt_email.Text
        gender = cb_gender.SelectedItem.ToString()
        employeeStatus = cb_emploStatus.SelectedItem.ToString()

        ' Initialize the availability list
        availability = New List(Of String)()

        ' Check each checkbox and add the corresponding day to the list if checked
        If ckb_sun.Checked Then availability.Add("Sun")
        If ckb_mon.Checked Then availability.Add("Mon")
        If ckb_tue.Checked Then availability.Add("Tue")
        If ckb_wed.Checked Then availability.Add("Wed")
        If ckb_thu.Checked Then availability.Add("Thu")
        If ckb_fri.Checked Then availability.Add("Fri")
        If ckb_sat.Checked Then availability.Add("Sat")



        ' Show the popup form
        Dim popup As New pop_instrucCourse
        popup.StartPosition = FormStartPosition.CenterParent

        Dim checkBox As New DataGridViewCheckBoxColumn()
        checkBox.HeaderText = "Check"
        checkBox.Name = "check"
        popup.dtgv_InstrucCourse.Columns.Add(checkBox)

        popup.dtgv_InstrucCourse.DataSource = courseCopy



        popup.ShowDialog(Me)
    End Sub

End Class