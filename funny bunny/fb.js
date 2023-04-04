let eggs =  []


function giveMeEgg(){
let egg = document.createElement("div")
egg.classList.add("egg")

egg.onclick = () => {
    document.title= document.title*1 + 1
    egg.style.top =(Math.floor(Math.random()*-500)-100) + "px"
    }

egg.style.left = Math.floor(Math.random()*window.innerWidth) + "px"
egg.style.top = (Math.floor(Math.random()*-500)-100) + "px"



document.body.appendChild(egg)
console.log("egg created",egg)
return egg
}

document.body.appendChild(giveMeEgg())

for (let i = 0; i < 100; i++){
    eggs.push(giveMeEgg())
}

setInterval(()=>{
eggs.forEach((egg)=>{
let newTop = egg.style.top.replace("px","")*1 + 5
if (newTop > window.innerHeight + 200) {
    newTop = Math.floor(Math.random()*-500)
}
 egg.style.top = newTop + "px"

})

},20)




//I have eggs:)