   var coin = ["Heads", "Tails"];

function coinResults(){

    var rand =Math.floor(Math.random() * coin.length);
    document.getElementById('resultDisplay').innerHTML = coin[rand];
}

// function tails(){

//     var rand2 =Math.floor(Math.random() * coin.length);
//     document.getElementById('resultDisplay').innerHTML = coin[rand2];  
// }