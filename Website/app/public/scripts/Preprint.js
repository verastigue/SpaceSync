function printTable() {
    let tableToPrint = document.getElementById('scheduleTable').outerHTML;
    let printWindow = window.open('', '_blank');
    printWindow.document.open();
    printWindow.document.write('<html><head><title>Colegio De Montalban</title>');
    
    // Include stylesheets
    let stylesheets = document.querySelectorAll('link[rel="stylesheet"]');
    stylesheets.forEach(function(stylesheet) {
        printWindow.document.write(stylesheet.outerHTML);
    });

    // Add custom styles
    printWindow.document.write('<style>');
    printWindow.document.write('@page { size: letter; }'); // Set paper size to Letter
    printWindow.document.write('body { margin: 0; }'); 
    printWindow.document.write('.logo { position: absolute; top: 50%; left: 50%; transform: translate(-50%, -50%); width: 400px !important; height: 400px !important; opacity: 0.2; }'); // Adjusted logo size and opacity
    printWindow.document.write('table { border-collapse: collapse; }'); // Set border-collapse for the table
    printWindow.document.write('.title { font-size: 20px; text-align: center; margin-top: 20px; font-weight: bold; }'); // Title style with added bold font-weight
    printWindow.document.write('.title ~ table { margin-top: 40px; }'); // Add space between title and table with pixels
    printWindow.document.write('</style>');

    // Add logo and title
    printWindow.document.write('</head><body>');
    printWindow.document.write('<div class="title">Colegio De Montalban</div>'); // Title
    printWindow.document.write('<img src="../public/images/cdm-logo.png" class="logo" alt="CDM Logo">'); // Logo
    // Add table
    printWindow.document.write(tableToPrint);
    printWindow.document.write('</body></html>');
    
    // Finish and print
    printWindow.document.close();
    printWindow.print();
}
