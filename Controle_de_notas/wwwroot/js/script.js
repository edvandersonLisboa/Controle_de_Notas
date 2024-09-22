function showAlert(message) {
    alert(message);
}


// wwwroot/js/scripts.js
function filterTableByMonth(inputId, tableId, columnIndex) {
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById(inputId);
    filter = input.value.toUpperCase();
    table = document.getElementById(tableId);
    tr = table.getElementsByTagName("tr");


    tr = Array.from(tr);

    var trf = tr.filter((row) => {
        var cells = row.getElementsByTagName("td");
        if (cells.length > columnIndex) {
            var cell = cells[columnIndex];
            if (cell && cell.textContent.trim() !== "") {
                var mes = Number(cell.textContent.split("/")[1]);
                console.log(cell.textContent);
                return mes != Number(filter);
            }

            if (cell.textContent.trim() == "") {

                return row;

            }
        }
        return false;
    });


    var may = trf;

    if (filter.trim() == "") {
        trf.forEach(row => {
            row.style.display = "";

        });
    } else {
        if (filter.trim() != "") {
            tr.forEach(row => {
                row.style.display = "";

            });
        }
        trf.forEach(row => {
            row.style.display = "none";

        });
    }
    // Exibe ou oculta as linhas da tabela com base no filtro
   
}

function filterTableByStatus(inputId, tableId, columnIndex) {
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById(inputId);
    filter = input.value.toUpperCase();
    table = document.getElementById(tableId);
    tr = table.getElementsByTagName("tr");

    for (i = 1; i < tr.length; i++) {
        tr[i].style.display = "none";
        td = tr[i].getElementsByTagName("td")[columnIndex];
        if (td) {
            txtValue = td.textContent || td.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            }
        }
    }
}


//recebidos: [
//    {
//        mes: "",
//        total: "",
//    }],

// wwwroot/js/script.js
function initializeChart(chartId, data, chatData) {

    const meses = ["Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"];
    console.log(data)
    var inadiplentes = data.filter((v) => {
        return v.statusId == 2 || v.statusId == 3;
    });
    var recebidos = data.filter((v) => {
        return v.statusId == 4;
    });

    var atarsado = data.filter((v) => {
        return v.statusId == 3;
    });
    const total_meses_inadiplentes = [0,0,0,0,0,0,0,0,0,0,0,0]
    inadiplentes.forEach((v) => {

        const mes = this.getMonthFromDate(v.dataCobranca);
        total_meses_inadiplentes[mes] += v.valor;

    })
    const total_meses_recebidos = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
    recebidos.forEach((v) => {

        const mes = this.getMonthFromDate(v.dataCobranca);
        total_meses_recebidos[mes] += v.valor;

    })

    var dashboards = {
        datasets: [
            {
                label: "Inadiplentes",
                backgroundColor: "rgba(228, 8, 10, 0.2)",
                borderColor: "rgba(228, 8, 10,1)",
                borderWidth: 1,
                data: total_meses_inadiplentes
            },
            {
                label: "Recebidos",
                backgroundColor: "rgba(75, 192, 192, 0.2)",
                borderColor: "rgba(75, 192, 192, 1)",
                borderWidth: 1,
                data: total_meses_recebidos
            }
            
        ],
        labels:meses
    }

    console.log(chatData);
    console.log(dashboards);
 
    var ctx = document.getElementById(chartId).getContext('2d');
    new Chart(ctx, {
        type: 'bar', // Tipo de gráfico (bar, line, pie, etc.)
        data: dashboards,
        options: {
            responsive: true,
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
}


function getMonthFromDate(dateString) {
    const date = new Date(dateString);
    const month = date.getMonth() + 1; // Adiciona 1 para obter o mês no formato 1-12
    return month;
}


function initializeEvolutionChart(chartId, data) {
    const ctx = document.getElementById(chartId).getContext('2d');
    const meses = ["Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"];
    var recebidos = data.filter((v) => {
        return v.statusId == 4;
    });
    var pendentes = data.filter((v) => {
        return v.statusId == 2 || v.statusId == 3 || v.statusId == 1;
    });

    const total_meses_pendentes = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
    pendentes.forEach((v) => {

        const mes = this.getMonthFromDate(v.dataCobranca);
        total_meses_pendentes[mes] += v.valor;

    })
    const total_meses_recebidos = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
    recebidos.forEach((v) => {

        const mes = this.getMonthFromDate(v.dataCobranca);
        total_meses_recebidos[mes] += v.valor;

    })

    const chartData = {
        labels: meses,
        datasets: [
            {
                label: 'Recebidos',
                data: total_meses_pendentes,
                backgroundColor: "rgba(228, 8, 10, 0.2)",
                borderColor: "rgba(228, 8, 10,1)",
                borderWidth: 1,
                fill: false,
                tension: 0.1
            },
            {
                label: 'Recebidos',
                data: total_meses_recebidos,
                backgroundColor: 'rgba(75, 192, 192, 0.2)',
                borderColor: 'rgba(75, 192, 192, 1)',
                borderWidth: 1,
                fill: false,
                tension: 0.1
            }

        ]
    };

    const config = {
        type: 'line',
        data: chartData,
        options: {
            responsive: true,
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    };

    new Chart(ctx, config);
}


function paginacaoTable(tableId, rowsPerPage) {
    const table = document.getElementById(tableId);
    const rows = table.getElementsByTagName("tr");
    const rowCount = rows.length;
    const pageCount = Math.ceil((rowCount - 1) / rowsPerPage); // Ignora o cabeçalho
    const pagination = document.getElementById("pagination");

    let currentPage = 1;

    function showPage(page) {
        currentPage = page;
        for (let i = 1; i < rowCount; i++) { // Começa em 1 para ignorar o cabeçalho
            if (i > (page - 1) * rowsPerPage && i <= page * rowsPerPage) {
                rows[i].style.display = "";
            } else {
                rows[i].style.display = "none";
            }
        }
        updatePagination();
    }

    function updatePagination() {
        pagination.innerHTML = "";

        // Botão "Prev"
        const prevButton = document.createElement("button");
        prevButton.innerText = "Prev";
        prevButton.disabled = currentPage === 1;
        prevButton.addEventListener("click", function () {
            if (currentPage > 1) {
                showPage(currentPage - 1);
            }
        });
        pagination.appendChild(prevButton);

        // Botão "Next"
        const nextButton = document.createElement("button");
        nextButton.innerText = "Next";
        nextButton.disabled = currentPage === pageCount;
        nextButton.addEventListener("click", function () {
            if (currentPage < pageCount) {
                showPage(currentPage + 1);
            }
        });
        pagination.appendChild(nextButton);
    }

    showPage(1);
}

function initializePieChart(chartId, data) {
    var ctx = document.getElementById(chartId).getContext('2d');
    new Chart(ctx, {
        type: 'pie',
        data: data,
        options: {
            responsive: true
        }
    });
}

function initializeDoughnutChart(chartId, data) {
    var ctx = document.getElementById(chartId).getContext('2d');
    new Chart(ctx, {
        type: 'doughnut',
        data: data,
        options: {
            responsive: true
        }
    });
}