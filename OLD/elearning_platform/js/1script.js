$(document).ready(function () {
    //mostra hp, nascondi tutto il resto
    showPage('homepage');

    $('#logo').click(function () {
        showPage('homepage');
    }).css({ cursor: "pointer" });

    // elimina bordo dall'ultima voce di menù
    $("#menu ul li:last-child").css({ border: "none" })
    // like disattivato
    //	console.log("input: "+$(".likepanel input[disabled]").size());
    $(".likepanel input[disabled]").css({ cursor: "default" })

    // apri chiudi menu
    $('#menu_btn').click(function () {
        if ($('#menu').is(':visible')) {
            $('#menu').hide();
        } else {
            $('#menu').show();
        }
        // chevron over menu item
        $("#menu ul li a")
          .mouseenter(function () {
              $(this).parent().addClass('on');
          })
          .mouseleave(function () {
              $(this).parent().removeClass('on');
          });
    });

    // paginazione contenuti
    var npag = $(".pagination div.pag").size();
    //console.log("pagine: "+ npag);

    $(".pagination div.pag").hide();
    $(".pag_sx").hide();
    $(".pagination div.pag:first").show();
    var currPage = 0;


    $(".pagination .pag_sx").click(function () {
        if (currPage > 0) {
            currPage = currPage - 1;

            $(".pagination div.pag").hide();
            $(".pagination div.pag:eq( " + currPage + " )").fadeTo("fast", 1);

            if (currPage == 0) {
                $(".pagination .pag_sx").hide();
            } else {
                $(".pagination .pag_sx").show();
            }
            if (currPage == npag - 1) {
                $(".pagination .pag_dx").hide();
            } else {
                $(".pagination .pag_dx").show();
            }

        }

    });
    $(".pagination .pag_dx").click(function () {
        if (currPage < npag - 1) {
            currPage = currPage + 1;
            //console.log("corrente: "+ currPage);
            $(".pagination div.pag").hide();
            $(".pagination div.pag:eq( " + currPage + " )").fadeTo("fast", 1);

            if (currPage == 0) {
                $(".pagination .pag_sx").hide();
            } else {
                $(".pagination .pag_sx").show();
            }
            if (currPage == npag - 1) {
                $(".pagination .pag_dx").hide();
            } else {
                $(".pagination .pag_dx").show();
            }

        }

    });

    // paginazione contenuti
    var npag2 = $(".pagination2 div.pag").size();
    //console.log("pagine: "+ npag);

    $(".pagination2 div.pag").hide();
    $(".pagination2 .pag_sx").hide();
    $(".pagination2 div.pag:first").show();
    var currPage2 = 0;


    $(".pagination2 .pag_sx").click(function () {
        if (currPage2 > 0) {
            currPage2 = currPage2 - 1;

            $(".pagination2 div.pag").hide();
            $(".pagination2 div.pag:eq( " + currPage2 + " )").fadeTo("fast", 1);

            if (currPage2 == 0) {
                $(".pagination2 .pag_sx").hide();
            } else {
                $(".pagination2 .pag_sx").show();
            }
            if (currPage2 == npag2 - 1) {
                $(".pagination2 .pag_dx").hide();
            } else {
                $(".pagination2 .pag_dx").show();
            }
        }
    });

    $(".pagination2 .pag_dx").click(function () {
        if (currPage2 < npag2 - 1) {
            currPage2 = currPage2 + 1;
            //			console.log("corrente: "+ currPage);
            $(".pagination2 div.pag").hide();
            $(".pagination2 div.pag:eq( " + currPage2 + " )").fadeTo("fast", 1);

            if (currPage2 == 0) {
                $(".pagination2 .pag_sx").hide();
            } else {
                $(".pagination2 .pag_sx").show();
            }
            if (currPage2 == npag2 - 1) {
                $(".pagination2 .pag_dx").hide();
            } else {
                $(".pagination2 .pag_dx").show();
            }

        }

    });

    // paginazione contenuti
    var npag3 = $(".pagination3 div.pag").size();
    //console.log("pagine: "+ npag);

    $(".pagination3 div.pag").hide();
    $(".pagination3 .pag_sx").hide();
    $(".pagination3 div.pag:first").show();
    var currPage3 = 0;


    $(".pagination3 .pag_sx").click(function () {
        if (currPage3 > 0) {
            currPage3 = currPage3 - 1;

            $(".pagination3 div.pag").hide();
            $(".pagination3 div.pag:eq( " + currPage3 + " )").fadeTo("fast", 1);

            if (currPage3 == 0) {
                $(".pagination3 .pag_sx").hide();
            } else {
                $(".pagination3 .pag_sx").show();
            }
            if (currPage3 == npag3 - 1) {
                $(".pagination3 .pag_dx").hide();
            } else {
                $(".pagination3 .pag_dx").show();
            }
        }
    });

    $(".pagination3 .pag_dx").click(function () {
        if (currPage3 < npag3 - 1) {
            currPage3 = currPage3 + 1;
            //			console.log("corrente: "+ currPage);
            $(".pagination3 div.pag").hide();
            $(".pagination3 div.pag:eq( " + currPage3 + " )").fadeTo("fast", 1);

            if (currPage3 == 0) {
                $(".pagination3 .pag_sx").hide();
            } else {
                $(".pagination3 .pag_sx").show();
            }
            if (currPage3 == npag3 - 1) {
                $(".pagination3 .pag_dx").hide();
            } else {
                $(".pagination3 .pag_dx").show();
            }

        }

    });


    var poll_size = $('.poll_questions td').size();
    var poll_arr = ["blue", "orange", "green", "yellow", "gray", "cyan"];
    var poll_col = ["#5a9fda", "#f17a27", "#367a2f", "#ead667", "#83786f", "#73afb6"];

    for (i = 0; i < poll_size; i++) {
        $(".poll_questions td:eq( " + i + " )").css({ background: "#003c6a url(img/poll_arrow_" + poll_arr[i] + ".gif) no-repeat 0 0" });
    }

    $('.poll_questions td input').hide();
    $('#voteArticle').hide();

    $('.poll_questions td').click(function () {
        $(this > 'input').prop('checked', true);
    });
    $('.poll_questions input').change(function () {

        for (i = 0; i < poll_size; i++) {
            $(".poll_questions td:eq( " + i + " )").css({ background: "#003c6a url(img/poll_arrow_" + poll_arr[i] + ".gif) no-repeat 0 0" });
        }
        var pos_check = $(this).parent().parent().index();
        if ($(this).is(":checked")) {
            $('#voteArticle').show();

            $(this).parent().css({ background: poll_col[pos_check] + " url(img/poll_arrow_" + poll_arr[pos_check] + ".gif) no-repeat 0 0" });
            $(this).parent().animate(
                {
                    'background-position': '+=100%'
                }, 200, 'linear');

            var returnVal = $(this).attr("id")
            $(this).attr("checked", returnVal);
        } else {
            $('#voteArticle').hide();
        }
    });

    // slider
    $("#slider4").responsiveSlides({
        auto: false,
        pager: false,
        nav: true,
        speed: 500,
        namespace: "callbacks",
        before: function () {
            $('.events').append("<li>before event fired.</li>");
        },
        after: function () {
            $('.events').append("<li>after event fired.</li>");
        }
    });

 
 
 updateVote();

    $("#voteArticle").click(function () {
        setTimeout(function () {
            $('.poll_questions td span input').hide();
            $('.poll_questions td').css({ cursor: 'default' });
            updateVote();
        }, 800);
    });


   




});






