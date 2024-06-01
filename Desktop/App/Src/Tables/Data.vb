Module Data
    'STORAGE OF DATA
    Public usersData As DataTable
    Public schoolsData As DataTable
    Public programsData As DataTable
    Public sectionsData As DataTable
    Public coursesData As DataTable
    Public instructorsData As DataTable
    Public roomsData As DataTable
    Public schedulesData As DataTable
    Public studentSchedulesData As DataTable
    Public instructorSchedulesData As DataTable
    Public insNotSche As DataTable
    Public secNotSche As DataTable
    Public roomNotSche As DataTable
    Public instrucCourse As DataTable
    Public scheduleToday As DataTable
    Public ongoingSchedule As DataTable
    Public nextSchedule As DataTable
    Public finishSchedule As DataTable
    Public scheduleTime As DataTable
    Public dataChart As DataTable
    Public courseCopy As DataTable

    Sub RefreshData()
        RefreshProgram()
        RefreshCourse()
        RefreshSection()
    End Sub

    Sub RefreshProgram()
        frm_Main.dtgv_program.Columns.Clear()

        programsData = read("SELECT program_code, name, department, NoOfYear FROM tbl_programs")

        ' Bind the data to the DataGridView
        frm_Main.dtgv_program.DataSource = programsData

        ' Change the header names
        frm_Main.dtgv_program.Columns("program_code").HeaderText = "Program Code"
        frm_Main.dtgv_program.Columns("name").HeaderText = "Name"
        frm_Main.dtgv_program.Columns("department").HeaderText = "Department"
        frm_Main.dtgv_program.Columns("NoOfYear").HeaderText = "Years"

        ' Add the "edit" button column
        Dim editColumn As New DataGridViewButtonColumn()
        editColumn.Name = "edit"
        editColumn.HeaderText = "Edit"
        editColumn.Text = "Edit"
        editColumn.DefaultCellStyle.BackColor = Color.FromArgb(255, 213, 79)
        editColumn.UseColumnTextForButtonValue = True
        frm_Main.dtgv_program.Columns.Add(editColumn)

        ' Add the "delete" button column
        Dim deleteColumn As New DataGridViewButtonColumn()
        deleteColumn.Name = "delete"
        deleteColumn.HeaderText = "Delete"
        deleteColumn.Text = "Delete"
        deleteColumn.DefaultCellStyle.BackColor = Color.FromArgb(255, 138, 128)
        deleteColumn.UseColumnTextForButtonValue = True
        frm_Main.dtgv_program.Columns.Add(deleteColumn)

        ' Set the column widths manually
        frm_Main.dtgv_program.Columns("program_code").Width = 150
        frm_Main.dtgv_program.Columns("name").Width = 300
        frm_Main.dtgv_program.Columns("department").Width = 150
        frm_Main.dtgv_program.Columns("NoOfYear").Width = 75
        frm_Main.dtgv_program.Columns("edit").Width = 75
        frm_Main.dtgv_program.Columns("delete").Width = 75


    End Sub

    Sub RefreshSection()
        frm_Main.dtgv_section.Columns.Clear()

        sectionsData = read("SELECT category, program_code, year, name FROM tbl_sections")

        frm_Main.dtgv_section.DataSource = sectionsData

        ' Change the header names
        frm_Main.dtgv_section.Columns("category").HeaderText = "Section"
        frm_Main.dtgv_section.Columns("program_code").HeaderText = "Program"
        frm_Main.dtgv_section.Columns("year").HeaderText = "Year"
        frm_Main.dtgv_section.Columns("name").HeaderText = "Name"
    End Sub

    Sub RefreshCourse()
        frm_Main.dtgv_course.Columns.Clear()

        coursesData = read("SELECT course_code, description, credits, program_code, yrLevel FROM tbl_courses")

        courseCopy = coursesData.Copy
        courseCopy.Columns.Remove("description")
        courseCopy.Columns.Remove("credits")
        courseCopy.Columns.Remove("yrLevel")

        frm_Main.dtgv_course.DataSource = coursesData

        ' Change the header names
        frm_Main.dtgv_course.Columns("course_code").HeaderText = "Subject Code"
        frm_Main.dtgv_course.Columns("description").HeaderText = "Description"
        frm_Main.dtgv_course.Columns("credits").HeaderText = "Credits"
        frm_Main.dtgv_course.Columns("program_code").HeaderText = "Program"
        frm_Main.dtgv_course.Columns("yrLevel").HeaderText = "Year Level"

        ' Set the column widths manually
        frm_Main.dtgv_course.Columns("course_code").Width = 150
        frm_Main.dtgv_course.Columns("description").Width = 300
        frm_Main.dtgv_course.Columns("credits").Width = 75
        frm_Main.dtgv_course.Columns("program_code").Width = 150
        frm_Main.dtgv_course.Columns("yrLevel").Width = 75
    End Sub








End Module
