console.log('---Help.js has loaded---');

$(function () {
     console.log("---JQ DOM ready---");
     addevents();
});

function addevents() {
     timer();
     getLocation();
}

function getLocation() {
     if (navigator.geolocation) {
          navigator.geolocation.getCurrentPosition(showPosition);
     }else {
          console.log("Geolocation is not supproted by htis browser");
     }
}

function showPosition(position) {
     console.log("Latitude: " + position.coords.latitude +
     "<br>Longitude: " + position.coords.longitude);
}

var idleTime = 0;
$(document).ready(function () {
     var idleInterval = setInterval(timer, 60000);

     $(this).mousemove(function (e) {
          idleTime = 0;
     });
     $(this).keypress(function (e) {
          idleTime = 0;
     });
});

function timer() {
     idleTime = idleTime + 1;
     if (idleTime > 5) {
          window.location.reload();
          localStorage.clear();
     }
}