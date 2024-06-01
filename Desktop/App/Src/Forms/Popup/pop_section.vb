Imports Guna.UI2.WinForms

Public Class pop_section

    Private Sub pop_section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RefreshData()
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click

        'ADD YEARS IN THE LIST
        Dim yearsList As New List(Of Integer)()
        For i As Integer = 1 To 5
            Dim checkBox As Guna2CheckBox = CType(Me.Controls("ckb_" & i), Guna2CheckBox)
            If checkBox.Checked Then
                yearsList.Add(i)
            End If
        Next

        Dim selectedProgramCode As String = CType(cb_secProgCode.SelectedItem, DataRowView)("program_code").ToString()

        For Each year As Integer In yearsList
            create("INSERT INTO tbl_sections(category, program_code, year, name) VALUE('" & selectedProgramCode & " " & year & txt_name.Text & "', '" & selectedProgramCode & "', '" & year & "', '" & txt_name.Text & "')")
        Next
        MessageBox.Show("Successfully Created!")
    End Sub


End Class