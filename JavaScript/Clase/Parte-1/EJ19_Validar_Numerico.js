// validar si una variable definida es tipo de dato numerico

let x = 5.3;
let y = Number('1.23');

let z = '';

let d = new Date();

if (typeof x === 'number'){
    console.log('La variable x es numerica ')   
}else{
    console.log('La variable x no es numerica');
}
if (typeof y === 'number'){
    console.log('La variable y es numerica ')   
}else{
    console.log('La variable y no es numerica');
}
if (typeof z === 'number'){
    console.log('La variable z es numerica ')   
}else{
    console.log('La variable z no es numerica');
}
if (typeof d === 'number'){
    console.log('La variable d es numerica ')   
}else{
    console.log('La variable d no es numerica');
}

