<?php
// Start the session if it hasn't already been started
if (session_status() == PHP_SESSION_NONE) {
    session_start();
}

require_once("../configs/Database.php");
require_once("../models/InstructorModel.php");

$db = new Database();
$instructorModel = new InstructorModel($db);


$cards = $instructorModel->getInstructorSchedule($_SESSION['instructorNo'])->fetchAll();
$colors = array('29CC39', 'FF6633', '8833FF', 'E62E7B', '33BFFF', 'FFCB33', '2EE6CA');
$colorIndex = 0;

ob_start();
foreach ($cards as $index => $card) {
    $currentColor = '#' . $colors[$colorIndex % count($colors)];
    $colorIndex++;
    $borderColor = $currentColor;
    $backgroundOpacity = 0.2;
    list($r, $g, $b) = sscanf($currentColor, "#%02x%02x%02x");
    $backgroundColor = "rgba($r, $g, $b, $backgroundOpacity)";

    // Generate HTML for each card
    ?>
    <li class="card" style="border: <?php echo $borderColor; ?> 3px solid; background-color: <?php echo $backgroundColor; ?>; ">
        <h3 style="font-size: 16px;"><?php echo $card['Description']; ?> <span>(<?php echo $card['course_code']; ?>)</span></h3>
        <div class="card-details">
            <div class="detail-left">
                <span><?php echo $card['Room']; ?></span>
                <span><?php echo $card['Section']; ?></span>
            </div>
            <div class="detail-right">
            <h4 class="class-day">
                <?php 
                    $class_days = explode(',', $card['class_day']); 
                    foreach ($class_days as $day) {
                        echo substr(trim($day), 0, 1) . str_repeat('&nbsp;', 3); 
                    }
                ?>
            </h4>
                <div class="time-section">
                    <span class="time" style="background-color: <?php echo $currentColor; ?>;"><?php echo $card['start_time']; ?></span>
                    <span class="time" style="background-color: <?php echo $currentColor; ?>;"><?php echo $card['end_time']; ?></span>
                </div>
            </div>
        </div>
    </li>
    <?php
}
$html = ob_get_clean();

echo $html;
?>
