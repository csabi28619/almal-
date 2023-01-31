function greet(name = "Anonymous"){
    console.log(" wassup hommie " + name + "!")
}

greet()
greet("Tibes")
greet(" forthynighty ila babag babag babag ila ekesz bokesz ekesz babaG ila lugitic babag")

function canDrink(age){
    if(age >=18){
    return true

    }else{
        return false}
}

function calculateAge(yearOfBirth){
    return age = 2023 -yearOfBirth
}

canDrink(calculateAge(2007))
function refreshAge(választó){

    let age = (calculateAge(választó.value))
}

function refreshAge(választó){
    let age = calculateAge(választó.value)

    document.getElementById("yearOfBirth").innerText = age

    if (canDrink (age)){
        document.body.style.backgroundColor = "green"
        alert("Ne igyál")
    }else{
        document.body.style.backgroundColor = "red"
        alert("nem")
    }

}


