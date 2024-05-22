<?php
require_once("../configs/Database.php");
require_once("../models/InstructorModel.php");

$db = new Database();
$instructorModel = new InstructorModel($db);


$schedules = $instructorModel->getAllInstructorSchedule()->fetchAll();

ob_start();
foreach ($schedules as $schedule) {
    // Generate HTML for each row of the table
    ?>
    <tr>
        <td><?php echo $schedule['room_no']; ?></td>
        <td><?php echo $schedule['course_code']; ?></td>
        <td><?php echo $schedule['Description']; ?></td>
        <td><?php echo $schedule['Credits']; ?></td>
        <td><?php echo $schedule['section']; ?></td>
        <td><?php echo $schedule['class_day']; ?></td>
        <td><?php echo $schedule['Time']; ?></td>
    </tr>
    <?php
}
$html = ob_get_clean();

echo $html;
?>
