let skupnaVrednost = 0;
let kvadratura = 0;
let povprecnaVrednostKvadratnegaMetra = 0;

//selectors


fetch("data.json")
  .then((response) => response.json())
    .then((json) => {
    const container = document.querySelector(".container");
    json.Items.forEach((item) => {
      if (item.Kraj === "KOVOR") {
        skupnaVrednost += item.Cena;
        if (item.Velikost !== "") {
          const velikost = item.Velikost.split(" ");
          kvadratura += +velikost[0];
        }
      }
    });

    povprecnaVrednostKvadratnegaMetra = skupnaVrednost / kvadratura;

      console.log(povprecnaVrednostKvadratnegaMetra, skupnaVrednost, kvadratura);
    container.innerHTML =
      "<div> Skupna vrednost je: " +
      skupnaVrednost +
      "</div>" +
      "<div> Kvadratura je: " +
      kvadratura +
      "</div>" +
      "<div> Povprečna vrednost kvadratnega metra je: " +
      povprecnaVrednostKvadratnegaMetra +
      "</div>";
  });
