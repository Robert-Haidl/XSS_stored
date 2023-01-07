$(document).ready(function () {
    let searchParams = new URLSearchParams(window.location.search)
    let server = "https://localhost:5001/api/blogs";
    if(searchParams.has("id")) server+="/"+searchParams.get("id")
    console.log(searchParams.get("id"));

    $.ajax({
        type: "GET",
        url: server,
        dataType: "JSON",
        success: function (response) {
            response.forEach(element => {
                $("#author").html(element.author);
                $("#title").html(element.title);
                $("#description").html(element.description);
            });
            console.log(response);
            
        },
        error: function(e){
            console.log(e);
        }
    });
});