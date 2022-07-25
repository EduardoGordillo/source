// determinar si un tipo de dato pertenece a un objeto


let fecha = new Date();

let error = new Error();

let cadena = new String();

let objeto  = new Object();

console.log(typeof fecha)
console.log(typeof error)
console.log(typeof cadena)
console.log(typeof objeto)

console.log();

if(fecha instanceof Date){
    console.log('La variable fecha es de tipo date')
}else if(fecha instanceof Error){
    console.log('La variable fecha es de tipo error')
}else if(fecha instanceof String){
    console.log('La variable fecha es de tipo cadena')
}else{
    console.log('No se pudo determinar el tipo de dato')
}

if(error instanceof Date){
    console.log('La variable error es de tipo date')
}else if(error instanceof Error){
    console.log('La variable error es de tipo error')
}else if(error instanceof String){
    console.log('La variable error es de tipo cadena')
}else{
    console.log('No se pudo determinar el tipo de dato')
}

if(cadena instanceof Date){
    console.log('La variable cadena es de tipo date')
}else if(cadena instanceof Error){
    console.log('La variable cadena es de tipo error')
}else if(cadena instanceof String){
    console.log('La variable cadena es de tipo cadena')
}else{
    console.log('No se pudo determinar el tipo de dato')
}

if(objeto instanceof Date){
    console.log('La variable objeto es de tipo date')
}else if(objeto instanceof Error){
    console.log('La variable objeto es de tipo error')
}else if(objeto instanceof String){
    console.log('La variable objeto es de tipo cadena')
}else{
    console.log('No se pudo determinar el tipo de dato')
}