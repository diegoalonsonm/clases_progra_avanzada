new DataTable('#tablaInventario')

$(document).ready(() => {
    $("#miAlerta").on("click", (e) => {
        Swal.fire({
            title: "Buen trabajo",
            text: "Haz apretado el boton",
            icon: "success"
        })
    }
}) 