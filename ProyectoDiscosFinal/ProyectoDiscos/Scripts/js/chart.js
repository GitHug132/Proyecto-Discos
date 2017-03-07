var ObjDisco;

/*Funciones para crear la chat de top discos*/
$(document).ready(function() {

    //Ajax
    var request = $.ajax({
        url: "/api/TopDiscos",
        type: "GET",
        contentType: 'application/json',
        dataType: "json",
        success: function (discos) {
            ObjDisco = discos;
            drawChart();
        },
        error: function (e) {
            console.log(e.responseText)
        }
    });

    // Load the Visualization API and the corechart package.
    google.charts.load('current', { 'packages': ['corechart'] });

    // Set a callback to run when the Google Visualization API is loaded.
    google.charts.setOnLoadCallback(drawChart);


});

// on window resize run function
$(window).resize(function () {
    drawChart();
});


// Callback that creates and populates a data table,
// instantiates the pie chart, passes in the data and
// draws it.
function drawChart() {
    if (ObjDisco != undefined) {
        // Create the data table.
        var data = new google.visualization.DataTable();
        data.addColumn('string', 'Título');
        data.addColumn('number', 'Puntuación');
        data.addRows([
          [ObjDisco[0].Titulo, ObjDisco[0].Puntuacion],
          [ObjDisco[1].Titulo, ObjDisco[1].Puntuacion],
          [ObjDisco[2].Titulo, ObjDisco[2].Puntuacion],
          [ObjDisco[3].Titulo, ObjDisco[3].Puntuacion],
          [ObjDisco[4].Titulo, ObjDisco[4].Puntuacion]
        ]);

        // Set chart options
        var options = {
            'title': 'Top 5 Discos'
        }

        // Instantiate and draw our chart, passing in some options.
        var chart = new google.visualization.ColumnChart(document.getElementById('chart_div'));
        chart.draw(data, options);

    }
}
