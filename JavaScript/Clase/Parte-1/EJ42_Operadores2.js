// uso del operador diferente de.
// != , !===
/// 5 != 3 = true

if(5!=3){
    console.log('5 es diferente de 3')
};
if(5 != 5){
    console.log('5 es diferente de 5')
}


if(5 != '5'){
    console.log('5 es diferente de "5"')
}
if(5 !== '5'){
    console.log('5 es estrictamente diferente de "5"')
}
if (true != false){
    console.log('true es diferente de false');

}
if(true !== 1){
    console.log('true es estrictamente diferente de 1')
}

let objeto = {};
let objeto2 = {};
if (objeto != objeto2){
    console.log('objeto es diferente de objeto2')
}
let arreglo = [];
let arreglo2 = [];
if(arreglo != arreglo2){
    console.log('arreglo es diferente de arreglo2');
}
