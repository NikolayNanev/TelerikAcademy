window.onload = function () {
    var fontInput = document.getElementById('font-color'),
            backgroundInput = document.getElementById('background-color');

    fontInput.addEventListener('change', changeFontColor, false);
    backgroundInput.addEventListener('change', changeBackgroundColor, false);

    function changeFontColor(ev) {
        if (!ev) ev = window.event;

        var color = ev.target.value;

        var textArea = document.getElementById('text-area');
        textArea.style.color = color;
    }

    function changeBackgroundColor(ev) {
        if (!ev) ev = window.event;

        var color = ev.target.value;

        var textArea = document.getElementById('text-area');
        textArea.style.backgroundColor = color;
    }
}