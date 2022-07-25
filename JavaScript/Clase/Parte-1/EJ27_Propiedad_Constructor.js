// determinar eñ tipo de un objeto a traves de la propiedad constructor

let fecha = new Date();
let cadena = new String();

console.log(fecha.constructor);
console.log(cadena.constructor);

console.log(fecha.constructor === Date);
console.log(cadena.constructor === String);

