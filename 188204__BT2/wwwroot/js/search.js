$(document).ready(function () {
    $('#search-id').keyup(function () {
        var searchkey = $('#search-id').val();
        $(".search-product-tt").remove();
        $.ajax({
            type: "GET",
            url: "/Home/Search",
            data: { searchkeyWork: searchkey },
            success: function (res) {
                var product = JSON.parse(res);

                if (searchkey.length >= 2 && product.length > 0) {
                    console.log(product);
                    var html_body_search = `
                             <div class="search-product-tt">
                                <ul></ul>
                             </div>
                        `
                } $(".search-product").append(html_body_search)
                $.each(product, function (key, item) {
                    if (searchkey.length >= 2 && product) {
                        var html_search = `
                                    <li>
                                       <a>
                                        <div class="search-img">
                                            <img src="${item.Image}" />
                                        </div>
                                        <div class="search-txt">
                                            <h3>${item.Name}</h3>
                                            <div class="price">
                                                <strong class="price-current">${item.price_current}</strong>
                                                <span class="price-old">${item.price_old}</span>
                                                <span class="price-percent">${item.Discount}% </span>
                                            </div>
                                        </div>
                                    </a>
                                </li>
                        `
                        $(".search-product-tt ul").append(html_search);
                    }
                })
            }
        })
    })

    $('#search-id').focus(function () {
        $(".focus-search").addClass("them")
        $(".search-show").addClass("add-show")
        $(".header-search input").addClass("style-border")
        $("body").addClass("fix-body")
    });
    $('#search-id').focusout(function () {
        $(".focus-search").removeClass("them")
        $(".search-show").removeClass("add-show")
        $(".header-search input").removeClass("style-border")
        $("body").removeClass("fix-body")
    });
});