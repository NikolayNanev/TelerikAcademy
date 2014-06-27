var stage = new Kinetic.Stage({
    container: 'canvas-container',
    width: 1800,
    height: 1000
});

var layer = new Kinetic.Layer();

var peopleInFamilyTree = parsePersons(familyMembers2);
var treeRoot = findRoot(peopleInFamilyTree);

var drawer = new Drawer(layer);
drawer.drawTree(treeRoot, 10, 10);
layer.offsetX(findMinXCoordinate(peopleInFamilyTree));
stage.add(layer);

function parsePersons(familyTreeData) {
    var persons = [];

    for (var i = 0; i < familyTreeData.length; i++) {
        var family = familyTreeData[i];
        var mother = addNewPerson(family.mother, persons);
        var father = addNewPerson(family.father, persons);

        mother.spouse = father;
        father.spouse = mother;
        mother.isFemale = true;

        for (var j = 0; j < family.children.length; j++) {
            var child = addNewPerson(family.children[j], persons);

            mother.children.push(child);
            father.children.push(child);

            child.mother = mother;
            child.father = father;
        }
    }

    return persons;

    function addNewPerson(currentPersonsName, arrPeople) {
        for (var i = 0; i < arrPeople.length; i++) {
            if (arrPeople[i].name === currentPersonsName) {
                return arrPeople[i];
            }
        }

        var newPerson = new Person(currentPersonsName);
        arrPeople.push(newPerson);
        return newPerson;

    }

    function Person(name) {
        this.name = name;
        this.children = [];

        this.hasOffspring = function () {
            if (this.children.length > 0) {
                return true;
            }
        };

        this.hasParents = function () {
            if (this.father || this.mother) {
                return true;
            }
        };

        this.isFemale = false;
    }
}

function findRoot(people) {
    for (var i = 0; i < people.length; i++) {
        if (!people[i].hasParents() && !people[i].spouse.hasParents()) {
            return people[i];
        }
    }
}

function findMinXCoordinate(persons) {
    var currentMin = Number.MAX_VALUE;
    for (var i = 0; i < persons.length; i++) {
        if (persons[i].x && persons[i].x < currentMin) {
            currentMin = persons[i].x;
        }
    }
    return currentMin;
}

function Drawer(layer) {
    var nodeWidth = 150;
    var nodeHeight = 30;

    var widthSpace = nodeWidth + 10;
    var heightSpace = nodeHeight + 50;

    var fontSize = 12;
    var strokeColor = '#black';
    var textPadding = 10;
    var textColor = 'black';

    this.drawTree = function (currentNode, startX, startY) {
        var x = startX;
        var y = startY;

        if (currentNode.spouse) {
            this.drawPerson(currentNode.spouse, x, y);
            x += widthSpace;
        }
        this.drawPerson(currentNode, x, y);

        x = startX;

        for (var i = 0; i < currentNode.children.length; i++) {
            if (i && currentNode.children[i - 1].spouse) {
                x += widthSpace;
            }
            this.drawTree(currentNode.children[i], x - widthSpace, y + heightSpace);
            x += widthSpace;
        }
    }

    this.drawPerson = function (person, x, y) {

        function drawText() {
            return new Kinetic.Text({
                x: x,
                y: y,
                width: nodeWidth,
                padding: textPadding,
                text: person.name,
                fontSize: fontSize,
                fill: textColor,
                align: 'center'
            });
        }

        function drawRect() {
            var radius = 7;

            var strokeColor = 'blue';

            if (person.isFemale) {
                radius = 15;
                strokeColor = 'red';
            }

            person.x = x;
            person.y = y;

            return new Kinetic.Rect({
                x: x,
                y: y,
                width: nodeWidth,
                stroke: strokeColor,
                strokeWidth: 1,
                height: nodeHeight,
                cornerRadius: radius
            });
        }

        function connectToParent(parent, layer) {
            layer.add(new Kinetic.Line({
                points: [x + nodeWidth / 2, y,
                        parent.x + nodeWidth / 2, parent.y + nodeHeight],
                stroke: strokeColor,
                strokeWidth: 1,
                tension: 1
            }));
        }

        function connectToSpouse(spouse, layer) {
            layer.add(new Kinetic.Line({
                points: [x, y + nodeHeight / 2,
                        spouse.x + nodeWidth, spouse.y + nodeHeight / 2],
                stroke: strokeColor,
                strokeWidth: 3,
                tension: 1
            }));
        }

        if (person.hasParents()) {
            if (person.mother) {
                connectToParent((person.mother), layer);
            }
            if (person.father) {
                connectToParent((person.father), layer);
            }
        }

        if (person.hasOffspring()) {
            connectToSpouse((person.spouse), layer);
        }

        layer.add(drawText());
        layer.add(drawRect());
    }
}