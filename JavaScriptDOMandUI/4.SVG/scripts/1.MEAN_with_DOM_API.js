﻿var svgElement = document.getElementById('svg-container');

//First circle
var grayCircle = createCircle(231.334, 161.795, 78.187, '', '#3E3F37');
var path1 = createPath('M234.124,225.348l-2.994-0.992c0,0,0.381-15.15-5.083-16.211 c-3.603-4.174,0.554-178.327,13.644-0.596c0,0-4.48,2.25-5.328,6.068C233.515,217.442,234.124,225.348,234.124,225.348z', '')
var path2 = createPath('M235.737,210.717c0,0,26.011-17.131,19.917-52.709c-5.868-25.849-19.723-34.345-21.212-37.59c-1.639-2.295-3.29-6.364-3.29-6.364l1.106,72.021C232.258,186.074,229.969,208.065,235.737,210.717z', '#449644');
var path3 = createPath('M229.606,211.674c0,0-24.398-16.644-22.995-46.012c1.405-29.368,18.638-43.809,21.994-46.427c2.17-2.313,2.259-3.205,2.427-5.486c1.521,3.267,1.268,48.797,1.429,54.119C233.087,188.584,231.314,207.764,229.606,211.674z', '#5EB14A');

svgElement.appendChild(grayCircle);
svgElement.appendChild(path1);
svgElement.appendChild(path2);
svgElement.appendChild(path3);

//Second circle
var blackCircle = createCircle(231.334, 237.129, 78.187, '', '#221F1F');
var blackCircleText = createText('express', 38.2225, "'Arial'", '#FFFFFF', 'matrix(1 0 0 1 164.417 249.8262)');

svgElement.appendChild(blackCircle);
svgElement.appendChild(blackCircleText);

//Third circle
var redCircle = createCircle(231.334, 327.129, 78.187, '', '#E23336');
var polygon1 = createPolygon('231.192,281.522 186.977,297.083 193.963,355.012 231.239,375.5 268.707,354.735 275.692,296.807', '#B4B4B4');
var polygon2 = createPolygon('231.192,281.522 186.977,297.083 193.963,355.012 231.239,375.5 268.707,354.735 275.692,296.807', '#B4B4B4');
var polygon3 = createPolygon('271.282,300.155 231.089,286.449 231.089,370.605 264.772,351.964', '#B63133');
var polygon4 = createPolygon('191.938,300.402 197.925,352.211 231.088,370.605 231.088,286.447', '#E23335');
var polygon5 = createPolygon('231.089,289.505 231.162,309.004 240.396,328.322 231.11,328.322 231.089,336.411 243.929,336.423 249.93,350.324 259.687,350.505', '#B4B4B4');
var path4 = createPath('M243.929,336.423h-24.501l-5.481,13.71l-10.196,0.188l27.338-60.817l28.292,60.817h-9.451L243.929,336.423zM240.405,328.307l-9.243-19.302l-8.137,19.302H240.405z', '#F3F3F3');

svgElement.appendChild(redCircle);
svgElement.appendChild(polygon1);
svgElement.appendChild(polygon2);
svgElement.appendChild(polygon3);
svgElement.appendChild(polygon4);

//Forth circle

