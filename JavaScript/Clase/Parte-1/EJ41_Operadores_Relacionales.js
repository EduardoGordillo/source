//Uso de operadores relacionales

// < menor que

console.log(3 < 5);
//la comparacion de los operandos regresa un valor tipo booleano}
let menor = 3 < 5;
console.log(menor);

if(menor){
    console.log('3 es menor que 5');

}

if(7< 5){
    console.log('7 es menor que 5')
}else {
    console.log('la condicion es false')
}


if(5 <= 5){
    console.log('5 es menor o igual que 5')
}else {
    console.log('la condicion es false')
}
if('5' < '7'){// hace coersing con el metodo ToNumber, y lo convierte en numero siempre y cuando sea un numero

    console.log('5 es menor que 7')
}
if(NaN < '7'){
    
    console.log('NaN es menor que 7')
}

let a = 3;
let b = 5;
let c = Number('3a');
console.log(c);
console.log(Number('3a')&&Number('5')&&'3a' <= '5');
if(Math.sqrt(a)  < b){
console.log(`La raiz de ${a} es menor que ${b}`)
};
console.log()


// > Mayor  que

if(5> 3){
    console.log('5 es mayor que 3')
}

if(5.11 > 5.1){
    console.log('5.11 es mayor que 5.1')
}

if(b> a){
    console.log(`${b} es mayor que ${a}`); // literales de plantilla
}

if(3>=a){
    console.log(`3 es mayor o igual que ${a}`)
}
console.log();

// == operador igual que

if(a == b){
    console.log(`a es igual que b`)

}else {
    console.log(`${a} es diferente de ${b}`);

}

if ('JS'=='JS'){
    console.log('JS es iguaL a JS');

}

if ('7' == 7){
    console.log('"7" es igual a 7')
}
if ('true' == true){
    console.log('"true" es igual a true')
}
if (true == 1){
    console.log('true es igual a 1')
}

let objeto = {};
let otroObjeto = {};
let arreglo = [];
let otroArreglo = []

if (objeto == otroObjeto){
    console.log('objeto es igual a  otroObjeto')
}
if (objeto == {}){
    console.log('objeto es igual a {}')
}

if(arreglo == []){
    console.log('Arreglo es igual a []')
}
if(arreglo == otroArreglo){
    console.log('arreglo es igual a otroArreglo');
    
}
console.log();

// === Igualdad estricta

if('3'=== 3){// en esta condicion solo cuando son iguales los dos datos
    console.log('"3" es estrictamente igual que 3')
}else{
    console.log('"3" no es estrictamente igual que 3')
}
if (a === 3){
    console.log(`${a} es igual a 3`);
}

if(true === 1){
    console.log('true es igual a 1')
}

if(objeto === otroObjeto){
    console.log('objeto es igual a otroObjeto')
}

//objeto = otroObjeto;
if(objeto === otroObjeto){
    console.log('objeto es igual a otroObjeto')
}
let objeto1 = {nombre : 'Eduardo'};
let objeto2 = {nombre : 'Eduardo'};

if(objeto1.nombre === objeto2.nombre){
    console.log(`${objeto1.nombre} es estrictamente igual a ${objeto2.nombre}`)
}


