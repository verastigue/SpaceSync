<?php
session_start();
if (!isset($_SESSION['studentNo'])) {
    header("Location: authentication.php");
    exit;
}


require_once("../models/StudentModel.php");
$studentModel = new StudentModel($db);

if (isset($_SESSION['studentNo'])) {
    $lastName = $studentModel->getStudentLastName($_SESSION['studentNo'])->fetchColumn();
    $_SESSION['lastname'] = $lastName;
}

$colors = array('29CC39', 'FF6633', '8833FF', 'E62E7B', '33BFFF', 'FFCB33', '2EE6CA');
$colorIndex = 0;

if(isset($_POST['logout'])) {
    sleep(2);
    $_SESSION = array();
    session_destroy();
    header("Location: authentication.php"); 
    exit;
}

$schedules = $studentModel->GetAllSchedule()->fetchAll();

require("../views/studentpage.view.php");

