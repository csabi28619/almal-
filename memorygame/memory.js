let playground = document.getElementById
("playground")

for(let i=0; i<16; i++){
let card = document.createElement("div")
card.classList.add("card")
playground.appendChild(card)
}