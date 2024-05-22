<?php
require_once("../configs/Database.php");

$db = new Database();
class StudentModel {
    private $db;

    public function __construct(Database $db) {
        $this->db = $db;
    }

    public function validateStudent($studentNo, $email) {
        $query = "SELECT COUNT(*) FROM tbl_students WHERE students_no = :studentNo AND email = :email";

        $params = [
            ':studentNo' => $studentNo,
            ':email' => $email
        ];

        
    
        $result = $this->db->executeQuery($query, $params)->fetchColumn();

        return $result;
    }

    public function getStudentLastName($studentNo) {
        $query = "SELECT lastname FROM tbl_students WHERE students_no = :studentNo";

        $params = [
            ':studentNo' => $studentNo
        ];

        $result = $this->db->executeQuery($query, $params);

        return $result;
    }

    public function GetStudentScheduleByStudentNo($studentNo) {

        $query = "SELECT 
        CONCAT(tbl_rooms.room_no, ' - ', tbl_rooms.building_name) AS Room, 
        tbl_enrollments.students_no AS Student, 
        tbl_courses.course_code, 
        tbl_courses.description AS Description, 
        tbl_sections.category AS Section, 
        tbl_schedules.class_day,
        TIME_FORMAT(tbl_schedules.start_time, '%h:%i %p') AS start_time,
        TIME_FORMAT(tbl_schedules.end_time, '%h:%i %p') AS end_time,
        tbl_courses.credits AS Credits, 
        tbl_instructors.lastname AS Instructor 
    FROM 
        tbl_enrollments 
    LEFT JOIN 
        tbl_sections ON tbl_enrollments.section = tbl_sections.category 
    LEFT JOIN 
        tbl_courses ON tbl_enrollments.course_code = tbl_courses.course_code 
    LEFT JOIN 
        tbl_schedules ON tbl_enrollments.course_code = tbl_schedules.course_code AND tbl_enrollments.section = tbl_schedules.section 
    LEFT JOIN 
        tbl_rooms ON tbl_schedules.room_no = tbl_rooms.room_no 
    LEFT JOIN 
        tbl_instructors ON tbl_schedules.instructor_no = tbl_instructors.instructor_no 
    WHERE 
        tbl_enrollments.students_no = :studentNo
    ORDER BY 
        FIELD(tbl_schedules.class_day, 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'), 
        tbl_schedules.start_time DESC;
    ";

        $params = [
            ':studentNo' => $studentNo
        ];

        $result = $this->db->executeQuery($query, $params);
        
        return $result;
    }

    public function GetAllSchedule(){
        $query = "SELECT s.room_no, s.course_code, c.description AS Description, c.credits AS Credits, CONCAT(i.firstname, ' ', i.lastname) AS Instructor, s.section, s.class_day, CONCAT(TIME_FORMAT(s.start_time, '%h:%i %p'), ' - ', TIME_FORMAT(s.end_time, '%h:%i %p')) AS Time FROM tbl_schedules s LEFT JOIN tbl_instructors i ON s.instructor_no = i.instructor_no LEFT JOIN tbl_courses c ON s.course_code = c.course_code ORDER BY FIELD(s.class_day, 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'), s.start_time DESC";


        $result = $this->db->executeQuery($query);
    
        return $result;
    }   


}