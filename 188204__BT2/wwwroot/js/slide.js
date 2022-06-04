$(document).ready(function () {
    var index = 1;
    $('.gallery img').each(function (i, value) {
        $(this).click(function () {
            index = i + 1;
            $(".count-current").text(i + 1)
            $(`.gallery img:first-child`).removeClass("addboder")
            $(".main-img").css({
                "transform": `translateX(-${(index - 1) * 100}%)`,
                "transition": "0.3s",
            })
            $(`.gallery img:not(:nth-child(${index}))`).removeClass("addboder")
            $(`.gallery img:nth-child(${index})`).addClass("addboder")

        })
    });
    $(".count-current").text(index)
    $(`.gallery img:nth-child(${index})`).addClass("addboder")
    $(".next-btn").click(function () {
        if (index < $(".main-imgs img").length) {
            index = index + 1;
            $(".count-current").text(index)
            $(`.gallery img:nth-child(${index})`).addClass("addboder")
            $(`.gallery img:nth-child(${index - 1})`).removeClass("addboder")

        } else {
            index = $(".main-imgs img").length;
            $(".count-current").text(index)
        }
        $(".main-img").css({
            "transform": `translateX(-${(index - 1) * 100}%)`,
            "transition": "0.3s",
        })

    })
    $(".prev-btn").click(function () {
        if (index < 2) {
            index = 1;
            $(".count-current").text(index)
        } else {
            index = index - 1;
            $(".count-current").text(index)
            $(`.gallery img:nth-child(${index})`).addClass("addboder")
            $(`.gallery img:nth-child(${index + 1})`).removeClass("addboder")
        }
        $(".main-img").css({
            "transform": `translateX(-${(index - 1) * 100}%)`,
            "transition": "0.3s",
        })
        $(`.gallery img:not(:nth-child(${index}))`).removeClass("addboder")
    })

})