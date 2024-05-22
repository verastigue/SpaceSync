<?php

require_once("../configs/Database.php");

$db = new Database();

class InstructorModel {
    private $db;

    public function __construct(Database $db) {
        $this->db = $db;
    }

    public function validateInstructor($instructorNo, $email) {
        $query = "SELECT COUNT(*) FROM tbl_instructors  WHERE instructor_no = :instructorNo AND email = :email";
        $params = [
            ':instructorNo' => $instructorNo,
            ':email' => $email
        ];
    
        
        $result =  $this->db->executeQuery($query, $params)->fetchColumn();

        return $result;
    }
    public function getInstructorLastName($instructorNo){
        $query = "SELECT lastname FROM tbl_instructors WHERE instructor_no = :instructorNo;";
        $params = [
            ':instructorNo' => $instructorNo
        ];

        $result = $this->db->executeQuery($query, $params);
        return $result;
    }

    public function getInstructorSchedule($instructorNo){
        $query = "SELECT 
        CONCAT(tbl_rooms.room_no, ' - ', tbl_rooms.building_name) AS Room, 
        tbl_courses.course_code, 
        tbl_courses.description AS Description, 
        tbl_sections.category AS Section, 
        tbl_schedules.class_day,
        TIME_FORMAT(tbl_schedules.start_time, '%h:%i %p') AS start_time,
        TIME_FORMAT(tbl_schedules.end_time, '%h:%i %p') AS end_time,
        tbl_courses.credits AS Credits
            FROM 
                tbl_schedules
            LEFT JOIN 
                tbl_rooms ON tbl_schedules.room_no = tbl_rooms.room_no 
            LEFT JOIN 
                tbl_instructors ON tbl_schedules.instructor_no = tbl_instructors.instructor_no 
            LEFT JOIN 
                tbl_sections ON tbl_schedules.section = tbl_sections.category 
            LEFT JOIN 
                tbl_courses ON tbl_schedules.course_code = tbl_courses.course_code 
            WHERE 
                tbl_instructors.instructor_no = :instructorNo
                AND (tbl_rooms.room_no IS NOT NULL OR tbl_sections.category IS NOT NULL OR tbl_courses.course_code IS NOT NULL) 
            ORDER BY 
                FIELD(tbl_schedules.class_day, 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'), 
                tbl_schedules.start_time DESC;
            ";
        $params = [
            ':instructorNo' => $instructorNo
        ];

        $result = $this->db->executeQuery($query, $params);
        return $result;
    }

    public function getAllInstructorSchedule(){
        $query = "SELECT 
        s.room_no, 
        s.course_code, 
        c.description AS Description, 
        c.credits AS Credits, 
        s.section, 
        s.class_day, 
        CONCAT(TIME_FORMAT(s.start_time, '%h:%i %p'), ' - ', TIME_FORMAT(s.end_time, '%h:%i %p')) AS Time 
            FROM 
                tbl_schedules s 
            LEFT JOIN 
                tbl_instructors i ON s.instructor_no = i.instructor_no 
            LEFT JOIN 
                tbl_courses c ON s.course_code = c.course_code 
            ORDER BY 
                FIELD(s.class_day, 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'), 
                s.start_time DESC;
            ";


        $result = $this->db->executeQuery($query);
        return $result;
    }
    
        
 
    
}