let playground = document.getElementById
("playground")
let cards = ["A","A",
"B","B",
"C","C",
"D","D",
"E","E",
"F","F",
"G","G",
"H","H",]

cards.sort((a,b)=>{
    let rnd = Math.random()-0.5
    return rnd
})

function test(){
    let pickeds = document.getElementsByClassName("picked")
    pickeds = Array.from("pickeds")
        console.log(pickeds)
        if (pickeds.length <2){
            return
        }else{if(pickeds[0].innerHTML === pickeds[i].innerHTML){
            alert("egyenlő")
        }else{
            pickeds[0].innerHTML = ""
            pickeds[1].innerHTML = ""
        }
        pickeds[0].classList.remove("picked")
        pickeds[1].classList.remove("picked")
    }
}

for(let i=0; i<16; i++){
let card = document.createElement("div")
card.classList.add("card")

card.onclick= () =>{
    if (document.getElementsByClassName("picked").length >= 2) {
        return
    }
    card.innerHTML = cards [i]
    card.classList.add("picked")
    test()
}

playground.appendChild(card)
}