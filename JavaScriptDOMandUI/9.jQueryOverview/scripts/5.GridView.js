var $inputRowsBtn = $('#input-rows-btn');
var $addRowBtn = $('#add-row-btn');
var $addHeadBtn = $('#add-head-btn');

$inputRowsBtn.on('click', function () {
    var $columnsCount = $('#input-grid-columns').val();
    var $container = $('#inputs-row');

    generateInputsForRow($columnsCount, $container);
});
$addHeadBtn.on('click', addHead);
$addRowBtn.on('click', addRow);

function generateInputsForRow(columnsCount, container) {
    container.html('').append($('<span>').html('Input data:'));

    for (var i = 0; i < columnsCount; i++) {
        container.append($('<input>').addClass('input-data').attr('type', 'text'));
    }
}

function addRow() {
    var $dataContainer = $('#inputs-row');
    var $inputRows = $dataContainer.children('.input-data');
    var $tableBody = $('#table-body');
    var $newRow = $('<tr>');

    for (var i = 0, len = $inputRows.length; i < len; i++) {
        var $cellData = $($inputRows[i]).val()
        var $newCell = $('<td>').html($cellData);
        $newRow.append($newCell);
    }

    var deleteButton = $('<button>')
        .html('del')
        .on('click', function () {
            var $currentRow = $(this).parent('tr');
            $currentRow.remove('tr', false);
        })

    $newRow.append(deleteButton)

    $tableBody.append($newRow);
}

function addHead() {
    var $dataContainer = $('#inputs-row');
    var $inputRows = $dataContainer.children('.input-data');
    var $tableHead = $('#table-head').html('');
    var $newHead = $('<tr>');

    for (var i = 0, len = $inputRows.length; i < len; i++) {
        var $cellData = $($inputRows[i]).val()
        var $newCell = $('<th>').html($cellData);
        $newHead.append($newCell);
    }

    $tableHead.append($newHead);
}