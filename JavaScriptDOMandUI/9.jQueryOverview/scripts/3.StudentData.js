var students = [
            Student('Mariq', 'Peneva', '6'),
            Student('Boqn', 'Penev', '5'),
            Student('Veliko', 'Stoqnov', '4'),
            Student('Vladimir', 'Hadjiev', '3'),
            Student('Morihei', 'Ueshiba', '7')
];

function Student(firstName, lastName, grade) {
    var student = {
        firstName: firstName,
        lastName: lastName,
        grade: grade
    };

    return student;
}