function agregarMaestro() {
    var titulo = $('#txtTitulo').val();
    var nombre = $('#txtNombre').val();
    var apellido = $('#txtApellido').val();
    var maestro = {};
    maestro.Titulo = titulo;
    maestro.Nombre = nombre;
    maestro.Apellido = apellido;
    $.ajax({
        type: "POST",
        data: JSON.stringify(maestro),
        url: "/api/maestro/maestros",
        processData: false,  // tell jQuery not to process the data
        contentType: "application/json; charset=utf-8"  // tell jQuery not to set contentType
    })

        .done(function (response) {
            //buildAlert(response.status, response.msg);
            if (response!== null) {
                setTimeout(function () {
                    location.href = response;
                }, 800);
            }
        })
        .fail(function (jqXHR, textStatus) {
            alertMsg = "Un error courrió al procesar tu petición";
            //buildAlert("error", alertMsg);
        });//END Ajax call
}