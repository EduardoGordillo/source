// Crear instancias de objetos por medio de constructores

'JavaScript'

new String('JavaScript');

[2,3,45,566,8];
new Array(2,3,45,6,7);


function sumar(a,b){
    return a +b;
}

console.log(sumar(45,88))


let restarFunc = new Function('a', 'b', 'return a-b');

console.log(restarFunc(5,8));

{id : 24, nombre = 'juan'}
let persona = new Object();

persona.id =1;
persona.nonbre ='Ivan';

console.log(persona);

