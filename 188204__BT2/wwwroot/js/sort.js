//xu ly phan sort
$(document).ready(function () {
    $(".sort-select-main p").click(function () {
        var listTypeCN = [];
        var listType = [];
        var listBrand = [];
        $(".btn-filter").each( function () {
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
                for (var i = 0; i < listTypeCN.length; i++) {
                    if (listTypeCN[i] == $(this).data("id")) {
                        listTypeCN.splice(i, 1);
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
      
     
        var precent = $(this).attr("data-id")
        $.ajax({
            type: "POST",
            url: "/Category/SortCategory",
            data: { Order: precent, TypeCN: listTypeCN, TypeL: listType, BrandList: listBrand },
            success: function (res) {
                $(".productList").html(res)

            }

        })
        var textContent = $(this).text()
        $(".sort-select-main p").removeClass("activeSort")
        $(this).addClass("activeSort")
        $(".sort-show").text(textContent)
        $(".sort-select-main").css({ "display": "none" })
    })
})
