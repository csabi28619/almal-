let sides = document.getElementById("sides")
let result = document.getElementById("result")
let rollNumber = document.getElementById("rollNumber")

function random(sidesNum){
    let rnd = Math.floor(Math.random()* sidesNum) + 1

    return rnd
}

function roll(){
    let numberofRolls = rollNumber.value * 1
    let sidesNum = sides.value *1

    result.innerText="|"

    for (let i = 0; i < numberofRolls; i++){
    result.innerText += random(sidesNum) +" | "
    }
}