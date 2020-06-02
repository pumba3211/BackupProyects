$(document).ready(function () {
    if ($('html').hasClass('desktop')) {
        new WOW().init();
    }
});


jQuery(function(){
    jQuery('#camera_wrap').camera({
        height: '34.58333333333333%',
        thumbnails: false,
        pagination: true,
        fx: 'simpleFade',
        loader: 'none',
        hover: false,
        navigation: false,
        playPause: false,
        minHeight: "139px",
    });
});
$(document).ready(function() {
    $(".owl-carousel").owlCarousel({
        navigation: true,
        pagination: false,
        items : 3,
        itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,3],
        itemsTablet: [750,1],
        itemsMobile : [479,1],
        navigationText: false
    });
});

$(document).ready(function() {
    if ($('html').hasClass('desktop')) {
        $.stellar({
            horizontalScrolling: false,
            verticalOffset: 20,
            resposive: true,
            hideDistantElements: true,
        });
        $('.page-scroll').removeClass("active");
    }
});