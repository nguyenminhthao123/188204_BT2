function LoadProduct() {
    $.ajax({
        type: "GET",
        url: "/Category/FitterCaterogy",
        success: function (res) {
            $(".productList").html(res)
        }
    })
}
function ClickTitleMannu() {
    $(".filter__item__titile").click(function (values) {
        var el = $(values)[0].currentTarget
        $(".filter__show").css({ "display": "none" })
        if ($(this).hasClass("activeCategory")) {
            $(this).removeClass("activeCategory")
            $(this).next().css({ "display": "none" })
        } else {
            $(this).addClass("activeCategory")
            $(this).next().css({ "display": "block" })
            $(".filter__item__titile").each(function (i, value) {
                if (el != value) {
                    $(value).removeClass("activeCategory")
                }
            })
        }
    })
}
function ToggleBtn() {
    $(".btn-filter").click(function () {
        console.log("lll")
        if ($(this).hasClass("activeFilter")) {
            $(this).removeClass("activeFilter")
        } else {
            $(this).addClass("activeFilter")
            $(".filter-button").css({ "display": "block" })
        }
    })
  
}
// GetTotalProduct
function GetTotalProduct() {
    $(".btn-filter").click(function () {
        var listTypeCN = [];
        var listType = [];
        var listBrand = [];
        $(".btn-filter").each(function () {
            if ($(this).hasClass("activeFilter")) {
                if ($(this).data("id") != undefined && !listTypeCN.includes($(this).data("id"))) {
                    listTypeCN.push($(this).data("id"))
                }
                if ($(this).data("type") != undefined && !listType.includes($(this).data("type"))) {
                    listType.push($(this).data("type"))
                }
                if ($(this).data("brand") != undefined && !listBrand.includes($(this).data("brand"))) {
                    listBrand.push($(this).data("brand"))
                }
            } else {
                if (listTypeCN.includes($(this).data("id"))) {
                    listTypeCN.pop($(this).data("id"))
                }
                if (listType.includes($(this).data("type"))) {
                    listType.pop($(this).data("type"))
                }
                if (listBrand.includes($(this).data("brand"))) {
                    listBrand.pop($(this).data('brand'))
                }
            }
        })
        
        $.ajax({
            type: "POST",
            url: "/Category/GetCountProduct",
            data: { TypeCN: listTypeCN, TypeL: listType, BrandList: listBrand },
            success: function (res) {
                $(".btn-filter-result span").text(`(${res} kết quả)`)
            }
        })
    })
    
}
// result filter 

function ResultFilter() {
    var listCN = [];
    var listType = [];
    var listBrand = [];
    $(".btn-filter-result").click(function () {

        $(".btn-filter").each(async function () {
            if ($(this).hasClass("activeFilter")) {
                if ($(this).data("id") != undefined && !listCN.includes($(this).data("id"))) {
                    listCN.push($(this).data("id"))
                }
                if ($(this).data("type") != undefined && !listType.includes($(this).data("type"))) {
                    listType.push($(this).data("type"))
                }
                if ($(this).data("brand") != undefined && !listBrand.includes($(this).data("brand"))) {
                    listBrand.push($(this).data("brand"))
                }
            } else {
                for (var i = 0; i < listCN.length; i++) {
                    if (listCN[i] == $(this).data("id")) {
                        listCN.splice(i, 1);
                    }
                }
                for (var i = 0; i < listType.length; i++) {
                    if (listType[i] == $(this).data("type")) {
                        listType.splice(i, 1);
                    }
                }
                for (var i = 0; i < listBrand.length; i++) {
                    if (listBrand[i] == $(this).data("brand")) {
                        listBrand.splice(i, 1);
                    }
                }
            }

        })
        $.ajax({
            type: "POST",
            url: "/Category/FitterCaterogy",
            data: { oder: "", TypeCN: listCN, TypeL: listType, BrandList: listBrand },
            success: function (res) {
                $(".productList").html(res)
            }
        })

    })
}
$(document).ready(function () {


    //Load product dau trang
    LoadProduct();
    //
    $(".click-sort").click(function () {
        $(".sort-select-main").css({ "display": "block" })
    })
    // click title menu
    ClickTitleMannu();
    // ToggleBTn
    ToggleBtn();
    GetTotalProduct();
    // ResultFilter
    ResultFilter();

})