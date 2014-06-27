var templateHTML = $('#table-template').html(),
    lecturesTemplate = new Handlebars.compile(templateHTML),
    context = { lecture: lectures }

$('#table-container').html(lecturesTemplate(context));