function createCalendar(selector, events) {
    var DAYS = 30;
    var daysOfWeek = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];

    var container = document.querySelector(selector);

    container.style.width = (140 * 7.5) + 'px';

    var box = document.createElement('div'),
        boxTitle = document.createElement('span'),
        boxContent = document.createElement('div');

    boxContent.innerHTML = '&nbsp;';

    box.style.display = 'inline-block';
    box.style.margin = '0';
    box.style.padding = '0';
    box.style.width = 140 + 'px';
    box.style.height = 140 + 'px'
    box.style.border = '1px solid black';

    boxTitle.style.display = 'block';
    boxTitle.style.background = 'gray'
    boxTitle.style.borderBottom = '1px solid black';

    boxContent.className = 'boxTitle';

    box.appendChild(boxTitle);
    box.appendChild(boxContent);

    

    var calendar = createCalendar(DAYS, daysOfWeek);
    addEvents(calendar, events);

    function createCalendar(DAYS, daysOfWeek) {
        var calendar = [];

        for (var i = 0; i < DAYS; i++) {

            var dayOfweek = daysOfWeek[i % 7]

            boxTitle.innerHTML = dayOfweek + ' ' + i + ' ' + ' June 2014';

            calendar.push(box.cloneNode(true));
        }

        return calendar;
    }

    function addEvents(celendar, events) {
        for (var i = 0; i < events.length; i++) {
            var event = events[i];
            celendar[event.date - 1].querySelector('.boxTitle').innerHTML = event.hour + ' ' + event.title;

            //console.log(celendar[event.date].lastElementChild());
        }
    }

    
    var selected = null;

    function onClick(ev) {
        if (selected) {
            selected.style.background = '';
        }
        if (selected && selected === this) {
            selected = null;
        }
        else {
            this.style.background = 'blue';
            selected = this;
        }
    }

    function onMouseover(ev) {
        if (selected !== this) {
            this.style.background = 'gold';
        }
    }

    function onMouseout(ev) {
        if (selected !== this) {
            this.style.background = '';
        }
    }

    
    var frag = document.createDocumentFragment();

    for (var i = 0; i < calendar.length; i++) {
        frag.appendChild(calendar[i]);

        calendar[i].addEventListener('click', onClick);
        calendar[i].addEventListener('mouseover', onMouseover);
        calendar[i].addEventListener('mouseout', onMouseout);
    }

    container.appendChild(frag);
}