var lastFetchedCards = ''; 
var lastFetchedTable = ''; 

function updateScheduleCards() {
    $.ajax({
        url: 'get_student_schedule_cards.php',
        method: 'GET',
        success: function(response) {
            if (response !== lastFetchedCards) {
                $('.cards').html(response);
                lastFetchedCards = response;
            }
        }
    });
}

function updateScheduleTable() {
    $.ajax({
        url: 'get_student_schedule_table.php',
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

// Initial update
updateScheduleCards();
updateScheduleTable();

// Periodic updates every 5 seconds
setInterval(function() {
    updateScheduleCards();
    updateScheduleTable();
}, 5000);
