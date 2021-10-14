// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    console.log("document ready.");

    $(".edit-product-button").click(function () {
        console.log($(this).val());

        $.ajax({
            type: "json",
            data: { "id": $(this).val() },
            url: "/product/ShowOneProductJson",
            success: function (data) {
                $("#modal-input-id").val(data.id);
                $("#modal-input-name").val(data.name);
                $("#modal-input-price").val(data.price);
                $("#modal-input-description").val(data.description);
            }
        })
    });


    $(".save-button").click(function () {
        console.log("save button clicked");
        //get values from the input field and create a json object to submit to the controller
        let Product = {
            "Id": $("#modal-input-id").val(),
            "Name": $("#modal-input-name").val(),
            "Price": $("#modal-input-price").val(),
            "Description": $("#modal-input-description").val()
        };

        $.ajax({
            type: "post",
            data: Product,
            url: "/product/ProcessEdit",
            success: function (data) {
                //this is where partial update is useful
                $(".partial-div").html("");
            }
        })

    })
})