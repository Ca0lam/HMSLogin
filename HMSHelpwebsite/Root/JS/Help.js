console.log('---Help.js has loaded---');

$(function () {
     console.log("---JQ DOM ready---");
     addevents();
});

function addevents() {
     timer();
}

function getLocation() {
     if (navigator.geolocation) {
          navigator.geolocation.getCurrentPosition(showPosition);
     }else {
          console.log("Geolocation is not supproted by this browser");
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

function setClock() {
     var now = new Date();
     console.log(now);                  
     var sec = now.getSeconds();       
     console.log('sec:', sec);         
     var min = now.getMinutes();       
     console.log('min:', min);
     var hrs = now.getHours() + min / 60;
     console.log('hrs:', hrs);
 
     for (var i = 0; i < 12; i++) {
        var newEl = document.createElementNS('http://www.w3.org/2000/svg', 'line');
         newEl.setAttribute('x1', '100');       
         newEl.setAttribute('y1', '30');
         newEl.setAttribute('x2', '100');              
         newEl.setAttribute('y2', '40');
         newEl.setAttribute('style', 'stroke: white; stroke-width: 2px;');
         newEl.setAttribute('transform', 'rotate(' + 30 * i + ' 100 100)');
         document.getElementById('myClock').appendChild(newEl);
     }
 
     var secAni = document.getElementById('secHandAni');
     var secAttrFrom = (360 / 60 * sec) + ' 100 100';
     secAni.setAttribute('from', secAttrFrom);
     console.log('secAttrFrom:', secAttrFrom);               
     var secAttrTo = ((360 / 60 * sec) + 360) + ' 100 100';
     secAni.setAttribute('to', secAttrTo);
     console.log('secAttrTo:', secAttrTo);
 
     var minAni = document.getElementById('minHandAni');
     var minAttrFrom = (360 / 60 * min) + ' 100 100';
     minAni.setAttribute('from', minAttrFrom);                      
     console.log('minAttrFrom:', minAttrFrom);
     var minAttrTo = ((360 / 60 * min) + 360) + ' 100 100';
     minAni.setAttribute('to', minAttrTo);
     console.log('minAttrTo:', minAttrTo);
 
     var hrsAni = document.getElementById('hrsHandAni');
     var hrsAttrFrom = (360 / 12 * hrs) + ' 100 100';
     hrsAni.setAttribute('from', hrsAttrFrom);                       
     console.log('hrsAttrFrom:', hrsAttrFrom);
     var hrsAttrTo = ((360 / 12 * hrs) + 360) + ' 100 100';
     hrsAni.setAttribute('to', hrsAttrTo);
     console.log('hrsAttrTo:', hrsAttrTo);
 }