
$(window).on('load resize', function () {

    //Add/remove class based on browser size when load/resize
    var w = $(window).width();

    if (w >= 1200) {
        // if larger 
        $('#docs-sidebar').addClass('sidebar-visible').removeClass('sidebar-hidden');
    } else {
        // if smaller
        $('#docs-sidebar').addClass('sidebar-hidden').removeClass('sidebar-visible');
    }
});


$(document).ready(function () {

    /* ====== Toggle Sidebar ======= */

    $('#docs-sidebar-toggler').on('click', function () {

        if ($('#docs-sidebar').hasClass('sidebar-visible')) {

            $("#docs-sidebar").removeClass('sidebar-visible').addClass('sidebar-hidden');


        } else {

            $("#docs-sidebar").removeClass('sidebar-hidden').addClass('sidebar-visible');

        }

    });


    /* ====== Activate scrollspy menu ===== */
    $('body').scrollspy({ target: '#docs-nav', offset: 100 });



    /* ===== Smooth scrolling ====== */

    //console.log(433, $('#docs-sidebar a.scrollto'));

    //$('#docs-sidebar a.scrollto').on('click', function (e) {
    //    //store hash
    //    var target = this.hash;
    //    e.preventDefault();
    //    console.log(44, target);
    //    $('body').scrollTo(target, 800, { offset: -69, 'axis': 'y' });

    //    //Collapse sidebar after clicking
    //    if ($('#docs-sidebar').hasClass('sidebar-visible') && $(window).width() < 1200) {
    //        $('#docs-sidebar').removeClass('sidebar-visible').addClass('slidebar-hidden');
    //    }

    //});

    /* wmooth scrolling on page load if URL has a hash */
    if (window.location.hash) {
        var urlhash = window.location.hash;
        console.log(33, urlhash);
        $('body').scrollTo(urlhash, 800, { offset: -69, 'axis': 'y' });
    }


    /* Bootstrap lightbox */
    /* Ref: http://ashleydw.github.io/lightbox/ */

    $(document).delegate('*[data-toggle="lightbox"]', 'click', function (e) {
        e.preventDefault();
        $(this).ekkoLightbox();
    });




});


$(document).on('click', '#docs-sidebar a.scrollto', function (e) {
    //store hash
    var target = this.hash;
    e.preventDefault();
    console.log(44, target);
    $('body').scrollTo(target, 800, { offset: -69, 'axis': 'y' });

    //Collapse sidebar after clicking
    if ($('#docs-sidebar').hasClass('sidebar-visible') && $(window).width() < 1200) {
        $('#docs-sidebar').removeClass('sidebar-visible').addClass('slidebar-hidden');
    }

});