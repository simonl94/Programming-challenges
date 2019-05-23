    var maleNames = ["Simon", "Matt", "Simon", "Daniel", "Sam"];
    var femaleNames = ["Georgia", "Jenny", "Sarah", "Sally", "Mary"];
    var lastNames = ["Smith", "Hill", "Doe", "Lee", "Tucker"];

function maleButton(){

    var rand1 = Math.floor(Math.random() * maleNames.length);
    var rand3 = Math.floor(Math.random() * lastNames.length);

    document.getElementById('nameDisplay').innerHTML = maleNames[rand1] + " " + lastNames[rand3];
}

function femaleButton(){
    
    var rand2 = Math.floor(Math.random() * femaleNames.length);
    var rand3 = Math.floor(Math.random() * lastNames.length);

    document.getElementById('nameDisplay').innerHTML = femaleNames[rand2] + " " + lastNames[rand3];
}