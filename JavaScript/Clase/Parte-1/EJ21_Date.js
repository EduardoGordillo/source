// crear una fecha con el objeto date

let hoy = new Date();
console.log(hoy);

let fecha = new Date('Mayo 13; 2013 03:17:19');
console.log(fecha);

fecha = new Date(2013, 05, 13);
console.log(fecha);

fecha = new Date(2013,4,13,3,17,19);
console.log(fecha);

console.log(fecha.getUTCFullYear());