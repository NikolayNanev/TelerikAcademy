var $afterListItem = createListItem('After');
var $beforeListItem = createListItem('Before');

//Add element before list item-1
$('#item-1').addBeforeElement($beforeListItem);

//Add element after list item-4
$('#item-4').addAfterElement($afterListItem);

function createListItem(text) {
    return $('<li>').addClass('list-item').html(text);
}