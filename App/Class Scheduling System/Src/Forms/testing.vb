Public Class testing
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim roomInfo() As String = {
            "101 - PRRC" & Environment.NewLine & "ACSS" & Environment.NewLine & "Evangelio" & Environment.NewLine & "BSIT 2B" & Environment.NewLine & "Mon, Wed" & Environment.NewLine & "10:00pm - 11:00pm",
            "102 - Room 102" & Environment.NewLine & "Some Information" & Environment.NewLine & "BSCPE" & Environment.NewLine & "Tue, Fri" & Environment.NewLine & "07:00pm - 8:00pm",
            "103 - Another Room" & Environment.NewLine & "Some Details" & Environment.NewLine & "ITE" & Environment.NewLine & "Mon, Sat" & Environment.NewLine & "11:00pm - 11:59pm",
            "103 - Another Room" & Environment.NewLine & "Some Details" & Environment.NewLine & "ITE" & Environment.NewLine & "Mon" & Environment.NewLine & "10:30pm - 11:59pm"
        } ' Sample room information

        For Each room As String In roomInfo
            Dim roomPanel As New Panel()
            roomPanel.BorderStyle = BorderStyle.FixedSingle
            roomPanel.Width = 200
            roomPanel.Height = 120

            Dim roomLabel As New Label()
            roomLabel.Text = room
            roomLabel.Dock = DockStyle.Fill
            roomLabel.TextAlign = ContentAlignment.MiddleCenter

            ' Parse room schedule details
            Dim scheduleDetails() As String = room.Split(Environment.NewLine)
            If scheduleDetails.Length >= 6 Then ' Ensure there are enough elements to extract schedule details
                Dim days() As String = scheduleDetails(4).Split(","c)
                Dim scheduleTimes() As String = scheduleDetails(5).Split("-"c)

                If days.Length = 2 AndAlso scheduleTimes.Length = 2 Then ' Ensure the correct format for days and times
                    Dim startTime As DateTime
                    Dim endTime As DateTime

                    If DateTime.TryParse(scheduleTimes(0).Trim(), startTime) AndAlso DateTime.TryParse(scheduleTimes(1).Trim(), endTime) Then
                        ' Check if current day and time fall within the schedule
                        If days.Contains(DateTime.Now.ToString("ddd")) AndAlso DateTime.Now.TimeOfDay >= startTime.TimeOfDay AndAlso DateTime.Now.TimeOfDay <= endTime.TimeOfDay Then
                            roomPanel.BackColor = Color.Red ' Current schedule
                        ElseIf (DateTime.Now.DayOfWeek.ToString() = days(0) AndAlso DateTime.Now.TimeOfDay < startTime.TimeOfDay) OrElse (DateTime.Now.DayOfWeek.ToString() = days(1) AndAlso DateTime.Now.TimeOfDay > endTime.TimeOfDay) Then
                            roomPanel.BackColor = Color.Yellow ' Next to schedule
                        Else
                            ' Check if it's the next scheduled day and time
                            Dim nextScheduledDay As DayOfWeek
                            If [Enum].TryParse(days(0), nextScheduledDay) Then
                                If DateTime.Now.DayOfWeek < nextScheduledDay Then
                                    roomPanel.BackColor = Color.Yellow ' Next to schedule
                                ElseIf DateTime.Now.DayOfWeek > nextScheduledDay Then
                                    roomPanel.BackColor = Color.Green ' Finished schedule
                                ElseIf DateTime.Now.TimeOfDay < startTime.TimeOfDay Then
                                    roomPanel.BackColor = Color.Yellow ' Next to schedule
                                Else
                                    roomPanel.BackColor = Color.Green ' Finished schedule
                                End If
                            End If
                        End If
                    End If
                End If
            End If

            roomPanel.Controls.Add(roomLabel)
            ' Add each room's panel to the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Add(roomPanel)
        Next
    End Sub

    Private Sub RoomPanel_Click(sender As Object, e As EventArgs)
        Dim roomPanel As Panel = CType(sender, Panel)
        If roomPanel.BackColor = Color.Green Then
            roomPanel.BackColor = Color.Red
        Else
            roomPanel.BackColor = Color.Green
        End If
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxICS.CheckedChanged, CheckBoxIBE.CheckedChanged, CheckBoxITE.CheckedChanged
        Dim checkBox As CheckBox = CType(sender, CheckBox)

        If checkBox.Checked Then
            Dim category As String = checkBox.Text.Substring(0, 3) ' Extract the category from the checkbox text

            For Each panel As Panel In FlowLayoutPanel1.Controls.OfType(Of Panel)()
                Dim roomLabel As Label = panel.Controls.OfType(Of Label)().FirstOrDefault()
                If roomLabel IsNot Nothing Then
                    Dim labelText As String = roomLabel.Text

                    ' Check if the label text contains the selected category
                    If labelText.Contains(category) Then
                        panel.Visible = True
                    Else
                        panel.Visible = False
                    End If
                End If
            Next
        ElseIf Not (CheckBoxICS.Checked Or CheckBoxIBE.Checked Or CheckBoxITE.Checked) Then
            ' If no checkbox is checked, repopulate FlowLayoutPanel with all room panels
            For Each panel As Panel In FlowLayoutPanel1.Controls.OfType(Of Panel)()
                panel.Visible = True
            Next
        End If
    End Sub
End Class
