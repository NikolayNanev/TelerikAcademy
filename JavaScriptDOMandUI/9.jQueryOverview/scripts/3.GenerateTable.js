var $tableContainer = $('#table-container');
generateTable($tableContainer, students);

function generateTable(container, students) {
    var $table = $('<table>')
        .html('<thead><tr><th>First name</th><th>Last name</th><th>Grade</th></tr></thead>');

    var $tableBody = $('<tbody>');

    for (var i = 0, len = students.length; i < len; i++) {
        var $firstName = $('<td>').append(students[i].firstName);
        var $lastName = $('<td>').append(students[i].lastName);
        var $grade = $('<td>').append(students[i].grade);

        var $nextRow = $('<tr>').append($firstName).append($lastName).append($grade);


        $tableBody.append($nextRow);
    }

    container.append($table.append($tableBody));
}