﻿Public Class Students
    Private sql As String

    'ADD STUDENTS'
    Public Sub AddNewStudent(students_no As String, firstname As String, lastname As String, email As String, gender As String, student_status As String, program_code As String)
        Try
            sql = "INSERT INTO tbl_students (students_no, firstname, lastname, email, gender, student_status, program_code) VALUES('" & students_no & "', '" & firstname & "', '" & lastname & "', '" & email & "', '" & gender & "', '" & student_status & "', '" & program_code & "' )"
            executeQuery(sql)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Sub enrollCourseToStudent(students_no As String, course_code As String, section As String)
        Try
            sql = "INSERT INTO tbl_enrollments (students_no, course_code, section) VALUES('" & students_no & "', '" & course_code & "', '" & section & "')"
            executeQuery(sql)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    'SEARCH STUDENTS BY INPUT'
    Public Function SearchStudents(input As String) As DataTable
        Dim dt As New DataTable
        Try
            sql = "SELECT * FROM tbl_students WHERE students_no = '" & input & "' OR firstname = '" & input & "' OR lastname = '" & input & "' OR email = '" & input & "', gender = '" & input & "', student_status = '" & input & "'"
            dt = read(sql)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
        Return dt
    End Function

    'UPDATE STUDENT'
    Public Sub UpdateStudent(students_no As String, firstname As String, lastname As String, email As String, gender As String, student_status As String)
        Try
            sql = "UPDATE tbl_students SET students_no = '" & students_no & "', firstname = '" & firstname & "', lastname = '" & lastname & "', email = '" & email & "', gender = '" & gender & "', student_status = '" & students_no & "'"
            update(sql)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    'DELETE STUDENT BY NO'
    Public Sub DeleteStudent(students_no As String)
        Try
            sql = "DELETE FROM tbl_students WHERE students_no = '" & students_no & "'"
            delete(sql)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    'COUNT ALL STUDENTS'
    Function CountAllStudents() As Integer
        Dim tryCount As Integer = 0

        Try
            sql = "SELECT COUNT(*) FROM tbl_students"
            tryCount = count(sql)

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try

        Return tryCount
    End Function

    'COUNT REGULAR STUDENTS'
    Function CountRegularStudent() As Integer
        Dim tryCount As Integer = 0

        Try
            sql = "SELECT COUNT(*) FROM tbl_students WHERE student_status = 'Regular'"
            tryCount = count(sql)

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try

        Return tryCount
    End Function

    'COUNT IRREGULAR STUDENTS'
    Function CountIrregularStudent() As Integer
        Dim tryCount As Integer = 0

        Try
            sql = "SELECT COUNT(*) FROM tbl_students WHERE student_status = 'Irregular'"
            tryCount = count(sql)

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try

        Return tryCount
    End Function

    'STUDENT THAT HAS BEEN ENROLLED'
    Public Function StudentEnrolled() As DataTable
        Dim dt As New DataTable
        Try
            sql = "SELECT tbl_students.students_no,tbl_enrollments.course_code, tbl_enrollments.section FROM tbl_students INNER JOIN tbl_enrollments ON tbl_students.students_no = tbl_enrollments.students_no"
            dt = read(sql)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
        Return dt
    End Function

    'COUNT STUDENT THAT HAS BEEN ENROLLED'
    Public Sub CountStudentEnrolled()
        Try
            sql = "SELECT COUNT(*) FROM tbl_enrollments"
            read(sql)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    'STUDENTS SCHEDULE
    Function ReadAllStudentsShedule() As DataTable
        Dim dataTable As New DataTable

        Try
            sql = "SELECT tbl_enrollments.students_no AS Student, tbl_courses.course_code, tbl_courses.description AS Description, tbl_sections.category AS Section, tbl_schedules.class_day, CONCAT(TIME_FORMAT(tbl_schedules.start_time, '%h:%i %p'), ' - ', TIME_FORMAT(tbl_schedules.end_time, '%h:%i %p')) AS Time, tbl_rooms.room_no, tbl_courses.credits AS Credits, tbl_instructors.lastname AS Instructor FROM tbl_enrollments INNER JOIN tbl_sections ON tbl_enrollments.section = tbl_sections.category INNER JOIN tbl_courses ON tbl_enrollments.course_code = tbl_courses.course_code LEFT JOIN tbl_schedules ON tbl_enrollments.course_code = tbl_schedules.course_code AND tbl_enrollments.section = tbl_schedules.section LEFT JOIN tbl_rooms ON tbl_schedules.room_no = tbl_rooms.room_no LEFT JOIN tbl_instructors ON tbl_schedules.instructor_no = tbl_instructors.instructor_no WHERE (tbl_rooms.room_no IS NOT NULL OR tbl_instructors.instructor_no IS NOT NULL OR tbl_sections.category IS NOT NULL OR tbl_courses.course_code IS NOT NULL) AND tbl_instructors.lastname IS NOT NULL ORDER BY FIELD(tbl_schedules.class_day, 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'), tbl_schedules.start_time DESC;"
            dataTable = read(sql)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try

        Return dataTable
    End Function
End Class
