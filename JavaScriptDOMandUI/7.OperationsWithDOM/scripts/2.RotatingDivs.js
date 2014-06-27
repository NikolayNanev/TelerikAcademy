window.onload = function(){
    var container = document.getElementById('div-container'),
        center = document.createElement('div');

    container.appendChild(center);
    //center.innerHTML = 'o';
    center.style.position = 'absolute';
    center.style.left = center.parentNode.offsetWidth / 2 + 'px';
    center.style.top = center.parentNode.offsetHeight / 2 + 'px';

    var centerPoint = {
        x: center.parentNode.offsetWidth / 2,
        y: center.parentNode.offsetHeight / 2.2
    };

    var countOfDivs = 25;
    createRandomDivs(countOfDivs, 'div-container');

    var allDivs = document.querySelectorAll('.random-div');

    //Animation parameters
    var currentPoint = {
        x: 0,
        y: 0
    },
        angle = 0,
        radius = (container.offsetWidth + container.offsetHeight) / 5,
        //positive animationSpeed clockwise movement;
        //negativ animationSpeed counterclockwise movement;
        animationSpeed = +0.15;

        
    setInterval(function () {
        for (var i = 0, len = allDivs.length; i < len; i++) {
            currentPoint.x = Math.round(Math.cos(angle) * radius);
            currentPoint.y = Math.round(Math.sin(angle) * radius);
            angle -= 2 * Math.PI / countOfDivs;

            allDivs[i].style.top = (centerPoint.y + currentPoint.y) + "px";
            allDivs[i].style.left = (centerPoint.x + currentPoint.x) + "px";
        }

        angle += animationSpeed;

    }, 100)

    function createRandomDivs(numberOfDivs, containerID) {
        var container = document.getElementById(containerID);
        var dFrag = document.createDocumentFragment();

        var divTemplate = document.createElement('div');

        divTemplate.className = 'random-div';
        divTemplate.style.borderStyle = 'solid';
        divTemplate.style.position = 'absolute';

        for (var i = 0; i < numberOfDivs; i++) {
            divTemplate.id = 'div #' + (i + 1);

            divTemplate.style.left = getRandomNumber(0, container.offsetWidth) + 'px';
            divTemplate.style.top = getRandomNumber(0, container.offsetHeight) + 'px';

            divTemplate.style.width = getRandomNumber(20, 50) + 'px';
            divTemplate.style.height = getRandomNumber(20, 50) + 'px';

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