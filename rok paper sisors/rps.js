let playerChoise = document.getElementById("player-choise")
let enemyChoise = document.getElementById("enemy-choise")

let choiseButtons = document.getElementByIdClassName("choiseBtn")

for(let i = 0; i < choiseButtons.length; i++){
    choiseButtons[i].onClick = ()=>{
        alert(choiseButtons[i].id)
    }
}