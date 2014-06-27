window.onload = function () {
    var addButton = document.getElementById("add-task-button");
    addButton.addEventListener("click", function () {
        var valueOfInput = document.getElementById("task-content").value;
        var taskElement = createTask(valueOfInput);

        if (taskElement) {
            var taskList = document.getElementById('task-container');
            taskList.appendChild(taskElement);
        }

        document.getElementById("task-content").value = '';

        function createTask(content) {
            if (content === '') {
                return;
            }

            var newTask = document.getElementById('task-template').cloneNode(true),
                taskText = document.createElement('span'),
                buttonContainer = newTask.getElementsByClassName('button-container')[0],
                showButton = newTask.getElementsByClassName('show-button')[0],
                hideButton = newTask.getElementsByClassName('hide-button')[0],
                delButton = newTask.getElementsByClassName('del-button')[0];

            taskText.innerHTML = content;
            newTask.id = '';
            newTask.insertBefore(taskText, buttonContainer);

            var currentTaskDisplay = taskText.style.display;

            newTask.addEventListener('mouseover', function (ev) {
                taskText.style.display = 'inline-block';
                buttonContainer.style.display = 'block';
                showButton.style.display = 'block';
                hideButton.style.display = 'block';
                delButton.style.display = 'block';
            }, false);

            newTask.addEventListener('mouseout', function (ev) {
                if (currentTaskDisplay === 'none') {
                    taskText.style.display = 'none';
                }

                buttonContainer.style.display = 'none';
                showButton.style.display = 'none';
                hideButton.style.display = 'none';
                delButton.style.display = 'none';
            }, false);

            showButton.addEventListener('click', function (ev) {
                taskText.style.display = 'inline-block';
                currentTaskDisplay = 'inline-block';
            }, false);

            hideButton.addEventListener('click', function (ev) {
                taskText.style.display = 'none';
                currentTaskDisplay = 'none';
            }, false);

            delButton.addEventListener('click', function (ev) {
                newTask.parentNode.removeChild(newTask);
            }, false);

            return newTask;
        }
    }, false);    
}