$(document).ready(function () {
    $(".delete-item-cart").click(function (e) {
        var confirmed = confirm("Bạn có muốn xóa sản phẩm này không?");
        if (!confirmed) {
            e.preventDefault();
        }
    });
});