// Validar si un dato es tipo date

let fecha = new Date();
let x = '';
let y = 5;

if (fecha instanceof Date){
    console.log('La variable fecha es de tipo Date')
}else {
    console.log('La variable fecha no es tipo Date')
}
if (x instanceof Date){
    console.log('La variable x es de tipo Date')
}else {
    console.log('La variable x no es tipo Date')
}
if (y instanceof Date){
    console.log('La variable y es de tipo Date')
}else {
    console.log('La variable y no es tipo Date')
}
