let eggs =  []

document.title = 0

function giveMeEgg(){
let egg = document.createElement("div")
egg.classList.add("egg")

egg.onclick = () => {
document.title= document.title*1 + 1
egg.style.top =(Math.floor(Math.random()*-500)-100) + "px"
}

egg.style.left = Math.floor(Math.random()*window.innerWidth) + "px"
egg.style.top = (Math.floor(Math.random()*-500)-100) + "px"

if(Math.random()*10 <3){
egg.classList.add("rotten")

}
if(egg.classList.contains("rotten")){
    document.title = document.title*1 -100
}

document.body.appendChild(egg)
console.log("egg created",egg)
return egg
}

document.body.appendChild(giveMeEgg())

for (let i = 0; i < 10 ; i++){
    eggs.push(giveMeEgg())
}

setInterval(()=>{
eggs.forEach((egg)=>{
let newTop = egg.style.top.replace("px","")*1 + 5

if(newTop> window.innerHeight +200){
newTop = Math.floor(Math.random()*-500)

}




 egg.style.top = newTop + "px"

})

},15)