// JavaScript Document
var arr = ["homepage", "expert", "appointments", "happening", "tour", "transformation", "poll"];
showPage = function (id) {
    jQuery.each(arr, function (i, val) {
        $("#" + val).hide();

        $("#" + id).show();
        $('#menu').hide();
    });

};


function radioMe(e) {
    if (!e) e = window.event;
    var sender = e.target || e.srcElement;

    if (sender.nodeName != 'INPUT') return;
    var checker = sender;
    var chkBox = document.getElementById('<%= pollQuestions.ClientID %>');
    var chks = pollQuestions.getElementsByTagName('INPUT');
    for (i = 0; i < chks.length; i++) {
        if (chks[i] != checker)
            chks[i].checked = false;
    }
}


function updateVote() {

    var siteCookies = readCookie('userSelection');



    var cookieVote = 0;

    if (siteCookies != null) {
        var regularExp =  /(vote=([0-9]))/g;
        var subStr = siteCookies.match(regularExp);
        if (subStr != null) {

            var voteCook = subStr[0];
            
            for (var i = 0, l = voteCook.length; i < l; i++) {
                //cookieVote = subStr[5] - 1;
                cookieVote = voteCook[5] - 1;

            }

            /*
            for (var i = 0, l = siteCookies.length; i < l; i++) {
                cookieVote = siteCookies[5] - 1;
            } */



            //console.log(poll_col[i]);
            //alert(cookieVote);

            var poll_size = $('.poll_questions td').size();
            var poll_arr = ["blue", "orange", "green", "yellow", "gray", "cyan"];
            var poll_col = ["#5a9fda", "#f17a27", "#367a2f", "#ead667", "#83786f", "#73afb6"];

            $('#voteArticle').hide();
            $('.poll_questions td').css({ cursor: 'default' });
            for (i = 0; i < poll_size; i++) {

                if (cookieVote == i) {
                    $(".poll_questions td:eq( " + i + " )").css({ background: poll_col[i] + " url(img/poll_arrow_" + poll_arr[i] + ".gif) no-repeat right 0" });

                } else {
                    $(".poll_questions td:eq( " + i + " )").css({ background: "#003c6a url(img/poll_arrow_" + poll_arr[i] + ".gif) no-repeat 0 0" });
                }
            }
        }
    }

}


function readCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
}

function eraseCookie(name) {
    createCookie(name, "", -1);
}




