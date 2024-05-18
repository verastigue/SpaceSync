<?php

require("../configs/Database.php");

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
    
        return $this->db->executeQuery($query, $params);
    }

    
}