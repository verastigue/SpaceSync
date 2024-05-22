function searchTable() {
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("searchInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("scheduleTable");
    tr = table.getElementsByTagName("tr");
    
    // Loop through table rows
    for (i = 0; i < tr.length; i++) {
        var display = false;
        td = tr[i].getElementsByTagName("td");
        
        // Loop through table cells
        for (var j = 0; j < td.length; j++) {
            if (td[j]) {
                txtValue = td[j].textContent || td[j].innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    display = true;
                    break; // Break out of inner loop if match found
                }
            }
        }
        
        // Set display style based on search result
        if (display || tr[i].querySelector('th')) {
            tr[i].style.display = "";
        } else {
            tr[i].style.display = "none";
        }
    }
}
