<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Class Scheduling System | Login</title>
    <link rel="stylesheet" href="../public/styles/authenticationt.css">
</head>
<body>
<div class="container">
        <div class="left-content">
            <h2 >Colegio de Montalban’s <br><span>Class Scheduling System</span></h2>
            <form action="" method="post">
                <div class="input-block">
                    <div class="input-group">
                        <label for="StudentInstructorNo">Student or Instructor No.</label>
                        <input type="text" name="StudentInstructorNo">
                    </div>
                    <div class="input-group">
                        <label for="email">Email</label>
                        <input type="text" name="email">
                    </div>
                    <div class="input-group">
                        <label for="LoginType">Login Type</label>
                        <select name="LoginType">
                            <option value="">Select role</option>
                            <option value="Student">Student</option>
                            <option value="Instructor">Instructor</option>
                        </select>
                    </div>
                </div>
                <button type="submit" name="login">Login</button>
            </form>
        </div>

        <div class="right-content">
            <img src="../public/images/illus_boy.png" alt="">
        </div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <script>
        <?php if(isset($_SESSION['message'])): ?>
            Swal.fire({
                icon: '<?php echo $_SESSION['message']['type']; ?>',
                title: '<?php echo $_SESSION['message']['title']; ?>',
                text: '<?php echo $_SESSION['message']['text']; ?>',
            }).then(function() {
                <?php unset($_SESSION['message']); ?>
            });
        <?php endif; ?>
    </script>
    
</body>
</html>