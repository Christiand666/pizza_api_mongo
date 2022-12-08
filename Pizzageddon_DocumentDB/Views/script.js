function GetAll() {
    var xhttp = new XMLHttpRequest();
    var data = {};
    if (document.getElementById("pizzas")) document.getElementById("pizzas").innerHTML = "";
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            data = JSON.parse(this.responseText);

            var ul;
            if (!document.getElementById("pizzas")) {
                ul = document.createElement("ul");
                ul.id = "pizzas";
            } else
                ul = document.getElementById("pizzas");


            for (var i = 0; i < data.length; ++i) {
                var li = document.createElement('li');
                li.innerHTML =
                    "<b>Pizza Details:</b> <br />" +
                    data[i].id + "<br />" +
                    data[i].pizzaDetail.name + "<br />" +
                    data[i].crusttype.price + " kr." + "<br />" +

                    "<b>Crustype:</b> <br />" +
                    data[i].crusttype.name + "<br />" +
                    data[i].crusttype.price + " kr." + "<br />" +

                    "<b>Size:</b> <br />" +
                    data[i].size.name + "<br />" +
                    data[i].size.price + " kr." + "<br />";
                li.innerHTML +=
                    "<b>Toppings:</b> <br />";
                for (var j = 0; j < data[i].pizzaDetail.toppings.length; ++j) {
                    li.innerHTML +=
                        data[i].pizzaDetail.toppings[j].name + "<br />" +
                        "<b>Ekstra topping pris: </b>" + data[i].pizzaDetail.toppings[j].price + " kr." + "<br />";
                }
                li.innerHTML += "<br />";
                ul.appendChild(li);
            }

            document.body.appendChild(ul);
        }
    };
    xhttp.open("GET", "https://localhost:7060/pizza", true);
    xhttp.setRequestHeader("Content-type", "application/json");
    xhttp.send("");
}

function Delete() {
    var id = document.getElementById("deleteId").value;

    return fetch('https://localhost:7060/pizza/' + id, {
        method: 'DELETE',
        body: ''
    }).then(response => GetAll())
}