var greenCircle = createCircle(231.334, 405.314, 78.187, '', '#8EC74E');
var path5 = createPath('M194.603,403.381c0-0.475-0.249-0.911-0.658-1.145l-10.903-6.275c-0.185-0.109-0.391-0.166-0.601-0.174c-0.019,0-0.098,0-0.112,0c-0.208,0.009-0.415,0.065-0.603,0.174l-10.903,6.275c-0.406,0.234-0.659,0.669-0.659,1.145l0.024,16.896c0,0.234,0.122,0.453,0.328,0.569c0.203,0.121,0.453,0.121,0.654,0l6.48-3.711c0.409-0.243,0.659-0.673,0.659-1.143v-7.894c0-0.47,0.249-0.905,0.657-1.14l2.759-1.59c0.206-0.118,0.431-0.176,0.66-0.176c0.226,0,0.455,0.058,0.655,0.176l2.759,1.59c0.408,0.234,0.658,0.67,0.658,1.14v7.894c0,0.47,0.253,0.902,0.66,1.143l6.478,3.711c0.203,0.121,0.458,0.121,0.659,0c0.2-0.116,0.327-0.335,0.327-0.569L194.603,403.381z', '#47493F');
var path6 = createPath('M252.825,380.154c-0.204-0.114-0.453-0.111-0.654,0.007c-0.201,0.119-0.325,0.334-0.325,0.568v16.733c0,0.165-0.088,0.317-0.23,0.4c-0.144,0.082-0.318,0.082-0.461,0l-2.73-1.573c-0.408-0.236-0.909-0.235-1.316,0l-10.908,6.295c-0.408,0.235-0.659,0.669-0.659,1.14v12.593c0,0.471,0.251,0.905,0.659,1.14l10.907,6.3c0.408,0.236,0.909,0.236,1.317,0.001l10.909-6.301c0.407-0.235,0.658-0.669,0.658-1.14v-31.391c0-0.477-0.259-0.917-0.676-1.15L252.825,380.154z M251.813,412.179c0,0.118-0.063,0.226-0.164,0.285l-3.746,2.159c-0.102,0.059-0.227,0.059-0.328,0l-3.745-2.159c-0.103-0.059-0.165-0.167-0.165-0.285v-4.322c0-0.118,0.063-0.228,0.164-0.286l3.745-2.164c0.103-0.058,0.228-0.058,0.33,0l3.745,2.164c0.102,0.058,0.164,0.167,0.164,0.286V412.179z', '#47493F');
var path7 = createPath('M291.85,407.741c0.405-0.235,0.655-0.669,0.655-1.139v-3.052c0-0.469-0.251-0.904-0.656-1.139l-10.838-6.292c-0.407-0.238-0.911-0.238-1.319-0.002l-10.904,6.296c-0.407,0.234-0.658,0.669-0.658,1.14v12.59c0,0.473,0.254,0.91,0.665,1.145l10.836,6.174c0.399,0.229,0.89,0.231,1.292,0.007l6.555-3.644c0.207-0.115,0.336-0.333,0.338-0.57c0.002-0.238-0.125-0.458-0.33-0.577l-10.974-6.297c-0.204-0.117-0.331-0.334-0.331-0.571v-3.945c0-0.235,0.126-0.454,0.33-0.57l3.415-1.969c0.203-0.118,0.454-0.118,0.657,0l3.417,1.969c0.204,0.117,0.33,0.335,0.33,0.57v3.104c0,0.236,0.125,0.454,0.33,0.57c0.204,0.118,0.455,0.117,0.659-0.001L291.85,407.741z', '#47493F');
var path8 = createPath('M214.438,396.051c0.407-0.235,0.909-0.235,1.316,0l10.906,6.293c0.408,0.236,0.659,0.671,0.659,1.141v12.598c0,0.471-0.251,0.905-0.658,1.14l-10.906,6.3c-0.408,0.236-0.91,0.236-1.318,0l-10.903-6.3c-0.407-0.235-0.658-0.669-0.658-1.14v-12.598c0-0.47,0.251-0.905,0.658-1.141L214.438,396.051z', '#FFF');
var path9 = createPath('M280.19,407.15c0.078-0.045,0.174-0.045,0.253,0l2.093,1.209c0.079,0.045,0.126,0.128,0.126,0.219v2.416c0,0.09-0.047,0.174-0.126,0.219l-2.093,1.209c-0.079,0.044-0.175,0.044-0.253-0.001l-2.091-1.208c-0.079-0.044-0.127-0.128-0.127-0.219v-2.416c0-0.091,0.048-0.174,0.127-0.219L280.19,407.15z', '#FFF');

svgElement.appendChild(greenCircle);
svgElement.appendChild(path5);
svgElement.appendChild(path6);
svgElement.appendChild(path7);
svgElement.appendChild(path8);
svgElement.appendChild(path9);

//Letters
var letterM = createText('M', '44.9901', "'Arial'", '#3E3F37', 'matrix(1 0 0 1 78.666 173.126)');
var letterE = createText('E', '44.9901', "'Arial'", '#221F1F', 'matrix(1 0 0 1 83.6528 255.7925)');
var letterA = createText('A', '44.9901', "'Arial'", '#E23336', 'matrix(1 0 0 1 82.3296 337.2925)');
var letterN = createText('N', '44.9901', "'Arial'", '#8EC74E', 'matrix(1 0 0 1 81.1597 420.9595)');

svgElement.appendChild(letterM);
svgElement.appendChild(letterE);
svgElement.appendChild(letterA);
svgElement.appendChild(letterN);


function createCircle(x, y, radius, strokeColor, fillColor) {
    var circle = document.createElementNS('http://www.w3.org/2000/svg', 'circle');

    circle.setAttribute('cx', x);
    circle.setAttribute('cy', y);
    circle.setAttribute('r', radius);
    circle.setAttribute('stroke', strokeColor);
    circle.setAttribute('fill', fillColor);

    return circle;
}

function createPath(pathDescription, fillColor) {
    var path = document.createElementNS('http://www.w3.org/2000/svg', 'path');

    path.setAttribute('fill', fillColor);
    path.setAttribute('d', pathDescription);

    return path;
}

function createText(textValue, fontSize, fontFamily, fillColor, transformMatrix) {
    var text = document.createElementNS('http://www.w3.org/2000/svg', 'text');

    text.setAttribute('transform', transformMatrix);
    text.setAttribute('fill', fillColor);
    text.setAttribute('font-family', fontFamily);
    text.setAttribute('font-size', fontSize);
    text.innerHTML = textValue;

    return text;
}

function createPolygon(points, fillColor) {
    var polygon = document.createElementNS('http://www.w3.org/2000/svg', 'polygon');

    polygon.setAttribute('fill', fillColor);
    polygon.setAttribute('points', points);

    return polygon;
}