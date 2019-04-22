function eliminarMaestro() {
    var titulo = $('#txtTitulo').val();
    var nombre = $('#txtNombre').val();
    var id = $('#hdnid').val();
    var maestro = {};
    maestro.Id = id;
    maestro.Titulo = titulo;
    maestro.Nombre = nombre;
    $.ajax({
        type: "DELETE",
        data: JSON.stringify(maestro),
        url: "/api/maestro/maestros",
        processData: false,  // tell jQuery not to process the data
        contentType: "application/json; charset=utf-8",  // tell jQuery not to set contentType
    })
        .done(function (response) {
            //buildAlert(response.status, response.msg);
            if (response !== null) {
                setTimeout(function () {
                    location.href = response;
                }, 800);
            }
        })
        .fail(function (jqXHR, textStatus) {
            //alertMsg = "Un error courrió al procesar tu petición";
            //buildAlert("error", alertMsg);
        });//END Ajax call
}