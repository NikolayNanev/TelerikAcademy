function createRectangle(x, y, width, height, fillColor) {
    var rectangle = document.createElementNS('http://www.w3.org/2000/svg', 'rect');

    rectangle.setAttribute('x', x);
    rectangle.setAttribute('y', y);
    rectangle.setAttribute('width', width);
    rectangle.setAttribute('height', height);
    rectangle.setAttribute('fill', fillColor);

    return rectangle;
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

function createImage(imgHref, width, height, transformMatrix) {
    var image = document.createElementNS('http://www.w3.org/2000/svg', 'image');

    image.setAttribute('xlink:href', imgHref);
    image.setAttribute('width', width);
    image.setAttribute('height', height);
    image.setAttribute('transform', transformMatrix);

    return image;
}