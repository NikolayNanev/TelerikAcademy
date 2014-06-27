Handlebars.registerHelper('dynamic_select_option', function () {
    return new Handlebars.SafeString(
      "<option value=" + this.value + ">" + this.text + "</option>"
    );
});

var templateHTML = $('#select-template').html(),
    selectTemplate = new Handlebars.compile(templateHTML),
    context = { selectOption: items }
selectHTML = selectTemplate({ selectOption: items });
$('#select-container').html(selectHTML);