<?php 

session_start();
if (!isset($_SESSION['instructorNo'])) {
    header("Location: authentication.php");
    exit;
}

require("../models/InstructorModel.php");

$instructorModel = new InstructorModel($db);



if (isset($_SESSION['instructorNo'])) {
    $lastName = $instructorModel->getInstructorLastName($_SESSION['instructorNo'])->fetchColumn();
    
    if ($lastName) {
        $_SESSION['lastname'] = $lastName;
    } else {
        $_SESSION['lastname'] = ''; 
    }
}

$cards = $instructorModel->getInstructorSchedule($_SESSION['instructorNo'])->fetchAll();


$colors = array('29CC39', 'FF6633', '8833FF', 'E62E7B', '33BFFF', 'FFCB33', '2EE6CA');
$colorIndex = 0;

// Logout logic
if(isset($_POST['logout'])) {
    sleep(2); // Optional delay
    $_SESSION = array();
    session_destroy();
    header("Location: authentication.php"); 
    exit;
}

$schedules = $instructorModel->getAllInstructorSchedule()->fetchAll();

require("../views/instructorpage.view.php");
