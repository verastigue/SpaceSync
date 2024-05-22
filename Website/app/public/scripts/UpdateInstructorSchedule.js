var lastFetchedCards = '';
var lastFetchedTable = '';

function updateInstructorCards() {
    $.ajax({
        url: 'get_instructor_cards_schedule.php',
        method: 'GET',
        success: function(response) {
            if (response !== lastFetchedCards) {
                $('.cards').html(response);
                lastFetchedCards = response;
            }
        }
    });
}

function updateInstructorSchedule() {
    $.ajax({
        url: 'get_instructor_table_schedule.php',
        method: 'GET',
        success: function(response) {
            if (response !== lastFetchedTable) {
                // Store the current scroll position
                var scrollPos = $('#scheduleTable').scrollTop();

                // Update the table body
                $('#scheduleTable tbody').html(response);

                // Restore the scroll position
                $('#scheduleTable').scrollTop(scrollPos);

                lastFetchedTable = response;
            }
        }
    });
}

// Initial updates
updateInstructorCards();
updateInstructorSchedule();

// Periodic updates every 5 seconds
setInterval(function() {
    updateInstructorCards();
    updateInstructorSchedule();
}, 7000);
