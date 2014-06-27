function createDiv() {
    var newDiv = document.createElement("div");
    var content = document.createTextNode("I'm a div!");
    var outputOfNewDiv = document.getElementById("divCollector");

    outputOfNewDiv.appendChild(newDiv);
    newDiv.appendChild(content);
}

function selectDivsWithQuerySelectorAll() {
    var selectedDivs = document.querySelectorAll('div div');    //The object returned with querySelectorAll is a NodeList

    countDivsInsideDiv(selectedDivs);
}

function selectDivsWithGetElementByTagName() {
    var allDivs = document.getElementsByTagName('div');    //The object returned with selectWithGetElementByTagName() is a live NodeList

    var selectedDivs = [];

    for (var i = 0, len = allDivs.length; i < len; i++) {
        var curentElement = allDivs[i].getElementsByTagName('div');

        for (var j = 0, leng = curentElement.length; j < leng; j++) {
            selectedDivs.push(curentElement[j]);
        }
    }

    countDivsInsideDiv(selectedDivs);
}

function countDivsInsideDiv(colectionOfDivs) {
    var countOfDivs = colectionOfDivs.length;

    var isOrAre = (countOfDivs === 1) ? 'is' : 'are';
    var divOrDivs = (countOfDivs === 1) ? 'div' : 'divs';
    jsConsole.writeLine('There ' + isOrAre + ' \'' + countOfDivs + '\' ' + divOrDivs + ' that are directly inside other div elements!');
}