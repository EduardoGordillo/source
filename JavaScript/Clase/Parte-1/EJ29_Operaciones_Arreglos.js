// realizar operaciones basicas sobre arreglos o listas
//creacion
let numeros = new Array(0,1,2,3,4);
let lenguajes = ['JavaScript', 'Python', 'Java', 'PHP'];

console.log(lenguajes.length);
//acceso

console.log(lenguajes[0]);
console.log(lenguajes[1]);
console.log(lenguajes[2]);
console.log(lenguajes[3]);
console.log();

for(let i = 0; i < lenguajes.length; i++){
    console.log(lenguajes[i]);
    
}
console.log();
for(let i = 0; i < numeros.length; i++){
    console.log(numeros[i]);
    
}
console.log();


//modificacion

lenguajes[1]= 'CSS';
for(let i = 0; i < lenguajes.length; i++){
    console.log(lenguajes[i]);
    
}

// eliminar elemento

delete lenguajes[3];// elimina el contenido pero no la posicion

lenguajes.pop();// eliminar totalmente del arreglo

for(let i = 0; i < lenguajes.length; i++){
    console.log(lenguajes[i]);
    
}
console.log();



