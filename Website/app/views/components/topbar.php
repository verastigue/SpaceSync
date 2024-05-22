<?php
if (session_status() === PHP_SESSION_NONE) {
    session_start();
}
?>


<div class="upper-bar-wrapper">
    
    <div class="upper-bar">
        <div class="left-side">
            <img src="../public/images/cdm-logo.png" alt="">
            <h2 >Colegio de Montalban’s <br><span>Class Scheduling System</span></h2>
        </div>
        
        <div class="right-side">
            <h2 style="font-size: 18px;">
                <?php
                if(isset($_SESSION['user_type'])) {
                    if($_SESSION['user_type'] == 'instructor' && isset($_SESSION['instructorNo'])) {
                        echo $_SESSION['instructorNo'];
                    } elseif($_SESSION['user_type'] == 'student' && isset($_SESSION['studentNo'])) {
                        echo $_SESSION['studentNo'];
                    }
                }
                ?>
            </h2>
            <form method="post">
                <button type="submit" class="logout-button" name="logout">LOGOUT</button>
            </form>
        </div>
    </div>

</div>

