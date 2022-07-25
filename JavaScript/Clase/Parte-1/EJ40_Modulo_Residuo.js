// hacer uso del operador modulo o resto de la division

// MOD, %

// 3 % 1 = 0 , 3 % 2 = 1, 5%7 = 5
let a = 2;
let b = 7

let modulo = a % b;
console.log(modulo);

modulo = b % a;
console.log(modulo)
 

let x = '5';
let y = '7';

modulo = x%y;
console.log(modulo);// se promociona a tipo number siempre que sea un numero

modulo = 'x' % y;
console.log(modulo);// no define ningun tipo de variable

modulo = `${x}` % y;// se puede definir con inyeccion de codigo

console.log(modulo);