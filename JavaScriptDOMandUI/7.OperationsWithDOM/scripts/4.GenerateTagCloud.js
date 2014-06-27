function generateTagCloud(arrayWithTags, minFontSize, maxFontSize) {
    var wordAppearances = countWords(),
        maxAppearance = mostOccurrencesOfWord(wordAppearances),
        minAppearance = leastOccurrencesOfWord(wordAppearances);

    var tagCloud = document.createElement('div');
    tagCloud.style.width = '300px';

    var step = (maxFontSize - minFontSize) / (maxAppearance - minAppearance);
    var dFrag = document.createDocumentFragment();

    for (var key in wordAppearances) {
        var nextTag = document.createElement('a');
        nextTag.innerHTML = key + ' ';
        nextTag.href = 'https://www.google.bg/#q=' + key;
        nextTag.style.fontSize = minFontSize + (wordAppearances[key] - 1) * step + 'px';

        dFrag.appendChild(nextTag);
    }

    tagCloud.appendChild(dFrag);

    document.body.appendChild(tagCloud);

    function countWords() {
        var dictionary = {};

        for (var i = 0, len = arrayWithTags.length; i < len; i++) {
            var tagName = arrayWithTags[i].toLowerCase();

            if (dictionary[tagName] === undefined) {
                dictionary[tagName] = 0;
            }
            else {
                continue;
            }

            for (var j = 0, leng = arrayWithTags.length; j < leng; j++) {
                if (arrayWithTags[j].toLowerCase() === tagName) {
                    dictionary[tagName]++;
                }
            }
        }

        return dictionary;
    }

    function mostOccurrencesOfWord(obj) {
        var maxCount = Number.MIN_VALUE;

        for (var key in obj) {
            if (obj[key] > maxCount) {
                maxCount = obj[key];
            }
        }

        return maxCount;
    }

    function leastOccurrencesOfWord(obj) {
        var minCount = Number.MAX_VALUE;

        for (var key in obj) {
            if (obj[key] < minCount) {
                minCount = obj[key];
            }
        }

        return minCount;
    }
}

generateTagCloud(tags, 17, 42);