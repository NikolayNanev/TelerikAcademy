function changeColor() {
    var valueOfInputColor = document.getElementById('color');

    var color = valueOfInputColor.value;
    document.body.style.backgroundColor = color;
}