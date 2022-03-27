
function doReply2(btn, e) {

    $("#buttonyorum").click(function () {
        var YorumID = $(this).attr("yorumid");

     if (e === "new_reply") {

         $(this).parent().append($('<p>selamunaleyküm</p>'));

        // var KullanıcıADI = KullaniciADI;
        // var mail = mail;
        // var cevap = Cevap;

        //$.ajax({
        //    method: "POST",
        //    url: "/Blog/Reply",
        //    data: { "Cevap": cevap, "YorumID": YorumID, "mail": mail, "KullanıcıADI": KullanıcıADI, }
        //}).done(function (data) {

        //    if (data.result) {
        //        // yorumlar partial tekrar yüklenir..
        //        location.reload();
        //    } else {
        //        alert("Yorum eklenemedi.");
        //    }

        //}).fail(function () {
        //    alert("Sunucu ile bağlantı kurulamadı.");
        //});
        }
    })
}