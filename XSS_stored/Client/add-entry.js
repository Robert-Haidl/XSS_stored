$(document).ready(function () {
    var jsonData = {};
    $("#add-entry-form").submit(function(e){
        e.preventDefault();
        
        $("#add-entry-form").serializeArray().map(function (x) {
            jsonData[x.name] = x.value;
        });

        console.log(jsonData);

        $.ajax({
            type: "POST",
            headers: { 'Access-Control-Allow-Origin': '*', 'Access-Control-Allow-Methods': '*', 'Content-Type': 'application/json' },
            url: "https://localhost:5001/api/blogs",
            data: JSON.stringify(jsonData),
            dataType: "JSON",
            success: function (response) {
                console.log(response);
                location.href="show-entry.html?id="+response.id;
            },
            error: function (response){
                console.log(response);
            }
        });
        return false;
    });
});