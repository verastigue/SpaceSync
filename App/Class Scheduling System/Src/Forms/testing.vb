Imports MySql.Data.MySqlClient

Public Class testing
    Private connectionString As String = "YourConnectionStringHere"

    Private Sub AutomateScheduling()
        ' Connect to the database
        Using connection As New MySqlConnection(connectionString)
            ' Open the connection
            connection.Open()

            ' Fetch available instructors
            Dim availableInstructors As List(Of String) = GetAvailableInstructors(connection)

            ' Fetch courses that need scheduling
            Dim coursesToSchedule As List(Of Course) = GetCoursesToSchedule(connection)

            ' Loop through courses and assign instructors
            For Each course In coursesToSchedule
                ' Find an available instructor for this course
                Dim instructor As String = FindAvailableInstructor(course, availableInstructors)

                If instructor IsNot Nothing Then
                    ' Schedule the course with the instructor
                    ScheduleCourse(connection, course, instructor)
                    ' Remove the assigned instructor from the list of available instructors
                    availableInstructors.Remove(instructor)
                Else
                    MessageBox.Show("No available instructor found for course: " & course.CourseCode)
                End If
            Next

            MessageBox.Show("Scheduling complete.")
        End Using
    End Sub

    Private Function GetAvailableInstructors(connection As MySqlConnection) As List(Of String)
        Dim instructors As New List(Of String)()

        ' Fetch instructors available on the current day (you might need to refine this logic)
        Dim query As String = "SELECT instructor_no FROM tbl_instructors WHERE availability LIKE CONCAT('%', DAYNAME(NOW()), '%')"

        Using cmd As New MySqlCommand(query, connection)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    instructors.Add(reader.GetString("instructor_no"))
                End While
            End Using
        End Using

        Return instructors
    End Function

    Private Function GetCoursesToSchedule(connection As MySqlConnection) As List(Of Course)
        Dim courses As New List(Of Course)()

        ' Fetch courses that haven't been scheduled yet
        Dim query As String = "SELECT course_code FROM tbl_courses WHERE course_code NOT IN (SELECT course_code FROM tbl_schedules)"

        Using cmd As New MySqlCommand(query, connection)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    courses.Add(New Course(reader.GetString("course_code")))
                End While
            End Using
        End Using

        Return courses
    End Function

    Private Function FindAvailableInstructor(course As Course, availableInstructors As List(Of String)) As String
        ' Simple algorithm: Just pick the first available instructor
        If availableInstructors.Count > 0 Then
            Return availableInstructors(0)
        Else
            Return Nothing
        End If
    End Function

    Private Sub ScheduleCourse(connection As MySqlConnection, course As Course, instructor As String)
        ' You would insert the schedule for the course with the selected instructor here
        ' Example query:
        ' Dim query As String = "INSERT INTO tbl_schedules (course_code, instructor_no, ...) VALUES (@courseCode, @instructorNo, ...)"
        ' Execute the query with appropriate parameters
    End Sub

    Private Class Course
        Public Property CourseCode As String

        Public Sub New(courseCode As String)
            Me.CourseCode = courseCode
        End Sub
    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Call the method to automate scheduling
        AutomateScheduling()
    End Sub
End Class
