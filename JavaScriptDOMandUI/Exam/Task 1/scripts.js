function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector),
                imageView = document.createElement('div'),
                imageViewTitle = document.createElement('h2'),
		        imageMenu = document.createElement('div'),
                viewImage = document.createElement('img'),
                searchTool = document.createElement('div'),
                searchToolTitle = document.createElement('h4'),
                searcheToolInput = document.createElement('input'),
		        imageContainer = document.createElement('div'),
                imageTitle = document.createElement('h5'),
                image = document.createElement('img');

    //Conatainer
    container.className = 'conatainer';
    container.style.width = 600 + 'px';
    container.style.height = 400 + 'px';
    container.style.margin = 0;
    container.style.padding = 0;

    //View
    //imageView
    imageView.className = 'image-view';
    imageView.style.display = 'inline-block';
    imageView.style.width = 360 + 'px';
    imageView.style.height = 360 + 'px';
    imageView.style.margin = '20px'

    //View Title
    //imageViewTitle.style.border = '1px solid black';
    imageViewTitle.className = 'image-view-title';
    imageViewTitle.style.textAlign = 'center';
    imageViewTitle.style.marginTop = '30px';
    //imageViewTitle.style.padding = 5 + 'px';
    imageViewTitle.innerText = items[0].title;

    //viewImage 
    viewImage.className = 'view-image';
    viewImage.style.display = 'block';
    viewImage.setAttribute("src", items[0].url);
    viewImage.setAttribute("height", "260");
    viewImage.setAttribute("width", "340");
    viewImage.style.marginLeft = 'auto';
    viewImage.style.marginRight = 'auto';
    viewImage.style.borderRadius = '15px'

    imageView.appendChild(imageViewTitle);
    imageView.appendChild(viewImage);

    //Colection
    imageMenu.style.display = 'inline-block';
    imageMenu.style.cssFloat = 'right';
    imageMenu.style.width = 160 + 'px';
    imageMenu.style.height = 360 + 'px';
    imageMenu.style.margin = '15px'
    imageMenu.style.overflow = 'auto';

    //Search tool
    searchTool.className = 'search-tool';
    searchTool.style.width = 130 + 'px';
    searchTool.style.height = 40 + 'px';
    searchTool.style.margin = '2px';

    searchToolTitle.className = 'search-tool-title';
    searchToolTitle.innerText = 'Search';
    searchToolTitle.style.margin = '1px';
    searchToolTitle.style.textAlign = 'center';

    searcheToolInput.className = 'search-tool-input';
    searcheToolInput.type = 'text';
    searcheToolInput.style.width = 125 + 'px';
    searcheToolInput.style.height = 15 + 'px';

    searchTool.appendChild(searchToolTitle);
    searchTool.appendChild(searcheToolInput);

    imageContainer.className = 'image-container';
    imageContainer.style.display = 'lnline-block';
    imageContainer.style.width = 130 + 'px';
    imageContainer.style.height = 100 + 'px';
    imageContainer.style.margin = '2px';

    imageTitle.className = 'image-title';
    imageTitle.style.margin = '1px';
    imageTitle.style.textAlign = 'center';

    image.className = 'image';
    image.style.display = 'block';
    image.setAttribute("height", "80");
    image.setAttribute("width", "100");
    image.style.marginLeft = 'auto';
    image.style.marginRight = 'auto';
    image.style.borderRadius = '10px'


    imageMenu.appendChild(searchTool);

    imageContainer.appendChild(imageTitle);
    imageContainer.appendChild(image);

    container.appendChild(imageView);
    container.appendChild(imageMenu);

    var frag = document.createDocumentFragment();

    createImageList(animals);


    function onClick(event) {
        var clickedImage = this,
            urlClickedImage = clickedImage.getAttribute("src"),
            titleClickedImage = clickedImage.getAttribute("data-info");

        var viewImg = container.querySelector('.view-image');
        viewImg.setAttribute("src", urlClickedImage);

        var viewTitle = container.querySelector('.image-view-title');
        viewTitle.textContent = titleClickedImage;

    }

    function onMouseover(event) {
        var clickedImage = this,
            imageContainer = clickedImage.parentNode;

        imageContainer.style.background = 'lightgray';
    }

    function onMouseout(event) {
        var clickedImage = this,
            imageContainer = clickedImage.parentNode;

        imageContainer.style.background = '';
    }

    //Filter images
    searcheToolInput.onkeyup = function () {
        var value = this.value.toLowerCase();

        var animals = imageMenu.querySelectorAll('.image-container');

        for	(var i = 0; i < animals.length; i++ ) {
			var animalName = animals[i].firstChild.innerHTML.toLowerCase();
			
			if (animalName.indexOf(value) > -1) {
				animals[i].style.display = 'inline-block';
			}
			else {
				animals[i].style.display = 'none';
			}
		}
    }

    function createImageList(images) {

        for (var i = 0, len = images.length; i < len; i++) {
            var nextImage = imageContainer.cloneNode(true);

            nextImage.firstElementChild.innerText = items[i].title;
            nextImage.lastElementChild.setAttribute("src", images[i].url);
            nextImage.lastElementChild.setAttribute("data-info", images[i].title);

            nextImage.lastElementChild.addEventListener('click', onClick, false);
            nextImage.lastElementChild.addEventListener('mouseover', onMouseover, false);
            nextImage.lastElementChild.addEventListener('mouseout', onMouseout, false);

            frag.appendChild(nextImage);
        }

        imageMenu.appendChild(frag);
    }
}