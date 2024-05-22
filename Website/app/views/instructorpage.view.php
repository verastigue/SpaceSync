<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>INSTRUCTOR PAGE</title>
    <link rel="stylesheet" href="../public/styles/mainpagess.css">
    <link rel="stylesheet" href="../public/styles/topbart.css">
</head>
<body>

    <?php require("../views/components/topbar.php") ?>

    <section>
        <h2 class="greetings" style="font-size: 20px;">WELCOME BACK, <?php echo strtoupper($_SESSION["lastname"]); ?>!</h2>
        <div class="content-block">
            <div class="left-content">
                <h3>Your Schedule</h3>
                <ul class="cards">
                    <!-- Cards will be populated dynamically -->
                </ul>
            </div>
            <div class="right-content">
                <div class='top-content'>
                    <h3>Search Schedule</h3>
                    <div class="search-section">
                        <div class="search">
                            <img class="icon" src="../public/images/search-icon.png">
                            <input id="searchInput" type="text" class="search-input" placeholder="Search" onkeyup="searchTable()">
                        </div>
                        <button onclick="printTable()">PRINT</button>
                    </div>
                </div>
                <div class='bottom-content'>
                    <table id="scheduleTable">
                        <thead>
                            <tr>
                                <th>Room No</th>
                                <th>Subject Code</th>
                                <th>Description</th>
                                <th>Credits</th>
                                <th>Section</th>
                                <th>Class Day</th>
                                <th>Time</th>
                            </tr>
                        </thead>
                        <tbody>
                            <!-- Table body will be populated dynamically -->
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </section>

    <script src="../public/scripts/inquiry.js"></script>
    <script src="../public/scripts/Preprint.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="../public/scripts/UpdateInstructorSchedule.js"    ></script>
    
</body>
</html>
