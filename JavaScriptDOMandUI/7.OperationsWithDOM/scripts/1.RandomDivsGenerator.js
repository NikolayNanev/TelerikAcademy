window.onload = function () {
    createRandomDivs(100);

    function createRandomDivs(numberOfDivs) {
        var container = document.getElementById('div-container');
        var dFrag = document.createDocumentFragment();

        var divTemplate = document.createElement('div'),
            strongElemTemplate = document.createElement('strong');

        strongElemTemplate.innerHTML = 'div';
        divTemplate.appendChild(strongElemTemplate);

        divTemplate.className = 'random-div';
        divTemplate.style.borderStyle = 'solid';
        divTemplate.style.position = 'absolute';

        for (var i = 0; i < numberOfDivs; i++) {
            divTemplate.id = 'div #' + (i + 1);

            divTemplate.style.left = getRandomNumber(0, container.offsetWidth) + 'px';
            divTemplate.style.top = getRandomNumber(0, container.offsetHeight) + 'px';

            divTemplate.style.width = getRandomNumber(20, 100) + 'px';
            divTemplate.style.height = getRandomNumber(20, 100) + 'px';

            divTemplate.style.backgroundColor = getRandomColor();
            divTemplate.style.color = getRandomColor();

            divTemplate.style.borderWidth = getRandomNumber(1, 20) + 'px';
            divTemplate.style.borderColor = getRandomColor();
            divTemplate.style.borderRadius = getRandomNumber(0, 50) + 'px';

            dFrag.appendChild(divTemplate.cloneNode(true));
        }

        container.appendChild(dFrag);

        function getRandomNumber(min, max) {
            return Math.floor(Math.random() * (max - min + 1)) + min;
        }

        function getRandomColor() {
            var rgbColor = '';

            var redNuance = getRandomNumber(0, 255),
                greenNuance = getRandomNumber(0, 255),
                blueNuance = getRandomNumber(0, 255);

            rgbColor = 'rgb(' + redNuance + ', ' + greenNuance + ', ' + blueNuance + ')'

            return rgbColor;
        }
    }
}