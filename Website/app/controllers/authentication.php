<?php
session_start();
if (isset($_SESSION['studentNo'])) {
    header("Location: studentpage.php");
    exit;
} elseif (isset($_SESSION['instructorNo'])) {
    header("Location: instructorpage.php");
    exit;
}
if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST['login'])) {
    
    $studentInstructorNo = $_POST['StudentInstructorNo'];
    $loginType = $_POST['LoginType'];
    $email = $_POST['email'];

    if (empty($studentInstructorNo) || empty($email) || empty($loginType)) {
        $message = [
            'type' => 'error',
            'title' => 'Error',
            'text' => 'Please fill in all fields.'
        ];
    } else {
        // VALIDATE THE LOGIN 
        if ($loginType == 'Student') {
            require("../models/StudentModel.php");
            $studentNo = $_POST['StudentInstructorNo'];
            $studentModel = new StudentModel($db);
            $count = $studentModel->validateStudent($studentNo, $email);

            if ($count > 0) {
                $_SESSION['studentNo'] = $studentNo;
                
                $_SESSION['user_type'] = 'student'; 
                sleep(2);
                header('Location: studentpage.php');
                exit;
            } else {
                $message = [
                    'type' => 'error',
                    'title' => 'Error',
                    'text' => 'Invalid credentials for student.'
                ];
            }
        } elseif ($loginType == 'Instructor') {
            require("../models/InstructorModel.php");
            $instructorNo = $_POST['StudentInstructorNo'];
            $instructorModel = new InstructorModel($db);
            $count = $instructorModel->validateInstructor($instructorNo, $email);
  
            if ($count > 0) {
                $_SESSION['instructorNo'] = $instructorNo;
                
                $_SESSION['user_type'] = 'instructor'; 
                sleep(2);
                header('Location: instructorpage.php');
                exit;
            } else {
                $message = [
                    'type' => 'error',
                    'title' => 'Error',
                    'text' => 'Invalid credentials for instructor.'
                ];
            }
        }
    }
    $_SESSION['message'] = $message;
}

require("../views/authentication.view.php");