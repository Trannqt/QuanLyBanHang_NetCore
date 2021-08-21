function LoadCart(data) {
    var htmlString = "";
    var totalQuantity = 0;
    var totalAmount = 0;
    if (data.length != 0) {
        for (i in data) {
            totalQuantity += data[i].soLuong;
            totalAmount += data[i].soLuong * data[i].giaBan;
            //htmlString += '<li class="item-in-cart"><a href="SingleProduct/Index/' + data[i].maThucDon + '"><img src="/uploads/product/' + data[i].hinhAnh + '" alt="" width="75" height="75">';
            //htmlString += '<div class="item-info"><h5>' + data[i].tenThucDon + '</h5>';
            //htmlString += '<p class="item-quantity">Số lượng : ' + data[i].soLuong + '</p>';
            //htmlString += '<p class="item-price">$' + (data[i].giaBan * data[i].soLuong).toFixed(2) + '</p></div></a></li>';

            htmlString += '<li>';
            htmlString += '<div class="cart-item">';
            htmlString += '<div class="image"> <img src="user/images/products/' + data[i].hinhAnh + '" alt=\"altimage\"></div>';
            htmlString += '<div class="item-description">'
            htmlString += '<p class="name">' + data[i].tenThucDon + '</p >';
            htmlString += '<p> Size: <span class="light-red">One size</span> <br>Quantity: <span class="light-red">' + data[i].soLuong + '</span></p>';
            htmlString += '</div ><div class="right">';
            htmlString += '<p class="price" >' + data[i].giaBan+ ' (VNĐ) </p>';
            htmlString += '</div></div></li>';
            //htmlString += '<li> <span class="total">Total <strong class="total-price">0đ</strong></span> <button class="checkout" onClick="location.href="checkout.html"">CheckOut</button></li >';
        }
        htmlString += '<li> <span class="total">Total <strong class="total-price">0đ</strong></span><a href="checkout"><button class="checkout" > CheckOut</button ></a></li > ';
    }
    else {
        htmlString += '<li class="none-item"><p>Chưa có sản phẩm trong giỏ</p></li>';

    }
    $("#cart_hidden li.none-item").remove();
    $("#cart_hidden li.item-in-cart").remove();
    $("#cart_hidden li.item-total").before(htmlString);

    $(".option-cart-item").html(htmlString);
    $(".cart-icon .amount-cart").html(totalQuantity);
    $(".total-price").html(totalAmount.toFixed(2)+ "(VNĐ)");
}

function LoadHiddenCart() {
    $.ajax({
        type: "GET",
        url: '/Cart/LoadCartHidden',
        dataType: 'json',
        success: function (response) {
            LoadCart(response);
        },
        error: function (error) {
        }
    });
}
$(document).ready(function () {

    LoadHiddenCart();

    function ResetButton(that) {
        $(that).html('<i class="fas fa-check"></i>');
    }

    $(document).on('click', '.order-button button', function (event) {
        event.preventDefault();
        console.log("da click");
        var product_id = $(this).attr("data-id");
        var $this = $(this);
        //$(this).html('<i class="fas fa-check"></i>');
        //setTimeout(function () {
        //    console.log($this.text());
        //    $this.html('Mua hàng');
        //}, 1000);
        $.ajax({
            type: "GET",
            url: '/Cart/AddToCart?id=' + product_id,
            dataType: 'json',
            success: function (response) {
                LoadCart(response);
            },
            error: function (error) {
            }
        });
    });

    $(document).on('click', '.button-add-to-cart a', function (event) {
        event.preventDefault();
        console.log("da click");
        var product_id = $(this).attr("data-id");
        var $this = $(this);
        $(this).html('<i class="fas fa-check"></i>');
        setTimeout(function () {
            $this.html('THÊM VÀO GIỎ');
        }, 1000);
        $.ajax({
            type: "GET",
            url: '/Cart/AddToCart?id=' + product_id,
            dataType: 'json',
            success: function (response) {
                LoadCart(response);
            },
            error: function (error) {
            }
        });
    });
});