function printValueOfTextInput() {
    var textInput = document.getElementById('text');

    var valueOfInput = textInput.value;

    jsConsole.writeLine('Value of text input: ' + valueOfInput);
}