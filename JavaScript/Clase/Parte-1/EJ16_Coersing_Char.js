console.log(String('JavaScript'));
console.log(String(5));
console.log(typeof String(5));
console.log(typeof String(true));
console.log(String(false));

let objeto = {nombre : 'German Ortiz', id : 15491};
console.log(typeof String(objeto));

let numeros = [1,2,3,4,55];

console.log(String(numeros));
console.log(numeros.join(','));

let sumar = (a,b)=>{return a+b};

console.log(String(sumar));

console.log();

console.log(String(null));
console.log(String(undefined));

let regEx = /abc/g

console.log(String(regEx));

console.log();

objeto = {toString: function(){return 'Hola!';}};

console.log(String(objeto))
