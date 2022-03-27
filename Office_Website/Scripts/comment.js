
function doComment() {
    var Blogid = $('input#BlogID').val();
    var KullanıcıADI = $('#KullaniciADI').val();
    var mail = $('#mail').val();
    var yorum = $("#new_comment").val();

    $.ajax({
        method: "POST",
        url: "/Blog/Create",
        data: { "Yorum": yorum, "Blogid": Blogid, "mail": mail, "KullanıcıADI": KullanıcıADI, }
    }).done(function (data) {

        if (data.result) {
            // yorumlar partial tekrar yüklenir..
            location.reload();
        } else {
            alert("Yorum eklenemedi.");
        }

    }).fail(function () {
        alert("Girdiğiniz bilgiler eksik veya hatalıdır.");
    });

}

