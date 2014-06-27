var $container = $('#container'),
    $nextSlideBtn = $('#next-slide'),
    $previousSlideBtn = $('#previous-slide'),
    $toggleSlideShow = $('#slide-show');

var slideShow,
    isSlideShowOn = false;

$container.children('.slide').first().addClass('current');

$nextSlideBtn.on('click', function () {
    var $currentSlide = $container
        .find('.current')
        .removeClass('current');

    var $nextSlide = $currentSlide.next('.slide');

    if ($nextSlide.length === 0) {
        $container.children('.slide').first().addClass('current');
    }
    else {
        $nextSlide.addClass('current');
    }
});

$previousSlideBtn.on('click', function () {
    var $currentSlide = $container
        .find('.current')
        .removeClass('current');

    var $previousSlide = $currentSlide.prev('.slide');

    if ($previousSlide.length === 0) {
        $container.children('.slide').last().addClass('current');
    }
    else {
        $previousSlide.addClass('current');
    }
});

$toggleSlideShow.on('click', function () {
    isSlideShowOn = !isSlideShowOn;

    if (isSlideShowOn === true) {
        slideShow = setInterval(changeSlide, 3000);
    }
    else {
        clearInterval(slideShow);
    }

    function changeSlide() {
        $nextSlideBtn.click();
    }
});