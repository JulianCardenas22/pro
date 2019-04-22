function modificarSalon() {
    var nombre = $('#txtsalon').val();
    var id = $('#hdnid').val();
    var salon = {};
    salon.Id = id;
    salon.Nombre = nombre;
    $.ajax({
        type: "PUT",
        data: JSON.stringify(salon),
        url: "/api/salon/salones",
        processData: false,  // tell jQuery not to process the data
        contentType: "application/json; charset=utf-8"  // tell jQuery not to set contentType
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