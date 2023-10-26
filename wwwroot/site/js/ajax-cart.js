$(document).ready(function () {
    $("input.quantity").change(function () {
        var qty = $(this).val();
        var id = $(this).attr("id");
        //alert(qty + " " + id);
        $.ajax({
            type: 'POST', // Loại phương thức HTTP
            url: '/update-total-cart', // Đường dẫn đến router
            data: { id: id, qty: qty }, // Dữ liệu gửi lên router
            success: function (data) {
                $("div#header").empty().append(data);
                //alert(data);
                console.log(data);
            }
        });
        $.ajax({
            type: 'POST', // Loại phương thức HTTP
            url: '/update-item-cart', // Đường dẫn đến router
            data: { id: id, qty: qty }, // Dữ liệu gửi lên router
            success: function (data) {
                $("div#my-cart").empty().append(data);
                console.log(data);
            }
        });
    });
});